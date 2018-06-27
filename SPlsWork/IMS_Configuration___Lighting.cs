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
using IMS_Configuration;

namespace UserModule_IMS_CONFIGURATION___LIGHTING
{
    public class UserModuleClass_IMS_CONFIGURATION___LIGHTING : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.DigitalInput PULL_CONFIG;
        Crestron.Logos.SplusObjects.StringOutput LIGHTING_PRESET1_ID;
        Crestron.Logos.SplusObjects.StringOutput LIGHTING_PRESET1_NAME;
        Crestron.Logos.SplusObjects.StringOutput LIGHTING_PRESET2_ID;
        Crestron.Logos.SplusObjects.StringOutput LIGHTING_PRESET2_NAME;
        Crestron.Logos.SplusObjects.StringOutput LIGHTING_PRESET3_ID;
        Crestron.Logos.SplusObjects.StringOutput LIGHTING_PRESET3_NAME;
        Crestron.Logos.SplusObjects.StringOutput LIGHTING_PRESET4_ID;
        Crestron.Logos.SplusObjects.StringOutput LIGHTING_PRESET4_NAME;
        Crestron.Logos.SplusObjects.StringOutput LIGHTING_PRESET5_ID;
        Crestron.Logos.SplusObjects.StringOutput LIGHTING_PRESET5_NAME;
        Crestron.Logos.SplusObjects.StringOutput LIGHTING_PRESET6_ID;
        Crestron.Logos.SplusObjects.StringOutput LIGHTING_PRESET6_NAME;
        Crestron.Logos.SplusObjects.StringOutput LIGHTING_SSI_SEVERITY_MESSAGE;
        Crestron.Logos.SplusObjects.StringOutput LIGHTING_SSI_ERROR_TEXT;
        Crestron.Logos.SplusObjects.StringOutput LIGHTING_SSI_OK_TEXT;
        object PULL_CONFIG_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                 Configuration.Obj.Lighting.PresetToArray()  ;  
 
                
                __context__.SourceCodeLine = 164;
                try 
                    { 
                    __context__.SourceCodeLine = 165;
                    LIGHTING_PRESET1_ID  .UpdateValue ( Configuration . Obj . Lighting . PresetsArray [ 0] . Id  ) ; 
                    __context__.SourceCodeLine = 166;
                    LIGHTING_PRESET1_NAME  .UpdateValue ( Configuration . Obj . Lighting . PresetsArray [ 0] . Name  ) ; 
                    } 
                
                catch (Exception __splus_exception__)
                    { 
                    SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                    
                    
                    }
                    
                    __context__.SourceCodeLine = 167;
                    ; 
                    __context__.SourceCodeLine = 168;
                    try 
                        { 
                        __context__.SourceCodeLine = 169;
                        LIGHTING_PRESET2_ID  .UpdateValue ( Configuration . Obj . Lighting . PresetsArray [ 1] . Id  ) ; 
                        __context__.SourceCodeLine = 170;
                        LIGHTING_PRESET2_NAME  .UpdateValue ( Configuration . Obj . Lighting . PresetsArray [ 1] . Name  ) ; 
                        } 
                    
                    catch (Exception __splus_exception__)
                        { 
                        SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                        
                        
                        }
                        
                        __context__.SourceCodeLine = 171;
                        ; 
                        __context__.SourceCodeLine = 172;
                        try 
                            { 
                            __context__.SourceCodeLine = 173;
                            LIGHTING_PRESET3_ID  .UpdateValue ( Configuration . Obj . Lighting . PresetsArray [ 2] . Id  ) ; 
                            __context__.SourceCodeLine = 174;
                            LIGHTING_PRESET3_NAME  .UpdateValue ( Configuration . Obj . Lighting . PresetsArray [ 2] . Name  ) ; 
                            } 
                        
                        catch (Exception __splus_exception__)
                            { 
                            SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                            
                            
                            }
                            
                            __context__.SourceCodeLine = 175;
                            ; 
                            __context__.SourceCodeLine = 176;
                            try 
                                { 
                                __context__.SourceCodeLine = 177;
                                LIGHTING_PRESET4_ID  .UpdateValue ( Configuration . Obj . Lighting . PresetsArray [ 3] . Id  ) ; 
                                __context__.SourceCodeLine = 178;
                                LIGHTING_PRESET4_NAME  .UpdateValue ( Configuration . Obj . Lighting . PresetsArray [ 3] . Name  ) ; 
                                } 
                            
                            catch (Exception __splus_exception__)
                                { 
                                SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                
                                
                                }
                                
                                __context__.SourceCodeLine = 179;
                                ; 
                                __context__.SourceCodeLine = 180;
                                try 
                                    { 
                                    __context__.SourceCodeLine = 181;
                                    LIGHTING_PRESET5_ID  .UpdateValue ( Configuration . Obj . Lighting . PresetsArray [ 4] . Id  ) ; 
                                    __context__.SourceCodeLine = 182;
                                    LIGHTING_PRESET5_NAME  .UpdateValue ( Configuration . Obj . Lighting . PresetsArray [ 4] . Name  ) ; 
                                    } 
                                
                                catch (Exception __splus_exception__)
                                    { 
                                    SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                    
                                    
                                    }
                                    
                                    __context__.SourceCodeLine = 183;
                                    ; 
                                    __context__.SourceCodeLine = 184;
                                    try 
                                        { 
                                        __context__.SourceCodeLine = 185;
                                        LIGHTING_PRESET6_ID  .UpdateValue ( Configuration . Obj . Lighting . PresetsArray [ 5] . Id  ) ; 
                                        __context__.SourceCodeLine = 186;
                                        LIGHTING_PRESET6_NAME  .UpdateValue ( Configuration . Obj . Lighting . PresetsArray [ 5] . Name  ) ; 
                                        } 
                                    
                                    catch (Exception __splus_exception__)
                                        { 
                                        SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                        
                                        
                                        }
                                        
                                        __context__.SourceCodeLine = 187;
                                        ; 
                                        __context__.SourceCodeLine = 188;
                                        LIGHTING_SSI_SEVERITY_MESSAGE  .UpdateValue ( Configuration . Obj . Lighting . SSI_Equipment_Status . Severity_Message  ) ; 
                                        __context__.SourceCodeLine = 189;
                                        LIGHTING_SSI_ERROR_TEXT  .UpdateValue ( Configuration . Obj . Lighting . SSI_Equipment_Status . Error_Text  ) ; 
                                        __context__.SourceCodeLine = 190;
                                        LIGHTING_SSI_OK_TEXT  .UpdateValue ( Configuration . Obj . Lighting . SSI_Equipment_Status . Ok_Text  ) ; 
                                        
                                        
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
                                    
                                    
                                    
                                }
                                catch(Exception e) { ObjectCatchHandler(e); }
                                finally { ObjectFinallyHandler(); }
                                return __obj__;
                                }
                                
                            
                            public override void LogosSplusInitialize()
                            {
                                SocketInfo __socketinfo__ = new SocketInfo( 1, this );
                                InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
                                _SplusNVRAM = new SplusNVRAM( this );
                                
                                PULL_CONFIG = new Crestron.Logos.SplusObjects.DigitalInput( PULL_CONFIG__DigitalInput__, this );
                                m_DigitalInputList.Add( PULL_CONFIG__DigitalInput__, PULL_CONFIG );
                                
                                LIGHTING_PRESET1_ID = new Crestron.Logos.SplusObjects.StringOutput( LIGHTING_PRESET1_ID__AnalogSerialOutput__, this );
                                m_StringOutputList.Add( LIGHTING_PRESET1_ID__AnalogSerialOutput__, LIGHTING_PRESET1_ID );
                                
                                LIGHTING_PRESET1_NAME = new Crestron.Logos.SplusObjects.StringOutput( LIGHTING_PRESET1_NAME__AnalogSerialOutput__, this );
                                m_StringOutputList.Add( LIGHTING_PRESET1_NAME__AnalogSerialOutput__, LIGHTING_PRESET1_NAME );
                                
                                LIGHTING_PRESET2_ID = new Crestron.Logos.SplusObjects.StringOutput( LIGHTING_PRESET2_ID__AnalogSerialOutput__, this );
                                m_StringOutputList.Add( LIGHTING_PRESET2_ID__AnalogSerialOutput__, LIGHTING_PRESET2_ID );
                                
                                LIGHTING_PRESET2_NAME = new Crestron.Logos.SplusObjects.StringOutput( LIGHTING_PRESET2_NAME__AnalogSerialOutput__, this );
                                m_StringOutputList.Add( LIGHTING_PRESET2_NAME__AnalogSerialOutput__, LIGHTING_PRESET2_NAME );
                                
                                LIGHTING_PRESET3_ID = new Crestron.Logos.SplusObjects.StringOutput( LIGHTING_PRESET3_ID__AnalogSerialOutput__, this );
                                m_StringOutputList.Add( LIGHTING_PRESET3_ID__AnalogSerialOutput__, LIGHTING_PRESET3_ID );
                                
                                LIGHTING_PRESET3_NAME = new Crestron.Logos.SplusObjects.StringOutput( LIGHTING_PRESET3_NAME__AnalogSerialOutput__, this );
                                m_StringOutputList.Add( LIGHTING_PRESET3_NAME__AnalogSerialOutput__, LIGHTING_PRESET3_NAME );
                                
                                LIGHTING_PRESET4_ID = new Crestron.Logos.SplusObjects.StringOutput( LIGHTING_PRESET4_ID__AnalogSerialOutput__, this );
                                m_StringOutputList.Add( LIGHTING_PRESET4_ID__AnalogSerialOutput__, LIGHTING_PRESET4_ID );
                                
                                LIGHTING_PRESET4_NAME = new Crestron.Logos.SplusObjects.StringOutput( LIGHTING_PRESET4_NAME__AnalogSerialOutput__, this );
                                m_StringOutputList.Add( LIGHTING_PRESET4_NAME__AnalogSerialOutput__, LIGHTING_PRESET4_NAME );
                                
                                LIGHTING_PRESET5_ID = new Crestron.Logos.SplusObjects.StringOutput( LIGHTING_PRESET5_ID__AnalogSerialOutput__, this );
                                m_StringOutputList.Add( LIGHTING_PRESET5_ID__AnalogSerialOutput__, LIGHTING_PRESET5_ID );
                                
                                LIGHTING_PRESET5_NAME = new Crestron.Logos.SplusObjects.StringOutput( LIGHTING_PRESET5_NAME__AnalogSerialOutput__, this );
                                m_StringOutputList.Add( LIGHTING_PRESET5_NAME__AnalogSerialOutput__, LIGHTING_PRESET5_NAME );
                                
                                LIGHTING_PRESET6_ID = new Crestron.Logos.SplusObjects.StringOutput( LIGHTING_PRESET6_ID__AnalogSerialOutput__, this );
                                m_StringOutputList.Add( LIGHTING_PRESET6_ID__AnalogSerialOutput__, LIGHTING_PRESET6_ID );
                                
                                LIGHTING_PRESET6_NAME = new Crestron.Logos.SplusObjects.StringOutput( LIGHTING_PRESET6_NAME__AnalogSerialOutput__, this );
                                m_StringOutputList.Add( LIGHTING_PRESET6_NAME__AnalogSerialOutput__, LIGHTING_PRESET6_NAME );
                                
                                LIGHTING_SSI_SEVERITY_MESSAGE = new Crestron.Logos.SplusObjects.StringOutput( LIGHTING_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, this );
                                m_StringOutputList.Add( LIGHTING_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, LIGHTING_SSI_SEVERITY_MESSAGE );
                                
                                LIGHTING_SSI_ERROR_TEXT = new Crestron.Logos.SplusObjects.StringOutput( LIGHTING_SSI_ERROR_TEXT__AnalogSerialOutput__, this );
                                m_StringOutputList.Add( LIGHTING_SSI_ERROR_TEXT__AnalogSerialOutput__, LIGHTING_SSI_ERROR_TEXT );
                                
                                LIGHTING_SSI_OK_TEXT = new Crestron.Logos.SplusObjects.StringOutput( LIGHTING_SSI_OK_TEXT__AnalogSerialOutput__, this );
                                m_StringOutputList.Add( LIGHTING_SSI_OK_TEXT__AnalogSerialOutput__, LIGHTING_SSI_OK_TEXT );
                                
                                
                                PULL_CONFIG.OnDigitalPush.Add( new InputChangeHandlerWrapper( PULL_CONFIG_OnPush_0, false ) );
                                
                                _SplusNVRAM.PopulateCustomAttributeList( true );
                                
                                NVRAM = _SplusNVRAM;
                                
                            }
                            
                            public override void LogosSimplSharpInitialize()
                            {
                                
                                
                            }
                            
                            public UserModuleClass_IMS_CONFIGURATION___LIGHTING ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
                            
                            
                            
                            
                            const uint PULL_CONFIG__DigitalInput__ = 0;
                            const uint LIGHTING_PRESET1_ID__AnalogSerialOutput__ = 0;
                            const uint LIGHTING_PRESET1_NAME__AnalogSerialOutput__ = 1;
                            const uint LIGHTING_PRESET2_ID__AnalogSerialOutput__ = 2;
                            const uint LIGHTING_PRESET2_NAME__AnalogSerialOutput__ = 3;
                            const uint LIGHTING_PRESET3_ID__AnalogSerialOutput__ = 4;
                            const uint LIGHTING_PRESET3_NAME__AnalogSerialOutput__ = 5;
                            const uint LIGHTING_PRESET4_ID__AnalogSerialOutput__ = 6;
                            const uint LIGHTING_PRESET4_NAME__AnalogSerialOutput__ = 7;
                            const uint LIGHTING_PRESET5_ID__AnalogSerialOutput__ = 8;
                            const uint LIGHTING_PRESET5_NAME__AnalogSerialOutput__ = 9;
                            const uint LIGHTING_PRESET6_ID__AnalogSerialOutput__ = 10;
                            const uint LIGHTING_PRESET6_NAME__AnalogSerialOutput__ = 11;
                            const uint LIGHTING_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 12;
                            const uint LIGHTING_SSI_ERROR_TEXT__AnalogSerialOutput__ = 13;
                            const uint LIGHTING_SSI_OK_TEXT__AnalogSerialOutput__ = 14;
                            
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
                    