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

namespace UserModule_GUI_PROCCESOR
{
    public class UserModuleClass_GUI_PROCCESOR : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput SWYPE_UP;
        Crestron.Logos.SplusObjects.DigitalInput SWYPE_DW;
        Crestron.Logos.SplusObjects.DigitalInput SWYPE_LF;
        Crestron.Logos.SplusObjects.DigitalInput SWYPE_RG;
        Crestron.Logos.SplusObjects.DigitalInput SWYPE_RESET_UP_DW;
        Crestron.Logos.SplusObjects.DigitalInput SWYPE_RESET_LF_RG;
        Crestron.Logos.SplusObjects.DigitalOutput SWYPE_UP_GUI;
        Crestron.Logos.SplusObjects.DigitalOutput SWYPE_DW_GUI;
        Crestron.Logos.SplusObjects.DigitalOutput SWYPE_LF_GUI;
        Crestron.Logos.SplusObjects.DigitalOutput SWYPE_RG_GUI;
        object SWYPE_UP_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 159;
                if ( Functions.TestForTrue  ( ( SWYPE_DW_GUI  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 161;
                    SWYPE_DW_GUI  .Value = (ushort) ( 0 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 165;
                    SWYPE_UP_GUI  .Value = (ushort) ( 1 ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object SWYPE_DW_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 171;
            if ( Functions.TestForTrue  ( ( SWYPE_UP_GUI  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 173;
                SWYPE_UP_GUI  .Value = (ushort) ( 0 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 177;
                SWYPE_DW_GUI  .Value = (ushort) ( 1 ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object SWYPE_LF_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 183;
        if ( Functions.TestForTrue  ( ( SWYPE_RG_GUI  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 185;
            SWYPE_RG_GUI  .Value = (ushort) ( 0 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 189;
            SWYPE_LF_GUI  .Value = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SWYPE_RG_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 195;
        if ( Functions.TestForTrue  ( ( SWYPE_LF_GUI  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 197;
            SWYPE_LF_GUI  .Value = (ushort) ( 0 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 201;
            SWYPE_RG_GUI  .Value = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SWYPE_RESET_UP_DW_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 207;
        SWYPE_UP_GUI  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 208;
        SWYPE_DW_GUI  .Value = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SWYPE_RESET_LF_RG_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 212;
        SWYPE_LF_GUI  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 213;
        SWYPE_RG_GUI  .Value = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 273;
        WaitForInitializationComplete ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    SWYPE_UP = new Crestron.Logos.SplusObjects.DigitalInput( SWYPE_UP__DigitalInput__, this );
    m_DigitalInputList.Add( SWYPE_UP__DigitalInput__, SWYPE_UP );
    
    SWYPE_DW = new Crestron.Logos.SplusObjects.DigitalInput( SWYPE_DW__DigitalInput__, this );
    m_DigitalInputList.Add( SWYPE_DW__DigitalInput__, SWYPE_DW );
    
    SWYPE_LF = new Crestron.Logos.SplusObjects.DigitalInput( SWYPE_LF__DigitalInput__, this );
    m_DigitalInputList.Add( SWYPE_LF__DigitalInput__, SWYPE_LF );
    
    SWYPE_RG = new Crestron.Logos.SplusObjects.DigitalInput( SWYPE_RG__DigitalInput__, this );
    m_DigitalInputList.Add( SWYPE_RG__DigitalInput__, SWYPE_RG );
    
    SWYPE_RESET_UP_DW = new Crestron.Logos.SplusObjects.DigitalInput( SWYPE_RESET_UP_DW__DigitalInput__, this );
    m_DigitalInputList.Add( SWYPE_RESET_UP_DW__DigitalInput__, SWYPE_RESET_UP_DW );
    
    SWYPE_RESET_LF_RG = new Crestron.Logos.SplusObjects.DigitalInput( SWYPE_RESET_LF_RG__DigitalInput__, this );
    m_DigitalInputList.Add( SWYPE_RESET_LF_RG__DigitalInput__, SWYPE_RESET_LF_RG );
    
    SWYPE_UP_GUI = new Crestron.Logos.SplusObjects.DigitalOutput( SWYPE_UP_GUI__DigitalOutput__, this );
    m_DigitalOutputList.Add( SWYPE_UP_GUI__DigitalOutput__, SWYPE_UP_GUI );
    
    SWYPE_DW_GUI = new Crestron.Logos.SplusObjects.DigitalOutput( SWYPE_DW_GUI__DigitalOutput__, this );
    m_DigitalOutputList.Add( SWYPE_DW_GUI__DigitalOutput__, SWYPE_DW_GUI );
    
    SWYPE_LF_GUI = new Crestron.Logos.SplusObjects.DigitalOutput( SWYPE_LF_GUI__DigitalOutput__, this );
    m_DigitalOutputList.Add( SWYPE_LF_GUI__DigitalOutput__, SWYPE_LF_GUI );
    
    SWYPE_RG_GUI = new Crestron.Logos.SplusObjects.DigitalOutput( SWYPE_RG_GUI__DigitalOutput__, this );
    m_DigitalOutputList.Add( SWYPE_RG_GUI__DigitalOutput__, SWYPE_RG_GUI );
    
    
    SWYPE_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( SWYPE_UP_OnPush_0, false ) );
    SWYPE_DW.OnDigitalPush.Add( new InputChangeHandlerWrapper( SWYPE_DW_OnPush_1, false ) );
    SWYPE_LF.OnDigitalPush.Add( new InputChangeHandlerWrapper( SWYPE_LF_OnPush_2, false ) );
    SWYPE_RG.OnDigitalPush.Add( new InputChangeHandlerWrapper( SWYPE_RG_OnPush_3, false ) );
    SWYPE_RESET_UP_DW.OnDigitalPush.Add( new InputChangeHandlerWrapper( SWYPE_RESET_UP_DW_OnPush_4, false ) );
    SWYPE_RESET_LF_RG.OnDigitalPush.Add( new InputChangeHandlerWrapper( SWYPE_RESET_LF_RG_OnPush_5, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_GUI_PROCCESOR ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint SWYPE_UP__DigitalInput__ = 0;
const uint SWYPE_DW__DigitalInput__ = 1;
const uint SWYPE_LF__DigitalInput__ = 2;
const uint SWYPE_RG__DigitalInput__ = 3;
const uint SWYPE_RESET_UP_DW__DigitalInput__ = 4;
const uint SWYPE_RESET_LF_RG__DigitalInput__ = 5;
const uint SWYPE_UP_GUI__DigitalOutput__ = 0;
const uint SWYPE_DW_GUI__DigitalOutput__ = 1;
const uint SWYPE_LF_GUI__DigitalOutput__ = 2;
const uint SWYPE_RG_GUI__DigitalOutput__ = 3;

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
