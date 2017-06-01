S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 10906
Date: 2017-06-01 21:17:10+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb37ed290, esi = 0x8000aa56
ebp = 0xbf9edf08, esp = 0xbf9edeb0
eax = 0xb37ed000, ebx = 0xb73475f0
ecx = 0x00000000, edx = 0x8000341b
eip = 0xb37e88a5

Memory Information
MemTotal:      123 KB
MemFree:        21 KB
Buffers:         8 KB
Cached:     191848 KB
VmPeak:     100460 KB
VmSize:     100460 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21968 KB
VmRSS:       21968 KB
VmData:      32904 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34464 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 10906 TID = 10906
10906 10915 11106 11107 

Maps Information
b2ba9000 b2bb3000 r-xp /usr/lib/libfeedback.so.0.1.4
b2bb9000 b2bc5000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2bc6000 b2be7000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2bec000 b2bed000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2bee000 b2bf3000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2bf4000 b2bf6000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2bf7000 b2bf9000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2bfa000 b2c06000 r-xp /usr/lib/libdrm.so.2.4.0
b2c07000 b2c0a000 r-xp /usr/lib/libdri2.so.0.0.0
b2c0b000 b2c15000 r-xp /usr/lib/libtbm.so.1.0.0
b2c16000 b2c2b000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c2c000 b2c3e000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3440000 b3471000 r-xp /usr/lib/libidn.so.11.5.44
b3472000 b3494000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3495000 b34a5000 r-xp /usr/lib/libcares.so.2.1.0
b34a6000 b34af000 r-xp /usr/lib/libeventsystem.so.0.0.1
b34b0000 b34b9000 r-xp /usr/lib/libefl-extension.so.0.1.0
b34ba000 b3531000 r-xp /usr/lib/libcurl.so.4.3.0
b3533000 b3545000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3546000 b3567000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b356e000 b356f000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3570000 b3571000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3572000 b3575000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3576000 b3579000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3681000 b3687000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3688000 b37cc000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37dc000 b37dd000 r-xp /usr/lib/libxshmfence.so.1.0.0
b37de000 b37df000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37e0000 b37ec000 r-xp /opt/usr/apps/org.example.example/bin/example
b37ee000 b3827000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b422a000 b4235000 r-xp /lib/libnss_files-2.20-2014.11.so
b4237000 b4242000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4244000 b425b000 r-xp /lib/libnsl-2.20-2014.11.so
b425f000 b4267000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4269000 b428d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b428e000 b428f000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4290000 b4293000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4294000 b429b000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b429c000 b42a6000 r-xp /usr/lib/libsensord-share.so
b42a7000 b42c3000 r-xp /usr/lib/libsensor.so.1.2.0
b42c5000 b42ce000 r-xp /usr/lib/libappcore-common.so.1.1
b42d1000 b42d3000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42e8000 b42ea000 r-xp /usr/lib/libXau.so.6.0.0
b42eb000 b430d000 r-xp /usr/lib/libxcb.so.1.1.0
b430f000 b4318000 r-xp /lib/libcrypt-2.20-2014.11.so
b4341000 b4343000 r-xp /usr/lib/libiri.so
b4344000 b436a000 r-xp /lib/libexpat.so.1.5.2
b436c000 b43d7000 r-xp /usr/lib/libssl.so.1.0.0
b43dd000 b43e9000 r-xp /usr/lib/libethumb.so.1.13.0
b43ea000 b43ee000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43ef000 b4640000 r-xp /usr/lib/libcrypto.so.1.0.0
b5bbb000 b5bcb000 r-xp /usr/lib/libXi.so.6.1.0
b5bcc000 b5bce000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bcf000 b5bd5000 r-xp /usr/lib/libXtst.so.6.1.0
b5bd6000 b5be0000 r-xp /usr/lib/libXrender.so.1.3.0
b5be1000 b5bea000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bec000 b5bee000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bef000 b5bf4000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bf5000 b5c07000 r-xp /usr/lib/libXext.so.6.4.0
b5c08000 b5c0a000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c0b000 b5c0d000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c0f000 b5d51000 r-xp /usr/lib/libX11.so.6.3.0
b5d55000 b5d5f000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d60000 b5d76000 r-xp /usr/lib/libudev.so.1.6.0
b5d79000 b5d7d000 r-xp /lib/libattr.so.1.1.0
b5d7e000 b5dad000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5daf000 b5db5000 r-xp /usr/lib/libffi.so.6.0.2
b5db6000 b5dd9000 r-xp /lib/libz.so.1.2.8
b5dda000 b5ddd000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5dde000 b5f3a000 r-xp /usr/lib/libxml2.so.2.9.2
b5f40000 b6027000 r-xp /usr/lib/libstdc++.so.6.0.20
b6034000 b6037000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6038000 b605a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b605b000 b606f000 r-xp /lib/libresolv-2.20-2014.11.so
b6073000 b6097000 r-xp /usr/lib/liblzma.so.5.0.3
b6098000 b609a000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b609c000 b60a6000 r-xp /usr/lib/libembryo.so.1.13.0
b60a7000 b60d0000 r-xp /usr/lib/libpng12.so.0.50.0
b60d1000 b611a000 r-xp /usr/lib/libjpeg.so.8.0.2
b612b000 b6132000 r-xp /lib/librt-2.20-2014.11.so
b6134000 b6153000 r-xp /usr/lib/libector.so.1.13.0
b6156000 b6183000 r-xp /usr/lib/liblua-5.1.so
b6184000 b6214000 r-xp /usr/lib/libfreetype.so.6.11.3
b6218000 b6256000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6257000 b626d000 r-xp /usr/lib/libfribidi.so.0.3.1
b626e000 b62c7000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62ca000 b6315000 r-xp /lib/libm-2.20-2014.11.so
b6317000 b6329000 r-xp /usr/lib/libeio.so.1.13.0
b632a000 b632d000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b632e000 b6334000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6335000 b6358000 r-xp /usr/lib/libefreet.so.1.13.0
b635b000 b6386000 r-xp /usr/lib/libeldbus.so.1.13.0
b6387000 b63bb000 r-xp /usr/lib/libecore_con.so.1.13.0
b63bd000 b63c6000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63c7000 b63d0000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63d1000 b63e4000 r-xp /usr/lib/libeo.so.1.13.0
b63e6000 b63f9000 r-xp /usr/lib/libecore_input.so.1.13.0
b63fa000 b6401000 r-xp /usr/lib/libecore_file.so.1.13.0
b6402000 b6425000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6426000 b6452000 r-xp /usr/lib/libeet.so.1.13.0
b645b000 b64c6000 r-xp /usr/lib/libeina.so.1.13.0
b64c9000 b64e0000 r-xp /usr/lib/libefl.so.1.13.0
b64e2000 b6649000 r-xp /usr/lib/libicuuc.so.51.1
b6657000 b6863000 r-xp /usr/lib/libicui18n.so.51.1
b686b000 b68ba000 r-xp /usr/lib/libecore_x.so.1.13.0
b68bc000 b68d6000 r-xp /lib/libgcc_s-4.9.so.1
b68d8000 b68dc000 r-xp /lib/libcap.so.2.21
b68dd000 b6923000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6924000 b692b000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b692d000 b697f000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6981000 b6b0c000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b11000 b6bdf000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6be2000 b6be6000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6be7000 b6bf6000 r-xp /usr/lib/libvconf.so.0.2.45
b6bf7000 b6bfa000 r-xp /usr/lib/libvasum.so.0.3.1
b6bfb000 b6bfe000 r-xp /usr/lib/libttrace.so.1.1
b6c00000 b6c04000 r-xp /usr/lib/libiniparser.so.0
b6c05000 b6c35000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c36000 b6c3f000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c40000 b6c65000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c66000 b6c76000 r-xp /usr/lib/libunwind.so.8.0.1
b6c80000 b6e2e000 r-xp /lib/libc-2.20-2014.11.so
b6e36000 b6f79000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f7b000 b6fd3000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fd4000 b7008000 r-xp /usr/lib/libsystemd.so.0.4.0
b700b000 b70df000 r-xp /usr/lib/libedje.so.1.13.0
b70e2000 b710e000 r-xp /usr/lib/libecore.so.1.13.0
b711f000 b7345000 r-xp /usr/lib/libevas.so.1.13.0
b736d000 b7385000 r-xp /lib/libpthread-2.20-2014.11.so
b7389000 b7703000 r-xp /usr/lib/libelementary.so.1.13.0
b7723000 b7727000 r-xp /usr/lib/libsmack.so.1.0.0
b7728000 b7731000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7732000 b7735000 r-xp /usr/lib/libdlog.so.0.0.0
b7736000 b773b000 r-xp /usr/lib/libbundle.so.0.1.22
b773c000 b773f000 r-xp /lib/libdl-2.20-2014.11.so
b7741000 b7766000 r-xp /usr/lib/libaul.so.0.1.0
b7769000 b776b000 r-xp /usr/lib/libappsvc.so.0.1.0
b776c000 b7771000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7772000 b7779000 r-xp /usr/lib/libappcore-efl.so.1.1
b777b000 b7780000 r-xp /usr/lib/libsys-assert.so
b7783000 b7784000 r-xp [vdso]
b7784000 b77a6000 r-xp /lib/ld-2.20-2014.11.so
b77a8000 b77b0000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:10906)
Call Stack Count: 18
 0: setting_view_cb + 0x35 (0xb37e88a5) [/opt/usr/apps/org.example.example/bin/example] + 0x88a5
 1: (0xb7153449) [/usr/lib/libevas.so.1] + 0x34449
 2: (0xb63df319) [/usr/lib/libeo.so.1] + 0xe319
 3: eo_event_callback_call + 0xb3 (0xb63dcd63) [/usr/lib/libeo.so.1] + 0xbd63
 4: (0xb7153a62) [/usr/lib/libevas.so.1] + 0x34a62
 5: (0xb7162441) [/usr/lib/libevas.so.1] + 0x43441
 6: evas_canvas_event_feed_mouse_down + 0xcf (0xb716c20f) [/usr/lib/libevas.so.1] + 0x4d20f
 7: evas_event_feed_mouse_down + 0x6a (0xb7172c2a) [/usr/lib/libevas.so.1] + 0x53c2a
 8: (0xb43ec49c) [/usr/lib/libecore_input_evas.so.1] + 0x249c
 9: (0xb70ef055) [/usr/lib/libecore.so.1] + 0xd055
10: (0xb70f81b9) [/usr/lib/libecore.so.1] + 0x161b9
11: ecore_main_loop_begin + 0x57 (0xb70f8587) [/usr/lib/libecore.so.1] + 0x16587
12: elm_run + 0x2d (0xb755122d) [/usr/lib/libelementary.so.1] + 0x1c822d
13: appcore_efl_main + 0x4de (0xb7775dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
14: ui_app_main + 0x140 (0xb776ec80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
15: main + 0x2e1 (0xb37e79a1) [/opt/usr/apps/org.example.example/bin/example] + 0x79a1
16: (0xb77aa148) [/opt/usr/apps/org.example.example/bin/example] + 0xb77aa148
17: __libc_start_main + 0xde (0xb6c97e4e) [/lib/libc.so.6] + 0x17e4e
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
  [1]th page, updated[1]
06-01 21:17:07.664+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.clockui2] Name[clockui2] Icon[/opt/usr/apps/org.example.clockui2/shared/res/clockui2.png] enable[1] system[0]
06-01 21:17:07.664+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.clockui2'], count[0]
06-01 21:17:07.664+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.clockui2][-17956860][0]
06-01 21:17:07.664+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.clockui2]
06-01 21:17:07.664+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[clockui2] pos[4, 1] pageId[100001]
06-01 21:17:07.664+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[16]
06-01 21:17:07.664+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[4], [4, 1]
06-01 21:17:07.664+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[4], [4, 1]
06-01 21:17:07.664+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:17:07.664+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.contacts] Name[Contacts] Icon[/usr/share/icons/default/small/org.tizen.contacts.png] enable[1] system[1]
06-01 21:17:07.664+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.contacts'], count[0]
06-01 21:17:07.664+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.contacts][-17956860][0]
06-01 21:17:07.664+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.contacts]
06-01 21:17:07.664+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Contacts] pos[1, 2] pageId[100001]
06-01 21:17:07.664+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[4]
06-01 21:17:07.664+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[5], [1, 2]
06-01 21:17:07.664+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[5], [1, 2]
06-01 21:17:07.664+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:17:07.664+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.email] Name[Email] Icon[/usr/apps/org.tizen.email/shared/res/org.tizen.email.png] enable[1] system[1]
06-01 21:17:07.664+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.email'], count[1]
06-01 21:17:07.664+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.email]
06-01 21:17:07.664+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Email] pos[2, 2] pageId[100001]
06-01 21:17:07.664+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[5]
06-01 21:17:07.664+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[6], [2, 2]
06-01 21:17:07.664+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[6], [2, 2]
06-01 21:17:07.664+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:17:07.664+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.emailui] Name[emailui] Icon[/opt/usr/apps/org.example.emailui/shared/res/emailui.png] enable[1] system[0]
06-01 21:17:07.664+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.emailui'], count[0]
06-01 21:17:07.664+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.emailui][-17956860][0]
06-01 21:17:07.664+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.emailui]
06-01 21:17:07.664+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[emailui] pos[3, 2] pageId[100001]
06-01 21:17:07.664+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[15]
06-01 21:17:07.664+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[7], [3, 2]
06-01 21:17:07.664+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[7], [3, 2]
06-01 21:17:07.664+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:17:07.664+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.example] Name[forpet] Icon[/opt/usr/apps/org.example.example/shared/res/1.jpg] enable[1] system[0]
06-01 21:17:07.664+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.example'], count[0]
06-01 21:17:07.664+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.example][-17956860][0]
06-01 21:17:07.664+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.example]
06-01 21:17:07.664+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[forpet] pos[4, 2] pageId[100001]
06-01 21:17:07.664+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[0]
06-01 21:17:07.664+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(787) >  AddBoxToMenuView
06-01 21:17:07.664+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(347) >  AddBox Name[forpet] pageid[100001] pos[4, 2]
06-01 21:17:07.664+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(354) >  menuPage.GetPageId() = 100001, boxPageId = 100001
06-01 21:17:07.664+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: AddBoxToPage(112) >  void ClusterHome3D::Internal::CMainMenuPage::AddBoxToPage(std::shared_ptr<CMainMenuBoxData>) : 112
06-01 21:17:07.664+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: AddBoxToPage(122) >  void ClusterHome3D::Internal::CMainMenuPage::AddBoxToPage(std::shared_ptr<CMainMenuBoxData>) : 122
06-01 21:17:07.664+0900 D/test-log( 2894): mainmenu-page-impl.cpp: AddBoxToPage(123) >  create box[org.example.example] [4,2]
06-01 21:17:07.664+0900 D/test-log( 2894): mainmenu-box-impl.cpp: CMainMenuBox(148) >  create box
06-01 21:17:07.674+0900 D/test-log( 2894): mainmenu-box-impl.cpp: SetPosition(459) >  cut Animation : forpet
06-01 21:17:07.674+0900 D/test-log( 2894): mainmenu-page-impl.cpp: AddBoxToPage(177) >  add created box
06-01 21:17:07.674+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.gallery] Name[Gallery] Icon[/usr/share/icons/default/small/org.tizen.gallery.png] enable[1] system[1]
06-01 21:17:07.674+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.gallery'], count[0]
06-01 21:17:07.674+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.gallery][-17956860][0]
06-01 21:17:07.674+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.gallery]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Gallery] pos[1, 3] pageId[100001]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[6]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[9], [1, 3]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[8], [4, 2]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:17:07.674+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.browser] Name[Internet] Icon[/usr/share/icons/default/small/org.tizen.browser.png] enable[1] system[1]
06-01 21:17:07.674+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.browser'], count[0]
06-01 21:17:07.674+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.browser][-17956860][0]
06-01 21:17:07.674+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.browser]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Internet] pos[2, 3] pageId[100001]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[1]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[10], [2, 3]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:17:07.674+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.message] Name[Messages] Icon[/usr/share/icons/default/small/org.tizen.message.png] enable[1] system[1]
06-01 21:17:07.674+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.message'], count[1]
06-01 21:17:07.674+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.message]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Messages] pos[3, 3] pageId[100001]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[7]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[11], [3, 3]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:17:07.674+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.music-player] Name[Music] Icon[/usr/share/icons/default/small/org.tizen.music-player.png] enable[1] system[1]
06-01 21:17:07.674+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.music-player'], count[0]
06-01 21:17:07.674+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.music-player][-17956860][0]
06-01 21:17:07.674+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.music-player]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Music] pos[4, 3] pageId[100001]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[8]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[12], [4, 3]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:17:07.674+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.myfile] Name[My Files] Icon[/usr/share/icons/default/small/org.tizen.myfile.png] enable[1] system[1]
06-01 21:17:07.674+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.myfile'], count[0]
06-01 21:17:07.674+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.myfile][-17956860][0]
06-01 21:17:07.674+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.myfile]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[My Files] pos[1, 4] pageId[100001]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[9]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[13], [1, 4]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:17:07.674+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.phone] Name[Phone] Icon[/usr/share/icons/default/small/org.tizen.phone.png] enable[1] system[1]
06-01 21:17:07.674+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.phone'], count[0]
06-01 21:17:07.674+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.phone][-17956860][0]
06-01 21:17:07.674+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.phone]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Phone] pos[2, 4] pageId[100001]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[10]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[14], [2, 4]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:17:07.674+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.setting] Name[Settings] Icon[/usr/share/icons/default/small/org.tizen.setting.png] enable[1] system[1]
06-01 21:17:07.674+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.setting'], count[0]
06-01 21:17:07.674+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.setting][-17956860][0]
06-01 21:17:07.674+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.setting]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Settings] pos[3, 4] pageId[100001]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[11]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[15], [3, 4]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:17:07.674+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.uibuildernavigationview] Name[uibuildernavigationview] Icon[/opt/usr/apps/org.example.uibuildernavigationview/shared/res/uibuildernavigationview.png] enable[1] system[0]
06-01 21:17:07.674+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.uibuildernavigationview'], count[0]
06-01 21:17:07.674+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.uibuildernavigationview][-17956860][0]
06-01 21:17:07.674+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.uibuildernavigationview]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[uibuildernavigationview] pos[4, 4] pageId[100001]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[14]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[16], [4, 4]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:17:07.674+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.videos] Name[Video] Icon[/usr/share/icons/default/small/org.tizen.videos.png] enable[1] system[1]
06-01 21:17:07.674+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.videos'], count[0]
06-01 21:17:07.674+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.videos][-17956860][0]
06-01 21:17:07.674+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.videos]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Video] pos[1, 5] pageId[100001]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[12]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[17], [1, 5]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:17:07.674+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: RearrangeItems(243) >  view type [1]
06-01 21:17:07.804+0900 D/rpm-installer(11048): rpm-appcore-intf.c: main(238) > sync() end
06-01 21:17:08.064+0900 D/rpm-installer(11048): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
06-01 21:17:08.064+0900 D/rpm-installer(11048): rpm-appcore-intf.c: main(259) > ------------------------------------------------
06-01 21:17:08.064+0900 D/rpm-installer(11048): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
06-01 21:17:08.064+0900 D/rpm-installer(11048): rpm-appcore-intf.c: main(261) > ------------------------------------------------
06-01 21:17:08.064+0900 D/PKGMGR_SERVER(11034): pkgmgr-server.c: sighandler(387) > child exit [11048]
06-01 21:17:08.064+0900 E/PKGMGR_SERVER(11034): pkgmgr-server.c: sighandler(402) > child NORMAL exit [11048]
06-01 21:17:08.684+0900 D/AUL_AMD ( 2787): amd_request.c: __request_handler(838) > __request_handler: 0
06-01 21:17:08.684+0900 D/AUL_AMD ( 2787): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-01 21:17:08.684+0900 D/PKGMGR_INFO( 2787): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 21:17:08.684+0900 D/PKGMGR_INFO( 2787): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 21:17:08.684+0900 I/AUL     ( 2787): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
06-01 21:17:08.684+0900 D/AUL     ( 2787): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 11100, pid = 11102
06-01 21:17:08.684+0900 D/PKGMGR_INFO( 2787): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 21:17:08.684+0900 D/PKGMGR_INFO( 2787): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 21:17:08.684+0900 I/AUL     ( 2787): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
06-01 21:17:08.684+0900 E/AUL_AMD ( 2787): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-01 21:17:08.684+0900 W/AUL_AMD ( 2787): amd_launch.c: _start_app(2233) > caller pid : 11102
06-01 21:17:08.684+0900 E/AUL_AMD ( 2787): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-01 21:17:08.684+0900 W/AUL_AMD ( 2787): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-01 21:17:08.684+0900 D/AUL_AMD ( 2787): amd_launch.c: _start_app(2648) > process_pool: false
06-01 21:17:08.684+0900 D/AUL_AMD ( 2787): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-01 21:17:08.684+0900 D/AUL_AMD ( 2787): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-01 21:17:08.684+0900 W/AUL_AMD ( 2787): amd_launch.c: _start_app(2665) > pad pid(-5)
06-01 21:17:08.684+0900 D/AUL_AMD ( 2787): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-01 21:17:08.684+0900 D/AUL_AMD ( 2787): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-01 21:17:08.684+0900 D/AUL     ( 2787): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-01 21:17:08.694+0900 D/AUL_PAD ( 2943): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-01 21:17:08.694+0900 D/AUL_PAD ( 2943): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 21:17:08.694+0900 D/AUL_PAD ( 2943): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 21:17:08.694+0900 D/AUL_PAD ( 2943): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 21:17:08.694+0900 D/AUL_PAD ( 2943): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 21:17:08.694+0900 D/AUL_PAD ( 2943): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 21:17:08.694+0900 D/AUL_PAD ( 2943): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 21:17:08.694+0900 D/AUL_PAD ( 2943): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-01 21:17:08.694+0900 D/AUL_PAD ( 2943): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-01 21:17:08.694+0900 D/AUL_PAD ( 2943): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-01 21:17:08.694+0900 D/AUL_PAD ( 2943): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-01 21:17:08.694+0900 D/AUL_PAD ( 2943): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-01 21:17:08.694+0900 D/AUL_PAD ( 2943): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-01 21:17:08.694+0900 D/AUL_PAD ( 2943): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-01 21:17:08.694+0900 W/AUL_PAD ( 2943): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-01 21:17:08.694+0900 D/AUL     ( 2943): process_pool.c: __send_pkt_raw_data(219) > send(12) : 624 / 624
06-01 21:17:08.694+0900 D/AUL_PAD ( 2943): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 10906, bin path: /opt/usr/apps/org.example.example/bin/example
06-01 21:17:08.694+0900 W/AUL_PAD ( 2943): launchpad.c: __send_result_to_caller(265) > Check app launching
06-01 21:17:08.694+0900 D/AUL_PAD ( 2943): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-01 21:17:08.694+0900 D/AUL_PAD (10906): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-01 21:17:08.694+0900 D/AUL_PAD (10906): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
06-01 21:17:08.694+0900 D/AUL_PAD (10906): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-01 21:17:08.694+0900 D/AUL_PAD (10906): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-01 21:17:08.694+0900 D/AUL_PAD (10906): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-01 21:17:08.694+0900 D/AUL_PAD (10906): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-01 21:17:08.694+0900 D/AUL     (10906): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (10915) is sent.
06-01 21:17:08.694+0900 D/RESOURCED( 2881): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-01 21:17:08.694+0900 D/RESOURCED( 2881): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-01 21:17:08.694+0900 D/AUL     (10906): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 10915, signo: 10
06-01 21:17:08.694+0900 E/RESOURCED( 2881): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-01 21:17:08.694+0900 D/AUL     (10906): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-01 21:17:08.694+0900 D/AUL_PAD (10906): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-01 21:17:08.694+0900 D/AUL_PAD (10906): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-01 21:17:08.694+0900 D/AUL_PAD (10906): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-01 21:17:08.694+0900 D/AUL_PAD (10906): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-01 21:17:08.694+0900 D/AUL_PAD (10906): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTYzMTk0MjgvNjkyODg4AA==##
06-01 21:17:08.694+0900 D/AUL_PAD (10906): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-01 21:17:08.694+0900 D/AUL_PAD (10906): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAxMTEwMgA=##
06-01 21:17:08.694+0900 D/AUL_PAD (10906): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-01 21:17:08.694+0900 D/AUL_PAD (10906): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-01 21:17:08.694+0900 D/AUL_PAD (10906): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-01 21:17:08.694+0900 D/AUL_PAD (10906): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-01 21:17:08.694+0900 D/AUL_PAD (10906): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-01 21:17:08.694+0900 I/CAPI_APPFW_APPLICATION(10906): app_main.c: ui_app_main(788) > app_efl_main
06-01 21:17:08.694+0900 D/LAUNCH  (10906): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-01 21:17:08.694+0900 D/APP_CORE(10906): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-01 21:17:08.694+0900 D/APP_CORE(10906): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-01 21:17:08.694+0900 D/APP_CORE(10906): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-01 21:17:08.714+0900 D/APP_CORE(10906): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-01 21:17:08.714+0900 D/AUL     (10906): app_sock.c: __create_server_sock(156) > pg path - already exists
06-01 21:17:08.714+0900 D/APP_CORE(10906): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42ce520
06-01 21:17:08.714+0900 D/LAUNCH  (10906): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-01 21:17:08.714+0900 I/CAPI_APPFW_APPLICATION(10906): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-01 21:17:08.794+0900 D/AUL_PAD ( 2943): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-01 21:17:08.794+0900 W/AUL     ( 2787): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 10906, appid: org.example.example
06-01 21:17:08.794+0900 D/AUL     ( 2787): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-01 21:17:08.794+0900 E/AUL     ( 2787): simple_util.c: __trm_app_info_send_socket(330) > access
06-01 21:17:08.794+0900 D/AUL_AMD ( 2787): amd_launch.c: _start_app(2700) > add app group info
06-01 21:17:08.794+0900 E/AUL     ( 2787): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-01 21:17:08.794+0900 D/AUL_AMD ( 2787): amd_status.c: _status_add_app_info_list(427) > pid(10906) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-01 21:17:08.794+0900 D/RESOURCED( 2881): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 10906
06-01 21:17:08.794+0900 D/RESOURCED( 2881): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-01 21:17:08.794+0900 E/RESOURCED( 2881): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-01 21:17:08.794+0900 D/RESOURCED( 2881): proc-main.c: resourced_proc_status_change(888) > available memory = 314
06-01 21:17:08.834+0900 D/LAUNCH  (10906): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
06-01 21:17:08.834+0900 D/APP_CORE(10906): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-01 21:17:08.834+0900 E/E17     ( 2736): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x01200002)
06-01 21:17:08.884+0900 E/E17     ( 2736): e_border.c: e_border_show(2088) > BD_SHOW(0x01200002)
06-01 21:17:08.894+0900 D/APP_CORE(10906): appcore.c: __aul_handler(587) > [APP 10906]     AUL event: AUL_START
06-01 21:17:08.894+0900 I/APP_CORE(10906): appcore-efl.c: __do_app(496) > [APP 10906] Event: RESET State: CREATED
06-01 21:17:08.894+0900 D/APP_CORE(10906): appcore-efl.c: __do_app(527) > [APP 10906] RESET
06-01 21:17:08.894+0900 D/LAUNCH  (10906): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
06-01 21:17:08.894+0900 D/APP_CORE(10906): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-01 21:17:08.894+0900 D/APP_CORE(10906): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-01 21:17:08.894+0900 I/CAPI_APPFW_APPLICATION(10906): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-01 21:17:08.894+0900 D/AUL     (10906): service.c: __set_bundle(186) > __set_bundle
06-01 21:17:08.894+0900 D/LAUNCH  (10906): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-01 21:17:08.894+0900 D/APP_CORE(10906): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-01 21:17:08.894+0900 E/EFL     (10906): edje<10906> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 21:17:08.894+0900 E/EFL     (10906): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 21:17:08.894+0900 E/EFL     (10906): edje<10906> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 21:17:08.894+0900 E/EFL     (10906): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 21:17:08.894+0900 E/EFL     (10906): edje<10906> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 21:17:08.894+0900 E/EFL     (10906): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 21:17:08.894+0900 E/EFL     (10906): edje<10906> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 21:17:08.894+0900 E/EFL     (10906): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 21:17:08.894+0900 E/EFL     (10906): edje<10906> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 21:17:08.894+0900 E/EFL     (10906): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 21:17:08.904+0900 W/APP_CORE(10906): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1200002
06-01 21:17:08.904+0900 D/APP_CORE(10906): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:1200002
06-01 21:17:08.904+0900 D/APP_CORE(10906): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-01 21:17:08.904+0900 D/AUL     (10906): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-01 21:17:08.904+0900 D/AUL_AMD ( 2787): amd_request.c: __request_handler(838) > __request_handler: 34
06-01 21:17:08.924+0900 W/PROCESSMGR( 2736): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=10906
06-01 21:17:08.944+0900 E/EFL     ( 2736): eo<2736> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 21:17:08.944+0900 E/EFL     ( 2736): eo<2736> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 21:17:08.954+0900 D/INDICATOR( 2886): main.c: _property_changed_cb(432) > UNSNIFF API 1800002
06-01 21:17:08.954+0900 D/INDICATOR( 2886): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-01 21:17:08.964+0900 D/INDICATOR( 2886): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-01 21:17:08.964+0900 D/INDICATOR( 2886): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-01 21:17:08.964+0900 D/INDICATOR( 2886): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-01 21:17:08.964+0900 D/INDICATOR( 2886): main.c: _rotate_window(252) > port :: hide more icon
06-01 21:17:08.964+0900 D/AUL_AMD ( 2787): amd_request.c: __request_handler(838) > __request_handler: 15
06-01 21:17:08.964+0900 D/PKGMGR_INFO( 2787): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 21:17:08.964+0900 D/PKGMGR_INFO( 2787): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 21:17:08.964+0900 D/AUL_AMD ( 2787): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 10906 is org.example.example
06-01 21:17:08.964+0900 D/AUL_AMD ( 2787): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 10906 : 0
06-01 21:17:08.964+0900 D/AUL     ( 2961): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-01 21:17:08.994+0900 E/PKGMGR_SERVER(11034): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-01 21:17:08.994+0900 E/PKGMGR_SERVER(11034): pkgmgr-server.c: main(2265) > package manager server terminated.
06-01 21:17:09.194+0900 D/APP_CORE(10906): appcore.c: __prt_ltime(236) > [APP 10906] first idle after reset: 516 msec
06-01 21:17:09.284+0900 E/E17     ( 2736): e_border.c: e_border_hide(2248) > BD_HIDE(0x01800002), visible:1
06-01 21:17:09.284+0900 D/APP_CORE( 2894): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1800002 fully_obscured 1
06-01 21:17:09.284+0900 D/APP_CORE( 2894): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-01 21:17:09.284+0900 D/APP_CORE( 2894): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-01 21:17:09.284+0900 I/APP_CORE( 2894): appcore-efl.c: __do_app(496) > [APP 2894] Event: PAUSE State: RUNNING
06-01 21:17:09.284+0900 D/APP_CORE( 2894): appcore-efl.c: __do_app(565) > [APP 2894] PAUSE
06-01 21:17:09.284+0900 I/CAPI_APPFW_APPLICATION( 2894): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-01 21:17:09.284+0900 E/cluster-home( 2894): homescreen.cpp: OnPause(84) >  app pause
06-01 21:17:09.284+0900 D/cluster-view( 2894): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-01 21:17:09.284+0900 D/cluster-view( 2894): homescreen-view-manager.cpp: AppPause(923) >  END
06-01 21:17:09.284+0900 D/APP_CORE( 2894): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-01 21:17:09.284+0900 E/APP_CORE( 2894): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-01 21:17:09.304+0900 D/AUL_AMD ( 2787): amd_status.c: _status_update_app_info_list(456) > pid(2894) status(4)
06-01 21:17:09.304+0900 D/AUL_AMD ( 2787): amd_status.c: _status_update_app_info_list(468) > pid(2894) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-01 21:17:09.304+0900 D/AUL     ( 2787): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-01 21:17:09.304+0900 W/AUL     ( 2787): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2894, appid: org.tizen.homescreen, status: bg
06-01 21:17:09.304+0900 D/DATA_PROVIDER_MASTER( 2950): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2894 is paused
06-01 21:17:09.304+0900 D/DATA_PROVIDER_MASTER( 2950): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-01 21:17:09.304+0900 D/AUL_AMD ( 2787): amd_launch.c: __e17_status_handler(2891) > pid(10906) status(3)
06-01 21:17:09.304+0900 D/AUL_AMD ( 2787): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-01 21:17:09.314+0900 I/CAPI_WIDGET_APPLICATION( 3024): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-01 21:17:09.314+0900 I/CAPI_WIDGET_APPLICATION( 3024): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-01 21:17:09.314+0900 W/AUL     ( 3024): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3024, appid: org.tizen.calendar.widget, status: bg
06-01 21:17:09.314+0900 W/AUL_AMD ( 2787): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-01 21:17:09.314+0900 W/AUL_AMD ( 2787): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-01 21:17:09.314+0900 D/AUL_AMD ( 2787): amd_status.c: _status_update_app_info_list(456) > pid(10906) status(3)
06-01 21:17:09.314+0900 D/AUL_AMD ( 2787): amd_status.c: _status_update_app_info_list(468) > pid(10906) appid(org.example.example) pkgid(org.example.example) status(3)
06-01 21:17:09.314+0900 D/AUL     ( 2787): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-01 21:17:09.314+0900 W/AUL     ( 2787): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 10906, appid: org.example.example, status: fg
06-01 21:17:09.314+0900 D/RESOURCED( 2881): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3024, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-01 21:17:09.314+0900 D/RESOURCED( 2881): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3024
06-01 21:17:09.314+0900 D/RESOURCED( 2881): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3024, appname = org.tizen.calendar.widget
06-01 21:17:09.314+0900 D/RESOURCED( 2881): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3024
06-01 21:17:09.314+0900 D/RESOURCED( 2881): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 10906
06-01 21:17:09.314+0900 D/RESOURCED( 2881): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 10906, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-01 21:17:09.314+0900 D/RESOURCED( 2881): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 10906
06-01 21:17:09.374+0900 D/APP_CORE(10906): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1200002 fully_obscured 0
06-01 21:17:09.374+0900 D/APP_CORE(10906): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-01 21:17:09.374+0900 D/APP_CORE(10906): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-01 21:17:09.374+0900 I/APP_CORE(10906): appcore-efl.c: __do_app(496) > [APP 10906] Event: RESUME State: CREATED
06-01 21:17:09.374+0900 D/LAUNCH  (10906): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-01 21:17:09.374+0900 D/APP_CORE(10906): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-01 21:17:09.374+0900 D/APP_CORE(10906): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-01 21:17:09.374+0900 D/APP_CORE(10906): appcore-efl.c: __do_app(607) > [APP 10906] RESUME
06-01 21:17:09.374+0900 I/APP_CORE(10906): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-01 21:17:09.374+0900 I/APP_CORE(10906): appcore-efl.c: __do_app(614) > [APP 10906] Initial Launching, call the resume_cb
06-01 21:17:09.374+0900 I/CAPI_APPFW_APPLICATION(10906): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-01 21:17:09.374+0900 D/LAUNCH  (10906): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-01 21:17:09.374+0900 D/LAUNCH  (10906): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-01 21:17:09.374+0900 D/APP_CORE(10906): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-01 21:17:09.374+0900 E/APP_CORE(10906): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-01 21:17:09.374+0900 D/RESOURCED( 2881): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 10906, appname = org.example.example, pkgname = org.example.example
06-01 21:17:09.374+0900 D/RESOURCED( 2881): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 10906, appname = org.example.example
06-01 21:17:09.374+0900 D/RESOURCED( 2881): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 10906
06-01 21:17:09.384+0900 I/RESOURCED( 2881): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-01 21:17:09.384+0900 I/RESOURCED( 2881): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-01 21:17:09.554+0900 D/AUL_AMD ( 2787): amd_launch.c: __e17_status_handler(2910) > pid(10906) status(0)
06-01 21:17:09.794+0900 D/AUL_PAD ( 2943): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-01 21:17:09.794+0900 D/AUL_PAD (11110): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-01 21:17:09.804+0900 D/AUL_PAD ( 2943): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-01 21:17:09.814+0900 E/RESOURCED( 2881): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.914
06-01 21:17:10.184+0900 E/EFL     ( 2736): eo<2736> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 21:17:10.184+0900 D/AUL_PAD ( 2943): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-01 21:17:10.184+0900 D/AUL_PAD ( 2943): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 21:17:10.184+0900 D/AUL_PAD ( 2943): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 21:17:10.184+0900 D/AUL_PAD ( 2943): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 21:17:10.184+0900 D/AUL_PAD ( 2943): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 21:17:10.184+0900 D/AUL_PAD ( 2943): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 21:17:10.184+0900 D/AUL_PAD ( 2943): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 21:17:10.184+0900 I/AUL_PAD ( 2943): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 10906 pgid = 10906
06-01 21:17:10.184+0900 I/AUL_PAD ( 2943): sigchild.h: __sigchild_action(142) > dead_pid(10906)
06-01 21:17:10.194+0900 W/CRASH_MANAGER(11111): worker.c: worker_job(1204) > 1110906657861149631943
