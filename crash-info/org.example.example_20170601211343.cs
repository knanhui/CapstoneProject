S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 10289
Date: 2017-06-01 21:13:42+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000008, esi = 0xb37cc531
ebp = 0xbfe582b8, esp = 0xbfe58250
eax = 0xb87da580, ebx = 0xb6bc20d4
ecx = 0xb87da580, edx = 0x00000008
eip = 0xb6ba01f6

Memory Information
MemTotal:      123 KB
MemFree:        22 KB
Buffers:         7 KB
Cached:     191716 KB
VmPeak:     100472 KB
VmSize:     100472 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22036 KB
VmRSS:       22036 KB
VmData:      32916 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34464 KB
VmPTE:          84 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 10289 TID = 10289
10289 10298 10493 10494 

Maps Information
b2b8b000 b2b95000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b9b000 b2ba7000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2ba8000 b2bc9000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2bce000 b2bcf000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2bd0000 b2bd5000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2bd6000 b2bd8000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2bd9000 b2bdb000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2bdc000 b2be8000 r-xp /usr/lib/libdrm.so.2.4.0
b2be9000 b2bec000 r-xp /usr/lib/libdri2.so.0.0.0
b2bed000 b2bf7000 r-xp /usr/lib/libtbm.so.1.0.0
b2bf8000 b2c0d000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c0e000 b2c20000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3422000 b3453000 r-xp /usr/lib/libidn.so.11.5.44
b3454000 b3476000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3477000 b3487000 r-xp /usr/lib/libcares.so.2.1.0
b3488000 b3491000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3492000 b349b000 r-xp /usr/lib/libefl-extension.so.0.1.0
b349c000 b3513000 r-xp /usr/lib/libcurl.so.4.3.0
b3515000 b3527000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3528000 b3549000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b3550000 b3551000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3552000 b3553000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3554000 b3557000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3558000 b355b000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3663000 b3669000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b366a000 b37ae000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37be000 b37bf000 r-xp /usr/lib/libxshmfence.so.1.0.0
b37c0000 b37c1000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37c2000 b37ce000 r-xp /opt/usr/apps/org.example.example/bin/example
b37d0000 b3809000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b420c000 b4217000 r-xp /lib/libnss_files-2.20-2014.11.so
b4219000 b4224000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4226000 b423d000 r-xp /lib/libnsl-2.20-2014.11.so
b4241000 b4249000 r-xp /lib/libnss_compat-2.20-2014.11.so
b424b000 b426f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4270000 b4271000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4272000 b4275000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4276000 b427d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b427e000 b4288000 r-xp /usr/lib/libsensord-share.so
b4289000 b42a5000 r-xp /usr/lib/libsensor.so.1.2.0
b42a7000 b42b0000 r-xp /usr/lib/libappcore-common.so.1.1
b42b3000 b42b5000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42ca000 b42cc000 r-xp /usr/lib/libXau.so.6.0.0
b42cd000 b42ef000 r-xp /usr/lib/libxcb.so.1.1.0
b42f1000 b42fa000 r-xp /lib/libcrypt-2.20-2014.11.so
b4323000 b4325000 r-xp /usr/lib/libiri.so
b4326000 b434c000 r-xp /lib/libexpat.so.1.5.2
b434e000 b43b9000 r-xp /usr/lib/libssl.so.1.0.0
b43bf000 b43cb000 r-xp /usr/lib/libethumb.so.1.13.0
b43cc000 b43d0000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43d1000 b4622000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b9d000 b5bad000 r-xp /usr/lib/libXi.so.6.1.0
b5bae000 b5bb0000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bb1000 b5bb7000 r-xp /usr/lib/libXtst.so.6.1.0
b5bb8000 b5bc2000 r-xp /usr/lib/libXrender.so.1.3.0
b5bc3000 b5bcc000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bce000 b5bd0000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bd1000 b5bd6000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bd7000 b5be9000 r-xp /usr/lib/libXext.so.6.4.0
b5bea000 b5bec000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bed000 b5bef000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bf1000 b5d33000 r-xp /usr/lib/libX11.so.6.3.0
b5d37000 b5d41000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d42000 b5d58000 r-xp /usr/lib/libudev.so.1.6.0
b5d5b000 b5d5f000 r-xp /lib/libattr.so.1.1.0
b5d60000 b5d8f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d91000 b5d97000 r-xp /usr/lib/libffi.so.6.0.2
b5d98000 b5dbb000 r-xp /lib/libz.so.1.2.8
b5dbc000 b5dbf000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5dc0000 b5f1c000 r-xp /usr/lib/libxml2.so.2.9.2
b5f22000 b6009000 r-xp /usr/lib/libstdc++.so.6.0.20
b6016000 b6019000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b601a000 b603c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b603d000 b6051000 r-xp /lib/libresolv-2.20-2014.11.so
b6055000 b6079000 r-xp /usr/lib/liblzma.so.5.0.3
b607a000 b607c000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b607e000 b6088000 r-xp /usr/lib/libembryo.so.1.13.0
b6089000 b60b2000 r-xp /usr/lib/libpng12.so.0.50.0
b60b3000 b60fc000 r-xp /usr/lib/libjpeg.so.8.0.2
b610d000 b6114000 r-xp /lib/librt-2.20-2014.11.so
b6116000 b6135000 r-xp /usr/lib/libector.so.1.13.0
b6138000 b6165000 r-xp /usr/lib/liblua-5.1.so
b6166000 b61f6000 r-xp /usr/lib/libfreetype.so.6.11.3
b61fa000 b6238000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6239000 b624f000 r-xp /usr/lib/libfribidi.so.0.3.1
b6250000 b62a9000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62ac000 b62f7000 r-xp /lib/libm-2.20-2014.11.so
b62f9000 b630b000 r-xp /usr/lib/libeio.so.1.13.0
b630c000 b630f000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6310000 b6316000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6317000 b633a000 r-xp /usr/lib/libefreet.so.1.13.0
b633d000 b6368000 r-xp /usr/lib/libeldbus.so.1.13.0
b6369000 b639d000 r-xp /usr/lib/libecore_con.so.1.13.0
b639f000 b63a8000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63a9000 b63b2000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63b3000 b63c6000 r-xp /usr/lib/libeo.so.1.13.0
b63c8000 b63db000 r-xp /usr/lib/libecore_input.so.1.13.0
b63dc000 b63e3000 r-xp /usr/lib/libecore_file.so.1.13.0
b63e4000 b6407000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6408000 b6434000 r-xp /usr/lib/libeet.so.1.13.0
b643d000 b64a8000 r-xp /usr/lib/libeina.so.1.13.0
b64ab000 b64c2000 r-xp /usr/lib/libefl.so.1.13.0
b64c4000 b662b000 r-xp /usr/lib/libicuuc.so.51.1
b6639000 b6845000 r-xp /usr/lib/libicui18n.so.51.1
b684d000 b689c000 r-xp /usr/lib/libecore_x.so.1.13.0
b689e000 b68b8000 r-xp /lib/libgcc_s-4.9.so.1
b68ba000 b68be000 r-xp /lib/libcap.so.2.21
b68bf000 b6905000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6906000 b690d000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b690f000 b6961000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6963000 b6aee000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6af3000 b6bc1000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bc4000 b6bc8000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bc9000 b6bd8000 r-xp /usr/lib/libvconf.so.0.2.45
b6bd9000 b6bdc000 r-xp /usr/lib/libvasum.so.0.3.1
b6bdd000 b6be0000 r-xp /usr/lib/libttrace.so.1.1
b6be2000 b6be6000 r-xp /usr/lib/libiniparser.so.0
b6be7000 b6c17000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c18000 b6c21000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c22000 b6c47000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c48000 b6c58000 r-xp /usr/lib/libunwind.so.8.0.1
b6c62000 b6e10000 r-xp /lib/libc-2.20-2014.11.so
b6e18000 b6f5b000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f5d000 b6fb5000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fb6000 b6fea000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fed000 b70c1000 r-xp /usr/lib/libedje.so.1.13.0
b70c4000 b70f0000 r-xp /usr/lib/libecore.so.1.13.0
b7101000 b7327000 r-xp /usr/lib/libevas.so.1.13.0
b734f000 b7367000 r-xp /lib/libpthread-2.20-2014.11.so
b736b000 b76e5000 r-xp /usr/lib/libelementary.so.1.13.0
b7705000 b7709000 r-xp /usr/lib/libsmack.so.1.0.0
b770a000 b7713000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7714000 b7717000 r-xp /usr/lib/libdlog.so.0.0.0
b7718000 b771d000 r-xp /usr/lib/libbundle.so.0.1.22
b771e000 b7721000 r-xp /lib/libdl-2.20-2014.11.so
b7723000 b7748000 r-xp /usr/lib/libaul.so.0.1.0
b774b000 b774d000 r-xp /usr/lib/libappsvc.so.0.1.0
b774e000 b7753000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7754000 b775b000 r-xp /usr/lib/libappcore-efl.so.1.1
b775d000 b7762000 r-xp /usr/lib/libsys-assert.so
b7765000 b7766000 r-xp [vdso]
b7766000 b7788000 r-xp /lib/ld-2.20-2014.11.so
b778a000 b7792000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:10289)
Call Stack Count: 20
 0: (0xb6ba01f6) [/usr/lib/libsqlite3.so.0] + 0xad1f6
 1: init_db + 0x13f (0xb37caadf) [/opt/usr/apps/org.example.example/bin/example] + 0x8adf
 2: setting_view_cb + 0x42 (0xb37ca8b2) [/opt/usr/apps/org.example.example/bin/example] + 0x88b2
 3: (0xb7135449) [/usr/lib/libevas.so.1] + 0x34449
 4: (0xb63c1319) [/usr/lib/libeo.so.1] + 0xe319
 5: eo_event_callback_call + 0xb3 (0xb63bed63) [/usr/lib/libeo.so.1] + 0xbd63
 6: (0xb7135a62) [/usr/lib/libevas.so.1] + 0x34a62
 7: (0xb7144441) [/usr/lib/libevas.so.1] + 0x43441
 8: evas_canvas_event_feed_mouse_down + 0xcf (0xb714e20f) [/usr/lib/libevas.so.1] + 0x4d20f
 9: evas_event_feed_mouse_down + 0x6a (0xb7154c2a) [/usr/lib/libevas.so.1] + 0x53c2a
10: (0xb43ce49c) [/usr/lib/libecore_input_evas.so.1] + 0x249c
11: (0xb70d1055) [/usr/lib/libecore.so.1] + 0xd055
12: (0xb70da1b9) [/usr/lib/libecore.so.1] + 0x161b9
13: ecore_main_loop_begin + 0x57 (0xb70da587) [/usr/lib/libecore.so.1] + 0x16587
14: elm_run + 0x2d (0xb753322d) [/usr/lib/libelementary.so.1] + 0x1c822d
15: appcore_efl_main + 0x4de (0xb7757dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
16: ui_app_main + 0x140 (0xb7750c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
17: main + 0x2e1 (0xb37c99a1) [/opt/usr/apps/org.example.example/bin/example] + 0x79a1
18: (0xb778c148) [/opt/usr/apps/org.example.example/bin/example] + 0xb778c148
19: __libc_start_main + 0xde (0xb6c79e4e) [/lib/libc.so.6] + 0x17e4e
End of Call Stack

Package Information
Package Name: org.example.example
Package ID : org.example.example
Version: 1.0.0
Package Type: tpk
App Name: forpet
App ID: org.example.example
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
uBox(1001) >  nOriBoxOrder[6], [2, 2]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:13:40.467+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.emailui] Name[emailui] Icon[/opt/usr/apps/org.example.emailui/shared/res/emailui.png] enable[1] system[0]
06-01 21:13:40.467+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.emailui'], count[0]
06-01 21:13:40.467+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.emailui][-17956860][0]
06-01 21:13:40.467+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.emailui]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[emailui] pos[3, 2] pageId[100001]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[15]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[7], [3, 2]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[7], [3, 2]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:13:40.467+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.example] Name[forpet] Icon[/opt/usr/apps/org.example.example/shared/res/1.jpg] enable[1] system[0]
06-01 21:13:40.467+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.example'], count[0]
06-01 21:13:40.467+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.example][-17956860][0]
06-01 21:13:40.467+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.example]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[forpet] pos[4, 2] pageId[100001]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[0]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(787) >  AddBoxToMenuView
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(347) >  AddBox Name[forpet] pageid[100001] pos[4, 2]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(354) >  menuPage.GetPageId() = 100001, boxPageId = 100001
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: AddBoxToPage(112) >  void ClusterHome3D::Internal::CMainMenuPage::AddBoxToPage(std::shared_ptr<CMainMenuBoxData>) : 112
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: AddBoxToPage(122) >  void ClusterHome3D::Internal::CMainMenuPage::AddBoxToPage(std::shared_ptr<CMainMenuBoxData>) : 122
06-01 21:13:40.467+0900 D/test-log( 2894): mainmenu-page-impl.cpp: AddBoxToPage(123) >  create box[org.example.example] [4,2]
06-01 21:13:40.467+0900 D/test-log( 2894): mainmenu-box-impl.cpp: CMainMenuBox(148) >  create box
06-01 21:13:40.467+0900 D/test-log( 2894): mainmenu-box-impl.cpp: SetPosition(459) >  cut Animation : forpet
06-01 21:13:40.467+0900 D/test-log( 2894): mainmenu-page-impl.cpp: AddBoxToPage(177) >  add created box
06-01 21:13:40.467+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.gallery] Name[Gallery] Icon[/usr/share/icons/default/small/org.tizen.gallery.png] enable[1] system[1]
06-01 21:13:40.467+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.gallery'], count[0]
06-01 21:13:40.467+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.gallery][-17956860][0]
06-01 21:13:40.467+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.gallery]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Gallery] pos[1, 3] pageId[100001]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[6]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[9], [1, 3]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[8], [4, 2]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:13:40.467+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.browser] Name[Internet] Icon[/usr/share/icons/default/small/org.tizen.browser.png] enable[1] system[1]
06-01 21:13:40.467+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.browser'], count[0]
06-01 21:13:40.467+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.browser][-17956860][0]
06-01 21:13:40.467+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.browser]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Internet] pos[2, 3] pageId[100001]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[1]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[10], [2, 3]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:13:40.467+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.message] Name[Messages] Icon[/usr/share/icons/default/small/org.tizen.message.png] enable[1] system[1]
06-01 21:13:40.467+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.message'], count[1]
06-01 21:13:40.467+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.message]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Messages] pos[3, 3] pageId[100001]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[7]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[11], [3, 3]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:13:40.467+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.music-player] Name[Music] Icon[/usr/share/icons/default/small/org.tizen.music-player.png] enable[1] system[1]
06-01 21:13:40.467+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.music-player'], count[0]
06-01 21:13:40.467+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.music-player][-17956860][0]
06-01 21:13:40.467+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.music-player]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Music] pos[4, 3] pageId[100001]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[8]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[12], [4, 3]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:13:40.467+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.myfile] Name[My Files] Icon[/usr/share/icons/default/small/org.tizen.myfile.png] enable[1] system[1]
06-01 21:13:40.467+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.myfile'], count[0]
06-01 21:13:40.467+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.myfile][-17956860][0]
06-01 21:13:40.467+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.myfile]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[My Files] pos[1, 4] pageId[100001]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[9]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[13], [1, 4]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:13:40.467+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.phone] Name[Phone] Icon[/usr/share/icons/default/small/org.tizen.phone.png] enable[1] system[1]
06-01 21:13:40.467+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.phone'], count[0]
06-01 21:13:40.467+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.phone][-17956860][0]
06-01 21:13:40.467+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.phone]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Phone] pos[2, 4] pageId[100001]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[10]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[14], [2, 4]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:13:40.467+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.setting] Name[Settings] Icon[/usr/share/icons/default/small/org.tizen.setting.png] enable[1] system[1]
06-01 21:13:40.467+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.setting'], count[0]
06-01 21:13:40.467+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.setting][-17956860][0]
06-01 21:13:40.467+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.setting]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Settings] pos[3, 4] pageId[100001]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[11]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[15], [3, 4]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 21:13:40.467+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:13:40.467+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.uibuildernavigationview] Name[uibuildernavigationview] Icon[/opt/usr/apps/org.example.uibuildernavigationview/shared/res/uibuildernavigationview.png] enable[1] system[0]
06-01 21:13:40.477+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.uibuildernavigationview'], count[0]
06-01 21:13:40.477+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.uibuildernavigationview][-17956860][0]
06-01 21:13:40.477+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.uibuildernavigationview]
06-01 21:13:40.477+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[uibuildernavigationview] pos[4, 4] pageId[100001]
06-01 21:13:40.477+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[14]
06-01 21:13:40.477+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[16], [4, 4]
06-01 21:13:40.477+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 21:13:40.477+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:13:40.477+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.videos] Name[Video] Icon[/usr/share/icons/default/small/org.tizen.videos.png] enable[1] system[1]
06-01 21:13:40.477+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.videos'], count[0]
06-01 21:13:40.477+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.videos][-17956860][0]
06-01 21:13:40.477+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.videos]
06-01 21:13:40.477+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Video] pos[1, 5] pageId[100001]
06-01 21:13:40.477+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[12]
06-01 21:13:40.477+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[17], [1, 5]
06-01 21:13:40.477+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 21:13:40.477+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:13:40.477+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: RearrangeItems(243) >  view type [1]
06-01 21:13:40.697+0900 D/rpm-installer(10432): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
06-01 21:13:40.697+0900 D/rpm-installer(10432): rpm-appcore-intf.c: main(259) > ------------------------------------------------
06-01 21:13:40.697+0900 D/rpm-installer(10432): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
06-01 21:13:40.697+0900 D/rpm-installer(10432): rpm-appcore-intf.c: main(261) > ------------------------------------------------
06-01 21:13:40.717+0900 D/PKGMGR_SERVER(10418): pkgmgr-server.c: sighandler(387) > child exit [10432]
06-01 21:13:40.717+0900 E/PKGMGR_SERVER(10418): pkgmgr-server.c: sighandler(402) > child NORMAL exit [10432]
06-01 21:13:40.987+0900 E/PKGMGR_SERVER(10418): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-01 21:13:40.987+0900 E/PKGMGR_SERVER(10418): pkgmgr-server.c: main(2265) > package manager server terminated.
06-01 21:13:41.547+0900 D/AUL_AMD ( 2787): amd_request.c: __request_handler(838) > __request_handler: 0
06-01 21:13:41.547+0900 D/AUL_AMD ( 2787): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-01 21:13:41.557+0900 D/PKGMGR_INFO( 2787): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 21:13:41.557+0900 D/PKGMGR_INFO( 2787): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 21:13:41.557+0900 I/AUL     ( 2787): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
06-01 21:13:41.557+0900 D/AUL     ( 2787): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 10487, pid = 10489
06-01 21:13:41.557+0900 D/PKGMGR_INFO( 2787): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 21:13:41.557+0900 D/PKGMGR_INFO( 2787): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 21:13:41.557+0900 I/AUL     ( 2787): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
06-01 21:13:41.557+0900 E/AUL_AMD ( 2787): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-01 21:13:41.557+0900 W/AUL_AMD ( 2787): amd_launch.c: _start_app(2233) > caller pid : 10489
06-01 21:13:41.557+0900 E/AUL_AMD ( 2787): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-01 21:13:41.557+0900 W/AUL_AMD ( 2787): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-01 21:13:41.557+0900 D/AUL_AMD ( 2787): amd_launch.c: _start_app(2648) > process_pool: false
06-01 21:13:41.557+0900 D/AUL_AMD ( 2787): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-01 21:13:41.557+0900 D/AUL_AMD ( 2787): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-01 21:13:41.557+0900 W/AUL_AMD ( 2787): amd_launch.c: _start_app(2665) > pad pid(-5)
06-01 21:13:41.557+0900 D/AUL_AMD ( 2787): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-01 21:13:41.557+0900 D/AUL_AMD ( 2787): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-01 21:13:41.557+0900 D/AUL     ( 2787): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-01 21:13:41.557+0900 D/RESOURCED( 2881): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-01 21:13:41.557+0900 D/RESOURCED( 2881): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-01 21:13:41.557+0900 E/RESOURCED( 2881): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-01 21:13:41.567+0900 D/AUL_PAD ( 2943): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-01 21:13:41.567+0900 D/AUL_PAD ( 2943): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 21:13:41.567+0900 D/AUL_PAD ( 2943): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 21:13:41.567+0900 D/AUL_PAD ( 2943): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 21:13:41.567+0900 D/AUL_PAD ( 2943): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 21:13:41.567+0900 D/AUL_PAD ( 2943): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 21:13:41.567+0900 D/AUL_PAD ( 2943): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 21:13:41.567+0900 D/AUL_PAD ( 2943): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-01 21:13:41.567+0900 D/AUL_PAD ( 2943): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-01 21:13:41.567+0900 D/AUL_PAD ( 2943): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-01 21:13:41.567+0900 D/AUL_PAD ( 2943): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-01 21:13:41.567+0900 D/AUL_PAD ( 2943): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-01 21:13:41.567+0900 D/AUL_PAD ( 2943): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-01 21:13:41.567+0900 D/AUL_PAD ( 2943): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-01 21:13:41.567+0900 W/AUL_PAD ( 2943): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-01 21:13:41.567+0900 D/AUL     ( 2943): process_pool.c: __send_pkt_raw_data(219) > send(12) : 624 / 624
06-01 21:13:41.567+0900 D/AUL_PAD ( 2943): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 10289, bin path: /opt/usr/apps/org.example.example/bin/example
06-01 21:13:41.567+0900 W/AUL_PAD ( 2943): launchpad.c: __send_result_to_caller(265) > Check app launching
06-01 21:13:41.567+0900 D/AUL_PAD ( 2943): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-01 21:13:41.567+0900 D/AUL_PAD (10289): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-01 21:13:41.567+0900 D/AUL_PAD (10289): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
06-01 21:13:41.567+0900 D/AUL_PAD (10289): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-01 21:13:41.567+0900 D/AUL_PAD (10289): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-01 21:13:41.567+0900 D/AUL_PAD (10289): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-01 21:13:41.567+0900 D/AUL_PAD (10289): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-01 21:13:41.567+0900 D/AUL     (10289): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (10298) is sent.
06-01 21:13:41.567+0900 D/AUL     (10289): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 10298, signo: 10
06-01 21:13:41.567+0900 D/AUL     (10289): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-01 21:13:41.567+0900 D/AUL_PAD (10289): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-01 21:13:41.567+0900 D/AUL_PAD (10289): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-01 21:13:41.567+0900 D/AUL_PAD (10289): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-01 21:13:41.567+0900 D/AUL_PAD (10289): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-01 21:13:41.567+0900 D/AUL_PAD (10289): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTYzMTkyMjEvNTU3MDU5AA==##
06-01 21:13:41.567+0900 D/AUL_PAD (10289): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-01 21:13:41.567+0900 D/AUL_PAD (10289): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAxMDQ4OQA=##
06-01 21:13:41.567+0900 D/AUL_PAD (10289): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-01 21:13:41.567+0900 D/AUL_PAD (10289): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-01 21:13:41.567+0900 D/AUL_PAD (10289): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-01 21:13:41.567+0900 D/AUL_PAD (10289): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-01 21:13:41.567+0900 D/AUL_PAD (10289): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-01 21:13:41.567+0900 I/CAPI_APPFW_APPLICATION(10289): app_main.c: ui_app_main(788) > app_efl_main
06-01 21:13:41.567+0900 D/LAUNCH  (10289): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-01 21:13:41.567+0900 D/APP_CORE(10289): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-01 21:13:41.567+0900 D/APP_CORE(10289): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-01 21:13:41.567+0900 D/APP_CORE(10289): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-01 21:13:41.587+0900 D/APP_CORE(10289): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-01 21:13:41.587+0900 D/AUL     (10289): app_sock.c: __create_server_sock(156) > pg path - already exists
06-01 21:13:41.587+0900 D/APP_CORE(10289): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42b0520
06-01 21:13:41.587+0900 D/LAUNCH  (10289): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-01 21:13:41.587+0900 I/CAPI_APPFW_APPLICATION(10289): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-01 21:13:41.667+0900 D/AUL_PAD ( 2943): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-01 21:13:41.667+0900 W/AUL     ( 2787): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 10289, appid: org.example.example
06-01 21:13:41.667+0900 D/AUL     ( 2787): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-01 21:13:41.667+0900 E/AUL     ( 2787): simple_util.c: __trm_app_info_send_socket(330) > access
06-01 21:13:41.667+0900 D/AUL_AMD ( 2787): amd_launch.c: _start_app(2700) > add app group info
06-01 21:13:41.667+0900 E/AUL     ( 2787): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-01 21:13:41.667+0900 D/AUL_AMD ( 2787): amd_status.c: _status_add_app_info_list(427) > pid(10289) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-01 21:13:41.667+0900 D/RESOURCED( 2881): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 10289
06-01 21:13:41.667+0900 D/RESOURCED( 2881): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-01 21:13:41.667+0900 E/RESOURCED( 2881): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-01 21:13:41.667+0900 D/RESOURCED( 2881): proc-main.c: resourced_proc_status_change(888) > available memory = 315
06-01 21:13:41.687+0900 D/LAUNCH  (10289): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
06-01 21:13:41.687+0900 D/APP_CORE(10289): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-01 21:13:41.697+0900 E/E17     ( 2736): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x01200002)
06-01 21:13:41.737+0900 E/E17     ( 2736): e_border.c: e_border_show(2088) > BD_SHOW(0x01200002)
06-01 21:13:41.747+0900 D/APP_CORE(10289): appcore.c: __aul_handler(587) > [APP 10289]     AUL event: AUL_START
06-01 21:13:41.747+0900 I/APP_CORE(10289): appcore-efl.c: __do_app(496) > [APP 10289] Event: RESET State: CREATED
06-01 21:13:41.747+0900 D/APP_CORE(10289): appcore-efl.c: __do_app(527) > [APP 10289] RESET
06-01 21:13:41.747+0900 D/LAUNCH  (10289): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
06-01 21:13:41.747+0900 D/APP_CORE(10289): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-01 21:13:41.747+0900 D/APP_CORE(10289): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-01 21:13:41.747+0900 I/CAPI_APPFW_APPLICATION(10289): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-01 21:13:41.747+0900 D/AUL     (10289): service.c: __set_bundle(186) > __set_bundle
06-01 21:13:41.747+0900 D/LAUNCH  (10289): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-01 21:13:41.747+0900 D/APP_CORE(10289): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-01 21:13:41.747+0900 E/EFL     (10289): edje<10289> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 21:13:41.747+0900 E/EFL     (10289): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 21:13:41.747+0900 E/EFL     (10289): edje<10289> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 21:13:41.747+0900 E/EFL     (10289): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 21:13:41.747+0900 E/EFL     (10289): edje<10289> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 21:13:41.747+0900 E/EFL     (10289): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 21:13:41.747+0900 E/EFL     (10289): edje<10289> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 21:13:41.747+0900 E/EFL     (10289): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 21:13:41.747+0900 E/EFL     (10289): edje<10289> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 21:13:41.747+0900 E/EFL     (10289): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 21:13:41.797+0900 W/PROCESSMGR( 2736): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=10289
06-01 21:13:41.807+0900 E/EFL     ( 2736): eo<2736> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 21:13:41.807+0900 E/EFL     ( 2736): eo<2736> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 21:13:41.827+0900 D/INDICATOR( 2886): main.c: _property_changed_cb(432) > UNSNIFF API 1800002
06-01 21:13:41.827+0900 D/INDICATOR( 2886): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-01 21:13:41.827+0900 D/INDICATOR( 2886): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-01 21:13:41.827+0900 D/INDICATOR( 2886): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-01 21:13:41.827+0900 D/INDICATOR( 2886): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-01 21:13:41.827+0900 D/INDICATOR( 2886): main.c: _rotate_window(252) > port :: hide more icon
06-01 21:13:41.847+0900 D/AUL_AMD ( 2787): amd_request.c: __request_handler(838) > __request_handler: 15
06-01 21:13:41.847+0900 D/PKGMGR_INFO( 2787): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 21:13:41.847+0900 D/PKGMGR_INFO( 2787): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 21:13:41.847+0900 D/AUL_AMD ( 2787): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 10289 is org.example.example
06-01 21:13:41.847+0900 D/AUL_AMD ( 2787): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 10289 : 0
06-01 21:13:41.847+0900 D/AUL     ( 2961): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-01 21:13:41.897+0900 D/APP_CORE(10289): appcore.c: __prt_ltime(236) > [APP 10289] first idle after reset: 346 msec
06-01 21:13:41.927+0900 W/APP_CORE(10289): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1200002
06-01 21:13:41.927+0900 D/APP_CORE(10289): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:1200002
06-01 21:13:41.927+0900 D/APP_CORE(10289): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-01 21:13:41.927+0900 D/AUL     (10289): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-01 21:13:41.927+0900 D/AUL_AMD ( 2787): amd_request.c: __request_handler(838) > __request_handler: 34
06-01 21:13:42.307+0900 E/E17     ( 2736): e_border.c: e_border_hide(2248) > BD_HIDE(0x01800002), visible:1
06-01 21:13:42.307+0900 D/APP_CORE(10289): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1200002 fully_obscured 0
06-01 21:13:42.307+0900 D/APP_CORE( 2894): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1800002 fully_obscured 1
06-01 21:13:42.307+0900 D/APP_CORE( 2894): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-01 21:13:42.307+0900 D/APP_CORE( 2894): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-01 21:13:42.307+0900 I/APP_CORE( 2894): appcore-efl.c: __do_app(496) > [APP 2894] Event: PAUSE State: RUNNING
06-01 21:13:42.307+0900 D/APP_CORE( 2894): appcore-efl.c: __do_app(565) > [APP 2894] PAUSE
06-01 21:13:42.307+0900 I/CAPI_APPFW_APPLICATION( 2894): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-01 21:13:42.307+0900 E/cluster-home( 2894): homescreen.cpp: OnPause(84) >  app pause
06-01 21:13:42.307+0900 D/APP_CORE(10289): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-01 21:13:42.307+0900 D/APP_CORE(10289): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-01 21:13:42.307+0900 I/APP_CORE(10289): appcore-efl.c: __do_app(496) > [APP 10289] Event: RESUME State: CREATED
06-01 21:13:42.307+0900 D/LAUNCH  (10289): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-01 21:13:42.307+0900 D/APP_CORE(10289): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-01 21:13:42.307+0900 D/APP_CORE(10289): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-01 21:13:42.307+0900 D/APP_CORE(10289): appcore-efl.c: __do_app(607) > [APP 10289] RESUME
06-01 21:13:42.307+0900 D/cluster-view( 2894): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-01 21:13:42.307+0900 D/cluster-view( 2894): homescreen-view-manager.cpp: AppPause(923) >  END
06-01 21:13:42.307+0900 D/APP_CORE( 2894): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-01 21:13:42.307+0900 E/APP_CORE( 2894): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-01 21:13:42.307+0900 I/APP_CORE(10289): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-01 21:13:42.307+0900 I/APP_CORE(10289): appcore-efl.c: __do_app(614) > [APP 10289] Initial Launching, call the resume_cb
06-01 21:13:42.307+0900 I/CAPI_APPFW_APPLICATION(10289): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-01 21:13:42.307+0900 D/LAUNCH  (10289): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-01 21:13:42.307+0900 D/LAUNCH  (10289): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-01 21:13:42.307+0900 D/APP_CORE(10289): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-01 21:13:42.307+0900 E/APP_CORE(10289): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-01 21:13:42.317+0900 D/AUL_AMD ( 2787): amd_status.c: _status_update_app_info_list(456) > pid(2894) status(4)
06-01 21:13:42.317+0900 D/AUL_AMD ( 2787): amd_status.c: _status_update_app_info_list(468) > pid(2894) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-01 21:13:42.317+0900 D/AUL     ( 2787): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-01 21:13:42.317+0900 W/AUL     ( 2787): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2894, appid: org.tizen.homescreen, status: bg
06-01 21:13:42.327+0900 D/DATA_PROVIDER_MASTER( 2950): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2894 is paused
06-01 21:13:42.327+0900 D/AUL_AMD ( 2787): amd_launch.c: __e17_status_handler(2891) > pid(10289) status(3)
06-01 21:13:42.327+0900 D/AUL_AMD ( 2787): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-01 21:13:42.327+0900 D/DATA_PROVIDER_MASTER( 2950): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-01 21:13:42.337+0900 I/CAPI_WIDGET_APPLICATION( 3024): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-01 21:13:42.337+0900 I/CAPI_WIDGET_APPLICATION( 3024): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-01 21:13:42.337+0900 W/AUL     ( 3024): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3024, appid: org.tizen.calendar.widget, status: bg
06-01 21:13:42.337+0900 D/RESOURCED( 2881): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3024, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-01 21:13:42.337+0900 D/RESOURCED( 2881): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3024
06-01 21:13:42.337+0900 D/RESOURCED( 2881): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3024, appname = org.tizen.calendar.widget
06-01 21:13:42.337+0900 D/RESOURCED( 2881): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3024
06-01 21:13:42.357+0900 W/AUL_AMD ( 2787): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-01 21:13:42.357+0900 W/AUL_AMD ( 2787): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-01 21:13:42.357+0900 D/AUL_AMD ( 2787): amd_status.c: _status_update_app_info_list(456) > pid(10289) status(3)
06-01 21:13:42.357+0900 D/AUL_AMD ( 2787): amd_status.c: _status_update_app_info_list(468) > pid(10289) appid(org.example.example) pkgid(org.example.example) status(3)
06-01 21:13:42.357+0900 D/AUL     ( 2787): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-01 21:13:42.357+0900 W/AUL     ( 2787): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 10289, appid: org.example.example, status: fg
06-01 21:13:42.357+0900 D/RESOURCED( 2881): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 10289
06-01 21:13:42.357+0900 D/RESOURCED( 2881): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 10289, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-01 21:13:42.357+0900 D/RESOURCED( 2881): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 10289
06-01 21:13:42.407+0900 D/RESOURCED( 2881): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 10289, appname = org.example.example, pkgname = org.example.example
06-01 21:13:42.407+0900 D/RESOURCED( 2881): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 10289, appname = org.example.example
06-01 21:13:42.407+0900 D/RESOURCED( 2881): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 10289
06-01 21:13:42.407+0900 I/RESOURCED( 2881): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-01 21:13:42.407+0900 I/RESOURCED( 2881): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-01 21:13:42.477+0900 D/AUL_AMD ( 2787): amd_launch.c: __e17_status_handler(2910) > pid(10289) status(0)
06-01 21:13:42.667+0900 D/AUL_PAD ( 2943): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-01 21:13:42.667+0900 D/AUL_PAD (10496): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-01 21:13:42.687+0900 D/AUL_PAD ( 2943): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-01 21:13:42.697+0900 E/RESOURCED( 2881): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.857
06-01 21:13:42.967+0900 I/user_tag0(10289): /opt/usr/apps/org.example.example/data/test.db
06-01 21:13:43.027+0900 E/EFL     ( 2736): eo<2736> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 21:13:43.037+0900 D/AUL_PAD ( 2943): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-01 21:13:43.037+0900 D/AUL_PAD ( 2943): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 21:13:43.037+0900 D/AUL_PAD ( 2943): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 21:13:43.037+0900 D/AUL_PAD ( 2943): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 21:13:43.037+0900 D/AUL_PAD ( 2943): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 21:13:43.037+0900 D/AUL_PAD ( 2943): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 21:13:43.037+0900 D/AUL_PAD ( 2943): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 21:13:43.037+0900 I/AUL_PAD ( 2943): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 10289 pgid = 10289
06-01 21:13:43.037+0900 I/AUL_PAD ( 2943): sigchild.h: __sigchild_action(142) > dead_pid(10289)
06-01 21:13:43.057+0900 D/PROCESSMGR( 2736): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002e  register trigger_timer!  pointed_win=0x40174c 
06-01 21:13:43.057+0900 E/E17     ( 2736): e_border.c: e_border_show(2088) > BD_SHOW(0x01800002)
06-01 21:13:43.067+0900 D/AUL_AMD ( 2787): amd_launch.c: __e17_status_handler(2891) > pid(2894) status(3)
06-01 21:13:43.067+0900 D/AUL_AMD ( 2787): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-01 21:13:43.067+0900 W/AUL_AMD ( 2787): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-01 21:13:43.067+0900 W/AUL_AMD ( 2787): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-01 21:13:43.067+0900 D/AUL_AMD ( 2787): amd_status.c: _status_update_app_info_list(456) > pid(2894) status(3)
06-01 21:13:43.067+0900 D/AUL_AMD ( 2787): amd_status.c: _status_update_app_info_list(468) > pid(2894) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(3)
06-01 21:13:43.067+0900 D/AUL     ( 2787): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.tizen.homescreen
06-01 21:13:43.067+0900 W/AUL     ( 2787): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2894, appid: org.tizen.homescreen, status: fg
06-01 21:13:43.077+0900 D/RESOURCED( 2881): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2894
06-01 21:13:43.077+0900 E/E17     ( 2736): e_border.c: e_border_hide(2248) > BD_HIDE(0x01200002), visible:1
06-01 21:13:43.077+0900 D/RESOURCED( 2881): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 2894, appname = org.tizen.homescreen, pkgname = org.tizen.homescreen
06-01 21:13:43.077+0900 D/RESOURCED( 2881): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2894, appname = org.tizen.homescreen
06-01 21:13:43.077+0900 D/RESOURCED( 2881): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2894
06-01 21:13:43.087+0900 D/AUL_PAD ( 2943): sigchild.h: __send_app_dead_signal(90) > send dead signal done
06-01 21:13:43.087+0900 I/AUL_PAD ( 2943): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
06-01 21:13:43.087+0900 I/AUL_PAD ( 2943): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
06-01 21:13:43.087+0900 E/AUL_PAD ( 2943): launchpad.c: main(688) > error reading sigchld info
06-01 21:13:43.087+0900 D/STARTER ( 2877): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 10289 is termianted
06-01 21:13:43.087+0900 D/STARTER ( 2877): starter.c: _check_dead_signal(202) > [_check_dead_signal:202] Unknown process, ignore it
06-01 21:13:43.087+0900 I/ESD     ( 2959): esd_main.c: __esd_app_dead_handler(1771) > pid: 10289
06-01 21:13:43.087+0900 D/INDICATOR( 2886): main.c: _property_changed_cb(432) > UNSNIFF API 1200002
06-01 21:13:43.087+0900 W/AUL_AMD ( 2787): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 10289
06-01 21:13:43.087+0900 W/AUL_AMD ( 2787): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 10289
06-01 21:13:43.087+0900 D/AUL_AMD ( 2787): amd_key.c: _unregister_key_event(179) > ===key stack===
06-01 21:13:43.087+0900 E/AUL_AMD ( 2787): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
06-01 21:13:43.087+0900 D/AUL_AMD ( 2787): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.example.example)
06-01 21:13:43.087+0900 D/AUL     ( 2787): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-01 21:13:43.087+0900 E/AUL     ( 2787): simple_util.c: __trm_app_info_send_socket(330) > access
06-01 21:13:43.087+0900 E/RESOURCED( 2881): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.859
06-01 21:13:43.097+0900 W/CRASH_MANAGER(10497): worker.c: worker_job(1204) > 1110289657861149631922
