; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "VirusTotalChecker"
#define MyAppVersion "1.0"
#define MyAppPublisher "VirusTotalChecker"
#define MyAppURL "VirusTotalChecker"
#define MyAppExeName "uploader.exe"
#define MyAppAssocName MyAppName + " File"
#define MyAppAssocExt ".vtc"
#define MyAppAssocKey StringChange(MyAppAssocName, " ", "") + MyAppAssocExt

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{660E60A3-D52E-4E9A-A24F-C68FD89F7DB7}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
ChangesAssociations=yes
DisableProgramGroupPage=yes
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
OutputDir=C:\Users\jared\Desktop\VirusTotalUploader-master\uploader\SetupTool
OutputBaseFilename=VirusTotalCheckerInstaller
SetupIconFile=C:\Users\jared\Downloads\VirusTotal.ico
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\jared\Desktop\VirusTotalUploader-master\uploader\uploader\build\rel\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\jared\Desktop\VirusTotalUploader-master\uploader\uploader\build\rel\DarkUI.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\jared\Desktop\VirusTotalUploader-master\uploader\uploader\build\rel\Microsoft.Bcl.AsyncInterfaces.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\jared\Desktop\VirusTotalUploader-master\uploader\uploader\build\rel\Microsoft.Bcl.AsyncInterfaces.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\jared\Desktop\VirusTotalUploader-master\uploader\uploader\build\rel\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\jared\Desktop\VirusTotalUploader-master\uploader\uploader\build\rel\Newtonsoft.Json.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\jared\Desktop\VirusTotalUploader-master\uploader\uploader\build\rel\RestSharp.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\jared\Desktop\VirusTotalUploader-master\uploader\uploader\build\rel\RestSharp.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\jared\Desktop\VirusTotalUploader-master\uploader\uploader\build\rel\Siticone.UI.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\jared\Desktop\VirusTotalUploader-master\uploader\uploader\build\rel\System.Buffers.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\jared\Desktop\VirusTotalUploader-master\uploader\uploader\build\rel\System.Buffers.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\jared\Desktop\VirusTotalUploader-master\uploader\uploader\build\rel\System.Memory.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\jared\Desktop\VirusTotalUploader-master\uploader\uploader\build\rel\System.Memory.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\jared\Desktop\VirusTotalUploader-master\uploader\uploader\build\rel\System.Numerics.Vectors.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\jared\Desktop\VirusTotalUploader-master\uploader\uploader\build\rel\System.Numerics.Vectors.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\jared\Desktop\VirusTotalUploader-master\uploader\uploader\build\rel\System.Runtime.CompilerServices.Unsafe.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\jared\Desktop\VirusTotalUploader-master\uploader\uploader\build\rel\System.Runtime.CompilerServices.Unsafe.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\jared\Desktop\VirusTotalUploader-master\uploader\uploader\build\rel\System.Text.Encodings.Web.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\jared\Desktop\VirusTotalUploader-master\uploader\uploader\build\rel\System.Text.Encodings.Web.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\jared\Desktop\VirusTotalUploader-master\uploader\uploader\build\rel\System.Text.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\jared\Desktop\VirusTotalUploader-master\uploader\uploader\build\rel\System.Text.Json.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\jared\Desktop\VirusTotalUploader-master\uploader\uploader\build\rel\System.Threading.Tasks.Extensions.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\jared\Desktop\VirusTotalUploader-master\uploader\uploader\build\rel\System.Threading.Tasks.Extensions.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\jared\Desktop\VirusTotalUploader-master\uploader\uploader\build\rel\System.ValueTuple.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\jared\Desktop\VirusTotalUploader-master\uploader\uploader\build\rel\System.ValueTuple.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\jared\Desktop\VirusTotalUploader-master\uploader\uploader\build\rel\uploader.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\jared\Desktop\VirusTotalUploader-master\uploader\uploader\build\rel\vtu_settings.json"; DestDir: "{userappdata}\VirusTotalChecker"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Registry]
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocExt}\OpenWithProgids"; ValueType: string; ValueName: "{#MyAppAssocKey}"; ValueData: ""; Flags: uninsdeletevalue
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}"; ValueType: string; ValueName: ""; ValueData: "{#MyAppAssocName}"; Flags: uninsdeletekey
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\{#MyAppExeName},0"
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""
Root: HKA; Subkey: "Software\Classes\Applications\{#MyAppExeName}\SupportedTypes"; ValueType: string; ValueName: ".myp"; ValueData: ""
Root: HKCR; Subkey: "*\shell\{#MyAppAssocKey}\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""
Root: HKCR; Subkey: "*\shell\{#MyAppAssocKey}"; ValueType: string; ValueName: ""; ValueData: "Scan with VirusTotal"
Root: HKCR; Subkey: "*\shell\{#MyAppAssocKey}"; ValueType: string; ValueName: "Icon"; ValueData: "{app}\{#MyAppExeName},0"

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

