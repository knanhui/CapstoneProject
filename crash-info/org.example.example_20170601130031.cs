S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 7043
Date: 2017-06-01 13:00:31+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x1c

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb7ed4cb8, esi = 0xb37b8ff0
ebp = 0xbfd8b1e8, esp = 0xbfd8b190
eax = 0x00000000, ebx = 0xb37bc000
ecx = 0x00000000, edx = 0x40000008
eip = 0xb37b858c

Memory Information
MemTotal:      123 KB
MemFree:        31 KB
Buffers:         6 KB
Cached:     165776 KB
VmPeak:     100300 KB
VmSize:     100300 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21880 KB
VmRSS:       21880 KB
VmData:      32748 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34456 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 7043 TID = 7043
7043 7044 7203 7204 

Maps Information
b2b79000 b2b83000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b89000 b2b95000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b96000 b2bb7000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2bbc000 b2bbd000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2bbe000 b2bc3000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2bc4000 b2bc5000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2bc6000 b2bc8000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2bc9000 b2bd5000 r-xp /usr/lib/libdrm.so.2.4.0
b2bd6000 b2bd9000 r-xp /usr/lib/libdri2.so.0.0.0
b2bda000 b2be4000 r-xp /usr/lib/libtbm.so.1.0.0
b2be5000 b2bfa000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2bfb000 b2c0d000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b340f000 b3440000 r-xp /usr/lib/libidn.so.11.5.44
b3441000 b3463000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3464000 b3474000 r-xp /usr/lib/libcares.so.2.1.0
b3475000 b347e000 r-xp /usr/lib/libeventsystem.so.0.0.1
b347f000 b3488000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3489000 b3500000 r-xp /usr/lib/libcurl.so.4.3.0
b3502000 b3514000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3515000 b3536000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b353d000 b353e000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b353f000 b3540000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3541000 b3544000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3545000 b3548000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3650000 b3656000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3657000 b379b000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37ab000 b37ad000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b37ae000 b37af000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37b0000 b37ba000 r-xp /opt/usr/apps/org.example.example/bin/example
b37bd000 b37f6000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41f9000 b4204000 r-xp /lib/libnss_files-2.20-2014.11.so
b4206000 b4211000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4213000 b422a000 r-xp /lib/libnsl-2.20-2014.11.so
b422e000 b4236000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4238000 b425c000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b425d000 b425e000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b425f000 b4262000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4263000 b426a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b426b000 b4275000 r-xp /usr/lib/libsensord-share.so
b4276000 b4292000 r-xp /usr/lib/libsensor.so.1.2.0
b4294000 b429d000 r-xp /usr/lib/libappcore-common.so.1.1
b42a0000 b42a2000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42b7000 b42b9000 r-xp /usr/lib/libXau.so.6.0.0
b42ba000 b42dc000 r-xp /usr/lib/libxcb.so.1.1.0
b42de000 b42e7000 r-xp /lib/libcrypt-2.20-2014.11.so
b4310000 b4312000 r-xp /usr/lib/libiri.so
b4313000 b4339000 r-xp /lib/libexpat.so.1.5.2
b433b000 b43a6000 r-xp /usr/lib/libssl.so.1.0.0
b43ac000 b43b8000 r-xp /usr/lib/libethumb.so.1.13.0
b43b9000 b43bd000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43be000 b460f000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b8a000 b5b9a000 r-xp /usr/lib/libXi.so.6.1.0
b5b9b000 b5b9d000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b9e000 b5ba4000 r-xp /usr/lib/libXtst.so.6.1.0
b5ba5000 b5baf000 r-xp /usr/lib/libXrender.so.1.3.0
b5bb0000 b5bb9000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bbb000 b5bbd000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bbe000 b5bc3000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bc4000 b5bd6000 r-xp /usr/lib/libXext.so.6.4.0
b5bd7000 b5bd9000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bda000 b5bdc000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bde000 b5d20000 r-xp /usr/lib/libX11.so.6.3.0
b5d24000 b5d2e000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d2f000 b5d45000 r-xp /usr/lib/libudev.so.1.6.0
b5d48000 b5d4c000 r-xp /lib/libattr.so.1.1.0
b5d4d000 b5d7c000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d7e000 b5d84000 r-xp /usr/lib/libffi.so.6.0.2
b5d85000 b5da8000 r-xp /lib/libz.so.1.2.8
b5da9000 b5dac000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5dad000 b5f09000 r-xp /usr/lib/libxml2.so.2.9.2
b5f0f000 b5ff6000 r-xp /usr/lib/libstdc++.so.6.0.20
b6003000 b6006000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6007000 b6029000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b602a000 b603e000 r-xp /lib/libresolv-2.20-2014.11.so
b6042000 b6066000 r-xp /usr/lib/liblzma.so.5.0.3
b6067000 b6069000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b606b000 b6075000 r-xp /usr/lib/libembryo.so.1.13.0
b6076000 b609f000 r-xp /usr/lib/libpng12.so.0.50.0
b60a0000 b60e9000 r-xp /usr/lib/libjpeg.so.8.0.2
b60fa000 b6101000 r-xp /lib/librt-2.20-2014.11.so
b6103000 b6122000 r-xp /usr/lib/libector.so.1.13.0
b6125000 b6152000 r-xp /usr/lib/liblua-5.1.so
b6153000 b61e3000 r-xp /usr/lib/libfreetype.so.6.11.3
b61e7000 b6225000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6226000 b623c000 r-xp /usr/lib/libfribidi.so.0.3.1
b623d000 b6296000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6299000 b62e4000 r-xp /lib/libm-2.20-2014.11.so
b62e6000 b62f8000 r-xp /usr/lib/libeio.so.1.13.0
b62f9000 b62fc000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62fd000 b6303000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6304000 b6327000 r-xp /usr/lib/libefreet.so.1.13.0
b632a000 b6355000 r-xp /usr/lib/libeldbus.so.1.13.0
b6356000 b638a000 r-xp /usr/lib/libecore_con.so.1.13.0
b638c000 b6395000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6396000 b639f000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63a0000 b63b3000 r-xp /usr/lib/libeo.so.1.13.0
b63b5000 b63c8000 r-xp /usr/lib/libecore_input.so.1.13.0
b63c9000 b63d0000 r-xp /usr/lib/libecore_file.so.1.13.0
b63d1000 b63f4000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63f5000 b6421000 r-xp /usr/lib/libeet.so.1.13.0
b642a000 b6495000 r-xp /usr/lib/libeina.so.1.13.0
b6498000 b64af000 r-xp /usr/lib/libefl.so.1.13.0
b64b1000 b6618000 r-xp /usr/lib/libicuuc.so.51.1
b6626000 b6832000 r-xp /usr/lib/libicui18n.so.51.1
b683a000 b6889000 r-xp /usr/lib/libecore_x.so.1.13.0
b688b000 b68a5000 r-xp /lib/libgcc_s-4.9.so.1
b68a7000 b68ab000 r-xp /lib/libcap.so.2.21
b68ac000 b68f2000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68f3000 b68fa000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68fc000 b694e000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6950000 b6adb000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6ae0000 b6bae000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bb1000 b6bb5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bb6000 b6bc5000 r-xp /usr/lib/libvconf.so.0.2.45
b6bc6000 b6bc9000 r-xp /usr/lib/libvasum.so.0.3.1
b6bca000 b6bcd000 r-xp /usr/lib/libttrace.so.1.1
b6bcf000 b6bd3000 r-xp /usr/lib/libiniparser.so.0
b6bd4000 b6c04000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c05000 b6c0e000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c0f000 b6c34000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c35000 b6c45000 r-xp /usr/lib/libunwind.so.8.0.1
b6c4f000 b6dfd000 r-xp /lib/libc-2.20-2014.11.so
b6e05000 b6f48000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f4a000 b6fa2000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fa3000 b6fd7000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fda000 b70ae000 r-xp /usr/lib/libedje.so.1.13.0
b70b1000 b70dd000 r-xp /usr/lib/libecore.so.1.13.0
b70ee000 b7314000 r-xp /usr/lib/libevas.so.1.13.0
b733c000 b7354000 r-xp /lib/libpthread-2.20-2014.11.so
b7358000 b76d2000 r-xp /usr/lib/libelementary.so.1.13.0
b76f2000 b76f6000 r-xp /usr/lib/libsmack.so.1.0.0
b76f7000 b7700000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7701000 b7704000 r-xp /usr/lib/libdlog.so.0.0.0
b7705000 b770a000 r-xp /usr/lib/libbundle.so.0.1.22
b770b000 b770e000 r-xp /lib/libdl-2.20-2014.11.so
b7710000 b7735000 r-xp /usr/lib/libaul.so.0.1.0
b7738000 b773a000 r-xp /usr/lib/libappsvc.so.0.1.0
b773b000 b7740000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7741000 b7748000 r-xp /usr/lib/libappcore-efl.so.1.1
b774a000 b774f000 r-xp /usr/lib/libsys-assert.so
b7752000 b7753000 r-xp [vdso]
b7753000 b7775000 r-xp /lib/ld-2.20-2014.11.so
b7777000 b777f000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:7043)
Call Stack Count: 18
 0: setting_view_cb + 0x8c (0xb37b858c) [/opt/usr/apps/org.example.example/bin/example] + 0x858c
 1: (0xb7122449) [/usr/lib/libevas.so.1] + 0x34449
 2: (0xb63ae319) [/usr/lib/libeo.so.1] + 0xe319
 3: eo_event_callback_call + 0xb3 (0xb63abd63) [/usr/lib/libeo.so.1] + 0xbd63
 4: (0xb7122a62) [/usr/lib/libevas.so.1] + 0x34a62
 5: (0xb7131441) [/usr/lib/libevas.so.1] + 0x43441
 6: evas_canvas_event_feed_mouse_down + 0xcf (0xb713b20f) [/usr/lib/libevas.so.1] + 0x4d20f
 7: evas_event_feed_mouse_down + 0x6a (0xb7141c2a) [/usr/lib/libevas.so.1] + 0x53c2a
 8: (0xb43bb49c) [/usr/lib/libecore_input_evas.so.1] + 0x249c
 9: (0xb70be055) [/usr/lib/libecore.so.1] + 0xd055
10: (0xb70c71b9) [/usr/lib/libecore.so.1] + 0x161b9
11: ecore_main_loop_begin + 0x57 (0xb70c7587) [/usr/lib/libecore.so.1] + 0x16587
12: elm_run + 0x2d (0xb752022d) [/usr/lib/libelementary.so.1] + 0x1c822d
13: appcore_efl_main + 0x4de (0xb7744dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
14: ui_app_main + 0x140 (0xb773dc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
15: main + 0x2e1 (0xb37b7641) [/opt/usr/apps/org.example.example/bin/example] + 0x7641
16: (0xb7779148) [/opt/usr/apps/org.example.example/bin/example] + 0xb7779148
17: __libc_start_main + 0xde (0xb6c66e4e) [/lib/libc.so.6] + 0x17e4e
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
5.162+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.email]
06-01 13:00:25.162+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Email] pos[2, 2] pageId[100001]
06-01 13:00:25.162+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[5]
06-01 13:00:25.162+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[6], [2, 2]
06-01 13:00:25.162+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[6], [2, 2]
06-01 13:00:25.162+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 13:00:25.162+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.example] Name[forpet] Icon[/opt/usr/apps/org.example.example/shared/res/1.jpg] enable[1] system[0]
06-01 13:00:25.162+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.example'], count[0]
06-01 13:00:25.162+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.example][-17956860][0]
06-01 13:00:25.162+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.example]
06-01 13:00:25.162+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[forpet] pos[3, 2] pageId[100001]
06-01 13:00:25.162+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[0]
06-01 13:00:25.162+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(787) >  AddBoxToMenuView
06-01 13:00:25.162+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(347) >  AddBox Name[forpet] pageid[100001] pos[3, 2]
06-01 13:00:25.162+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(354) >  menuPage.GetPageId() = 100001, boxPageId = 100001
06-01 13:00:25.162+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: AddBoxToPage(112) >  void ClusterHome3D::Internal::CMainMenuPage::AddBoxToPage(std::shared_ptr<CMainMenuBoxData>) : 112
06-01 13:00:25.162+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: AddBoxToPage(122) >  void ClusterHome3D::Internal::CMainMenuPage::AddBoxToPage(std::shared_ptr<CMainMenuBoxData>) : 122
06-01 13:00:25.162+0900 D/test-log( 2945): mainmenu-page-impl.cpp: AddBoxToPage(123) >  create box[org.example.example] [3,2]
06-01 13:00:25.162+0900 D/test-log( 2945): mainmenu-box-impl.cpp: CMainMenuBox(148) >  create box
06-01 13:00:25.172+0900 D/test-log( 2945): mainmenu-box-impl.cpp: SetPosition(459) >  cut Animation : forpet
06-01 13:00:25.172+0900 D/test-log( 2945): mainmenu-page-impl.cpp: AddBoxToPage(177) >  add created box
06-01 13:00:25.172+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.gallery] Name[Gallery] Icon[/usr/share/icons/default/small/org.tizen.gallery.png] enable[1] system[1]
06-01 13:00:25.172+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.gallery'], count[0]
06-01 13:00:25.172+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.gallery][-17956860][0]
06-01 13:00:25.172+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.gallery]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Gallery] pos[4, 2] pageId[100001]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[6]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[8], [4, 2]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[7], [3, 2]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 13:00:25.172+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.imageutil] Name[imageutil] Icon[/opt/usr/apps/org.example.imageutil/shared/res/imageutil.png] enable[1] system[0]
06-01 13:00:25.172+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.imageutil'], count[0]
06-01 13:00:25.172+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.imageutil][-17956860][0]
06-01 13:00:25.172+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.imageutil]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[imageutil] pos[1, 3] pageId[100001]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[15]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[9], [1, 3]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 13:00:25.172+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.browser] Name[Internet] Icon[/usr/share/icons/default/small/org.tizen.browser.png] enable[1] system[1]
06-01 13:00:25.172+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.browser'], count[0]
06-01 13:00:25.172+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.browser][-17956860][0]
06-01 13:00:25.172+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.browser]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Internet] pos[2, 3] pageId[100001]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[1]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[10], [2, 3]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 13:00:25.172+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.message] Name[Messages] Icon[/usr/share/icons/default/small/org.tizen.message.png] enable[1] system[1]
06-01 13:00:25.172+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.message'], count[1]
06-01 13:00:25.172+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.message]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Messages] pos[3, 3] pageId[100001]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[7]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[11], [3, 3]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 13:00:25.172+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.music-player] Name[Music] Icon[/usr/share/icons/default/small/org.tizen.music-player.png] enable[1] system[1]
06-01 13:00:25.172+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.music-player'], count[0]
06-01 13:00:25.172+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.music-player][-17956860][0]
06-01 13:00:25.172+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.music-player]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Music] pos[4, 3] pageId[100001]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[8]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[12], [4, 3]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 13:00:25.172+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.myfile] Name[My Files] Icon[/usr/share/icons/default/small/org.tizen.myfile.png] enable[1] system[1]
06-01 13:00:25.172+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.myfile'], count[0]
06-01 13:00:25.172+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.myfile][-17956860][0]
06-01 13:00:25.172+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.myfile]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[My Files] pos[1, 4] pageId[100001]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[9]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[13], [1, 4]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 13:00:25.172+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.phone] Name[Phone] Icon[/usr/share/icons/default/small/org.tizen.phone.png] enable[1] system[1]
06-01 13:00:25.172+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.phone'], count[0]
06-01 13:00:25.172+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.phone][-17956860][0]
06-01 13:00:25.172+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.phone]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Phone] pos[2, 4] pageId[100001]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[10]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[14], [2, 4]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 13:00:25.172+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.setting] Name[Settings] Icon[/usr/share/icons/default/small/org.tizen.setting.png] enable[1] system[1]
06-01 13:00:25.172+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.setting'], count[0]
06-01 13:00:25.172+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.setting][-17956860][0]
06-01 13:00:25.172+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.setting]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Settings] pos[3, 4] pageId[100001]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[11]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[15], [3, 4]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 13:00:25.172+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.videos] Name[Video] Icon[/usr/share/icons/default/small/org.tizen.videos.png] enable[1] system[1]
06-01 13:00:25.172+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.videos'], count[0]
06-01 13:00:25.172+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.videos][-17956860][0]
06-01 13:00:25.172+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.videos]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Video] pos[4, 4] pageId[100001]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[12]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[16], [4, 4]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 13:00:25.172+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: RearrangeItems(243) >  view type [1]
06-01 13:00:25.202+0900 D/rpm-installer( 7144): rpm-appcore-intf.c: main(238) > sync() end
06-01 13:00:25.382+0900 D/rpm-installer( 7144): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
06-01 13:00:25.382+0900 D/rpm-installer( 7144): rpm-appcore-intf.c: main(259) > ------------------------------------------------
06-01 13:00:25.382+0900 D/rpm-installer( 7144): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
06-01 13:00:25.382+0900 D/rpm-installer( 7144): rpm-appcore-intf.c: main(261) > ------------------------------------------------
06-01 13:00:25.382+0900 D/PKGMGR_SERVER( 7130): pkgmgr-server.c: sighandler(387) > child exit [7144]
06-01 13:00:25.382+0900 E/PKGMGR_SERVER( 7130): pkgmgr-server.c: sighandler(402) > child NORMAL exit [7144]
06-01 13:00:25.392+0900 D/WIDGET_PROVIDER( 3084): widget_provider.c: widget_provider_send_ping(1671) > [SECURE_LOG] name[0_36.679036]
06-01 13:00:25.932+0900 E/PKGMGR_SERVER( 7130): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-01 13:00:25.932+0900 E/PKGMGR_SERVER( 7130): pkgmgr-server.c: main(2265) > package manager server terminated.
06-01 13:00:26.502+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(838) > __request_handler: 0
06-01 13:00:26.502+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-01 13:00:26.502+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 13:00:26.502+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 13:00:26.502+0900 I/AUL     ( 2858): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
06-01 13:00:26.502+0900 D/AUL     ( 2858): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 7197, pid = 7199
06-01 13:00:26.502+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 13:00:26.502+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 13:00:26.502+0900 I/AUL     ( 2858): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
06-01 13:00:26.502+0900 E/AUL_AMD ( 2858): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-01 13:00:26.502+0900 W/AUL_AMD ( 2858): amd_launch.c: _start_app(2233) > caller pid : 7199
06-01 13:00:26.502+0900 E/AUL_AMD ( 2858): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-01 13:00:26.502+0900 W/AUL_AMD ( 2858): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-01 13:00:26.502+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2648) > process_pool: false
06-01 13:00:26.502+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-01 13:00:26.502+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-01 13:00:26.502+0900 W/AUL_AMD ( 2858): amd_launch.c: _start_app(2665) > pad pid(-5)
06-01 13:00:26.502+0900 D/AUL_AMD ( 2858): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-01 13:00:26.502+0900 D/AUL_AMD ( 2858): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-01 13:00:26.502+0900 D/AUL     ( 2858): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-01 13:00:26.502+0900 D/AUL_PAD ( 3003): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-01 13:00:26.502+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 13:00:26.502+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 13:00:26.502+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 13:00:26.502+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 13:00:26.502+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 13:00:26.502+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 13:00:26.502+0900 D/AUL_PAD ( 3003): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-01 13:00:26.502+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-01 13:00:26.502+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-01 13:00:26.502+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-01 13:00:26.502+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-01 13:00:26.502+0900 D/AUL_PAD ( 3003): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-01 13:00:26.502+0900 D/AUL_PAD ( 3003): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-01 13:00:26.502+0900 W/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-01 13:00:26.502+0900 D/AUL     ( 3003): process_pool.c: __send_pkt_raw_data(219) > send(11) : 620 / 620
06-01 13:00:26.502+0900 D/AUL_PAD ( 3003): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 7043, bin path: /opt/usr/apps/org.example.example/bin/example
06-01 13:00:26.502+0900 W/AUL_PAD ( 3003): launchpad.c: __send_result_to_caller(265) > Check app launching
06-01 13:00:26.502+0900 D/AUL_PAD ( 3003): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-01 13:00:26.512+0900 D/RESOURCED( 2893): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-01 13:00:26.512+0900 D/RESOURCED( 2893): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-01 13:00:26.512+0900 E/RESOURCED( 2893): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-01 13:00:26.512+0900 D/AUL_PAD ( 7043): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-01 13:00:26.512+0900 D/AUL_PAD ( 7043): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
06-01 13:00:26.512+0900 D/AUL_PAD ( 7043): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-01 13:00:26.512+0900 D/AUL_PAD ( 7043): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-01 13:00:26.512+0900 D/AUL_PAD ( 7043): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-01 13:00:26.512+0900 D/AUL_PAD ( 7043): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-01 13:00:26.512+0900 D/AUL     ( 7043): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (7044) is sent.
06-01 13:00:26.512+0900 D/AUL     ( 7043): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 7044, signo: 10
06-01 13:00:26.512+0900 D/AUL     ( 7043): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-01 13:00:26.512+0900 D/AUL_PAD ( 7043): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-01 13:00:26.522+0900 D/AUL_PAD ( 7043): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-01 13:00:26.522+0900 D/AUL_PAD ( 7043): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-01 13:00:26.522+0900 D/AUL_PAD ( 7043): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-01 13:00:26.522+0900 D/AUL_PAD ( 7043): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTYyODk2MjYvNTEyMTA0AA==##
06-01 13:00:26.522+0900 D/AUL_PAD ( 7043): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-01 13:00:26.522+0900 D/AUL_PAD ( 7043): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA3MTk5AA==##
06-01 13:00:26.522+0900 D/AUL_PAD ( 7043): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-01 13:00:26.522+0900 D/AUL_PAD ( 7043): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-01 13:00:26.522+0900 D/AUL_PAD ( 7043): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-01 13:00:26.522+0900 D/AUL_PAD ( 7043): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-01 13:00:26.522+0900 D/AUL_PAD ( 7043): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-01 13:00:26.522+0900 I/CAPI_APPFW_APPLICATION( 7043): app_main.c: ui_app_main(788) > app_efl_main
06-01 13:00:26.522+0900 D/LAUNCH  ( 7043): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-01 13:00:26.522+0900 D/APP_CORE( 7043): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-01 13:00:26.522+0900 D/APP_CORE( 7043): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-01 13:00:26.522+0900 D/APP_CORE( 7043): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-01 13:00:26.552+0900 D/APP_CORE( 7043): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-01 13:00:26.552+0900 D/AUL     ( 7043): app_sock.c: __create_server_sock(156) > pg path - already exists
06-01 13:00:26.552+0900 D/APP_CORE( 7043): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb429d520
06-01 13:00:26.552+0900 D/LAUNCH  ( 7043): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-01 13:00:26.552+0900 I/CAPI_APPFW_APPLICATION( 7043): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-01 13:00:26.612+0900 D/AUL_PAD ( 3003): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-01 13:00:26.612+0900 W/AUL     ( 2858): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 7043, appid: org.example.example
06-01 13:00:26.612+0900 D/AUL     ( 2858): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-01 13:00:26.612+0900 E/AUL     ( 2858): simple_util.c: __trm_app_info_send_socket(330) > access
06-01 13:00:26.612+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2700) > add app group info
06-01 13:00:26.612+0900 E/AUL     ( 2858): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-01 13:00:26.612+0900 D/AUL_AMD ( 2858): amd_status.c: _status_add_app_info_list(427) > pid(7043) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-01 13:00:26.612+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 7043
06-01 13:00:26.612+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-01 13:00:26.612+0900 E/RESOURCED( 2893): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-01 13:00:26.612+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(888) > available memory = 320
06-01 13:00:26.682+0900 D/LAUNCH  ( 7043): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
06-01 13:00:26.682+0900 D/APP_CORE( 7043): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-01 13:00:26.692+0900 E/E17     ( 2741): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02800002)
06-01 13:00:26.732+0900 E/E17     ( 2741): e_border.c: e_border_show(2088) > BD_SHOW(0x02800002)
06-01 13:00:26.752+0900 D/APP_CORE( 7043): appcore.c: __aul_handler(587) > [APP 7043]     AUL event: AUL_START
06-01 13:00:26.752+0900 I/APP_CORE( 7043): appcore-efl.c: __do_app(496) > [APP 7043] Event: RESET State: CREATED
06-01 13:00:26.752+0900 D/APP_CORE( 7043): appcore-efl.c: __do_app(527) > [APP 7043] RESET
06-01 13:00:26.752+0900 D/LAUNCH  ( 7043): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
06-01 13:00:26.752+0900 D/APP_CORE( 7043): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-01 13:00:26.752+0900 D/APP_CORE( 7043): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-01 13:00:26.752+0900 I/CAPI_APPFW_APPLICATION( 7043): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-01 13:00:26.752+0900 D/AUL     ( 7043): service.c: __set_bundle(186) > __set_bundle
06-01 13:00:26.752+0900 D/LAUNCH  ( 7043): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-01 13:00:26.752+0900 D/APP_CORE( 7043): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-01 13:00:26.752+0900 E/EFL     ( 7043): edje<7043> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 13:00:26.752+0900 E/EFL     ( 7043): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 13:00:26.752+0900 E/EFL     ( 7043): edje<7043> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 13:00:26.752+0900 E/EFL     ( 7043): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 13:00:26.752+0900 E/EFL     ( 7043): edje<7043> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 13:00:26.752+0900 E/EFL     ( 7043): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 13:00:26.752+0900 E/EFL     ( 7043): edje<7043> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 13:00:26.752+0900 E/EFL     ( 7043): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 13:00:26.752+0900 E/EFL     ( 7043): edje<7043> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 13:00:26.752+0900 E/EFL     ( 7043): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 13:00:26.782+0900 W/APP_CORE( 7043): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2800002
06-01 13:00:26.782+0900 D/APP_CORE( 7043): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2800002
06-01 13:00:26.782+0900 D/APP_CORE( 7043): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-01 13:00:26.782+0900 D/AUL     ( 7043): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-01 13:00:26.782+0900 W/PROCESSMGR( 2741): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=7043
06-01 13:00:26.782+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(838) > __request_handler: 34
06-01 13:00:26.802+0900 E/EFL     ( 2741): eo<2741> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 13:00:26.802+0900 E/EFL     ( 2741): eo<2741> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 13:00:26.822+0900 D/INDICATOR( 2934): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
06-01 13:00:26.822+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(838) > __request_handler: 15
06-01 13:00:26.822+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 13:00:26.822+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 13:00:26.832+0900 D/AUL_AMD ( 2858): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 7043 is org.example.example
06-01 13:00:26.832+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 7043 : 0
06-01 13:00:26.832+0900 D/INDICATOR( 2934): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-01 13:00:26.832+0900 D/AUL     ( 3022): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-01 13:00:26.832+0900 D/INDICATOR( 2934): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-01 13:00:26.832+0900 D/INDICATOR( 2934): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-01 13:00:26.832+0900 D/INDICATOR( 2934): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-01 13:00:26.832+0900 D/INDICATOR( 2934): main.c: _rotate_window(252) > port :: hide more icon
06-01 13:00:27.112+0900 D/APP_CORE( 7043): appcore.c: __prt_ltime(236) > [APP 7043] first idle after reset: 618 msec
06-01 13:00:27.282+0900 E/E17     ( 2741): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
06-01 13:00:27.282+0900 D/APP_CORE( 2945): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
06-01 13:00:27.282+0900 D/APP_CORE( 2945): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-01 13:00:27.282+0900 D/APP_CORE( 2945): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-01 13:00:27.282+0900 I/APP_CORE( 2945): appcore-efl.c: __do_app(496) > [APP 2945] Event: PAUSE State: RUNNING
06-01 13:00:27.282+0900 D/APP_CORE( 2945): appcore-efl.c: __do_app(565) > [APP 2945] PAUSE
06-01 13:00:27.282+0900 I/CAPI_APPFW_APPLICATION( 2945): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-01 13:00:27.282+0900 E/cluster-home( 2945): homescreen.cpp: OnPause(84) >  app pause
06-01 13:00:27.282+0900 D/cluster-view( 2945): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-01 13:00:27.282+0900 D/cluster-view( 2945): homescreen-view-manager.cpp: AppPause(923) >  END
06-01 13:00:27.282+0900 D/APP_CORE( 2945): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-01 13:00:27.282+0900 E/APP_CORE( 2945): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-01 13:00:27.282+0900 D/APP_CORE( 7043): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2800002 fully_obscured 0
06-01 13:00:27.282+0900 D/APP_CORE( 7043): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-01 13:00:27.282+0900 D/APP_CORE( 7043): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-01 13:00:27.282+0900 I/APP_CORE( 7043): appcore-efl.c: __do_app(496) > [APP 7043] Event: RESUME State: CREATED
06-01 13:00:27.282+0900 D/LAUNCH  ( 7043): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-01 13:00:27.282+0900 D/APP_CORE( 7043): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-01 13:00:27.282+0900 D/APP_CORE( 7043): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-01 13:00:27.282+0900 D/APP_CORE( 7043): appcore-efl.c: __do_app(607) > [APP 7043] RESUME
06-01 13:00:27.302+0900 I/APP_CORE( 7043): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-01 13:00:27.302+0900 I/APP_CORE( 7043): appcore-efl.c: __do_app(614) > [APP 7043] Initial Launching, call the resume_cb
06-01 13:00:27.302+0900 I/CAPI_APPFW_APPLICATION( 7043): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-01 13:00:27.302+0900 D/LAUNCH  ( 7043): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-01 13:00:27.302+0900 D/LAUNCH  ( 7043): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-01 13:00:27.302+0900 D/APP_CORE( 7043): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-01 13:00:27.302+0900 E/APP_CORE( 7043): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-01 13:00:27.302+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(456) > pid(2945) status(4)
06-01 13:00:27.302+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(468) > pid(2945) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-01 13:00:27.302+0900 D/AUL     ( 2858): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-01 13:00:27.302+0900 W/AUL     ( 2858): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2945, appid: org.tizen.homescreen, status: bg
06-01 13:00:27.302+0900 D/DATA_PROVIDER_MASTER( 3009): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2945 is paused
06-01 13:00:27.302+0900 D/DATA_PROVIDER_MASTER( 3009): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-01 13:00:27.302+0900 D/AUL_AMD ( 2858): amd_launch.c: __e17_status_handler(2891) > pid(7043) status(3)
06-01 13:00:27.302+0900 D/AUL_AMD ( 2858): amd_key.c: _key_ungrab(265) > _key_ungrab, win : c00002
06-01 13:00:27.302+0900 I/CAPI_WIDGET_APPLICATION( 3084): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-01 13:00:27.312+0900 W/AUL_AMD ( 2858): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-01 13:00:27.312+0900 W/AUL_AMD ( 2858): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-01 13:00:27.312+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(456) > pid(7043) status(3)
06-01 13:00:27.312+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(468) > pid(7043) appid(org.example.example) pkgid(org.example.example) status(3)
06-01 13:00:27.312+0900 D/AUL     ( 2858): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-01 13:00:27.312+0900 W/AUL     ( 2858): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 7043, appid: org.example.example, status: fg
06-01 13:00:27.312+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 7043
06-01 13:00:27.312+0900 D/RESOURCED( 2893): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 7043, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-01 13:00:27.312+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 7043
06-01 13:00:27.312+0900 I/CAPI_WIDGET_APPLICATION( 3084): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-01 13:00:27.312+0900 W/AUL     ( 3084): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3084, appid: org.tizen.calendar.widget, status: bg
06-01 13:00:27.352+0900 D/RESOURCED( 2893): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 7043, appname = org.example.example, pkgname = org.example.example
06-01 13:00:27.352+0900 D/RESOURCED( 2893): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 7043, appname = org.example.example
06-01 13:00:27.352+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 7043
06-01 13:00:27.352+0900 D/RESOURCED( 2893): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3084, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-01 13:00:27.352+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3084
06-01 13:00:27.352+0900 D/RESOURCED( 2893): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3084, appname = org.tizen.calendar.widget
06-01 13:00:27.352+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3084
06-01 13:00:27.352+0900 I/RESOURCED( 2893): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-01 13:00:27.352+0900 I/RESOURCED( 2893): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-01 13:00:27.362+0900 D/AUL_AMD ( 2858): amd_launch.c: __e17_status_handler(2910) > pid(7043) status(0)
06-01 13:00:27.632+0900 D/AUL_PAD ( 3003): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-01 13:00:27.642+0900 D/AUL_PAD ( 7206): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-01 13:00:27.672+0900 D/AUL_PAD ( 3003): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-01 13:00:28.122+0900 D/AUL_AMD ( 2858): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-01 13:00:28.122+0900 D/RUA     ( 2858): rua.c: rua_add_history(179) > rua_add_history start
06-01 13:00:28.162+0900 D/RUA     ( 2858): rua.c: rua_add_history(247) > rua_add_history ok
06-01 13:00:28.712+0900 D/AUL_PAD ( 7206): launchpad_loader.c: main(588) > sleeping 1 sec...
06-01 13:00:28.712+0900 D/AUL_PAD ( 7206): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-01 13:00:28.712+0900 D/AUL_PAD ( 7206): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b89d3760
06-01 13:00:28.712+0900 D/AUL_PAD ( 7206): preload.h: __preload_init(69) > get pre-initialization function
06-01 13:00:28.712+0900 D/AUL_PAD ( 7206): preload.h: __preload_init(73) > get shutdown function
06-01 13:00:28.712+0900 D/AUL_PAD ( 7206): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b89d3a40
06-01 13:00:28.712+0900 D/AUL_PAD ( 7206): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b89d5640
06-01 13:00:28.712+0900 D/AUL_PAD ( 7206): preload.h: __preload_init(69) > get pre-initialization function
06-01 13:00:28.712+0900 D/AUL_PAD ( 7206): preload.h: __preload_init(73) > get shutdown function
06-01 13:00:28.712+0900 D/AUL_PAD ( 7206): preexec.h: __preexec_init(76) > preexec start
06-01 13:00:28.722+0900 D/AUL_PAD ( 7206): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-01 13:00:28.722+0900 D/AUL     ( 7206): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-01 13:00:28.722+0900 D/AUL     ( 7206): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-01 13:00:28.722+0900 D/AUL_PAD ( 3003): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-01 13:00:28.722+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-01 13:00:28.722+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 13:00:28.722+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 13:00:28.722+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 13:00:28.722+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 13:00:28.722+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 13:00:28.722+0900 D/AUL_PAD ( 3003): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-01 13:00:28.722+0900 D/AUL_PAD ( 3003): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 7206
06-01 13:00:28.722+0900 D/AUL     ( 7206): process_pool.c: __connect_to_launchpad(132) > send(7206) : 4
06-01 13:00:28.722+0900 D/AUL     ( 7206): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-01 13:00:28.742+0900 E/RESOURCED( 2893): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.529
06-01 13:00:28.912+0900 D/AUL_PAD ( 7206): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-01 13:00:28.922+0900 D/AUL_PAD ( 7206): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-01 13:00:28.922+0900 D/AUL_PAD ( 7206): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-01 13:00:28.932+0900 D/AUL_PAD ( 7206): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-01 13:00:31.412+0900 E/EFL     ( 7043): eo<7043> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xbfd8b7b0 is not pointing to a valid object. Maybe it has already been freed.
06-01 13:00:31.412+0900 E/EFL     ( 7043): eo<7043> lib/eo/eo.c:879 _eo_add_internal_start() Obj (0xbfd8b7b0) is an invalid ref.
06-01 13:00:31.412+0900 I/user_tag( 7043): 설마
06-01 13:00:31.412+0900 I/user_tag2( 7043): 설마
06-01 13:00:31.412+0900 E/EFL     ( 7043): <7043> elm_grid.c:163 elm_grid_add() safety check failed: parent == NULL
06-01 13:00:31.412+0900 E/EFL     ( 7043): <7043> elm_bg.c:115 elm_bg_add() safety check failed: parent == NULL
06-01 13:00:31.412+0900 E/EFL     ( 7043): <7043> elm_label.c:947 elm_label_add() safety check failed: parent == NULL
06-01 13:00:31.412+0900 E/EFL     ( 7043): <7043> elm_label.c:947 elm_label_add() safety check failed: parent == NULL
06-01 13:00:31.412+0900 E/EFL     ( 7043): <7043> elm_main.c:1218 elm_object_part_text_set() safety check failed: obj == NULL
06-01 13:00:31.412+0900 E/EFL     ( 7043): <7043> elm_main.c:1218 elm_object_part_text_set() safety check failed: obj == NULL
06-01 13:00:31.462+0900 D/AUL_PAD ( 3003): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-01 13:00:31.462+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 13:00:31.462+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 13:00:31.462+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 13:00:31.462+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 13:00:31.462+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 13:00:31.462+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 13:00:31.462+0900 I/AUL_PAD ( 3003): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 7043 pgid = 7043
06-01 13:00:31.462+0900 I/AUL_PAD ( 3003): sigchild.h: __sigchild_action(142) > dead_pid(7043)
06-01 13:00:31.472+0900 E/EFL     ( 2741): eo<2741> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 13:00:31.492+0900 W/CRASH_MANAGER( 7208): worker.c: worker_job(1204) > 1107043657861149628963
