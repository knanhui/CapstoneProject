S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 15840
Date: 2017-05-23 04:07:54+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x28

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000000, esi = 0xb9531388
ebp = 0xbfc4e158, esp = 0xbfc4e100
eax = 0xb42ff000, ebx = 0xb73725f0
ecx = 0xb42ff050, edx = 0xb42ff050
eip = 0xb717ecb6

Memory Information
MemTotal:      123 KB
MemFree:        27 KB
Buffers:         8 KB
Cached:     169112 KB
VmPeak:     113492 KB
VmSize:     113492 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       26288 KB
VmRSS:       26288 KB
VmData:      44672 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33592 KB
VmPTE:          96 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 15840 TID = 15840
15840 15843 16024 16025 16029 

Maps Information
b19de000 b19e2000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2cb7000 b2cc1000 r-xp /usr/lib/libfeedback.so.0.1.4
b2cc7000 b2cd3000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2cd4000 b2cf5000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2cfa000 b2cfb000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2cfc000 b2d01000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2d02000 b2d04000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2d05000 b2d07000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2d08000 b2d14000 r-xp /usr/lib/libdrm.so.2.4.0
b2d15000 b2d1f000 r-xp /usr/lib/libtbm.so.1.0.0
b2d20000 b2d35000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2d36000 b2d48000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b354a000 b3553000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3554000 b355d000 r-xp /usr/lib/libefl-extension.so.0.1.0
b355e000 b3570000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3571000 b3592000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b3599000 b359a000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b359b000 b359c000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b359d000 b35a0000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b35a1000 b35a4000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b36ac000 b36b2000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b36b3000 b37f7000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3807000 b3808000 r-xp /usr/lib/libxshmfence.so.1.0.0
b3809000 b380c000 r-xp /usr/lib/libdri2.so.0.0.0
b380d000 b380e000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b380f000 b3817000 r-xp /opt/usr/apps/org.example.example/bin/example
b3819000 b3852000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4255000 b4260000 r-xp /lib/libnss_files-2.20-2014.11.so
b4262000 b426d000 r-xp /lib/libnss_nis-2.20-2014.11.so
b426f000 b4286000 r-xp /lib/libnsl-2.20-2014.11.so
b428a000 b4292000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4294000 b42b8000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b42b9000 b42ba000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b42bb000 b42be000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42bf000 b42c6000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42c7000 b42d1000 r-xp /usr/lib/libsensord-share.so
b42d2000 b42ee000 r-xp /usr/lib/libsensor.so.1.2.0
b42f0000 b42f9000 r-xp /usr/lib/libappcore-common.so.1.1
b42fc000 b42fe000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4313000 b4315000 r-xp /usr/lib/libXau.so.6.0.0
b4316000 b4338000 r-xp /usr/lib/libxcb.so.1.1.0
b433a000 b4343000 r-xp /lib/libcrypt-2.20-2014.11.so
b436c000 b436e000 r-xp /usr/lib/libiri.so
b436f000 b4395000 r-xp /lib/libexpat.so.1.5.2
b4397000 b4402000 r-xp /usr/lib/libssl.so.1.0.0
b4408000 b4414000 r-xp /usr/lib/libethumb.so.1.13.0
b4415000 b4419000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b441a000 b466b000 r-xp /usr/lib/libcrypto.so.1.0.0
b5be6000 b5bf6000 r-xp /usr/lib/libXi.so.6.1.0
b5bf7000 b5bf9000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bfa000 b5c00000 r-xp /usr/lib/libXtst.so.6.1.0
b5c01000 b5c0b000 r-xp /usr/lib/libXrender.so.1.3.0
b5c0c000 b5c15000 r-xp /usr/lib/libXrandr.so.2.2.0
b5c17000 b5c19000 r-xp /usr/lib/libXinerama.so.1.0.0
b5c1a000 b5c1f000 r-xp /usr/lib/libXfixes.so.3.1.0
b5c20000 b5c32000 r-xp /usr/lib/libXext.so.6.4.0
b5c33000 b5c35000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c36000 b5c38000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c3a000 b5d7c000 r-xp /usr/lib/libX11.so.6.3.0
b5d80000 b5d8a000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d8b000 b5da1000 r-xp /usr/lib/libudev.so.1.6.0
b5da4000 b5da8000 r-xp /lib/libattr.so.1.1.0
b5da9000 b5dd8000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5dda000 b5de0000 r-xp /usr/lib/libffi.so.6.0.2
b5de1000 b5e04000 r-xp /lib/libz.so.1.2.8
b5e05000 b5e08000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5e09000 b5f65000 r-xp /usr/lib/libxml2.so.2.9.2
b5f6b000 b6052000 r-xp /usr/lib/libstdc++.so.6.0.20
b605f000 b6062000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6063000 b6085000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6086000 b609a000 r-xp /lib/libresolv-2.20-2014.11.so
b609e000 b60c2000 r-xp /usr/lib/liblzma.so.5.0.3
b60c3000 b60c5000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b60c7000 b60d1000 r-xp /usr/lib/libembryo.so.1.13.0
b60d2000 b60fb000 r-xp /usr/lib/libpng12.so.0.50.0
b60fc000 b6145000 r-xp /usr/lib/libjpeg.so.8.0.2
b6156000 b615d000 r-xp /lib/librt-2.20-2014.11.so
b615f000 b617e000 r-xp /usr/lib/libector.so.1.13.0
b6181000 b61ae000 r-xp /usr/lib/liblua-5.1.so
b61af000 b623f000 r-xp /usr/lib/libfreetype.so.6.11.3
b6243000 b6281000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6282000 b6298000 r-xp /usr/lib/libfribidi.so.0.3.1
b6299000 b62f2000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62f5000 b6340000 r-xp /lib/libm-2.20-2014.11.so
b6342000 b6354000 r-xp /usr/lib/libeio.so.1.13.0
b6355000 b6358000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6359000 b635f000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6360000 b6383000 r-xp /usr/lib/libefreet.so.1.13.0
b6386000 b63b1000 r-xp /usr/lib/libeldbus.so.1.13.0
b63b2000 b63e6000 r-xp /usr/lib/libecore_con.so.1.13.0
b63e8000 b63f1000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63f2000 b63fb000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63fc000 b640f000 r-xp /usr/lib/libeo.so.1.13.0
b6411000 b6424000 r-xp /usr/lib/libecore_input.so.1.13.0
b6425000 b642c000 r-xp /usr/lib/libecore_file.so.1.13.0
b642d000 b6450000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6451000 b647d000 r-xp /usr/lib/libeet.so.1.13.0
b6486000 b64f1000 r-xp /usr/lib/libeina.so.1.13.0
b64f4000 b650b000 r-xp /usr/lib/libefl.so.1.13.0
b650d000 b6674000 r-xp /usr/lib/libicuuc.so.51.1
b6682000 b688e000 r-xp /usr/lib/libicui18n.so.51.1
b6896000 b68e5000 r-xp /usr/lib/libecore_x.so.1.13.0
b68e7000 b6901000 r-xp /lib/libgcc_s-4.9.so.1
b6903000 b6907000 r-xp /lib/libcap.so.2.21
b6908000 b694e000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b694f000 b6956000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6958000 b69aa000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b69ac000 b6b37000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b3c000 b6c0a000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6c0d000 b6c11000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6c12000 b6c21000 r-xp /usr/lib/libvconf.so.0.2.45
b6c22000 b6c25000 r-xp /usr/lib/libvasum.so.0.3.1
b6c26000 b6c29000 r-xp /usr/lib/libttrace.so.1.1
b6c2b000 b6c2f000 r-xp /usr/lib/libiniparser.so.0
b6c30000 b6c60000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c61000 b6c6a000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c6b000 b6c90000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c91000 b6ca1000 r-xp /usr/lib/libunwind.so.8.0.1
b6cab000 b6e59000 r-xp /lib/libc-2.20-2014.11.so
b6e61000 b6fa4000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6fa6000 b6ffe000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fff000 b7033000 r-xp /usr/lib/libsystemd.so.0.4.0
b7036000 b710a000 r-xp /usr/lib/libedje.so.1.13.0
b710d000 b7139000 r-xp /usr/lib/libecore.so.1.13.0
b714a000 b7370000 r-xp /usr/lib/libevas.so.1.13.0
b7398000 b73b0000 r-xp /lib/libpthread-2.20-2014.11.so
b73b4000 b772e000 r-xp /usr/lib/libelementary.so.1.13.0
b774e000 b7752000 r-xp /usr/lib/libsmack.so.1.0.0
b7753000 b775c000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b775d000 b7760000 r-xp /usr/lib/libdlog.so.0.0.0
b7761000 b7766000 r-xp /usr/lib/libbundle.so.0.1.22
b7767000 b776a000 r-xp /lib/libdl-2.20-2014.11.so
b776c000 b7791000 r-xp /usr/lib/libaul.so.0.1.0
b7794000 b7796000 r-xp /usr/lib/libappsvc.so.0.1.0
b7797000 b779c000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b779d000 b77a4000 r-xp /usr/lib/libappcore-efl.so.1.1
b77a6000 b77ab000 r-xp /usr/lib/libsys-assert.so
b77ae000 b77af000 r-xp [vdso]
b77af000 b77d1000 r-xp /lib/ld-2.20-2014.11.so
b77d3000 b77db000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:15840)
Call Stack Count: 32
 0: evas_object_event_callback_priority_add + 0xe6 (0xb717ecb6) [/usr/lib/libevas.so.1] + 0x34cb6
 1: evas_object_event_callback_add + 0x38 (0xb717ed48) [/usr/lib/libevas.so.1] + 0x34d48
 2: (0xb75660b8) [/usr/lib/libelementary.so.1] + 0x1b20b8
 3: elm_obj_widget_sub_object_add + 0xa1 (0xb7617371) [/usr/lib/libelementary.so.1] + 0x263371
 4: elm_widget_sub_object_add + 0x55 (0xb7631085) [/usr/lib/libelementary.so.1] + 0x27d085
 5: (0xb7562af2) [/usr/lib/libelementary.so.1] + 0x1aeaf2
 6: elm_obj_container_content_set + 0xb3 (0xb74b0393) [/usr/lib/libelementary.so.1] + 0xfc393
 7: (0xb7459899) [/usr/lib/libelementary.so.1] + 0xa5899
 8: elm_obj_container_content_set + 0xb3 (0xb74b0393) [/usr/lib/libelementary.so.1] + 0xfc393
 9: elm_widget_content_part_set + 0x71 (0xb7623b41) [/usr/lib/libelementary.so.1] + 0x26fb41
10: elm_object_part_content_set + 0x2f (0xb757cb3f) [/usr/lib/libelementary.so.1] + 0x1c8b3f
11: make_popup_time + 0x2ad (0xb3812e3d) [/opt/usr/apps/org.example.example/bin/example] + 0x3e3d
12: (0xb71d3116) [/usr/lib/libevas.so.1] + 0x89116
13: (0xb640a319) [/usr/lib/libeo.so.1] + 0xe319
14: eo_event_callback_call + 0xb3 (0xb6407d63) [/usr/lib/libeo.so.1] + 0xbd63
15: evas_object_smart_callback_call + 0x75 (0xb71d59e5) [/usr/lib/libevas.so.1] + 0x8b9e5
16: (0xb7486404) [/usr/lib/libelementary.so.1] + 0xd2404
17: (0xb70b9f39) [/usr/lib/libedje.so.1] + 0x83f39
18: (0xb70c0a11) [/usr/lib/libedje.so.1] + 0x8aa11
19: (0xb70bafdc) [/usr/lib/libedje.so.1] + 0x84fdc
20: (0xb70bb4cb) [/usr/lib/libedje.so.1] + 0x854cb
21: (0xb70bb68f) [/usr/lib/libedje.so.1] + 0x8568f
22: (0xb7120702) [/usr/lib/libecore.so.1] + 0x13702
23: (0xb711a055) [/usr/lib/libecore.so.1] + 0xd055
24: (0xb71231b9) [/usr/lib/libecore.so.1] + 0x161b9
25: ecore_main_loop_begin + 0x57 (0xb7123587) [/usr/lib/libecore.so.1] + 0x16587
26: elm_run + 0x2d (0xb757c22d) [/usr/lib/libelementary.so.1] + 0x1c822d
27: appcore_efl_main + 0x4de (0xb77a0dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
28: ui_app_main + 0x140 (0xb7799c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
29: main + 0x27e (0xb381409e) [/opt/usr/apps/org.example.example/bin/example] + 0x509e
30: (0xb77d5148) [/opt/usr/apps/org.example.example/bin/example] + 0xb77d5148
31: __libc_start_main + 0xde (0xb6cc2e4e) [/lib/libc.so.6] + 0x17e4e
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
g:org.example.example key:install_percent val:100
05-23 04:07:47.544+0900 D/PKGMGR  ( 2978): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1775457260], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-23 04:07:47.544+0900 D/QUICKPANEL( 2978): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:end val:ok
05-23 04:07:47.544+0900 D/PKGMGR  ( 2985): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1775457260], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-23 04:07:47.544+0900 D/PKGMGR  ( 2985): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1775457260], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-23 04:07:47.544+0900 D/PKGMGR  ( 2832): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[upgrade], req_id=[org.example.example_-1775457260], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-23 04:07:47.544+0900 D/AUL_AMD ( 2832): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.example), key(end), value(ok)
05-23 04:07:47.544+0900 W/AUL_AMD ( 2832): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(update), value(ok)
05-23 04:07:47.544+0900 W/ISF_PANEL_EFL( 3069): isf_panel_efl.cpp: _package_manager_event_cb(1380) > isf_db_select_appids_by_pkgid returned 0.
05-23 04:07:47.544+0900 D/PKGMGR  ( 2973): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1775457260], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-23 04:07:47.544+0900 D/DATA_PROVIDER_MASTER( 2973): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.example] 100
05-23 04:07:47.544+0900 D/PKGMGR  ( 2973): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1775457260], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-23 04:07:47.544+0900 D/DATA_PROVIDER_MASTER( 2973): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.example] ok
05-23 04:07:47.544+0900 D/DATA_PROVIDER_MASTER( 2973): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.example], event_type[1]
05-23 04:07:47.544+0900 D/DATA_PROVIDER_MASTER( 2973): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
05-23 04:07:47.544+0900 D/AUL_AMD ( 2832): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.example, type:rpm
05-23 04:07:47.544+0900 D/PKGMGR  ( 2918): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1775457260], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-23 04:07:47.544+0900 W/cluster-home( 2918): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.example]
05-23 04:07:47.544+0900 D/PKGMGR  ( 2918): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1775457260], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-23 04:07:47.544+0900 D/cluster-home( 2918): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29180003] pkg_type[tpk] package[org.example.example] key[install_percent] val[100] pmsg[(null)]
05-23 04:07:47.544+0900 D/PKGMGR  ( 2918): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1775457260], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-23 04:07:47.544+0900 W/cluster-home( 2918): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[2], package[org.example.example]
05-23 04:07:47.544+0900 D/cluster-home( 2918): widget-data-provider.cpp: PackageUpdated(2160) >  No boxes that pkgname is[org.example.example]
05-23 04:07:47.544+0900 D/PKGMGR  ( 2918): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1775457260], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-23 04:07:47.544+0900 D/cluster-home( 2918): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29180003] pkg_type[tpk] package[org.example.example] key[end] val[ok] pmsg[(null)]
05-23 04:07:47.544+0900 E/cluster-home( 2918): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
05-23 04:07:47.544+0900 E/cluster-home( 2918): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
05-23 04:07:47.544+0900 E/cluster-home( 2918): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
05-23 04:07:47.554+0900 D/DATA_PROVIDER_MASTER( 2973): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
05-23 04:07:47.554+0900 D/DATA_PROVIDER_MASTER( 2973): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
05-23 04:07:47.554+0900 D/DATA_PROVIDER_MASTER( 2973): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.example]
05-23 04:07:47.554+0900 D/PKGMGR  ( 2983): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1775457260], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-23 04:07:47.554+0900 D/ESD     ( 2983): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29830002), pkg_type(tpk), pkgid(org.example.example), key(end), val(ok)
05-23 04:07:47.554+0900 D/ESD     ( 2983): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
05-23 04:07:47.554+0900 D/PKGMGR  ( 2992): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1775457260], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-23 04:07:47.554+0900 D/PKGMGR  ( 2992): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
05-23 04:07:47.554+0900 D/PKGMGR  ( 2992): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1775457260], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-23 04:07:47.554+0900 D/PKGMGR  ( 2992): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
05-23 04:07:47.554+0900 D/cluster-home( 2918): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
05-23 04:07:47.554+0900 D/cluster-home( 2918): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.example]
05-23 04:07:47.554+0900 E/cluster-home( 2918): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.example]
05-23 04:07:47.554+0900 E/cluster-home( 2918): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.example]
05-23 04:07:47.554+0900 E/cluster-home( 2918): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
05-23 04:07:47.554+0900 E/cluster-home( 2918): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
05-23 04:07:47.554+0900 E/cluster-home( 2918): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.example]
05-23 04:07:47.554+0900 E/cluster-home( 2918): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.example] Name[forpet] Icon[/opt/usr/apps/org.example.example/shared/res/1.jpg] enable[1] system[0]
05-23 04:07:47.554+0900 D/cluster-home( 2918): mainmenu-presenter.cpp: OnAppUpdated(337) >  pAppId [org.example.example]
05-23 04:07:47.554+0900 D/cluster-home( 2918): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.example
05-23 04:07:47.554+0900 D/cluster-home( 2918): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[14], isFolder[0], pageId[1], col[2], row[4], appId[org.example.example], name[forpet], menuId[1], isPreload[0] isPreload[0]
05-23 04:07:47.554+0900 D/cluster-home( 2918): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
05-23 04:07:47.554+0900 E/cluster-home( 2918): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.example] Name[forpet] Icon[/opt/usr/apps/org.example.example/shared/res/1.jpg] enable[1] system[0]
05-23 04:07:47.554+0900 D/cluster-home( 2918): mainmenu-presenter.cpp: OnAppUpdated(364) >  name [forpet]
05-23 04:07:47.554+0900 D/cluster-home( 2918): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
05-23 04:07:47.554+0900 D/cluster-home( 2918): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
05-23 04:07:47.554+0900 D/test-log( 2918): mainmenu-box-impl.cpp: UpdateBoxData(812) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.example/shared/res/1.jpg], New icon path[/opt/usr/apps/org.example.example/shared/res/1.jpg]!!!!!
05-23 04:07:47.554+0900 D/cluster-home( 2918): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 1, appId = $appId, name = $name, col = 2, row = 4, isPreload = 0, isSystem = 0 WHERE boxId = 14]
05-23 04:07:47.754+0900 D/rpm-installer(15967): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
05-23 04:07:47.754+0900 D/rpm-installer(15967): rpm-appcore-intf.c: main(259) > ------------------------------------------------
05-23 04:07:47.754+0900 D/rpm-installer(15967): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
05-23 04:07:47.754+0900 D/rpm-installer(15967): rpm-appcore-intf.c: main(261) > ------------------------------------------------
05-23 04:07:47.754+0900 D/PKGMGR_SERVER(15878): pkgmgr-server.c: sighandler(387) > child exit [15967]
05-23 04:07:47.754+0900 E/PKGMGR_SERVER(15878): pkgmgr-server.c: sighandler(402) > child NORMAL exit [15967]
05-23 04:07:47.994+0900 E/PKGMGR_SERVER(15878): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
05-23 04:07:47.994+0900 E/PKGMGR_SERVER(15878): pkgmgr-server.c: main(2265) > package manager server terminated.
05-23 04:07:48.454+0900 D/AUL_AMD ( 2832): amd_request.c: __request_handler(838) > __request_handler: 0
05-23 04:07:48.464+0900 D/AUL_AMD ( 2832): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
05-23 04:07:48.464+0900 D/PKGMGR_INFO( 2832): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
05-23 04:07:48.464+0900 D/PKGMGR_INFO( 2832): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
05-23 04:07:48.464+0900 I/AUL     ( 2832): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
05-23 04:07:48.464+0900 D/AUL     ( 2832): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 16018, pid = 16020
05-23 04:07:48.464+0900 D/PKGMGR_INFO( 2832): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
05-23 04:07:48.464+0900 D/PKGMGR_INFO( 2832): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
05-23 04:07:48.464+0900 I/AUL     ( 2832): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
05-23 04:07:48.464+0900 E/AUL_AMD ( 2832): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
05-23 04:07:48.464+0900 W/AUL_AMD ( 2832): amd_launch.c: _start_app(2233) > caller pid : 16020
05-23 04:07:48.464+0900 E/AUL_AMD ( 2832): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
05-23 04:07:48.464+0900 W/AUL_AMD ( 2832): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
05-23 04:07:48.464+0900 D/AUL_AMD ( 2832): amd_launch.c: _start_app(2648) > process_pool: false
05-23 04:07:48.464+0900 D/AUL_AMD ( 2832): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
05-23 04:07:48.464+0900 D/AUL_AMD ( 2832): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
05-23 04:07:48.464+0900 W/AUL_AMD ( 2832): amd_launch.c: _start_app(2665) > pad pid(-5)
05-23 04:07:48.464+0900 D/AUL_AMD ( 2832): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
05-23 04:07:48.464+0900 D/AUL_AMD ( 2832): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
05-23 04:07:48.464+0900 D/AUL     ( 2832): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
05-23 04:07:48.474+0900 D/AUL_PAD ( 2966): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
05-23 04:07:48.474+0900 D/AUL_PAD ( 2966): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
05-23 04:07:48.474+0900 D/AUL_PAD ( 2966): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-23 04:07:48.474+0900 D/AUL_PAD ( 2966): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-23 04:07:48.474+0900 D/AUL_PAD ( 2966): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-23 04:07:48.474+0900 D/AUL_PAD ( 2966): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-23 04:07:48.474+0900 D/AUL_PAD ( 2966): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-23 04:07:48.474+0900 D/AUL_PAD ( 2966): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
05-23 04:07:48.474+0900 D/AUL_PAD ( 2966): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
05-23 04:07:48.474+0900 D/AUL_PAD ( 2966): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
05-23 04:07:48.474+0900 D/AUL_PAD ( 2966): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
05-23 04:07:48.474+0900 D/AUL_PAD ( 2966): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
05-23 04:07:48.474+0900 D/AUL_PAD ( 2966): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
05-23 04:07:48.474+0900 D/AUL_PAD ( 2966): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
05-23 04:07:48.474+0900 W/AUL_PAD ( 2966): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
05-23 04:07:48.474+0900 D/AUL     ( 2966): process_pool.c: __send_pkt_raw_data(219) > send(13) : 624 / 624
05-23 04:07:48.474+0900 D/AUL_PAD ( 2966): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 15840, bin path: /opt/usr/apps/org.example.example/bin/example
05-23 04:07:48.474+0900 W/AUL_PAD ( 2966): launchpad.c: __send_result_to_caller(265) > Check app launching
05-23 04:07:48.474+0900 D/AUL_PAD ( 2966): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
05-23 04:07:48.474+0900 D/AUL_PAD (15840): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
05-23 04:07:48.474+0900 D/AUL_PAD (15840): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
05-23 04:07:48.474+0900 D/RESOURCED( 2897): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
05-23 04:07:48.474+0900 D/RESOURCED( 2897): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
05-23 04:07:48.474+0900 D/AUL_PAD (15840): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
05-23 04:07:48.474+0900 D/AUL_PAD (15840): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
05-23 04:07:48.474+0900 D/AUL_PAD (15840): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
05-23 04:07:48.474+0900 D/AUL_PAD (15840): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
05-23 04:07:48.474+0900 D/AUL     (15840): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (15843) is sent.
05-23 04:07:48.474+0900 E/RESOURCED( 2897): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
05-23 04:07:48.474+0900 D/AUL     (15840): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 15843, signo: 10
05-23 04:07:48.484+0900 D/AUL     (15840): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
05-23 04:07:48.484+0900 D/AUL_PAD (15840): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
05-23 04:07:48.484+0900 D/AUL_PAD (15840): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
05-23 04:07:48.484+0900 D/AUL_PAD (15840): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
05-23 04:07:48.484+0900 D/AUL_PAD (15840): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
05-23 04:07:48.484+0900 D/AUL_PAD (15840): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTU0ODAwNjgvNDY0OTE2AA==##
05-23 04:07:48.484+0900 D/AUL_PAD (15840): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
05-23 04:07:48.484+0900 D/AUL_PAD (15840): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAxNjAyMAA=##
05-23 04:07:48.484+0900 D/AUL_PAD (15840): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
05-23 04:07:48.484+0900 D/AUL_PAD (15840): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
05-23 04:07:48.484+0900 D/AUL_PAD (15840): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
05-23 04:07:48.484+0900 D/AUL_PAD (15840): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
05-23 04:07:48.484+0900 D/AUL_PAD (15840): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
05-23 04:07:48.484+0900 I/CAPI_APPFW_APPLICATION(15840): app_main.c: ui_app_main(788) > app_efl_main
05-23 04:07:48.484+0900 D/LAUNCH  (15840): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
05-23 04:07:48.484+0900 D/APP_CORE(15840): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
05-23 04:07:48.484+0900 D/APP_CORE(15840): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
05-23 04:07:48.484+0900 D/APP_CORE(15840): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
05-23 04:07:48.504+0900 D/APP_CORE(15840): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
05-23 04:07:48.504+0900 D/AUL     (15840): app_sock.c: __create_server_sock(156) > pg path - already exists
05-23 04:07:48.504+0900 D/APP_CORE(15840): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42f9520
05-23 04:07:48.504+0900 D/LAUNCH  (15840): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
05-23 04:07:48.504+0900 I/CAPI_APPFW_APPLICATION(15840): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
05-23 04:07:48.574+0900 D/AUL_PAD ( 2966): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
05-23 04:07:48.574+0900 W/AUL     ( 2832): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 15840, appid: org.example.example
05-23 04:07:48.574+0900 D/AUL     ( 2832): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
05-23 04:07:48.574+0900 E/AUL     ( 2832): simple_util.c: __trm_app_info_send_socket(330) > access
05-23 04:07:48.574+0900 D/AUL_AMD ( 2832): amd_launch.c: _start_app(2700) > add app group info
05-23 04:07:48.574+0900 E/AUL     ( 2832): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
05-23 04:07:48.574+0900 D/AUL_AMD ( 2832): amd_status.c: _status_add_app_info_list(427) > pid(15840) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
05-23 04:07:48.574+0900 D/RESOURCED( 2897): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 15840
05-23 04:07:48.574+0900 D/RESOURCED( 2897): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
05-23 04:07:48.574+0900 E/RESOURCED( 2897): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
05-23 04:07:48.574+0900 D/RESOURCED( 2897): proc-main.c: resourced_proc_status_change(888) > available memory = 316
05-23 04:07:48.594+0900 D/LAUNCH  (15840): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
05-23 04:07:48.604+0900 D/APP_CORE(15840): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
05-23 04:07:48.604+0900 E/E17     ( 2842): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02000002)
05-23 04:07:48.664+0900 E/E17     ( 2842): e_border.c: e_border_show(2088) > BD_SHOW(0x02000002)
05-23 04:07:48.664+0900 D/APP_CORE(15840): appcore.c: __aul_handler(587) > [APP 15840]     AUL event: AUL_START
05-23 04:07:48.664+0900 I/APP_CORE(15840): appcore-efl.c: __do_app(496) > [APP 15840] Event: RESET State: CREATED
05-23 04:07:48.664+0900 D/APP_CORE(15840): appcore-efl.c: __do_app(527) > [APP 15840] RESET
05-23 04:07:48.664+0900 D/LAUNCH  (15840): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
05-23 04:07:48.674+0900 D/APP_CORE(15840): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
05-23 04:07:48.674+0900 D/APP_CORE(15840): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-23 04:07:48.674+0900 I/CAPI_APPFW_APPLICATION(15840): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
05-23 04:07:48.674+0900 D/AUL     (15840): service.c: __set_bundle(186) > __set_bundle
05-23 04:07:48.674+0900 D/LAUNCH  (15840): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
05-23 04:07:48.674+0900 D/APP_CORE(15840): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
05-23 04:07:48.674+0900 E/EFL     (15840): edje<15840> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-23 04:07:48.674+0900 E/EFL     (15840): By the power of Grayskull, your previous Embryo stack is now broken!
05-23 04:07:48.674+0900 E/EFL     (15840): edje<15840> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-23 04:07:48.674+0900 E/EFL     (15840): By the power of Grayskull, your previous Embryo stack is now broken!
05-23 04:07:48.674+0900 E/EFL     (15840): edje<15840> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-23 04:07:48.674+0900 E/EFL     (15840): By the power of Grayskull, your previous Embryo stack is now broken!
05-23 04:07:48.674+0900 E/EFL     (15840): edje<15840> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-23 04:07:48.674+0900 E/EFL     (15840): By the power of Grayskull, your previous Embryo stack is now broken!
05-23 04:07:48.674+0900 E/EFL     (15840): edje<15840> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-23 04:07:48.674+0900 E/EFL     (15840): By the power of Grayskull, your previous Embryo stack is now broken!
05-23 04:07:48.714+0900 W/PROCESSMGR( 2842): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=15840
05-23 04:07:48.714+0900 W/APP_CORE(15840): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2000002
05-23 04:07:48.714+0900 D/APP_CORE(15840): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2000002
05-23 04:07:48.714+0900 D/APP_CORE(15840): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
05-23 04:07:48.714+0900 D/AUL     (15840): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
05-23 04:07:48.714+0900 D/AUL_AMD ( 2832): amd_request.c: __request_handler(838) > __request_handler: 34
05-23 04:07:48.724+0900 E/EFL     ( 2842): eo<2842> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-23 04:07:48.724+0900 E/EFL     ( 2842): eo<2842> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-23 04:07:48.754+0900 D/AUL_AMD ( 2832): amd_request.c: __request_handler(838) > __request_handler: 15
05-23 04:07:48.754+0900 D/PKGMGR_INFO( 2832): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-23 04:07:48.754+0900 D/PKGMGR_INFO( 2832): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-23 04:07:48.754+0900 D/AUL_AMD ( 2832): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 15840 is org.example.example
05-23 04:07:48.754+0900 D/AUL_AMD ( 2832): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 15840 : 0
05-23 04:07:48.764+0900 D/AUL     ( 2985): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
05-23 04:07:48.774+0900 D/INDICATOR( 2900): main.c: _property_changed_cb(432) > UNSNIFF API 1400002
05-23 04:07:48.774+0900 D/INDICATOR( 2900): util.c: util_signal_emit_by_win(116) > emission bg.opaque
05-23 04:07:48.774+0900 D/INDICATOR( 2900): main.c: _rotate_window(229) > Indicator angle is 0 degree
05-23 04:07:48.774+0900 D/INDICATOR( 2900): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
05-23 04:07:48.774+0900 D/INDICATOR( 2900): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
05-23 04:07:48.784+0900 D/INDICATOR( 2900): main.c: _rotate_window(252) > port :: hide more icon
05-23 04:07:49.014+0900 D/APP_CORE(15840): appcore.c: __prt_ltime(236) > [APP 15840] first idle after reset: 561 msec
05-23 04:07:49.134+0900 E/E17     ( 2842): e_border.c: e_border_hide(2248) > BD_HIDE(0x01400002), visible:1
05-23 04:07:49.134+0900 D/APP_CORE( 2918): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1400002 fully_obscured 1
05-23 04:07:49.134+0900 D/APP_CORE( 2918): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
05-23 04:07:49.134+0900 D/APP_CORE( 2918): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
05-23 04:07:49.134+0900 I/APP_CORE( 2918): appcore-efl.c: __do_app(496) > [APP 2918] Event: PAUSE State: RUNNING
05-23 04:07:49.134+0900 D/APP_CORE( 2918): appcore-efl.c: __do_app(565) > [APP 2918] PAUSE
05-23 04:07:49.134+0900 I/CAPI_APPFW_APPLICATION( 2918): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
05-23 04:07:49.134+0900 E/cluster-home( 2918): homescreen.cpp: OnPause(84) >  app pause
05-23 04:07:49.134+0900 D/cluster-view( 2918): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
05-23 04:07:49.134+0900 D/cluster-view( 2918): homescreen-view-manager.cpp: AppPause(923) >  END
05-23 04:07:49.134+0900 D/APP_CORE( 2918): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-23 04:07:49.134+0900 E/APP_CORE( 2918): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-23 04:07:49.144+0900 D/AUL_AMD ( 2832): amd_status.c: _status_update_app_info_list(456) > pid(2918) status(4)
05-23 04:07:49.144+0900 D/AUL_AMD ( 2832): amd_status.c: _status_update_app_info_list(468) > pid(2918) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
05-23 04:07:49.144+0900 D/AUL     ( 2832): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
05-23 04:07:49.144+0900 W/AUL     ( 2832): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2918, appid: org.tizen.homescreen, status: bg
05-23 04:07:49.144+0900 D/DATA_PROVIDER_MASTER( 2973): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2918 is paused
05-23 04:07:49.144+0900 D/DATA_PROVIDER_MASTER( 2973): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
05-23 04:07:49.144+0900 D/AUL_AMD ( 2832): amd_launch.c: __e17_status_handler(2891) > pid(15840) status(3)
05-23 04:07:49.144+0900 D/AUL_AMD ( 2832): amd_key.c: _key_ungrab(265) > _key_ungrab, win : 600002
05-23 04:07:49.154+0900 I/CAPI_WIDGET_APPLICATION( 3067): widget_app.c: __provider_pause_cb(294) > widget obj was paused
05-23 04:07:49.154+0900 I/CAPI_WIDGET_APPLICATION( 3067): widget_app.c: __check_status_for_cgroup(142) > enter background group
05-23 04:07:49.154+0900 W/AUL     ( 3067): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3067, appid: org.tizen.calendar.widget, status: bg
05-23 04:07:49.164+0900 D/RESOURCED( 2897): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3067, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
05-23 04:07:49.164+0900 D/RESOURCED( 2897): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3067
05-23 04:07:49.164+0900 D/RESOURCED( 2897): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3067, appname = org.tizen.calendar.widget
05-23 04:07:49.164+0900 D/RESOURCED( 2897): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3067
05-23 04:07:49.184+0900 D/APP_CORE(15840): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2000002 fully_obscured 0
05-23 04:07:49.184+0900 D/APP_CORE(15840): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
05-23 04:07:49.184+0900 D/APP_CORE(15840): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
05-23 04:07:49.184+0900 I/APP_CORE(15840): appcore-efl.c: __do_app(496) > [APP 15840] Event: RESUME State: CREATED
05-23 04:07:49.184+0900 D/LAUNCH  (15840): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
05-23 04:07:49.184+0900 D/APP_CORE(15840): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
05-23 04:07:49.184+0900 D/APP_CORE(15840): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-23 04:07:49.184+0900 D/APP_CORE(15840): appcore-efl.c: __do_app(607) > [APP 15840] RESUME
05-23 04:07:49.184+0900 I/APP_CORE(15840): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
05-23 04:07:49.184+0900 I/APP_CORE(15840): appcore-efl.c: __do_app(614) > [APP 15840] Initial Launching, call the resume_cb
05-23 04:07:49.184+0900 I/CAPI_APPFW_APPLICATION(15840): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
05-23 04:07:49.184+0900 D/LAUNCH  (15840): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
05-23 04:07:49.184+0900 D/LAUNCH  (15840): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
05-23 04:07:49.184+0900 D/APP_CORE(15840): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-23 04:07:49.184+0900 E/APP_CORE(15840): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-23 04:07:49.184+0900 W/AUL_AMD ( 2832): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-23 04:07:49.184+0900 W/AUL_AMD ( 2832): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
05-23 04:07:49.184+0900 D/AUL_AMD ( 2832): amd_status.c: _status_update_app_info_list(456) > pid(15840) status(3)
05-23 04:07:49.184+0900 D/AUL_AMD ( 2832): amd_status.c: _status_update_app_info_list(468) > pid(15840) appid(org.example.example) pkgid(org.example.example) status(3)
05-23 04:07:49.184+0900 D/AUL     ( 2832): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
05-23 04:07:49.184+0900 W/AUL     ( 2832): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 15840, appid: org.example.example, status: fg
05-23 04:07:49.194+0900 D/RESOURCED( 2897): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 15840
05-23 04:07:49.194+0900 D/RESOURCED( 2897): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 15840, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
05-23 04:07:49.194+0900 D/RESOURCED( 2897): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 15840
05-23 04:07:49.254+0900 D/RESOURCED( 2897): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 15840, appname = org.example.example, pkgname = org.example.example
05-23 04:07:49.254+0900 D/RESOURCED( 2897): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 15840, appname = org.example.example
05-23 04:07:49.254+0900 D/RESOURCED( 2897): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 15840
05-23 04:07:49.254+0900 I/RESOURCED( 2897): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
05-23 04:07:49.254+0900 I/RESOURCED( 2897): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
05-23 04:07:49.324+0900 D/AUL_AMD ( 2832): amd_launch.c: __e17_status_handler(2910) > pid(15840) status(0)
05-23 04:07:49.594+0900 D/AUL_PAD ( 2966): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
05-23 04:07:49.604+0900 D/AUL_PAD (16027): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
05-23 04:07:49.644+0900 D/AUL_PAD ( 2966): sigchild.h: __send_app_launch_signal(131) > send launch signal done
05-23 04:07:49.654+0900 E/RESOURCED( 2897): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1060
05-23 04:07:50.084+0900 D/AUL_AMD ( 2832): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
05-23 04:07:50.084+0900 D/RUA     ( 2832): rua.c: rua_add_history(179) > rua_add_history start
05-23 04:07:50.174+0900 D/RUA     ( 2832): rua.c: rua_add_history(247) > rua_add_history ok
05-23 04:07:50.444+0900 D/AUL_AMD ( 2832): amd_status.c: __app_terminate_timer_cb(442) > pid(15656)
05-23 04:07:50.444+0900 W/AUL_AMD ( 2832): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
05-23 04:07:50.444+0900 D/AUL_AMD ( 2832): amd_status.c: __app_terminate_timer_cb(442) > pid(15656)
05-23 04:07:50.444+0900 W/AUL_AMD ( 2832): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
05-23 04:07:50.714+0900 D/AUL_PAD (16027): launchpad_loader.c: main(588) > sleeping 1 sec...
05-23 04:07:50.714+0900 D/AUL_PAD (16027): preload.h: __preload_init(52) > max_cmdline_size = 1053
05-23 04:07:50.754+0900 D/AUL_PAD (16027): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b8b68760
05-23 04:07:50.754+0900 D/AUL_PAD (16027): preload.h: __preload_init(69) > get pre-initialization function
05-23 04:07:50.754+0900 D/AUL_PAD (16027): preload.h: __preload_init(73) > get shutdown function
05-23 04:07:50.764+0900 D/AUL_PAD (16027): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b8b68a40
05-23 04:07:50.774+0900 D/AUL_PAD (16027): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b8b6a640
05-23 04:07:50.774+0900 D/AUL_PAD (16027): preload.h: __preload_init(69) > get pre-initialization function
05-23 04:07:50.774+0900 D/AUL_PAD (16027): preload.h: __preload_init(73) > get shutdown function
05-23 04:07:50.774+0900 D/AUL_PAD (16027): preexec.h: __preexec_init(76) > preexec start
05-23 04:07:50.774+0900 D/AUL_PAD (16027): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
05-23 04:07:50.774+0900 D/AUL     (16027): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
05-23 04:07:50.784+0900 D/AUL     (16027): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
05-23 04:07:50.784+0900 D/AUL_PAD ( 2966): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-23 04:07:50.784+0900 D/AUL_PAD ( 2966): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
05-23 04:07:50.784+0900 D/AUL_PAD ( 2966): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-23 04:07:50.784+0900 D/AUL_PAD ( 2966): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-23 04:07:50.784+0900 D/AUL_PAD ( 2966): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-23 04:07:50.784+0900 D/AUL_PAD ( 2966): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-23 04:07:50.784+0900 D/AUL_PAD ( 2966): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-23 04:07:50.784+0900 D/AUL_PAD ( 2966): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
05-23 04:07:50.784+0900 D/AUL_PAD ( 2966): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 16027
05-23 04:07:50.784+0900 D/AUL     (16027): process_pool.c: __connect_to_launchpad(132) > send(16027) : 4
05-23 04:07:50.784+0900 D/AUL     (16027): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
05-23 04:07:51.034+0900 D/AUL_PAD (16027): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
05-23 04:07:51.044+0900 D/AUL_PAD (16027): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
05-23 04:07:51.044+0900 D/AUL_PAD (16027): launchpad_loader.c: main(693) > [candidate] ecore handler add
05-23 04:07:51.044+0900 D/AUL_PAD (16027): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
05-23 04:07:53.194+0900 D/PROCESSMGR( 2842): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x201f3e 
05-23 04:07:54.094+0900 E/EFL     (15840): edje<15840> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p15';
05-23 04:07:54.094+0900 E/EFL     (15840): By the power of Grayskull, your previous Embryo stack is now broken!
05-23 04:07:54.104+0900 D/PROCESSMGR( 2842): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x201f3e 
05-23 04:07:54.154+0900 D/APP_CORE( 2918): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
05-23 04:07:54.154+0900 I/APP_CORE( 2918): appcore-efl.c: __do_app(496) > [APP 2918] Event: MEM_FLUSH State: PAUSED
05-23 04:07:54.154+0900 D/APP_CORE( 2918): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
05-23 04:07:54.154+0900 D/APP_CORE( 2918): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2918
05-23 04:07:54.154+0900 D/APP_CORE( 2918): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
05-23 04:07:54.154+0900 D/RESOURCED( 2897): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2918
05-23 04:07:54.264+0900 E/EFL     (15840): eo<15840> lib/eo/eo.c:676 _eo_call_resolve() in elm_popup.eo.c:20: func 'elm_obj_popup_align_set' (1815) could not be resolved for class 'Elm_Grid'.
05-23 04:07:54.334+0900 E/EFL     (15840): edje<15840> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-23 04:07:54.344+0900 E/EFL     (15840): edje<15840> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-23 04:07:54.344+0900 E/EFL     (15840): edje<15840> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-23 04:07:54.354+0900 E/EFL     (15840): edje<15840> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-23 04:07:54.354+0900 E/EFL     (15840): edje<15840> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-23 04:07:54.354+0900 E/EFL     (15840): edje<15840> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-23 04:07:54.354+0900 E/EFL     (15840): edje<15840> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-23 04:07:54.364+0900 E/EFL     (15840): eo<15840> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb77d2000 is not pointing to a valid object. Maybe it has already been freed.
05-23 04:07:54.364+0900 E/EFL     (15840): eo<15840> lib/eo/eo.c:485 _eo_do_internal() Obj (0xb77d2000) is an invalid ref.
05-23 04:07:54.364+0900 E/EFL     (15840): eo<15840> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb77d2000 is not pointing to a valid object. Maybe it has already been freed.
05-23 04:07:54.364+0900 E/EFL     (15840): eo<15840> lib/eo/eo.c:1471 eo_isa() Obj (0xb77d2000) is an invalid ref.
05-23 04:07:54.364+0900 E/EFL     (15840): eo<15840> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb77d2000 is not pointing to a valid object. Maybe it has already been freed.
05-23 04:07:54.364+0900 E/EFL     (15840): eo<15840> lib/eo/eo.c:485 _eo_do_internal() Obj (0xb77d2000) is an invalid ref.
05-23 04:07:54.364+0900 E/EFL     (15840): eo<15840> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb77d2000 is not pointing to a valid object. Maybe it has already been freed.
05-23 04:07:54.364+0900 E/EFL     (15840): eo<15840> lib/eo/eo.c:485 _eo_do_internal() Obj (0xb77d2000) is an invalid ref.
05-23 04:07:54.364+0900 E/EFL     (15840): eo<15840> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb77d2000 is not pointing to a valid object. Maybe it has already been freed.
05-23 04:07:54.364+0900 E/EFL     (15840): eo<15840> lib/eo/eo.c:1471 eo_isa() Obj (0xb77d2000) is an invalid ref.
05-23 04:07:54.364+0900 E/EFL     (15840): eo<15840> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb77d2000 is not pointing to a valid object. Maybe it has already been freed.
05-23 04:07:54.364+0900 E/EFL     (15840): eo<15840> lib/eo/eo.c:485 _eo_do_internal() Obj (0xb77d2000) is an invalid ref.
05-23 04:07:54.364+0900 E/EFL     (15840): eo<15840> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb77d2000 is not pointing to a valid object. Maybe it has already been freed.
05-23 04:07:54.364+0900 E/EFL     (15840): eo<15840> lib/eo/eo.c:1471 eo_isa() Obj (0xb77d2000) is an invalid ref.
05-23 04:07:54.364+0900 E/EFL     (15840): eo<15840> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb77d2000 is not pointing to a valid object. Maybe it has already been freed.
05-23 04:07:54.364+0900 E/EFL     (15840): eo<15840> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0xb77d2000) is an invalid ref.
05-23 04:07:54.364+0900 E/EFL     (15840): eo<15840> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb77d2000 is not pointing to a valid object. Maybe it has already been freed.
05-23 04:07:54.364+0900 E/EFL     (15840): eo<15840> lib/eo/eo.c:485 _eo_do_internal() Obj (0xb77d2000) is an invalid ref.
05-23 04:07:54.444+0900 D/AUL_PAD ( 2966): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-23 04:07:54.444+0900 D/AUL_PAD ( 2966): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
05-23 04:07:54.444+0900 D/AUL_PAD ( 2966): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-23 04:07:54.444+0900 D/AUL_PAD ( 2966): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-23 04:07:54.444+0900 D/AUL_PAD ( 2966): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-23 04:07:54.444+0900 D/AUL_PAD ( 2966): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-23 04:07:54.444+0900 D/AUL_PAD ( 2966): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-23 04:07:54.444+0900 I/AUL_PAD ( 2966): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 15840 pgid = 15840
05-23 04:07:54.444+0900 I/AUL_PAD ( 2966): sigchild.h: __sigchild_action(142) > dead_pid(15840)
05-23 04:07:54.444+0900 E/EFL     ( 2842): eo<2842> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-23 04:07:54.474+0900 W/CRASH_MANAGER(16030): worker.c: worker_job(1204) > 1115840657861149548007
