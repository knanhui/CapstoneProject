S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 6158
Date: 2017-06-13 14:52:49+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000000, esi = 0xb88472a0
ebp = 0xbff249f8, esp = 0xbff24990
eax = 0xb88472a0, ebx = 0xb6bbf0d4
ecx = 0xb37cc000, edx = 0x00000000
eip = 0xb6b9d1f6

Memory Information
MemTotal:      123 KB
MemFree:        32 KB
Buffers:         6 KB
Cached:     155952 KB
VmPeak:     129640 KB
VmSize:     126692 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       34260 KB
VmRSS:       31376 KB
VmData:      56616 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34780 KB
VmPTE:         108 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 6158 TID = 6158
6158 6159 6366 6368 6372 

Maps Information
b069e000 b06a5000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b06a6000 b06be000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b06bf000 b06c6000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1083000 b1087000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2b5d000 b2b67000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b6d000 b2b79000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b7a000 b2b9b000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2ba0000 b2ba1000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2ba2000 b2ba7000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2ba8000 b2ba9000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2baa000 b2bac000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2bad000 b2baf000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2bb0000 b2bbc000 r-xp /usr/lib/libdrm.so.2.4.0
b2bbd000 b2bc0000 r-xp /usr/lib/libdri2.so.0.0.0
b2bc1000 b2bcb000 r-xp /usr/lib/libtbm.so.1.0.0
b2bcc000 b2bcd000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b2bce000 b2be3000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2be4000 b2bf6000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b33f8000 b3429000 r-xp /usr/lib/libidn.so.11.5.44
b342a000 b344c000 r-xp /usr/lib/libnghttp2.so.5.4.0
b344d000 b345d000 r-xp /usr/lib/libcares.so.2.1.0
b345e000 b3467000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3468000 b346e000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b346f000 b3485000 r-xp /usr/lib/libalarm.so.0.0.0
b3487000 b3490000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3491000 b3508000 r-xp /usr/lib/libcurl.so.4.3.0
b350a000 b351c000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b351d000 b3520000 r-xp /usr/lib/libcapi-message-port.so.1.2.2.1
b3521000 b3524000 r-xp /usr/lib/libcapi-appfw-alarm.so.0.3.1.0
b3525000 b3546000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b354d000 b354e000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b354f000 b3550000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3551000 b3554000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3555000 b3558000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3660000 b3666000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3667000 b37ab000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37bc000 b37cb000 r-xp /opt/usr/apps/org.example.example/bin/example
b37cd000 b3806000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4209000 b4214000 r-xp /lib/libnss_files-2.20-2014.11.so
b4216000 b4221000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4223000 b423a000 r-xp /lib/libnsl-2.20-2014.11.so
b423e000 b4246000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4248000 b426c000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b426d000 b426e000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b426f000 b4272000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4273000 b427a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b427b000 b4285000 r-xp /usr/lib/libsensord-share.so
b4286000 b42a2000 r-xp /usr/lib/libsensor.so.1.2.0
b42a4000 b42ad000 r-xp /usr/lib/libappcore-common.so.1.1
b42b0000 b42b2000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42c7000 b42c9000 r-xp /usr/lib/libXau.so.6.0.0
b42ca000 b42ec000 r-xp /usr/lib/libxcb.so.1.1.0
b42ee000 b42f7000 r-xp /lib/libcrypt-2.20-2014.11.so
b4320000 b4322000 r-xp /usr/lib/libiri.so
b4323000 b4349000 r-xp /lib/libexpat.so.1.5.2
b434b000 b43b6000 r-xp /usr/lib/libssl.so.1.0.0
b43bc000 b43c8000 r-xp /usr/lib/libethumb.so.1.13.0
b43c9000 b43cd000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43ce000 b461f000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b9a000 b5baa000 r-xp /usr/lib/libXi.so.6.1.0
b5bab000 b5bad000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bae000 b5bb4000 r-xp /usr/lib/libXtst.so.6.1.0
b5bb5000 b5bbf000 r-xp /usr/lib/libXrender.so.1.3.0
b5bc0000 b5bc9000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bcb000 b5bcd000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bce000 b5bd3000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bd4000 b5be6000 r-xp /usr/lib/libXext.so.6.4.0
b5be7000 b5be9000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bea000 b5bec000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bee000 b5d30000 r-xp /usr/lib/libX11.so.6.3.0
b5d34000 b5d3e000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d3f000 b5d55000 r-xp /usr/lib/libudev.so.1.6.0
b5d58000 b5d5c000 r-xp /lib/libattr.so.1.1.0
b5d5d000 b5d8c000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d8e000 b5d94000 r-xp /usr/lib/libffi.so.6.0.2
b5d95000 b5db8000 r-xp /lib/libz.so.1.2.8
b5db9000 b5dbc000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5dbd000 b5f19000 r-xp /usr/lib/libxml2.so.2.9.2
b5f1f000 b6006000 r-xp /usr/lib/libstdc++.so.6.0.20
b6013000 b6016000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6017000 b6039000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b603a000 b604e000 r-xp /lib/libresolv-2.20-2014.11.so
b6052000 b6076000 r-xp /usr/lib/liblzma.so.5.0.3
b6077000 b6079000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b607b000 b6085000 r-xp /usr/lib/libembryo.so.1.13.0
b6086000 b60af000 r-xp /usr/lib/libpng12.so.0.50.0
b60b0000 b60f9000 r-xp /usr/lib/libjpeg.so.8.0.2
b610a000 b6111000 r-xp /lib/librt-2.20-2014.11.so
b6113000 b6132000 r-xp /usr/lib/libector.so.1.13.0
b6135000 b6162000 r-xp /usr/lib/liblua-5.1.so
b6163000 b61f3000 r-xp /usr/lib/libfreetype.so.6.11.3
b61f7000 b6235000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6236000 b624c000 r-xp /usr/lib/libfribidi.so.0.3.1
b624d000 b62a6000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62a9000 b62f4000 r-xp /lib/libm-2.20-2014.11.so
b62f6000 b6308000 r-xp /usr/lib/libeio.so.1.13.0
b6309000 b630c000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b630d000 b6313000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6314000 b6337000 r-xp /usr/lib/libefreet.so.1.13.0
b633a000 b6365000 r-xp /usr/lib/libeldbus.so.1.13.0
b6366000 b639a000 r-xp /usr/lib/libecore_con.so.1.13.0
b639c000 b63a5000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63a6000 b63af000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63b0000 b63c3000 r-xp /usr/lib/libeo.so.1.13.0
b63c5000 b63d8000 r-xp /usr/lib/libecore_input.so.1.13.0
b63d9000 b63e0000 r-xp /usr/lib/libecore_file.so.1.13.0
b63e1000 b6404000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6405000 b6431000 r-xp /usr/lib/libeet.so.1.13.0
b643a000 b64a5000 r-xp /usr/lib/libeina.so.1.13.0
b64a8000 b64bf000 r-xp /usr/lib/libefl.so.1.13.0
b64c1000 b6628000 r-xp /usr/lib/libicuuc.so.51.1
b6636000 b6842000 r-xp /usr/lib/libicui18n.so.51.1
b684a000 b6899000 r-xp /usr/lib/libecore_x.so.1.13.0
b689b000 b68b5000 r-xp /lib/libgcc_s-4.9.so.1
b68b7000 b68bb000 r-xp /lib/libcap.so.2.21
b68bc000 b6902000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6903000 b690a000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b690c000 b695e000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6960000 b6aeb000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6af0000 b6bbe000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bc1000 b6bc5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bc6000 b6bd5000 r-xp /usr/lib/libvconf.so.0.2.45
b6bd6000 b6bd9000 r-xp /usr/lib/libvasum.so.0.3.1
b6bda000 b6bdd000 r-xp /usr/lib/libttrace.so.1.1
b6bdf000 b6be3000 r-xp /usr/lib/libiniparser.so.0
b6be4000 b6c14000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c15000 b6c1e000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c1f000 b6c44000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c45000 b6c55000 r-xp /usr/lib/libunwind.so.8.0.1
b6c5f000 b6e0d000 r-xp /lib/libc-2.20-2014.11.so
b6e15000 b6f58000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f5a000 b6fb2000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fb3000 b6fe7000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fea000 b70be000 r-xp /usr/lib/libedje.so.1.13.0
b70c1000 b70ed000 r-xp /usr/lib/libecore.so.1.13.0
b70fe000 b7324000 r-xp /usr/lib/libevas.so.1.13.0
b734c000 b7364000 r-xp /lib/libpthread-2.20-2014.11.so
b7368000 b76e2000 r-xp /usr/lib/libelementary.so.1.13.0
b7702000 b7706000 r-xp /usr/lib/libsmack.so.1.0.0
b7707000 b7710000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7711000 b7714000 r-xp /usr/lib/libdlog.so.0.0.0
b7715000 b771a000 r-xp /usr/lib/libbundle.so.0.1.22
b771b000 b771e000 r-xp /lib/libdl-2.20-2014.11.so
b7720000 b7745000 r-xp /usr/lib/libaul.so.0.1.0
b7748000 b774a000 r-xp /usr/lib/libappsvc.so.0.1.0
b774b000 b7750000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7751000 b7758000 r-xp /usr/lib/libappcore-efl.so.1.1
b775a000 b775f000 r-xp /usr/lib/libsys-assert.so
b7762000 b7763000 r-xp [vdso]
b7763000 b7785000 r-xp /lib/ld-2.20-2014.11.so
b7787000 b778f000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:6158)
Call Stack Count: 9
 0: (0xb6b9d1f6) [/usr/lib/libsqlite3.so.0] + 0xad1f6
 1: open_setting_db + 0x143 (0xb37c71e3) [/opt/usr/apps/org.example.example/bin/example] + 0xb1e3
 2: app_pause + 0x29 (0xb37c5c99) [/opt/usr/apps/org.example.example/bin/example] + 0x9c99
 3: (0xb774cce2) [/usr/lib/libcapi-appfw-application.so.0] + 0x1ce2
 4: appcore_efl_main + 0x85a (0xb775515a) [/usr/lib/libappcore-efl.so.1] + 0x415a
 5: ui_app_main + 0x140 (0xb774dc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
 6: main + 0x2a5 (0xb37c5bc5) [/opt/usr/apps/org.example.example/bin/example] + 0x9bc5
 7: (0xb7789148) [/opt/usr/apps/org.example.example/bin/example] + 0xb7789148
 8: __libc_start_main + 0xde (0xb6c76e4e) [/lib/libc.so.6] + 0x17e4e
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
mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[11]
06-13 14:52:41.406+0900 D/cluster-view( 2863): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[13], [1, 4]
06-13 14:52:41.406+0900 D/cluster-view( 2863): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-13 14:52:41.406+0900 D/cluster-view( 2863): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-13 14:52:41.406+0900 E/cluster-home( 2863): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.videos] Name[Video] Icon[/usr/share/icons/default/small/org.tizen.videos.png] enable[1] system[1]
06-13 14:52:41.406+0900 D/BADGE   ( 2863): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.videos'], count[0]
06-13 14:52:41.406+0900 E/cluster-home( 2863): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.videos][-17956860][0]
06-13 14:52:41.406+0900 D/cluster-home( 2863): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.videos]
06-13 14:52:41.406+0900 D/cluster-view( 2863): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Video] pos[2, 4] pageId[100001]
06-13 14:52:41.406+0900 D/cluster-view( 2863): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[12]
06-13 14:52:41.406+0900 D/cluster-view( 2863): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[14], [2, 4]
06-13 14:52:41.406+0900 D/cluster-view( 2863): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-13 14:52:41.406+0900 D/cluster-view( 2863): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-13 14:52:41.406+0900 D/cluster-view( 2863): mainmenu-apps-view-impl.cpp: RearrangeItems(243) >  view type [1]
06-13 14:52:41.476+0900 D/rpm-installer( 6307): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
06-13 14:52:41.476+0900 D/rpm-installer( 6307): rpm-appcore-intf.c: main(259) > ------------------------------------------------
06-13 14:52:41.476+0900 D/rpm-installer( 6307): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
06-13 14:52:41.476+0900 D/rpm-installer( 6307): rpm-appcore-intf.c: main(261) > ------------------------------------------------
06-13 14:52:41.476+0900 D/PKGMGR_SERVER( 6292): pkgmgr-server.c: sighandler(387) > child exit [6307]
06-13 14:52:41.476+0900 E/PKGMGR_SERVER( 6292): pkgmgr-server.c: sighandler(402) > child NORMAL exit [6307]
06-13 14:52:41.746+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(838) > __request_handler: 0
06-13 14:52:41.746+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-13 14:52:41.746+0900 D/PKGMGR_INFO( 2747): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-13 14:52:41.746+0900 D/PKGMGR_INFO( 2747): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-13 14:52:41.746+0900 I/AUL     ( 2747): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
06-13 14:52:41.746+0900 D/AUL     ( 2747): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 6359, pid = 6361
06-13 14:52:41.746+0900 D/PKGMGR_INFO( 2747): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-13 14:52:41.746+0900 D/PKGMGR_INFO( 2747): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-13 14:52:41.746+0900 I/AUL     ( 2747): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
06-13 14:52:41.746+0900 E/AUL_AMD ( 2747): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-13 14:52:41.746+0900 W/AUL_AMD ( 2747): amd_launch.c: _start_app(2233) > caller pid : 6361
06-13 14:52:41.746+0900 E/AUL_AMD ( 2747): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-13 14:52:41.746+0900 W/AUL_AMD ( 2747): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-13 14:52:41.746+0900 D/AUL_AMD ( 2747): amd_launch.c: _start_app(2648) > process_pool: false
06-13 14:52:41.746+0900 D/AUL_AMD ( 2747): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-13 14:52:41.746+0900 D/AUL_AMD ( 2747): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-13 14:52:41.746+0900 W/AUL_AMD ( 2747): amd_launch.c: _start_app(2665) > pad pid(-5)
06-13 14:52:41.746+0900 D/AUL_AMD ( 2747): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-13 14:52:41.746+0900 D/AUL_AMD ( 2747): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-13 14:52:41.746+0900 D/AUL     ( 2747): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-13 14:52:41.746+0900 D/AUL_PAD ( 2910): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-13 14:52:41.746+0900 D/AUL_PAD ( 2910): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-13 14:52:41.746+0900 D/AUL_PAD ( 2910): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-13 14:52:41.746+0900 D/AUL_PAD ( 2910): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-13 14:52:41.746+0900 D/AUL_PAD ( 2910): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-13 14:52:41.746+0900 D/AUL_PAD ( 2910): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-13 14:52:41.746+0900 D/AUL_PAD ( 2910): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-13 14:52:41.746+0900 D/AUL_PAD ( 2910): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-13 14:52:41.746+0900 D/AUL_PAD ( 2910): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-13 14:52:41.746+0900 D/AUL_PAD ( 2910): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-13 14:52:41.746+0900 D/AUL_PAD ( 2910): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-13 14:52:41.746+0900 D/AUL_PAD ( 2910): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-13 14:52:41.746+0900 D/AUL_PAD ( 2910): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-13 14:52:41.746+0900 D/AUL_PAD ( 2910): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-13 14:52:41.746+0900 W/AUL_PAD ( 2910): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-13 14:52:41.746+0900 D/AUL     ( 2910): process_pool.c: __send_pkt_raw_data(219) > send(11) : 620 / 620
06-13 14:52:41.746+0900 D/AUL_PAD ( 2910): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 6158, bin path: /opt/usr/apps/org.example.example/bin/example
06-13 14:52:41.746+0900 W/AUL_PAD ( 2910): launchpad.c: __send_result_to_caller(265) > Check app launching
06-13 14:52:41.746+0900 D/AUL_PAD ( 2910): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-13 14:52:41.746+0900 D/RESOURCED( 2842): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-13 14:52:41.746+0900 D/RESOURCED( 2842): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-13 14:52:41.746+0900 D/AUL_PAD ( 6158): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-13 14:52:41.746+0900 E/RESOURCED( 2842): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:52:41.746+0900 D/AUL_PAD ( 6158): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
06-13 14:52:41.746+0900 D/AUL_PAD ( 6158): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-13 14:52:41.746+0900 D/AUL_PAD ( 6158): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-13 14:52:41.746+0900 D/AUL_PAD ( 6158): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-13 14:52:41.746+0900 D/AUL_PAD ( 6158): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-13 14:52:41.746+0900 D/AUL     ( 6158): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (6159) is sent.
06-13 14:52:41.746+0900 D/AUL     ( 6158): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 6159, signo: 10
06-13 14:52:41.756+0900 D/AUL     ( 6158): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-13 14:52:41.756+0900 D/AUL_PAD ( 6158): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-13 14:52:41.756+0900 D/AUL_PAD ( 6158): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-13 14:52:41.756+0900 D/AUL_PAD ( 6158): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-13 14:52:41.756+0900 D/AUL_PAD ( 6158): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-13 14:52:41.756+0900 D/AUL_PAD ( 6158): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTczMzMxNjEvNzUzMjc4AA==##
06-13 14:52:41.756+0900 D/AUL_PAD ( 6158): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-13 14:52:41.756+0900 D/AUL_PAD ( 6158): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA2MzYxAA==##
06-13 14:52:41.756+0900 D/AUL_PAD ( 6158): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-13 14:52:41.756+0900 D/AUL_PAD ( 6158): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-13 14:52:41.756+0900 D/AUL_PAD ( 6158): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-13 14:52:41.756+0900 D/AUL_PAD ( 6158): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-13 14:52:41.756+0900 D/AUL_PAD ( 6158): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-13 14:52:41.756+0900 I/CAPI_APPFW_APPLICATION( 6158): app_main.c: ui_app_main(788) > app_efl_main
06-13 14:52:41.756+0900 D/LAUNCH  ( 6158): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-13 14:52:41.756+0900 D/APP_CORE( 6158): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-13 14:52:41.756+0900 D/APP_CORE( 6158): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-13 14:52:41.756+0900 D/APP_CORE( 6158): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-13 14:52:41.766+0900 D/APP_CORE( 6158): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-13 14:52:41.766+0900 D/AUL     ( 6158): app_sock.c: __create_server_sock(156) > pg path - already exists
06-13 14:52:41.766+0900 D/APP_CORE( 6158): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42ad520
06-13 14:52:41.766+0900 D/LAUNCH  ( 6158): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-13 14:52:41.766+0900 I/CAPI_APPFW_APPLICATION( 6158): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-13 14:52:41.836+0900 D/LAUNCH  ( 6158): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
06-13 14:52:41.836+0900 D/APP_CORE( 6158): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-13 14:52:41.836+0900 E/E17     ( 2765): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x01200002)
06-13 14:52:41.856+0900 D/AUL_PAD ( 2910): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-13 14:52:41.856+0900 W/AUL     ( 2747): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 6158, appid: org.example.example
06-13 14:52:41.856+0900 D/AUL     ( 2747): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-13 14:52:41.856+0900 E/AUL     ( 2747): simple_util.c: __trm_app_info_send_socket(330) > access
06-13 14:52:41.856+0900 D/AUL_AMD ( 2747): amd_launch.c: _start_app(2700) > add app group info
06-13 14:52:41.856+0900 E/AUL     ( 2747): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-13 14:52:41.856+0900 D/AUL_AMD ( 2747): amd_status.c: _status_add_app_info_list(427) > pid(6158) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-13 14:52:41.856+0900 D/RESOURCED( 2842): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 6158
06-13 14:52:41.856+0900 D/RESOURCED( 2842): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-13 14:52:41.856+0900 E/RESOURCED( 2842): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-13 14:52:41.856+0900 D/RESOURCED( 2842): proc-main.c: resourced_proc_status_change(888) > available memory = 320
06-13 14:52:41.876+0900 E/E17     ( 2765): e_border.c: e_border_show(2088) > BD_SHOW(0x01200002)
06-13 14:52:41.876+0900 D/APP_CORE( 6158): appcore.c: __aul_handler(587) > [APP 6158]     AUL event: AUL_START
06-13 14:52:41.876+0900 I/APP_CORE( 6158): appcore-efl.c: __do_app(496) > [APP 6158] Event: RESET State: CREATED
06-13 14:52:41.876+0900 D/APP_CORE( 6158): appcore-efl.c: __do_app(527) > [APP 6158] RESET
06-13 14:52:41.876+0900 D/LAUNCH  ( 6158): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
06-13 14:52:41.876+0900 D/APP_CORE( 6158): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-13 14:52:41.876+0900 D/APP_CORE( 6158): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-13 14:52:41.876+0900 I/CAPI_APPFW_APPLICATION( 6158): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-13 14:52:41.876+0900 D/AUL     ( 6158): service.c: __set_bundle(186) > __set_bundle
06-13 14:52:41.876+0900 D/tag     ( 6158): 왜안돼 ㅠㅠㅠ
06-13 14:52:41.876+0900 D/LAUNCH  ( 6158): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-13 14:52:41.876+0900 I/run     ( 6158): socket
06-13 14:52:41.876+0900 I/tag     ( 6158): eonji~
06-13 14:52:41.876+0900 D/APP_CORE( 6158): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-13 14:52:41.876+0900 I/run     ( 6158): connect
06-13 14:52:41.876+0900 I/run     ( 6158): new
06-13 14:52:41.876+0900 I/run     ( 6158): send
06-13 14:52:41.876+0900 E/EFL     ( 6158): edje<6158> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 14:52:41.876+0900 E/EFL     ( 6158): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:52:41.876+0900 E/EFL     ( 6158): edje<6158> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 14:52:41.876+0900 E/EFL     ( 6158): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:52:41.876+0900 E/EFL     ( 6158): edje<6158> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 14:52:41.876+0900 E/EFL     ( 6158): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:52:41.876+0900 E/EFL     ( 6158): edje<6158> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 14:52:41.876+0900 E/EFL     ( 6158): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:52:41.876+0900 E/EFL     ( 6158): edje<6158> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 14:52:41.876+0900 E/EFL     ( 6158): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:52:41.876+0900 W/APP_CORE( 6158): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1200002
06-13 14:52:41.876+0900 D/APP_CORE( 6158): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:1200002
06-13 14:52:41.876+0900 D/APP_CORE( 6158): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-13 14:52:41.876+0900 D/AUL     ( 6158): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-13 14:52:41.886+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(838) > __request_handler: 34
06-13 14:52:41.896+0900 W/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=6158
06-13 14:52:41.896+0900 E/EFL     ( 2765): eo<2765> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:52:41.896+0900 E/EFL     ( 2765): eo<2765> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:52:41.896+0900 D/INDICATOR( 2846): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
06-13 14:52:41.916+0900 D/INDICATOR( 2846): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-13 14:52:41.916+0900 D/INDICATOR( 2846): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-13 14:52:41.916+0900 D/INDICATOR( 2846): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-13 14:52:41.916+0900 D/INDICATOR( 2846): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-13 14:52:41.916+0900 D/INDICATOR( 2846): main.c: _rotate_window(252) > port :: hide more icon
06-13 14:52:41.926+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(838) > __request_handler: 15
06-13 14:52:41.926+0900 D/PKGMGR_INFO( 2747): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-13 14:52:41.926+0900 D/PKGMGR_INFO( 2747): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-13 14:52:41.926+0900 D/AUL_AMD ( 2747): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 6158 is org.example.example
06-13 14:52:41.926+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 6158 : 0
06-13 14:52:41.926+0900 D/AUL     ( 2934): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-13 14:52:42.056+0900 D/APP_CORE( 6158): appcore.c: __prt_ltime(236) > [APP 6158] first idle after reset: 313 msec
06-13 14:52:42.116+0900 E/E17     ( 2765): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
06-13 14:52:42.116+0900 D/APP_CORE( 2863): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
06-13 14:52:42.116+0900 D/APP_CORE( 2863): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-13 14:52:42.116+0900 D/APP_CORE( 2863): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-13 14:52:42.116+0900 I/APP_CORE( 2863): appcore-efl.c: __do_app(496) > [APP 2863] Event: PAUSE State: RUNNING
06-13 14:52:42.116+0900 D/APP_CORE( 2863): appcore-efl.c: __do_app(565) > [APP 2863] PAUSE
06-13 14:52:42.116+0900 I/CAPI_APPFW_APPLICATION( 2863): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-13 14:52:42.116+0900 E/cluster-home( 2863): homescreen.cpp: OnPause(84) >  app pause
06-13 14:52:42.116+0900 D/cluster-view( 2863): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-13 14:52:42.116+0900 D/cluster-view( 2863): homescreen-view-manager.cpp: AppPause(923) >  END
06-13 14:52:42.116+0900 D/APP_CORE( 2863): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-13 14:52:42.116+0900 E/APP_CORE( 2863): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-13 14:52:42.126+0900 D/AUL_AMD ( 2747): amd_status.c: _status_update_app_info_list(456) > pid(2863) status(4)
06-13 14:52:42.126+0900 D/AUL_AMD ( 2747): amd_status.c: _status_update_app_info_list(468) > pid(2863) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-13 14:52:42.126+0900 D/AUL     ( 2747): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-13 14:52:42.126+0900 W/AUL     ( 2747): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2863, appid: org.tizen.homescreen, status: bg
06-13 14:52:42.126+0900 D/AUL_AMD ( 2747): amd_launch.c: __e17_status_handler(2891) > pid(6158) status(3)
06-13 14:52:42.126+0900 D/AUL_AMD ( 2747): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-13 14:52:42.126+0900 W/AUL_AMD ( 2747): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:52:42.126+0900 W/AUL_AMD ( 2747): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-13 14:52:42.126+0900 D/AUL_AMD ( 2747): amd_status.c: _status_update_app_info_list(456) > pid(6158) status(3)
06-13 14:52:42.126+0900 D/AUL_AMD ( 2747): amd_status.c: _status_update_app_info_list(468) > pid(6158) appid(org.example.example) pkgid(org.example.example) status(3)
06-13 14:52:42.126+0900 D/AUL     ( 2747): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-13 14:52:42.126+0900 W/AUL     ( 2747): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 6158, appid: org.example.example, status: fg
06-13 14:52:42.126+0900 D/RESOURCED( 2842): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 6158
06-13 14:52:42.126+0900 D/RESOURCED( 2842): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 6158, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-13 14:52:42.126+0900 D/RESOURCED( 2842): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 6158
06-13 14:52:42.136+0900 D/DATA_PROVIDER_MASTER( 2922): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2863 is paused
06-13 14:52:42.136+0900 D/DATA_PROVIDER_MASTER( 2922): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-13 14:52:42.136+0900 I/CAPI_WIDGET_APPLICATION( 3008): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-13 14:52:42.136+0900 I/CAPI_WIDGET_APPLICATION( 3008): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-13 14:52:42.136+0900 W/AUL     ( 3008): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3008, appid: org.tizen.calendar.widget, status: bg
06-13 14:52:42.156+0900 D/APP_CORE( 6158): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1200002 fully_obscured 0
06-13 14:52:42.156+0900 D/APP_CORE( 6158): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-13 14:52:42.156+0900 D/APP_CORE( 6158): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-13 14:52:42.156+0900 I/APP_CORE( 6158): appcore-efl.c: __do_app(496) > [APP 6158] Event: RESUME State: CREATED
06-13 14:52:42.156+0900 D/LAUNCH  ( 6158): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-13 14:52:42.156+0900 D/APP_CORE( 6158): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-13 14:52:42.156+0900 D/APP_CORE( 6158): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-13 14:52:42.156+0900 D/APP_CORE( 6158): appcore-efl.c: __do_app(607) > [APP 6158] RESUME
06-13 14:52:42.156+0900 I/APP_CORE( 6158): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-13 14:52:42.156+0900 I/APP_CORE( 6158): appcore-efl.c: __do_app(614) > [APP 6158] Initial Launching, call the resume_cb
06-13 14:52:42.156+0900 I/CAPI_APPFW_APPLICATION( 6158): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-13 14:52:42.156+0900 D/LAUNCH  ( 6158): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-13 14:52:42.156+0900 D/LAUNCH  ( 6158): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-13 14:52:42.156+0900 D/APP_CORE( 6158): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-13 14:52:42.156+0900 E/APP_CORE( 6158): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-13 14:52:42.186+0900 D/RESOURCED( 2842): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 6158, appname = org.example.example, pkgname = org.example.example
06-13 14:52:42.186+0900 D/RESOURCED( 2842): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 6158, appname = org.example.example
06-13 14:52:42.186+0900 D/RESOURCED( 2842): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 6158
06-13 14:52:42.186+0900 D/RESOURCED( 2842): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3008, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-13 14:52:42.186+0900 D/RESOURCED( 2842): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3008
06-13 14:52:42.186+0900 D/RESOURCED( 2842): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3008, appname = org.tizen.calendar.widget
06-13 14:52:42.186+0900 D/RESOURCED( 2842): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3008
06-13 14:52:42.186+0900 I/RESOURCED( 2842): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-13 14:52:42.186+0900 I/RESOURCED( 2842): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-13 14:52:42.246+0900 D/AUL_AMD ( 2747): amd_launch.c: __e17_status_handler(2910) > pid(6158) status(0)
06-13 14:52:42.856+0900 D/AUL_PAD ( 2910): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-13 14:52:42.856+0900 D/AUL_PAD ( 6369): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-13 14:52:42.866+0900 D/AUL_PAD ( 2910): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-13 14:52:42.876+0900 E/RESOURCED( 2842): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.453
06-13 14:52:42.996+0900 E/PKGMGR_SERVER( 6292): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 14:52:42.996+0900 E/PKGMGR_SERVER( 6292): pkgmgr-server.c: main(2265) > package manager server terminated.
06-13 14:52:43.356+0900 D/AUL_AMD ( 2747): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-13 14:52:43.356+0900 D/RUA     ( 2747): rua.c: rua_add_history(179) > rua_add_history start
06-13 14:52:43.366+0900 D/RUA     ( 2747): rua.c: rua_add_history(247) > rua_add_history ok
06-13 14:52:43.906+0900 D/AUL_PAD ( 6369): launchpad_loader.c: main(588) > sleeping 1 sec...
06-13 14:52:43.906+0900 D/AUL_PAD ( 6369): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-13 14:52:43.916+0900 D/AUL_PAD ( 6369): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b8525760
06-13 14:52:43.916+0900 D/AUL_PAD ( 6369): preload.h: __preload_init(69) > get pre-initialization function
06-13 14:52:43.916+0900 D/AUL_PAD ( 6369): preload.h: __preload_init(73) > get shutdown function
06-13 14:52:43.916+0900 D/AUL_PAD ( 6369): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b8525a40
06-13 14:52:43.926+0900 D/AUL_PAD ( 6369): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b8527640
06-13 14:52:43.926+0900 D/AUL_PAD ( 6369): preload.h: __preload_init(69) > get pre-initialization function
06-13 14:52:43.926+0900 D/AUL_PAD ( 6369): preload.h: __preload_init(73) > get shutdown function
06-13 14:52:43.926+0900 D/AUL_PAD ( 6369): preexec.h: __preexec_init(76) > preexec start
06-13 14:52:43.926+0900 D/AUL_PAD ( 6369): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-13 14:52:43.926+0900 D/AUL     ( 6369): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-13 14:52:43.926+0900 D/AUL     ( 6369): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-13 14:52:43.926+0900 D/AUL     ( 6369): process_pool.c: __connect_to_launchpad(132) > send(6369) : 4
06-13 14:52:43.926+0900 D/AUL     ( 6369): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-13 14:52:43.926+0900 D/AUL_PAD ( 2910): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-13 14:52:43.926+0900 D/AUL_PAD ( 2910): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-13 14:52:43.926+0900 D/AUL_PAD ( 2910): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-13 14:52:43.926+0900 D/AUL_PAD ( 2910): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-13 14:52:43.926+0900 D/AUL_PAD ( 2910): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-13 14:52:43.926+0900 D/AUL_PAD ( 2910): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-13 14:52:43.926+0900 D/AUL_PAD ( 2910): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-13 14:52:43.926+0900 D/AUL_PAD ( 2910): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-13 14:52:43.926+0900 D/AUL_PAD ( 2910): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 6369
06-13 14:52:44.016+0900 D/AUL_PAD ( 6369): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-13 14:52:44.026+0900 D/AUL_PAD ( 6369): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-13 14:52:44.026+0900 D/AUL_PAD ( 6369): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-13 14:52:44.026+0900 D/AUL_PAD ( 6369): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-13 14:52:44.356+0900 I/user_tag0( 6158): /opt/usr/apps/org.example.example/data/feeding.db
06-13 14:52:44.376+0900 I/tag     ( 6158): eonji~
06-13 14:52:44.436+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400d8f 
06-13 14:52:45.456+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400d8f 
06-13 14:52:45.556+0900 E/EFL     ( 6158): edje<6158> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 14:52:45.556+0900 E/EFL     ( 6158): edje<6158> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 14:52:45.606+0900 E/EFL     ( 6158): edje<6158> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 14:52:45.606+0900 E/EFL     ( 6158): edje<6158> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 14:52:45.616+0900 E/EFL     ( 6158): edje<6158> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 14:52:45.616+0900 E/EFL     ( 6158): edje<6158> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 14:52:45.616+0900 E/EFL     ( 6158): edje<6158> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 14:52:45.616+0900 E/EFL     ( 6158): edje<6158> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 14:52:45.616+0900 E/EFL     ( 6158): edje<6158> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 14:52:45.626+0900 D/IMMODULE( 6158): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
06-13 14:52:45.626+0900 D/ISF_SOCKET( 6158): scim_socket.cpp: connect(515) > ppid:2910  trying connect() to local:/tmp/scim-socket-frontend, example
06-13 14:52:45.626+0900 D/ISF_SOCKET( 6158): scim_socket.cpp: connect(524) > connect() succeeded
06-13 14:52:45.626+0900 D/ISF_SOCKET( 6158): scim_socket.cpp: connect(515) > ppid:2910  trying connect() to local:/tmp/scim-socket-frontend, example
06-13 14:52:45.626+0900 D/ISF_SOCKET( 6158): scim_socket.cpp: connect(524) > connect() succeeded
06-13 14:52:45.636+0900 D/ISF_SOCKET( 6158): scim_socket.cpp: connect(515) > ppid:2910  trying connect() to local:/tmp/scim-socket-frontend, example
06-13 14:52:45.636+0900 D/ISF_SOCKET( 6158): scim_socket.cpp: connect(524) > connect() succeeded
06-13 14:52:45.636+0900 D/ISF_QUERY( 6158): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
06-13 14:52:45.636+0900 D/ISF_QUERY( 6158): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-13 14:52:45.636+0900 D/ISF_QUERY( 6158): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-13 14:52:45.636+0900 D/ISF_QUERY( 6158): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-13 14:52:45.636+0900 D/ISF_QUERY( 6158): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-13 14:52:45.636+0900 D/ISF_QUERY( 6158): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-13 14:52:45.636+0900 D/ISF_QUERY( 6158): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-13 14:52:45.636+0900 D/ISF_SOCKET( 6158): scim_socket.cpp: connect(515) > ppid:2910  trying connect() to local:/tmp/scim-socket-frontend, example
06-13 14:52:45.636+0900 D/ISF_SOCKET( 6158): scim_socket.cpp: connect(524) > connect() succeeded
06-13 14:52:45.636+0900 D/IMMODULE( 6158): scim_panel_client.cpp: open_connection(162) > 
06-13 14:52:45.636+0900 D/ISF_SOCKET( 6158): scim_socket.cpp: connect(515) > ppid:2910  trying connect() to local:/tmp/scim-panel-socket:0, example
06-13 14:52:45.646+0900 D/ISF_SOCKET( 6158): scim_socket.cpp: connect(524) > connect() succeeded
06-13 14:52:45.646+0900 D/ISF_SOCKET( 6158): scim_socket.cpp: connect(515) > ppid:2910  trying connect() to local:/tmp/scim-panel-socket:0, example
06-13 14:52:45.646+0900 D/ISF_SOCKET( 6158): scim_socket.cpp: connect(524) > connect() succeeded
06-13 14:52:45.646+0900 D/IMMODULE( 6158): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 1
06-13 14:52:46.456+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1200002
06-13 14:52:46.516+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400d8f 
06-13 14:52:47.126+0900 D/APP_CORE( 2863): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
06-13 14:52:47.126+0900 I/APP_CORE( 2863): appcore-efl.c: __do_app(496) > [APP 2863] Event: MEM_FLUSH State: PAUSED
06-13 14:52:47.126+0900 D/APP_CORE( 2863): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
06-13 14:52:47.126+0900 D/APP_CORE( 2863): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2863
06-13 14:52:47.126+0900 D/APP_CORE( 2863): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
06-13 14:52:47.126+0900 D/RESOURCED( 2842): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2863
06-13 14:52:47.206+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400d8f 
06-13 14:52:47.406+0900 I/db      ( 6158): insert
06-13 14:52:47.406+0900 I/db      ( 6158): 14,53
06-13 14:52:47.406+0900 I/MESSAGE_PORT( 6158): message-port.c: __initialize(875) > initialize
06-13 14:52:47.406+0900 I/MESSAGE_PORT( 6158): message-port.c: __initialize(881) > init : org.example.example
06-13 14:52:47.416+0900 I/MESSAGE_PORT( 6158): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._031dc3d83618636debe50e147a11f1d80 
06-13 14:52:47.416+0900 I/MESSAGE_PORT( 6158): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._031dc3d83618636debe50e147a11f1d80 
06-13 14:52:47.416+0900 I/MESSAGE_PORT( 6158): message-port.c: __message_port_send_message(975) > port exist check !!
06-13 14:52:47.416+0900 I/MESSAGE_PORT( 6158): message-port.c: __check_remote_port(545) > Check a remote port : [org.example.service:myapplicationservice_service_port]
06-13 14:52:47.416+0900 I/MESSAGE_PORT( 6158): message-port.c: __check_remote_port(557) > remote_app_id, app_id :[org.example.service : org.example.example] 
06-13 14:52:47.416+0900 I/MESSAGE_PORT( 6158): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._031dc3d83618636debe50e147a11f1d80 
06-13 14:52:47.416+0900 I/MESSAGE_PORT( 6158): message-port.c: __check_remote_port(603) > Name not exist org.tizen.messageport._031dc3d83618636debe50e147a11f1d80
06-13 14:52:47.416+0900 E/example ( 6158): message_port_check_remote_port error : -18022399
06-13 14:52:47.416+0900 E/EFL     ( 6158): edje<6158> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 14:52:47.416+0900 E/EFL     ( 6158): edje<6158> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 14:52:47.426+0900 E/EFL     ( 6158): edje<6158> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 14:52:47.426+0900 E/EFL     ( 6158): edje<6158> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 14:52:47.426+0900 E/EFL     ( 6158): edje<6158> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 14:52:47.436+0900 I/get     ( 6158): 53
06-13 14:52:47.436+0900 I/get     ( 6158): 53
06-13 14:52:47.436+0900 I/get     ( 6158): 53
06-13 14:52:47.436+0900 I/get     ( 6158): 53
06-13 14:52:47.446+0900 I/get     ( 6158): 53
06-13 14:52:47.446+0900 I/get     ( 6158): 53
06-13 14:52:47.446+0900 I/get     ( 6158): 53
06-13 14:52:47.446+0900 I/get     ( 6158): 53
06-13 14:52:49.266+0900 I/CAPI_APPFW_APPLICATION( 6158): app_main.c: ui_app_exit(799) > ui_app_exit
06-13 14:52:49.266+0900 D/AUL     ( 6158): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-13 14:52:49.266+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(838) > __request_handler: 22
06-13 14:52:49.266+0900 W/AUL_AMD ( 2747): amd_request.c: __request_handler(1056) > app status : 5
06-13 14:52:49.266+0900 D/AUL_AMD ( 2747): amd_status.c: _status_update_app_info_list(456) > pid(6158) status(5)
06-13 14:52:49.266+0900 D/AUL_AMD ( 2747): amd_status.c: _status_update_app_info_list(468) > pid(6158) appid(org.example.example) pkgid(org.example.example) status(5)
06-13 14:52:49.266+0900 D/AUL     ( 2747): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.example.example
06-13 14:52:49.266+0900 W/AUL     ( 2747): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 6158, appid: org.example.example, status: bg
06-13 14:52:49.266+0900 D/RESOURCED( 2842): heart-cpu.c: heart_cpu_background_state(230) > heart_cpu_background_state : pid = 6158, appname = org.example.example, pkgname = org.example.example
06-13 14:52:49.266+0900 D/RESOURCED( 2842): cpu.c: cpu_background_state(233) > cpu_background_state : pid = 6158, appname = org.example.example
06-13 14:52:49.266+0900 D/RESOURCED( 2842): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 6158
06-13 14:52:49.266+0900 D/RESOURCED( 2842): proc-process.c: proc_backgrd_manage(170) > BACKGRD : process 2859 increase lru 5
06-13 14:52:49.266+0900 D/RESOURCED( 2842): proc-process.c: proc_backgrd_manage(179) > BACKGRD : process 2859 set score 420 (before 390)
06-13 14:52:49.266+0900 D/RESOURCED( 2842): proc-process.c: proc_backgrd_manage(189) > detect favorite application : org.example.example
06-13 14:52:49.266+0900 D/RESOURCED( 2842): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 6158, proc_name: org.example.example, cg_name: favorite, oom_score_adj: 270
06-13 14:52:49.266+0900 D/RESOURCED( 2842): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/favorite//cgroup.procs, value 6158
06-13 14:52:49.266+0900 D/APP_CORE( 6158): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
06-13 14:52:49.266+0900 D/APP_CORE( 6158): appcore-efl.c: __after_loop(1169) > [APP 6158] PAUSE before termination
06-13 14:52:49.266+0900 I/CAPI_APPFW_APPLICATION( 6158): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-13 14:52:49.266+0900 I/user_tag0( 6158): /opt/usr/apps/org.example.example/data/test.db
06-13 14:52:49.316+0900 W/CRASH_MANAGER( 6374): worker.c: worker_job(1204) > 1106158657861149733316
