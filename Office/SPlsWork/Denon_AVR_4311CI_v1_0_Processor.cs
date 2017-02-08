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

namespace CrestronModule_DENON_AVR_4311CI_V1_0_PROCESSOR
{
    public class CrestronModuleClass_DENON_AVR_4311CI_V1_0_PROCESSOR : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput AM_ENABLED;
        Crestron.Logos.SplusObjects.DigitalInput FM_ENABLED;
        Crestron.Logos.SplusObjects.DigitalInput AM_HD_ENABLED;
        Crestron.Logos.SplusObjects.DigitalInput FM_HD_ENABLED;
        Crestron.Logos.SplusObjects.DigitalInput SENDMAIN;
        Crestron.Logos.SplusObjects.DigitalInput SENDZONE2;
        Crestron.Logos.SplusObjects.DigitalInput SENDZONE3;
        Crestron.Logos.SplusObjects.DigitalInput IPOD;
        Crestron.Logos.SplusObjects.DigitalInput USB;
        Crestron.Logos.SplusObjects.DigitalInput ENTER_AM_FM;
        Crestron.Logos.SplusObjects.DigitalInput ENTER_HD;
        Crestron.Logos.SplusObjects.DigitalInput ENTER_XM;
        Crestron.Logos.SplusObjects.DigitalInput ENTER_DAB;
        Crestron.Logos.SplusObjects.DigitalInput ENTER_SIRIUS;
        Crestron.Logos.SplusObjects.BufferInput DIRECT_KEY_AM_FM__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput DIRECT_KEY_HD__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput DIRECT_KEY_XM__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput DIRECT_KEY_DAB__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput DIRECT_KEY_SIRIUS__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput FROMDEVICE__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput MAINLEVEL;
        Crestron.Logos.SplusObjects.AnalogOutput ZONE2LEVEL;
        Crestron.Logos.SplusObjects.AnalogOutput ZONE3LEVEL;
        Crestron.Logos.SplusObjects.StringOutput MAINLEVEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput ZONE2LEVEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput ZONE3LEVEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput FLLEVEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput FRLEVEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CLEVEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SWLEVEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SW2LEVEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SLLEVEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SRLEVEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SBLLEVEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SBRLEVEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SBLEVEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput FHLLEVEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput FHRLEVEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput FWLLEVEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput FWRLEVEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput ANALOG_TUNER_FREQUENCY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_TUNER_FREQUENCY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput XM_TUNER_FREQUENCY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DAB_TUNER_FREQUENCY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SIRIUS_TUNER_FREQUENCY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput AM_FM_PRESET__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_PRESET__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_STATION_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_STATION_NAME_LONG__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_SIGNAL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_MULTICAST_CURRENT_CH__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_MULTICAST_CH__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_PROGRAM_TYPE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_ARTIST__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_TITLE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_ALBUM__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_GENRE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput XM_PRESET__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput XM_CHANNEL_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput XM_ARTIST__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput XM_TITLE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput XM_RADIO_ID__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput XM_SIGNAL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DAB_STATION_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DAB_STATION_NAME_LONG__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DAB_ENSEMBLE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DAB_PROGRAM_TYPE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DAB_CHANNEL_CH__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DAB_FREQUENCY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DAB_MODE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DAB_SIGNAL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DAB_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DAB_DATE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SIRIUS_PRESET__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SIRIUS_CHANNEL_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SIRIUS_ARTIST__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SIRIUS_TITLE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SIRIUS_RADIO_ID__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SIRIUS_SIGNAL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput IPOD_LINE_0__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput IPOD_LINE_1__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput IPOD_LINE_2__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput IPOD_LINE_3__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput IPOD_LINE_4__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput IPOD_LINE_5__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput IPOD_LINE_6__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput IPOD_LINE_7__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput IPOD_LINE_8__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput IPOD_LINE_9__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput USB_NSA_LINE_0__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput USB_NSA_LINE_1__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput USB_NSA_LINE_2__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput USB_NSA_LINE_3__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput USB_NSA_LINE_4__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput USB_NSA_LINE_5__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput USB_NSA_LINE_6__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput USB_NSA_LINE_7__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput USB_NSA_LINE_8__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MSERVER_LINE_0__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MSERVER_LINE_1__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MSERVER_LINE_2__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MSERVER_LINE_3__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MSERVER_LINE_4__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MSERVER_LINE_5__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MSERVER_LINE_6__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MSERVER_LINE_7__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MSERVER_LINE_8__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECT_COMMAND_VALUE_DISPLAYED_AM_FM__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECT_COMMAND_VALUE_DISPLAYED_HD__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECT_COMMAND_VALUE_DISPLAYED_XM__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECT_COMMAND_VALUE_DISPLAYED_DAB__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECT_COMMAND_VALUE_DISPLAYED_SIRIUS__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECT_COMMAND__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MUTE_MAIN__DOLLAR__;
        ushort LEVEL = 0;
        ushort SEMAPHORE = 0;
        ushort FL = 0;
        ushort FR = 0;
        ushort SL = 0;
        ushort SR = 0;
        ushort SBL = 0;
        ushort SBR = 0;
        ushort C = 0;
        ushort SW = 0;
        ushort SB = 0;
        ushort FREQHI = 0;
        ushort FREQLO = 0;
        ushort ISTRINGLENGTH = 0;
        ushort HDVALUE = 0;
        ushort AMFMVALUE = 0;
        CrestronString TEMPSTRING__DOLLAR__;
        CrestronString COMMAND__DOLLAR__;
        CrestronString SUB__DOLLAR__;
        CrestronString SUB3__DOLLAR__;
        CrestronString MAINLEVELINT__DOLLAR__;
        CrestronString ZONE2LEVELINT__DOLLAR__;
        CrestronString MAINLEVELSENT__DOLLAR__;
        CrestronString ZONE2LEVELSENT__DOLLAR__;
        CrestronString ZONE3LEVELINT__DOLLAR__;
        CrestronString ZONE3LEVELSENT__DOLLAR__;
        CrestronString ZONE4LEVELINT__DOLLAR__;
        CrestronString FROMDEVICETEMP__DOLLAR__;
        private CrestronString CALCULATEVOLUMETEXT (  SplusExecutionContext __context__, ushort VALUE ) 
            { 
            CrestronString TEXT__DOLLAR__;
            TEXT__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            
            CrestronString VALUE__DOLLAR__;
            VALUE__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
            
            ushort REMAINDER = 0;
            
            
            __context__.SourceCodeLine = 105;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( VALUE >= 800 ))  ) ) 
                {
                __context__.SourceCodeLine = 106;
                MakeString ( TEXT__DOLLAR__ , "{0:d}.{1:d} dB", (ushort)((VALUE - 800) / 10), (ushort)Mod( (VALUE - 800) , 10 )) ; 
                }
            
            else 
                { 
                __context__.SourceCodeLine = 109;
                VALUE = (ushort) ( Functions.ToInteger( -( (VALUE - 800) ) ) ) ; 
                __context__.SourceCodeLine = 110;
                MakeString ( VALUE__DOLLAR__ , "{0:d3}\r\n", (ushort)VALUE) ; 
                __context__.SourceCodeLine = 111;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Mod( VALUE , 10 ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 112;
                    MakeString ( TEXT__DOLLAR__ , "- {0:d}.5 dB", (ushort)(VALUE / 10)) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 114;
                    MakeString ( TEXT__DOLLAR__ , "- {0:d}.0 dB", (ushort)(VALUE / 10)) ; 
                    }
                
                } 
            
            __context__.SourceCodeLine = 116;
            return ( TEXT__DOLLAR__ ) ; 
            
            }
            
        private CrestronString CALCULATECHANNELTEXT (  SplusExecutionContext __context__, ushort VALUE ) 
            { 
            CrestronString TEXT__DOLLAR__;
            TEXT__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            
            CrestronString VALUE__DOLLAR__;
            VALUE__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
            
            ushort REMAINDER = 0;
            
            
            __context__.SourceCodeLine = 125;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( VALUE >= 500 ))  ) ) 
                {
                __context__.SourceCodeLine = 126;
                MakeString ( TEXT__DOLLAR__ , "{0:d}.{1:d} dB", (ushort)((VALUE - 500) / 10), (ushort)Mod( (VALUE - 500) , 10 )) ; 
                }
            
            else 
                { 
                __context__.SourceCodeLine = 129;
                VALUE = (ushort) ( Functions.ToInteger( -( (VALUE - 500) ) ) ) ; 
                __context__.SourceCodeLine = 130;
                MakeString ( VALUE__DOLLAR__ , "{0:d3}\r\n", (ushort)VALUE) ; 
                __context__.SourceCodeLine = 131;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Mod( VALUE , 10 ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 132;
                    MakeString ( TEXT__DOLLAR__ , "- {0:d}.5 dB", (ushort)(VALUE / 10)) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 134;
                    MakeString ( TEXT__DOLLAR__ , "- {0:d}.0 dB", (ushort)(VALUE / 10)) ; 
                    }
                
                } 
            
            __context__.SourceCodeLine = 136;
            return ( TEXT__DOLLAR__ ) ; 
            
            }
            
        private CrestronString REMOVENULLS (  SplusExecutionContext __context__, CrestronString SSTRING , ushort ICURSOR ) 
            { 
            CrestronString STEMP__DOLLAR__;
            STEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
            
            ushort A = 0;
            ushort INULLLOCATION = 0;
            ushort ILENGTH = 0;
            
            
            __context__.SourceCodeLine = 168;
            STEMP__DOLLAR__  .UpdateValue ( SSTRING  ) ; 
            __context__.SourceCodeLine = 169;
            INULLLOCATION = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 177;
            STEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( "\u0000" , STEMP__DOLLAR__ )  ) ; 
            __context__.SourceCodeLine = 178;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( STEMP__DOLLAR__ ); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( A  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (A  >= __FN_FORSTART_VAL__1) && (A  <= __FN_FOREND_VAL__1) ) : ( (A  <= __FN_FORSTART_VAL__1) && (A  >= __FN_FOREND_VAL__1) ) ; A  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 180;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( STEMP__DOLLAR__ , (int)( A ) , (int)( 1 ) ) == "\u0000"))  ) ) 
                    {
                    __context__.SourceCodeLine = 181;
                    SetString ( "\u0020" , (int)A, STEMP__DOLLAR__ ) ; 
                    }
                
                __context__.SourceCodeLine = 178;
                } 
            
            __context__.SourceCodeLine = 185;
            if ( Functions.TestForTrue  ( ( ICURSOR)  ) ) 
                { 
                __context__.SourceCodeLine = 187;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Bit( STEMP__DOLLAR__ , (int)( 5 ) , (int)( 3 ) ) == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 188;
                    SetString ( "\u003E" , (int)5, STEMP__DOLLAR__ ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 190;
                    SetString ( "\u0020" , (int)5, STEMP__DOLLAR__ ) ; 
                    }
                
                } 
            
            __context__.SourceCodeLine = 192;
            return ( STEMP__DOLLAR__ ) ; 
            
            }
            
        object DIRECT_KEY_AM_FM__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort ILENGTH = 0;
                
                CrestronString STEMP__DOLLAR__;
                STEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
                
                
                __context__.SourceCodeLine = 224;
                ILENGTH = (ushort) ( Functions.Length( DIRECT_KEY_AM_FM__DOLLAR__ ) ) ; 
                __context__.SourceCodeLine = 225;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ILENGTH > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 225;
                    STEMP__DOLLAR__  .UpdateValue ( Functions.Right ( DIRECT_KEY_AM_FM__DOLLAR__ ,  (int) ( 1 ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 226;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u0000" , DIRECT_KEY_AM_FM__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 228;
                    Functions.ClearBuffer ( DIRECT_KEY_AM_FM__DOLLAR__ ) ; 
                    } 
                
                __context__.SourceCodeLine = 233;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ILENGTH == 7))  ) ) 
                    { 
                    __context__.SourceCodeLine = 235;
                    DIRECT_KEY_AM_FM__DOLLAR__  .UpdateValue ( STEMP__DOLLAR__  ) ; 
                    } 
                
                __context__.SourceCodeLine = 237;
                DIRECT_COMMAND_VALUE_DISPLAYED_AM_FM__DOLLAR__  .UpdateValue ( DIRECT_KEY_AM_FM__DOLLAR__  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object DIRECT_KEY_HD__DOLLAR___OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort ILENGTH = 0;
            
            CrestronString STEMP__DOLLAR__;
            STEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
            
            
            __context__.SourceCodeLine = 264;
            ILENGTH = (ushort) ( Functions.Length( DIRECT_KEY_HD__DOLLAR__ ) ) ; 
            __context__.SourceCodeLine = 265;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ILENGTH > 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 265;
                STEMP__DOLLAR__  .UpdateValue ( Functions.Right ( DIRECT_KEY_HD__DOLLAR__ ,  (int) ( 1 ) )  ) ; 
                }
            
            __context__.SourceCodeLine = 266;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u0000" , DIRECT_KEY_HD__DOLLAR__ ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 268;
                Functions.ClearBuffer ( DIRECT_KEY_HD__DOLLAR__ ) ; 
                } 
            
            __context__.SourceCodeLine = 273;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ILENGTH == 7))  ) ) 
                { 
                __context__.SourceCodeLine = 275;
                DIRECT_KEY_HD__DOLLAR__  .UpdateValue ( STEMP__DOLLAR__  ) ; 
                } 
            
            __context__.SourceCodeLine = 277;
            DIRECT_COMMAND_VALUE_DISPLAYED_HD__DOLLAR__  .UpdateValue ( DIRECT_KEY_HD__DOLLAR__  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object DIRECT_KEY_XM__DOLLAR___OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort ILENGTH = 0;
        
        CrestronString STEMP__DOLLAR__;
        STEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
        
        
        __context__.SourceCodeLine = 287;
        ILENGTH = (ushort) ( Functions.Length( DIRECT_KEY_XM__DOLLAR__ ) ) ; 
        __context__.SourceCodeLine = 288;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ILENGTH > 0 ))  ) ) 
            {
            __context__.SourceCodeLine = 288;
            STEMP__DOLLAR__  .UpdateValue ( Functions.Right ( DIRECT_KEY_XM__DOLLAR__ ,  (int) ( 1 ) )  ) ; 
            }
        
        __context__.SourceCodeLine = 289;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u0000" , DIRECT_KEY_XM__DOLLAR__ ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 291;
            Functions.ClearBuffer ( DIRECT_KEY_XM__DOLLAR__ ) ; 
            } 
        
        __context__.SourceCodeLine = 294;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ILENGTH == 4))  ) ) 
            { 
            __context__.SourceCodeLine = 296;
            DIRECT_KEY_XM__DOLLAR__  .UpdateValue ( STEMP__DOLLAR__  ) ; 
            } 
        
        __context__.SourceCodeLine = 298;
        DIRECT_COMMAND_VALUE_DISPLAYED_XM__DOLLAR__  .UpdateValue ( DIRECT_KEY_XM__DOLLAR__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIRECT_KEY_DAB__DOLLAR___OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort ILENGTH = 0;
        
        CrestronString STEMP__DOLLAR__;
        STEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
        
        
        __context__.SourceCodeLine = 308;
        ILENGTH = (ushort) ( Functions.Length( DIRECT_KEY_DAB__DOLLAR__ ) ) ; 
        __context__.SourceCodeLine = 309;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ILENGTH > 0 ))  ) ) 
            {
            __context__.SourceCodeLine = 309;
            STEMP__DOLLAR__  .UpdateValue ( Functions.Right ( DIRECT_KEY_DAB__DOLLAR__ ,  (int) ( 1 ) )  ) ; 
            }
        
        __context__.SourceCodeLine = 310;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u0000" , DIRECT_KEY_DAB__DOLLAR__ ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 312;
            Functions.ClearBuffer ( DIRECT_KEY_DAB__DOLLAR__ ) ; 
            } 
        
        __context__.SourceCodeLine = 314;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ILENGTH == 7))  ) ) 
            { 
            __context__.SourceCodeLine = 316;
            DIRECT_KEY_DAB__DOLLAR__  .UpdateValue ( STEMP__DOLLAR__  ) ; 
            } 
        
        __context__.SourceCodeLine = 318;
        DIRECT_COMMAND_VALUE_DISPLAYED_DAB__DOLLAR__  .UpdateValue ( DIRECT_KEY_DAB__DOLLAR__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIRECT_KEY_SIRIUS__DOLLAR___OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort ILENGTH = 0;
        
        CrestronString STEMP__DOLLAR__;
        STEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
        
        
        __context__.SourceCodeLine = 328;
        ILENGTH = (ushort) ( Functions.Length( DIRECT_KEY_SIRIUS__DOLLAR__ ) ) ; 
        __context__.SourceCodeLine = 329;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ILENGTH > 0 ))  ) ) 
            {
            __context__.SourceCodeLine = 329;
            STEMP__DOLLAR__  .UpdateValue ( Functions.Right ( DIRECT_KEY_SIRIUS__DOLLAR__ ,  (int) ( 1 ) )  ) ; 
            }
        
        __context__.SourceCodeLine = 330;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u0000" , DIRECT_KEY_SIRIUS__DOLLAR__ ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 332;
            Functions.ClearBuffer ( DIRECT_KEY_SIRIUS__DOLLAR__ ) ; 
            } 
        
        __context__.SourceCodeLine = 335;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ILENGTH == 4))  ) ) 
            { 
            __context__.SourceCodeLine = 337;
            DIRECT_KEY_SIRIUS__DOLLAR__  .UpdateValue ( STEMP__DOLLAR__  ) ; 
            } 
        
        __context__.SourceCodeLine = 339;
        DIRECT_COMMAND_VALUE_DISPLAYED_SIRIUS__DOLLAR__  .UpdateValue ( DIRECT_KEY_SIRIUS__DOLLAR__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROMDEVICE__DOLLAR___OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 344;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SEMAPHORE == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 346;
            SEMAPHORE = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 347;
            FROMDEVICETEMP__DOLLAR__  .UpdateValue ( FROMDEVICETEMP__DOLLAR__ + FROMDEVICE__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 348;
            Functions.ClearBuffer ( FROMDEVICE__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 349;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u000D" , FROMDEVICETEMP__DOLLAR__ ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 351;
                TEMPSTRING__DOLLAR__  .UpdateValue ( Functions.Remove ( "\u000D" , FROMDEVICETEMP__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 352;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMPSTRING__DOLLAR__ == "MUON\u000D"))  ) ) 
                    {
                    __context__.SourceCodeLine = 353;
                    MUTE_MAIN__DOLLAR__  .UpdateValue ( "Z1MUON"  ) ; 
                    }
                
                __context__.SourceCodeLine = 354;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMPSTRING__DOLLAR__ == "MUOFF\u000D"))  ) ) 
                    {
                    __context__.SourceCodeLine = 355;
                    MUTE_MAIN__DOLLAR__  .UpdateValue ( "Z1MUOFF"  ) ; 
                    }
                
                __context__.SourceCodeLine = 357;
                COMMAND__DOLLAR__  .UpdateValue ( Functions.Left ( TEMPSTRING__DOLLAR__ ,  (int) ( 2 ) )  ) ; 
                __context__.SourceCodeLine = 358;
                ISTRINGLENGTH = (ushort) ( Functions.Find( "\u000D" , TEMPSTRING__DOLLAR__ ) ) ; 
                __context__.SourceCodeLine = 360;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "TPAN" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 360;
                    AM_FM_PRESET__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 5 ) ,  (int) ( (ISTRINGLENGTH - 5) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 361;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "TPHD" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 361;
                    HD_PRESET__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 5 ) ,  (int) ( (ISTRINGLENGTH - 5) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 362;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "HDST NAME " , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 362;
                    HD_STATION_NAME__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 11 ) ,  (int) ( (ISTRINGLENGTH - 11) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 363;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "HDSTL NAME " , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 363;
                    HD_STATION_NAME_LONG__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 12 ) ,  (int) ( (ISTRINGLENGTH - 12) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 364;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "HDSIG " , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 364;
                    HD_SIGNAL__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 7 ) ,  (int) ( (ISTRINGLENGTH - 7) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 365;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "HDMLT CURRCH " , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 365;
                    HD_MULTICAST_CURRENT_CH__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 14 ) ,  (int) ( (ISTRINGLENGTH - 14) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 366;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "HDMLT CAST CH " , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 366;
                    HD_MULTICAST_CH__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 15 ) ,  (int) ( (ISTRINGLENGTH - 15) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 367;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "HDPTY " , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 367;
                    HD_PROGRAM_TYPE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 7 ) ,  (int) ( (ISTRINGLENGTH - 7) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 368;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "HDARTIST " , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 368;
                    HD_ARTIST__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 10 ) ,  (int) ( (ISTRINGLENGTH - 10) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 369;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "HDTITLE " , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 369;
                    HD_TITLE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 9 ) ,  (int) ( (ISTRINGLENGTH - 9) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 370;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "HDALBUM " , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 370;
                    HD_ALBUM__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 9 ) ,  (int) ( (ISTRINGLENGTH - 9) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 371;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "HDGENRE " , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 371;
                    HD_GENRE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 9 ) ,  (int) ( (ISTRINGLENGTH - 9) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 373;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "TPXMA" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 373;
                    XM_PRESET__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 6 ) ,  (int) ( (ISTRINGLENGTH - 6) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 374;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "XMCH NAME " , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 374;
                    XM_CHANNEL_NAME__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 11 ) ,  (int) ( (ISTRINGLENGTH - 11) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 375;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "XMARTIST " , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 375;
                    XM_ARTIST__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 10 ) ,  (int) ( (ISTRINGLENGTH - 10) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 376;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "XMTITLE " , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 376;
                    XM_TITLE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 8 ) ,  (int) ( (ISTRINGLENGTH - 8) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 377;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "XMXMID " , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 377;
                    XM_RADIO_ID__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 6 ) ,  (int) ( (ISTRINGLENGTH - 6) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 378;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "XMSIGNAL " , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 378;
                    XM_SIGNAL__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 9 ) ,  (int) ( (ISTRINGLENGTH - 9) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 380;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "DABST NAME" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 380;
                    DAB_STATION_NAME__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 10 ) ,  (int) ( (ISTRINGLENGTH - 10) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 381;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "DABSTL NAME" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 381;
                    DAB_STATION_NAME_LONG__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 11 ) ,  (int) ( (ISTRINGLENGTH - 11) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 382;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "DABEN NAME" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 382;
                    DAB_ENSEMBLE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 10 ) ,  (int) ( (ISTRINGLENGTH - 10) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 383;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "DABPTY" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 383;
                    DAB_PROGRAM_TYPE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 7 ) ,  (int) ( (ISTRINGLENGTH - 7) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 384;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "DAB" , TEMPSTRING__DOLLAR__ ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( TEMPSTRING__DOLLAR__ ) == 7) )) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 384;
                    DAB_CHANNEL_CH__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 4 ) ,  (int) ( (ISTRINGLENGTH - 4) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 385;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "DAB" , TEMPSTRING__DOLLAR__ ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( TEMPSTRING__DOLLAR__ ) == 10) )) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 385;
                    DAB_FREQUENCY__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 4 ) ,  (int) ( (ISTRINGLENGTH - 4) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 386;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "DABMODE" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 386;
                    DAB_MODE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 8 ) ,  (int) ( (ISTRINGLENGTH - 8) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 387;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "DABSIG" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 387;
                    DAB_SIGNAL__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 7 ) ,  (int) ( (ISTRINGLENGTH - 7) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 389;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "DABTIME" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 389;
                    DAB_TIME__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 8 ) ,  (int) ( (ISTRINGLENGTH - 8) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 390;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "DABDATE" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 390;
                    DAB_DATE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 8 ) ,  (int) ( (ISTRINGLENGTH - 8) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 392;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "TPST" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 392;
                    SIRIUS_PRESET__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 5 ) ,  (int) ( (ISTRINGLENGTH - 5) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 393;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "STCH NAME " , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 393;
                    SIRIUS_CHANNEL_NAME__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 11 ) ,  (int) ( (ISTRINGLENGTH - 11) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 394;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "STARTIST " , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 394;
                    SIRIUS_ARTIST__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 10 ) ,  (int) ( (ISTRINGLENGTH - 10) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 395;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "STTITLE " , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 395;
                    SIRIUS_TITLE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 9 ) ,  (int) ( (ISTRINGLENGTH - 9) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 396;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "STID " , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 396;
                    SIRIUS_RADIO_ID__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 6 ) ,  (int) ( (ISTRINGLENGTH - 6) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 397;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "STSIGNAL " , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 397;
                    SIRIUS_SIGNAL__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 10 ) ,  (int) ( (ISTRINGLENGTH - 10) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 400;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (COMMAND__DOLLAR__ == "MV") ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( TEMPSTRING__DOLLAR__ , (int)( 3 ) ) != 77) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 402;
                    LEVEL = (ushort) ( (Functions.Atoi( Functions.Mid( TEMPSTRING__DOLLAR__ , (int)( 3 ) , (int)( 2 ) ) ) * 2) ) ; 
                    __context__.SourceCodeLine = 403;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (LEVEL == 198) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( TEMPSTRING__DOLLAR__ , (int)( 5 ) ) != 53) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 405;
                        MAINLEVEL  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 406;
                        MAINLEVELINT__DOLLAR__  .UpdateValue ( "---"  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 408;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (LEVEL == 198) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( TEMPSTRING__DOLLAR__ , (int)( 5 ) ) == 53) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 410;
                            MAINLEVEL  .Value = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 411;
                            MAINLEVELINT__DOLLAR__  .UpdateValue ( "- 80.5 dB"  ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 415;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( TEMPSTRING__DOLLAR__ , (int)( 5 ) ) == 53))  ) ) 
                                {
                                __context__.SourceCodeLine = 416;
                                LEVEL = (ushort) ( (LEVEL + 1) ) ; 
                                }
                            
                            __context__.SourceCodeLine = 417;
                            MAINLEVEL  .Value = (ushort) ( (LEVEL + 2) ) ; 
                            __context__.SourceCodeLine = 418;
                            LEVEL = (ushort) ( (LEVEL * 5) ) ; 
                            __context__.SourceCodeLine = 419;
                            MAINLEVELINT__DOLLAR__  .UpdateValue ( CALCULATEVOLUMETEXT (  __context__ , (ushort)( LEVEL ))  ) ; 
                            } 
                        
                        }
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 422;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (COMMAND__DOLLAR__ == "Z2") ) && Functions.TestForTrue ( Functions.BoolToInt ( Byte( TEMPSTRING__DOLLAR__ , (int)( 3 ) ) >= 48 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Byte( TEMPSTRING__DOLLAR__ , (int)( 3 ) ) <= 57 ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 424;
                        LEVEL = (ushort) ( (Functions.Atoi( Functions.Mid( TEMPSTRING__DOLLAR__ , (int)( 3 ) , (int)( 2 ) ) ) * 2) ) ; 
                        __context__.SourceCodeLine = 425;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (LEVEL == 198) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( TEMPSTRING__DOLLAR__ , (int)( 5 ) ) != 53) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 427;
                            ZONE2LEVEL  .Value = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 428;
                            ZONE2LEVELINT__DOLLAR__  .UpdateValue ( "---"  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 430;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (LEVEL == 198) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( TEMPSTRING__DOLLAR__ , (int)( 5 ) ) == 53) )) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 432;
                                ZONE2LEVEL  .Value = (ushort) ( 1 ) ; 
                                __context__.SourceCodeLine = 433;
                                ZONE2LEVELINT__DOLLAR__  .UpdateValue ( "- 80.5 dB"  ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 437;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( TEMPSTRING__DOLLAR__ , (int)( 5 ) ) == 53))  ) ) 
                                    {
                                    __context__.SourceCodeLine = 438;
                                    LEVEL = (ushort) ( (LEVEL + 1) ) ; 
                                    }
                                
                                __context__.SourceCodeLine = 439;
                                ZONE2LEVEL  .Value = (ushort) ( (LEVEL + 2) ) ; 
                                __context__.SourceCodeLine = 440;
                                LEVEL = (ushort) ( (LEVEL * 5) ) ; 
                                __context__.SourceCodeLine = 441;
                                ZONE2LEVELINT__DOLLAR__  .UpdateValue ( CALCULATEVOLUMETEXT (  __context__ , (ushort)( LEVEL ))  ) ; 
                                } 
                            
                            }
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 444;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (COMMAND__DOLLAR__ == "Z3") ) && Functions.TestForTrue ( Functions.BoolToInt ( Byte( TEMPSTRING__DOLLAR__ , (int)( 3 ) ) >= 48 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Byte( TEMPSTRING__DOLLAR__ , (int)( 3 ) ) <= 57 ) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 446;
                            LEVEL = (ushort) ( (Functions.Atoi( Functions.Mid( TEMPSTRING__DOLLAR__ , (int)( 3 ) , (int)( 2 ) ) ) * 2) ) ; 
                            __context__.SourceCodeLine = 447;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (LEVEL == 198) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( TEMPSTRING__DOLLAR__ , (int)( 5 ) ) != 53) )) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 449;
                                ZONE3LEVEL  .Value = (ushort) ( 0 ) ; 
                                __context__.SourceCodeLine = 450;
                                ZONE3LEVELINT__DOLLAR__  .UpdateValue ( "---"  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 452;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (LEVEL == 198) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( TEMPSTRING__DOLLAR__ , (int)( 5 ) ) == 53) )) ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 454;
                                    ZONE3LEVEL  .Value = (ushort) ( 1 ) ; 
                                    __context__.SourceCodeLine = 455;
                                    ZONE3LEVELINT__DOLLAR__  .UpdateValue ( "- 80.5 dB"  ) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 459;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( TEMPSTRING__DOLLAR__ , (int)( 5 ) ) == 53))  ) ) 
                                        {
                                        __context__.SourceCodeLine = 460;
                                        LEVEL = (ushort) ( (LEVEL + 1) ) ; 
                                        }
                                    
                                    __context__.SourceCodeLine = 461;
                                    ZONE3LEVEL  .Value = (ushort) ( (LEVEL + 2) ) ; 
                                    __context__.SourceCodeLine = 462;
                                    LEVEL = (ushort) ( (LEVEL * 5) ) ; 
                                    __context__.SourceCodeLine = 463;
                                    ZONE3LEVELINT__DOLLAR__  .UpdateValue ( CALCULATEVOLUMETEXT (  __context__ , (ushort)( LEVEL ))  ) ; 
                                    } 
                                
                                }
                            
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 466;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Left( TEMPSTRING__DOLLAR__ , (int)( 4 ) ) == "TFAN") ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Find( "CMP" , TEMPSTRING__DOLLAR__ ) == 0) )) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 468;
                                FREQHI = (ushort) ( Functions.Atoi( Functions.Mid( TEMPSTRING__DOLLAR__ , (int)( 5 ) , (int)( 4 ) ) ) ) ; 
                                __context__.SourceCodeLine = 469;
                                FREQLO = (ushort) ( Functions.Atoi( Functions.Mid( TEMPSTRING__DOLLAR__ , (int)( 9 ) , (int)( 2 ) ) ) ) ; 
                                __context__.SourceCodeLine = 470;
                                AMFMVALUE = (ushort) ( Functions.Atoi( Functions.Mid( TEMPSTRING__DOLLAR__ , (int)( 5 ) , (int)( 5 ) ) ) ) ; 
                                __context__.SourceCodeLine = 471;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( AMFMVALUE > 5000 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 473;
                                    MakeString ( ANALOG_TUNER_FREQUENCY__DOLLAR__ , "{0:d} kHz", (ushort)FREQHI) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 477;
                                    MakeString ( ANALOG_TUNER_FREQUENCY__DOLLAR__ , "{0:d}.{1:d} MHz", (ushort)FREQHI, (ushort)FREQLO) ; 
                                    } 
                                
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 481;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Left( TEMPSTRING__DOLLAR__ , (int)( 4 ) ) == "TFXM") ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Find( "CMP" , TEMPSTRING__DOLLAR__ ) == 0) )) ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 483;
                                    MakeString ( XM_TUNER_FREQUENCY__DOLLAR__ , "XM-{0:d}", (ushort)Functions.Atoi( TEMPSTRING__DOLLAR__ )) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 486;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Left( TEMPSTRING__DOLLAR__ , (int)( 4 ) ) == "TFDA") ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Find( "CMP" , TEMPSTRING__DOLLAR__ ) == 0) )) ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 488;
                                        MakeString ( DAB_TUNER_FREQUENCY__DOLLAR__ , "XM-{0:d}", (ushort)Functions.Atoi( TEMPSTRING__DOLLAR__ )) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 491;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Left( TEMPSTRING__DOLLAR__ , (int)( 4 ) ) == "TFHD") ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( TEMPSTRING__DOLLAR__ ) == 11) )) ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 493;
                                            FREQHI = (ushort) ( Functions.Atoi( Functions.Mid( TEMPSTRING__DOLLAR__ , (int)( 5 ) , (int)( 4 ) ) ) ) ; 
                                            __context__.SourceCodeLine = 494;
                                            FREQLO = (ushort) ( Functions.Atoi( Functions.Mid( TEMPSTRING__DOLLAR__ , (int)( 9 ) , (int)( 2 ) ) ) ) ; 
                                            __context__.SourceCodeLine = 495;
                                            HDVALUE = (ushort) ( Functions.Atoi( Functions.Mid( TEMPSTRING__DOLLAR__ , (int)( 5 ) , (int)( 5 ) ) ) ) ; 
                                            __context__.SourceCodeLine = 496;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( HDVALUE > 5000 ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 498;
                                                MakeString ( HD_TUNER_FREQUENCY__DOLLAR__ , "{0:d} kHz", (ushort)FREQHI) ; 
                                                } 
                                            
                                            else 
                                                { 
                                                __context__.SourceCodeLine = 502;
                                                MakeString ( HD_TUNER_FREQUENCY__DOLLAR__ , "{0:d}.{1:d} MHz", (ushort)FREQHI, (ushort)FREQLO) ; 
                                                } 
                                            
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 506;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Left( TEMPSTRING__DOLLAR__ , (int)( 4 ) ) == "TFST") ) && Functions.TestForTrue ( Functions.BoolToInt ( Byte( TEMPSTRING__DOLLAR__ , (int)( 5 ) ) < 58 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Byte( TEMPSTRING__DOLLAR__ , (int)( 6 ) ) < 58 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Byte( TEMPSTRING__DOLLAR__ , (int)( 7 ) ) < 58 ) )) ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 508;
                                                MakeString ( SIRIUS_TUNER_FREQUENCY__DOLLAR__ , "Sirius-{0:d}", (ushort)Functions.Atoi( TEMPSTRING__DOLLAR__ )) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 510;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COMMAND__DOLLAR__ == "CV"))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 512;
                                                    SUB__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 3 ) ,  (int) ( 3 ) )  ) ; 
                                                    __context__.SourceCodeLine = 513;
                                                    SUB3__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 3 ) ,  (int) ( 1 ) )  ) ; 
                                                    __context__.SourceCodeLine = 514;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "SBL") ) || Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "SBR") )) ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 516;
                                                        LEVEL = (ushort) ( (Functions.Atoi( Functions.Mid( TEMPSTRING__DOLLAR__ , (int)( 7 ) , (int)( 2 ) ) ) * 2) ) ; 
                                                        __context__.SourceCodeLine = 517;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( TEMPSTRING__DOLLAR__ , (int)( 9 ) ) == 53))  ) ) 
                                                            {
                                                            __context__.SourceCodeLine = 518;
                                                            LEVEL = (ushort) ( (LEVEL + 1) ) ; 
                                                            }
                                                        
                                                        __context__.SourceCodeLine = 519;
                                                        LEVEL = (ushort) ( (LEVEL * 5) ) ; 
                                                        __context__.SourceCodeLine = 520;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "SBL") ) && Functions.TestForTrue ( Functions.BoolToInt (LEVEL != SBL) )) ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 522;
                                                            SBLLEVEL__DOLLAR__  .UpdateValue ( CALCULATECHANNELTEXT (  __context__ , (ushort)( LEVEL ))  ) ; 
                                                            __context__.SourceCodeLine = 523;
                                                            SBL = (ushort) ( LEVEL ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 525;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "SBR") ) && Functions.TestForTrue ( Functions.BoolToInt (LEVEL != SBR) )) ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 527;
                                                                SBRLEVEL__DOLLAR__  .UpdateValue ( CALCULATECHANNELTEXT (  __context__ , (ushort)( LEVEL ))  ) ; 
                                                                __context__.SourceCodeLine = 528;
                                                                SBR = (ushort) ( LEVEL ) ; 
                                                                } 
                                                            
                                                            }
                                                        
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 531;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "SB ") ) || Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "SR ") )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "SL ") )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "SW ") )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "FL ") )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "FR ") )) ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 533;
                                                            LEVEL = (ushort) ( (Functions.Atoi( Functions.Mid( TEMPSTRING__DOLLAR__ , (int)( 6 ) , (int)( 2 ) ) ) * 2) ) ; 
                                                            __context__.SourceCodeLine = 534;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( TEMPSTRING__DOLLAR__ , (int)( 8 ) ) == 53))  ) ) 
                                                                {
                                                                __context__.SourceCodeLine = 535;
                                                                LEVEL = (ushort) ( (LEVEL + 1) ) ; 
                                                                }
                                                            
                                                            __context__.SourceCodeLine = 536;
                                                            LEVEL = (ushort) ( (LEVEL * 5) ) ; 
                                                            __context__.SourceCodeLine = 537;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "SB ") ) && Functions.TestForTrue ( Functions.BoolToInt (LEVEL != SB) )) ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 539;
                                                                SBLEVEL__DOLLAR__  .UpdateValue ( CALCULATECHANNELTEXT (  __context__ , (ushort)( LEVEL ))  ) ; 
                                                                __context__.SourceCodeLine = 540;
                                                                SB = (ushort) ( LEVEL ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 542;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "SR ") ) && Functions.TestForTrue ( Functions.BoolToInt (LEVEL != SR) )) ))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 544;
                                                                    SRLEVEL__DOLLAR__  .UpdateValue ( CALCULATECHANNELTEXT (  __context__ , (ushort)( LEVEL ))  ) ; 
                                                                    __context__.SourceCodeLine = 545;
                                                                    SR = (ushort) ( LEVEL ) ; 
                                                                    } 
                                                                
                                                                else 
                                                                    {
                                                                    __context__.SourceCodeLine = 547;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "SL ") ) && Functions.TestForTrue ( Functions.BoolToInt (LEVEL != SL) )) ))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 549;
                                                                        SLLEVEL__DOLLAR__  .UpdateValue ( CALCULATECHANNELTEXT (  __context__ , (ushort)( LEVEL ))  ) ; 
                                                                        __context__.SourceCodeLine = 550;
                                                                        SL = (ushort) ( LEVEL ) ; 
                                                                        } 
                                                                    
                                                                    else 
                                                                        {
                                                                        __context__.SourceCodeLine = 552;
                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "SW ") ) && Functions.TestForTrue ( Functions.BoolToInt (LEVEL != SW) )) ))  ) ) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 554;
                                                                            SWLEVEL__DOLLAR__  .UpdateValue ( CALCULATECHANNELTEXT (  __context__ , (ushort)( LEVEL ))  ) ; 
                                                                            __context__.SourceCodeLine = 555;
                                                                            SW = (ushort) ( LEVEL ) ; 
                                                                            } 
                                                                        
                                                                        else 
                                                                            {
                                                                            __context__.SourceCodeLine = 557;
                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "FR ") ) && Functions.TestForTrue ( Functions.BoolToInt (LEVEL != FR) )) ))  ) ) 
                                                                                { 
                                                                                __context__.SourceCodeLine = 559;
                                                                                FRLEVEL__DOLLAR__  .UpdateValue ( CALCULATECHANNELTEXT (  __context__ , (ushort)( LEVEL ))  ) ; 
                                                                                __context__.SourceCodeLine = 560;
                                                                                FR = (ushort) ( LEVEL ) ; 
                                                                                } 
                                                                            
                                                                            else 
                                                                                {
                                                                                __context__.SourceCodeLine = 562;
                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "FL ") ) && Functions.TestForTrue ( Functions.BoolToInt (LEVEL != FL) )) ))  ) ) 
                                                                                    { 
                                                                                    __context__.SourceCodeLine = 564;
                                                                                    FLLEVEL__DOLLAR__  .UpdateValue ( CALCULATECHANNELTEXT (  __context__ , (ushort)( LEVEL ))  ) ; 
                                                                                    __context__.SourceCodeLine = 565;
                                                                                    FL = (ushort) ( LEVEL ) ; 
                                                                                    } 
                                                                                
                                                                                }
                                                                            
                                                                            }
                                                                        
                                                                        }
                                                                    
                                                                    }
                                                                
                                                                }
                                                            
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 568;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SUB3__DOLLAR__ == "C"))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 570;
                                                                LEVEL = (ushort) ( (Functions.Atoi( Functions.Mid( TEMPSTRING__DOLLAR__ , (int)( 5 ) , (int)( 2 ) ) ) * 2) ) ; 
                                                                __context__.SourceCodeLine = 571;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( TEMPSTRING__DOLLAR__ , (int)( 7 ) ) == 53))  ) ) 
                                                                    {
                                                                    __context__.SourceCodeLine = 572;
                                                                    LEVEL = (ushort) ( (LEVEL + 1) ) ; 
                                                                    }
                                                                
                                                                __context__.SourceCodeLine = 573;
                                                                LEVEL = (ushort) ( (LEVEL * 5) ) ; 
                                                                __context__.SourceCodeLine = 574;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (C != LEVEL))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 576;
                                                                    CLEVEL__DOLLAR__  .UpdateValue ( CALCULATECHANNELTEXT (  __context__ , (ushort)( LEVEL ))  ) ; 
                                                                    __context__.SourceCodeLine = 577;
                                                                    C = (ushort) ( LEVEL ) ; 
                                                                    } 
                                                                
                                                                } 
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    } 
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                __context__.SourceCodeLine = 349;
                } 
            
            __context__.SourceCodeLine = 583;
            SEMAPHORE = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SENDMAIN_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 589;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MAINLEVELSENT__DOLLAR__ != MAINLEVELINT__DOLLAR__))  ) ) 
            { 
            __context__.SourceCodeLine = 591;
            MAINLEVEL__DOLLAR__  .UpdateValue ( MAINLEVELINT__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 592;
            MAINLEVELSENT__DOLLAR__  .UpdateValue ( MAINLEVELINT__DOLLAR__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SENDZONE2_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 598;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ZONE2LEVELSENT__DOLLAR__ != ZONE2LEVELINT__DOLLAR__))  ) ) 
            { 
            __context__.SourceCodeLine = 600;
            ZONE2LEVEL__DOLLAR__  .UpdateValue ( ZONE2LEVELINT__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 601;
            ZONE2LEVELSENT__DOLLAR__  .UpdateValue ( ZONE2LEVELINT__DOLLAR__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SENDZONE3_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 607;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ZONE3LEVELSENT__DOLLAR__ != ZONE3LEVELINT__DOLLAR__))  ) ) 
            { 
            __context__.SourceCodeLine = 609;
            ZONE3LEVEL__DOLLAR__  .UpdateValue ( ZONE3LEVELINT__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 610;
            ZONE3LEVELSENT__DOLLAR__  .UpdateValue ( ZONE3LEVELINT__DOLLAR__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENTER_AM_FM_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 636;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( AM_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_AM_FM__DOLLAR__ ) == 3) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 636;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFAN0{0}00\r", DIRECT_KEY_AM_FM__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 637;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( AM_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_AM_FM__DOLLAR__ ) == 4) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 637;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFAN{0}00\r", DIRECT_KEY_AM_FM__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 638;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( AM_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_AM_FM__DOLLAR__ ) == 5) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 638;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFAN{0}0\r", DIRECT_KEY_AM_FM__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 639;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( AM_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_AM_FM__DOLLAR__ ) == 6) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 639;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFAN{0}\r", DIRECT_KEY_AM_FM__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 641;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( FM_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_AM_FM__DOLLAR__ ) == 3) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 641;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFAN00{0}0\r", DIRECT_KEY_AM_FM__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 642;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( FM_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_AM_FM__DOLLAR__ ) == 4) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 642;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFAN00{0}\r", DIRECT_KEY_AM_FM__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 643;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( FM_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_AM_FM__DOLLAR__ ) == 5) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 643;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFAN0{0}\r", DIRECT_KEY_AM_FM__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 644;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( FM_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_AM_FM__DOLLAR__ ) == 6) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 644;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFAN{0}\r", DIRECT_KEY_AM_FM__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 645;
        Functions.ClearBuffer ( DIRECT_KEY_AM_FM__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENTER_HD_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 650;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( AM_HD_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_HD__DOLLAR__ ) == 3) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 650;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFHD0{0}00\r", DIRECT_KEY_HD__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 651;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( AM_HD_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_HD__DOLLAR__ ) == 4) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 651;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFHD{0}00\r", DIRECT_KEY_HD__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 652;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( AM_HD_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_HD__DOLLAR__ ) == 5) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 652;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFHD{0}0\r", DIRECT_KEY_HD__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 653;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( AM_HD_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_HD__DOLLAR__ ) == 6) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 653;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFHD{0}\r", DIRECT_KEY_HD__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 655;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( FM_HD_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_HD__DOLLAR__ ) == 3) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 655;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFHD00{0}0\r", DIRECT_KEY_HD__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 656;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( FM_HD_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_HD__DOLLAR__ ) == 4) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 656;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFHD00{0}\r", DIRECT_KEY_HD__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 657;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( FM_HD_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_HD__DOLLAR__ ) == 5) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 657;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFHD0{0}\r", DIRECT_KEY_HD__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 658;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( FM_HD_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_HD__DOLLAR__ ) == 6) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 658;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFHD{0}\r", DIRECT_KEY_HD__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 659;
        Functions.ClearBuffer ( DIRECT_KEY_HD__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENTER_XM_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 664;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_XM__DOLLAR__ ) == 3))  ) ) 
            {
            __context__.SourceCodeLine = 664;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFXM{0}\r", DIRECT_KEY_XM__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 665;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_XM__DOLLAR__ ) == 2))  ) ) 
            {
            __context__.SourceCodeLine = 665;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFXM0{0}\r", DIRECT_KEY_XM__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 666;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_XM__DOLLAR__ ) == 1))  ) ) 
            {
            __context__.SourceCodeLine = 666;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFXM00{0}\r", DIRECT_KEY_XM__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 667;
        Functions.ClearBuffer ( DIRECT_KEY_XM__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENTER_DAB_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 672;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_DAB__DOLLAR__ ) == 6))  ) ) 
            {
            __context__.SourceCodeLine = 672;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFDA{0}\r", DIRECT_KEY_DAB__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 673;
        Functions.ClearBuffer ( DIRECT_KEY_DAB__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENTER_SIRIUS_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 678;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_SIRIUS__DOLLAR__ ) == 3))  ) ) 
            {
            __context__.SourceCodeLine = 678;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFST{0}\r", DIRECT_KEY_SIRIUS__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 679;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_SIRIUS__DOLLAR__ ) == 2))  ) ) 
            {
            __context__.SourceCodeLine = 679;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFST0{0}\r", DIRECT_KEY_SIRIUS__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 680;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_SIRIUS__DOLLAR__ ) == 1))  ) ) 
            {
            __context__.SourceCodeLine = 680;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFST00{0}\r", DIRECT_KEY_SIRIUS__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 681;
        Functions.ClearBuffer ( DIRECT_KEY_SIRIUS__DOLLAR__ ) ; 
        
        
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
        
        __context__.SourceCodeLine = 693;
        SEMAPHORE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 694;
        FL = (ushort) ( 100 ) ; 
        __context__.SourceCodeLine = 695;
        FR = (ushort) ( 100 ) ; 
        __context__.SourceCodeLine = 696;
        SL = (ushort) ( 100 ) ; 
        __context__.SourceCodeLine = 697;
        SR = (ushort) ( 100 ) ; 
        __context__.SourceCodeLine = 698;
        SBL = (ushort) ( 100 ) ; 
        __context__.SourceCodeLine = 699;
        SBR = (ushort) ( 100 ) ; 
        __context__.SourceCodeLine = 700;
        C = (ushort) ( 100 ) ; 
        __context__.SourceCodeLine = 701;
        SW = (ushort) ( 100 ) ; 
        __context__.SourceCodeLine = 702;
        SB = (ushort) ( 100 ) ; 
        __context__.SourceCodeLine = 703;
        Functions.ClearBuffer ( MAINLEVELSENT__DOLLAR__ ) ; 
        __context__.SourceCodeLine = 704;
        Functions.ClearBuffer ( ZONE2LEVELSENT__DOLLAR__ ) ; 
        __context__.SourceCodeLine = 705;
        Functions.ClearBuffer ( ZONE3LEVELSENT__DOLLAR__ ) ; 
        __context__.SourceCodeLine = 706;
        Functions.ClearBuffer ( MAINLEVELINT__DOLLAR__ ) ; 
        __context__.SourceCodeLine = 707;
        Functions.ClearBuffer ( ZONE2LEVELINT__DOLLAR__ ) ; 
        __context__.SourceCodeLine = 708;
        Functions.ClearBuffer ( ZONE3LEVELINT__DOLLAR__ ) ; 
        __context__.SourceCodeLine = 709;
        Functions.ClearBuffer ( DIRECT_KEY_AM_FM__DOLLAR__ ) ; 
        __context__.SourceCodeLine = 710;
        Functions.ClearBuffer ( DIRECT_KEY_XM__DOLLAR__ ) ; 
        __context__.SourceCodeLine = 711;
        Functions.ClearBuffer ( DIRECT_KEY_DAB__DOLLAR__ ) ; 
        __context__.SourceCodeLine = 712;
        Functions.ClearBuffer ( DIRECT_KEY_SIRIUS__DOLLAR__ ) ; 
        __context__.SourceCodeLine = 713;
        Functions.ClearBuffer ( FROMDEVICETEMP__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    TEMPSTRING__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3000, this );
    COMMAND__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
    SUB__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    SUB3__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
    MAINLEVELINT__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    ZONE2LEVELINT__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    MAINLEVELSENT__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    ZONE2LEVELSENT__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    ZONE3LEVELINT__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    ZONE3LEVELSENT__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    ZONE4LEVELINT__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    FROMDEVICETEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3000, this );
    
    AM_ENABLED = new Crestron.Logos.SplusObjects.DigitalInput( AM_ENABLED__DigitalInput__, this );
    m_DigitalInputList.Add( AM_ENABLED__DigitalInput__, AM_ENABLED );
    
    FM_ENABLED = new Crestron.Logos.SplusObjects.DigitalInput( FM_ENABLED__DigitalInput__, this );
    m_DigitalInputList.Add( FM_ENABLED__DigitalInput__, FM_ENABLED );
    
    AM_HD_ENABLED = new Crestron.Logos.SplusObjects.DigitalInput( AM_HD_ENABLED__DigitalInput__, this );
    m_DigitalInputList.Add( AM_HD_ENABLED__DigitalInput__, AM_HD_ENABLED );
    
    FM_HD_ENABLED = new Crestron.Logos.SplusObjects.DigitalInput( FM_HD_ENABLED__DigitalInput__, this );
    m_DigitalInputList.Add( FM_HD_ENABLED__DigitalInput__, FM_HD_ENABLED );
    
    SENDMAIN = new Crestron.Logos.SplusObjects.DigitalInput( SENDMAIN__DigitalInput__, this );
    m_DigitalInputList.Add( SENDMAIN__DigitalInput__, SENDMAIN );
    
    SENDZONE2 = new Crestron.Logos.SplusObjects.DigitalInput( SENDZONE2__DigitalInput__, this );
    m_DigitalInputList.Add( SENDZONE2__DigitalInput__, SENDZONE2 );
    
    SENDZONE3 = new Crestron.Logos.SplusObjects.DigitalInput( SENDZONE3__DigitalInput__, this );
    m_DigitalInputList.Add( SENDZONE3__DigitalInput__, SENDZONE3 );
    
    IPOD = new Crestron.Logos.SplusObjects.DigitalInput( IPOD__DigitalInput__, this );
    m_DigitalInputList.Add( IPOD__DigitalInput__, IPOD );
    
    USB = new Crestron.Logos.SplusObjects.DigitalInput( USB__DigitalInput__, this );
    m_DigitalInputList.Add( USB__DigitalInput__, USB );
    
    ENTER_AM_FM = new Crestron.Logos.SplusObjects.DigitalInput( ENTER_AM_FM__DigitalInput__, this );
    m_DigitalInputList.Add( ENTER_AM_FM__DigitalInput__, ENTER_AM_FM );
    
    ENTER_HD = new Crestron.Logos.SplusObjects.DigitalInput( ENTER_HD__DigitalInput__, this );
    m_DigitalInputList.Add( ENTER_HD__DigitalInput__, ENTER_HD );
    
    ENTER_XM = new Crestron.Logos.SplusObjects.DigitalInput( ENTER_XM__DigitalInput__, this );
    m_DigitalInputList.Add( ENTER_XM__DigitalInput__, ENTER_XM );
    
    ENTER_DAB = new Crestron.Logos.SplusObjects.DigitalInput( ENTER_DAB__DigitalInput__, this );
    m_DigitalInputList.Add( ENTER_DAB__DigitalInput__, ENTER_DAB );
    
    ENTER_SIRIUS = new Crestron.Logos.SplusObjects.DigitalInput( ENTER_SIRIUS__DigitalInput__, this );
    m_DigitalInputList.Add( ENTER_SIRIUS__DigitalInput__, ENTER_SIRIUS );
    
    MAINLEVEL = new Crestron.Logos.SplusObjects.AnalogOutput( MAINLEVEL__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MAINLEVEL__AnalogSerialOutput__, MAINLEVEL );
    
    ZONE2LEVEL = new Crestron.Logos.SplusObjects.AnalogOutput( ZONE2LEVEL__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ZONE2LEVEL__AnalogSerialOutput__, ZONE2LEVEL );
    
    ZONE3LEVEL = new Crestron.Logos.SplusObjects.AnalogOutput( ZONE3LEVEL__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ZONE3LEVEL__AnalogSerialOutput__, ZONE3LEVEL );
    
    MAINLEVEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MAINLEVEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAINLEVEL__DOLLAR____AnalogSerialOutput__, MAINLEVEL__DOLLAR__ );
    
    ZONE2LEVEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( ZONE2LEVEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE2LEVEL__DOLLAR____AnalogSerialOutput__, ZONE2LEVEL__DOLLAR__ );
    
    ZONE3LEVEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( ZONE3LEVEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE3LEVEL__DOLLAR____AnalogSerialOutput__, ZONE3LEVEL__DOLLAR__ );
    
    FLLEVEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( FLLEVEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( FLLEVEL__DOLLAR____AnalogSerialOutput__, FLLEVEL__DOLLAR__ );
    
    FRLEVEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( FRLEVEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( FRLEVEL__DOLLAR____AnalogSerialOutput__, FRLEVEL__DOLLAR__ );
    
    CLEVEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CLEVEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CLEVEL__DOLLAR____AnalogSerialOutput__, CLEVEL__DOLLAR__ );
    
    SWLEVEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SWLEVEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SWLEVEL__DOLLAR____AnalogSerialOutput__, SWLEVEL__DOLLAR__ );
    
    SW2LEVEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SW2LEVEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SW2LEVEL__DOLLAR____AnalogSerialOutput__, SW2LEVEL__DOLLAR__ );
    
    SLLEVEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SLLEVEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SLLEVEL__DOLLAR____AnalogSerialOutput__, SLLEVEL__DOLLAR__ );
    
    SRLEVEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SRLEVEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SRLEVEL__DOLLAR____AnalogSerialOutput__, SRLEVEL__DOLLAR__ );
    
    SBLLEVEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SBLLEVEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SBLLEVEL__DOLLAR____AnalogSerialOutput__, SBLLEVEL__DOLLAR__ );
    
    SBRLEVEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SBRLEVEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SBRLEVEL__DOLLAR____AnalogSerialOutput__, SBRLEVEL__DOLLAR__ );
    
    SBLEVEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SBLEVEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SBLEVEL__DOLLAR____AnalogSerialOutput__, SBLEVEL__DOLLAR__ );
    
    FHLLEVEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( FHLLEVEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( FHLLEVEL__DOLLAR____AnalogSerialOutput__, FHLLEVEL__DOLLAR__ );
    
    FHRLEVEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( FHRLEVEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( FHRLEVEL__DOLLAR____AnalogSerialOutput__, FHRLEVEL__DOLLAR__ );
    
    FWLLEVEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( FWLLEVEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( FWLLEVEL__DOLLAR____AnalogSerialOutput__, FWLLEVEL__DOLLAR__ );
    
    FWRLEVEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( FWRLEVEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( FWRLEVEL__DOLLAR____AnalogSerialOutput__, FWRLEVEL__DOLLAR__ );
    
    ANALOG_TUNER_FREQUENCY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( ANALOG_TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( ANALOG_TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, ANALOG_TUNER_FREQUENCY__DOLLAR__ );
    
    HD_TUNER_FREQUENCY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, HD_TUNER_FREQUENCY__DOLLAR__ );
    
    XM_TUNER_FREQUENCY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( XM_TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( XM_TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, XM_TUNER_FREQUENCY__DOLLAR__ );
    
    DAB_TUNER_FREQUENCY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DAB_TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DAB_TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, DAB_TUNER_FREQUENCY__DOLLAR__ );
    
    SIRIUS_TUNER_FREQUENCY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SIRIUS_TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUS_TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, SIRIUS_TUNER_FREQUENCY__DOLLAR__ );
    
    AM_FM_PRESET__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( AM_FM_PRESET__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( AM_FM_PRESET__DOLLAR____AnalogSerialOutput__, AM_FM_PRESET__DOLLAR__ );
    
    HD_PRESET__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_PRESET__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_PRESET__DOLLAR____AnalogSerialOutput__, HD_PRESET__DOLLAR__ );
    
    HD_STATION_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_STATION_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_STATION_NAME__DOLLAR____AnalogSerialOutput__, HD_STATION_NAME__DOLLAR__ );
    
    HD_STATION_NAME_LONG__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_STATION_NAME_LONG__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_STATION_NAME_LONG__DOLLAR____AnalogSerialOutput__, HD_STATION_NAME_LONG__DOLLAR__ );
    
    HD_SIGNAL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_SIGNAL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_SIGNAL__DOLLAR____AnalogSerialOutput__, HD_SIGNAL__DOLLAR__ );
    
    HD_MULTICAST_CURRENT_CH__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_MULTICAST_CURRENT_CH__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_MULTICAST_CURRENT_CH__DOLLAR____AnalogSerialOutput__, HD_MULTICAST_CURRENT_CH__DOLLAR__ );
    
    HD_MULTICAST_CH__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_MULTICAST_CH__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_MULTICAST_CH__DOLLAR____AnalogSerialOutput__, HD_MULTICAST_CH__DOLLAR__ );
    
    HD_PROGRAM_TYPE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_PROGRAM_TYPE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_PROGRAM_TYPE__DOLLAR____AnalogSerialOutput__, HD_PROGRAM_TYPE__DOLLAR__ );
    
    HD_ARTIST__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_ARTIST__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_ARTIST__DOLLAR____AnalogSerialOutput__, HD_ARTIST__DOLLAR__ );
    
    HD_TITLE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_TITLE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_TITLE__DOLLAR____AnalogSerialOutput__, HD_TITLE__DOLLAR__ );
    
    HD_ALBUM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_ALBUM__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_ALBUM__DOLLAR____AnalogSerialOutput__, HD_ALBUM__DOLLAR__ );
    
    HD_GENRE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_GENRE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_GENRE__DOLLAR____AnalogSerialOutput__, HD_GENRE__DOLLAR__ );
    
    XM_PRESET__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( XM_PRESET__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( XM_PRESET__DOLLAR____AnalogSerialOutput__, XM_PRESET__DOLLAR__ );
    
    XM_CHANNEL_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( XM_CHANNEL_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( XM_CHANNEL_NAME__DOLLAR____AnalogSerialOutput__, XM_CHANNEL_NAME__DOLLAR__ );
    
    XM_ARTIST__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( XM_ARTIST__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( XM_ARTIST__DOLLAR____AnalogSerialOutput__, XM_ARTIST__DOLLAR__ );
    
    XM_TITLE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( XM_TITLE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( XM_TITLE__DOLLAR____AnalogSerialOutput__, XM_TITLE__DOLLAR__ );
    
    XM_RADIO_ID__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( XM_RADIO_ID__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( XM_RADIO_ID__DOLLAR____AnalogSerialOutput__, XM_RADIO_ID__DOLLAR__ );
    
    XM_SIGNAL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( XM_SIGNAL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( XM_SIGNAL__DOLLAR____AnalogSerialOutput__, XM_SIGNAL__DOLLAR__ );
    
    DAB_STATION_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DAB_STATION_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DAB_STATION_NAME__DOLLAR____AnalogSerialOutput__, DAB_STATION_NAME__DOLLAR__ );
    
    DAB_STATION_NAME_LONG__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DAB_STATION_NAME_LONG__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DAB_STATION_NAME_LONG__DOLLAR____AnalogSerialOutput__, DAB_STATION_NAME_LONG__DOLLAR__ );
    
    DAB_ENSEMBLE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DAB_ENSEMBLE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DAB_ENSEMBLE__DOLLAR____AnalogSerialOutput__, DAB_ENSEMBLE__DOLLAR__ );
    
    DAB_PROGRAM_TYPE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DAB_PROGRAM_TYPE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DAB_PROGRAM_TYPE__DOLLAR____AnalogSerialOutput__, DAB_PROGRAM_TYPE__DOLLAR__ );
    
    DAB_CHANNEL_CH__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DAB_CHANNEL_CH__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DAB_CHANNEL_CH__DOLLAR____AnalogSerialOutput__, DAB_CHANNEL_CH__DOLLAR__ );
    
    DAB_FREQUENCY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DAB_FREQUENCY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DAB_FREQUENCY__DOLLAR____AnalogSerialOutput__, DAB_FREQUENCY__DOLLAR__ );
    
    DAB_MODE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DAB_MODE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DAB_MODE__DOLLAR____AnalogSerialOutput__, DAB_MODE__DOLLAR__ );
    
    DAB_SIGNAL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DAB_SIGNAL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DAB_SIGNAL__DOLLAR____AnalogSerialOutput__, DAB_SIGNAL__DOLLAR__ );
    
    DAB_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DAB_TIME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DAB_TIME__DOLLAR____AnalogSerialOutput__, DAB_TIME__DOLLAR__ );
    
    DAB_DATE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DAB_DATE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DAB_DATE__DOLLAR____AnalogSerialOutput__, DAB_DATE__DOLLAR__ );
    
    SIRIUS_PRESET__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SIRIUS_PRESET__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUS_PRESET__DOLLAR____AnalogSerialOutput__, SIRIUS_PRESET__DOLLAR__ );
    
    SIRIUS_CHANNEL_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SIRIUS_CHANNEL_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUS_CHANNEL_NAME__DOLLAR____AnalogSerialOutput__, SIRIUS_CHANNEL_NAME__DOLLAR__ );
    
    SIRIUS_ARTIST__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SIRIUS_ARTIST__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUS_ARTIST__DOLLAR____AnalogSerialOutput__, SIRIUS_ARTIST__DOLLAR__ );
    
    SIRIUS_TITLE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SIRIUS_TITLE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUS_TITLE__DOLLAR____AnalogSerialOutput__, SIRIUS_TITLE__DOLLAR__ );
    
    SIRIUS_RADIO_ID__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SIRIUS_RADIO_ID__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUS_RADIO_ID__DOLLAR____AnalogSerialOutput__, SIRIUS_RADIO_ID__DOLLAR__ );
    
    SIRIUS_SIGNAL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SIRIUS_SIGNAL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUS_SIGNAL__DOLLAR____AnalogSerialOutput__, SIRIUS_SIGNAL__DOLLAR__ );
    
    IPOD_LINE_0__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( IPOD_LINE_0__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPOD_LINE_0__DOLLAR____AnalogSerialOutput__, IPOD_LINE_0__DOLLAR__ );
    
    IPOD_LINE_1__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( IPOD_LINE_1__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPOD_LINE_1__DOLLAR____AnalogSerialOutput__, IPOD_LINE_1__DOLLAR__ );
    
    IPOD_LINE_2__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( IPOD_LINE_2__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPOD_LINE_2__DOLLAR____AnalogSerialOutput__, IPOD_LINE_2__DOLLAR__ );
    
    IPOD_LINE_3__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( IPOD_LINE_3__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPOD_LINE_3__DOLLAR____AnalogSerialOutput__, IPOD_LINE_3__DOLLAR__ );
    
    IPOD_LINE_4__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( IPOD_LINE_4__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPOD_LINE_4__DOLLAR____AnalogSerialOutput__, IPOD_LINE_4__DOLLAR__ );
    
    IPOD_LINE_5__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( IPOD_LINE_5__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPOD_LINE_5__DOLLAR____AnalogSerialOutput__, IPOD_LINE_5__DOLLAR__ );
    
    IPOD_LINE_6__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( IPOD_LINE_6__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPOD_LINE_6__DOLLAR____AnalogSerialOutput__, IPOD_LINE_6__DOLLAR__ );
    
    IPOD_LINE_7__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( IPOD_LINE_7__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPOD_LINE_7__DOLLAR____AnalogSerialOutput__, IPOD_LINE_7__DOLLAR__ );
    
    IPOD_LINE_8__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( IPOD_LINE_8__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPOD_LINE_8__DOLLAR____AnalogSerialOutput__, IPOD_LINE_8__DOLLAR__ );
    
    IPOD_LINE_9__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( IPOD_LINE_9__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPOD_LINE_9__DOLLAR____AnalogSerialOutput__, IPOD_LINE_9__DOLLAR__ );
    
    USB_NSA_LINE_0__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( USB_NSA_LINE_0__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( USB_NSA_LINE_0__DOLLAR____AnalogSerialOutput__, USB_NSA_LINE_0__DOLLAR__ );
    
    USB_NSA_LINE_1__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( USB_NSA_LINE_1__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( USB_NSA_LINE_1__DOLLAR____AnalogSerialOutput__, USB_NSA_LINE_1__DOLLAR__ );
    
    USB_NSA_LINE_2__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( USB_NSA_LINE_2__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( USB_NSA_LINE_2__DOLLAR____AnalogSerialOutput__, USB_NSA_LINE_2__DOLLAR__ );
    
    USB_NSA_LINE_3__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( USB_NSA_LINE_3__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( USB_NSA_LINE_3__DOLLAR____AnalogSerialOutput__, USB_NSA_LINE_3__DOLLAR__ );
    
    USB_NSA_LINE_4__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( USB_NSA_LINE_4__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( USB_NSA_LINE_4__DOLLAR____AnalogSerialOutput__, USB_NSA_LINE_4__DOLLAR__ );
    
    USB_NSA_LINE_5__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( USB_NSA_LINE_5__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( USB_NSA_LINE_5__DOLLAR____AnalogSerialOutput__, USB_NSA_LINE_5__DOLLAR__ );
    
    USB_NSA_LINE_6__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( USB_NSA_LINE_6__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( USB_NSA_LINE_6__DOLLAR____AnalogSerialOutput__, USB_NSA_LINE_6__DOLLAR__ );
    
    USB_NSA_LINE_7__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( USB_NSA_LINE_7__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( USB_NSA_LINE_7__DOLLAR____AnalogSerialOutput__, USB_NSA_LINE_7__DOLLAR__ );
    
    USB_NSA_LINE_8__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( USB_NSA_LINE_8__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( USB_NSA_LINE_8__DOLLAR____AnalogSerialOutput__, USB_NSA_LINE_8__DOLLAR__ );
    
    MSERVER_LINE_0__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MSERVER_LINE_0__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MSERVER_LINE_0__DOLLAR____AnalogSerialOutput__, MSERVER_LINE_0__DOLLAR__ );
    
    MSERVER_LINE_1__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MSERVER_LINE_1__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MSERVER_LINE_1__DOLLAR____AnalogSerialOutput__, MSERVER_LINE_1__DOLLAR__ );
    
    MSERVER_LINE_2__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MSERVER_LINE_2__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MSERVER_LINE_2__DOLLAR____AnalogSerialOutput__, MSERVER_LINE_2__DOLLAR__ );
    
    MSERVER_LINE_3__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MSERVER_LINE_3__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MSERVER_LINE_3__DOLLAR____AnalogSerialOutput__, MSERVER_LINE_3__DOLLAR__ );
    
    MSERVER_LINE_4__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MSERVER_LINE_4__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MSERVER_LINE_4__DOLLAR____AnalogSerialOutput__, MSERVER_LINE_4__DOLLAR__ );
    
    MSERVER_LINE_5__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MSERVER_LINE_5__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MSERVER_LINE_5__DOLLAR____AnalogSerialOutput__, MSERVER_LINE_5__DOLLAR__ );
    
    MSERVER_LINE_6__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MSERVER_LINE_6__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MSERVER_LINE_6__DOLLAR____AnalogSerialOutput__, MSERVER_LINE_6__DOLLAR__ );
    
    MSERVER_LINE_7__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MSERVER_LINE_7__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MSERVER_LINE_7__DOLLAR____AnalogSerialOutput__, MSERVER_LINE_7__DOLLAR__ );
    
    MSERVER_LINE_8__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MSERVER_LINE_8__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MSERVER_LINE_8__DOLLAR____AnalogSerialOutput__, MSERVER_LINE_8__DOLLAR__ );
    
    DIRECT_COMMAND_VALUE_DISPLAYED_AM_FM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECT_COMMAND_VALUE_DISPLAYED_AM_FM__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECT_COMMAND_VALUE_DISPLAYED_AM_FM__DOLLAR____AnalogSerialOutput__, DIRECT_COMMAND_VALUE_DISPLAYED_AM_FM__DOLLAR__ );
    
    DIRECT_COMMAND_VALUE_DISPLAYED_HD__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECT_COMMAND_VALUE_DISPLAYED_HD__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECT_COMMAND_VALUE_DISPLAYED_HD__DOLLAR____AnalogSerialOutput__, DIRECT_COMMAND_VALUE_DISPLAYED_HD__DOLLAR__ );
    
    DIRECT_COMMAND_VALUE_DISPLAYED_XM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECT_COMMAND_VALUE_DISPLAYED_XM__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECT_COMMAND_VALUE_DISPLAYED_XM__DOLLAR____AnalogSerialOutput__, DIRECT_COMMAND_VALUE_DISPLAYED_XM__DOLLAR__ );
    
    DIRECT_COMMAND_VALUE_DISPLAYED_DAB__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECT_COMMAND_VALUE_DISPLAYED_DAB__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECT_COMMAND_VALUE_DISPLAYED_DAB__DOLLAR____AnalogSerialOutput__, DIRECT_COMMAND_VALUE_DISPLAYED_DAB__DOLLAR__ );
    
    DIRECT_COMMAND_VALUE_DISPLAYED_SIRIUS__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECT_COMMAND_VALUE_DISPLAYED_SIRIUS__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECT_COMMAND_VALUE_DISPLAYED_SIRIUS__DOLLAR____AnalogSerialOutput__, DIRECT_COMMAND_VALUE_DISPLAYED_SIRIUS__DOLLAR__ );
    
    DIRECT_COMMAND__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECT_COMMAND__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECT_COMMAND__DOLLAR____AnalogSerialOutput__, DIRECT_COMMAND__DOLLAR__ );
    
    MUTE_MAIN__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MUTE_MAIN__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MUTE_MAIN__DOLLAR____AnalogSerialOutput__, MUTE_MAIN__DOLLAR__ );
    
    DIRECT_KEY_AM_FM__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( DIRECT_KEY_AM_FM__DOLLAR____AnalogSerialInput__, 12, this );
    m_StringInputList.Add( DIRECT_KEY_AM_FM__DOLLAR____AnalogSerialInput__, DIRECT_KEY_AM_FM__DOLLAR__ );
    
    DIRECT_KEY_HD__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( DIRECT_KEY_HD__DOLLAR____AnalogSerialInput__, 12, this );
    m_StringInputList.Add( DIRECT_KEY_HD__DOLLAR____AnalogSerialInput__, DIRECT_KEY_HD__DOLLAR__ );
    
    DIRECT_KEY_XM__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( DIRECT_KEY_XM__DOLLAR____AnalogSerialInput__, 12, this );
    m_StringInputList.Add( DIRECT_KEY_XM__DOLLAR____AnalogSerialInput__, DIRECT_KEY_XM__DOLLAR__ );
    
    DIRECT_KEY_DAB__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( DIRECT_KEY_DAB__DOLLAR____AnalogSerialInput__, 12, this );
    m_StringInputList.Add( DIRECT_KEY_DAB__DOLLAR____AnalogSerialInput__, DIRECT_KEY_DAB__DOLLAR__ );
    
    DIRECT_KEY_SIRIUS__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( DIRECT_KEY_SIRIUS__DOLLAR____AnalogSerialInput__, 12, this );
    m_StringInputList.Add( DIRECT_KEY_SIRIUS__DOLLAR____AnalogSerialInput__, DIRECT_KEY_SIRIUS__DOLLAR__ );
    
    FROMDEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROMDEVICE__DOLLAR____AnalogSerialInput__, 3000, this );
    m_StringInputList.Add( FROMDEVICE__DOLLAR____AnalogSerialInput__, FROMDEVICE__DOLLAR__ );
    
    
    DIRECT_KEY_AM_FM__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( DIRECT_KEY_AM_FM__DOLLAR___OnChange_0, false ) );
    DIRECT_KEY_HD__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( DIRECT_KEY_HD__DOLLAR___OnChange_1, false ) );
    DIRECT_KEY_XM__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( DIRECT_KEY_XM__DOLLAR___OnChange_2, false ) );
    DIRECT_KEY_DAB__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( DIRECT_KEY_DAB__DOLLAR___OnChange_3, false ) );
    DIRECT_KEY_SIRIUS__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( DIRECT_KEY_SIRIUS__DOLLAR___OnChange_4, false ) );
    FROMDEVICE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROMDEVICE__DOLLAR___OnChange_5, false ) );
    SENDMAIN.OnDigitalPush.Add( new InputChangeHandlerWrapper( SENDMAIN_OnPush_6, false ) );
    SENDZONE2.OnDigitalPush.Add( new InputChangeHandlerWrapper( SENDZONE2_OnPush_7, false ) );
    SENDZONE3.OnDigitalPush.Add( new InputChangeHandlerWrapper( SENDZONE3_OnPush_8, false ) );
    ENTER_AM_FM.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENTER_AM_FM_OnPush_9, false ) );
    ENTER_HD.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENTER_HD_OnPush_10, false ) );
    ENTER_XM.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENTER_XM_OnPush_11, false ) );
    ENTER_DAB.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENTER_DAB_OnPush_12, false ) );
    ENTER_SIRIUS.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENTER_SIRIUS_OnPush_13, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_DENON_AVR_4311CI_V1_0_PROCESSOR ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint AM_ENABLED__DigitalInput__ = 0;
const uint FM_ENABLED__DigitalInput__ = 1;
const uint AM_HD_ENABLED__DigitalInput__ = 2;
const uint FM_HD_ENABLED__DigitalInput__ = 3;
const uint SENDMAIN__DigitalInput__ = 4;
const uint SENDZONE2__DigitalInput__ = 5;
const uint SENDZONE3__DigitalInput__ = 6;
const uint IPOD__DigitalInput__ = 7;
const uint USB__DigitalInput__ = 8;
const uint ENTER_AM_FM__DigitalInput__ = 9;
const uint ENTER_HD__DigitalInput__ = 10;
const uint ENTER_XM__DigitalInput__ = 11;
const uint ENTER_DAB__DigitalInput__ = 12;
const uint ENTER_SIRIUS__DigitalInput__ = 13;
const uint DIRECT_KEY_AM_FM__DOLLAR____AnalogSerialInput__ = 0;
const uint DIRECT_KEY_HD__DOLLAR____AnalogSerialInput__ = 1;
const uint DIRECT_KEY_XM__DOLLAR____AnalogSerialInput__ = 2;
const uint DIRECT_KEY_DAB__DOLLAR____AnalogSerialInput__ = 3;
const uint DIRECT_KEY_SIRIUS__DOLLAR____AnalogSerialInput__ = 4;
const uint FROMDEVICE__DOLLAR____AnalogSerialInput__ = 5;
const uint MAINLEVEL__AnalogSerialOutput__ = 0;
const uint ZONE2LEVEL__AnalogSerialOutput__ = 1;
const uint ZONE3LEVEL__AnalogSerialOutput__ = 2;
const uint MAINLEVEL__DOLLAR____AnalogSerialOutput__ = 3;
const uint ZONE2LEVEL__DOLLAR____AnalogSerialOutput__ = 4;
const uint ZONE3LEVEL__DOLLAR____AnalogSerialOutput__ = 5;
const uint FLLEVEL__DOLLAR____AnalogSerialOutput__ = 6;
const uint FRLEVEL__DOLLAR____AnalogSerialOutput__ = 7;
const uint CLEVEL__DOLLAR____AnalogSerialOutput__ = 8;
const uint SWLEVEL__DOLLAR____AnalogSerialOutput__ = 9;
const uint SW2LEVEL__DOLLAR____AnalogSerialOutput__ = 10;
const uint SLLEVEL__DOLLAR____AnalogSerialOutput__ = 11;
const uint SRLEVEL__DOLLAR____AnalogSerialOutput__ = 12;
const uint SBLLEVEL__DOLLAR____AnalogSerialOutput__ = 13;
const uint SBRLEVEL__DOLLAR____AnalogSerialOutput__ = 14;
const uint SBLEVEL__DOLLAR____AnalogSerialOutput__ = 15;
const uint FHLLEVEL__DOLLAR____AnalogSerialOutput__ = 16;
const uint FHRLEVEL__DOLLAR____AnalogSerialOutput__ = 17;
const uint FWLLEVEL__DOLLAR____AnalogSerialOutput__ = 18;
const uint FWRLEVEL__DOLLAR____AnalogSerialOutput__ = 19;
const uint ANALOG_TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__ = 20;
const uint HD_TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__ = 21;
const uint XM_TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__ = 22;
const uint DAB_TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__ = 23;
const uint SIRIUS_TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__ = 24;
const uint AM_FM_PRESET__DOLLAR____AnalogSerialOutput__ = 25;
const uint HD_PRESET__DOLLAR____AnalogSerialOutput__ = 26;
const uint HD_STATION_NAME__DOLLAR____AnalogSerialOutput__ = 27;
const uint HD_STATION_NAME_LONG__DOLLAR____AnalogSerialOutput__ = 28;
const uint HD_SIGNAL__DOLLAR____AnalogSerialOutput__ = 29;
const uint HD_MULTICAST_CURRENT_CH__DOLLAR____AnalogSerialOutput__ = 30;
const uint HD_MULTICAST_CH__DOLLAR____AnalogSerialOutput__ = 31;
const uint HD_PROGRAM_TYPE__DOLLAR____AnalogSerialOutput__ = 32;
const uint HD_ARTIST__DOLLAR____AnalogSerialOutput__ = 33;
const uint HD_TITLE__DOLLAR____AnalogSerialOutput__ = 34;
const uint HD_ALBUM__DOLLAR____AnalogSerialOutput__ = 35;
const uint HD_GENRE__DOLLAR____AnalogSerialOutput__ = 36;
const uint XM_PRESET__DOLLAR____AnalogSerialOutput__ = 37;
const uint XM_CHANNEL_NAME__DOLLAR____AnalogSerialOutput__ = 38;
const uint XM_ARTIST__DOLLAR____AnalogSerialOutput__ = 39;
const uint XM_TITLE__DOLLAR____AnalogSerialOutput__ = 40;
const uint XM_RADIO_ID__DOLLAR____AnalogSerialOutput__ = 41;
const uint XM_SIGNAL__DOLLAR____AnalogSerialOutput__ = 42;
const uint DAB_STATION_NAME__DOLLAR____AnalogSerialOutput__ = 43;
const uint DAB_STATION_NAME_LONG__DOLLAR____AnalogSerialOutput__ = 44;
const uint DAB_ENSEMBLE__DOLLAR____AnalogSerialOutput__ = 45;
const uint DAB_PROGRAM_TYPE__DOLLAR____AnalogSerialOutput__ = 46;
const uint DAB_CHANNEL_CH__DOLLAR____AnalogSerialOutput__ = 47;
const uint DAB_FREQUENCY__DOLLAR____AnalogSerialOutput__ = 48;
const uint DAB_MODE__DOLLAR____AnalogSerialOutput__ = 49;
const uint DAB_SIGNAL__DOLLAR____AnalogSerialOutput__ = 50;
const uint DAB_TIME__DOLLAR____AnalogSerialOutput__ = 51;
const uint DAB_DATE__DOLLAR____AnalogSerialOutput__ = 52;
const uint SIRIUS_PRESET__DOLLAR____AnalogSerialOutput__ = 53;
const uint SIRIUS_CHANNEL_NAME__DOLLAR____AnalogSerialOutput__ = 54;
const uint SIRIUS_ARTIST__DOLLAR____AnalogSerialOutput__ = 55;
const uint SIRIUS_TITLE__DOLLAR____AnalogSerialOutput__ = 56;
const uint SIRIUS_RADIO_ID__DOLLAR____AnalogSerialOutput__ = 57;
const uint SIRIUS_SIGNAL__DOLLAR____AnalogSerialOutput__ = 58;
const uint IPOD_LINE_0__DOLLAR____AnalogSerialOutput__ = 59;
const uint IPOD_LINE_1__DOLLAR____AnalogSerialOutput__ = 60;
const uint IPOD_LINE_2__DOLLAR____AnalogSerialOutput__ = 61;
const uint IPOD_LINE_3__DOLLAR____AnalogSerialOutput__ = 62;
const uint IPOD_LINE_4__DOLLAR____AnalogSerialOutput__ = 63;
const uint IPOD_LINE_5__DOLLAR____AnalogSerialOutput__ = 64;
const uint IPOD_LINE_6__DOLLAR____AnalogSerialOutput__ = 65;
const uint IPOD_LINE_7__DOLLAR____AnalogSerialOutput__ = 66;
const uint IPOD_LINE_8__DOLLAR____AnalogSerialOutput__ = 67;
const uint IPOD_LINE_9__DOLLAR____AnalogSerialOutput__ = 68;
const uint USB_NSA_LINE_0__DOLLAR____AnalogSerialOutput__ = 69;
const uint USB_NSA_LINE_1__DOLLAR____AnalogSerialOutput__ = 70;
const uint USB_NSA_LINE_2__DOLLAR____AnalogSerialOutput__ = 71;
const uint USB_NSA_LINE_3__DOLLAR____AnalogSerialOutput__ = 72;
const uint USB_NSA_LINE_4__DOLLAR____AnalogSerialOutput__ = 73;
const uint USB_NSA_LINE_5__DOLLAR____AnalogSerialOutput__ = 74;
const uint USB_NSA_LINE_6__DOLLAR____AnalogSerialOutput__ = 75;
const uint USB_NSA_LINE_7__DOLLAR____AnalogSerialOutput__ = 76;
const uint USB_NSA_LINE_8__DOLLAR____AnalogSerialOutput__ = 77;
const uint MSERVER_LINE_0__DOLLAR____AnalogSerialOutput__ = 78;
const uint MSERVER_LINE_1__DOLLAR____AnalogSerialOutput__ = 79;
const uint MSERVER_LINE_2__DOLLAR____AnalogSerialOutput__ = 80;
const uint MSERVER_LINE_3__DOLLAR____AnalogSerialOutput__ = 81;
const uint MSERVER_LINE_4__DOLLAR____AnalogSerialOutput__ = 82;
const uint MSERVER_LINE_5__DOLLAR____AnalogSerialOutput__ = 83;
const uint MSERVER_LINE_6__DOLLAR____AnalogSerialOutput__ = 84;
const uint MSERVER_LINE_7__DOLLAR____AnalogSerialOutput__ = 85;
const uint MSERVER_LINE_8__DOLLAR____AnalogSerialOutput__ = 86;
const uint DIRECT_COMMAND_VALUE_DISPLAYED_AM_FM__DOLLAR____AnalogSerialOutput__ = 87;
const uint DIRECT_COMMAND_VALUE_DISPLAYED_HD__DOLLAR____AnalogSerialOutput__ = 88;
const uint DIRECT_COMMAND_VALUE_DISPLAYED_XM__DOLLAR____AnalogSerialOutput__ = 89;
const uint DIRECT_COMMAND_VALUE_DISPLAYED_DAB__DOLLAR____AnalogSerialOutput__ = 90;
const uint DIRECT_COMMAND_VALUE_DISPLAYED_SIRIUS__DOLLAR____AnalogSerialOutput__ = 91;
const uint DIRECT_COMMAND__DOLLAR____AnalogSerialOutput__ = 92;
const uint MUTE_MAIN__DOLLAR____AnalogSerialOutput__ = 93;

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
