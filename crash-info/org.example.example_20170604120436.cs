S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 8503
Date: 2017-06-04 12:04:36+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 128
      signal sent by the kernel

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb9905b78, esi = 0xb987d7a0
ebp = 0xbfbcd188, esp = 0xbfbccf0c
eax = 0xb76f4a40, ebx = 0xb987d76f
ecx = 0x8000aa56, edx = 0x00000002
eip = 0xb987d7c1

Memory Information
MemTotal:      123 KB
MemFree:        23 KB
Buffers:         7 KB
Cached:     183412 KB
VmPeak:     122384 KB
VmSize:     118348 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       35312 KB
VmRSS:       31208 KB
VmData:      48432 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34640 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 8503 TID = 8503
8503 8504 8664 8665 8670 

Maps Information
b0ed6000 b0edd000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b0ede000 b0ef6000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0ef7000 b0efe000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b18b7000 b18bb000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2b90000 b2b9a000 r-xp /usr/lib/libfeedback.so.0.1.4
b2ba0000 b2bac000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2bad000 b2bce000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2bd3000 b2bd4000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2bd5000 b2bda000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2bdb000 b2bdc000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2bdd000 b2bdf000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2be0000 b2be2000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2be3000 b2bef000 r-xp /usr/lib/libdrm.so.2.4.0
b2bf0000 b2bf3000 r-xp /usr/lib/libdri2.so.0.0.0
b2bf4000 b2bfe000 r-xp /usr/lib/libtbm.so.1.0.0
b2bff000 b2c14000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c15000 b2c27000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3429000 b345a000 r-xp /usr/lib/libidn.so.11.5.44
b345b000 b347d000 r-xp /usr/lib/libnghttp2.so.5.4.0
b347e000 b348e000 r-xp /usr/lib/libcares.so.2.1.0
b348f000 b3498000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3499000 b34a2000 r-xp /usr/lib/libefl-extension.so.0.1.0
b34a3000 b351a000 r-xp /usr/lib/libcurl.so.4.3.0
b351c000 b352e000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b352f000 b3550000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b3557000 b3558000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3559000 b355a000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b355b000 b355e000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b355f000 b3562000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b366a000 b3670000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3671000 b37b5000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37c5000 b37c6000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37c7000 b37d5000 r-xp /opt/usr/apps/org.example.example/bin/example
b37d7000 b3810000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4213000 b421e000 r-xp /lib/libnss_files-2.20-2014.11.so
b4220000 b422b000 r-xp /lib/libnss_nis-2.20-2014.11.so
b422d000 b4244000 r-xp /lib/libnsl-2.20-2014.11.so
b4248000 b4250000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4252000 b4276000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4277000 b4278000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4279000 b427c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b427d000 b4284000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4285000 b428f000 r-xp /usr/lib/libsensord-share.so
b4290000 b42ac000 r-xp /usr/lib/libsensor.so.1.2.0
b42ae000 b42b7000 r-xp /usr/lib/libappcore-common.so.1.1
b42ba000 b42bc000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42d1000 b42d3000 r-xp /usr/lib/libXau.so.6.0.0
b42d4000 b42f6000 r-xp /usr/lib/libxcb.so.1.1.0
b42f8000 b4301000 r-xp /lib/libcrypt-2.20-2014.11.so
b432a000 b432c000 r-xp /usr/lib/libiri.so
b432d000 b4353000 r-xp /lib/libexpat.so.1.5.2
b4355000 b43c0000 r-xp /usr/lib/libssl.so.1.0.0
b43c6000 b43d2000 r-xp /usr/lib/libethumb.so.1.13.0
b43d3000 b43d7000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43d8000 b4629000 r-xp /usr/lib/libcrypto.so.1.0.0
b5ba4000 b5bb4000 r-xp /usr/lib/libXi.so.6.1.0
b5bb5000 b5bb7000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bb8000 b5bbe000 r-xp /usr/lib/libXtst.so.6.1.0
b5bbf000 b5bc9000 r-xp /usr/lib/libXrender.so.1.3.0
b5bca000 b5bd3000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bd5000 b5bd7000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bd8000 b5bdd000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bde000 b5bf0000 r-xp /usr/lib/libXext.so.6.4.0
b5bf1000 b5bf3000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bf4000 b5bf6000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bf8000 b5d3a000 r-xp /usr/lib/libX11.so.6.3.0
b5d3e000 b5d48000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d49000 b5d5f000 r-xp /usr/lib/libudev.so.1.6.0
b5d62000 b5d66000 r-xp /lib/libattr.so.1.1.0
b5d67000 b5d96000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d98000 b5d9e000 r-xp /usr/lib/libffi.so.6.0.2
b5d9f000 b5dc2000 r-xp /lib/libz.so.1.2.8
b5dc3000 b5dc6000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5dc7000 b5f23000 r-xp /usr/lib/libxml2.so.2.9.2
b5f29000 b6010000 r-xp /usr/lib/libstdc++.so.6.0.20
b601d000 b6020000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6021000 b6043000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6044000 b6058000 r-xp /lib/libresolv-2.20-2014.11.so
b605c000 b6080000 r-xp /usr/lib/liblzma.so.5.0.3
b6081000 b6083000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6085000 b608f000 r-xp /usr/lib/libembryo.so.1.13.0
b6090000 b60b9000 r-xp /usr/lib/libpng12.so.0.50.0
b60ba000 b6103000 r-xp /usr/lib/libjpeg.so.8.0.2
b6114000 b611b000 r-xp /lib/librt-2.20-2014.11.so
b611d000 b613c000 r-xp /usr/lib/libector.so.1.13.0
b613f000 b616c000 r-xp /usr/lib/liblua-5.1.so
b616d000 b61fd000 r-xp /usr/lib/libfreetype.so.6.11.3
b6201000 b623f000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6240000 b6256000 r-xp /usr/lib/libfribidi.so.0.3.1
b6257000 b62b0000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62b3000 b62fe000 r-xp /lib/libm-2.20-2014.11.so
b6300000 b6312000 r-xp /usr/lib/libeio.so.1.13.0
b6313000 b6316000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6317000 b631d000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b631e000 b6341000 r-xp /usr/lib/libefreet.so.1.13.0
b6344000 b636f000 r-xp /usr/lib/libeldbus.so.1.13.0
b6370000 b63a4000 r-xp /usr/lib/libecore_con.so.1.13.0
b63a6000 b63af000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63b0000 b63b9000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63ba000 b63cd000 r-xp /usr/lib/libeo.so.1.13.0
b63cf000 b63e2000 r-xp /usr/lib/libecore_input.so.1.13.0
b63e3000 b63ea000 r-xp /usr/lib/libecore_file.so.1.13.0
b63eb000 b640e000 r-xp /usr/lib/libecore_evas.so.1.13.0
b640f000 b643b000 r-xp /usr/lib/libeet.so.1.13.0
b6444000 b64af000 r-xp /usr/lib/libeina.so.1.13.0
b64b2000 b64c9000 r-xp /usr/lib/libefl.so.1.13.0
b64cb000 b6632000 r-xp /usr/lib/libicuuc.so.51.1
b6640000 b684c000 r-xp /usr/lib/libicui18n.so.51.1
b6854000 b68a3000 r-xp /usr/lib/libecore_x.so.1.13.0
b68a5000 b68bf000 r-xp /lib/libgcc_s-4.9.so.1
b68c1000 b68c5000 r-xp /lib/libcap.so.2.21
b68c6000 b690c000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b690d000 b6914000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6916000 b6968000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b696a000 b6af5000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6afa000 b6bc8000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bcb000 b6bcf000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bd0000 b6bdf000 r-xp /usr/lib/libvconf.so.0.2.45
b6be0000 b6be3000 r-xp /usr/lib/libvasum.so.0.3.1
b6be4000 b6be7000 r-xp /usr/lib/libttrace.so.1.1
b6be9000 b6bed000 r-xp /usr/lib/libiniparser.so.0
b6bee000 b6c1e000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c1f000 b6c28000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c29000 b6c4e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c4f000 b6c5f000 r-xp /usr/lib/libunwind.so.8.0.1
b6c69000 b6e17000 r-xp /lib/libc-2.20-2014.11.so
b6e1f000 b6f62000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f64000 b6fbc000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fbd000 b6ff1000 r-xp /usr/lib/libsystemd.so.0.4.0
b6ff4000 b70c8000 r-xp /usr/lib/libedje.so.1.13.0
b70cb000 b70f7000 r-xp /usr/lib/libecore.so.1.13.0
b7108000 b732e000 r-xp /usr/lib/libevas.so.1.13.0
b7356000 b736e000 r-xp /lib/libpthread-2.20-2014.11.so
b7372000 b76ec000 r-xp /usr/lib/libelementary.so.1.13.0
b770c000 b7710000 r-xp /usr/lib/libsmack.so.1.0.0
b7711000 b771a000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b771b000 b771e000 r-xp /usr/lib/libdlog.so.0.0.0
b771f000 b7724000 r-xp /usr/lib/libbundle.so.0.1.22
b7725000 b7728000 r-xp /lib/libdl-2.20-2014.11.so
b772a000 b774f000 r-xp /usr/lib/libaul.so.0.1.0
b7752000 b7754000 r-xp /usr/lib/libappsvc.so.0.1.0
b7755000 b775a000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b775b000 b7762000 r-xp /usr/lib/libappcore-efl.so.1.1
b7764000 b7769000 r-xp /usr/lib/libsys-assert.so
b776c000 b776d000 r-xp [vdso]
b776d000 b778f000 r-xp /lib/ld-2.20-2014.11.so
b7791000 b7799000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:8503)
Call Stack Count: 23
 0: (0xb987d7c1) (null)
 1: (0xb74c3235) [/usr/lib/libelementary.so.1] + 0x151235
 2: (0xb74c3802) [/usr/lib/libelementary.so.1] + 0x151802
 3: (0xb74c3f64) [/usr/lib/libelementary.so.1] + 0x151f64
 4: (0xb74c4440) [/usr/lib/libelementary.so.1] + 0x152440
 5: (0xb74d2c42) [/usr/lib/libelementary.so.1] + 0x160c42
 6: evas_obj_smart_calculate + 0x99 (0xb71926f9) [/usr/lib/libevas.so.1] + 0x8a6f9
 7: (0xb7193bf9) [/usr/lib/libevas.so.1] + 0x8bbf9
 8: (0xb71e4029) [/usr/lib/libevas.so.1] + 0xdc029
 9: (0xb71e736c) [/usr/lib/libevas.so.1] + 0xdf36c
10: evas_canvas_render_updates + 0x97 (0xb71567c7) [/usr/lib/libevas.so.1] + 0x4e7c7
11: evas_render_updates + 0x53 (0xb715c713) [/usr/lib/libevas.so.1] + 0x54713
12: (0xb2c1f4bc) [/usr/lib/ecore_evas/engines/x/v-1.13/module.so] + 0xa4bc
13: (0xb63f99d9) [/usr/lib/libecore_evas.so.1] + 0xe9d9
14: (0xb70dd180) [/usr/lib/libecore.so.1] + 0x12180
15: (0xb70e108d) [/usr/lib/libecore.so.1] + 0x1608d
16: ecore_main_loop_begin + 0x57 (0xb70e1587) [/usr/lib/libecore.so.1] + 0x16587
17: elm_run + 0x2d (0xb753a22d) [/usr/lib/libelementary.so.1] + 0x1c822d
18: appcore_efl_main + 0x4de (0xb775edde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
19: ui_app_main + 0x140 (0xb7757c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
20: main + 0x296 (0xb37cfcd6) [/opt/usr/apps/org.example.example/bin/example] + 0x8cd6
21: (0xb7793148) [/opt/usr/apps/org.example.example/bin/example] + 0xb7793148
22: __libc_start_main + 0xde (0xb6c80e4e) [/lib/libc.so.6] + 0x17e4e
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
2:04:28.580+0900 D/cluster-view( 2864): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[14], [2, 4]
06-04 12:04:28.580+0900 D/cluster-view( 2864): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-04 12:04:28.580+0900 D/cluster-view( 2864): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-04 12:04:28.580+0900 D/cluster-view( 2864): mainmenu-apps-view-impl.cpp: RearrangeItems(243) >  view type [1]
06-04 12:04:28.710+0900 D/rpm-installer( 8606): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
06-04 12:04:28.710+0900 D/rpm-installer( 8606): rpm-appcore-intf.c: main(259) > ------------------------------------------------
06-04 12:04:28.710+0900 D/rpm-installer( 8606): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
06-04 12:04:28.710+0900 D/rpm-installer( 8606): rpm-appcore-intf.c: main(261) > ------------------------------------------------
06-04 12:04:28.710+0900 D/PKGMGR_SERVER( 8591): pkgmgr-server.c: sighandler(387) > child exit [8606]
06-04 12:04:28.710+0900 E/PKGMGR_SERVER( 8591): pkgmgr-server.c: sighandler(402) > child NORMAL exit [8606]
06-04 12:04:29.210+0900 D/AUL_AMD ( 2729): amd_request.c: __request_handler(838) > __request_handler: 0
06-04 12:04:29.210+0900 D/AUL_AMD ( 2729): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-04 12:04:29.210+0900 D/PKGMGR_INFO( 2729): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-04 12:04:29.210+0900 D/PKGMGR_INFO( 2729): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-04 12:04:29.210+0900 I/AUL     ( 2729): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
06-04 12:04:29.210+0900 D/AUL     ( 2729): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 8658, pid = 8660
06-04 12:04:29.210+0900 D/PKGMGR_INFO( 2729): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-04 12:04:29.210+0900 D/PKGMGR_INFO( 2729): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-04 12:04:29.210+0900 I/AUL     ( 2729): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
06-04 12:04:29.210+0900 E/AUL_AMD ( 2729): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-04 12:04:29.210+0900 W/AUL_AMD ( 2729): amd_launch.c: _start_app(2233) > caller pid : 8660
06-04 12:04:29.210+0900 E/AUL_AMD ( 2729): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-04 12:04:29.210+0900 W/AUL_AMD ( 2729): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-04 12:04:29.210+0900 D/AUL_AMD ( 2729): amd_launch.c: _start_app(2648) > process_pool: false
06-04 12:04:29.210+0900 D/AUL_AMD ( 2729): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-04 12:04:29.210+0900 D/AUL_AMD ( 2729): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-04 12:04:29.210+0900 W/AUL_AMD ( 2729): amd_launch.c: _start_app(2665) > pad pid(-5)
06-04 12:04:29.210+0900 D/AUL_AMD ( 2729): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-04 12:04:29.210+0900 D/AUL_AMD ( 2729): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-04 12:04:29.210+0900 D/AUL     ( 2729): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-04 12:04:29.210+0900 D/AUL_PAD ( 2915): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-04 12:04:29.210+0900 D/AUL_PAD ( 2915): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-04 12:04:29.210+0900 D/AUL_PAD ( 2915): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-04 12:04:29.210+0900 D/AUL_PAD ( 2915): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-04 12:04:29.210+0900 D/AUL_PAD ( 2915): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-04 12:04:29.210+0900 D/AUL_PAD ( 2915): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-04 12:04:29.210+0900 D/AUL_PAD ( 2915): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-04 12:04:29.210+0900 D/AUL_PAD ( 2915): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-04 12:04:29.210+0900 D/RESOURCED( 2844): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-04 12:04:29.210+0900 D/RESOURCED( 2844): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-04 12:04:29.210+0900 E/RESOURCED( 2844): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-04 12:04:29.210+0900 D/AUL_PAD ( 2915): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-04 12:04:29.210+0900 D/AUL_PAD ( 2915): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-04 12:04:29.210+0900 D/AUL_PAD ( 2915): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-04 12:04:29.210+0900 D/AUL_PAD ( 2915): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-04 12:04:29.210+0900 D/AUL_PAD ( 2915): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-04 12:04:29.210+0900 D/AUL_PAD ( 2915): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-04 12:04:29.210+0900 W/AUL_PAD ( 2915): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-04 12:04:29.210+0900 D/AUL     ( 2915): process_pool.c: __send_pkt_raw_data(219) > send(12) : 620 / 620
06-04 12:04:29.210+0900 D/AUL_PAD ( 2915): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 8503, bin path: /opt/usr/apps/org.example.example/bin/example
06-04 12:04:29.210+0900 W/AUL_PAD ( 2915): launchpad.c: __send_result_to_caller(265) > Check app launching
06-04 12:04:29.210+0900 D/AUL_PAD ( 2915): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-04 12:04:29.210+0900 D/AUL_PAD ( 8503): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-04 12:04:29.210+0900 D/AUL_PAD ( 8503): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
06-04 12:04:29.210+0900 D/AUL_PAD ( 8503): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-04 12:04:29.210+0900 D/AUL_PAD ( 8503): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-04 12:04:29.210+0900 D/AUL_PAD ( 8503): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-04 12:04:29.210+0900 D/AUL_PAD ( 8503): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-04 12:04:29.210+0900 D/AUL     ( 8503): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (8504) is sent.
06-04 12:04:29.210+0900 D/AUL     ( 8503): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 8504, signo: 10
06-04 12:04:29.210+0900 D/AUL     ( 8503): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-04 12:04:29.210+0900 D/AUL_PAD ( 8503): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-04 12:04:29.210+0900 D/AUL_PAD ( 8503): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-04 12:04:29.210+0900 D/AUL_PAD ( 8503): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-04 12:04:29.210+0900 D/AUL_PAD ( 8503): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-04 12:04:29.210+0900 D/AUL_PAD ( 8503): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTY1NDU0NjkvMjE0NjMzAA==##
06-04 12:04:29.210+0900 D/AUL_PAD ( 8503): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-04 12:04:29.210+0900 D/AUL_PAD ( 8503): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA4NjYwAA==##
06-04 12:04:29.210+0900 D/AUL_PAD ( 8503): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-04 12:04:29.210+0900 D/AUL_PAD ( 8503): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-04 12:04:29.210+0900 D/AUL_PAD ( 8503): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-04 12:04:29.210+0900 D/AUL_PAD ( 8503): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-04 12:04:29.210+0900 D/AUL_PAD ( 8503): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-04 12:04:29.210+0900 I/CAPI_APPFW_APPLICATION( 8503): app_main.c: ui_app_main(788) > app_efl_main
06-04 12:04:29.210+0900 D/LAUNCH  ( 8503): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-04 12:04:29.210+0900 D/APP_CORE( 8503): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-04 12:04:29.210+0900 D/APP_CORE( 8503): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-04 12:04:29.210+0900 D/APP_CORE( 8503): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-04 12:04:29.220+0900 D/APP_CORE( 8503): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-04 12:04:29.220+0900 D/AUL     ( 8503): app_sock.c: __create_server_sock(156) > pg path - already exists
06-04 12:04:29.220+0900 D/APP_CORE( 8503): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42b7520
06-04 12:04:29.220+0900 D/LAUNCH  ( 8503): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-04 12:04:29.220+0900 I/CAPI_APPFW_APPLICATION( 8503): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-04 12:04:29.260+0900 D/LAUNCH  ( 8503): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
06-04 12:04:29.260+0900 E/E17     ( 2748): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02a00002)
06-04 12:04:29.260+0900 D/APP_CORE( 8503): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-04 12:04:29.260+0900 E/E17     ( 2748): e_border.c: e_border_show(2088) > BD_SHOW(0x02a00002)
06-04 12:04:29.270+0900 D/APP_CORE( 8503): appcore.c: __aul_handler(587) > [APP 8503]     AUL event: AUL_START
06-04 12:04:29.270+0900 I/APP_CORE( 8503): appcore-efl.c: __do_app(496) > [APP 8503] Event: RESET State: CREATED
06-04 12:04:29.270+0900 D/APP_CORE( 8503): appcore-efl.c: __do_app(527) > [APP 8503] RESET
06-04 12:04:29.270+0900 D/LAUNCH  ( 8503): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
06-04 12:04:29.270+0900 D/APP_CORE( 8503): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-04 12:04:29.270+0900 D/APP_CORE( 8503): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-04 12:04:29.270+0900 I/CAPI_APPFW_APPLICATION( 8503): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-04 12:04:29.270+0900 D/AUL     ( 8503): service.c: __set_bundle(186) > __set_bundle
06-04 12:04:29.270+0900 D/LAUNCH  ( 8503): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-04 12:04:29.270+0900 D/APP_CORE( 8503): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-04 12:04:29.270+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 12:04:29.270+0900 E/EFL     ( 8503): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 12:04:29.270+0900 W/PROCESSMGR( 2748): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=8503
06-04 12:04:29.270+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 12:04:29.270+0900 E/EFL     ( 8503): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 12:04:29.270+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 12:04:29.270+0900 E/EFL     ( 8503): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 12:04:29.270+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 12:04:29.270+0900 E/EFL     ( 8503): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 12:04:29.270+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 12:04:29.270+0900 E/EFL     ( 8503): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 12:04:29.270+0900 E/EFL     ( 2748): eo<2748> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-04 12:04:29.270+0900 E/EFL     ( 2748): eo<2748> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-04 12:04:29.270+0900 W/APP_CORE( 8503): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2a00002
06-04 12:04:29.270+0900 D/APP_CORE( 8503): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2a00002
06-04 12:04:29.270+0900 D/APP_CORE( 8503): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-04 12:04:29.270+0900 D/AUL     ( 8503): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-04 12:04:29.270+0900 D/INDICATOR( 2851): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
06-04 12:04:29.270+0900 D/INDICATOR( 2851): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-04 12:04:29.280+0900 D/INDICATOR( 2851): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-04 12:04:29.280+0900 D/INDICATOR( 2851): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-04 12:04:29.280+0900 D/INDICATOR( 2851): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-04 12:04:29.280+0900 D/INDICATOR( 2851): main.c: _rotate_window(252) > port :: hide more icon
06-04 12:04:29.310+0900 D/AUL_PAD ( 2915): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-04 12:04:29.310+0900 W/AUL     ( 2729): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 8503, appid: org.example.example
06-04 12:04:29.310+0900 D/AUL     ( 2729): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-04 12:04:29.310+0900 E/AUL     ( 2729): simple_util.c: __trm_app_info_send_socket(330) > access
06-04 12:04:29.310+0900 D/AUL_AMD ( 2729): amd_launch.c: _start_app(2700) > add app group info
06-04 12:04:29.310+0900 E/AUL     ( 2729): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-04 12:04:29.310+0900 D/AUL_AMD ( 2729): amd_status.c: _status_add_app_info_list(427) > pid(8503) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-04 12:04:29.310+0900 D/AUL_AMD ( 2729): amd_status.c: __app_terminate_timer_cb(442) > pid(8333)
06-04 12:04:29.310+0900 W/AUL_AMD ( 2729): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
06-04 12:04:29.310+0900 D/AUL_AMD ( 2729): amd_status.c: __app_terminate_timer_cb(442) > pid(8333)
06-04 12:04:29.310+0900 W/AUL_AMD ( 2729): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
06-04 12:04:29.310+0900 D/AUL_AMD ( 2729): amd_request.c: __request_handler(838) > __request_handler: 34
06-04 12:04:29.310+0900 D/AUL_AMD ( 2729): amd_request.c: __request_handler(838) > __request_handler: 15
06-04 12:04:29.310+0900 D/PKGMGR_INFO( 2729): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-04 12:04:29.310+0900 D/PKGMGR_INFO( 2729): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-04 12:04:29.310+0900 D/RESOURCED( 2844): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 8503
06-04 12:04:29.310+0900 D/RESOURCED( 2844): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-04 12:04:29.310+0900 E/RESOURCED( 2844): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-04 12:04:29.310+0900 D/AUL_AMD ( 2729): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 8503 is org.example.example
06-04 12:04:29.310+0900 D/AUL_AMD ( 2729): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 8503 : 0
06-04 12:04:29.310+0900 D/RESOURCED( 2844): proc-main.c: resourced_proc_status_change(888) > available memory = 310
06-04 12:04:29.310+0900 D/AUL     ( 2939): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-04 12:04:29.520+0900 D/APP_CORE( 8503): appcore.c: __prt_ltime(236) > [APP 8503] first idle after reset: 314 msec
06-04 12:04:29.540+0900 E/E17     ( 2748): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
06-04 12:04:29.540+0900 D/APP_CORE( 2864): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
06-04 12:04:29.540+0900 D/APP_CORE( 2864): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-04 12:04:29.540+0900 D/APP_CORE( 2864): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-04 12:04:29.540+0900 I/APP_CORE( 2864): appcore-efl.c: __do_app(496) > [APP 2864] Event: PAUSE State: RUNNING
06-04 12:04:29.540+0900 D/APP_CORE( 2864): appcore-efl.c: __do_app(565) > [APP 2864] PAUSE
06-04 12:04:29.540+0900 I/CAPI_APPFW_APPLICATION( 2864): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-04 12:04:29.540+0900 E/cluster-home( 2864): homescreen.cpp: OnPause(84) >  app pause
06-04 12:04:29.540+0900 D/cluster-view( 2864): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-04 12:04:29.540+0900 D/cluster-view( 2864): homescreen-view-manager.cpp: AppPause(923) >  END
06-04 12:04:29.540+0900 D/APP_CORE( 2864): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-04 12:04:29.540+0900 E/APP_CORE( 2864): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-04 12:04:29.540+0900 D/AUL_AMD ( 2729): amd_status.c: _status_update_app_info_list(456) > pid(2864) status(4)
06-04 12:04:29.540+0900 D/AUL_AMD ( 2729): amd_status.c: _status_update_app_info_list(468) > pid(2864) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-04 12:04:29.540+0900 D/AUL     ( 2729): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-04 12:04:29.540+0900 W/AUL     ( 2729): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2864, appid: org.tizen.homescreen, status: bg
06-04 12:04:29.540+0900 D/AUL_AMD ( 2729): amd_launch.c: __e17_status_handler(2891) > pid(8503) status(3)
06-04 12:04:29.540+0900 D/AUL_AMD ( 2729): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-04 12:04:29.540+0900 W/AUL_AMD ( 2729): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-04 12:04:29.540+0900 W/AUL_AMD ( 2729): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-04 12:04:29.540+0900 D/AUL_AMD ( 2729): amd_status.c: _status_update_app_info_list(456) > pid(8503) status(3)
06-04 12:04:29.540+0900 D/AUL_AMD ( 2729): amd_status.c: _status_update_app_info_list(468) > pid(8503) appid(org.example.example) pkgid(org.example.example) status(3)
06-04 12:04:29.540+0900 D/AUL     ( 2729): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-04 12:04:29.540+0900 W/AUL     ( 2729): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 8503, appid: org.example.example, status: fg
06-04 12:04:29.550+0900 D/RESOURCED( 2844): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 8503
06-04 12:04:29.550+0900 D/RESOURCED( 2844): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 8503, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-04 12:04:29.550+0900 D/RESOURCED( 2844): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 8503
06-04 12:04:29.550+0900 D/DATA_PROVIDER_MASTER( 2917): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2864 is paused
06-04 12:04:29.550+0900 D/DATA_PROVIDER_MASTER( 2917): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-04 12:04:29.550+0900 I/CAPI_WIDGET_APPLICATION( 2999): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-04 12:04:29.550+0900 I/CAPI_WIDGET_APPLICATION( 2999): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-04 12:04:29.550+0900 W/AUL     ( 2999): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2999, appid: org.tizen.calendar.widget, status: bg
06-04 12:04:29.610+0900 D/APP_CORE( 8503): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2a00002 fully_obscured 0
06-04 12:04:29.610+0900 D/APP_CORE( 8503): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-04 12:04:29.610+0900 D/APP_CORE( 8503): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-04 12:04:29.610+0900 I/APP_CORE( 8503): appcore-efl.c: __do_app(496) > [APP 8503] Event: RESUME State: CREATED
06-04 12:04:29.610+0900 D/LAUNCH  ( 8503): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-04 12:04:29.610+0900 D/APP_CORE( 8503): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-04 12:04:29.610+0900 D/APP_CORE( 8503): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-04 12:04:29.610+0900 D/APP_CORE( 8503): appcore-efl.c: __do_app(607) > [APP 8503] RESUME
06-04 12:04:29.610+0900 I/APP_CORE( 8503): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-04 12:04:29.610+0900 I/APP_CORE( 8503): appcore-efl.c: __do_app(614) > [APP 8503] Initial Launching, call the resume_cb
06-04 12:04:29.610+0900 I/CAPI_APPFW_APPLICATION( 8503): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-04 12:04:29.610+0900 D/LAUNCH  ( 8503): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-04 12:04:29.610+0900 D/LAUNCH  ( 8503): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-04 12:04:29.610+0900 D/APP_CORE( 8503): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-04 12:04:29.610+0900 E/APP_CORE( 8503): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-04 12:04:29.620+0900 D/RESOURCED( 2844): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 8503, appname = org.example.example, pkgname = org.example.example
06-04 12:04:29.620+0900 D/RESOURCED( 2844): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 8503, appname = org.example.example
06-04 12:04:29.620+0900 D/RESOURCED( 2844): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 8503
06-04 12:04:29.620+0900 D/RESOURCED( 2844): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 2999, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-04 12:04:29.620+0900 D/RESOURCED( 2844): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 2999
06-04 12:04:29.620+0900 D/RESOURCED( 2844): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 2999, appname = org.tizen.calendar.widget
06-04 12:04:29.620+0900 D/RESOURCED( 2844): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 2999
06-04 12:04:29.620+0900 I/RESOURCED( 2844): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-04 12:04:29.620+0900 I/RESOURCED( 2844): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-04 12:04:29.720+0900 D/AUL_AMD ( 2729): amd_launch.c: __e17_status_handler(2910) > pid(8503) status(0)
06-04 12:04:30.000+0900 E/PKGMGR_SERVER( 8591): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-04 12:04:30.000+0900 E/PKGMGR_SERVER( 8591): pkgmgr-server.c: main(2265) > package manager server terminated.
06-04 12:04:30.320+0900 D/AUL_PAD ( 2915): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-04 12:04:30.320+0900 D/AUL_PAD ( 8669): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-04 12:04:30.320+0900 D/AUL_PAD ( 2915): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-04 12:04:30.660+0900 I/user_tag0( 8503): /opt/usr/apps/org.example.example/data/feeding.db
06-04 12:04:30.670+0900 I/tag     ( 8503): eonji~
06-04 12:04:30.710+0900 D/PROCESSMGR( 2748): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x601de7 
06-04 12:04:30.820+0900 D/AUL_AMD ( 2729): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-04 12:04:30.820+0900 D/RUA     ( 2729): rua.c: rua_add_history(179) > rua_add_history start
06-04 12:04:30.820+0900 D/RUA     ( 2729): rua.c: rua_add_history(247) > rua_add_history ok
06-04 12:04:31.340+0900 D/AUL_PAD ( 8669): launchpad_loader.c: main(588) > sleeping 1 sec...
06-04 12:04:31.340+0900 D/AUL_PAD ( 8669): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-04 12:04:31.340+0900 D/AUL_PAD ( 8669): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b7be1760
06-04 12:04:31.340+0900 D/AUL_PAD ( 8669): preload.h: __preload_init(69) > get pre-initialization function
06-04 12:04:31.340+0900 D/AUL_PAD ( 8669): preload.h: __preload_init(73) > get shutdown function
06-04 12:04:31.340+0900 D/AUL_PAD ( 8669): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b7be1a40
06-04 12:04:31.340+0900 D/AUL_PAD ( 8669): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b7be3640
06-04 12:04:31.340+0900 D/AUL_PAD ( 8669): preload.h: __preload_init(69) > get pre-initialization function
06-04 12:04:31.350+0900 D/AUL_PAD ( 8669): preload.h: __preload_init(73) > get shutdown function
06-04 12:04:31.350+0900 D/AUL_PAD ( 8669): preexec.h: __preexec_init(76) > preexec start
06-04 12:04:31.350+0900 D/AUL_PAD ( 8669): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-04 12:04:31.350+0900 D/AUL     ( 8669): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-04 12:04:31.350+0900 D/AUL     ( 8669): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-04 12:04:31.350+0900 D/AUL     ( 8669): process_pool.c: __connect_to_launchpad(132) > send(8669) : 4
06-04 12:04:31.350+0900 D/AUL_PAD ( 2915): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-04 12:04:31.350+0900 D/AUL_PAD ( 2915): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-04 12:04:31.350+0900 D/AUL_PAD ( 2915): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-04 12:04:31.350+0900 D/AUL_PAD ( 2915): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-04 12:04:31.350+0900 D/AUL_PAD ( 2915): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-04 12:04:31.350+0900 D/AUL_PAD ( 2915): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-04 12:04:31.350+0900 D/AUL_PAD ( 2915): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-04 12:04:31.350+0900 D/AUL_PAD ( 2915): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-04 12:04:31.350+0900 D/AUL_PAD ( 2915): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 8669
06-04 12:04:31.350+0900 D/AUL     ( 8669): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-04 12:04:31.360+0900 D/PROCESSMGR( 2748): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x601de7 
06-04 12:04:31.450+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 12:04:31.460+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 12:04:31.470+0900 D/AUL_PAD ( 8669): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-04 12:04:31.470+0900 D/AUL_PAD ( 8669): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-04 12:04:31.470+0900 D/AUL_PAD ( 8669): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-04 12:04:31.470+0900 D/AUL_PAD ( 8669): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-04 12:04:31.490+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 12:04:31.510+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 12:04:31.510+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 12:04:31.510+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 12:04:31.510+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 12:04:31.510+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 12:04:31.510+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 12:04:31.510+0900 D/IMMODULE( 8503): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
06-04 12:04:31.510+0900 D/ISF_SOCKET( 8503): scim_socket.cpp: connect(515) > ppid:2915  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 12:04:31.510+0900 D/ISF_SOCKET( 8503): scim_socket.cpp: connect(524) > connect() succeeded
06-04 12:04:31.520+0900 D/ISF_SOCKET( 8503): scim_socket.cpp: connect(515) > ppid:2915  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 12:04:31.520+0900 D/ISF_SOCKET( 8503): scim_socket.cpp: connect(524) > connect() succeeded
06-04 12:04:31.520+0900 D/ISF_SOCKET( 8503): scim_socket.cpp: connect(515) > ppid:2915  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 12:04:31.520+0900 D/ISF_SOCKET( 8503): scim_socket.cpp: connect(524) > connect() succeeded
06-04 12:04:31.520+0900 D/ISF_QUERY( 8503): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
06-04 12:04:31.530+0900 D/ISF_QUERY( 8503): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 12:04:31.530+0900 D/ISF_QUERY( 8503): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 12:04:31.530+0900 D/ISF_QUERY( 8503): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 12:04:31.530+0900 D/ISF_QUERY( 8503): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 12:04:31.530+0900 D/ISF_QUERY( 8503): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 12:04:31.530+0900 D/ISF_QUERY( 8503): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 12:04:31.530+0900 D/ISF_SOCKET( 8503): scim_socket.cpp: connect(515) > ppid:2915  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 12:04:31.530+0900 D/ISF_SOCKET( 8503): scim_socket.cpp: connect(524) > connect() succeeded
06-04 12:04:31.530+0900 D/IMMODULE( 8503): scim_panel_client.cpp: open_connection(162) > 
06-04 12:04:31.530+0900 D/ISF_SOCKET( 8503): scim_socket.cpp: connect(515) > ppid:2915  trying connect() to local:/tmp/scim-panel-socket:0, example
06-04 12:04:31.530+0900 D/ISF_SOCKET( 8503): scim_socket.cpp: connect(524) > connect() succeeded
06-04 12:04:31.530+0900 D/ISF_SOCKET( 8503): scim_socket.cpp: connect(515) > ppid:2915  trying connect() to local:/tmp/scim-panel-socket:0, example
06-04 12:04:31.530+0900 D/ISF_SOCKET( 8503): scim_socket.cpp: connect(524) > connect() succeeded
06-04 12:04:31.530+0900 D/IMMODULE( 8503): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 1
06-04 12:04:32.150+0900 D/PROCESSMGR( 2748): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x601de7 
06-04 12:04:32.310+0900 I/tag     ( 8503): insert
06-04 12:04:32.310+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 12:04:32.320+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 12:04:32.320+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 12:04:32.320+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 12:04:32.320+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 12:04:32.720+0900 D/PROCESSMGR( 2748): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x601de7 
06-04 12:04:32.870+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 12:04:32.870+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 12:04:32.920+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 12:04:32.920+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 12:04:32.920+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 12:04:32.920+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 12:04:32.920+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 12:04:32.920+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 12:04:32.920+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 12:04:33.730+0900 D/PROCESSMGR( 2748): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2a00002
06-04 12:04:33.730+0900 D/PROCESSMGR( 2748): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x601de7 
06-04 12:04:33.850+0900 D/PROCESSMGR( 2748): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x601de7 
06-04 12:04:34.290+0900 D/PROCESSMGR( 2748): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x601de7 
06-04 12:04:34.560+0900 D/APP_CORE( 2864): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
06-04 12:04:34.560+0900 I/APP_CORE( 2864): appcore-efl.c: __do_app(496) > [APP 2864] Event: MEM_FLUSH State: PAUSED
06-04 12:04:34.560+0900 D/APP_CORE( 2864): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
06-04 12:04:34.560+0900 D/APP_CORE( 2864): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2864
06-04 12:04:34.560+0900 D/APP_CORE( 2864): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
06-04 12:04:34.560+0900 D/RESOURCED( 2844): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2864
06-04 12:04:34.640+0900 I/tag     ( 8503): insert
06-04 12:04:34.640+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 12:04:34.640+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 12:04:34.640+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 12:04:34.640+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 12:04:34.650+0900 E/EFL     ( 8503): edje<8503> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 12:04:35.290+0900 D/PROCESSMGR( 2748): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x601de7 
06-04 12:04:36.080+0900 I/user_tag0( 8503): /opt/usr/apps/org.example.example/data/feeding.db
06-04 12:04:36.080+0900 I/tag     ( 8503): eonji~
06-04 12:04:36.080+0900 I/tag     ( 8503): 들어와!
06-04 12:04:36.080+0900 I/tag     ( 8503): 언지
06-04 12:04:36.080+0900 I/tag     ( 8503): 12 4
06-04 12:04:36.080+0900 I/tag     ( 8503): 12:4
06-04 12:04:36.080+0900 I/saved time( 8503): 12 4
06-04 12:04:36.080+0900 I/tag     ( 8503): 들어와!
06-04 12:04:36.080+0900 I/tag     ( 8503): 언지
06-04 12:04:36.080+0900 I/tag     ( 8503): 12 2
06-04 12:04:36.080+0900 I/tag     ( 8503): 12:2
06-04 12:04:36.080+0900 I/saved time( 8503): 12 2
06-04 12:04:36.120+0900 W/CRASH_MANAGER( 8672): worker.c: worker_job(1204) > 1108503657861149654547
