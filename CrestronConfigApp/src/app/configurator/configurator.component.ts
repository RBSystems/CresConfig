import { Component, OnInit } from '@angular/core';
import { CrestronAPIService } from '../crestron-api.service';
import { RootConfig, DisplaysEntity, PresentationInputsEntity, ATCEntity, VTCEntity,
          SSIDeviceUsageEntity, SSIDisplayUsageEntity, SSIEquipmentStatusEntity,
          PowerSequencerEntity, PresetsEntity, LightingEntity,
          GenericDeviceEntity, CamerasEntity } from '../configuration';

import { FormControl, FormArray, FormGroup, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-configurator',
  templateUrl: './configurator.component.html',
  styleUrls: ['./configurator.component.css']
})

export class ConfiguratorComponent implements OnInit {

  response: RootConfig;
  r: RootConfig;

  configForm: FormGroup;

  apiIP: string;

  get slots() {
    return [1, 2, 3, 4, 5, 6, 7, 8, 9];
  }

  get MAXDISPLAYS() {
    return 12;
  }

  get MAXINPUTS() {
    return 12;
  }

  get MAXPRESETS() {
    return 6;
  }

  get MAXSEQUENCERS() {
    return 6;
  }

  get MAXGENERICDEVICES() {
    return 12;
  }

  get MAXCAMERAS() {
    return 6;
  }

  isCollapsed: boolean[] = [];
  presentationIsCollapsed: boolean[] = [];
  CameraPresetsIsCollapsed: boolean[][] = [];
  CamerasIsCollapsed: boolean[] = [];
  LightingPresetsIsCollapsed: boolean[] = [];
  SequencersIsCollapsed: boolean[] = [];
  GenericDevicesIsCollapsed: boolean[] = [];


  globalSettingsCollapsed = false;
  displaySettingsCollapsed = true;
  presentationSettingsCollapsed = true;
  atcSettingsCollapsed = true;
  vtcSettingsCollapsed = true;
  lightingSettingsCollapsed = true;
  sequencerSettingsCollapsed = true;
  genericDevicesSettingCollapsed = true;
  cameraSettingsCollapsed = true;

  slot: number;

  get displays(): FormArray {
    return this.configForm.get('displays') as FormArray;
  }

  get Power_Sequencer(): FormArray {
    return this.configForm.get('Power_Sequencer') as FormArray;
  }
  get Presentation_Inputs(): FormArray {
    return this.configForm.get('Presentation_Inputs') as FormArray;
  }

  get Camera(): FormArray {
    return this.configForm.get('Camera') as FormArray;
  }

  get LightingPresets(): FormArray {
    return this.configForm.get('Lighting').get('Presets') as FormArray;
  }

  get Generic_Devices(): FormArray {
    return this.configForm.get('Generic_Device') as FormArray;
  }

  constructor(private crestronAPIService: CrestronAPIService, private fb: FormBuilder) {
    this.createForm();
  }

  CameraPresets(index: number): FormArray {
    // @ts-ignore
    return this.Camera.controls[index].controls.Presets as FormArray;
  }


  createForm() {
    this.configForm = this.fb.group({
      Room_Name: ['', Validators.required ],
      Welcome_Text: ['', Validators.required ],
      Shutdown_Text: ['', Validators.required ],
      Warming_Text: ['', Validators.required ],
      Cooling_Text: ['', Validators.required ],
      Startup_Time: ['', Validators.required ],
      Shutdown_Time_Display_Active: ['', Validators.required ],
      Shutdown_Time_Display_Inactive: ['', Validators.required ],
      Microphone_Mute_Enable: ['', Validators.required ],
      Microphone_Muted_Text: ['', Validators.required ],
      Microphone_Muted_Not_Text: ['', Validators.required ],
      Presentation_Page_Text: ['', Validators.required ],
      Presentation_Inputs: this.fb.array([ ]),
      displays: this.fb.array([]),
      ATC: this.fb.group({
        Extension: ['', Validators.required ],
        Help_Number: ['', Validators.required ],
        Help_Button_Text: ['', Validators.required ],
        Connected_Dial_Text: ['', Validators.required ],
        Disconnected_Dial_Text: ['', Validators.required ],
        Connected_Hangup_Text: ['', Validators.required ],
        Disconnected_Hangup_Text: ['', Validators.required ],
        SSI_Device_Usage: this.fb.group({}),
        SSI_Equipment_Status: this.fb.group({})
      }),
      VTC: this.fb.group({
        Extension: ['', Validators.required ],
        Help_Number: ['', Validators.required ],
        Help_Button_Text: ['', Validators.required ],
        Connected_Dial_Text: ['', Validators.required ],
        Disconnected_Dial_Text: ['', Validators.required ],
        Connected_Hangup_Text: ['', Validators.required ],
        Disconnected_Hangup_Text: ['', Validators.required ],
        SSI_Device_Usage: this.fb.group({}),
        SSI_Equipment_Status: this.fb.group({})
      }),
      Lighting: this.fb.group({
        Presets: this.fb.array([]),
        SSI_Equipment_Status: this.fb.group({})
      }),
      Power_Sequencer: this.fb.array([]),
      Camera: this.fb.array([]),
      Generic_Device: this.fb.array([])
    });
  }

  ngOnInit() {
    this.apiIP = window.location.origin;
    this.slot = 0;
    // Uncomment this to use Local
    this.apiIP = 'http://172.16.121.44';
  }

  showConfig(slotNumber: number) {
    this.slot = slotNumber;
    console.log('Slot #:' + slotNumber);
    this.crestronAPIService.getConfig(this.apiIP + '/CWS/API/' + slotNumber + '/CONFIGURATION/')
    .subscribe((data: RootConfig) => {
      this.response = { ...data };
      this.r = { ...data };
      console.log(this.r);
      this.updateConfig();
      this.rebuildForm();
      this.populateCollapse();
    });
  }

  updateConfig() {
      const config = this.response;
      const ATCconfig = config.ATC;
      const VTCconfig = config.VTC;

    this.configForm.patchValue({
      Room_Name: this.response.Room_Name,
      Welcome_Text: this.response.Welcome_Text,
      Shutdown_Text: this.response.Shutdown_Text,
      Warming_Text: this.response.Warming_Text,
      Cooling_Text: this.response.Cooling_Text,
      Startup_Time: this.response.Startup_Time,
      Shutdown_Time_Display_Active: this.response.Shutdown_Time_Display_Active,
      Shutdown_Time_Display_Inactive: this.response.Shutdown_Time_Display_Inactive,
      Microphone_Mute_Enable: this.response.Microphone_Mute_Enable,
      Microphone_Muted_Text:  this.response.Microphone_Muted_Text,
      Microphone_Muted_Not_Text: this.response.Microphone_Muted_Not_Text,
      Presentation_Page_Text: this.response.Presentation_Page_Text

    });
    const ATC = this.configForm.get('ATC') as FormGroup;
    ATC.patchValue({
      Extension: ATCconfig.Extension,
      Help_Number: ATCconfig.Help_Number,
      Help_Button_Text: ATCconfig.Help_Button_Text,
      Connected_Dial_Text: ATCconfig.Connected_Dial_Text,
      Disconnected_Dial_Text: ATCconfig.Disconnected_Dial_Text,
      Connected_Hangup_Text: ATCconfig.Connected_Hangup_Text,
      Disconnected_Hangup_Text: ATCconfig.Disconnected_Hangup_Text
    });

    const VTC = this.configForm.get('VTC') as FormGroup;
    VTC.patchValue({
      Extension: VTCconfig.Extension,
      Help_Number: VTCconfig.Help_Number,
      Help_Button_Text: VTCconfig.Help_Button_Text,
      Connected_Dial_Text: VTCconfig.Connected_Dial_Text,
      Disconnected_Dial_Text: VTCconfig.Disconnected_Dial_Text,
      Connected_Hangup_Text: VTCconfig.Connected_Hangup_Text,
      Disconnected_Hangup_Text: VTCconfig.Disconnected_Hangup_Text
    });
  }

  setDisplays(displays: any) {
    const displaysFGs = displays.map(display => {
      display.SSI_Display_Usage = this.fb.group({
        Display_Name: [ display.SSI_Display_Usage.Display_Name, Validators.required]
      });
      display.SSI_Equipment_Status = this.fb.group({
        Severity_Message: [ display.SSI_Equipment_Status.Severity_Message, Validators.required],
        Error_Text: [ display.SSI_Equipment_Status.Error_Text, Validators.required],
        Ok_Text: [ display.SSI_Equipment_Status.Ok_Text, Validators.required]
      });
      return this.fb.group(display);
    });
    const displayFormArray = this.fb.array(displaysFGs);
    this.configForm.setControl('displays', displayFormArray);
  }

  setPresentationInputs(presentation_Inputs: any[]) {
    const presentationInputsFGs = presentation_Inputs.map(input => {
      input.SSI_Device_Usage = this.fb.group({
        Device_Name: [ input.SSI_Device_Usage.Device_Name, Validators.required],
        Device_Type: [ input.SSI_Device_Usage.Device_Type, Validators.required]
      });
      input.SSI_Equipment_Status = this.fb.group({
        Severity_Message: [ input.SSI_Equipment_Status.Severity_Message, Validators.required],
        Error_Text: [ input.SSI_Equipment_Status.Error_Text, Validators.required],
        Ok_Text: [ input.SSI_Equipment_Status.Ok_Text, Validators.required]
      });
      return this.fb.group(input);
    });
    const presentationInputsFormArray = this.fb.array(presentationInputsFGs);
    this.configForm.setControl('Presentation_Inputs', presentationInputsFormArray);
  }

  setSequencers(sequencers: any[
  ]) {
    const sequencersFGs = sequencers.map(sequencer => {
      sequencer.SSI_Equipment_Status = this.fb.group({
        Severity_Message: [ sequencer.SSI_Equipment_Status.Severity_Message, Validators.required],
        Error_Text: [ sequencer.SSI_Equipment_Status.Error_Text, Validators.required],
        Ok_Text: [ sequencer.SSI_Equipment_Status.Ok_Text, Validators.required]
      });
      return this.fb.group(sequencer);
    });
    const sequencerFormArray = this.fb.array(sequencersFGs);
    this.configForm.setControl('Power_Sequencer', sequencerFormArray);
  }

  setCameras(cameras: any) {
    const camerasFGs = cameras.map(camera => {
      const presetFGs = camera.Presets.map(preset => this.fb.group(preset));
      camera.Presets = this.fb.array(presetFGs);
      camera.SSI_Device_Usage = this.fb.group({
        Device_Name: [ camera.SSI_Device_Usage.Device_Name, Validators.required],
        Device_Type: [ camera.SSI_Device_Usage.Device_Type, Validators.required]
      });
      camera.SSI_Equipment_Status = this.fb.group({
        Severity_Message: [ camera.SSI_Equipment_Status.Severity_Message, Validators.required],
        Error_Text: [ camera.SSI_Equipment_Status.Error_Text, Validators.required],
        Ok_Text: [ camera.SSI_Equipment_Status.Ok_Text, Validators.required]
      });
      return this.fb.group(camera);
    });
    const cameraFormArray = this.fb.array(camerasFGs);
    this.configForm.setControl('Camera', cameraFormArray);
  }

  setGenericDevices(generic_devices: any) {
    const generic_devicesFGs = generic_devices.map(generic_device => {
      generic_device.SSI_Device_Usage = this.fb.group({
        Device_Name: [ generic_device.SSI_Device_Usage.Device_Name, Validators.required],
        Device_Type: [ generic_device.SSI_Device_Usage.Device_Type, Validators.required]
      });
      generic_device.SSI_Equipment_Status = this.fb.group({
        Severity_Message: [ generic_device.SSI_Equipment_Status.Severity_Message, Validators.required],
        Error_Text: [ generic_device.SSI_Equipment_Status.Error_Text, Validators.required],
        Ok_Text: [ generic_device.SSI_Equipment_Status.Ok_Text, Validators.required]
      });
      return this.fb.group(generic_device);
    });
    const generic_devicesFormArray = this.fb.array(generic_devicesFGs);
    this.configForm.setControl('Generic_Device', generic_devicesFormArray);
  }

  setPresets(model: PresetsEntity[], groupName: string) {
    const presetFGs = model.map(preset => this.fb.group(preset));
    const presetFormArray = this.fb.array(presetFGs);
    const FG = this.configForm.get(groupName) as FormGroup;
    FG.setControl('Presets', presetFormArray);
  }

  setSSIDeviceUsage(model: SSIDeviceUsageEntity, groupName: string) {
    const SSIDeviceUsageFG = this.fb.group({
      Device_Name: [ model.Device_Name, Validators.required],
      Device_Type: [ model.Device_Type, Validators.required]
    });
    const FG = this.configForm.get(groupName) as FormGroup;
    FG.setControl('SSI_Device_Usage', SSIDeviceUsageFG);
  }

  setSSIDisplayUsage(model: SSIDisplayUsageEntity, groupName: string) {
    const SSIDisplayUsageFG = this.fb.group({
      Display_Name: [ model.Display_Name, Validators.required]
    });

    const FG = this.configForm.get(groupName) as FormGroup;
    FG.setControl('SSI_Display_Usage', SSIDisplayUsageFG);
  }

  setSSIEquipmentStatus(model: SSIEquipmentStatusEntity, groupName: string) {
    const SSIEquipmentStatusFG = this.fb.group({
      Severity_Message: [ model.Severity_Message, Validators.required],
      Error_Text: [ model.Error_Text, Validators.required],
      Ok_Text: [ model.Ok_Text, Validators.required]
    });
    const FG = this.configForm.get(groupName) as FormGroup;
    FG.setControl('SSI_Equipment_Status', SSIEquipmentStatusFG);
  }

  createPresentationInput() {
    const presentationInput: PresentationInputsEntity =  {
      Name: 'New Input',
      Type: 'New Type',
      Generic_Page_Text: 'Use the controls on the Device for this Input',
      Switcher_Value: 99,
      Icon_Value: 99,
      SSI_Device_Usage: this.createSSIDeviceUsage(),
      SSI_Equipment_Status: this.createSSIEquipmentStatus()
    };
    const FG = this.fb.group(presentationInput);
    this.Presentation_Inputs.push(FG);
  }

  createDisplay() {
    const displayNew: DisplaysEntity =  {
      Name: 'New Input',
      Type: 'New Type',
      Switcher_Value: 99,
      Icon_Value: 99,
      Screen_Enabled: true,
      Warming_Time: 30,
      SSI_Display_Usage: this.createSSIDisplayUsage(),
      SSI_Equipment_Status: this.createSSIEquipmentStatus()
    };
    const FG = this.fb.group(displayNew);
    this.displays.push(FG);
  }

  createSequencer() {
    const sequencerNew: PowerSequencerEntity =  {
      Channel_1_Name: 'Channel 1',
      Channel_2_Name: 'Channel 2',
      Channel_3_Name: 'Channel 3',
      Channel_4_Name: 'Channel 4',
      Channel_5_Name: 'Channel 5',
      Channel_6_Name: 'Channel 6',
      Channel_7_Name: 'Channel 7',
      Channel_8_Name: 'Channel 8',
      SSI_Equipment_Status: this.createSSIEquipmentStatus()
    };
    const FG = this.fb.group(sequencerNew);
    this.Power_Sequencer.push(FG);
  }

  createGenericDevice() {
    const genericDeviceNew: GenericDeviceEntity =  {
    Type: 'New Type',
    Name: 'New Name',
    ValueName1: 'Value 1 Name',
    Value1: 'Value 1',
    ValueName2: 'Value 2 Name',
    Value2: 'Value 2',
    ValueName3: 'Value 3 Name',
    Value3: 'Value 3',
    ValueName4: 'Value 4 Name',
    Value4: 'Value 4',
    SSI_Device_Usage: this.createSSIDeviceUsage(),
    SSI_Equipment_Status: this.createSSIEquipmentStatus()
    };
    const FG = this.fb.group(genericDeviceNew);
    this.Generic_Devices.push(FG);
  }

  createCameraDevice(index: number) {
    const cameraNew: any = {
    Switcher_Value: 0,
    Presets : this.fb.array([this.createPreset(), this.createPreset(), this.createPreset(), this.createPreset(),
                              this.createPreset(), this.createPreset()]),
    SSI_Device_Usage: this.createSSIDeviceUsage(),
    SSI_Equipment_Status: this.createSSIEquipmentStatus()
    };
    this.CameraPresetsIsCollapsed.push([]);
    // Need to refactor as this could be a function
    cameraNew.Presets.controls.forEach(element => {
      this.CameraPresetsIsCollapsed[index].push(true);
    });
    const FG = this.fb.group(cameraNew);
    this.Camera.push(FG);
  }

  createPreset() {
    const presetNew: PresetsEntity =  {
      Type: 'Preset Type',
      Id: '99',
      Name: 'New Preset'
    };
    return this.fb.group(presetNew);
    /* Leaving code for future if needed
    const FG = this.fb.group(presetNew);
    console.log(this[groupName]);
    this[groupName].push(FG);
    */
  }

  createSSIDeviceUsage(): any {
    const SSIDeviceUsage: SSIDeviceUsageEntity = {
    Device_Type: 'Generic Input',
    Device_Name: 'New Device'
    };
    return this.fb.group(SSIDeviceUsage);
  }

  createSSIDisplayUsage(): any {
    const SSIDisplayUsage: SSIDisplayUsageEntity = {
    Display_Name: 'New Dislpay'
    };
    return this.fb.group(SSIDisplayUsage);
  }

  createSSIEquipmentStatus(): any  {
    const SSIDisplayUsage: SSIEquipmentStatusEntity = {
    Severity_Message: 'Error',
    Ok_Text: 'New Device Online',
    Error_Text: 'New Device Offline'
    };
    return this.fb.group(SSIDisplayUsage);
  }

  rebuildForm() {
    this.setPresentationInputs(this.response.Presentation_Inputs);
    this.setDisplays(this.response.Displays);
    this.setSSIDeviceUsage(this.response.ATC.SSI_Device_Usage, 'ATC');
    this.setSSIEquipmentStatus(this.response.ATC.SSI_Equipment_Status, 'ATC');
    this.setSSIDeviceUsage(this.response.VTC.SSI_Device_Usage, 'VTC');
    this.setSSIEquipmentStatus(this.response.VTC.SSI_Equipment_Status, 'VTC');
    // Saving if needed back in
    // this.setPresets(this.response.VTC.Presets, 'VTC');
    this.setPresets(this.response.Lighting.Presets, 'Lighting');
    this.setSSIEquipmentStatus(this.response.Lighting.SSI_Equipment_Status, 'Lighting');
    this.setSequencers(this.response.Power_Sequencer);
    this.setGenericDevices(this.response.Generic_Device);
    this.setCameras(this.response.Cameras);
  }

  onSubmit() {
    this.crestronAPIService.updateConfig(this.apiIP + '/CWS/API/' + this.slot + '/CONFIGURATION/', this.prepareSaveConfig())
    .subscribe((obs) => console.log('Config Sent'));
  }

  prepareSaveConfig(): RootConfig {
    const formModel = this.configForm.value;

    const displaysDeepCopy: DisplaysEntity[] = formModel.displays.map(
      (display: DisplaysEntity) => Object.assign({}, display)
    );

    const presentationsDeepCopy: PresentationInputsEntity[] = formModel.Presentation_Inputs.map(
      (input: PresentationInputsEntity) => Object.assign({}, input)
    );

    const ATCDeepCopy: ATCEntity = Object.assign({}, formModel.ATC);

    const VTCDeepCopy: VTCEntity = Object.assign({}, formModel.VTC);

    const LightingDeepCopy: LightingEntity = Object.assign({}, formModel.Lighting);

    const SequencersDeepCopy: PowerSequencerEntity[] = formModel.Power_Sequencer.map(
      (sequencer: DisplaysEntity) => Object.assign({}, sequencer)
    );

    const GenericDeviceDeepCopy: GenericDeviceEntity[] = formModel.Generic_Device.map(
      (genericDevice: GenericDeviceEntity) => Object.assign({}, genericDevice)
    );

    const CameraDeepCopy: CamerasEntity[] = formModel.Camera.map(
      (camera: CamerasEntity) => {
        // @ts-ignore: Preset Array does not exist on camera
        delete camera.PresetsArray;
        return Object.assign({}, camera);
      }
    );
    console.log(CameraDeepCopy);

    const saveConfig: RootConfig = {
      Room_Name: formModel.Room_Name,
      Welcome_Text: formModel.Welcome_Text,
      Shutdown_Text: formModel.Shutdown_Text,
      Warming_Text: formModel.Warming_Text,
      Cooling_Text: formModel.Cooling_Text,
      Startup_Time: formModel.Startup_Time,
      Shutdown_Time_Display_Active: formModel.Shutdown_Time_Display_Active,
      Shutdown_Time_Display_Inactive: formModel.Shutdown_Time_Display_Inactive,
      Microphone_Mute_Enable: formModel.Microphone_Mute_Enable,
      Microphone_Muted_Text:  formModel.Microphone_Muted_Text,
      Microphone_Muted_Not_Text: formModel.Microphone_Muted_Not_Text,
      Presentation_Page_Text: formModel.Presentation_Page_Text,
      Displays: displaysDeepCopy,
      Presentation_Inputs: presentationsDeepCopy,
      ATC: ATCDeepCopy,
      VTC: VTCDeepCopy,
      Lighting: LightingDeepCopy,
      Power_Sequencer: SequencersDeepCopy,
      Cameras: CameraDeepCopy,
      Generic_Device: GenericDeviceDeepCopy
    };

    return saveConfig;
  }

  populateCollapse() {
    this.r.Displays.forEach((element, index) => {
      this.isCollapsed.push(true);
    });
    if (this.isCollapsed.length > 0) {
      this.isCollapsed[0] = false;
    }
    this.r.Presentation_Inputs.forEach((element, index) => {
      this.presentationIsCollapsed.push(true);
    });
    if (this.presentationIsCollapsed.length > 0) {
      this.presentationIsCollapsed[0] = false;
    }
    this.r.Cameras.forEach((element, index) => {
      this.CameraPresetsIsCollapsed.push([]);
      // @ts-ignore: Property'controls' does not existo on type 'AbstractControl'
      element.Presets.controls.forEach((el, i) => {
        this.CameraPresetsIsCollapsed[index].push(true);
      });
    });
    if (this.CameraPresetsIsCollapsed.length > 0) {
      this.CameraPresetsIsCollapsed.forEach((element, index) => {
        this.CameraPresetsIsCollapsed[index][0] = false;
      });
    }
    this.r.Cameras.forEach((element, index) => {
      this.CamerasIsCollapsed.push(true);
    });
    if (this.CamerasIsCollapsed.length > 0) {
      this.CamerasIsCollapsed[0] = false;
    }
    this.r.Lighting.Presets.forEach((element, index) => {
      this.LightingPresetsIsCollapsed.push(true);
    });
    if (this.LightingPresetsIsCollapsed.length > 0) {
      this.LightingPresetsIsCollapsed[0] = false;
    }
    this.r.Power_Sequencer.forEach((element, index) => {
      this.SequencersIsCollapsed.push(true);
    });
    if (this.SequencersIsCollapsed.length > 0) {
      this.SequencersIsCollapsed[0] = false;
    }
    this.r.Generic_Device.forEach((element, index) => {
      this.GenericDevicesIsCollapsed.push(true);
    });
    if (this.GenericDevicesIsCollapsed.length > 0) {
      this.GenericDevicesIsCollapsed[0] = false;
    }
  }

  collapseAllDisplays() {
    this.isCollapsed.forEach((element, index) => {
      this.isCollapsed[index] = true;
    });
  }

  collapseAllPresentation() {
    this.presentationIsCollapsed.forEach((element, index) => {
      this.presentationIsCollapsed[index] = true;
    });
  }

  collapseAllCameras() {
    this.CamerasIsCollapsed.forEach((element, index) => {
      this.CamerasIsCollapsed[index] = true;
    });
  }

  collapseAllCameraPresets() {
    this.CameraPresetsIsCollapsed.forEach((element, index) => {
      element.forEach((el, i) => {
        this.CameraPresetsIsCollapsed[index][i] = true;
      });
    });
  }

  collapseAllLightingPresets() {
    this.LightingPresetsIsCollapsed.forEach((element, index) => {
      this.LightingPresetsIsCollapsed[index] = true;
    });
  }

  collapseAllSequencers() {
    this.SequencersIsCollapsed.forEach((element, index) => {
      this.SequencersIsCollapsed[index] = true;
    });
  }

  collapseAllGenericDevices() {
    this.GenericDevicesIsCollapsed.forEach((element, index) => {
      this.GenericDevicesIsCollapsed[index] = true;
    });
  }
}
