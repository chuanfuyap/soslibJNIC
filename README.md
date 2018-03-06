These are c scripts and the library (.so) written to be called by JNA code found in GRaPe2.
These are scripts written to call SOSLib for ode solution of sbml models, hence vital for GRaPe's Genetic Algorithm to function.

Download the and compile the it into a library file and put them into a folder called "lib" to be created next to the compiled GRaPe2 jar file for the software to work accordingly/

ALTERNATIVELY, remember the path of the file, which will be named 'sosLibLinkv3.so' by default, (you can rename it in the config files in nbproject folder). Remember the path and make changes to the path in src/odeBridge/SSodesolve.java line 34 and src/odeBridge/TCodesolve.java lines 38.

!!!If necessary, change the path for libsbml.so, libODEs.so and SBMLOdesolver files depending on where you have set the output when compiling the libsbml, sundials and SBML ODE Solver libraries.
Make the changes to configurations.xml and Makefile-Debug.mk within the nbproject folder before compiling so the library know where to the libraries needed.

