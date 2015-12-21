;Include helpful logic liberary
;Include Modern UI
!include "LogicLib.nsh"
!include "MUI2.nsh"

!define PRODUCT_NAME "Visual LiveStreamer C++ Mainline"
!define PRODUCT_VERSION "0.4"
!define SETUP_NAME "mainline-0.4.exe"
!define COMPILE_DIR "C:\Users\Victor\Documents\GitHub\Visual-LiveStreamer"

OutFile ${SETUP_NAME}
Name "${PRODUCT_NAME} ${PRODUCT_VERSION}"

InstallDir "$PROGRAMFILES64\VLS"
InstallDirRegKey HKLM "Software\VLS" ""
ShowInstDetails show
ShowUnInstDetails show

SetCompressor /SOLID lzma
SetCompressorDictSize 64

  ;Request application privileges for Windows Vista
  RequestExecutionLevel admin

Section "LiveStreamer" SecLS

  SetOutPath "$INSTDIR"
  
  File "${COMPILE_DIR}\bin\bin.zip"
	ZipDLL::extractall "$INSTDIR\bin.zip" "$INSTDIR" "<ALL>"
  Delete "$INSTDIR\bin.zip"
  
  File "${COMPILE_DIR}\bin\vls.exe"
  
  File "${COMPILE_DIR}\bin\libgcc_s_seh-1.dll"
  File "${COMPILE_DIR}\bin\libstdc++-6.dll"
  File "${COMPILE_DIR}\bin\libwinpthread-1.dll"
  

  ;Store installation folder
  WriteRegStr HKCU "Software\VLS" "" $INSTDIR

  ;Create uninstaller
  WriteUninstaller "$INSTDIR\Uninstall.exe"

SectionEnd
Section "VLC Player" SecPlay

  SetOutPath "$INSTDIR"
  File "${COMPILE_DIR}\bin\player.zip"
	ZipDLL::extractall "$INSTDIR\player.zip" "$INSTDIR" "<ALL>"
  Delete "$INSTDIR\player.zip"

  ;Store installation folder
  WriteRegStr HKCU "Software\VLS" "" $INSTDIR

  ;Create uninstaller
  WriteUninstaller "$INSTDIR\Uninstall.exe"

SectionEnd


Section "Uninstall"

  ;ADD YOUR OWN FILES HERE...


  Delete "$INSTDIR\Uninstall.exe"
  RMDir /r "$INSTDIR\player"
  RMDir /r "$INSTDIR\cfg"
  RMDir /r "$INSTDIR\bin"
  Delete "$INSTDIR\vls.exe"
  
  Delete "$INSTDIR\libgcc_s_seh-1.dll"
  Delete "$INSTDIR\libstdc++-6.dll"
  Delete "$INSTDIR\libwinpthread-1.dll"


  RMDir "$INSTDIR"

  DeleteRegKey /ifempty HKCU "Software\VLS"

SectionEnd

!insertmacro MUI_PAGE_WELCOME
!insertmacro MUI_PAGE_LICENSE "${COMPILE_DIR}\LICENSE"
!insertmacro MUI_PAGE_COMPONENTS
!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_INSTFILES
!insertmacro MUI_PAGE_FINISH

!insertmacro MUI_UNPAGE_WELCOME
!insertmacro MUI_UNPAGE_CONFIRM
!insertmacro MUI_UNPAGE_INSTFILES
!insertmacro MUI_UNPAGE_FINISH

;--------------------------------
;Languages

!insertmacro MUI_LANGUAGE "English"


;--------------------------------
;Descriptions

  ;Language strings
  LangString DESC_SecLS ${LANG_ENGLISH} "If you already have VLC, mark just this option"

  ;Assign language strings to sections
  !insertmacro MUI_FUNCTION_DESCRIPTION_BEGIN
    !insertmacro MUI_DESCRIPTION_TEXT ${SecLS} $(DESC_SecLS)
  !insertmacro MUI_FUNCTION_DESCRIPTION_END