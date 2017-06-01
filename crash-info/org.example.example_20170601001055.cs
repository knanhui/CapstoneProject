S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 5542
Date: 2017-06-01 00:10:55+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x1c

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x0000001c, esi = 0xb3833c61
ebp = 0xbf8b1918, esp = 0xbf8b18b0
eax = 0xb8960a48, ebx = 0xb6c290d4
ecx = 0xb8960a48, edx = 0x0000001c
eip = 0xb6c071f6

Memory Information
MemTotal:      123 KB
MemFree:        27 KB
Buffers:         4 KB
Cached:     170824 KB
VmPeak:     100436 KB
VmSize:     100436 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22192 KB
VmRSS:       22192 KB
VmData:      32884 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34460 KB
VmPTE:          76 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 5542 TID = 5542
5542 5543 5744 5745 

Maps Information
b2bf3000 b2bfd000 r-xp /usr/lib/libfeedback.so.0.1.4
b2c03000 b2c0f000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2c10000 b2c31000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2c36000 b2c37000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2c38000 b2c3d000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2c3e000 b2c3f000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2c40000 b2c42000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c43000 b2c4f000 r-xp /usr/lib/libdrm.so.2.4.0
b2c50000 b2c53000 r-xp /usr/lib/libdri2.so.0.0.0
b2c54000 b2c5e000 r-xp /usr/lib/libtbm.so.1.0.0
b2c5f000 b2c74000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c75000 b2c87000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3489000 b34ba000 r-xp /usr/lib/libidn.so.11.5.44
b34bb000 b34dd000 r-xp /usr/lib/libnghttp2.so.5.4.0
b34de000 b34ee000 r-xp /usr/lib/libcares.so.2.1.0
b34ef000 b34f8000 r-xp /usr/lib/libeventsystem.so.0.0.1
b34f9000 b3502000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3503000 b357a000 r-xp /usr/lib/libcurl.so.4.3.0
b357c000 b358e000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b358f000 b35b0000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b35b7000 b35b8000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b35b9000 b35ba000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b35bb000 b35be000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b35bf000 b35c2000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b36ca000 b36d0000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b36d1000 b3815000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3825000 b3827000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b3828000 b3829000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b382a000 b3835000 r-xp /opt/usr/apps/org.example.example/bin/example
b3837000 b3870000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4273000 b427e000 r-xp /lib/libnss_files-2.20-2014.11.so
b4280000 b428b000 r-xp /lib/libnss_nis-2.20-2014.11.so
b428d000 b42a4000 r-xp /lib/libnsl-2.20-2014.11.so
b42a8000 b42b0000 r-xp /lib/libnss_compat-2.20-2014.11.so
b42b2000 b42d6000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b42d7000 b42d8000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b42d9000 b42dc000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42dd000 b42e4000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42e5000 b42ef000 r-xp /usr/lib/libsensord-share.so
b42f0000 b430c000 r-xp /usr/lib/libsensor.so.1.2.0
b430e000 b4317000 r-xp /usr/lib/libappcore-common.so.1.1
b431a000 b431c000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4331000 b4333000 r-xp /usr/lib/libXau.so.6.0.0
b4334000 b4356000 r-xp /usr/lib/libxcb.so.1.1.0
b4358000 b4361000 r-xp /lib/libcrypt-2.20-2014.11.so
b438a000 b438c000 r-xp /usr/lib/libiri.so
b438d000 b43b3000 r-xp /lib/libexpat.so.1.5.2
b43b5000 b4420000 r-xp /usr/lib/libssl.so.1.0.0
b4426000 b4432000 r-xp /usr/lib/libethumb.so.1.13.0
b4433000 b4437000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4438000 b4689000 r-xp /usr/lib/libcrypto.so.1.0.0
b5c04000 b5c14000 r-xp /usr/lib/libXi.so.6.1.0
b5c15000 b5c17000 r-xp /usr/lib/libXgesture.so.7.0.0
b5c18000 b5c1e000 r-xp /usr/lib/libXtst.so.6.1.0
b5c1f000 b5c29000 r-xp /usr/lib/libXrender.so.1.3.0
b5c2a000 b5c33000 r-xp /usr/lib/libXrandr.so.2.2.0
b5c35000 b5c37000 r-xp /usr/lib/libXinerama.so.1.0.0
b5c38000 b5c3d000 r-xp /usr/lib/libXfixes.so.3.1.0
b5c3e000 b5c50000 r-xp /usr/lib/libXext.so.6.4.0
b5c51000 b5c53000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c54000 b5c56000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c58000 b5d9a000 r-xp /usr/lib/libX11.so.6.3.0
b5d9e000 b5da8000 r-xp /usr/lib/libXcursor.so.1.0.2
b5da9000 b5dbf000 r-xp /usr/lib/libudev.so.1.6.0
b5dc2000 b5dc6000 r-xp /lib/libattr.so.1.1.0
b5dc7000 b5df6000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5df8000 b5dfe000 r-xp /usr/lib/libffi.so.6.0.2
b5dff000 b5e22000 r-xp /lib/libz.so.1.2.8
b5e23000 b5e26000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5e27000 b5f83000 r-xp /usr/lib/libxml2.so.2.9.2
b5f89000 b6070000 r-xp /usr/lib/libstdc++.so.6.0.20
b607d000 b6080000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6081000 b60a3000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b60a4000 b60b8000 r-xp /lib/libresolv-2.20-2014.11.so
b60bc000 b60e0000 r-xp /usr/lib/liblzma.so.5.0.3
b60e1000 b60e3000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b60e5000 b60ef000 r-xp /usr/lib/libembryo.so.1.13.0
b60f0000 b6119000 r-xp /usr/lib/libpng12.so.0.50.0
b611a000 b6163000 r-xp /usr/lib/libjpeg.so.8.0.2
b6174000 b617b000 r-xp /lib/librt-2.20-2014.11.so
b617d000 b619c000 r-xp /usr/lib/libector.so.1.13.0
b619f000 b61cc000 r-xp /usr/lib/liblua-5.1.so
b61cd000 b625d000 r-xp /usr/lib/libfreetype.so.6.11.3
b6261000 b629f000 r-xp /usr/lib/libfontconfig.so.1.8.0
b62a0000 b62b6000 r-xp /usr/lib/libfribidi.so.0.3.1
b62b7000 b6310000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6313000 b635e000 r-xp /lib/libm-2.20-2014.11.so
b6360000 b6372000 r-xp /usr/lib/libeio.so.1.13.0
b6373000 b6376000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6377000 b637d000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b637e000 b63a1000 r-xp /usr/lib/libefreet.so.1.13.0
b63a4000 b63cf000 r-xp /usr/lib/libeldbus.so.1.13.0
b63d0000 b6404000 r-xp /usr/lib/libecore_con.so.1.13.0
b6406000 b640f000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6410000 b6419000 r-xp /usr/lib/libethumb_client.so.1.13.0
b641a000 b642d000 r-xp /usr/lib/libeo.so.1.13.0
b642f000 b6442000 r-xp /usr/lib/libecore_input.so.1.13.0
b6443000 b644a000 r-xp /usr/lib/libecore_file.so.1.13.0
b644b000 b646e000 r-xp /usr/lib/libecore_evas.so.1.13.0
b646f000 b649b000 r-xp /usr/lib/libeet.so.1.13.0
b64a4000 b650f000 r-xp /usr/lib/libeina.so.1.13.0
b6512000 b6529000 r-xp /usr/lib/libefl.so.1.13.0
b652b000 b6692000 r-xp /usr/lib/libicuuc.so.51.1
b66a0000 b68ac000 r-xp /usr/lib/libicui18n.so.51.1
b68b4000 b6903000 r-xp /usr/lib/libecore_x.so.1.13.0
b6905000 b691f000 r-xp /lib/libgcc_s-4.9.so.1
b6921000 b6925000 r-xp /lib/libcap.so.2.21
b6926000 b696c000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b696d000 b6974000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6976000 b69c8000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b69ca000 b6b55000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b5a000 b6c28000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6c2b000 b6c2f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6c30000 b6c3f000 r-xp /usr/lib/libvconf.so.0.2.45
b6c40000 b6c43000 r-xp /usr/lib/libvasum.so.0.3.1
b6c44000 b6c47000 r-xp /usr/lib/libttrace.so.1.1
b6c49000 b6c4d000 r-xp /usr/lib/libiniparser.so.0
b6c4e000 b6c7e000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c7f000 b6c88000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c89000 b6cae000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6caf000 b6cbf000 r-xp /usr/lib/libunwind.so.8.0.1
b6cc9000 b6e77000 r-xp /lib/libc-2.20-2014.11.so
b6e7f000 b6fc2000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6fc4000 b701c000 r-xp /usr/lib/libdbus-1.so.3.8.11
b701d000 b7051000 r-xp /usr/lib/libsystemd.so.0.4.0
b7054000 b7128000 r-xp /usr/lib/libedje.so.1.13.0
b712b000 b7157000 r-xp /usr/lib/libecore.so.1.13.0
b7168000 b738e000 r-xp /usr/lib/libevas.so.1.13.0
b73b6000 b73ce000 r-xp /lib/libpthread-2.20-2014.11.so
b73d2000 b774c000 r-xp /usr/lib/libelementary.so.1.13.0
b776c000 b7770000 r-xp /usr/lib/libsmack.so.1.0.0
b7771000 b777a000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b777b000 b777e000 r-xp /usr/lib/libdlog.so.0.0.0
b777f000 b7784000 r-xp /usr/lib/libbundle.so.0.1.22
b7785000 b7788000 r-xp /lib/libdl-2.20-2014.11.so
b778a000 b77af000 r-xp /usr/lib/libaul.so.0.1.0
b77b2000 b77b4000 r-xp /usr/lib/libappsvc.so.0.1.0
b77b5000 b77ba000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b77bb000 b77c2000 r-xp /usr/lib/libappcore-efl.so.1.1
b77c4000 b77c9000 r-xp /usr/lib/libsys-assert.so
b77cc000 b77cd000 r-xp [vdso]
b77cd000 b77ef000 r-xp /lib/ld-2.20-2014.11.so
b77f1000 b77f9000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:5542)
Call Stack Count: 21
 0: (0xb6c071f6) [/usr/lib/libsqlite3.so.0] + 0xad1f6
 1: init_db + 0x13f (0xb38330df) [/opt/usr/apps/org.example.example/bin/example] + 0x90df
 2: create_button_view + 0x51f (0xb3832d9f) [/opt/usr/apps/org.example.example/bin/example] + 0x8d9f
 3: setting_view_cb + 0x54 (0xb38327c4) [/opt/usr/apps/org.example.example/bin/example] + 0x87c4
 4: (0xb719c449) [/usr/lib/libevas.so.1] + 0x34449
 5: (0xb6428319) [/usr/lib/libeo.so.1] + 0xe319
 6: eo_event_callback_call + 0xb3 (0xb6425d63) [/usr/lib/libeo.so.1] + 0xbd63
 7: (0xb719ca62) [/usr/lib/libevas.so.1] + 0x34a62
 8: (0xb71ab441) [/usr/lib/libevas.so.1] + 0x43441
 9: evas_canvas_event_feed_mouse_down + 0xcf (0xb71b520f) [/usr/lib/libevas.so.1] + 0x4d20f
10: evas_event_feed_mouse_down + 0x6a (0xb71bbc2a) [/usr/lib/libevas.so.1] + 0x53c2a
11: (0xb443549c) [/usr/lib/libecore_input_evas.so.1] + 0x249c
12: (0xb7138055) [/usr/lib/libecore.so.1] + 0xd055
13: (0xb71411b9) [/usr/lib/libecore.so.1] + 0x161b9
14: ecore_main_loop_begin + 0x57 (0xb7141587) [/usr/lib/libecore.so.1] + 0x16587
15: elm_run + 0x2d (0xb759a22d) [/usr/lib/libelementary.so.1] + 0x1c822d
16: appcore_efl_main + 0x4de (0xb77bedde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
17: ui_app_main + 0x140 (0xb77b7c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
18: main + 0x27e (0xb38318ae) [/opt/usr/apps/org.example.example/bin/example] + 0x78ae
19: (0xb77f3148) [/opt/usr/apps/org.example.example/bin/example] + 0xb77f3148
20: __libc_start_main + 0xde (0xb6ce0e4e) [/lib/libc.so.6] + 0x17e4e
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
ppId[org.example.example]
06-01 00:10:52.490+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[forpet] pos[4, 2] pageId[100001]
06-01 00:10:52.490+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[0]
06-01 00:10:52.490+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(787) >  AddBoxToMenuView
06-01 00:10:52.490+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(347) >  AddBox Name[forpet] pageid[100001] pos[4, 2]
06-01 00:10:52.490+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(354) >  menuPage.GetPageId() = 100001, boxPageId = 100001
06-01 00:10:52.490+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: AddBoxToPage(112) >  void ClusterHome3D::Internal::CMainMenuPage::AddBoxToPage(std::shared_ptr<CMainMenuBoxData>) : 112
06-01 00:10:52.490+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: AddBoxToPage(122) >  void ClusterHome3D::Internal::CMainMenuPage::AddBoxToPage(std::shared_ptr<CMainMenuBoxData>) : 122
06-01 00:10:52.490+0900 D/test-log( 2904): mainmenu-page-impl.cpp: AddBoxToPage(123) >  create box[org.example.example] [4,2]
06-01 00:10:52.490+0900 D/test-log( 2904): mainmenu-box-impl.cpp: CMainMenuBox(148) >  create box
06-01 00:10:52.500+0900 D/test-log( 2904): mainmenu-box-impl.cpp: SetPosition(459) >  cut Animation : forpet
06-01 00:10:52.500+0900 D/test-log( 2904): mainmenu-page-impl.cpp: AddBoxToPage(177) >  add created box
06-01 00:10:52.500+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.gallery] Name[Gallery] Icon[/usr/share/icons/default/small/org.tizen.gallery.png] enable[1] system[1]
06-01 00:10:52.500+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.gallery'], count[0]
06-01 00:10:52.500+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.gallery][-17956860][0]
06-01 00:10:52.500+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.gallery]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Gallery] pos[1, 3] pageId[100001]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[6]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[9], [1, 3]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[8], [4, 2]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:10:52.500+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.browser] Name[Internet] Icon[/usr/share/icons/default/small/org.tizen.browser.png] enable[1] system[1]
06-01 00:10:52.500+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.browser'], count[0]
06-01 00:10:52.500+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.browser][-17956860][0]
06-01 00:10:52.500+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.browser]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Internet] pos[2, 3] pageId[100001]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[1]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[10], [2, 3]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:10:52.500+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.message] Name[Messages] Icon[/usr/share/icons/default/small/org.tizen.message.png] enable[1] system[1]
06-01 00:10:52.500+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.message'], count[1]
06-01 00:10:52.500+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.message]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Messages] pos[3, 3] pageId[100001]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[7]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[11], [3, 3]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:10:52.500+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.music-player] Name[Music] Icon[/usr/share/icons/default/small/org.tizen.music-player.png] enable[1] system[1]
06-01 00:10:52.500+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.music-player'], count[0]
06-01 00:10:52.500+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.music-player][-17956860][0]
06-01 00:10:52.500+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.music-player]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Music] pos[4, 3] pageId[100001]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[8]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[12], [4, 3]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:10:52.500+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.myfile] Name[My Files] Icon[/usr/share/icons/default/small/org.tizen.myfile.png] enable[1] system[1]
06-01 00:10:52.500+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.myfile'], count[0]
06-01 00:10:52.500+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.myfile][-17956860][0]
06-01 00:10:52.500+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.myfile]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[My Files] pos[1, 4] pageId[100001]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[9]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[13], [1, 4]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:10:52.500+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.phone] Name[Phone] Icon[/usr/share/icons/default/small/org.tizen.phone.png] enable[1] system[1]
06-01 00:10:52.500+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.phone'], count[0]
06-01 00:10:52.500+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.phone][-17956860][0]
06-01 00:10:52.500+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.phone]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Phone] pos[2, 4] pageId[100001]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[10]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[14], [2, 4]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:10:52.500+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.setting] Name[Settings] Icon[/usr/share/icons/default/small/org.tizen.setting.png] enable[1] system[1]
06-01 00:10:52.500+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.setting'], count[0]
06-01 00:10:52.500+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.setting][-17956860][0]
06-01 00:10:52.500+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.setting]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Settings] pos[3, 4] pageId[100001]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[11]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[15], [3, 4]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:10:52.500+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.uibuildernavigationview] Name[uibuildernavigationview] Icon[/opt/usr/apps/org.example.uibuildernavigationview/shared/res/uibuildernavigationview.png] enable[1] system[0]
06-01 00:10:52.500+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.uibuildernavigationview'], count[0]
06-01 00:10:52.500+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.uibuildernavigationview][-17956860][0]
06-01 00:10:52.500+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.uibuildernavigationview]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[uibuildernavigationview] pos[4, 4] pageId[100001]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[14]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[16], [4, 4]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:10:52.500+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.videos] Name[Video] Icon[/usr/share/icons/default/small/org.tizen.videos.png] enable[1] system[1]
06-01 00:10:52.500+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.videos'], count[0]
06-01 00:10:52.500+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.videos][-17956860][0]
06-01 00:10:52.500+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.videos]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Video] pos[1, 5] pageId[100001]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[12]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[17], [1, 5]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:10:52.500+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: RearrangeItems(243) >  view type [1]
06-01 00:10:53.000+0900 E/PKGMGR_SERVER( 5671): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-01 00:10:53.000+0900 E/PKGMGR_SERVER( 5671): pkgmgr-server.c: main(2265) > package manager server terminated.
06-01 00:10:53.550+0900 D/AUL_AMD ( 2773): amd_request.c: __request_handler(838) > __request_handler: 0
06-01 00:10:53.550+0900 D/AUL_AMD ( 2773): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-01 00:10:53.550+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 00:10:53.550+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 00:10:53.550+0900 I/AUL     ( 2773): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
06-01 00:10:53.560+0900 D/AUL     ( 2773): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 5738, pid = 5740
06-01 00:10:53.560+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 00:10:53.560+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 00:10:53.560+0900 I/AUL     ( 2773): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
06-01 00:10:53.560+0900 E/AUL_AMD ( 2773): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-01 00:10:53.560+0900 W/AUL_AMD ( 2773): amd_launch.c: _start_app(2233) > caller pid : 5740
06-01 00:10:53.560+0900 E/AUL_AMD ( 2773): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-01 00:10:53.560+0900 W/AUL_AMD ( 2773): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-01 00:10:53.560+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2648) > process_pool: false
06-01 00:10:53.560+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-01 00:10:53.560+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-01 00:10:53.560+0900 W/AUL_AMD ( 2773): amd_launch.c: _start_app(2665) > pad pid(-5)
06-01 00:10:53.560+0900 D/AUL_AMD ( 2773): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-01 00:10:53.560+0900 D/AUL_AMD ( 2773): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-01 00:10:53.560+0900 D/AUL     ( 2773): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-01 00:10:53.560+0900 D/AUL_PAD ( 2951): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-01 00:10:53.560+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 00:10:53.560+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 00:10:53.560+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 00:10:53.560+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 00:10:53.560+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 00:10:53.560+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 00:10:53.560+0900 D/AUL_PAD ( 2951): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-01 00:10:53.560+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-01 00:10:53.560+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-01 00:10:53.560+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-01 00:10:53.560+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-01 00:10:53.560+0900 D/AUL_PAD ( 2951): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-01 00:10:53.560+0900 D/AUL_PAD ( 2951): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-01 00:10:53.560+0900 W/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-01 00:10:53.560+0900 D/AUL     ( 2951): process_pool.c: __send_pkt_raw_data(219) > send(11) : 620 / 620
06-01 00:10:53.560+0900 D/AUL_PAD ( 2951): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 5542, bin path: /opt/usr/apps/org.example.example/bin/example
06-01 00:10:53.560+0900 W/AUL_PAD ( 2951): launchpad.c: __send_result_to_caller(265) > Check app launching
06-01 00:10:53.560+0900 D/AUL_PAD ( 2951): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-01 00:10:53.560+0900 D/AUL_PAD ( 5542): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-01 00:10:53.560+0900 D/RESOURCED( 2886): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-01 00:10:53.560+0900 D/RESOURCED( 2886): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-01 00:10:53.560+0900 D/AUL_PAD ( 5542): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
06-01 00:10:53.560+0900 E/RESOURCED( 2886): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-01 00:10:53.560+0900 D/AUL_PAD ( 5542): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-01 00:10:53.560+0900 D/AUL_PAD ( 5542): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-01 00:10:53.560+0900 D/AUL_PAD ( 5542): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-01 00:10:53.560+0900 D/AUL_PAD ( 5542): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-01 00:10:53.560+0900 D/AUL     ( 5542): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (5543) is sent.
06-01 00:10:53.560+0900 D/AUL     ( 5542): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 5543, signo: 10
06-01 00:10:53.570+0900 D/AUL     ( 5542): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-01 00:10:53.570+0900 D/AUL_PAD ( 5542): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-01 00:10:53.570+0900 D/AUL_PAD ( 5542): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-01 00:10:53.570+0900 D/AUL_PAD ( 5542): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-01 00:10:53.570+0900 D/AUL_PAD ( 5542): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-01 00:10:53.570+0900 D/AUL_PAD ( 5542): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTYyNDM0NTMvNTUwMDM5AA==##
06-01 00:10:53.570+0900 D/AUL_PAD ( 5542): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-01 00:10:53.570+0900 D/AUL_PAD ( 5542): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA1NzQwAA==##
06-01 00:10:53.570+0900 D/AUL_PAD ( 5542): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-01 00:10:53.570+0900 D/AUL_PAD ( 5542): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-01 00:10:53.570+0900 D/AUL_PAD ( 5542): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-01 00:10:53.570+0900 D/AUL_PAD ( 5542): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-01 00:10:53.570+0900 D/AUL_PAD ( 5542): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-01 00:10:53.580+0900 I/CAPI_APPFW_APPLICATION( 5542): app_main.c: ui_app_main(788) > app_efl_main
06-01 00:10:53.580+0900 D/LAUNCH  ( 5542): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-01 00:10:53.580+0900 D/APP_CORE( 5542): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-01 00:10:53.580+0900 D/APP_CORE( 5542): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-01 00:10:53.580+0900 D/APP_CORE( 5542): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-01 00:10:53.600+0900 D/APP_CORE( 5542): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-01 00:10:53.600+0900 D/AUL     ( 5542): app_sock.c: __create_server_sock(156) > pg path - already exists
06-01 00:10:53.600+0900 D/APP_CORE( 5542): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb4317520
06-01 00:10:53.600+0900 D/LAUNCH  ( 5542): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-01 00:10:53.600+0900 I/CAPI_APPFW_APPLICATION( 5542): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-01 00:10:53.660+0900 D/AUL_PAD ( 2951): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-01 00:10:53.660+0900 W/AUL     ( 2773): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 5542, appid: org.example.example
06-01 00:10:53.660+0900 D/AUL     ( 2773): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-01 00:10:53.660+0900 E/AUL     ( 2773): simple_util.c: __trm_app_info_send_socket(330) > access
06-01 00:10:53.660+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2700) > add app group info
06-01 00:10:53.660+0900 E/AUL     ( 2773): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-01 00:10:53.660+0900 D/AUL_AMD ( 2773): amd_status.c: _status_add_app_info_list(427) > pid(5542) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-01 00:10:53.670+0900 D/RESOURCED( 2886): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 5542
06-01 00:10:53.670+0900 D/RESOURCED( 2886): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-01 00:10:53.670+0900 E/RESOURCED( 2886): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-01 00:10:53.670+0900 D/RESOURCED( 2886): proc-main.c: resourced_proc_status_change(888) > available memory = 299
06-01 00:10:53.700+0900 D/LAUNCH  ( 5542): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
06-01 00:10:53.700+0900 D/APP_CORE( 5542): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-01 00:10:53.710+0900 E/E17     ( 2798): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x01200002)
06-01 00:10:53.760+0900 E/E17     ( 2798): e_border.c: e_border_show(2088) > BD_SHOW(0x01200002)
06-01 00:10:53.780+0900 D/APP_CORE( 5542): appcore.c: __aul_handler(587) > [APP 5542]     AUL event: AUL_START
06-01 00:10:53.780+0900 I/APP_CORE( 5542): appcore-efl.c: __do_app(496) > [APP 5542] Event: RESET State: CREATED
06-01 00:10:53.780+0900 D/APP_CORE( 5542): appcore-efl.c: __do_app(527) > [APP 5542] RESET
06-01 00:10:53.780+0900 D/LAUNCH  ( 5542): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
06-01 00:10:53.780+0900 D/APP_CORE( 5542): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-01 00:10:53.780+0900 D/APP_CORE( 5542): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-01 00:10:53.780+0900 I/CAPI_APPFW_APPLICATION( 5542): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-01 00:10:53.780+0900 D/AUL     ( 5542): service.c: __set_bundle(186) > __set_bundle
06-01 00:10:53.780+0900 D/LAUNCH  ( 5542): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-01 00:10:53.780+0900 D/APP_CORE( 5542): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-01 00:10:53.780+0900 E/EFL     ( 5542): edje<5542> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 00:10:53.780+0900 E/EFL     ( 5542): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 00:10:53.780+0900 E/EFL     ( 5542): edje<5542> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 00:10:53.780+0900 E/EFL     ( 5542): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 00:10:53.780+0900 E/EFL     ( 5542): edje<5542> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 00:10:53.780+0900 E/EFL     ( 5542): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 00:10:53.780+0900 E/EFL     ( 5542): edje<5542> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 00:10:53.780+0900 E/EFL     ( 5542): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 00:10:53.780+0900 E/EFL     ( 5542): edje<5542> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 00:10:53.780+0900 E/EFL     ( 5542): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 00:10:53.810+0900 W/PROCESSMGR( 2798): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=5542
06-01 00:10:53.830+0900 W/APP_CORE( 5542): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1200002
06-01 00:10:53.830+0900 D/APP_CORE( 5542): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:1200002
06-01 00:10:53.830+0900 D/APP_CORE( 5542): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-01 00:10:53.830+0900 D/AUL     ( 5542): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-01 00:10:53.830+0900 D/AUL_AMD ( 2773): amd_request.c: __request_handler(838) > __request_handler: 34
06-01 00:10:53.840+0900 E/EFL     ( 2798): eo<2798> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 00:10:53.840+0900 E/EFL     ( 2798): eo<2798> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 00:10:53.860+0900 D/AUL_AMD ( 2773): amd_request.c: __request_handler(838) > __request_handler: 15
06-01 00:10:53.860+0900 D/INDICATOR( 2891): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
06-01 00:10:53.860+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 00:10:53.860+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 00:10:53.870+0900 D/AUL_AMD ( 2773): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 5542 is org.example.example
06-01 00:10:53.870+0900 D/AUL_AMD ( 2773): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 5542 : 0
06-01 00:10:53.870+0900 D/AUL     ( 2966): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-01 00:10:53.870+0900 D/INDICATOR( 2891): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-01 00:10:53.870+0900 D/INDICATOR( 2891): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-01 00:10:53.870+0900 D/INDICATOR( 2891): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-01 00:10:53.870+0900 D/INDICATOR( 2891): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-01 00:10:53.870+0900 D/INDICATOR( 2891): main.c: _rotate_window(252) > port :: hide more icon
06-01 00:10:54.190+0900 D/APP_CORE( 5542): appcore.c: __prt_ltime(236) > [APP 5542] first idle after reset: 652 msec
06-01 00:10:54.330+0900 E/E17     ( 2798): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
06-01 00:10:54.330+0900 D/APP_CORE( 2904): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
06-01 00:10:54.330+0900 D/APP_CORE( 2904): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-01 00:10:54.330+0900 D/APP_CORE( 2904): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-01 00:10:54.330+0900 I/APP_CORE( 2904): appcore-efl.c: __do_app(496) > [APP 2904] Event: PAUSE State: RUNNING
06-01 00:10:54.330+0900 D/APP_CORE( 2904): appcore-efl.c: __do_app(565) > [APP 2904] PAUSE
06-01 00:10:54.330+0900 I/CAPI_APPFW_APPLICATION( 2904): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-01 00:10:54.330+0900 E/cluster-home( 2904): homescreen.cpp: OnPause(84) >  app pause
06-01 00:10:54.330+0900 D/cluster-view( 2904): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-01 00:10:54.330+0900 D/cluster-view( 2904): homescreen-view-manager.cpp: AppPause(923) >  END
06-01 00:10:54.330+0900 D/APP_CORE( 2904): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-01 00:10:54.330+0900 E/APP_CORE( 2904): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-01 00:10:54.340+0900 D/APP_CORE( 5542): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1200002 fully_obscured 0
06-01 00:10:54.340+0900 D/APP_CORE( 5542): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-01 00:10:54.340+0900 D/APP_CORE( 5542): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-01 00:10:54.340+0900 I/APP_CORE( 5542): appcore-efl.c: __do_app(496) > [APP 5542] Event: RESUME State: CREATED
06-01 00:10:54.340+0900 D/LAUNCH  ( 5542): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-01 00:10:54.340+0900 D/APP_CORE( 5542): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-01 00:10:54.340+0900 D/APP_CORE( 5542): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-01 00:10:54.340+0900 D/APP_CORE( 5542): appcore-efl.c: __do_app(607) > [APP 5542] RESUME
06-01 00:10:54.340+0900 I/APP_CORE( 5542): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-01 00:10:54.340+0900 I/APP_CORE( 5542): appcore-efl.c: __do_app(614) > [APP 5542] Initial Launching, call the resume_cb
06-01 00:10:54.340+0900 I/CAPI_APPFW_APPLICATION( 5542): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-01 00:10:54.340+0900 D/LAUNCH  ( 5542): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-01 00:10:54.340+0900 D/LAUNCH  ( 5542): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-01 00:10:54.340+0900 D/APP_CORE( 5542): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-01 00:10:54.340+0900 E/APP_CORE( 5542): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-01 00:10:54.350+0900 D/DATA_PROVIDER_MASTER( 2954): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2904 is paused
06-01 00:10:54.350+0900 D/DATA_PROVIDER_MASTER( 2954): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-01 00:10:54.350+0900 D/AUL_AMD ( 2773): amd_status.c: _status_update_app_info_list(456) > pid(2904) status(4)
06-01 00:10:54.350+0900 D/AUL_AMD ( 2773): amd_status.c: _status_update_app_info_list(468) > pid(2904) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-01 00:10:54.350+0900 D/AUL     ( 2773): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-01 00:10:54.350+0900 W/AUL     ( 2773): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2904, appid: org.tizen.homescreen, status: bg
06-01 00:10:54.360+0900 I/CAPI_WIDGET_APPLICATION( 3032): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-01 00:10:54.360+0900 I/CAPI_WIDGET_APPLICATION( 3032): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-01 00:10:54.360+0900 W/AUL     ( 3032): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3032, appid: org.tizen.calendar.widget, status: bg
06-01 00:10:54.360+0900 D/AUL_AMD ( 2773): amd_launch.c: __e17_status_handler(2891) > pid(5542) status(3)
06-01 00:10:54.360+0900 D/AUL_AMD ( 2773): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-01 00:10:54.360+0900 D/RESOURCED( 2886): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3032, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-01 00:10:54.360+0900 D/RESOURCED( 2886): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3032
06-01 00:10:54.360+0900 D/RESOURCED( 2886): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3032, appname = org.tizen.calendar.widget
06-01 00:10:54.360+0900 D/RESOURCED( 2886): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3032
06-01 00:10:54.360+0900 W/AUL_AMD ( 2773): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-01 00:10:54.360+0900 W/AUL_AMD ( 2773): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-01 00:10:54.360+0900 D/AUL_AMD ( 2773): amd_status.c: _status_update_app_info_list(456) > pid(5542) status(3)
06-01 00:10:54.360+0900 D/AUL_AMD ( 2773): amd_status.c: _status_update_app_info_list(468) > pid(5542) appid(org.example.example) pkgid(org.example.example) status(3)
06-01 00:10:54.360+0900 D/AUL     ( 2773): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-01 00:10:54.360+0900 W/AUL     ( 2773): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 5542, appid: org.example.example, status: fg
06-01 00:10:54.370+0900 D/RESOURCED( 2886): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 5542
06-01 00:10:54.370+0900 D/RESOURCED( 2886): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 5542, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-01 00:10:54.370+0900 D/RESOURCED( 2886): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 5542
06-01 00:10:54.430+0900 D/RESOURCED( 2886): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 5542, appname = org.example.example, pkgname = org.example.example
06-01 00:10:54.430+0900 D/RESOURCED( 2886): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 5542, appname = org.example.example
06-01 00:10:54.430+0900 D/RESOURCED( 2886): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 5542
06-01 00:10:54.430+0900 I/RESOURCED( 2886): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-01 00:10:54.430+0900 I/RESOURCED( 2886): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-01 00:10:54.520+0900 D/AUL_AMD ( 2773): amd_launch.c: __e17_status_handler(2910) > pid(5542) status(0)
06-01 00:10:54.670+0900 D/AUL_PAD ( 2951): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-01 00:10:54.670+0900 D/AUL_PAD ( 5747): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-01 00:10:54.680+0900 D/AUL_PAD ( 2951): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-01 00:10:54.700+0900 E/RESOURCED( 2886): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.333
06-01 00:10:55.170+0900 D/AUL_AMD ( 2773): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-01 00:10:55.170+0900 D/RUA     ( 2773): rua.c: rua_add_history(179) > rua_add_history start
06-01 00:10:55.220+0900 D/RUA     ( 2773): rua.c: rua_add_history(247) > rua_add_history ok
06-01 00:10:55.720+0900 D/AUL_PAD ( 5747): launchpad_loader.c: main(588) > sleeping 1 sec...
06-01 00:10:55.720+0900 D/AUL_PAD ( 5747): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-01 00:10:55.720+0900 D/AUL_PAD ( 5747): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b884a760
06-01 00:10:55.720+0900 D/AUL_PAD ( 5747): preload.h: __preload_init(69) > get pre-initialization function
06-01 00:10:55.720+0900 D/AUL_PAD ( 5747): preload.h: __preload_init(73) > get shutdown function
06-01 00:10:55.720+0900 D/AUL_PAD ( 5747): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b884aa40
06-01 00:10:55.740+0900 D/AUL_PAD ( 5747): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b884c640
06-01 00:10:55.740+0900 D/AUL_PAD ( 5747): preload.h: __preload_init(69) > get pre-initialization function
06-01 00:10:55.740+0900 D/AUL_PAD ( 5747): preload.h: __preload_init(73) > get shutdown function
06-01 00:10:55.740+0900 D/AUL_PAD ( 5747): preexec.h: __preexec_init(76) > preexec start
06-01 00:10:55.740+0900 D/AUL_PAD ( 5747): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-01 00:10:55.740+0900 D/AUL     ( 5747): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-01 00:10:55.740+0900 D/AUL     ( 5747): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-01 00:10:55.740+0900 D/AUL     ( 5747): process_pool.c: __connect_to_launchpad(132) > send(5747) : 4
06-01 00:10:55.740+0900 D/AUL     ( 5747): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-01 00:10:55.740+0900 D/AUL_PAD ( 2951): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-01 00:10:55.740+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-01 00:10:55.740+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 00:10:55.740+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 00:10:55.740+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 00:10:55.740+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 00:10:55.740+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 00:10:55.740+0900 D/AUL_PAD ( 2951): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-01 00:10:55.740+0900 D/AUL_PAD ( 2951): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 5747
06-01 00:10:55.760+0900 I/user_tag0( 5542): /opt/usr/apps/org.example.example/data/test.db
06-01 00:10:55.810+0900 D/AUL_PAD ( 2951): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-01 00:10:55.810+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 00:10:55.810+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 00:10:55.810+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 00:10:55.810+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 00:10:55.810+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 00:10:55.810+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 00:10:55.810+0900 I/AUL_PAD ( 2951): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 5542 pgid = 5542
06-01 00:10:55.810+0900 I/AUL_PAD ( 2951): sigchild.h: __sigchild_action(142) > dead_pid(5542)
06-01 00:10:55.820+0900 E/EFL     ( 2798): eo<2798> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 00:10:55.840+0900 D/AUL_PAD ( 2951): sigchild.h: __send_app_dead_signal(90) > send dead signal done
06-01 00:10:55.840+0900 I/AUL_PAD ( 2951): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
06-01 00:10:55.840+0900 I/AUL_PAD ( 2951): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
06-01 00:10:55.840+0900 E/AUL_PAD ( 2951): launchpad.c: main(688) > error reading sigchld info
06-01 00:10:55.840+0900 D/PROCESSMGR( 2798): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002e  register trigger_timer!  pointed_win=0x40083d 
06-01 00:10:55.840+0900 D/AUL_AMD ( 2773): amd_launch.c: __e17_status_handler(2891) > pid(2904) status(3)
06-01 00:10:55.840+0900 D/AUL_AMD ( 2773): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-01 00:10:55.840+0900 I/ESD     ( 2964): esd_main.c: __esd_app_dead_handler(1771) > pid: 5542
06-01 00:10:55.840+0900 W/AUL_AMD ( 2773): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-01 00:10:55.840+0900 W/AUL_AMD ( 2773): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-01 00:10:55.840+0900 D/AUL_AMD ( 2773): amd_status.c: _status_update_app_info_list(456) > pid(2904) status(3)
06-01 00:10:55.840+0900 D/AUL_AMD ( 2773): amd_status.c: _status_update_app_info_list(468) > pid(2904) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(3)
06-01 00:10:55.840+0900 D/AUL     ( 2773): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.tizen.homescreen
06-01 00:10:55.840+0900 W/AUL     ( 2773): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2904, appid: org.tizen.homescreen, status: fg
06-01 00:10:55.840+0900 D/STARTER ( 2883): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 5542 is termianted
06-01 00:10:55.840+0900 D/STARTER ( 2883): starter.c: _check_dead_signal(202) > [_check_dead_signal:202] Unknown process, ignore it
06-01 00:10:55.840+0900 W/AUL_AMD ( 2773): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 5542
06-01 00:10:55.840+0900 W/AUL_AMD ( 2773): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 5542
06-01 00:10:55.840+0900 D/AUL_AMD ( 2773): amd_key.c: _unregister_key_event(179) > ===key stack===
06-01 00:10:55.840+0900 E/AUL_AMD ( 2773): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
06-01 00:10:55.840+0900 D/AUL_AMD ( 2773): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.example.example)
06-01 00:10:55.840+0900 D/AUL     ( 2773): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-01 00:10:55.840+0900 E/AUL     ( 2773): simple_util.c: __trm_app_info_send_socket(330) > access
06-01 00:10:55.850+0900 E/RESOURCED( 2886): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.337
06-01 00:10:55.850+0900 D/RESOURCED( 2886): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2904
06-01 00:10:55.850+0900 D/RESOURCED( 2886): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 2904, appname = org.tizen.homescreen, pkgname = org.tizen.homescreen
06-01 00:10:55.850+0900 D/RESOURCED( 2886): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2904, appname = org.tizen.homescreen
06-01 00:10:55.850+0900 D/RESOURCED( 2886): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2904
06-01 00:10:55.850+0900 D/RESOURCED( 2886): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 5542
06-01 00:10:55.850+0900 D/RESOURCED( 2886): appinfo-list.c: resourced_appinfo_put(132) > appid org.example.example, pkgname = org.example.example, ref = 0
06-01 00:10:55.850+0900 W/CRASH_MANAGER( 5748): worker.c: worker_job(1204) > 1105542657861149624345
