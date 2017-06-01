S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 6873
Date: 2017-06-01 00:28:48+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x20

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000020, esi = 0xb3750c81
ebp = 0xbfb909b8, esp = 0xbfb90950
eax = 0xb91890c0, ebx = 0xb6b460d4
ecx = 0xb91890c0, edx = 0x00000020
eip = 0xb6b241f6

Memory Information
MemTotal:      123 KB
MemFree:        28 KB
Buffers:         4 KB
Cached:     166968 KB
VmPeak:      81152 KB
VmSize:      81152 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16224 KB
VmRSS:       16224 KB
VmData:      20064 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34460 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 6873 TID = 6873
6873 6876 6909 

Maps Information
b2b10000 b2b1a000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b20000 b2b2c000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b2d000 b2b4e000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2b53000 b2b54000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2b55000 b2b5a000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2b5b000 b2b5c000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2b5d000 b2b5f000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2b60000 b2b6c000 r-xp /usr/lib/libdrm.so.2.4.0
b2b6d000 b2b70000 r-xp /usr/lib/libdri2.so.0.0.0
b2b71000 b2b7b000 r-xp /usr/lib/libtbm.so.1.0.0
b2b7c000 b2b91000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2b92000 b2ba4000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b33a6000 b33d7000 r-xp /usr/lib/libidn.so.11.5.44
b33d8000 b33fa000 r-xp /usr/lib/libnghttp2.so.5.4.0
b33fb000 b340b000 r-xp /usr/lib/libcares.so.2.1.0
b340c000 b3415000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3416000 b341f000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3420000 b3497000 r-xp /usr/lib/libcurl.so.4.3.0
b3499000 b34ab000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34ac000 b34cd000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b34d4000 b34d5000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b34d6000 b34d7000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b34d8000 b34db000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b34dc000 b34df000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b35e7000 b35ed000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b35ee000 b3732000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3742000 b3744000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b3745000 b3746000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b3747000 b3752000 r-xp /opt/usr/apps/org.example.example/bin/example
b3754000 b378d000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4190000 b419b000 r-xp /lib/libnss_files-2.20-2014.11.so
b419d000 b41a8000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41aa000 b41c1000 r-xp /lib/libnsl-2.20-2014.11.so
b41c5000 b41cd000 r-xp /lib/libnss_compat-2.20-2014.11.so
b41cf000 b41f3000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b41f4000 b41f5000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b41f6000 b41f9000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b41fa000 b4201000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4202000 b420c000 r-xp /usr/lib/libsensord-share.so
b420d000 b4229000 r-xp /usr/lib/libsensor.so.1.2.0
b422b000 b4234000 r-xp /usr/lib/libappcore-common.so.1.1
b4237000 b4239000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b424e000 b4250000 r-xp /usr/lib/libXau.so.6.0.0
b4251000 b4273000 r-xp /usr/lib/libxcb.so.1.1.0
b4275000 b427e000 r-xp /lib/libcrypt-2.20-2014.11.so
b42a7000 b42a9000 r-xp /usr/lib/libiri.so
b42aa000 b42d0000 r-xp /lib/libexpat.so.1.5.2
b42d2000 b433d000 r-xp /usr/lib/libssl.so.1.0.0
b4343000 b434f000 r-xp /usr/lib/libethumb.so.1.13.0
b4350000 b4354000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4355000 b45a6000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b21000 b5b31000 r-xp /usr/lib/libXi.so.6.1.0
b5b32000 b5b34000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b35000 b5b3b000 r-xp /usr/lib/libXtst.so.6.1.0
b5b3c000 b5b46000 r-xp /usr/lib/libXrender.so.1.3.0
b5b47000 b5b50000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b52000 b5b54000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b55000 b5b5a000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b5b000 b5b6d000 r-xp /usr/lib/libXext.so.6.4.0
b5b6e000 b5b70000 r-xp /usr/lib/libXdamage.so.1.1.0
b5b71000 b5b73000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5b75000 b5cb7000 r-xp /usr/lib/libX11.so.6.3.0
b5cbb000 b5cc5000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cc6000 b5cdc000 r-xp /usr/lib/libudev.so.1.6.0
b5cdf000 b5ce3000 r-xp /lib/libattr.so.1.1.0
b5ce4000 b5d13000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d15000 b5d1b000 r-xp /usr/lib/libffi.so.6.0.2
b5d1c000 b5d3f000 r-xp /lib/libz.so.1.2.8
b5d40000 b5d43000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d44000 b5ea0000 r-xp /usr/lib/libxml2.so.2.9.2
b5ea6000 b5f8d000 r-xp /usr/lib/libstdc++.so.6.0.20
b5f9a000 b5f9d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5f9e000 b5fc0000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5fc1000 b5fd5000 r-xp /lib/libresolv-2.20-2014.11.so
b5fd9000 b5ffd000 r-xp /usr/lib/liblzma.so.5.0.3
b5ffe000 b6000000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6002000 b600c000 r-xp /usr/lib/libembryo.so.1.13.0
b600d000 b6036000 r-xp /usr/lib/libpng12.so.0.50.0
b6037000 b6080000 r-xp /usr/lib/libjpeg.so.8.0.2
b6091000 b6098000 r-xp /lib/librt-2.20-2014.11.so
b609a000 b60b9000 r-xp /usr/lib/libector.so.1.13.0
b60bc000 b60e9000 r-xp /usr/lib/liblua-5.1.so
b60ea000 b617a000 r-xp /usr/lib/libfreetype.so.6.11.3
b617e000 b61bc000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61bd000 b61d3000 r-xp /usr/lib/libfribidi.so.0.3.1
b61d4000 b622d000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6230000 b627b000 r-xp /lib/libm-2.20-2014.11.so
b627d000 b628f000 r-xp /usr/lib/libeio.so.1.13.0
b6290000 b6293000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6294000 b629a000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b629b000 b62be000 r-xp /usr/lib/libefreet.so.1.13.0
b62c1000 b62ec000 r-xp /usr/lib/libeldbus.so.1.13.0
b62ed000 b6321000 r-xp /usr/lib/libecore_con.so.1.13.0
b6323000 b632c000 r-xp /usr/lib/libecore_imf.so.1.13.0
b632d000 b6336000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6337000 b634a000 r-xp /usr/lib/libeo.so.1.13.0
b634c000 b635f000 r-xp /usr/lib/libecore_input.so.1.13.0
b6360000 b6367000 r-xp /usr/lib/libecore_file.so.1.13.0
b6368000 b638b000 r-xp /usr/lib/libecore_evas.so.1.13.0
b638c000 b63b8000 r-xp /usr/lib/libeet.so.1.13.0
b63c1000 b642c000 r-xp /usr/lib/libeina.so.1.13.0
b642f000 b6446000 r-xp /usr/lib/libefl.so.1.13.0
b6448000 b65af000 r-xp /usr/lib/libicuuc.so.51.1
b65bd000 b67c9000 r-xp /usr/lib/libicui18n.so.51.1
b67d1000 b6820000 r-xp /usr/lib/libecore_x.so.1.13.0
b6822000 b683c000 r-xp /lib/libgcc_s-4.9.so.1
b683e000 b6842000 r-xp /lib/libcap.so.2.21
b6843000 b6889000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b688a000 b6891000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6893000 b68e5000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b68e7000 b6a72000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6a77000 b6b45000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b48000 b6b4c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b4d000 b6b5c000 r-xp /usr/lib/libvconf.so.0.2.45
b6b5d000 b6b60000 r-xp /usr/lib/libvasum.so.0.3.1
b6b61000 b6b64000 r-xp /usr/lib/libttrace.so.1.1
b6b66000 b6b6a000 r-xp /usr/lib/libiniparser.so.0
b6b6b000 b6b9b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6b9c000 b6ba5000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6ba6000 b6bcb000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bcc000 b6bdc000 r-xp /usr/lib/libunwind.so.8.0.1
b6be6000 b6d94000 r-xp /lib/libc-2.20-2014.11.so
b6d9c000 b6edf000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6ee1000 b6f39000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f3a000 b6f6e000 r-xp /usr/lib/libsystemd.so.0.4.0
b6f71000 b7045000 r-xp /usr/lib/libedje.so.1.13.0
b7048000 b7074000 r-xp /usr/lib/libecore.so.1.13.0
b7085000 b72ab000 r-xp /usr/lib/libevas.so.1.13.0
b72d3000 b72eb000 r-xp /lib/libpthread-2.20-2014.11.so
b72ef000 b7669000 r-xp /usr/lib/libelementary.so.1.13.0
b7689000 b768d000 r-xp /usr/lib/libsmack.so.1.0.0
b768e000 b7697000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7698000 b769b000 r-xp /usr/lib/libdlog.so.0.0.0
b769c000 b76a1000 r-xp /usr/lib/libbundle.so.0.1.22
b76a2000 b76a5000 r-xp /lib/libdl-2.20-2014.11.so
b76a7000 b76cc000 r-xp /usr/lib/libaul.so.0.1.0
b76cf000 b76d1000 r-xp /usr/lib/libappsvc.so.0.1.0
b76d2000 b76d7000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b76d8000 b76df000 r-xp /usr/lib/libappcore-efl.so.1.1
b76e1000 b76e6000 r-xp /usr/lib/libsys-assert.so
b76e9000 b76ea000 r-xp [vdso]
b76ea000 b770c000 r-xp /lib/ld-2.20-2014.11.so
b770e000 b7716000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:6873)
Call Stack Count: 10
 0: (0xb6b241f6) [/usr/lib/libsqlite3.so.0] + 0xad1f6
 1: init_db + 0x13f (0xb374f8df) [/opt/usr/apps/org.example.example/bin/example] + 0x88df
 2: create_base_gui + 0xbfd (0xb374f6ed) [/opt/usr/apps/org.example.example/bin/example] + 0x86ed
 3: app_create + 0x2c (0xb374e95c) [/opt/usr/apps/org.example.example/bin/example] + 0x795c
 4: (0xb76d465b) [/usr/lib/libcapi-appfw-application.so.0] + 0x265b
 5: appcore_efl_main + 0x327 (0xb76dbc27) [/usr/lib/libappcore-efl.so.1] + 0x3c27
 6: ui_app_main + 0x140 (0xb76d4c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
 7: main + 0x2a5 (0xb374e8d5) [/opt/usr/apps/org.example.example/bin/example] + 0x78d5
 8: (0xb7710148) [/opt/usr/apps/org.example.example/bin/example] + 0xb7710148
 9: __libc_start_main + 0xde (0xb6bfde4e) [/lib/libc.so.6] + 0x17e4e
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
8:41.347+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 00:28:41.347+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:28:41.347+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.videos] Name[Video] Icon[/usr/share/icons/default/small/org.tizen.videos.png] enable[1] system[1]
06-01 00:28:41.347+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.videos'], count[0]
06-01 00:28:41.347+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.videos][-17956860][0]
06-01 00:28:41.347+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.videos]
06-01 00:28:41.347+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Video] pos[1, 5] pageId[100001]
06-01 00:28:41.347+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[12]
06-01 00:28:41.347+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[17], [1, 5]
06-01 00:28:41.347+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 00:28:41.347+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:28:41.347+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: RearrangeItems(243) >  view type [1]
06-01 00:28:41.487+0900 D/rpm-installer( 6803): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
06-01 00:28:41.487+0900 D/rpm-installer( 6803): rpm-appcore-intf.c: main(259) > ------------------------------------------------
06-01 00:28:41.487+0900 D/rpm-installer( 6803): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
06-01 00:28:41.487+0900 D/rpm-installer( 6803): rpm-appcore-intf.c: main(261) > ------------------------------------------------
06-01 00:28:41.497+0900 D/PKGMGR_SERVER( 6789): pkgmgr-server.c: sighandler(387) > child exit [6803]
06-01 00:28:41.497+0900 E/PKGMGR_SERVER( 6789): pkgmgr-server.c: sighandler(402) > child NORMAL exit [6803]
06-01 00:28:41.997+0900 E/PKGMGR_SERVER( 6789): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-01 00:28:41.997+0900 E/PKGMGR_SERVER( 6789): pkgmgr-server.c: main(2265) > package manager server terminated.
06-01 00:28:42.397+0900 D/AUL_AMD ( 2773): amd_request.c: __request_handler(838) > __request_handler: 0
06-01 00:28:42.397+0900 D/AUL_AMD ( 2773): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-01 00:28:42.407+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 00:28:42.407+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 00:28:42.407+0900 I/AUL     ( 2773): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
06-01 00:28:42.407+0900 D/AUL     ( 2773): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 6856, pid = 6858
06-01 00:28:42.407+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 00:28:42.407+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 00:28:42.407+0900 I/AUL     ( 2773): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
06-01 00:28:42.407+0900 E/AUL_AMD ( 2773): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-01 00:28:42.407+0900 W/AUL_AMD ( 2773): amd_launch.c: _start_app(2233) > caller pid : 6858
06-01 00:28:42.407+0900 E/AUL_AMD ( 2773): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-01 00:28:42.407+0900 W/AUL_AMD ( 2773): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-01 00:28:42.407+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2648) > process_pool: false
06-01 00:28:42.407+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-01 00:28:42.407+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-01 00:28:42.407+0900 W/AUL_AMD ( 2773): amd_launch.c: _start_app(2665) > pad pid(-5)
06-01 00:28:42.407+0900 D/AUL_AMD ( 2773): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-01 00:28:42.407+0900 D/AUL_AMD ( 2773): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-01 00:28:42.407+0900 D/AUL     ( 2773): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-01 00:28:42.417+0900 D/AUL_PAD ( 2951): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-01 00:28:42.417+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 00:28:42.417+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 00:28:42.417+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 00:28:42.417+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 00:28:42.417+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 00:28:42.417+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 00:28:42.417+0900 D/AUL_PAD ( 2951): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-01 00:28:42.417+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-01 00:28:42.417+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-01 00:28:42.417+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-01 00:28:42.417+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-01 00:28:42.417+0900 D/AUL_PAD ( 2951): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-01 00:28:42.417+0900 D/AUL_PAD ( 2951): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-01 00:28:42.417+0900 W/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-01 00:28:42.417+0900 D/AUL     ( 2951): process_pool.c: __send_pkt_raw_data(219) > send(11) : 620 / 620
06-01 00:28:42.417+0900 D/AUL_PAD ( 2951): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 6667, bin path: /opt/usr/apps/org.example.example/bin/example
06-01 00:28:42.417+0900 W/AUL_PAD ( 2951): launchpad.c: __send_result_to_caller(265) > Check app launching
06-01 00:28:42.417+0900 D/AUL_PAD ( 2951): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-01 00:28:42.417+0900 D/AUL_PAD ( 6667): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-01 00:28:42.417+0900 D/AUL_PAD ( 6667): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
06-01 00:28:42.417+0900 D/AUL_PAD ( 6667): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-01 00:28:42.417+0900 D/AUL_PAD ( 6667): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-01 00:28:42.417+0900 D/AUL_PAD ( 6667): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-01 00:28:42.417+0900 D/AUL_PAD ( 6667): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-01 00:28:42.417+0900 D/AUL     ( 6667): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (6670) is sent.
06-01 00:28:42.417+0900 D/AUL     ( 6667): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 6670, signo: 10
06-01 00:28:42.417+0900 D/AUL     ( 6667): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-01 00:28:42.417+0900 D/AUL_PAD ( 6667): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-01 00:28:42.417+0900 D/AUL_PAD ( 6667): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-01 00:28:42.417+0900 D/AUL_PAD ( 6667): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-01 00:28:42.417+0900 D/AUL_PAD ( 6667): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-01 00:28:42.417+0900 D/AUL_PAD ( 6667): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTYyNDQ1MjIvNDA2MzMxAA==##
06-01 00:28:42.417+0900 D/AUL_PAD ( 6667): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-01 00:28:42.417+0900 D/AUL_PAD ( 6667): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA2ODU4AA==##
06-01 00:28:42.417+0900 D/AUL_PAD ( 6667): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-01 00:28:42.417+0900 D/AUL_PAD ( 6667): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-01 00:28:42.417+0900 D/AUL_PAD ( 6667): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-01 00:28:42.417+0900 D/AUL_PAD ( 6667): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-01 00:28:42.417+0900 D/AUL_PAD ( 6667): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-01 00:28:42.427+0900 I/CAPI_APPFW_APPLICATION( 6667): app_main.c: ui_app_main(788) > app_efl_main
06-01 00:28:42.427+0900 D/LAUNCH  ( 6667): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-01 00:28:42.427+0900 D/APP_CORE( 6667): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-01 00:28:42.427+0900 D/APP_CORE( 6667): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-01 00:28:42.427+0900 D/APP_CORE( 6667): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-01 00:28:42.427+0900 D/RESOURCED( 2886): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-01 00:28:42.427+0900 D/RESOURCED( 2886): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-01 00:28:42.427+0900 E/RESOURCED( 2886): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-01 00:28:42.437+0900 D/APP_CORE( 6667): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-01 00:28:42.447+0900 D/AUL     ( 6667): app_sock.c: __create_server_sock(156) > pg path - already exists
06-01 00:28:42.447+0900 D/APP_CORE( 6667): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb4283520
06-01 00:28:42.447+0900 D/LAUNCH  ( 6667): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-01 00:28:42.447+0900 I/CAPI_APPFW_APPLICATION( 6667): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-01 00:28:42.517+0900 D/AUL_PAD ( 2951): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-01 00:28:42.517+0900 W/AUL     ( 2773): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 6667, appid: org.example.example
06-01 00:28:42.517+0900 D/AUL     ( 2773): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-01 00:28:42.517+0900 E/AUL     ( 2773): simple_util.c: __trm_app_info_send_socket(330) > access
06-01 00:28:42.517+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2700) > add app group info
06-01 00:28:42.517+0900 E/AUL     ( 2773): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-01 00:28:42.517+0900 D/AUL_AMD ( 2773): amd_status.c: _status_add_app_info_list(427) > pid(6667) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-01 00:28:42.527+0900 D/RESOURCED( 2886): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 6667
06-01 00:28:42.527+0900 D/RESOURCED( 2886): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-01 00:28:42.527+0900 E/RESOURCED( 2886): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-01 00:28:42.527+0900 D/RESOURCED( 2886): proc-main.c: resourced_proc_status_change(888) > available memory = 299
06-01 00:28:42.537+0900 I/user_tag0( 6667): /opt/usr/apps/org.example.example/data/test.db
06-01 00:28:42.627+0900 W/CRASH_MANAGER( 6863): worker.c: worker_job(1204) > 11066676578611496244522
06-01 00:28:43.517+0900 D/AUL_PAD ( 2951): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-01 00:28:43.527+0900 D/AUL_PAD ( 6873): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-01 00:28:43.527+0900 D/AUL_AMD ( 2773): amd_launch.c: __grab_timeout_handler(1445) > pid(6667) ecore_x_pointer_ungrab
06-01 00:28:43.527+0900 D/AUL_AMD ( 2773): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-01 00:28:43.527+0900 W/AUL_AMD ( 2773): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-01 00:28:43.527+0900 W/AUL_AMD ( 2773): amd_launch.c: __grab_timeout_handler(1447) > back key ungrab error
06-01 00:28:43.547+0900 D/AUL_PAD ( 2951): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-01 00:28:43.547+0900 D/AUL_PAD ( 2951): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-01 00:28:43.547+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 00:28:43.547+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 00:28:43.547+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 00:28:43.547+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 00:28:43.547+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 00:28:43.547+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 00:28:43.547+0900 I/AUL_PAD ( 2951): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 6667 pgid = 6667
06-01 00:28:43.547+0900 I/AUL_PAD ( 2951): sigchild.h: __sigchild_action(142) > dead_pid(6667)
06-01 00:28:43.557+0900 E/RESOURCED( 2886): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.444
06-01 00:28:43.567+0900 D/AUL_PAD ( 2951): sigchild.h: __send_app_dead_signal(90) > send dead signal done
06-01 00:28:43.567+0900 D/STARTER ( 2883): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 6667 is termianted
06-01 00:28:43.567+0900 D/STARTER ( 2883): starter.c: _check_dead_signal(202) > [_check_dead_signal:202] Unknown process, ignore it
06-01 00:28:43.567+0900 W/AUL_AMD ( 2773): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 6667
06-01 00:28:43.567+0900 W/AUL_AMD ( 2773): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 6667
06-01 00:28:43.567+0900 D/AUL_AMD ( 2773): amd_key.c: _unregister_key_event(179) > ===key stack===
06-01 00:28:43.567+0900 E/AUL_AMD ( 2773): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
06-01 00:28:43.567+0900 D/AUL_AMD ( 2773): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.example.example)
06-01 00:28:43.567+0900 D/AUL     ( 2773): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-01 00:28:43.567+0900 E/AUL     ( 2773): simple_util.c: __trm_app_info_send_socket(330) > access
06-01 00:28:43.567+0900 I/ESD     ( 2964): esd_main.c: __esd_app_dead_handler(1771) > pid: 6667
06-01 00:28:43.567+0900 I/AUL_PAD ( 2951): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
06-01 00:28:43.577+0900 I/AUL_PAD ( 2951): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
06-01 00:28:43.577+0900 E/AUL_PAD ( 2951): launchpad.c: main(688) > error reading sigchld info
06-01 00:28:43.577+0900 E/RESOURCED( 2886): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.445
06-01 00:28:43.577+0900 D/RESOURCED( 2886): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 6667
06-01 00:28:43.577+0900 D/RESOURCED( 2886): appinfo-list.c: resourced_appinfo_put(132) > appid org.example.example, pkgname = org.example.example, ref = 0
06-01 00:28:44.027+0900 D/AUL_AMD ( 2773): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-01 00:28:44.027+0900 D/RUA     ( 2773): rua.c: rua_add_history(179) > rua_add_history start
06-01 00:28:44.037+0900 D/RUA     ( 2773): rua.c: rua_add_history(247) > rua_add_history ok
06-01 00:28:44.397+0900 E/VCONF   ( 6863): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
06-01 00:28:44.397+0900 E/VCONF   ( 6863): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
06-01 00:28:44.397+0900 E/VCONF   ( 6863): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
06-01 00:28:44.397+0900 E/VCONF   ( 6863): vconf.c: vconf_get_str(2891) > vconf_get_str(6863) : db/menu_widget/language error
06-01 00:28:44.397+0900 E/PKGMGR_INFO( 6863): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
06-01 00:28:44.397+0900 D/PKGMGR_INFO( 6863): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3502) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 00:28:44.407+0900 D/PKGMGR_INFO( 6863): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3508) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='No Locale' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 00:28:44.477+0900 E/VCONF   ( 6863): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
06-01 00:28:44.477+0900 E/VCONF   ( 6863): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
06-01 00:28:44.477+0900 E/VCONF   ( 6863): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
06-01 00:28:44.477+0900 E/VCONF   ( 6863): vconf.c: vconf_get_str(2891) > vconf_get_str(6863) : db/menu_widget/language error
06-01 00:28:44.477+0900 E/PKGMGR_INFO( 6863): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
06-01 00:28:44.477+0900 D/PKGMGR_INFO( 6863): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 00:28:44.477+0900 D/PKGMGR_INFO( 6863): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 00:28:44.537+0900 E/VCONF   ( 6863): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
06-01 00:28:44.537+0900 E/VCONF   ( 6863): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
06-01 00:28:44.537+0900 E/VCONF   ( 6863): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
06-01 00:28:44.537+0900 E/VCONF   ( 6863): vconf.c: vconf_get_str(2891) > vconf_get_str(6863) : db/menu_widget/language error
06-01 00:28:44.537+0900 E/PKGMGR_INFO( 6863): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
06-01 00:28:44.537+0900 D/PKGMGR_INFO( 6863): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 00:28:44.537+0900 D/PKGMGR_INFO( 6863): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 00:28:44.617+0900 D/AUL_PAD ( 6873): launchpad_loader.c: main(588) > sleeping 1 sec...
06-01 00:28:44.617+0900 D/AUL_PAD ( 6873): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-01 00:28:44.617+0900 D/AUL_PAD ( 6873): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b8fec760
06-01 00:28:44.617+0900 D/AUL_PAD ( 6873): preload.h: __preload_init(69) > get pre-initialization function
06-01 00:28:44.617+0900 D/AUL_PAD ( 6873): preload.h: __preload_init(73) > get shutdown function
06-01 00:28:44.617+0900 D/AUL_PAD ( 6873): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b8feca40
06-01 00:28:44.627+0900 E/VCONF   ( 6863): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
06-01 00:28:44.627+0900 E/VCONF   ( 6863): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
06-01 00:28:44.627+0900 E/VCONF   ( 6863): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
06-01 00:28:44.627+0900 E/VCONF   ( 6863): vconf.c: vconf_get_str(2891) > vconf_get_str(6863) : db/menu_widget/language error
06-01 00:28:44.627+0900 E/PKGMGR_INFO( 6863): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
06-01 00:28:44.627+0900 D/AUL_PAD ( 6873): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b8fee640
06-01 00:28:44.627+0900 D/AUL_PAD ( 6873): preload.h: __preload_init(69) > get pre-initialization function
06-01 00:28:44.627+0900 D/AUL_PAD ( 6873): preload.h: __preload_init(73) > get shutdown function
06-01 00:28:44.627+0900 D/AUL_PAD ( 6873): preexec.h: __preexec_init(76) > preexec start
06-01 00:28:44.627+0900 D/AUL_PAD ( 6873): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-01 00:28:44.627+0900 D/AUL     ( 6873): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-01 00:28:44.627+0900 D/AUL     ( 6873): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-01 00:28:44.627+0900 D/AUL     ( 6873): process_pool.c: __connect_to_launchpad(132) > send(6873) : 4
06-01 00:28:44.627+0900 D/AUL     ( 6873): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-01 00:28:44.627+0900 D/AUL_PAD ( 2951): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-01 00:28:44.627+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-01 00:28:44.627+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 00:28:44.627+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 00:28:44.627+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 00:28:44.627+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 00:28:44.627+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 00:28:44.627+0900 D/AUL_PAD ( 2951): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-01 00:28:44.627+0900 D/AUL_PAD ( 2951): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 6873
06-01 00:28:44.807+0900 D/AUL_PAD ( 6873): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-01 00:28:44.817+0900 D/AUL_PAD ( 6873): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-01 00:28:44.817+0900 D/AUL_PAD ( 6873): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-01 00:28:44.827+0900 D/AUL_PAD ( 6873): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-01 00:28:45.477+0900 D/LAUNCH  ( 6877): appcore-efl.c: appcore_efl_main(1692) > [crash-popup:Application:main:done]
06-01 00:28:45.477+0900 D/PKGMGR_INFO( 6877): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.crash-popup/bin/crash-popup' and package_app_info.app_disable IN ('false','False')
06-01 00:28:45.477+0900 D/PKGMGR_INFO( 6877): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.crash-popup/bin/crash-popup' and package_app_info.app_disable IN ('false','False')
06-01 00:28:45.477+0900 D/AUL     ( 6877): pkginfo.c: aul_app_get_appid_bypid(241) > [SECURE_LOG] appid for 6877 is org.tizen.crash-popup
06-01 00:28:45.657+0900 D/APP_CORE( 6877): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-01 00:28:45.657+0900 D/APP_CORE( 6877): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /usr/apps/org.tizen.crash-popup/res/locale
06-01 00:28:45.657+0900 D/APP_CORE( 6877): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-01 00:28:45.677+0900 D/APP_CORE( 6877): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-01 00:28:45.677+0900 D/APP_CORE( 6877): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb775e520
06-01 00:28:45.677+0900 D/LAUNCH  ( 6877): appcore-efl.c: __before_loop(1136) > [crash-popup:Platform:appcore_init:done]
06-01 00:28:45.777+0900 D/APP_CORE( 6877): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-01 00:28:45.797+0900 D/LAUNCH  ( 6877): appcore-efl.c: __before_loop(1154) > [crash-popup:Application:create:done]
06-01 00:28:45.797+0900 D/APP_CORE( 6877): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-01 00:28:45.947+0900 E/RESOURCED( 2886): heart-abnormal.c: heart_abnormal_process_crashed(77) > Failed: dbus_message_get_args()
06-01 00:28:47.527+0900 D/AUL_AMD ( 2773): amd_status.c: _status_update_app_info_list(456) > pid(6667) status(4)
06-01 00:28:48.397+0900 D/test-log( 2904): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1023) >  menu box Pick touched
06-01 00:28:48.397+0900 D/test-log( 2904): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1034) >  Long Tap Timer Start
06-01 00:28:48.607+0900 D/test-log( 2904): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1194) >  Box[0] pick ended by Up
06-01 00:28:48.617+0900 D/test-log( 2904): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1199) >  Cancel Long Tap Timer
06-01 00:28:48.617+0900 D/test-log( 2904): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1240) >  app launch state[1]
06-01 00:28:48.617+0900 D/test-log( 2904): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1249) >  touch is moved upper position!!!
06-01 00:28:48.617+0900 D/test-log( 2904): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1298) >  laundch!!!!! touch position is moved from[637.00][389.00] to[637.00][389.00]!
06-01 00:28:48.617+0900 D/cluster-view( 2904): homescreen-view-manager.cpp: IsOverScrollThreshold(997) >  is Over Scrollview TreshHold?[0]
06-01 00:28:48.617+0900 D/cluster-home( 2904): mainmenu-custom-box-impl.cpp: OnClicked(171) >  [24]MenuBox clicked
06-01 00:28:48.627+0900 D/PROCESSMGR( 2798): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002e  register trigger_timer!  pointed_win=0x40004e 
06-01 00:28:48.647+0900 D/cluster-home( 2904): mainmenu-custom-box-impl.cpp: OnClicked(184) >  launch application via service(operation APP_CONTROL_OPERATION_DEFAULT)
06-01 00:28:48.647+0900 D/AUL     ( 2904): service.c: __set_bundle(186) > __set_bundle
06-01 00:28:48.657+0900 D/AUL     ( 2904): service.c: __get_alias_appid(548) > [SECURE_LOG] alias_id : (null)
06-01 00:28:48.657+0900 D/AUL     ( 2904): service.c: __set_bundle(186) > __set_bundle
06-01 00:28:48.657+0900 D/AUL     ( 2904): service.c: __run_svc_with_pkgname(276) > [SECURE_LOG] pkg_name : org.example.example - no result
06-01 00:28:48.657+0900 D/AUL     ( 2904): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : org.example.example
06-01 00:28:48.667+0900 D/AUL     ( 2904): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(0)
06-01 00:28:48.697+0900 D/AUL_AMD ( 2773): amd_request.c: __request_handler(838) > __request_handler: 0
06-01 00:28:48.707+0900 D/AUL_AMD ( 2773): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-01 00:28:48.707+0900 W/AUL_AMD ( 2773): amd_launch.c: _start_app(2231) > [SECURE_LOG] caller appid : org.tizen.homescreen
06-01 00:28:48.707+0900 W/AUL_AMD ( 2773): amd_launch.c: _start_app(2233) > caller pid : 2904
06-01 00:28:48.727+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2443) > win(a00002) ecore_x_pointer_grab(1)
06-01 00:28:48.727+0900 D/AUL_AMD ( 2773): amd_key.c: _key_grab(243) > _key_grab, win : a00002
06-01 00:28:48.737+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2448) > back key grab
06-01 00:28:48.737+0900 W/AUL_AMD ( 2773): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-01 00:28:48.737+0900 D/RESOURCED( 2886): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-01 00:28:48.737+0900 D/RESOURCED( 2886): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-01 00:28:48.737+0900 E/RESOURCED( 2886): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-01 00:28:48.747+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2518) > org.tizen.system.deviced.PmQos-AppLaunch : 0
06-01 00:28:48.747+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2648) > process_pool: false
06-01 00:28:48.747+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-01 00:28:48.757+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-01 00:28:48.757+0900 W/AUL_AMD ( 2773): amd_launch.c: _start_app(2665) > pad pid(-5)
06-01 00:28:48.757+0900 D/AUL_AMD ( 2773): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-01 00:28:48.757+0900 D/AUL_AMD ( 2773): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-01 00:28:48.757+0900 D/AUL     ( 2773): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-01 00:28:48.757+0900 D/AUL_PAD ( 2951): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-01 00:28:48.757+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 00:28:48.757+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 00:28:48.757+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 00:28:48.757+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 00:28:48.757+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 00:28:48.757+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 00:28:48.757+0900 D/AUL_PAD ( 2951): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-01 00:28:48.757+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-01 00:28:48.757+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-01 00:28:48.757+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-01 00:28:48.757+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-01 00:28:48.757+0900 D/AUL_PAD ( 2951): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-01 00:28:48.757+0900 D/AUL_PAD ( 2951): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-01 00:28:48.757+0900 W/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-01 00:28:48.757+0900 D/AUL     ( 2951): process_pool.c: __send_pkt_raw_data(219) > send(11) : 884 / 884
06-01 00:28:48.757+0900 D/AUL_PAD ( 2951): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 6873, bin path: /opt/usr/apps/org.example.example/bin/example
06-01 00:28:48.757+0900 W/AUL_PAD ( 2951): launchpad.c: __send_result_to_caller(265) > Check app launching
06-01 00:28:48.757+0900 D/AUL_PAD ( 2951): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-01 00:28:48.757+0900 D/AUL_PAD ( 6873): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-01 00:28:48.757+0900 D/AUL_PAD ( 6873): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 884, pkt->len: 876
06-01 00:28:48.757+0900 D/AUL_PAD ( 6873): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-01 00:28:48.757+0900 D/AUL_PAD ( 6873): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-01 00:28:48.757+0900 D/AUL_PAD ( 6873): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-01 00:28:48.757+0900 D/AUL_PAD ( 6873): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-01 00:28:48.757+0900 D/AUL     ( 6873): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (6876) is sent.
06-01 00:28:48.757+0900 D/AUL     ( 6873): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 6876, signo: 10
06-01 00:28:48.767+0900 D/AUL     ( 6873): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-01 00:28:48.767+0900 D/AUL_PAD ( 6873): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-01 00:28:48.767+0900 D/AUL_PAD ( 6873): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-01 00:28:48.767+0900 D/AUL_PAD ( 6873): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-01 00:28:48.767+0900 D/AUL_PAD ( 6873): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
06-01 00:28:48.767+0900 D/AUL_PAD ( 6873): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : UgAAAAEEAAAUAAAAX19BUFBfU1ZDX09QX1RZUEVfXwAuAAAAaHR0cDovL3RpemVuLm9yZy9hcHBjb250cm9sL29wZXJhdGlvbi9kZWZhdWx0AA==##
06-01 00:28:48.767+0900 D/AUL_PAD ( 6873): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __APP_SVC_PKG_NAME__##
06-01 00:28:48.767+0900 D/AUL_PAD ( 6873): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : OQAAAAEEAAAVAAAAX19BUFBfU1ZDX1BLR19OQU1FX18AFAAAAG9yZy5leGFtcGxlLmV4YW1wbGUA##
06-01 00:28:48.767+0900 D/AUL_PAD ( 6873): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_STARTTIME__##
06-01 00:28:48.767+0900 D/AUL_PAD ( 6873): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTYyNDQ1MjgvNjY2MzgxAA==##
06-01 00:28:48.767+0900 D/AUL_PAD ( 6873): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 8 : __AUL_CALLER_PID__##
06-01 00:28:48.767+0900 D/AUL_PAD ( 6873): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 9 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAAyOTA0AA==##
06-01 00:28:48.767+0900 D/AUL_PAD ( 6873): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 10 : __AUL_CALLER_APPID__##
06-01 00:28:48.767+0900 D/AUL_PAD ( 6873): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 11 : OgAAAAEEAAAVAAAAX19BVUxfQ0FMTEVSX0FQUElEX18AFQAAAG9yZy50aXplbi5ob21lc2NyZWVuAA==##
06-01 00:28:48.767+0900 D/AUL_PAD ( 6873): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 12 : __AUL_INTERNAL_POOL__##
06-01 00:28:48.767+0900 D/AUL_PAD ( 6873): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 13 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-01 00:28:48.767+0900 D/AUL_PAD ( 6873): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 14
06-01 00:28:48.767+0900 D/AUL_PAD ( 6873): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-01 00:28:48.767+0900 D/AUL_PAD ( 6873): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-01 00:28:48.767+0900 I/CAPI_APPFW_APPLICATION( 6873): app_main.c: ui_app_main(788) > app_efl_main
06-01 00:28:48.767+0900 D/LAUNCH  ( 6873): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-01 00:28:48.767+0900 D/APP_CORE( 6873): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-01 00:28:48.767+0900 D/APP_CORE( 6873): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-01 00:28:48.767+0900 D/APP_CORE( 6873): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-01 00:28:48.797+0900 D/APP_CORE( 6873): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-01 00:28:48.797+0900 D/AUL     ( 6873): app_sock.c: __create_server_sock(156) > pg path - already exists
06-01 00:28:48.797+0900 D/APP_CORE( 6873): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb4234520
06-01 00:28:48.797+0900 D/LAUNCH  ( 6873): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-01 00:28:48.797+0900 I/CAPI_APPFW_APPLICATION( 6873): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-01 00:28:48.827+0900 E/EFL     ( 6877): eldbus<6877> lib/eldbus/eldbus_core.c:1005 _connection_get() Error connecting to bus of type 1. error name: org.freedesktop.DBus.Error.NoServer error message: Failed to connect to socket /tmp/dbus-gYh1XIjk7A: Connection refused
06-01 00:28:48.827+0900 E/EFL     ( 6877): <6877> lib/eldbus/eldbus_core.c:1068 eldbus_connection_get() safety check failed: conn == NULL
06-01 00:28:48.827+0900 E/EFL     ( 6877): elementary<6877> elm_atspi_bridge.c:4750 _elm_atspi_bridge_eo_base_constructor() Unable to connect to Session Bus
06-01 00:28:48.827+0900 D/APP_CORE( 6877): appcore.c: __aul_handler(587) > [APP 6877]     AUL event: AUL_START
06-01 00:28:48.827+0900 I/APP_CORE( 6877): appcore-efl.c: __do_app(496) > [APP 6877] Event: RESET State: CREATED
06-01 00:28:48.827+0900 D/APP_CORE( 6877): appcore-efl.c: __do_app(527) > [APP 6877] RESET
06-01 00:28:48.827+0900 D/LAUNCH  ( 6877): appcore-efl.c: __do_app(529) > [crash-popup:Application:reset:start]
06-01 00:28:48.827+0900 D/APP_CORE( 6877): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-01 00:28:48.827+0900 D/APP_CORE( 6877): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-01 00:28:48.827+0900 E/SYSPOPUP( 6877): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
06-01 00:28:48.827+0900 E/SYSPOPUP( 6877): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
06-01 00:28:48.827+0900 E/SYSPOPUP( 6877): syspopup_efl.c: syspopup_create(95) > popup_name or handler is NULL
06-01 00:28:48.827+0900 D/LAUNCH  ( 6877): appcore-efl.c: __do_app(544) > [crash-popup:Application:reset:done]
06-01 00:28:48.827+0900 D/APP_CORE( 6877): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-01 00:28:48.857+0900 D/AUL_PAD ( 2951): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-01 00:28:48.857+0900 W/AUL     ( 2773): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 6873, appid: org.example.example
06-01 00:28:48.857+0900 D/AUL     ( 2773): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-01 00:28:48.857+0900 E/AUL     ( 2773): simple_util.c: __trm_app_info_send_socket(330) > access
06-01 00:28:48.857+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2700) > add app group info
06-01 00:28:48.857+0900 E/AUL     ( 2773): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-01 00:28:48.857+0900 D/RESOURCED( 2886): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 6873
06-01 00:28:48.857+0900 D/RESOURCED( 2886): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-01 00:28:48.857+0900 E/RESOURCED( 2886): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-01 00:28:48.867+0900 D/AUL_AMD ( 2773): amd_status.c: _status_add_app_info_list(427) > pid(6873) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-01 00:28:48.867+0900 D/AUL     ( 2904): launch.c: app_request_to_launchpad(425) > launch request result : 6873
06-01 00:28:48.867+0900 E/cluster-home( 2904): mainmenu-custom-box-impl.cpp: OnClicked(202) >  Success to launch [0][org.example.example]
06-01 00:28:48.867+0900 D/test-log( 2904): mainmenu-apps-view-impl.cpp: _OnScrollViewTouched(1592) >  Stop boost timer of Apps view by [1]
06-01 00:28:48.877+0900 D/RESOURCED( 2886): proc-main.c: resourced_proc_status_change(888) > available memory = 289
06-01 00:28:48.897+0900 D/AUL     ( 6877): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-01 00:28:48.897+0900 D/AUL_AMD ( 2773): amd_request.c: __request_handler(838) > __request_handler: 22
06-01 00:28:48.897+0900 W/AUL_AMD ( 2773): amd_request.c: __request_handler(1056) > app status : 5
06-01 00:28:48.897+0900 D/AUL_AMD ( 2773): amd_status.c: _status_update_app_info_list(456) > pid(6877) status(5)
06-01 00:28:48.917+0900 D/APP_CORE( 6877): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
06-01 00:28:48.927+0900 E/EFL     ( 6877): eo<6877> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x8000542b is not pointing to a valid object. Maybe it has already been freed.
06-01 00:28:48.927+0900 E/EFL     ( 6877): eo<6877> lib/eo/eo.c:485 _eo_do_internal() Obj (0x8000542b) is an invalid ref.
06-01 00:28:48.957+0900 I/user_tag0( 6873): /opt/usr/apps/org.example.example/data/test.db
06-01 00:28:48.977+0900 W/CRASH_MANAGER( 6863): worker.c: worker_job(1204) > 1106873657861149624452
