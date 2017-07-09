/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.6
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace libsbml {

 using System;
 using System.Runtime.InteropServices;

/** 
 * @sbmlpackage{core}
 *
@htmlinclude pkg-marker-core.html A <em>compartment type</em> in SBML Level&nbsp;2.
 *
 * SBML Level&nbsp;2 Versions&nbsp;2&ndash;4 provide the <em>compartment
 * type</em> as a grouping construct that can be used to establish a
 * relationship between multiple Compartment objects.  A CompartmentType
 * object only has an identity, and this identity can only be used to
 * indicate that particular Compartment objects in the model belong to this
 * type.  This may be useful for conveying a modeling intention, such as
 * when a model contains many similar compartments, either by their
 * biological function or the reactions they carry.  Without a compartment
 * type construct, it would be impossible within SBML itself to indicate
 * that all of the compartments share an underlying conceptual relationship
 * because each SBML compartment must be given a unique and separate
 * identity.  Compartment types have no mathematical meaning in
 * SBML---they have no effect on a model's mathematical interpretation.
 * Simulators and other numerical analysis software may ignore
 * CompartmentType definitions and references to them in a model.
 * 
 * There is no mechanism in SBML Level 2 for representing hierarchies of
 * compartment types.  One CompartmentType instance cannot be the subtype
 * of another CompartmentType instance; SBML provides no means of defining
 * such relationships.
 * 
 * As with other major structures in SBML, CompartmentType has a mandatory
 * attribute, 'id', used to give the compartment type an identifier.  The
 * identifier must be a text %string conforming to the identifer syntax
 * permitted in SBML.  CompartmentType also has an optional 'name'
 * attribute, of type @c string.  The 'id' and 'name' must be used
 * according to the guidelines described in the SBML specification (e.g.,
 * Section 3.3 in the Level 2 Version 4 specification).
 *
 * CompartmentType was introduced in SBML Level 2 Version 2.  It is not
 * available in SBML Level&nbsp;1 nor in Level&nbsp;3.
 *
 * @see Compartment
 * @see ListOfCompartmentTypes
 * @see SpeciesType
 * @see ListOfSpeciesTypes
 *
 * 
 * 
 */

public class CompartmentType : SBase {
	private HandleRef swigCPtr;
	
	internal CompartmentType(IntPtr cPtr, bool cMemoryOwn) : base(libsbmlPINVOKE.CompartmentType_SWIGUpcast(cPtr), cMemoryOwn)
	{
		//super(libsbmlPINVOKE.CompartmentTypeUpcast(cPtr), cMemoryOwn);
		swigCPtr = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(CompartmentType obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (CompartmentType obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~CompartmentType() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_CompartmentType(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  
/**
   * Creates a new CompartmentType object using the given SBML @p level and
   * @p version values.
   *
   * @param level a long integer, the SBML Level to assign to this
   * CompartmentType
   *
   * @param version a long integer, the SBML Version to assign to this
   * CompartmentType
   *
   *
 * @throws SBMLConstructorException
 * Thrown if the given @p level and @p version combination are invalid
 * or if this object is incompatible with the given level and version.
 *
 *
   *
   *
 * @note Attempting to add an object to an SBMLDocument having a different
 * combination of SBML Level, Version and XML namespaces than the object
 * itself will result in an error at the time a caller attempts to make the
 * addition.  A parent object must have compatible Level, Version and XML
 * namespaces.  (Strictly speaking, a parent may also have more XML
 * namespaces than a child, but the reverse is not permitted.)  The
 * restriction is necessary to ensure that an SBML model has a consistent
 * overall structure.  This requires callers to manage their objects
 * carefully, but the benefit is increased flexibility in how models can be
 * created by permitting callers to create objects bottom-up if desired.  In
 * situations where objects are not yet attached to parents (e.g.,
 * SBMLDocument), knowledge of the intented SBML Level and Version help
 * libSBML determine such things as whether it is valid to assign a
 * particular value to an attribute.
 *
 *
   */ public
 CompartmentType(long level, long version) : this(libsbmlPINVOKE.new_CompartmentType__SWIG_0(level, version), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates a new CompartmentType object using the given SBMLNamespaces
   * object @p sbmlns.
   *
   *
 * 
 * The SBMLNamespaces object encapsulates SBML Level/Version/namespaces
 * information.  It is used to communicate the SBML Level, Version, and (in
 * Level&nbsp;3) packages used in addition to SBML Level&nbsp;3 Core.  A
 * common approach to using libSBML's SBMLNamespaces facilities is to create an
 * SBMLNamespaces object somewhere in a program once, then hand that object
 * as needed to object constructors that accept SBMLNamespaces as arguments.
 *
 *
   *
   * It is worth emphasizing that although this constructor does not take an
   * identifier argument, in SBML Level&nbsp;2 and beyond, the 'id'
   * (identifier) attribute of a CompartmentType object is required to have a
   * value.  Thus, callers are cautioned to assign a value after calling this
   * constructor.  Setting the identifier can be accomplished using the
   * method setId(@if java String@endif).
   *
   * @param sbmlns an SBMLNamespaces object.
   *
   *
 * @throws SBMLConstructorException
 * Thrown if the given @p sbmlns is inconsistent or incompatible
 * with this object.
 *
 *
   *
   *
 * @note Attempting to add an object to an SBMLDocument having a different
 * combination of SBML Level, Version and XML namespaces than the object
 * itself will result in an error at the time a caller attempts to make the
 * addition.  A parent object must have compatible Level, Version and XML
 * namespaces.  (Strictly speaking, a parent may also have more XML
 * namespaces than a child, but the reverse is not permitted.)  The
 * restriction is necessary to ensure that an SBML model has a consistent
 * overall structure.  This requires callers to manage their objects
 * carefully, but the benefit is increased flexibility in how models can be
 * created by permitting callers to create objects bottom-up if desired.  In
 * situations where objects are not yet attached to parents (e.g.,
 * SBMLDocument), knowledge of the intented SBML Level and Version help
 * libSBML determine such things as whether it is valid to assign a
 * particular value to an attribute.
 *
 *
   */ public
 CompartmentType(SBMLNamespaces sbmlns) : this(libsbmlPINVOKE.new_CompartmentType__SWIG_1(SBMLNamespaces.getCPtr(sbmlns)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Copy constructor; creates a copy of this CompartmentType object.
   *
   * @param orig the object to copy.
   */ public
 CompartmentType(CompartmentType orig) : this(libsbmlPINVOKE.new_CompartmentType__SWIG_2(CompartmentType.getCPtr(orig)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates and returns a deep copy of this CompartmentType object.
   *
   * @return the (deep) copy of this CompartmentType object.
   */ public new
 CompartmentType clone() {
    IntPtr cPtr = libsbmlPINVOKE.CompartmentType_clone(swigCPtr);
    CompartmentType ret = (cPtr == IntPtr.Zero) ? null : new CompartmentType(cPtr, true);
    return ret;
  }

  
/**
   * Returns the value of the 'id' attribute of this CompartmentType object.
   *
   * @return the identifier of this CompartmentType object.
   *
   * @see getName()
   * @see setId(@if java String@endif)
   * @see unsetId()
   * @see isSetId()
   */ public new
 string getId() {
    string ret = libsbmlPINVOKE.CompartmentType_getId(swigCPtr);
    return ret;
  }

  
/**
   * Returns the value of the 'name' attribute of this CompartmentType
   * object.
   *
   * @return the name of this CompartmentType object.
   *
   * @see getId()
   * @see isSetName()
   * @see setName(@if java String@endif)
   * @see unsetName()
   */ public new
 string getName() {
    string ret = libsbmlPINVOKE.CompartmentType_getName(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if this CompartmentType object's 'id'
   * attribute is set.
   *
   * @return @c true if the 'id' attribute of this CompartmentType object is
   * set, @c false otherwise.
   *
   * @see getId()
   * @see unsetId()
   * @see setId(@if java String@endif)
   */ public new
 bool isSetId() {
    bool ret = libsbmlPINVOKE.CompartmentType_isSetId(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if this CompartmentType object's 'name'
   * attribute is set.
   *
   * @return @c true if the 'name' attribute of this CompartmentType object
   * is set, @c false otherwise.
   *
   * @see getName()
   * @see setName(@if java String@endif)
   * @see unsetName()
   */ public new
 bool isSetName() {
    bool ret = libsbmlPINVOKE.CompartmentType_isSetName(swigCPtr);
    return ret;
  }

  
/**
   * Sets the value of the 'id' attribute of this CompartmentType object.
   *
   * The string @p sid is copied.
   *
   *
 * 
 * SBML has strict requirements for the syntax of identifiers, that is, the
 * values of the 'id' attribute present on most types of SBML objects.
 * The following is a summary of the definition of the SBML identifier type
 * <code>SId</code>, which defines the permitted syntax of identifiers.  We
 * express the syntax using an extended form of BNF notation:
 * <pre style='margin-left: 2em; border: none; font-weight: bold; font-size: 13px; color: black'>
 * letter ::= 'a'..'z','A'..'Z'
 * digit  ::= '0'..'9'
 * idChar ::= letter | digit | '_'
 * SId    ::= ( letter | '_' ) idChar*</pre>
 * The characters <code>(</code> and <code>)</code> are used for grouping, the
 * character <code>*</code> 'zero or more times', and the character
 * <code>|</code> indicates logical 'or'.  The equality of SBML identifiers is
 * determined by an exact character sequence match; i.e., comparisons must be
 * performed in a case-sensitive manner.  In addition, there are a few
 * conditions for the uniqueness of identifiers in an SBML model.  Please
 * consult the SBML specifications for the exact details of the uniqueness
 * requirements.
 *
 *
   *
   * @param sid the string to use as the identifier of this CompartmentType
   *
   *
 * @return integer value indicating success/failure of the
 * function.  @if clike The value is drawn from the
 * enumeration #OperationReturnValues_t. @endif The possible values
 * returned by this function are:
 * @li @link libsbml#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   * @li @link libsbml#LIBSBML_INVALID_ATTRIBUTE_VALUE LIBSBML_INVALID_ATTRIBUTE_VALUE@endlink
   *
   * @see getId()
   * @see unsetId()
   * @see isSetId()
   */ public new
 int setId(string sid) {
    int ret = libsbmlPINVOKE.CompartmentType_setId(swigCPtr, sid);
    return ret;
  }

  
/**
   * Sets the value of the 'name' attribute of this CompartmentType object.
   *
   * The string in @p name is copied.
   *
   * @param name the new name for the CompartmentType
   *
   *
 * @return integer value indicating success/failure of the
 * function.  @if clike The value is drawn from the
 * enumeration #OperationReturnValues_t. @endif The possible values
 * returned by this function are:
 * @li @link libsbml#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   * @li @link libsbml#LIBSBML_INVALID_ATTRIBUTE_VALUE LIBSBML_INVALID_ATTRIBUTE_VALUE@endlink
   *
   * @see getName()
   * @see isSetName()
   * @see unsetName()
   */ public new
 int setName(string name) {
    int ret = libsbmlPINVOKE.CompartmentType_setName(swigCPtr, name);
    return ret;
  }

  
/**
   * Unsets the value of the 'name' attribute of this CompartmentType object.
   *
   *
 * @return integer value indicating success/failure of the
 * function.  @if clike The value is drawn from the
 * enumeration #OperationReturnValues_t. @endif The possible values
 * returned by this function are:
 * @li @link libsbml#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   * @li @link libsbml#LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED@endlink
   *
   * @see getName()
   * @see setName(@if java String@endif)
   * @see isSetName()
   */ public new
 int unsetName() {
    int ret = libsbmlPINVOKE.CompartmentType_unsetName(swigCPtr);
    return ret;
  }

  
/**
   * Returns the libSBML type code for this SBML object.
   *
   *
 * 
 * LibSBML attaches an identifying code to every kind of SBML object.  These
 * are integer constants known as <em>SBML type codes</em>.  The names of all
 * the codes begin with the characters <code>SBML_</code>.
 * @if clike The set of possible type codes for core elements is defined in
 * the enumeration #SBMLTypeCode_t, and in addition, libSBML plug-ins for
 * SBML Level&nbsp;3 packages define their own extra enumerations of type
 * codes (e.g., #SBMLLayoutTypeCode_t for the Level&nbsp;3 Layout
 * package).@endif@if java In the Java language interface for libSBML, the
 * type codes are defined as static integer constants in the interface class
 * {@link libsbmlConstants}.  @endif@if python In the Python language
 * interface for libSBML, the type codes are defined as static integer
 * constants in the interface class @link libsbml@endlink.@endif@if csharp In
 * the C# language interface for libSBML, the type codes are defined as
 * static integer constants in the interface class
 * @link libsbmlcs.libsbml@endlink.@endif  Note that different Level&nbsp;3
 * package plug-ins may use overlapping type codes; to identify the package
 * to which a given object belongs, call the <code>getPackageName()</code>
 * method on the object.
 *
 *
   *
   * @return the SBML type code for this object:
   * @link libsbml#SBML_COMPARTMENT_TYPE SBML_COMPARTMENT_TYPE@endlink (default).
   *
   *
 * @warning <span class='warning'>The specific integer values of the possible
 * type codes may be reused by different libSBML plug-ins for SBML Level&nbsp;3.
 * packages,  To fully identify the correct code, <strong>it is necessary to
 * invoke both getTypeCode() and getPackageName()</strong>.</span>
 *
 *
   *
   * @see getElementName()
   * @see getPackageName()
   */ public new
 int getTypeCode() {
    int ret = libsbmlPINVOKE.CompartmentType_getTypeCode(swigCPtr);
    return ret;
  }

  
/**
   * Returns the XML element name of this object
   *
   * For CompartmentType, the element name is always @c 'compartmentType'.
   *
   * @return the name of this element.
   *
   * @see getTypeCode()
   * @see getPackageName()
   */ public new
 string getElementName() {
    string ret = libsbmlPINVOKE.CompartmentType_getElementName(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if all the required attributes for this
   * CompartmentType object have been set.
   *
   * The required attributes for a CompartmentType object are:
   * @li 'id'
   *
   * @return @c true if the required attributes have been set, @c false
   * otherwise.
   */ public new
 bool hasRequiredAttributes() {
    bool ret = libsbmlPINVOKE.CompartmentType_hasRequiredAttributes(swigCPtr);
    return ret;
  }

}

}
