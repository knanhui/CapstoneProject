S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 11043
Date: 2017-06-01 14:34:29+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb94130d8, esi = 0xb37bb9de
ebp = 0xbf87b2d8, esp = 0xbf87b280
eax = 0xb42a5000, ebx = 0xb37be000
ecx = 0x00000000, edx = 0x00000002
eip = 0xb37bace8

Memory Information
MemTotal:      123 KB
MemFree:        27 KB
Buffers:         8 KB
Cached:     170196 KB
VmPeak:     119960 KB
VmSize:     119960 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23076 KB
VmRSS:       23076 KB
VmData:      34192 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34460 KB
VmPTE:          96 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 11043 TID = 11043
11043 11053 11251 11252 

Maps Information
b2b7b000 b2b85000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b8b000 b2b97000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b98000 b2bb9000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2bbe000 b2bbf000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2bc0000 b2bc5000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2bc6000 b2bc7000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2bc8000 b2bca000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2bcb000 b2bd7000 r-xp /usr/lib/libdrm.so.2.4.0
b2bd8000 b2bdb000 r-xp /usr/lib/libdri2.so.0.0.0
b2bdc000 b2be6000 r-xp /usr/lib/libtbm.so.1.0.0
b2be7000 b2bfc000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2bfd000 b2c0f000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3411000 b3442000 r-xp /usr/lib/libidn.so.11.5.44
b3443000 b3465000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3466000 b3476000 r-xp /usr/lib/libcares.so.2.1.0
b3477000 b3480000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3481000 b348a000 r-xp /usr/lib/libefl-extension.so.0.1.0
b348b000 b3502000 r-xp /usr/lib/libcurl.so.4.3.0
b3504000 b3516000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3517000 b3538000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b353f000 b3540000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3541000 b3542000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3543000 b3546000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3547000 b354a000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3652000 b3658000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3659000 b379d000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37ad000 b37af000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b37b0000 b37b1000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37b2000 b37bd000 r-xp /opt/usr/apps/org.example.example/bin/example
b37bf000 b37f8000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41fb000 b4206000 r-xp /lib/libnss_files-2.20-2014.11.so
b4208000 b4213000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4215000 b422c000 r-xp /lib/libnsl-2.20-2014.11.so
b4230000 b4238000 r-xp /lib/libnss_compat-2.20-2014.11.so
b423a000 b425e000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b425f000 b4260000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4261000 b4264000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4265000 b426c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b426d000 b4277000 r-xp /usr/lib/libsensord-share.so
b4278000 b4294000 r-xp /usr/lib/libsensor.so.1.2.0
b4296000 b429f000 r-xp /usr/lib/libappcore-common.so.1.1
b42a2000 b42a4000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42b9000 b42bb000 r-xp /usr/lib/libXau.so.6.0.0
b42bc000 b42de000 r-xp /usr/lib/libxcb.so.1.1.0
b42e0000 b42e9000 r-xp /lib/libcrypt-2.20-2014.11.so
b4312000 b4314000 r-xp /usr/lib/libiri.so
b4315000 b433b000 r-xp /lib/libexpat.so.1.5.2
b433d000 b43a8000 r-xp /usr/lib/libssl.so.1.0.0
b43ae000 b43ba000 r-xp /usr/lib/libethumb.so.1.13.0
b43bb000 b43bf000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43c0000 b4611000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b8c000 b5b9c000 r-xp /usr/lib/libXi.so.6.1.0
b5b9d000 b5b9f000 r-xp /usr/lib/libXgesture.so.7.0.0
b5ba0000 b5ba6000 r-xp /usr/lib/libXtst.so.6.1.0
b5ba7000 b5bb1000 r-xp /usr/lib/libXrender.so.1.3.0
b5bb2000 b5bbb000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bbd000 b5bbf000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bc0000 b5bc5000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bc6000 b5bd8000 r-xp /usr/lib/libXext.so.6.4.0
b5bd9000 b5bdb000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bdc000 b5bde000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5be0000 b5d22000 r-xp /usr/lib/libX11.so.6.3.0
b5d26000 b5d30000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d31000 b5d47000 r-xp /usr/lib/libudev.so.1.6.0
b5d4a000 b5d4e000 r-xp /lib/libattr.so.1.1.0
b5d4f000 b5d7e000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d80000 b5d86000 r-xp /usr/lib/libffi.so.6.0.2
b5d87000 b5daa000 r-xp /lib/libz.so.1.2.8
b5dab000 b5dae000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5daf000 b5f0b000 r-xp /usr/lib/libxml2.so.2.9.2
b5f11000 b5ff8000 r-xp /usr/lib/libstdc++.so.6.0.20
b6005000 b6008000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6009000 b602b000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b602c000 b6040000 r-xp /lib/libresolv-2.20-2014.11.so
b6044000 b6068000 r-xp /usr/lib/liblzma.so.5.0.3
b6069000 b606b000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b606d000 b6077000 r-xp /usr/lib/libembryo.so.1.13.0
b6078000 b60a1000 r-xp /usr/lib/libpng12.so.0.50.0
b60a2000 b60eb000 r-xp /usr/lib/libjpeg.so.8.0.2
b60fc000 b6103000 r-xp /lib/librt-2.20-2014.11.so
b6105000 b6124000 r-xp /usr/lib/libector.so.1.13.0
b6127000 b6154000 r-xp /usr/lib/liblua-5.1.so
b6155000 b61e5000 r-xp /usr/lib/libfreetype.so.6.11.3
b61e9000 b6227000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6228000 b623e000 r-xp /usr/lib/libfribidi.so.0.3.1
b623f000 b6298000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b629b000 b62e6000 r-xp /lib/libm-2.20-2014.11.so
b62e8000 b62fa000 r-xp /usr/lib/libeio.so.1.13.0
b62fb000 b62fe000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62ff000 b6305000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6306000 b6329000 r-xp /usr/lib/libefreet.so.1.13.0
b632c000 b6357000 r-xp /usr/lib/libeldbus.so.1.13.0
b6358000 b638c000 r-xp /usr/lib/libecore_con.so.1.13.0
b638e000 b6397000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6398000 b63a1000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63a2000 b63b5000 r-xp /usr/lib/libeo.so.1.13.0
b63b7000 b63ca000 r-xp /usr/lib/libecore_input.so.1.13.0
b63cb000 b63d2000 r-xp /usr/lib/libecore_file.so.1.13.0
b63d3000 b63f6000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63f7000 b6423000 r-xp /usr/lib/libeet.so.1.13.0
b642c000 b6497000 r-xp /usr/lib/libeina.so.1.13.0
b649a000 b64b1000 r-xp /usr/lib/libefl.so.1.13.0
b64b3000 b661a000 r-xp /usr/lib/libicuuc.so.51.1
b6628000 b6834000 r-xp /usr/lib/libicui18n.so.51.1
b683c000 b688b000 r-xp /usr/lib/libecore_x.so.1.13.0
b688d000 b68a7000 r-xp /lib/libgcc_s-4.9.so.1
b68a9000 b68ad000 r-xp /lib/libcap.so.2.21
b68ae000 b68f4000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68f5000 b68fc000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68fe000 b6950000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6952000 b6add000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6ae2000 b6bb0000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bb3000 b6bb7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bb8000 b6bc7000 r-xp /usr/lib/libvconf.so.0.2.45
b6bc8000 b6bcb000 r-xp /usr/lib/libvasum.so.0.3.1
b6bcc000 b6bcf000 r-xp /usr/lib/libttrace.so.1.1
b6bd1000 b6bd5000 r-xp /usr/lib/libiniparser.so.0
b6bd6000 b6c06000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c07000 b6c10000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c11000 b6c36000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c37000 b6c47000 r-xp /usr/lib/libunwind.so.8.0.1
b6c51000 b6dff000 r-xp /lib/libc-2.20-2014.11.so
b6e07000 b6f4a000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f4c000 b6fa4000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fa5000 b6fd9000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fdc000 b70b0000 r-xp /usr/lib/libedje.so.1.13.0
b70b3000 b70df000 r-xp /usr/lib/libecore.so.1.13.0
b70f0000 b7316000 r-xp /usr/lib/libevas.so.1.13.0
b733e000 b7356000 r-xp /lib/libpthread-2.20-2014.11.so
b735a000 b76d4000 r-xp /usr/lib/libelementary.so.1.13.0
b76f4000 b76f8000 r-xp /usr/lib/libsmack.so.1.0.0
b76f9000 b7702000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7703000 b7706000 r-xp /usr/lib/libdlog.so.0.0.0
b7707000 b770c000 r-xp /usr/lib/libbundle.so.0.1.22
b770d000 b7710000 r-xp /lib/libdl-2.20-2014.11.so
b7712000 b7737000 r-xp /usr/lib/libaul.so.0.1.0
b773a000 b773c000 r-xp /usr/lib/libappsvc.so.0.1.0
b773d000 b7742000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7743000 b774a000 r-xp /usr/lib/libappcore-efl.so.1.1
b774c000 b7751000 r-xp /usr/lib/libsys-assert.so
b7754000 b7755000 r-xp [vdso]
b7755000 b7777000 r-xp /lib/ld-2.20-2014.11.so
b7779000 b7781000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:11043)
Call Stack Count: 24
 0: gl_content_get_cb + 0x98 (0xb37bace8) [/opt/usr/apps/org.example.example/bin/example] + 0x8ce8
 1: (0xb74aab9b) [/usr/lib/libelementary.so.1] + 0x150b9b
 2: (0xb74ab235) [/usr/lib/libelementary.so.1] + 0x151235
 3: (0xb74ab802) [/usr/lib/libelementary.so.1] + 0x151802
 4: (0xb74abf64) [/usr/lib/libelementary.so.1] + 0x151f64
 5: (0xb74ac440) [/usr/lib/libelementary.so.1] + 0x152440
 6: (0xb74bac42) [/usr/lib/libelementary.so.1] + 0x160c42
 7: evas_obj_smart_calculate + 0x99 (0xb717a6f9) [/usr/lib/libevas.so.1] + 0x8a6f9
 8: (0xb717bbf9) [/usr/lib/libevas.so.1] + 0x8bbf9
 9: (0xb71cc029) [/usr/lib/libevas.so.1] + 0xdc029
10: (0xb71cf36c) [/usr/lib/libevas.so.1] + 0xdf36c
11: evas_canvas_render_updates + 0x97 (0xb713e7c7) [/usr/lib/libevas.so.1] + 0x4e7c7
12: evas_render_updates + 0x53 (0xb7144713) [/usr/lib/libevas.so.1] + 0x54713
13: (0xb2c074bc) [/usr/lib/ecore_evas/engines/x/v-1.13/module.so] + 0xa4bc
14: (0xb63e19d9) [/usr/lib/libecore_evas.so.1] + 0xe9d9
15: (0xb70c5180) [/usr/lib/libecore.so.1] + 0x12180
16: (0xb70c908d) [/usr/lib/libecore.so.1] + 0x1608d
17: ecore_main_loop_begin + 0x57 (0xb70c9587) [/usr/lib/libecore.so.1] + 0x16587
18: elm_run + 0x2d (0xb752222d) [/usr/lib/libelementary.so.1] + 0x1c822d
19: appcore_efl_main + 0x4de (0xb7746dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
20: ui_app_main + 0x140 (0xb773fc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
21: main + 0x2e1 (0xb37b96a1) [/opt/usr/apps/org.example.example/bin/example] + 0x76a1
22: (0xb777b148) [/opt/usr/apps/org.example.example/bin/example] + 0xb777b148
23: __libc_start_main + 0xde (0xb6c68e4e) [/lib/libc.so.6] + 0x17e4e
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
nu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[forpet] pos[3, 2] pageId[100001]
06-01 14:34:19.591+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[0]
06-01 14:34:19.591+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(787) >  AddBoxToMenuView
06-01 14:34:19.591+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(347) >  AddBox Name[forpet] pageid[100001] pos[3, 2]
06-01 14:34:19.591+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(354) >  menuPage.GetPageId() = 100001, boxPageId = 100001
06-01 14:34:19.591+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: AddBoxToPage(112) >  void ClusterHome3D::Internal::CMainMenuPage::AddBoxToPage(std::shared_ptr<CMainMenuBoxData>) : 112
06-01 14:34:19.591+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: AddBoxToPage(122) >  void ClusterHome3D::Internal::CMainMenuPage::AddBoxToPage(std::shared_ptr<CMainMenuBoxData>) : 122
06-01 14:34:19.591+0900 D/test-log( 2945): mainmenu-page-impl.cpp: AddBoxToPage(123) >  create box[org.example.example] [3,2]
06-01 14:34:19.591+0900 D/test-log( 2945): mainmenu-box-impl.cpp: CMainMenuBox(148) >  create box
06-01 14:34:19.591+0900 D/test-log( 2945): mainmenu-box-impl.cpp: SetPosition(459) >  cut Animation : forpet
06-01 14:34:19.591+0900 D/test-log( 2945): mainmenu-page-impl.cpp: AddBoxToPage(177) >  add created box
06-01 14:34:19.591+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.gallery] Name[Gallery] Icon[/usr/share/icons/default/small/org.tizen.gallery.png] enable[1] system[1]
06-01 14:34:19.591+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.gallery'], count[0]
06-01 14:34:19.591+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.gallery][-17956860][0]
06-01 14:34:19.591+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.gallery]
06-01 14:34:19.591+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Gallery] pos[4, 2] pageId[100001]
06-01 14:34:19.591+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[6]
06-01 14:34:19.591+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[8], [4, 2]
06-01 14:34:19.591+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[7], [3, 2]
06-01 14:34:19.591+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 14:34:19.591+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.imageutil] Name[imageutil] Icon[/opt/usr/apps/org.example.imageutil/shared/res/imageutil.png] enable[1] system[0]
06-01 14:34:19.601+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.imageutil'], count[0]
06-01 14:34:19.601+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.imageutil][-17956860][0]
06-01 14:34:19.601+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.imageutil]
06-01 14:34:19.601+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[imageutil] pos[1, 3] pageId[100001]
06-01 14:34:19.601+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[15]
06-01 14:34:19.601+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[9], [1, 3]
06-01 14:34:19.601+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 14:34:19.601+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 14:34:19.601+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.browser] Name[Internet] Icon[/usr/share/icons/default/small/org.tizen.browser.png] enable[1] system[1]
06-01 14:34:19.601+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.browser'], count[0]
06-01 14:34:19.601+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.browser][-17956860][0]
06-01 14:34:19.601+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.browser]
06-01 14:34:19.601+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Internet] pos[2, 3] pageId[100001]
06-01 14:34:19.601+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[1]
06-01 14:34:19.601+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[10], [2, 3]
06-01 14:34:19.601+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 14:34:19.601+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 14:34:19.601+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.message] Name[Messages] Icon[/usr/share/icons/default/small/org.tizen.message.png] enable[1] system[1]
06-01 14:34:19.611+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.message'], count[1]
06-01 14:34:19.611+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.message]
06-01 14:34:19.611+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Messages] pos[3, 3] pageId[100001]
06-01 14:34:19.611+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[7]
06-01 14:34:19.611+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[11], [3, 3]
06-01 14:34:19.611+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 14:34:19.611+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 14:34:19.611+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.music-player] Name[Music] Icon[/usr/share/icons/default/small/org.tizen.music-player.png] enable[1] system[1]
06-01 14:34:19.621+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.music-player'], count[0]
06-01 14:34:19.621+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.music-player][-17956860][0]
06-01 14:34:19.621+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.music-player]
06-01 14:34:19.621+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Music] pos[4, 3] pageId[100001]
06-01 14:34:19.621+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[8]
06-01 14:34:19.621+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[12], [4, 3]
06-01 14:34:19.621+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 14:34:19.621+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 14:34:19.621+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.myfile] Name[My Files] Icon[/usr/share/icons/default/small/org.tizen.myfile.png] enable[1] system[1]
06-01 14:34:19.621+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.myfile'], count[0]
06-01 14:34:19.621+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.myfile][-17956860][0]
06-01 14:34:19.621+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.myfile]
06-01 14:34:19.621+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[My Files] pos[1, 4] pageId[100001]
06-01 14:34:19.621+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[9]
06-01 14:34:19.621+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[13], [1, 4]
06-01 14:34:19.621+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 14:34:19.621+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 14:34:19.621+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.phone] Name[Phone] Icon[/usr/share/icons/default/small/org.tizen.phone.png] enable[1] system[1]
06-01 14:34:19.621+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.phone'], count[0]
06-01 14:34:19.621+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.phone][-17956860][0]
06-01 14:34:19.621+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.phone]
06-01 14:34:19.621+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Phone] pos[2, 4] pageId[100001]
06-01 14:34:19.621+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[10]
06-01 14:34:19.621+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[14], [2, 4]
06-01 14:34:19.621+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 14:34:19.621+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 14:34:19.621+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.setting] Name[Settings] Icon[/usr/share/icons/default/small/org.tizen.setting.png] enable[1] system[1]
06-01 14:34:19.621+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.setting'], count[0]
06-01 14:34:19.621+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.setting][-17956860][0]
06-01 14:34:19.621+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.setting]
06-01 14:34:19.621+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Settings] pos[3, 4] pageId[100001]
06-01 14:34:19.621+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[11]
06-01 14:34:19.621+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[15], [3, 4]
06-01 14:34:19.621+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 14:34:19.621+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 14:34:19.621+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.videos] Name[Video] Icon[/usr/share/icons/default/small/org.tizen.videos.png] enable[1] system[1]
06-01 14:34:19.621+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.videos'], count[0]
06-01 14:34:19.621+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.videos][-17956860][0]
06-01 14:34:19.621+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.videos]
06-01 14:34:19.621+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Video] pos[4, 4] pageId[100001]
06-01 14:34:19.621+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[12]
06-01 14:34:19.621+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[16], [4, 4]
06-01 14:34:19.621+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 14:34:19.621+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 14:34:19.621+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: RearrangeItems(243) >  view type [1]
06-01 14:34:19.701+0900 D/rpm-installer(11193): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
06-01 14:34:19.701+0900 D/rpm-installer(11193): rpm-appcore-intf.c: main(259) > ------------------------------------------------
06-01 14:34:19.701+0900 D/rpm-installer(11193): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
06-01 14:34:19.701+0900 D/rpm-installer(11193): rpm-appcore-intf.c: main(261) > ------------------------------------------------
06-01 14:34:19.711+0900 D/PKGMGR_SERVER(11179): pkgmgr-server.c: sighandler(387) > child exit [11193]
06-01 14:34:19.711+0900 E/PKGMGR_SERVER(11179): pkgmgr-server.c: sighandler(402) > child NORMAL exit [11193]
06-01 14:34:20.461+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(838) > __request_handler: 0
06-01 14:34:20.461+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-01 14:34:20.461+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 14:34:20.461+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 14:34:20.471+0900 I/AUL     ( 2858): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
06-01 14:34:20.471+0900 D/AUL     ( 2858): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 11245, pid = 11247
06-01 14:34:20.471+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 14:34:20.471+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 14:34:20.471+0900 I/AUL     ( 2858): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
06-01 14:34:20.471+0900 E/AUL_AMD ( 2858): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-01 14:34:20.471+0900 W/AUL_AMD ( 2858): amd_launch.c: _start_app(2233) > caller pid : 11247
06-01 14:34:20.471+0900 E/AUL_AMD ( 2858): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-01 14:34:20.471+0900 W/AUL_AMD ( 2858): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-01 14:34:20.471+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2648) > process_pool: false
06-01 14:34:20.471+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-01 14:34:20.471+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-01 14:34:20.471+0900 W/AUL_AMD ( 2858): amd_launch.c: _start_app(2665) > pad pid(-5)
06-01 14:34:20.471+0900 D/AUL_AMD ( 2858): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-01 14:34:20.471+0900 D/AUL_AMD ( 2858): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-01 14:34:20.471+0900 D/AUL     ( 2858): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-01 14:34:20.471+0900 D/AUL_PAD ( 3003): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-01 14:34:20.471+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 14:34:20.471+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 14:34:20.471+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 14:34:20.471+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 14:34:20.471+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 14:34:20.471+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 14:34:20.471+0900 D/AUL_PAD ( 3003): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-01 14:34:20.471+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-01 14:34:20.471+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-01 14:34:20.471+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-01 14:34:20.471+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-01 14:34:20.471+0900 D/AUL_PAD ( 3003): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-01 14:34:20.471+0900 D/AUL_PAD ( 3003): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-01 14:34:20.471+0900 W/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-01 14:34:20.471+0900 D/AUL     ( 3003): process_pool.c: __send_pkt_raw_data(219) > send(11) : 624 / 624
06-01 14:34:20.471+0900 D/AUL_PAD ( 3003): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 11043, bin path: /opt/usr/apps/org.example.example/bin/example
06-01 14:34:20.471+0900 W/AUL_PAD ( 3003): launchpad.c: __send_result_to_caller(265) > Check app launching
06-01 14:34:20.471+0900 D/AUL_PAD ( 3003): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-01 14:34:20.481+0900 D/AUL_PAD (11043): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-01 14:34:20.481+0900 D/RESOURCED( 2893): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-01 14:34:20.481+0900 D/RESOURCED( 2893): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-01 14:34:20.481+0900 E/RESOURCED( 2893): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-01 14:34:20.481+0900 D/AUL_PAD (11043): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
06-01 14:34:20.481+0900 D/AUL_PAD (11043): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-01 14:34:20.481+0900 D/AUL_PAD (11043): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-01 14:34:20.481+0900 D/AUL_PAD (11043): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-01 14:34:20.481+0900 D/AUL_PAD (11043): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-01 14:34:20.481+0900 D/AUL     (11043): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (11053) is sent.
06-01 14:34:20.481+0900 D/AUL     (11043): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 11053, signo: 10
06-01 14:34:20.481+0900 D/AUL     (11043): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-01 14:34:20.481+0900 D/AUL_PAD (11043): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-01 14:34:20.481+0900 D/AUL_PAD (11043): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-01 14:34:20.481+0900 D/AUL_PAD (11043): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-01 14:34:20.481+0900 D/AUL_PAD (11043): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-01 14:34:20.481+0900 D/AUL_PAD (11043): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTYyOTUyNjAvNDcyMzk3AA==##
06-01 14:34:20.481+0900 D/AUL_PAD (11043): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-01 14:34:20.481+0900 D/AUL_PAD (11043): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAxMTI0NwA=##
06-01 14:34:20.481+0900 D/AUL_PAD (11043): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-01 14:34:20.481+0900 D/AUL_PAD (11043): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-01 14:34:20.481+0900 D/AUL_PAD (11043): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-01 14:34:20.481+0900 D/AUL_PAD (11043): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-01 14:34:20.481+0900 D/AUL_PAD (11043): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-01 14:34:20.491+0900 I/CAPI_APPFW_APPLICATION(11043): app_main.c: ui_app_main(788) > app_efl_main
06-01 14:34:20.491+0900 D/LAUNCH  (11043): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-01 14:34:20.491+0900 D/APP_CORE(11043): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-01 14:34:20.491+0900 D/APP_CORE(11043): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-01 14:34:20.491+0900 D/APP_CORE(11043): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-01 14:34:20.511+0900 D/APP_CORE(11043): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-01 14:34:20.511+0900 D/AUL     (11043): app_sock.c: __create_server_sock(156) > pg path - already exists
06-01 14:34:20.511+0900 D/APP_CORE(11043): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb429f520
06-01 14:34:20.511+0900 D/LAUNCH  (11043): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-01 14:34:20.511+0900 I/CAPI_APPFW_APPLICATION(11043): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-01 14:34:20.581+0900 D/AUL_PAD ( 3003): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-01 14:34:20.581+0900 W/AUL     ( 2858): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 11043, appid: org.example.example
06-01 14:34:20.581+0900 D/AUL     ( 2858): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-01 14:34:20.581+0900 E/AUL     ( 2858): simple_util.c: __trm_app_info_send_socket(330) > access
06-01 14:34:20.581+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2700) > add app group info
06-01 14:34:20.581+0900 E/AUL     ( 2858): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-01 14:34:20.581+0900 D/AUL_AMD ( 2858): amd_status.c: _status_add_app_info_list(427) > pid(11043) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-01 14:34:20.581+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 11043
06-01 14:34:20.581+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-01 14:34:20.581+0900 E/RESOURCED( 2893): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-01 14:34:20.581+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(888) > available memory = 316
06-01 14:34:20.631+0900 D/LAUNCH  (11043): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
06-01 14:34:20.631+0900 D/APP_CORE(11043): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-01 14:34:20.631+0900 E/E17     ( 2741): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02e00002)
06-01 14:34:20.681+0900 E/E17     ( 2741): e_border.c: e_border_show(2088) > BD_SHOW(0x02e00002)
06-01 14:34:20.681+0900 D/APP_CORE(11043): appcore.c: __aul_handler(587) > [APP 11043]     AUL event: AUL_START
06-01 14:34:20.681+0900 I/APP_CORE(11043): appcore-efl.c: __do_app(496) > [APP 11043] Event: RESET State: CREATED
06-01 14:34:20.681+0900 D/APP_CORE(11043): appcore-efl.c: __do_app(527) > [APP 11043] RESET
06-01 14:34:20.681+0900 D/LAUNCH  (11043): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
06-01 14:34:20.681+0900 D/APP_CORE(11043): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-01 14:34:20.681+0900 D/APP_CORE(11043): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-01 14:34:20.681+0900 I/CAPI_APPFW_APPLICATION(11043): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-01 14:34:20.681+0900 D/AUL     (11043): service.c: __set_bundle(186) > __set_bundle
06-01 14:34:20.681+0900 D/LAUNCH  (11043): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-01 14:34:20.681+0900 D/APP_CORE(11043): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-01 14:34:20.681+0900 E/EFL     (11043): edje<11043> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 14:34:20.681+0900 E/EFL     (11043): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 14:34:20.681+0900 E/EFL     (11043): edje<11043> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 14:34:20.681+0900 E/EFL     (11043): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 14:34:20.681+0900 E/EFL     (11043): edje<11043> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 14:34:20.681+0900 E/EFL     (11043): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 14:34:20.681+0900 E/EFL     (11043): edje<11043> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 14:34:20.681+0900 E/EFL     (11043): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 14:34:20.681+0900 E/EFL     (11043): edje<11043> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 14:34:20.681+0900 E/EFL     (11043): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 14:34:20.701+0900 W/PROCESSMGR( 2741): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=11043
06-01 14:34:20.701+0900 W/APP_CORE(11043): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2e00002
06-01 14:34:20.701+0900 D/APP_CORE(11043): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2e00002
06-01 14:34:20.701+0900 D/APP_CORE(11043): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-01 14:34:20.701+0900 D/AUL     (11043): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-01 14:34:20.701+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(838) > __request_handler: 34
06-01 14:34:20.711+0900 E/EFL     ( 2741): eo<2741> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 14:34:20.711+0900 E/EFL     ( 2741): eo<2741> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 14:34:20.721+0900 D/INDICATOR( 2934): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
06-01 14:34:20.731+0900 D/INDICATOR( 2934): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-01 14:34:20.731+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(838) > __request_handler: 15
06-01 14:34:20.731+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 14:34:20.731+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 14:34:20.731+0900 D/INDICATOR( 2934): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-01 14:34:20.731+0900 D/INDICATOR( 2934): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-01 14:34:20.731+0900 D/INDICATOR( 2934): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-01 14:34:20.731+0900 D/INDICATOR( 2934): main.c: _rotate_window(252) > port :: hide more icon
06-01 14:34:20.731+0900 D/AUL_AMD ( 2858): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 11043 is org.example.example
06-01 14:34:20.731+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 11043 : 0
06-01 14:34:20.731+0900 D/AUL     ( 3022): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-01 14:34:20.991+0900 D/APP_CORE(11043): appcore.c: __prt_ltime(236) > [APP 11043] first idle after reset: 522 msec
06-01 14:34:20.991+0900 E/PKGMGR_SERVER(11179): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-01 14:34:20.991+0900 E/PKGMGR_SERVER(11179): pkgmgr-server.c: main(2265) > package manager server terminated.
06-01 14:34:21.071+0900 E/E17     ( 2741): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
06-01 14:34:21.071+0900 D/APP_CORE( 2945): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
06-01 14:34:21.071+0900 D/APP_CORE( 2945): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-01 14:34:21.071+0900 D/APP_CORE( 2945): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-01 14:34:21.071+0900 I/APP_CORE( 2945): appcore-efl.c: __do_app(496) > [APP 2945] Event: PAUSE State: RUNNING
06-01 14:34:21.071+0900 D/APP_CORE( 2945): appcore-efl.c: __do_app(565) > [APP 2945] PAUSE
06-01 14:34:21.071+0900 I/CAPI_APPFW_APPLICATION( 2945): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-01 14:34:21.071+0900 E/cluster-home( 2945): homescreen.cpp: OnPause(84) >  app pause
06-01 14:34:21.071+0900 D/cluster-view( 2945): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-01 14:34:21.071+0900 D/cluster-view( 2945): homescreen-view-manager.cpp: AppPause(923) >  END
06-01 14:34:21.071+0900 D/APP_CORE( 2945): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-01 14:34:21.071+0900 E/APP_CORE( 2945): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-01 14:34:21.081+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(456) > pid(2945) status(4)
06-01 14:34:21.081+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(468) > pid(2945) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-01 14:34:21.081+0900 D/AUL     ( 2858): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-01 14:34:21.081+0900 W/AUL     ( 2858): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2945, appid: org.tizen.homescreen, status: bg
06-01 14:34:21.091+0900 D/DATA_PROVIDER_MASTER( 3009): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2945 is paused
06-01 14:34:21.091+0900 D/DATA_PROVIDER_MASTER( 3009): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-01 14:34:21.101+0900 I/CAPI_WIDGET_APPLICATION( 3084): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-01 14:34:21.101+0900 I/CAPI_WIDGET_APPLICATION( 3084): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-01 14:34:21.101+0900 W/AUL     ( 3084): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3084, appid: org.tizen.calendar.widget, status: bg
06-01 14:34:21.101+0900 D/RESOURCED( 2893): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3084, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-01 14:34:21.101+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3084
06-01 14:34:21.101+0900 D/RESOURCED( 2893): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3084, appname = org.tizen.calendar.widget
06-01 14:34:21.101+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3084
06-01 14:34:21.111+0900 D/AUL_AMD ( 2858): amd_launch.c: __e17_status_handler(2891) > pid(11043) status(3)
06-01 14:34:21.111+0900 D/AUL_AMD ( 2858): amd_key.c: _key_ungrab(265) > _key_ungrab, win : c00002
06-01 14:34:21.111+0900 W/AUL_AMD ( 2858): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-01 14:34:21.111+0900 W/AUL_AMD ( 2858): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-01 14:34:21.111+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(456) > pid(11043) status(3)
06-01 14:34:21.111+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(468) > pid(11043) appid(org.example.example) pkgid(org.example.example) status(3)
06-01 14:34:21.111+0900 D/AUL     ( 2858): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-01 14:34:21.111+0900 W/AUL     ( 2858): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 11043, appid: org.example.example, status: fg
06-01 14:34:21.111+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 11043
06-01 14:34:21.111+0900 D/RESOURCED( 2893): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 11043, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-01 14:34:21.111+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 11043
06-01 14:34:21.201+0900 D/RESOURCED( 2893): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 11043, appname = org.example.example, pkgname = org.example.example
06-01 14:34:21.201+0900 D/RESOURCED( 2893): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 11043, appname = org.example.example
06-01 14:34:21.201+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 11043
06-01 14:34:21.201+0900 I/RESOURCED( 2893): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-01 14:34:21.211+0900 I/RESOURCED( 2893): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-01 14:34:21.281+0900 D/APP_CORE(11043): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2e00002 fully_obscured 0
06-01 14:34:21.281+0900 D/APP_CORE(11043): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-01 14:34:21.281+0900 D/APP_CORE(11043): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-01 14:34:21.281+0900 I/APP_CORE(11043): appcore-efl.c: __do_app(496) > [APP 11043] Event: RESUME State: CREATED
06-01 14:34:21.281+0900 D/LAUNCH  (11043): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-01 14:34:21.281+0900 D/APP_CORE(11043): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-01 14:34:21.281+0900 D/APP_CORE(11043): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-01 14:34:21.281+0900 D/APP_CORE(11043): appcore-efl.c: __do_app(607) > [APP 11043] RESUME
06-01 14:34:21.281+0900 I/APP_CORE(11043): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-01 14:34:21.281+0900 I/APP_CORE(11043): appcore-efl.c: __do_app(614) > [APP 11043] Initial Launching, call the resume_cb
06-01 14:34:21.281+0900 I/CAPI_APPFW_APPLICATION(11043): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-01 14:34:21.281+0900 D/LAUNCH  (11043): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-01 14:34:21.281+0900 D/LAUNCH  (11043): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-01 14:34:21.281+0900 D/APP_CORE(11043): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-01 14:34:21.281+0900 E/APP_CORE(11043): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-01 14:34:21.461+0900 D/AUL_AMD ( 2858): amd_launch.c: __e17_status_handler(2910) > pid(11043) status(0)
06-01 14:34:21.591+0900 D/AUL_PAD ( 3003): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-01 14:34:21.591+0900 D/AUL_PAD (11255): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-01 14:34:21.601+0900 D/AUL_PAD ( 3003): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-01 14:34:21.601+0900 E/RESOURCED( 2893): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.944
06-01 14:34:22.091+0900 D/AUL_AMD ( 2858): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-01 14:34:22.101+0900 D/RUA     ( 2858): rua.c: rua_add_history(179) > rua_add_history start
06-01 14:34:22.201+0900 D/RUA     ( 2858): rua.c: rua_add_history(247) > rua_add_history ok
06-01 14:34:22.641+0900 D/AUL_PAD (11255): launchpad_loader.c: main(588) > sleeping 1 sec...
06-01 14:34:22.641+0900 D/AUL_PAD (11255): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-01 14:34:22.671+0900 D/AUL_PAD (11255): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b7fac760
06-01 14:34:22.671+0900 D/AUL_PAD (11255): preload.h: __preload_init(69) > get pre-initialization function
06-01 14:34:22.671+0900 D/AUL_PAD (11255): preload.h: __preload_init(73) > get shutdown function
06-01 14:34:22.671+0900 D/AUL_PAD (11255): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b7faca40
06-01 14:34:22.701+0900 D/AUL_PAD (11255): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b7fae640
06-01 14:34:22.711+0900 D/AUL_PAD (11255): preload.h: __preload_init(69) > get pre-initialization function
06-01 14:34:22.711+0900 D/AUL_PAD (11255): preload.h: __preload_init(73) > get shutdown function
06-01 14:34:22.711+0900 D/AUL_PAD (11255): preexec.h: __preexec_init(76) > preexec start
06-01 14:34:22.711+0900 D/AUL_PAD (11255): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-01 14:34:22.711+0900 D/AUL     (11255): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-01 14:34:22.711+0900 D/AUL     (11255): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-01 14:34:22.711+0900 D/AUL     (11255): process_pool.c: __connect_to_launchpad(132) > send(11255) : 4
06-01 14:34:22.711+0900 D/AUL     (11255): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-01 14:34:22.711+0900 D/AUL_PAD ( 3003): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-01 14:34:22.711+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-01 14:34:22.711+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 14:34:22.711+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 14:34:22.711+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 14:34:22.711+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 14:34:22.711+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 14:34:22.711+0900 D/AUL_PAD ( 3003): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-01 14:34:22.711+0900 D/AUL_PAD ( 3003): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 11255
06-01 14:34:22.981+0900 D/AUL_PAD (11255): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-01 14:34:22.991+0900 D/AUL_PAD (11255): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-01 14:34:22.991+0900 D/AUL_PAD (11255): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-01 14:34:22.991+0900 D/AUL_PAD (11255): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-01 14:34:26.091+0900 D/APP_CORE( 2945): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
06-01 14:34:26.091+0900 I/APP_CORE( 2945): appcore-efl.c: __do_app(496) > [APP 2945] Event: MEM_FLUSH State: PAUSED
06-01 14:34:26.091+0900 D/APP_CORE( 2945): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
06-01 14:34:26.091+0900 D/APP_CORE( 2945): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2945
06-01 14:34:26.091+0900 D/APP_CORE( 2945): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
06-01 14:34:26.101+0900 D/RESOURCED( 2893): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2945
06-01 14:34:28.111+0900 D/PROCESSMGR( 2741): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002f  register trigger_timer!  pointed_win=0x201440 
06-01 14:34:29.131+0900 D/PROCESSMGR( 2741): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2e00002
06-01 14:34:29.761+0900 D/PROCESSMGR( 2741): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002f  register trigger_timer!  pointed_win=0x201440 
06-01 14:34:29.771+0900 D/AUL_PAD ( 3003): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-01 14:34:29.771+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 14:34:29.771+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 14:34:29.771+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 14:34:29.771+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 14:34:29.771+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 14:34:29.771+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 14:34:29.771+0900 I/AUL_PAD ( 3003): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 11043 pgid = 11043
06-01 14:34:29.771+0900 I/AUL_PAD ( 3003): sigchild.h: __sigchild_action(142) > dead_pid(11043)
06-01 14:34:29.781+0900 E/EFL     ( 2741): eo<2741> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 14:34:29.801+0900 D/AUL_AMD ( 2858): amd_launch.c: __e17_status_handler(2891) > pid(2945) status(3)
06-01 14:34:29.801+0900 D/AUL_AMD ( 2858): amd_key.c: _key_ungrab(265) > _key_ungrab, win : c00002
06-01 14:34:29.801+0900 W/AUL_AMD ( 2858): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-01 14:34:29.801+0900 W/AUL_AMD ( 2858): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-01 14:34:29.801+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(456) > pid(2945) status(3)
06-01 14:34:29.801+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(468) > pid(2945) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(3)
06-01 14:34:29.801+0900 D/AUL     ( 2858): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.tizen.homescreen
06-01 14:34:29.801+0900 W/AUL     ( 2858): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2945, appid: org.tizen.homescreen, status: fg
06-01 14:34:29.811+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2945
06-01 14:34:29.811+0900 D/RESOURCED( 2893): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 2945, appname = org.tizen.homescreen, pkgname = org.tizen.homescreen
06-01 14:34:29.811+0900 D/RESOURCED( 2893): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2945, appname = org.tizen.homescreen
06-01 14:34:29.811+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2945
06-01 14:34:29.811+0900 W/CRASH_MANAGER(11257): worker.c: worker_job(1204) > 1111043657861149629526
