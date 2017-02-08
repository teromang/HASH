namespace Ultamation.SimplSharp.AppleDaap;
        // class declarations
         class DacpClient;
         class DeviceReportEventArgs;
         class DiagnosticReportEventArgs;
         class KeyboardReportEventArgs;
         class StatusReportEventArgs;
     class DacpClient 
    {
        // class delegates

        // class events
        EventHandler DiagnosticReport ( DacpClient sender, DiagnosticReportEventArgs args );
        EventHandler StatusReport ( DacpClient sender, StatusReportEventArgs args );
        EventHandler DeviceReport ( DacpClient sender, DeviceReportEventArgs args );
        EventHandler KeyboardReport ( DacpClient sender, KeyboardReportEventArgs args );

        // class functions
        FUNCTION InitialiseWithName ( SIMPLSHARPSTRING appleId , SIMPLSHARPSTRING password , SIMPLSHARPSTRING token , SIMPLSHARPSTRING devName );
        FUNCTION Initialise ( SIMPLSHARPSTRING appleId , SIMPLSHARPSTRING password , SIMPLSHARPSTRING token , SIMPLSHARPSTRING devAddress );
        FUNCTION ForceAuthenticate ();
        FUNCTION Debug ( INTEGER on );
        FUNCTION Navigate ( INTEGER mode );
        FUNCTION Touch ( INTEGER mode , INTEGER xpos , INTEGER ypos );
        FUNCTION PlayPause ();
        FUNCTION Play ();
        FUNCTION Pause ();
        FUNCTION Stop ();
        FUNCTION SkipFwd ();
        FUNCTION SkipBack ();
        FUNCTION SetVolume ( INTEGER vol );
        FUNCTION SetTime ( INTEGER time );
        FUNCTION SetPosition ( INTEGER pos );
        FUNCTION UpdateText ( SIMPLSHARPSTRING input );
        FUNCTION SendText ( SIMPLSHARPSTRING input );
        FUNCTION PlayerStatus ( INTEGER force );
        FUNCTION KeyboardStatus ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Password[];
    };

     class DeviceReportEventArgs 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        SIMPLSHARPSTRING Name[];
        INTEGER DbCount;

        // class properties
    };

     class DiagnosticReportEventArgs 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER Status;
        SIMPLSHARPSTRING Message[];

        // class properties
    };

     class KeyboardReportEventArgs 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        SIMPLSHARPSTRING Title[];
        INTEGER ShowKeyboard;
        INTEGER Secure;

        // class properties
    };

     class StatusReportEventArgs 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER State;
        INTEGER Shuffle;
        INTEGER Repeat;
        SIMPLSHARPSTRING Track[];
        SIMPLSHARPSTRING Artist[];
        SIMPLSHARPSTRING Album[];
        SIMPLSHARPSTRING AlbumArtURL[];
        INTEGER TimeSec;
        INTEGER TimeRemSec;
        INTEGER TimeTrackSec;
        INTEGER Position;

        // class properties
    };

