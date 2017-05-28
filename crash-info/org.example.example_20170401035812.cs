S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 11508
Date: 2017-04-01 03:58:12+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x14

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb7a3e6c8, esi = 0x8000b45b
ebp = 0xbff1c6d8, esp = 0xbff1c6a0
eax = 0x00000000, ebx = 0xb731d5f0
ecx = 0x00000059, edx = 0x00000015
eip = 0xb7174bbf

Memory Information
MemTotal:      123 KB
MemFree:        20 KB
Buffers:         8 KB
Cached:     181428 KB
VmPeak:      79200 KB
VmSize:      79200 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14016 KB
VmRSS:       14016 KB
VmData:      19560 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33316 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 11508 TID = 11508
11508 11531 11535 

Maps Information
b2ca5000 b2caf000 r-xp /usr/lib/libfeedback.so.0.1.4
b2cb5000 b2cc1000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2cc2000 b2ce3000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2ce8000 b2ce9000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2cea000 b2cef000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2cf0000 b2cf1000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2cf2000 b2cf4000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2cf5000 b2cf7000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2cf8000 b2d04000 r-xp /usr/lib/libdrm.so.2.4.0
b2d05000 b2d08000 r-xp /usr/lib/libdri2.so.0.0.0
b2d09000 b2d13000 r-xp /usr/lib/libtbm.so.1.0.0
b2d1a000 b2d1b000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2d1c000 b2d1d000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2d1e000 b2d21000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b2d22000 b2d25000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b2d26000 b2d3b000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2d3c000 b2d4e000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3657000 b365d000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b365e000 b37a2000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37b3000 b37b4000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37b5000 b37be000 r-xp /usr/lib/libefl-extension.so.0.1.0
b37bf000 b37c2000 r-xp /opt/usr/apps/org.example.example/bin/example
b37c4000 b37fd000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4200000 b420b000 r-xp /lib/libnss_files-2.20-2014.11.so
b420d000 b4218000 r-xp /lib/libnss_nis-2.20-2014.11.so
b421a000 b4231000 r-xp /lib/libnsl-2.20-2014.11.so
b4235000 b423d000 r-xp /lib/libnss_compat-2.20-2014.11.so
b423f000 b4263000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4264000 b4265000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4266000 b4269000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b426a000 b4271000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4272000 b427c000 r-xp /usr/lib/libsensord-share.so
b427d000 b4299000 r-xp /usr/lib/libsensor.so.1.2.0
b429b000 b42a4000 r-xp /usr/lib/libappcore-common.so.1.1
b42a7000 b42a9000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42be000 b42c0000 r-xp /usr/lib/libXau.so.6.0.0
b42c1000 b42e3000 r-xp /usr/lib/libxcb.so.1.1.0
b42e5000 b42ee000 r-xp /lib/libcrypt-2.20-2014.11.so
b4317000 b4319000 r-xp /usr/lib/libiri.so
b431a000 b4340000 r-xp /lib/libexpat.so.1.5.2
b4342000 b43ad000 r-xp /usr/lib/libssl.so.1.0.0
b43b3000 b43bf000 r-xp /usr/lib/libethumb.so.1.13.0
b43c0000 b43c4000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43c5000 b4616000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b91000 b5ba1000 r-xp /usr/lib/libXi.so.6.1.0
b5ba2000 b5ba4000 r-xp /usr/lib/libXgesture.so.7.0.0
b5ba5000 b5bab000 r-xp /usr/lib/libXtst.so.6.1.0
b5bac000 b5bb6000 r-xp /usr/lib/libXrender.so.1.3.0
b5bb7000 b5bc0000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bc2000 b5bc4000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bc5000 b5bca000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bcb000 b5bdd000 r-xp /usr/lib/libXext.so.6.4.0
b5bde000 b5be0000 r-xp /usr/lib/libXdamage.so.1.1.0
b5be1000 b5be3000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5be5000 b5d27000 r-xp /usr/lib/libX11.so.6.3.0
b5d2b000 b5d35000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d36000 b5d4c000 r-xp /usr/lib/libudev.so.1.6.0
b5d4f000 b5d53000 r-xp /lib/libattr.so.1.1.0
b5d54000 b5d83000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d85000 b5d8b000 r-xp /usr/lib/libffi.so.6.0.2
b5d8c000 b5daf000 r-xp /lib/libz.so.1.2.8
b5db0000 b5db3000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5db4000 b5f10000 r-xp /usr/lib/libxml2.so.2.9.2
b5f16000 b5ffd000 r-xp /usr/lib/libstdc++.so.6.0.20
b600a000 b600d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b600e000 b6030000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6031000 b6045000 r-xp /lib/libresolv-2.20-2014.11.so
b6049000 b606d000 r-xp /usr/lib/liblzma.so.5.0.3
b606e000 b6070000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6072000 b607c000 r-xp /usr/lib/libembryo.so.1.13.0
b607d000 b60a6000 r-xp /usr/lib/libpng12.so.0.50.0
b60a7000 b60f0000 r-xp /usr/lib/libjpeg.so.8.0.2
b6101000 b6108000 r-xp /lib/librt-2.20-2014.11.so
b610a000 b6129000 r-xp /usr/lib/libector.so.1.13.0
b612c000 b6159000 r-xp /usr/lib/liblua-5.1.so
b615a000 b61ea000 r-xp /usr/lib/libfreetype.so.6.11.3
b61ee000 b622c000 r-xp /usr/lib/libfontconfig.so.1.8.0
b622d000 b6243000 r-xp /usr/lib/libfribidi.so.0.3.1
b6244000 b629d000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62a0000 b62eb000 r-xp /lib/libm-2.20-2014.11.so
b62ed000 b62ff000 r-xp /usr/lib/libeio.so.1.13.0
b6300000 b6303000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6304000 b630a000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b630b000 b632e000 r-xp /usr/lib/libefreet.so.1.13.0
b6331000 b635c000 r-xp /usr/lib/libeldbus.so.1.13.0
b635d000 b6391000 r-xp /usr/lib/libecore_con.so.1.13.0
b6393000 b639c000 r-xp /usr/lib/libecore_imf.so.1.13.0
b639d000 b63a6000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63a7000 b63ba000 r-xp /usr/lib/libeo.so.1.13.0
b63bc000 b63cf000 r-xp /usr/lib/libecore_input.so.1.13.0
b63d0000 b63d7000 r-xp /usr/lib/libecore_file.so.1.13.0
b63d8000 b63fb000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63fc000 b6428000 r-xp /usr/lib/libeet.so.1.13.0
b6431000 b649c000 r-xp /usr/lib/libeina.so.1.13.0
b649f000 b64b6000 r-xp /usr/lib/libefl.so.1.13.0
b64b8000 b661f000 r-xp /usr/lib/libicuuc.so.51.1
b662d000 b6839000 r-xp /usr/lib/libicui18n.so.51.1
b6841000 b6890000 r-xp /usr/lib/libecore_x.so.1.13.0
b6892000 b68ac000 r-xp /lib/libgcc_s-4.9.so.1
b68ae000 b68b2000 r-xp /lib/libcap.so.2.21
b68b3000 b68f9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68fa000 b6901000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6903000 b6955000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6957000 b6ae2000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6ae7000 b6bb5000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bb8000 b6bbc000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bbd000 b6bcc000 r-xp /usr/lib/libvconf.so.0.2.45
b6bcd000 b6bd0000 r-xp /usr/lib/libvasum.so.0.3.1
b6bd1000 b6bd4000 r-xp /usr/lib/libttrace.so.1.1
b6bd6000 b6bda000 r-xp /usr/lib/libiniparser.so.0
b6bdb000 b6c0b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c0c000 b6c15000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c16000 b6c3b000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c3c000 b6c4c000 r-xp /usr/lib/libunwind.so.8.0.1
b6c56000 b6e04000 r-xp /lib/libc-2.20-2014.11.so
b6e0c000 b6f4f000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f51000 b6fa9000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6faa000 b6fde000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fe1000 b70b5000 r-xp /usr/lib/libedje.so.1.13.0
b70b8000 b70e4000 r-xp /usr/lib/libecore.so.1.13.0
b70f5000 b731b000 r-xp /usr/lib/libevas.so.1.13.0
b7343000 b735b000 r-xp /lib/libpthread-2.20-2014.11.so
b735f000 b76d9000 r-xp /usr/lib/libelementary.so.1.13.0
b76f9000 b76fd000 r-xp /usr/lib/libsmack.so.1.0.0
b76fe000 b7707000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7708000 b770b000 r-xp /usr/lib/libdlog.so.0.0.0
b770c000 b7711000 r-xp /usr/lib/libbundle.so.0.1.22
b7712000 b7715000 r-xp /lib/libdl-2.20-2014.11.so
b7717000 b773c000 r-xp /usr/lib/libaul.so.0.1.0
b773f000 b7741000 r-xp /usr/lib/libappsvc.so.0.1.0
b7742000 b7747000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7748000 b774f000 r-xp /usr/lib/libappcore-efl.so.1.1
b7751000 b7756000 r-xp /usr/lib/libsys-assert.so
b7759000 b775a000 r-xp [vdso]
b775a000 b777c000 r-xp /lib/ld-2.20-2014.11.so
b777e000 b7786000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:11508)
Call Stack Count: 27
 0: (0xb7174bbf) [/usr/lib/libevas.so.1] + 0x7fbbf
 1: (0xb7166ce8) [/usr/lib/libevas.so.1] + 0x71ce8
 2: evas_obj_size_hint_min_set + 0xb9 (0xb7161629) [/usr/lib/libevas.so.1] + 0x6c629
 3: evas_object_size_hint_min_set + 0x60 (0xb716efa0) [/usr/lib/libevas.so.1] + 0x79fa0
 4: (0xb75077df) [/usr/lib/libelementary.so.1] + 0x1a87df
 5: elm_obj_layout_sizing_eval + 0x99 (0xb750a559) [/usr/lib/libelementary.so.1] + 0x1ab559
 6: (0xb7511205) [/usr/lib/libelementary.so.1] + 0x1b2205
 7: evas_obj_smart_add + 0x99 (0xb717f809) [/usr/lib/libevas.so.1] + 0x8a809
 8: (0xb750824b) [/usr/lib/libelementary.so.1] + 0x1a924b
 9: evas_obj_smart_add + 0x99 (0xb717f809) [/usr/lib/libevas.so.1] + 0x8a809
10: (0xb7182d8b) [/usr/lib/libevas.so.1] + 0x8dd8b
11: eo_constructor + 0x99 (0xb63b1899) [/usr/lib/libeo.so.1] + 0xa899
12: (0xb75d04a6) [/usr/lib/libelementary.so.1] + 0x2714a6
13: eo_constructor + 0x99 (0xb63b1899) [/usr/lib/libeo.so.1] + 0xa899
14: (0xb7512c37) [/usr/lib/libelementary.so.1] + 0x1b3c37
15: eo_constructor + 0x99 (0xb63b1899) [/usr/lib/libeo.so.1] + 0xa899
16: (0xb7508692) [/usr/lib/libelementary.so.1] + 0x1a9692
17: eo_constructor + 0x99 (0xb63b1899) [/usr/lib/libeo.so.1] + 0xa899
18: elm_label_add + 0x77 (0xb7506cf7) [/usr/lib/libelementary.so.1] + 0x1a7cf7
19: create_base_gui + 0x3e8 (0xb37c0ef8) [/opt/usr/apps/org.example.example/bin/example] + 0x1ef8
20: app_create + 0x2c (0xb37c097c) [/opt/usr/apps/org.example.example/bin/example] + 0x197c
21: (0xb774465b) [/usr/lib/libcapi-appfw-application.so.0] + 0x265b
22: appcore_efl_main + 0x327 (0xb774bc27) [/usr/lib/libappcore-efl.so.1] + 0x3c27
23: ui_app_main + 0x140 (0xb7744c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
24: main + 0x27e (0xb37c08ee) [/opt/usr/apps/org.example.example/bin/example] + 0x18ee
25: create_base_gui + 0x638 (0xb7780148) [/opt/usr/apps/org.example.example/bin/example] + 0xb7780148
26: __libc_start_main + 0xde (0xb6c6de4e) [/lib/libc.so.6] + 0x17e4e
End of Call Stack

Package Information
Package Name: org.example.example
Package ID : org.example.example
Version: 1.0.0
Package Type: tpk
App Name: example
App ID: org.example.example
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
PANEL_EFL( 3052): isf_panel_efl.cpp: _package_manager_event_cb(1380) > isf_db_select_appids_by_pkgid returned 0.
04-01 03:58:06.724+0900 D/PKGMGR  (11428): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 03:58:06.724+0900 D/PKGMGR  ( 2960): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 03:58:06.724+0900 D/DATA_PROVIDER_MASTER( 2960): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.example] 100
04-01 03:58:06.724+0900 D/PKGMGR  ( 2960): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 03:58:06.724+0900 D/DATA_PROVIDER_MASTER( 2960): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.example] ok
04-01 03:58:06.724+0900 D/DATA_PROVIDER_MASTER( 2960): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.example], event_type[1]
04-01 03:58:06.724+0900 D/PKGMGR  (11428): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 03:58:06.724+0900 D/DATA_PROVIDER_MASTER( 2960): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
04-01 03:58:06.724+0900 D/DATA_PROVIDER_MASTER( 2960): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
04-01 03:58:06.724+0900 D/DATA_PROVIDER_MASTER( 2960): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
04-01 03:58:06.724+0900 D/DATA_PROVIDER_MASTER( 2960): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.example]
04-01 03:58:06.844+0900 D/rpm-installer(11430): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
04-01 03:58:06.844+0900 D/rpm-installer(11430): rpm-appcore-intf.c: main(259) > ------------------------------------------------
04-01 03:58:06.844+0900 D/rpm-installer(11430): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
04-01 03:58:06.844+0900 D/rpm-installer(11430): rpm-appcore-intf.c: main(261) > ------------------------------------------------
04-01 03:58:06.854+0900 D/PKGMGR_SERVER(11340): pkgmgr-server.c: sighandler(387) > child exit [11430]
04-01 03:58:06.854+0900 E/PKGMGR_SERVER(11340): pkgmgr-server.c: sighandler(402) > child NORMAL exit [11430]
04-01 03:58:07.034+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(838) > __request_handler: 0
04-01 03:58:07.034+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
04-01 03:58:07.034+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
04-01 03:58:07.034+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
04-01 03:58:07.034+0900 I/AUL     ( 2763): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
04-01 03:58:07.034+0900 D/AUL     ( 2763): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 11480, pid = 11482
04-01 03:58:07.034+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
04-01 03:58:07.034+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
04-01 03:58:07.034+0900 I/AUL     ( 2763): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
04-01 03:58:07.034+0900 E/AUL_AMD ( 2763): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
04-01 03:58:07.034+0900 W/AUL_AMD ( 2763): amd_launch.c: _start_app(2233) > caller pid : 11482
04-01 03:58:07.034+0900 E/AUL_AMD ( 2763): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
04-01 03:58:07.034+0900 W/AUL_AMD ( 2763): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
04-01 03:58:07.034+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2648) > process_pool: false
04-01 03:58:07.034+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
04-01 03:58:07.034+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
04-01 03:58:07.034+0900 W/AUL_AMD ( 2763): amd_launch.c: _start_app(2665) > pad pid(-5)
04-01 03:58:07.034+0900 D/AUL_AMD ( 2763): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
04-01 03:58:07.034+0900 D/AUL_AMD ( 2763): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
04-01 03:58:07.034+0900 D/AUL     ( 2763): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
04-01 03:58:07.034+0900 W/AUL_PAD ( 2958): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
04-01 03:58:07.034+0900 D/AUL     ( 2958): process_pool.c: __send_pkt_raw_data(219) > send(13) : 620 / 620
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 11248, bin path: /opt/usr/apps/org.example.example/bin/example
04-01 03:58:07.034+0900 W/AUL_PAD ( 2958): launchpad.c: __send_result_to_caller(265) > Check app launching
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
04-01 03:58:07.034+0900 D/RESOURCED( 2892): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
04-01 03:58:07.034+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
04-01 03:58:07.034+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
04-01 03:58:07.034+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
04-01 03:58:07.034+0900 D/RESOURCED( 2892): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 2
04-01 03:58:07.064+0900 E/RESOURCED( 2892): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-01 03:58:07.064+0900 D/AUL_PAD (11248): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
04-01 03:58:07.064+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
04-01 03:58:07.064+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
04-01 03:58:07.064+0900 D/AUL     (11248): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (11270) is sent.
04-01 03:58:07.064+0900 D/AUL     (11248): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 11270, signo: 10
04-01 03:58:07.064+0900 D/AUL     (11248): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
04-01 03:58:07.064+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
04-01 03:58:07.064+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
04-01 03:58:07.064+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
04-01 03:58:07.064+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
04-01 03:58:07.064+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : MwAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEQAAADE0OTA5ODY2ODcvNjYzODUA##
04-01 03:58:07.064+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
04-01 03:58:07.064+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAxMTQ4MgA=##
04-01 03:58:07.064+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
04-01 03:58:07.064+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
04-01 03:58:07.064+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
04-01 03:58:07.064+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
04-01 03:58:07.064+0900 D/AUL_PAD (11248): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
04-01 03:58:07.064+0900 I/CAPI_APPFW_APPLICATION(11248): app_main.c: ui_app_main(788) > app_efl_main
04-01 03:58:07.064+0900 D/LAUNCH  (11248): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
04-01 03:58:07.064+0900 D/APP_CORE(11248): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
04-01 03:58:07.064+0900 D/APP_CORE(11248): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
04-01 03:58:07.064+0900 D/APP_CORE(11248): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
04-01 03:58:07.064+0900 D/APP_CORE(11248): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
04-01 03:58:07.064+0900 D/AUL     (11248): app_sock.c: __create_server_sock(156) > pg path - already exists
04-01 03:58:07.064+0900 D/APP_CORE(11248): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42d9520
04-01 03:58:07.064+0900 D/LAUNCH  (11248): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
04-01 03:58:07.064+0900 I/CAPI_APPFW_APPLICATION(11248): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
04-01 03:58:07.084+0900 E/EFL     (11248): <11248> lib/edje/edje_smart.c:22 edje_object_add() safety check failed: evas == NULL
04-01 03:58:07.104+0900 W/CRASH_MANAGER(11487): worker.c: worker_job(1204) > 11112486578611490986687
04-01 03:58:07.164+0900 E/AUL_PAD ( 2958): launchpad.c: __send_result_to_caller(280) > error founded when being launched with 11248
04-01 03:58:07.164+0900 E/AUL_PAD ( 2958): launchpad.c: __send_result_to_caller(282) > The app process might be terminated while we are wating 11248
04-01 03:58:07.164+0900 E/AUL_PAD ( 2958): launchpad.c: __send_result_to_caller(312) > process launched, but cmdline not changed
04-01 03:58:07.164+0900 W/AUL     ( 2763): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 11248, appid: org.example.example
04-01 03:58:07.164+0900 D/AUL     ( 2763): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
04-01 03:58:07.164+0900 E/AUL     ( 2763): simple_util.c: __trm_app_info_send_socket(330) > access
04-01 03:58:07.164+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2700) > add app group info
04-01 03:58:07.164+0900 E/AUL     ( 2763): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
04-01 03:58:07.164+0900 D/AUL_AMD ( 2763): amd_status.c: _status_add_app_info_list(427) > pid(11248) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
04-01 03:58:07.164+0900 D/RESOURCED( 2892): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 11248
04-01 03:58:07.164+0900 D/RESOURCED( 2892): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
04-01 03:58:07.164+0900 E/RESOURCED( 2892): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
04-01 03:58:07.164+0900 D/RESOURCED( 2892): proc-main.c: resourced_proc_status_change(888) > available memory = 283
04-01 03:58:07.864+0900 E/VCONF   (11487): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
04-01 03:58:07.864+0900 E/VCONF   (11487): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
04-01 03:58:07.864+0900 E/VCONF   (11487): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
04-01 03:58:07.864+0900 E/VCONF   (11487): vconf.c: vconf_get_str(2891) > vconf_get_str(11487) : db/menu_widget/language error
04-01 03:58:07.864+0900 E/PKGMGR_INFO(11487): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
04-01 03:58:07.864+0900 D/PKGMGR_INFO(11487): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3502) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
04-01 03:58:07.864+0900 D/PKGMGR_INFO(11487): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3508) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='No Locale' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
04-01 03:58:07.864+0900 E/VCONF   (11487): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
04-01 03:58:07.864+0900 E/VCONF   (11487): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
04-01 03:58:07.864+0900 E/VCONF   (11487): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
04-01 03:58:07.864+0900 E/VCONF   (11487): vconf.c: vconf_get_str(2891) > vconf_get_str(11487) : db/menu_widget/language error
04-01 03:58:07.864+0900 E/PKGMGR_INFO(11487): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
04-01 03:58:07.864+0900 D/PKGMGR_INFO(11487): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
04-01 03:58:07.864+0900 D/PKGMGR_INFO(11487): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
04-01 03:58:07.864+0900 E/VCONF   (11487): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
04-01 03:58:07.864+0900 E/VCONF   (11487): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
04-01 03:58:07.864+0900 E/VCONF   (11487): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
04-01 03:58:07.864+0900 E/VCONF   (11487): vconf.c: vconf_get_str(2891) > vconf_get_str(11487) : db/menu_widget/language error
04-01 03:58:07.864+0900 E/PKGMGR_INFO(11487): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
04-01 03:58:07.864+0900 D/PKGMGR_INFO(11487): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
04-01 03:58:07.864+0900 D/PKGMGR_INFO(11487): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
04-01 03:58:07.864+0900 E/VCONF   (11487): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
04-01 03:58:07.864+0900 E/VCONF   (11487): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
04-01 03:58:07.864+0900 E/VCONF   (11487): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
04-01 03:58:07.864+0900 E/VCONF   (11487): vconf.c: vconf_get_str(2891) > vconf_get_str(11487) : db/menu_widget/language error
04-01 03:58:07.864+0900 E/PKGMGR_INFO(11487): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
04-01 03:58:07.984+0900 D/LAUNCH  (11499): appcore-efl.c: appcore_efl_main(1692) > [crash-popup:Application:main:done]
04-01 03:58:07.984+0900 D/PKGMGR_INFO(11499): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.crash-popup/bin/crash-popup' and package_app_info.app_disable IN ('false','False')
04-01 03:58:07.984+0900 D/PKGMGR_INFO(11499): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.crash-popup/bin/crash-popup' and package_app_info.app_disable IN ('false','False')
04-01 03:58:07.984+0900 D/AUL     (11499): pkginfo.c: aul_app_get_appid_bypid(241) > [SECURE_LOG] appid for 11499 is org.tizen.crash-popup
04-01 03:58:07.994+0900 E/PKGMGR_SERVER(11340): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-01 03:58:07.994+0900 E/PKGMGR_SERVER(11340): pkgmgr-server.c: main(2265) > package manager server terminated.
04-01 03:58:08.034+0900 D/APP_CORE(11499): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
04-01 03:58:08.034+0900 D/APP_CORE(11499): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /usr/apps/org.tizen.crash-popup/res/locale
04-01 03:58:08.034+0900 D/APP_CORE(11499): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
04-01 03:58:08.034+0900 D/APP_CORE(11499): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
04-01 03:58:08.034+0900 D/APP_CORE(11499): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb7760520
04-01 03:58:08.034+0900 D/LAUNCH  (11499): appcore-efl.c: __before_loop(1136) > [crash-popup:Platform:appcore_init:done]
04-01 03:58:08.044+0900 D/APP_CORE(11499): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
04-01 03:58:08.044+0900 D/LAUNCH  (11499): appcore-efl.c: __before_loop(1154) > [crash-popup:Application:create:done]
04-01 03:58:08.044+0900 D/APP_CORE(11499): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
04-01 03:58:08.164+0900 D/AUL_PAD ( 2958): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
04-01 03:58:08.164+0900 D/AUL_PAD (11508): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
04-01 03:58:08.164+0900 D/AUL_PAD ( 2958): sigchild.h: __send_app_launch_signal(131) > send launch signal done
04-01 03:58:08.164+0900 D/AUL_PAD ( 2958): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
04-01 03:58:08.164+0900 D/AUL_PAD ( 2958): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
04-01 03:58:08.164+0900 D/AUL_PAD ( 2958): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
04-01 03:58:08.164+0900 D/AUL_PAD ( 2958): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
04-01 03:58:08.164+0900 D/AUL_PAD ( 2958): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
04-01 03:58:08.164+0900 D/AUL_PAD ( 2958): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
04-01 03:58:08.164+0900 D/AUL_PAD ( 2958): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
04-01 03:58:08.164+0900 I/AUL_PAD ( 2958): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 11248 pgid = 11248
04-01 03:58:08.164+0900 I/AUL_PAD ( 2958): sigchild.h: __sigchild_action(142) > dead_pid(11248)
04-01 03:58:08.164+0900 D/AUL_AMD ( 2763): amd_launch.c: __grab_timeout_handler(1445) > pid(11248) ecore_x_pointer_ungrab
04-01 03:58:08.164+0900 D/AUL_AMD ( 2763): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
04-01 03:58:08.164+0900 W/AUL_AMD ( 2763): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-01 03:58:08.164+0900 W/AUL_AMD ( 2763): amd_launch.c: __grab_timeout_handler(1447) > back key ungrab error
04-01 03:58:08.164+0900 D/AUL_PAD ( 2958): sigchild.h: __send_app_dead_signal(90) > send dead signal done
04-01 03:58:08.164+0900 I/AUL_PAD ( 2958): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
04-01 03:58:08.164+0900 I/AUL_PAD ( 2958): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
04-01 03:58:08.164+0900 E/AUL_PAD ( 2958): launchpad.c: main(688) > error reading sigchld info
04-01 03:58:08.164+0900 I/ESD     ( 2974): esd_main.c: __esd_app_dead_handler(1771) > pid: 11248
04-01 03:58:08.164+0900 D/STARTER ( 2890): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 11248 is termianted
04-01 03:58:08.164+0900 D/STARTER ( 2890): starter.c: _check_dead_signal(202) > [_check_dead_signal:202] Unknown process, ignore it
04-01 03:58:08.164+0900 W/AUL_AMD ( 2763): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 11248
04-01 03:58:08.164+0900 W/AUL_AMD ( 2763): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 11248
04-01 03:58:08.164+0900 D/AUL_AMD ( 2763): amd_key.c: _unregister_key_event(179) > ===key stack===
04-01 03:58:08.164+0900 E/AUL_AMD ( 2763): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
04-01 03:58:08.164+0900 D/AUL_AMD ( 2763): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.example.example)
04-01 03:58:08.164+0900 D/AUL     ( 2763): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
04-01 03:58:08.164+0900 E/AUL     ( 2763): simple_util.c: __trm_app_info_send_socket(330) > access
04-01 03:58:08.184+0900 E/RESOURCED( 2892): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.767
04-01 03:58:08.184+0900 E/RESOURCED( 2892): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.768
04-01 03:58:08.184+0900 D/RESOURCED( 2892): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 11248
04-01 03:58:08.184+0900 D/RESOURCED( 2892): appinfo-list.c: resourced_appinfo_put(132) > appid org.example.example, pkgname = org.example.example, ref = 1
04-01 03:58:08.264+0900 E/RESOURCED( 2892): heart-abnormal.c: heart_abnormal_process_crashed(77) > Failed: dbus_message_get_args()
04-01 03:58:08.684+0900 D/AUL_AMD ( 2763): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
04-01 03:58:08.684+0900 D/RUA     ( 2763): rua.c: rua_add_history(179) > rua_add_history start
04-01 03:58:08.684+0900 D/RUA     ( 2763): rua.c: rua_add_history(247) > rua_add_history ok
04-01 03:58:08.714+0900 E/CAPI_NETWORK_WIFI( 2896): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
04-01 03:58:08.714+0900 E/INDICATOR( 2896): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001fafe)
04-01 03:58:08.714+0900 E/INDICATOR( 2896): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
04-01 03:58:08.714+0900 E/INDICATOR( 2896): 
04-01 03:58:09.254+0900 D/AUL_PAD (11508): launchpad_loader.c: main(588) > sleeping 1 sec...
04-01 03:58:09.254+0900 D/AUL_PAD (11508): preload.h: __preload_init(52) > max_cmdline_size = 1053
04-01 03:58:09.254+0900 D/AUL_PAD (11508): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b790d760
04-01 03:58:09.254+0900 D/AUL_PAD (11508): preload.h: __preload_init(69) > get pre-initialization function
04-01 03:58:09.254+0900 D/AUL_PAD (11508): preload.h: __preload_init(73) > get shutdown function
04-01 03:58:09.254+0900 D/AUL_PAD (11508): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b790da40
04-01 03:58:09.254+0900 D/AUL_PAD (11508): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b790f640
04-01 03:58:09.254+0900 D/AUL_PAD (11508): preload.h: __preload_init(69) > get pre-initialization function
04-01 03:58:09.254+0900 D/AUL_PAD (11508): preload.h: __preload_init(73) > get shutdown function
04-01 03:58:09.254+0900 D/AUL_PAD (11508): preexec.h: __preexec_init(76) > preexec start
04-01 03:58:09.254+0900 D/AUL_PAD (11508): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
04-01 03:58:09.254+0900 D/AUL     (11508): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
04-01 03:58:09.254+0900 D/AUL     (11508): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
04-01 03:58:09.254+0900 D/AUL     (11508): process_pool.c: __connect_to_launchpad(132) > send(11508) : 4
04-01 03:58:09.254+0900 D/AUL     (11508): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
04-01 03:58:09.254+0900 D/AUL_PAD ( 2958): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
04-01 03:58:09.254+0900 D/AUL_PAD ( 2958): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
04-01 03:58:09.254+0900 D/AUL_PAD ( 2958): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
04-01 03:58:09.254+0900 D/AUL_PAD ( 2958): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
04-01 03:58:09.254+0900 D/AUL_PAD ( 2958): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
04-01 03:58:09.254+0900 D/AUL_PAD ( 2958): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
04-01 03:58:09.254+0900 D/AUL_PAD ( 2958): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
04-01 03:58:09.254+0900 D/AUL_PAD ( 2958): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
04-01 03:58:09.254+0900 D/AUL_PAD ( 2958): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 11508
04-01 03:58:09.314+0900 D/AUL_PAD (11508): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
04-01 03:58:09.314+0900 D/AUL_PAD (11508): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
04-01 03:58:09.314+0900 D/AUL_PAD (11508): launchpad_loader.c: main(693) > [candidate] ecore handler add
04-01 03:58:09.314+0900 D/AUL_PAD (11508): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
04-01 03:58:11.084+0900 E/EFL     (11499): eldbus<11499> lib/eldbus/eldbus_core.c:1005 _connection_get() Error connecting to bus of type 1. error name: org.freedesktop.DBus.Error.NoServer error message: Failed to connect to socket /tmp/dbus-trhuK7pF2P: Connection refused
04-01 03:58:11.084+0900 E/EFL     (11499): <11499> lib/eldbus/eldbus_core.c:1068 eldbus_connection_get() safety check failed: conn == NULL
04-01 03:58:11.084+0900 E/EFL     (11499): elementary<11499> elm_atspi_bridge.c:4750 _elm_atspi_bridge_eo_base_constructor() Unable to connect to Session Bus
04-01 03:58:11.084+0900 D/APP_CORE(11499): appcore.c: __aul_handler(587) > [APP 11499]     AUL event: AUL_START
04-01 03:58:11.084+0900 I/APP_CORE(11499): appcore-efl.c: __do_app(496) > [APP 11499] Event: RESET State: CREATED
04-01 03:58:11.084+0900 D/APP_CORE(11499): appcore-efl.c: __do_app(527) > [APP 11499] RESET
04-01 03:58:11.084+0900 D/LAUNCH  (11499): appcore-efl.c: __do_app(529) > [crash-popup:Application:reset:start]
04-01 03:58:11.084+0900 D/APP_CORE(11499): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
04-01 03:58:11.084+0900 D/APP_CORE(11499): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
04-01 03:58:11.084+0900 E/SYSPOPUP(11499): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
04-01 03:58:11.084+0900 E/SYSPOPUP(11499): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
04-01 03:58:11.084+0900 E/SYSPOPUP(11499): syspopup_efl.c: syspopup_create(95) > popup_name or handler is NULL
04-01 03:58:11.084+0900 D/LAUNCH  (11499): appcore-efl.c: __do_app(544) > [crash-popup:Application:reset:done]
04-01 03:58:11.084+0900 D/APP_CORE(11499): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
04-01 03:58:11.124+0900 D/AUL     (11499): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
04-01 03:58:11.124+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(838) > __request_handler: 22
04-01 03:58:11.124+0900 W/AUL_AMD ( 2763): amd_request.c: __request_handler(1056) > app status : 5
04-01 03:58:11.124+0900 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(456) > pid(11499) status(5)
04-01 03:58:11.124+0900 D/APP_CORE(11499): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
04-01 03:58:11.124+0900 E/EFL     (11499): eo<11499> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x8000542b is not pointing to a valid object. Maybe it has already been freed.
04-01 03:58:11.124+0900 E/EFL     (11499): eo<11499> lib/eo/eo.c:485 _eo_do_internal() Obj (0x8000542b) is an invalid ref.
04-01 03:58:12.184+0900 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(456) > pid(11248) status(4)
04-01 03:58:12.544+0900 D/test-log( 2906): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1023) >  menu box Pick touched
04-01 03:58:12.544+0900 D/test-log( 2906): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1034) >  Long Tap Timer Start
04-01 03:58:12.684+0900 D/test-log( 2906): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1194) >  Box[0] pick ended by Up
04-01 03:58:12.684+0900 D/test-log( 2906): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1199) >  Cancel Long Tap Timer
04-01 03:58:12.684+0900 D/test-log( 2906): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1240) >  app launch state[1]
04-01 03:58:12.684+0900 D/test-log( 2906): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1249) >  touch is moved upper position!!!
04-01 03:58:12.684+0900 D/test-log( 2906): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1298) >  laundch!!!!! touch position is moved from[297.00][343.00] to[297.00][343.00]!
04-01 03:58:12.684+0900 D/cluster-view( 2906): homescreen-view-manager.cpp: IsOverScrollThreshold(997) >  is Over Scrollview TreshHold?[0]
04-01 03:58:12.684+0900 D/cluster-home( 2906): mainmenu-custom-box-impl.cpp: OnClicked(171) >  [14]MenuBox clicked
04-01 03:58:12.684+0900 D/cluster-home( 2906): mainmenu-custom-box-impl.cpp: OnClicked(184) >  launch application via service(operation APP_CONTROL_OPERATION_DEFAULT)
04-01 03:58:12.684+0900 D/AUL     ( 2906): service.c: __set_bundle(186) > __set_bundle
04-01 03:58:12.684+0900 D/AUL     ( 2906): service.c: __get_alias_appid(548) > [SECURE_LOG] alias_id : (null)
04-01 03:58:12.684+0900 D/AUL     ( 2906): service.c: __set_bundle(186) > __set_bundle
04-01 03:58:12.684+0900 D/AUL     ( 2906): service.c: __run_svc_with_pkgname(276) > [SECURE_LOG] pkg_name : org.example.example - no result
04-01 03:58:12.684+0900 D/AUL     ( 2906): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : org.example.example
04-01 03:58:12.684+0900 D/AUL     ( 2906): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(0)
04-01 03:58:12.684+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(838) > __request_handler: 0
04-01 03:58:12.684+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
04-01 03:58:12.684+0900 W/AUL_AMD ( 2763): amd_launch.c: _start_app(2231) > [SECURE_LOG] caller appid : org.tizen.homescreen
04-01 03:58:12.684+0900 W/AUL_AMD ( 2763): amd_launch.c: _start_app(2233) > caller pid : 2906
04-01 03:58:12.684+0900 D/PROCESSMGR( 2799): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002e  register trigger_timer!  pointed_win=0x40004d 
04-01 03:58:12.684+0900 D/RESOURCED( 2892): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
04-01 03:58:12.684+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2443) > win(a00002) ecore_x_pointer_grab(1)
04-01 03:58:12.684+0900 D/AUL_AMD ( 2763): amd_key.c: _key_grab(243) > _key_grab, win : a00002
04-01 03:58:12.684+0900 I/RESOURCED( 2892): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
04-01 03:58:12.684+0900 D/RESOURCED( 2892): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
04-01 03:58:12.684+0900 I/RESOURCED( 2892): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
04-01 03:58:12.694+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2448) > back key grab
04-01 03:58:12.694+0900 W/AUL_AMD ( 2763): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
04-01 03:58:12.694+0900 D/RESOURCED( 2892): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
04-01 03:58:12.694+0900 D/RESOURCED( 2892): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 2
04-01 03:58:12.694+0900 E/RESOURCED( 2892): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-01 03:58:12.694+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2518) > org.tizen.system.deviced.PmQos-AppLaunch : 0
04-01 03:58:12.694+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2648) > process_pool: false
04-01 03:58:12.694+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
04-01 03:58:12.694+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
04-01 03:58:12.694+0900 W/AUL_AMD ( 2763): amd_launch.c: _start_app(2665) > pad pid(-5)
04-01 03:58:12.694+0900 D/AUL_AMD ( 2763): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
04-01 03:58:12.694+0900 D/AUL_AMD ( 2763): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
04-01 03:58:12.694+0900 D/AUL     ( 2763): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
04-01 03:58:12.694+0900 D/AUL_PAD ( 2958): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
04-01 03:58:12.694+0900 D/AUL_PAD ( 2958): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
04-01 03:58:12.694+0900 D/AUL_PAD ( 2958): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
04-01 03:58:12.694+0900 D/AUL_PAD ( 2958): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
04-01 03:58:12.694+0900 D/AUL_PAD ( 2958): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
04-01 03:58:12.694+0900 D/AUL_PAD ( 2958): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
04-01 03:58:12.694+0900 D/AUL_PAD ( 2958): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
04-01 03:58:12.694+0900 D/AUL_PAD ( 2958): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
04-01 03:58:12.694+0900 D/AUL_PAD ( 2958): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
04-01 03:58:12.694+0900 D/AUL_PAD ( 2958): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
04-01 03:58:12.694+0900 D/AUL_PAD ( 2958): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
04-01 03:58:12.694+0900 D/AUL_PAD ( 2958): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
04-01 03:58:12.694+0900 D/AUL_PAD ( 2958): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
04-01 03:58:12.694+0900 D/AUL_PAD ( 2958): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
04-01 03:58:12.694+0900 W/AUL_PAD ( 2958): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
04-01 03:58:12.694+0900 D/AUL     ( 2958): process_pool.c: __send_pkt_raw_data(219) > send(13) : 884 / 884
04-01 03:58:12.694+0900 D/AUL_PAD ( 2958): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 11508, bin path: /opt/usr/apps/org.example.example/bin/example
04-01 03:58:12.694+0900 W/AUL_PAD ( 2958): launchpad.c: __send_result_to_caller(265) > Check app launching
04-01 03:58:12.694+0900 D/AUL_PAD ( 2958): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
04-01 03:58:12.694+0900 D/AUL_PAD (11508): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
04-01 03:58:12.694+0900 D/AUL_PAD (11508): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 884, pkt->len: 876
04-01 03:58:12.694+0900 D/AUL_PAD (11508): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
04-01 03:58:12.694+0900 D/AUL_PAD (11508): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
04-01 03:58:12.694+0900 D/AUL_PAD (11508): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
04-01 03:58:12.694+0900 D/AUL_PAD (11508): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
04-01 03:58:12.694+0900 D/AUL     (11508): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (11531) is sent.
04-01 03:58:12.694+0900 D/AUL     (11508): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 11531, signo: 10
04-01 03:58:12.694+0900 D/AUL     (11508): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
04-01 03:58:12.694+0900 D/AUL_PAD (11508): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
04-01 03:58:12.694+0900 D/AUL_PAD (11508): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
04-01 03:58:12.694+0900 D/AUL_PAD (11508): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
04-01 03:58:12.694+0900 D/AUL_PAD (11508): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
04-01 03:58:12.694+0900 D/AUL_PAD (11508): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : UgAAAAEEAAAUAAAAX19BUFBfU1ZDX09QX1RZUEVfXwAuAAAAaHR0cDovL3RpemVuLm9yZy9hcHBjb250cm9sL29wZXJhdGlvbi9kZWZhdWx0AA==##
04-01 03:58:12.694+0900 D/AUL_PAD (11508): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __APP_SVC_PKG_NAME__##
04-01 03:58:12.694+0900 D/AUL_PAD (11508): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : OQAAAAEEAAAVAAAAX19BUFBfU1ZDX1BLR19OQU1FX18AFAAAAG9yZy5leGFtcGxlLmV4YW1wbGUA##
04-01 03:58:12.694+0900 D/AUL_PAD (11508): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_STARTTIME__##
04-01 03:58:12.694+0900 D/AUL_PAD (11508): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTA5ODY2OTIvNjk2OTg0AA==##
04-01 03:58:12.694+0900 D/AUL_PAD (11508): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 8 : __AUL_CALLER_PID__##
04-01 03:58:12.694+0900 D/AUL_PAD (11508): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 9 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAAyOTA2AA==##
04-01 03:58:12.694+0900 D/AUL_PAD (11508): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 10 : __AUL_CALLER_APPID__##
04-01 03:58:12.694+0900 D/AUL_PAD (11508): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 11 : OgAAAAEEAAAVAAAAX19BVUxfQ0FMTEVSX0FQUElEX18AFQAAAG9yZy50aXplbi5ob21lc2NyZWVuAA==##
04-01 03:58:12.694+0900 D/AUL_PAD (11508): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 12 : __AUL_INTERNAL_POOL__##
04-01 03:58:12.694+0900 D/AUL_PAD (11508): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 13 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
04-01 03:58:12.694+0900 D/AUL_PAD (11508): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 14
04-01 03:58:12.694+0900 D/AUL_PAD (11508): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
04-01 03:58:12.694+0900 D/AUL_PAD (11508): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
04-01 03:58:12.694+0900 I/CAPI_APPFW_APPLICATION(11508): app_main.c: ui_app_main(788) > app_efl_main
04-01 03:58:12.694+0900 D/LAUNCH  (11508): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
04-01 03:58:12.694+0900 D/APP_CORE(11508): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
04-01 03:58:12.694+0900 D/APP_CORE(11508): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
04-01 03:58:12.694+0900 D/APP_CORE(11508): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
04-01 03:58:12.694+0900 D/APP_CORE(11508): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
04-01 03:58:12.694+0900 D/AUL     (11508): app_sock.c: __create_server_sock(156) > pg path - already exists
04-01 03:58:12.694+0900 D/APP_CORE(11508): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42a4520
04-01 03:58:12.694+0900 D/LAUNCH  (11508): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
04-01 03:58:12.694+0900 I/CAPI_APPFW_APPLICATION(11508): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
04-01 03:58:12.714+0900 E/EFL     (11508): <11508> lib/edje/edje_smart.c:22 edje_object_add() safety check failed: evas == NULL
04-01 03:58:12.734+0900 W/CRASH_MANAGER(11487): worker.c: worker_job(1204) > 1111508657861149098669
