using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;
using CrestronKNXLibrary.Data_Types;
using CrestronKNXLibrary.General;
using CrestronKNXLibrary.Communication;
using CrestronKNXLibrary.Routing;

namespace UserModule_CRESTRON_KNX_2_BYTE_V3_0
{
    public class UserModuleClass_CRESTRON_KNX_2_BYTE_V3_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput INITIALIZE;
        Crestron.Logos.SplusObjects.DigitalInput POLL_VALUE;
        Crestron.Logos.SplusObjects.DigitalInput SETEIS5SIGN;
        Crestron.Logos.SplusObjects.AnalogInput SETVALUE;
        Crestron.Logos.SplusObjects.AnalogInput SETEIS5VALUE;
        Crestron.Logos.SplusObjects.DigitalOutput INITIALIZATIONISCOMPLETE;
        Crestron.Logos.SplusObjects.DigitalOutput EIS5SIGN_FB;
        Crestron.Logos.SplusObjects.AnalogOutput VALUE_FB;
        Crestron.Logos.SplusObjects.AnalogOutput EIS5VALUE_FB;
        Crestron.Logos.SplusObjects.AnalogOutput EIS5MANTISSA_FB;
        Crestron.Logos.SplusObjects.AnalogOutput EIS5EXPONENT_FB;
        Crestron.Logos.SplusObjects.StringOutput EIS5VALUETEXT;
        Crestron.Logos.SplusObjects.StringOutput EIS5DECIMALVALUETEXT;
        UShortParameter IPGATEWAYID;
        StringParameter SPADDRESS;
        CrestronKNXLibrary.Data_Types.KNXTwoByteSimplSharpComponent SIMPLSHARPCOMPONENT;
        object INITIALIZE_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 88;
                SIMPLSHARPCOMPONENT . InitializeSettings ( (int)( IPGATEWAYID  .Value ), GetSymbolReferenceName() .ToString(), SPADDRESS  .ToString()) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object POLL_VALUE_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 93;
            SIMPLSHARPCOMPONENT . PollValue ( ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object SETVALUE_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 98;
        SIMPLSHARPCOMPONENT . ChangeValue ( (int)( SETVALUE  .IntValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SETEIS5VALUE_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 103;
        SIMPLSHARPCOMPONENT . ChangeEIS5Value ( (int)( SETEIS5SIGN  .Value ), (int)( SETEIS5VALUE  .IntValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void UPDATETWOBYTEVALUECALLBACK ( ushort VALUE ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 113;
        VALUE_FB  .Value = (ushort) ( VALUE ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATETWOBYTEEIS5MANTISSAVALUECALLBACK ( ushort VALUE ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 119;
        EIS5MANTISSA_FB  .Value = (ushort) ( VALUE ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATETWOBYTEEIS5EXPONENTVALUECALLBACK ( ushort VALUE ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 124;
        EIS5EXPONENT_FB  .Value = (ushort) ( VALUE ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATETWOBYTEEIS5SIGNVALUECALLBACK ( ushort VALUE ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 129;
        EIS5SIGN_FB  .Value = (ushort) ( VALUE ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATETWOBYTEEIS5ABSOLUTEVALUECALLBACK ( short VALUE ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 134;
        EIS5VALUE_FB  .Value = (ushort) ( VALUE ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATETWOBYTEEIS5ABSOLUTEVALUETEXTCALLBACK ( SimplSharpString VALUE ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 139;
        EIS5VALUETEXT  .UpdateValue ( VALUE  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATETWOBYTEEIS5DECIMALVALUETEXTCALLBACK ( SimplSharpString VALUE ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 144;
        EIS5DECIMALVALUETEXT  .UpdateValue ( VALUE  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void INITIALIZATIONISCOMPLETECALLBACK ( ushort TEMPSTATE ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 151;
        INITIALIZATIONISCOMPLETE  .Value = (ushort) ( TEMPSTATE ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void BASICINITIALIZATIONISCOMPLETEHANDLER ( ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 158;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , INITIALIZATIONISCOMPLETE , INITIALIZATIONISCOMPLETECALLBACK ) 
        SIMPLSHARPCOMPONENT .initializationIsComplete  = INITIALIZATIONISCOMPLETECALLBACK; ; 
        __context__.SourceCodeLine = 159;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATETWOBYTEVALUE , UPDATETWOBYTEVALUECALLBACK ) 
        SIMPLSHARPCOMPONENT .UpdateTwoByteValue  = UPDATETWOBYTEVALUECALLBACK; ; 
        __context__.SourceCodeLine = 160;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATETWOBYTEEIS5MANTISSAVALUE , UPDATETWOBYTEEIS5MANTISSAVALUECALLBACK ) 
        SIMPLSHARPCOMPONENT .UpdateTwoByteEIS5MantissaValue  = UPDATETWOBYTEEIS5MANTISSAVALUECALLBACK; ; 
        __context__.SourceCodeLine = 161;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATETWOBYTEEIS5EXPONENTVALUE , UPDATETWOBYTEEIS5EXPONENTVALUECALLBACK ) 
        SIMPLSHARPCOMPONENT .UpdateTwoByteEIS5ExponentValue  = UPDATETWOBYTEEIS5EXPONENTVALUECALLBACK; ; 
        __context__.SourceCodeLine = 162;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATETWOBYTEEIS5SIGNVALUE , UPDATETWOBYTEEIS5SIGNVALUECALLBACK ) 
        SIMPLSHARPCOMPONENT .UpdateTwoByteEIS5SignValue  = UPDATETWOBYTEEIS5SIGNVALUECALLBACK; ; 
        __context__.SourceCodeLine = 163;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATETWOBYTEEIS5ABSOLUTEVALUE , UPDATETWOBYTEEIS5ABSOLUTEVALUECALLBACK ) 
        SIMPLSHARPCOMPONENT .UpdateTwoByteEIS5AbsoluteValue  = UPDATETWOBYTEEIS5ABSOLUTEVALUECALLBACK; ; 
        __context__.SourceCodeLine = 164;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATETWOBYTEEIS5ABSOLUTEVALUETEXT , UPDATETWOBYTEEIS5ABSOLUTEVALUETEXTCALLBACK ) 
        SIMPLSHARPCOMPONENT .UpdateTwoByteEIS5AbsoluteValueText  = UPDATETWOBYTEEIS5ABSOLUTEVALUETEXTCALLBACK; ; 
        __context__.SourceCodeLine = 165;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATETWOBYTEEIS5DECIMALVALUETEXT , UPDATETWOBYTEEIS5DECIMALVALUETEXTCALLBACK ) 
        SIMPLSHARPCOMPONENT .UpdateTwoByteEIS5DecimalValueText  = UPDATETWOBYTEEIS5DECIMALVALUETEXTCALLBACK; ; 
        __context__.SourceCodeLine = 168;
        SIMPLSHARPCOMPONENT . BeginInitialization ( ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 181;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 182;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , BASICINITIALIZATIONISCOMPLETE , BASICINITIALIZATIONISCOMPLETEHANDLER ) 
        SIMPLSHARPCOMPONENT .basicInitializationIsComplete  = BASICINITIALIZATIONISCOMPLETEHANDLER; ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    INITIALIZE = new Crestron.Logos.SplusObjects.DigitalInput( INITIALIZE__DigitalInput__, this );
    m_DigitalInputList.Add( INITIALIZE__DigitalInput__, INITIALIZE );
    
    POLL_VALUE = new Crestron.Logos.SplusObjects.DigitalInput( POLL_VALUE__DigitalInput__, this );
    m_DigitalInputList.Add( POLL_VALUE__DigitalInput__, POLL_VALUE );
    
    SETEIS5SIGN = new Crestron.Logos.SplusObjects.DigitalInput( SETEIS5SIGN__DigitalInput__, this );
    m_DigitalInputList.Add( SETEIS5SIGN__DigitalInput__, SETEIS5SIGN );
    
    INITIALIZATIONISCOMPLETE = new Crestron.Logos.SplusObjects.DigitalOutput( INITIALIZATIONISCOMPLETE__DigitalOutput__, this );
    m_DigitalOutputList.Add( INITIALIZATIONISCOMPLETE__DigitalOutput__, INITIALIZATIONISCOMPLETE );
    
    EIS5SIGN_FB = new Crestron.Logos.SplusObjects.DigitalOutput( EIS5SIGN_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( EIS5SIGN_FB__DigitalOutput__, EIS5SIGN_FB );
    
    SETVALUE = new Crestron.Logos.SplusObjects.AnalogInput( SETVALUE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SETVALUE__AnalogSerialInput__, SETVALUE );
    
    SETEIS5VALUE = new Crestron.Logos.SplusObjects.AnalogInput( SETEIS5VALUE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SETEIS5VALUE__AnalogSerialInput__, SETEIS5VALUE );
    
    VALUE_FB = new Crestron.Logos.SplusObjects.AnalogOutput( VALUE_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( VALUE_FB__AnalogSerialOutput__, VALUE_FB );
    
    EIS5VALUE_FB = new Crestron.Logos.SplusObjects.AnalogOutput( EIS5VALUE_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( EIS5VALUE_FB__AnalogSerialOutput__, EIS5VALUE_FB );
    
    EIS5MANTISSA_FB = new Crestron.Logos.SplusObjects.AnalogOutput( EIS5MANTISSA_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( EIS5MANTISSA_FB__AnalogSerialOutput__, EIS5MANTISSA_FB );
    
    EIS5EXPONENT_FB = new Crestron.Logos.SplusObjects.AnalogOutput( EIS5EXPONENT_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( EIS5EXPONENT_FB__AnalogSerialOutput__, EIS5EXPONENT_FB );
    
    EIS5VALUETEXT = new Crestron.Logos.SplusObjects.StringOutput( EIS5VALUETEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( EIS5VALUETEXT__AnalogSerialOutput__, EIS5VALUETEXT );
    
    EIS5DECIMALVALUETEXT = new Crestron.Logos.SplusObjects.StringOutput( EIS5DECIMALVALUETEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( EIS5DECIMALVALUETEXT__AnalogSerialOutput__, EIS5DECIMALVALUETEXT );
    
    IPGATEWAYID = new UShortParameter( IPGATEWAYID__Parameter__, this );
    m_ParameterList.Add( IPGATEWAYID__Parameter__, IPGATEWAYID );
    
    SPADDRESS = new StringParameter( SPADDRESS__Parameter__, this );
    m_ParameterList.Add( SPADDRESS__Parameter__, SPADDRESS );
    
    
    INITIALIZE.OnDigitalPush.Add( new InputChangeHandlerWrapper( INITIALIZE_OnPush_0, false ) );
    POLL_VALUE.OnDigitalPush.Add( new InputChangeHandlerWrapper( POLL_VALUE_OnPush_1, false ) );
    SETVALUE.OnAnalogChange.Add( new InputChangeHandlerWrapper( SETVALUE_OnChange_2, false ) );
    SETEIS5VALUE.OnAnalogChange.Add( new InputChangeHandlerWrapper( SETEIS5VALUE_OnChange_3, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    SIMPLSHARPCOMPONENT  = new CrestronKNXLibrary.Data_Types.KNXTwoByteSimplSharpComponent();
    
    
}

public UserModuleClass_CRESTRON_KNX_2_BYTE_V3_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint INITIALIZE__DigitalInput__ = 0;
const uint POLL_VALUE__DigitalInput__ = 1;
const uint SETEIS5SIGN__DigitalInput__ = 2;
const uint SETVALUE__AnalogSerialInput__ = 0;
const uint SETEIS5VALUE__AnalogSerialInput__ = 1;
const uint INITIALIZATIONISCOMPLETE__DigitalOutput__ = 0;
const uint EIS5SIGN_FB__DigitalOutput__ = 1;
const uint VALUE_FB__AnalogSerialOutput__ = 0;
const uint EIS5VALUE_FB__AnalogSerialOutput__ = 1;
const uint EIS5MANTISSA_FB__AnalogSerialOutput__ = 2;
const uint EIS5EXPONENT_FB__AnalogSerialOutput__ = 3;
const uint EIS5VALUETEXT__AnalogSerialOutput__ = 4;
const uint EIS5DECIMALVALUETEXT__AnalogSerialOutput__ = 5;
const uint IPGATEWAYID__Parameter__ = 10;
const uint SPADDRESS__Parameter__ = 11;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
