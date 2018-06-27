using System;
using System.Text;
using System.Linq;
using Crestron.SimplSharp;                          				// For Basic SIMPL# Classes
using Crestron.SimplSharp.CrestronIO;
using Newtonsoft.Json;
using System.Collections.Generic;
using Crestron.SimplSharp.WebScripting;   

namespace IMS_Configuration
{
    public static class Configuration
    {
        public static RootObject Obj { set; get; }
        public static string filePath { set; get; }

        public static void Reader()
        {
            string JsonString;

            if (File.Exists(filePath))       //Ok make sure the file is there
            {
                StreamReader TheFile = new StreamReader(filePath);
                JsonString = TheFile.ReadToEnd();
                TheFile.Close();
                
            }
            else
            {
                //TODO IF FILE NOT FOUND, CREATE ONE
                CrestronConsole.PrintLine("File Not found\n\r");    //Generate error
                JsonString = "";

            }

            Obj = JsonConvert.DeserializeObject<RootObject>(JsonString); //All the heavy lifting

        }

        public static void Writer()
        {

            if (File.Exists(filePath))       //Ok make sure the file is there
            {
                StreamWriter TheFile = new StreamWriter(filePath, false);
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(TheFile, Obj);
                TheFile.Close();
                CrestronConsole.PrintLine("The Config File was written!\n\r");    //Generate Message

            }
            else
            {
                //TODO IF FILE NOT FOUND, CREATE ONE
                CrestronConsole.PrintLine("File Not found\n\r");    //Generate error

            }

        }
    }

    public class Display
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public ushort Screen_Enabled { get; set; }
        public ushort Switcher_Value { get; set; }
        public ushort Icon_Value { get; set; }
        public ushort Warming_Time { get; set; }
        public SSI_Display_Usage SSI_Display_Usage { get; set; }
        public SSI_Equipment_Status SSI_Equipment_Status { get; set; }
    }

    public class PresentationInput
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Generic_Page_Text { get; set; }
        public ushort Switcher_Value { get; set; }
        public ushort Icon_Value { get; set; }
        public SSI_Device_Usage SSI_Device_Usage { get; set; }
        public SSI_Equipment_Status SSI_Equipment_Status { get; set; }
    }

    public class ATC
    {
        public string Extension { get; set; }
        public string Help_Number { get; set; }
        public string Help_Button_Text { get; set; }
        public string Connected_Dial_Text { get; set; }
        public string Disconnected_Dial_Text { get; set; }
        public string Connected_Hangup_Text { get; set; }
        public string Disconnected_Hangup_Text { get; set; }
        public SSI_Device_Usage SSI_Device_Usage { get; set; }
        public SSI_Equipment_Status SSI_Equipment_Status { get; set; }

    }

    public class Preset
    {
        public string Type { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class Generic_Device
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string ValueName1 { get; set; }
        public string Value1 { get; set; }
        public string ValueName2 { get; set; }
        public string Value2 { get; set; }
        public string ValueName3 { get; set; }
        public string Value3 { get; set; }
        public string ValueName4 { get; set; }
        public string Value4 { get; set; }
        public SSI_Equipment_Status SSI_Equipment_Status { get; set; }
        public SSI_Device_Usage SSI_Device_Usage { get; set; }
    }

    public class Camera
    {
        public List<Preset> Presets { get; set; }
        public Preset[] PresetsArray { get; set; }

        public void PresetToArray()
        {
            PresetsArray = Presets.ToArray();
        }
        public SSI_Device_Usage SSI_Device_Usage { get; set; }
        public SSI_Equipment_Status SSI_Equipment_Status { get; set; }
    }

    public class VTC
    {
        public string Extension { get; set; }
        public string Help_Number { get; set; }
        public string Help_Button_Text { get; set; }
        public string Connected_Dial_Text { get; set; }
        public string Disconnected_Dial_Text { get; set; }
        public string Connected_Hangup_Text { get; set; }
        public string Disconnected_Hangup_Text { get; set; }
        public SSI_Device_Usage SSI_Device_Usage { get; set; }
        public SSI_Equipment_Status SSI_Equipment_Status { get; set; }
    }

    public class PowerSequencer
    {
        public string Channel_1_Name { get; set; }
        public string Channel_2_Name { get; set; }
        public string Channel_3_Name { get; set; }
        public string Channel_4_Name { get; set; }
        public string Channel_5_Name { get; set; }
        public string Channel_6_Name { get; set; }
        public string Channel_7_Name { get; set; }
        public string Channel_8_Name { get; set; }
        public SSI_Equipment_Status SSI_Equipment_Status { get; set; }
    }

    public class SSI_Display_Usage
    {
        public string Display_Name { get; set; }
    }

    public class SSI_Device_Usage
    {
        public string Device_Type { get; set; }
        public string Device_Name { get; set; }
    }

    public class SSI_Equipment_Status
    {
        public string Severity_Message { get; set; }
        public string Error_Text { get; set; }
        public string Ok_Text { get; set; }
    }

    public class Lighting
    {
        public List<Preset> Presets { get; set; }
        public Preset[] PresetsArray { get; set; }
        public SSI_Equipment_Status SSI_Equipment_Status { get; set; }
        public void PresetToArray()
        {
            PresetsArray = Presets.ToArray();
        }
    }

    public class RootObject
    {
        public string Room_Name { get; set; }
        public string Welcome_Text { get; set; }
        public string Shutdown_Text { get; set; }
        public string Warming_Text { get; set; }
        public string Cooling_Text { get; set; }
        public ushort Startup_Time { get; set; }
        public ushort Shutdown_Time_Display_Active { get; set; }
        public ushort Shutdown_Time_Display_Inactive { get; set; }
        public ushort Microphone_Mute_Enable { get; set; }
        public string Microphone_Muted_Text { get; set; }
        public string Microphone_Muted_Not_Text { get; set; }
        public string Presentation_Page_Text { get; set; }
        public List<Display> Displays { get; set; }
        public Display[] DisplayArray { get; set; }
        public List<Camera> Cameras { get; set; }
        public Camera[] CameraArray { get; set; }
        public List<PresentationInput> Presentation_Inputs { get; set; }
        public PresentationInput[] PresentationInputArray { get; set; }
        public ATC ATC { get; set; }
        public VTC VTC { get; set; }
        public Lighting Lighting { get; set; }
        public List<PowerSequencer> Power_Sequencer { get; set; }
        public PowerSequencer[] PowerSequencerArray { get; set; }
        public List<Generic_Device> Generic_Device { get; set; }
        public Generic_Device[] GenericDeviceArray { get; set; }

        public void DisplaysToArray()
        {
            DisplayArray = this.Displays.ToArray();
        }

        public void PresentationToArray()
        {
            PresentationInputArray = Presentation_Inputs.ToArray();
        }

        public void CameraToArray()
        {
            CameraArray = Cameras.ToArray();
        }

        public void PowerSequencerToArray()
        {
            PowerSequencerArray = Power_Sequencer.ToArray();
        }

        public void GenericDeviceToArray()
        {
            GenericDeviceArray = Generic_Device.ToArray();
        }
    }

    public class RESTfulApi
    {
        /// <summary>
        /// Locking object
        /// </summary>
        private CCriticalSection _ServerLock = new CCriticalSection();

        /// <summary>
        /// The Http Cws Server
        /// </summary>
        private HttpCwsServer _Server;

        public string ProgramNumber { set; get; }

        /// <summary>
        /// Constructor
        /// </summary>
        public RESTfulApi()
        {
        }

        /// <summary>
        /// Start the HTTP Server
        /// </summary>
        public void Start()
        {
            try
            {
                _ServerLock.Enter();
                if (_Server == null)
                {
                    CrestronConsole.PrintLine("Starting RESTful CWS API HTTP Server");
                    _Server = new HttpCwsServer("/API/" + ProgramNumber + "/");
                    _Server.HttpRequestHandler = new _Server_Handler(_Server, ProgramNumber);
                    _Server.Routes.Add(new HttpCwsRoute("configuration") { Name = "CONFIGURATION.GET" });
                    _Server.Routes.Add(new HttpCwsRoute("configuration/set") { Name = "CONFIGURATION.SET" });
                    // register the server
                    _Server.Register();
                    CrestronConsole.PrintLine("Started RESTful CWS API HTTP Server");
                }
                else
                {
                    throw new InvalidOperationException("Server is already running");
                }
            }
            finally
            {
                _ServerLock.Leave();
            }
        }

        /// <summary>
        /// Stop the server
        /// </summary>
        public void Stop()
        {
            try
            {
                _ServerLock.Enter();
                if (_Server != null)
                {
                    CrestronConsole.PrintLine("Stopping RESTful CWS API HTTP Server");
                    _Server.Unregister();
                    _Server = null;
                    CrestronConsole.PrintLine("Stopped RESTful CWS API HTTP Server");
                }
                else
                {
                    throw new InvalidOperationException("Server was not running");
                }
            }
            finally
            {
                _ServerLock.Leave();
            }
        }

        class _Server_Handler : IHttpCwsHandler
        {
            private HttpCwsServer _Server;
            private String slotNumber;

            public _Server_Handler(HttpCwsServer _Server, string slotNumber)
            {
                this._Server = _Server;
                this.slotNumber = slotNumber;
            }

            /// <summary>
            /// Returns the API Help
            /// </summary>
            /// <returns></returns>
            private List<string> GetApiHelp()
            {
                var ApiCommands = new List<string>() {
                        "[GET] Get Configuration: /configuration",
                        "[PUT] Set Configuration: /configuration",
                    };
                return ApiCommands;
            }

            void IHttpCwsHandler.ProcessRequest(HttpCwsContext context)
            {
                try
                {
                    context.Response.ContentType = "application/json";
                    context.Response.AppendHeader("Access-Control-Allow-Origin", "*");
                    context.Response.AppendHeader("Access-Control-Allow-Headers", "Content-Type");
                    context.Response.AppendHeader("Access-Control-Allow-Methods", "GET, PUT, POST");
                    //CrestronConsole.PrintLine("HttpMethod: " + context.Request.HttpMethod);
                    //CrestronConsole.PrintLine("HttpPath: " + context.Request.Path);
                    //CrestronConsole.PrintLine("Httpname: " + context.Request.RouteData.Route.Name);
                    if (context.Request.Path.ToUpper() == "/CWS/API/" + this.slotNumber + "/CONFIGURATION/")
                    {
                        context.Response.StatusCode = 200;
                        switch (context.Request.HttpMethod)
                        {
                            case ("GET"):
                                Configuration.Reader();
                                context.Response.Write(JsonConvert.SerializeObject(Configuration.Obj), true);
                                break;

                            case ("PUT"):
                                string JsonString;
                                StreamReader TheFile = new StreamReader(context.Request.InputStream);
                                JsonString = TheFile.ReadToEnd();
                                TheFile.Close();
                                //CrestronConsole.PrintLine("JsonString: " + JsonString);
                                Configuration.Obj = JsonConvert.DeserializeObject<RootObject>(JsonString);
                                Configuration.Writer();
                                context.Response.StatusCode = 204;
                                context.Response.Write(JsonConvert.SerializeObject(Configuration.Obj), true);
                                break;
                            default:
                                context.Response.StatusCode = 200;
                                context.Response.Write(JsonConvert.SerializeObject(GetApiHelp()), true);
                                break;
                        }
                    }
                    else
                    {
                        context.Response.StatusCode = 200;
                        context.Response.Write(JsonConvert.SerializeObject(GetApiHelp()), true);
                    }

                }
                catch (Exception ex)
                {
                    context.Response.ContentType = "text/html";
                    context.Response.StatusCode = 401;
                    context.Response.Write(_Server.HtmlEncode(String.Format("<HTML><HEAD>ERROR</HEAD><BODY>The following error occurred: {0}. Stacktrace: {1}</BODY></HEAD></HTML>", ex.Message, ex.StackTrace)), true);
                }
            }
        }
    }

    public class ApiError
    {

        /// <summary>
        /// Message to send
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// List of error messages
        /// </summary>
        public List<string> Errors { get; set; }

        /// <summary>
        /// Status code
        /// </summary>
        public int Status { get; set; }
    }
}
