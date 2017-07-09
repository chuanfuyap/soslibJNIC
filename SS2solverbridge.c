#ifdef HAVE_CONFIG_H
#include "config.h"
#endif

#include <stdio.h>
#include <stdlib.h>
#include <assert.h>

#include "solverLibraries/include/sbmlsolver/odeSolver.h"
#include "solverLibraries/include/sbmlsolver/sbmlResults.h"
#include "solverLibraries/include/sbmlsolver/solverError.h"

typedef struct output {
    double* vals;
} output;

output runSolver2 (const char* filelink, const char* variable, int numVals,const double* newparameter,  const char* paranames,  int paramcount, const char* reactionID)
{
    int j; 
    int i;
    output out;
    
    assert(NULL != variable);
    assert(NULL != paranames);
    assert(NULL != reactionID);
    int offset = 0;

    out.vals = (double*)malloc(sizeof(double) * numVals);
    memset(out.vals, 0, sizeof(double) * numVals);  
    
    const char** specieslist =malloc(numVals * sizeof(char*));//freed
    const char** paralist = malloc(paramcount * sizeof(char*));//freed
    const char** rID = malloc(paramcount * sizeof(char*));//freed
    
    for(j=0; j<paramcount; j++){
      paralist[j]=malloc(sizeof(char*));
      rID[j]=malloc(sizeof(char*));
    }
    offset = 0;
    for(j=0; j<paramcount; j++){
      paralist[j]=paranames + offset;
      offset += strlen(paralist[j]) + 1;
    }
    offset = 0;
    for(j=0; j<paramcount; j++){
      rID[j]=reactionID + offset;
      offset += strlen(rID[j]) + 1;
    }
    
    for(j=0; j<numVals; j++){
      specieslist[j]=malloc(sizeof(char*));
    }
    offset = 0;
    for(j=0; j<numVals; j++){
      specieslist[j]=variable + offset;
      offset += strlen(specieslist[j]) + 1;
    }
    
    SBMLReader_t *sr = SBMLReader_create(); //freed
    SBMLDocument_t *d = SBMLReader_readSBML(sr, filelink); //freed
    Model_t *sbml = SBMLDocument_getModel(d); //freed
    SBMLReader_free(sr); 
    
    cvodeSettings_t *options = CvodeSettings_createWithTime(100000000, 1); //freed
    CvodeSettings_setHaltOnSteadyState(options, 1);
    varySettings_t *parameters = VarySettings_allocate(paramcount,1);
    
    for(i=0; i<paramcount;i++){
        VarySettings_setName(parameters, i, paralist[i], rID[i]);
        VarySettings_setValue(parameters, 0, i, newparameter[i]);
    }
    
/*
    SBMLResultsArray_t *arrayresults = Model_odeSolverBatch(sbml, options, parameters); //freed
*/
    
    SBMLResults_t *results = SBMLResultsArray_getResults(Model_odeSolverBatch(sbml, options, parameters), 0);
    
/*
    SBMLResults_t *results = SBMLResultsArray_getResults(arrayresults, 0);
*/
    
    
    if ( results != NULL )
    {
        for ( i=0; i<numVals; i++ ){
            out.vals[i] = TimeCourse_getValue( Species_getTimeCourse(Model_getSpeciesById(sbml, specieslist[i]), results), 1 );
        }
    }
    
/*
    SolverError_dumpAndClearErrors();
*/
    SBMLResults_free(results);
/*
    SBMLResultsArray_free(arrayresults);
*/
    CvodeSettings_free(options);
    VarySettings_free(parameters);
    SBMLDocument_free(d);
    
    return out;
}

void outputCleanup2(double* array)
{
    free(array);
}
