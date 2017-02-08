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

namespace UserModule_DENON_FB
{
    public class UserModuleClass_DENON_FB : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.BufferInput RX__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput VOLUME;
        Crestron.Logos.SplusObjects.StringOutput OUT;
        Crestron.Logos.SplusObjects.StringOutput FREQNAME;
        Crestron.Logos.SplusObjects.StringOutput FREQHZ;
        ushort BUSY = 0;
        private void FN_PARSER (  SplusExecutionContext __context__, CrestronString IN__DOLLAR__ ) 
            { 
            ushort I = 0;
            
            CrestronString TEXT;
            TEXT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            
            
            __context__.SourceCodeLine = 24;
            I = (ushort) ( Functions.Find( "MV" , IN__DOLLAR__ ) ) ; 
            __context__.SourceCodeLine = 25;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Find( "MV" , IN__DOLLAR__ ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( IN__DOLLAR__ ) < 7 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 27;
                VOLUME  .Value = (ushort) ( Functions.Atoi( Functions.Mid( IN__DOLLAR__ , (int)( 3 ) , (int)( 2 ) ) ) ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 29;
                if ( Functions.TestForTrue  ( ( Functions.Find( "TFANNAME" , IN__DOLLAR__ ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 31;
                    TEXT  .UpdateValue ( Functions.Mid ( IN__DOLLAR__ ,  (int) ( 9 ) ,  (int) ( Functions.Length( IN__DOLLAR__ ) ) )  ) ; 
                    __context__.SourceCodeLine = 32;
                    FREQNAME  .UpdateValue ( Functions.Remove ( "\u000D" , TEXT )  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 34;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "TFAN0" , IN__DOLLAR__ ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 36;
                        TEXT  .UpdateValue ( Functions.Mid ( IN__DOLLAR__ ,  (int) ( 6 ) ,  (int) ( Functions.Length( IN__DOLLAR__ ) ) )  ) ; 
                        __context__.SourceCodeLine = 37;
                        TEXT  .UpdateValue ( Functions.Left ( TEXT ,  (int) ( 5 ) )  ) ; 
                        __context__.SourceCodeLine = 38;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( TEXT , (int)( 1 ) ) == "0"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 40;
                            TEXT  .UpdateValue ( Functions.Mid ( TEXT ,  (int) ( 2 ) ,  (int) ( 2 ) ) + "." + Functions.Mid ( TEXT ,  (int) ( 4 ) ,  (int) ( 5 ) )  ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 44;
                            TEXT  .UpdateValue ( Functions.Mid ( TEXT ,  (int) ( 1 ) ,  (int) ( 3 ) ) + "." + Functions.Mid ( TEXT ,  (int) ( 4 ) ,  (int) ( 5 ) )  ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 46;
                        TEXT  .UpdateValue ( "FM " + TEXT + " MHz"  ) ; 
                        __context__.SourceCodeLine = 47;
                        FREQHZ  .UpdateValue ( TEXT  ) ; 
                        } 
                    
                    }
                
                }
            
            
            }
            
        object RX__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                CrestronString STR_PARAMS;
                STR_PARAMS  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 512, this );
                
                
                __context__.SourceCodeLine = 57;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (BUSY == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 59;
                    BUSY = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 60;
                    do 
                        { 
                        __context__.SourceCodeLine = 62;
                        STR_PARAMS  .UpdateValue ( Functions.Gather ( "\u000D" , RX__DOLLAR__ )  ) ; 
                        __context__.SourceCodeLine = 63;
                        FN_PARSER (  __context__ , STR_PARAMS) ; 
                        } 
                    while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Find( "\u000D" , RX__DOLLAR__ ) == 0)) )); 
                    __context__.SourceCodeLine = 66;
                    BUSY = (ushort) ( 0 ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        VOLUME = new Crestron.Logos.SplusObjects.AnalogOutput( VOLUME__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( VOLUME__AnalogSerialOutput__, VOLUME );
        
        OUT = new Crestron.Logos.SplusObjects.StringOutput( OUT__AnalogSerialOutput__, this );
        m_StringOutputList.Add( OUT__AnalogSerialOutput__, OUT );
        
        FREQNAME = new Crestron.Logos.SplusObjects.StringOutput( FREQNAME__AnalogSerialOutput__, this );
        m_StringOutputList.Add( FREQNAME__AnalogSerialOutput__, FREQNAME );
        
        FREQHZ = new Crestron.Logos.SplusObjects.StringOutput( FREQHZ__AnalogSerialOutput__, this );
        m_StringOutputList.Add( FREQHZ__AnalogSerialOutput__, FREQHZ );
        
        RX__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( RX__DOLLAR____AnalogSerialInput__, 1000, this );
        m_StringInputList.Add( RX__DOLLAR____AnalogSerialInput__, RX__DOLLAR__ );
        
        
        RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( RX__DOLLAR___OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_DENON_FB ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint RX__DOLLAR____AnalogSerialInput__ = 0;
    const uint VOLUME__AnalogSerialOutput__ = 0;
    const uint OUT__AnalogSerialOutput__ = 1;
    const uint FREQNAME__AnalogSerialOutput__ = 2;
    const uint FREQHZ__AnalogSerialOutput__ = 3;
    
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
