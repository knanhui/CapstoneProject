S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 6161
Date: 2017-06-01 00:21:50+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x20

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000020, esi = 0xb3792c81
ebp = 0xbff9b698, esp = 0xbff9b630
eax = 0xb8cfee10, ebx = 0xb6b880d4
ecx = 0xb8cfee10, edx = 0x00000020
eip = 0xb6b661f6

Memory Information
MemTotal:      123 KB
MemFree:        31 KB
Buffers:         4 KB
Cached:     167728 KB
VmPeak:      81140 KB
VmSize:      81140 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16224 KB
VmRSS:       16224 KB
VmData:      20052 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34460 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 6161 TID = 6161
6161 6170 6368 

Maps Information
b2b52000 b2b5c000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b62000 b2b6e000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b6f000 b2b90000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2b95000 b2b96000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2b97000 b2b9c000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2b9d000 b2b9e000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2b9f000 b2ba1000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2ba2000 b2bae000 r-xp /usr/lib/libdrm.so.2.4.0
b2baf000 b2bb2000 r-xp /usr/lib/libdri2.so.0.0.0
b2bb3000 b2bbd000 r-xp /usr/lib/libtbm.so.1.0.0
b2bbe000 b2bd3000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2bd4000 b2be6000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b33e8000 b3419000 r-xp /usr/lib/libidn.so.11.5.44
b341a000 b343c000 r-xp /usr/lib/libnghttp2.so.5.4.0
b343d000 b344d000 r-xp /usr/lib/libcares.so.2.1.0
b344e000 b3457000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3458000 b3461000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3462000 b34d9000 r-xp /usr/lib/libcurl.so.4.3.0
b34db000 b34ed000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34ee000 b350f000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b3516000 b3517000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3518000 b3519000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b351a000 b351d000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b351e000 b3521000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3629000 b362f000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3630000 b3774000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3784000 b3786000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b3787000 b3788000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b3789000 b3794000 r-xp /opt/usr/apps/org.example.example/bin/example
b3796000 b37cf000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41d2000 b41dd000 r-xp /lib/libnss_files-2.20-2014.11.so
b41df000 b41ea000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41ec000 b4203000 r-xp /lib/libnsl-2.20-2014.11.so
b4207000 b420f000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4211000 b4235000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4236000 b4237000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4238000 b423b000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b423c000 b4243000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4244000 b424e000 r-xp /usr/lib/libsensord-share.so
b424f000 b426b000 r-xp /usr/lib/libsensor.so.1.2.0
b426d000 b4276000 r-xp /usr/lib/libappcore-common.so.1.1
b4279000 b427b000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4290000 b4292000 r-xp /usr/lib/libXau.so.6.0.0
b4293000 b42b5000 r-xp /usr/lib/libxcb.so.1.1.0
b42b7000 b42c0000 r-xp /lib/libcrypt-2.20-2014.11.so
b42e9000 b42eb000 r-xp /usr/lib/libiri.so
b42ec000 b4312000 r-xp /lib/libexpat.so.1.5.2
b4314000 b437f000 r-xp /usr/lib/libssl.so.1.0.0
b4385000 b4391000 r-xp /usr/lib/libethumb.so.1.13.0
b4392000 b4396000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4397000 b45e8000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b63000 b5b73000 r-xp /usr/lib/libXi.so.6.1.0
b5b74000 b5b76000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b77000 b5b7d000 r-xp /usr/lib/libXtst.so.6.1.0
b5b7e000 b5b88000 r-xp /usr/lib/libXrender.so.1.3.0
b5b89000 b5b92000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b94000 b5b96000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b97000 b5b9c000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b9d000 b5baf000 r-xp /usr/lib/libXext.so.6.4.0
b5bb0000 b5bb2000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bb3000 b5bb5000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bb7000 b5cf9000 r-xp /usr/lib/libX11.so.6.3.0
b5cfd000 b5d07000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d08000 b5d1e000 r-xp /usr/lib/libudev.so.1.6.0
b5d21000 b5d25000 r-xp /lib/libattr.so.1.1.0
b5d26000 b5d55000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d57000 b5d5d000 r-xp /usr/lib/libffi.so.6.0.2
b5d5e000 b5d81000 r-xp /lib/libz.so.1.2.8
b5d82000 b5d85000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d86000 b5ee2000 r-xp /usr/lib/libxml2.so.2.9.2
b5ee8000 b5fcf000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fdc000 b5fdf000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fe0000 b6002000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6003000 b6017000 r-xp /lib/libresolv-2.20-2014.11.so
b601b000 b603f000 r-xp /usr/lib/liblzma.so.5.0.3
b6040000 b6042000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6044000 b604e000 r-xp /usr/lib/libembryo.so.1.13.0
b604f000 b6078000 r-xp /usr/lib/libpng12.so.0.50.0
b6079000 b60c2000 r-xp /usr/lib/libjpeg.so.8.0.2
b60d3000 b60da000 r-xp /lib/librt-2.20-2014.11.so
b60dc000 b60fb000 r-xp /usr/lib/libector.so.1.13.0
b60fe000 b612b000 r-xp /usr/lib/liblua-5.1.so
b612c000 b61bc000 r-xp /usr/lib/libfreetype.so.6.11.3
b61c0000 b61fe000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61ff000 b6215000 r-xp /usr/lib/libfribidi.so.0.3.1
b6216000 b626f000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6272000 b62bd000 r-xp /lib/libm-2.20-2014.11.so
b62bf000 b62d1000 r-xp /usr/lib/libeio.so.1.13.0
b62d2000 b62d5000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62d6000 b62dc000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62dd000 b6300000 r-xp /usr/lib/libefreet.so.1.13.0
b6303000 b632e000 r-xp /usr/lib/libeldbus.so.1.13.0
b632f000 b6363000 r-xp /usr/lib/libecore_con.so.1.13.0
b6365000 b636e000 r-xp /usr/lib/libecore_imf.so.1.13.0
b636f000 b6378000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6379000 b638c000 r-xp /usr/lib/libeo.so.1.13.0
b638e000 b63a1000 r-xp /usr/lib/libecore_input.so.1.13.0
b63a2000 b63a9000 r-xp /usr/lib/libecore_file.so.1.13.0
b63aa000 b63cd000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63ce000 b63fa000 r-xp /usr/lib/libeet.so.1.13.0
b6403000 b646e000 r-xp /usr/lib/libeina.so.1.13.0
b6471000 b6488000 r-xp /usr/lib/libefl.so.1.13.0
b648a000 b65f1000 r-xp /usr/lib/libicuuc.so.51.1
b65ff000 b680b000 r-xp /usr/lib/libicui18n.so.51.1
b6813000 b6862000 r-xp /usr/lib/libecore_x.so.1.13.0
b6864000 b687e000 r-xp /lib/libgcc_s-4.9.so.1
b6880000 b6884000 r-xp /lib/libcap.so.2.21
b6885000 b68cb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68cc000 b68d3000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68d5000 b6927000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6929000 b6ab4000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6ab9000 b6b87000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b8a000 b6b8e000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b8f000 b6b9e000 r-xp /usr/lib/libvconf.so.0.2.45
b6b9f000 b6ba2000 r-xp /usr/lib/libvasum.so.0.3.1
b6ba3000 b6ba6000 r-xp /usr/lib/libttrace.so.1.1
b6ba8000 b6bac000 r-xp /usr/lib/libiniparser.so.0
b6bad000 b6bdd000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bde000 b6be7000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6be8000 b6c0d000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c0e000 b6c1e000 r-xp /usr/lib/libunwind.so.8.0.1
b6c28000 b6dd6000 r-xp /lib/libc-2.20-2014.11.so
b6dde000 b6f21000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f23000 b6f7b000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f7c000 b6fb0000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fb3000 b7087000 r-xp /usr/lib/libedje.so.1.13.0
b708a000 b70b6000 r-xp /usr/lib/libecore.so.1.13.0
b70c7000 b72ed000 r-xp /usr/lib/libevas.so.1.13.0
b7315000 b732d000 r-xp /lib/libpthread-2.20-2014.11.so
b7331000 b76ab000 r-xp /usr/lib/libelementary.so.1.13.0
b76cb000 b76cf000 r-xp /usr/lib/libsmack.so.1.0.0
b76d0000 b76d9000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76da000 b76dd000 r-xp /usr/lib/libdlog.so.0.0.0
b76de000 b76e3000 r-xp /usr/lib/libbundle.so.0.1.22
b76e4000 b76e7000 r-xp /lib/libdl-2.20-2014.11.so
b76e9000 b770e000 r-xp /usr/lib/libaul.so.0.1.0
b7711000 b7713000 r-xp /usr/lib/libappsvc.so.0.1.0
b7714000 b7719000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b771a000 b7721000 r-xp /usr/lib/libappcore-efl.so.1.1
b7723000 b7728000 r-xp /usr/lib/libsys-assert.so
b772b000 b772c000 r-xp [vdso]
b772c000 b774e000 r-xp /lib/ld-2.20-2014.11.so
b7750000 b7758000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:6161)
Call Stack Count: 10
 0: (0xb6b661f6) [/usr/lib/libsqlite3.so.0] + 0xad1f6
 1: init_db + 0x13f (0xb37918df) [/opt/usr/apps/org.example.example/bin/example] + 0x88df
 2: create_base_gui + 0xc11 (0xb3791701) [/opt/usr/apps/org.example.example/bin/example] + 0x8701
 3: app_create + 0x2c (0xb379095c) [/opt/usr/apps/org.example.example/bin/example] + 0x795c
 4: (0xb771665b) [/usr/lib/libcapi-appfw-application.so.0] + 0x265b
 5: appcore_efl_main + 0x327 (0xb771dc27) [/usr/lib/libappcore-efl.so.1] + 0x3c27
 6: ui_app_main + 0x140 (0xb7716c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
 7: main + 0x2a5 (0xb37908d5) [/opt/usr/apps/org.example.example/bin/example] + 0x78d5
 8: (0xb7752148) [/opt/usr/apps/org.example.example/bin/example] + 0xb7752148
 9: __libc_start_main + 0xde (0xb6c3fe4e) [/lib/libc.so.6] + 0x17e4e
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
 _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_2056302642], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 00:21:48.962+0900 D/PKGMGR  ( 3035): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_2056302642], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 00:21:48.972+0900 D/ISF_PANEL_EFL( 3035): isf_panel_efl.cpp: _package_manager_event_cb(1387) > type=tpk package=org.example.example event_type=INSTALL event_state=COMPLETED progress=100 error=0
06-01 00:21:48.972+0900 W/ISF_PANEL_EFL( 3035): isf_panel_efl.cpp: _package_manager_event_cb(1512) > _isf_insert_ime_info_by_pkgid returned 0.
06-01 00:21:48.972+0900 D/PKGMGR  ( 2966): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_2056302642], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 00:21:48.972+0900 D/PRIVILEGE_CHECKER( 2966): privilege_checker.c: __privilege_checker_check_privilege(45) > _ENTER_
06-01 00:21:48.972+0900 E/PRIVILEGE_CHECKER( 2966): privilege_checker.c: __privilege_checker_check_privilege(78) > Please declare http://tizen.org/privilege/package.info in tizen-manifest.xml or config.xml
06-01 00:21:48.972+0900 D/PRIVILEGE_CHECKER( 2966): privilege_checker.c: __privilege_checker_check_privilege(45) > _ENTER_
06-01 00:21:48.992+0900 D/PKGMGR  ( 2964): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_2056302642], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 00:21:48.992+0900 D/ESD     ( 2964): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29640002), pkg_type(tpk), pkgid(org.example.example), key(end), val(ok)
06-01 00:21:48.992+0900 D/ESD     ( 2964): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
06-01 00:21:48.992+0900 D/PKGMGR  ( 2954): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_2056302642], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 00:21:48.992+0900 D/DATA_PROVIDER_MASTER( 2954): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.example] ok
06-01 00:21:48.992+0900 D/DATA_PROVIDER_MASTER( 2954): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.example], event_type[1]
06-01 00:21:48.992+0900 D/DATA_PROVIDER_MASTER( 2954): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
06-01 00:21:48.992+0900 D/DATA_PROVIDER_MASTER( 2954): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
06-01 00:21:48.992+0900 D/DATA_PROVIDER_MASTER( 2954): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
06-01 00:21:48.992+0900 D/DATA_PROVIDER_MASTER( 2954): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.example]
06-01 00:21:48.992+0900 D/PKGMGR  ( 2977): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_2056302642], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 00:21:48.992+0900 D/PKGMGR  ( 2977): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
06-01 00:21:48.992+0900 D/PKGMGR  ( 2773): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[install], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_2056302642], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 00:21:48.992+0900 D/AUL_AMD ( 2773): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.example), key(end), value(ok)
06-01 00:21:48.992+0900 W/AUL_AMD ( 2773): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(install), value(ok)
06-01 00:21:48.992+0900 D/rpm-installer( 6307): rpm-installer-privilege.c: _ri_privilege_enable_permissions(106) > [smack] app_enable_permissions(org.example.example, 7), result=[0]
06-01 00:21:48.992+0900 D/rpm-installer( 6307): coretpk-installer.c: _coretpk_installer_prepare_package_install_with_debug(3285) > _ri_privilege_enable_permissions(privilege/appdebuging succeeded for debug_mode.
06-01 00:21:48.992+0900 D/rpm-installer( 6307): rpm-appcore-intf.c: main(236) > sync() start
06-01 00:21:48.992+0900 D/AUL_AMD ( 2773): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.example, type:rpm
06-01 00:21:48.992+0900 D/PKGMGR  ( 2904): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_2056302642], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 00:21:48.992+0900 W/cluster-home( 2904): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[0], state[2], package[org.example.example]
06-01 00:21:48.992+0900 D/cluster-home( 2904): widget-data-provider.cpp: PackageUpdated(2160) >  No boxes that pkgname is[org.example.example]
06-01 00:21:48.992+0900 D/PKGMGR  ( 2904): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_2056302642], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 00:21:48.992+0900 D/cluster-home( 2904): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29040003] pkg_type[tpk] package[org.example.example] key[end] val[ok] pmsg[(null)]
06-01 00:21:48.992+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
06-01 00:21:48.992+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
06-01 00:21:48.992+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
06-01 00:21:48.992+0900 D/cluster-home( 2904): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
06-01 00:21:48.992+0900 D/cluster-home( 2904): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.example]
06-01 00:21:48.992+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.example]
06-01 00:21:48.992+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.example]
06-01 00:21:48.992+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
06-01 00:21:48.992+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
06-01 00:21:48.992+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.example]
06-01 00:21:49.022+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.example] Name[forpet] Icon[/opt/usr/apps/org.example.example/shared/res/1.jpg] enable[1] system[0]
06-01 00:21:49.022+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: OnAppInstalled(309) >  pAppId [org.example.example]
06-01 00:21:49.022+0900 D/cluster-home( 2904): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.example
06-01 00:21:49.022+0900 D/cluster-home( 2904): mainmenu-data-manager.cpp: GetBoxDataByAppId(1879) >  cannot find box with appid[org.example.example]
06-01 00:21:49.022+0900 D/cluster-home( 2904): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
06-01 00:21:49.022+0900 D/cluster-home( 2904): mainmenu-data-manager.cpp: InsertBoxData(552) >  current last page [1, 1] box[20] [4, 4]
06-01 00:21:49.032+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: OnAppInstalled(316) >  box id [23]
06-01 00:21:49.042+0900 D/cluster-home( 2904): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
06-01 00:21:49.042+0900 D/rpm-installer( 6307): rpm-appcore-intf.c: main(238) > sync() end
06-01 00:21:49.042+0900 D/cluster-home( 2904): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
06-01 00:21:49.042+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.example] Name[forpet] Icon[/opt/usr/apps/org.example.example/shared/res/1.jpg] enable[1] system[0]
06-01 00:21:49.042+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: OnAppInstalled(323) >  name [forpet]
06-01 00:21:49.042+0900 D/test-log( 2904): mainmenu-view-manager-impl.cpp: AddMenuBox(282) >  AppInfo name [forpet] [1] [1,5, 1]
06-01 00:21:49.042+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(347) >  AddBox Name[forpet] pageid[1] pos[1, 5]
06-01 00:21:49.042+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(354) >  menuPage.GetPageId() = 100001, boxPageId = 1
06-01 00:21:49.042+0900 D/cluster-home( 2904): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 1, appId = $appId, name = $name, col = 1, row = 5, isPreload = 0, isSystem = 0 WHERE boxId = 23]
06-01 00:21:49.052+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(540) >  Do reorder
06-01 00:21:49.052+0900 D/cluster-home( 2904): mainmenu-data-manager.cpp: GetPageDataListByAlphabeticalOrder(1404) >  Alphabetical order Count : Box[17] Page[1]
06-01 00:21:49.052+0900 D/cluster-home( 2904): mainmenu-data-manager.cpp: GetPageDataListByAlphabeticalOrder(1411) >  page count[1]
06-01 00:21:49.052+0900 D/cluster-home( 2904): mainmenu-data-manager.cpp: GetPageDataListByAlphabeticalOrder(1423) >  nVirtualPageId[100001] pageNo[1]
06-01 00:21:49.052+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(559) >  pageId[100001]
06-01 00:21:49.052+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuPage(689) >  BEGIN nTotalPageCount[1] mAppsPages.size[1]
06-01 00:21:49.052+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuPage(701) >  pageId[100001] pageNo[1]
06-01 00:21:49.052+0900 D/cluster-view( 2904): homescreen-page-indicator.cpp: Update(281) >  Unit size is same [1]
06-01 00:21:49.052+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuPage(760) >  _SortingPageOrder
06-01 00:21:49.052+0900 D/test-log( 2904): mainmenu-apps-view-impl.cpp: _SortingPageOrder(1065) >  !!!!!!!!!!!![1],[100001]!!!!!!!!!!!!!!
06-01 00:21:49.052+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: SetLayoutPosition(1115) >  layoutposition [1]
06-01 00:21:49.052+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: OnPageDataNotify(226) >  Page [1]
06-01 00:21:49.052+0900 D/cluster-home( 2904): mainmenu-data-manager.cpp: UpdatePageDataForAlphaBeticalOrder(822) >  Do nothing while alphabetical order
06-01 00:21:49.052+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuPage(763) >  END
06-01 00:21:49.052+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.basicui] Name[basicui] Icon[/opt/usr/apps/org.example.basicui/shared/res/basicui.png] enable[1] system[0]
06-01 00:21:49.052+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.basicui'], count[0]
06-01 00:21:49.052+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.basicui][-17956860][0]
06-01 00:21:49.052+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.basicui]
06-01 00:21:49.052+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[basicui] pos[1, 1] pageId[100001]
06-01 00:21:49.052+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[20]
06-01 00:21:49.052+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[1], [1, 1]
06-01 00:21:49.052+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[1], [1, 1]
06-01 00:21:49.052+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:21:49.052+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.calendar] Name[Calendar] Icon[/usr/share/icons/default/small/calendar.png] enable[1] system[1]
06-01 00:21:49.052+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.calendar'], count[0]
06-01 00:21:49.052+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.calendar][-17956860][0]
06-01 00:21:49.052+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.calendar]
06-01 00:21:49.052+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Calendar] pos[2, 1] pageId[100001]
06-01 00:21:49.052+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[2]
06-01 00:21:49.052+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[2], [2, 1]
06-01 00:21:49.052+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[2], [2, 1]
06-01 00:21:49.052+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:21:49.052+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.camera-app] Name[Camera] Icon[/usr/share/icons/default/small/org.tizen.camera-app.png] enable[1] system[1]
06-01 00:21:49.052+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.camera-app'], count[0]
06-01 00:21:49.062+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.camera-app][-17956860][0]
06-01 00:21:49.062+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.camera-app]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Camera] pos[3, 1] pageId[100001]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[3]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[3], [3, 1]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[3], [3, 1]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:21:49.062+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.clockui2] Name[clockui2] Icon[/opt/usr/apps/org.example.clockui2/shared/res/clockui2.png] enable[1] system[0]
06-01 00:21:49.062+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.clockui2'], count[0]
06-01 00:21:49.062+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.clockui2][-17956860][0]
06-01 00:21:49.062+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.clockui2]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[clockui2] pos[4, 1] pageId[100001]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[16]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[4], [4, 1]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[4], [4, 1]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:21:49.062+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.contacts] Name[Contacts] Icon[/usr/share/icons/default/small/org.tizen.contacts.png] enable[1] system[1]
06-01 00:21:49.062+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.contacts'], count[0]
06-01 00:21:49.062+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.contacts][-17956860][0]
06-01 00:21:49.062+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.contacts]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Contacts] pos[1, 2] pageId[100001]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[4]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[5], [1, 2]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[5], [1, 2]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:21:49.062+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.email] Name[Email] Icon[/usr/apps/org.tizen.email/shared/res/org.tizen.email.png] enable[1] system[1]
06-01 00:21:49.062+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.email'], count[1]
06-01 00:21:49.062+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.email]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Email] pos[2, 2] pageId[100001]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[5]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[6], [2, 2]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[6], [2, 2]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:21:49.062+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.emailui] Name[emailui] Icon[/opt/usr/apps/org.example.emailui/shared/res/emailui.png] enable[1] system[0]
06-01 00:21:49.062+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.emailui'], count[0]
06-01 00:21:49.062+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.emailui][-17956860][0]
06-01 00:21:49.062+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.emailui]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[emailui] pos[3, 2] pageId[100001]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[15]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[7], [3, 2]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[7], [3, 2]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:21:49.062+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.example] Name[forpet] Icon[/opt/usr/apps/org.example.example/shared/res/1.jpg] enable[1] system[0]
06-01 00:21:49.062+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.example'], count[0]
06-01 00:21:49.062+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.example][-17956860][0]
06-01 00:21:49.062+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.example]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[forpet] pos[4, 2] pageId[100001]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[0]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(787) >  AddBoxToMenuView
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(347) >  AddBox Name[forpet] pageid[100001] pos[4, 2]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(354) >  menuPage.GetPageId() = 100001, boxPageId = 100001
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: AddBoxToPage(112) >  void ClusterHome3D::Internal::CMainMenuPage::AddBoxToPage(std::shared_ptr<CMainMenuBoxData>) : 112
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: AddBoxToPage(122) >  void ClusterHome3D::Internal::CMainMenuPage::AddBoxToPage(std::shared_ptr<CMainMenuBoxData>) : 122
06-01 00:21:49.062+0900 D/test-log( 2904): mainmenu-page-impl.cpp: AddBoxToPage(123) >  create box[org.example.example] [4,2]
06-01 00:21:49.062+0900 D/test-log( 2904): mainmenu-box-impl.cpp: CMainMenuBox(148) >  create box
06-01 00:21:49.062+0900 D/test-log( 2904): mainmenu-box-impl.cpp: SetPosition(459) >  cut Animation : forpet
06-01 00:21:49.062+0900 D/test-log( 2904): mainmenu-page-impl.cpp: AddBoxToPage(177) >  add created box
06-01 00:21:49.062+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.gallery] Name[Gallery] Icon[/usr/share/icons/default/small/org.tizen.gallery.png] enable[1] system[1]
06-01 00:21:49.062+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.gallery'], count[0]
06-01 00:21:49.062+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.gallery][-17956860][0]
06-01 00:21:49.062+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.gallery]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Gallery] pos[1, 3] pageId[100001]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[6]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[9], [1, 3]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[8], [4, 2]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:21:49.062+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.browser] Name[Internet] Icon[/usr/share/icons/default/small/org.tizen.browser.png] enable[1] system[1]
06-01 00:21:49.062+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.browser'], count[0]
06-01 00:21:49.062+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.browser][-17956860][0]
06-01 00:21:49.062+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.browser]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Internet] pos[2, 3] pageId[100001]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[1]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[10], [2, 3]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:21:49.062+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.message] Name[Messages] Icon[/usr/share/icons/default/small/org.tizen.message.png] enable[1] system[1]
06-01 00:21:49.062+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.message'], count[1]
06-01 00:21:49.062+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.message]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Messages] pos[3, 3] pageId[100001]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[7]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[11], [3, 3]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:21:49.062+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.music-player] Name[Music] Icon[/usr/share/icons/default/small/org.tizen.music-player.png] enable[1] system[1]
06-01 00:21:49.062+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.music-player'], count[0]
06-01 00:21:49.062+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.music-player][-17956860][0]
06-01 00:21:49.062+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.music-player]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Music] pos[4, 3] pageId[100001]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[8]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[12], [4, 3]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:21:49.062+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.myfile] Name[My Files] Icon[/usr/share/icons/default/small/org.tizen.myfile.png] enable[1] system[1]
06-01 00:21:49.062+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.myfile'], count[0]
06-01 00:21:49.062+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.myfile][-17956860][0]
06-01 00:21:49.062+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.myfile]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[My Files] pos[1, 4] pageId[100001]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[9]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[13], [1, 4]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:21:49.062+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.phone] Name[Phone] Icon[/usr/share/icons/default/small/org.tizen.phone.png] enable[1] system[1]
06-01 00:21:49.062+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.phone'], count[0]
06-01 00:21:49.062+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.phone][-17956860][0]
06-01 00:21:49.062+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.phone]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Phone] pos[2, 4] pageId[100001]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[10]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[14], [2, 4]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:21:49.062+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.setting] Name[Settings] Icon[/usr/share/icons/default/small/org.tizen.setting.png] enable[1] system[1]
06-01 00:21:49.062+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.setting'], count[0]
06-01 00:21:49.062+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.setting][-17956860][0]
06-01 00:21:49.062+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.setting]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Settings] pos[3, 4] pageId[100001]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[11]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[15], [3, 4]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:21:49.062+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.uibuildernavigationview] Name[uibuildernavigationview] Icon[/opt/usr/apps/org.example.uibuildernavigationview/shared/res/uibuildernavigationview.png] enable[1] system[0]
06-01 00:21:49.062+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.uibuildernavigationview'], count[0]
06-01 00:21:49.062+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.uibuildernavigationview][-17956860][0]
06-01 00:21:49.062+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.uibuildernavigationview]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[uibuildernavigationview] pos[4, 4] pageId[100001]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[14]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[16], [4, 4]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:21:49.062+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.videos] Name[Video] Icon[/usr/share/icons/default/small/org.tizen.videos.png] enable[1] system[1]
06-01 00:21:49.062+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.videos'], count[0]
06-01 00:21:49.062+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.videos][-17956860][0]
06-01 00:21:49.062+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.videos]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Video] pos[1, 5] pageId[100001]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[12]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[17], [1, 5]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:21:49.062+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: RearrangeItems(243) >  view type [1]
06-01 00:21:49.272+0900 D/rpm-installer( 6307): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
06-01 00:21:49.272+0900 D/rpm-installer( 6307): rpm-appcore-intf.c: main(259) > ------------------------------------------------
06-01 00:21:49.272+0900 D/rpm-installer( 6307): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
06-01 00:21:49.272+0900 D/rpm-installer( 6307): rpm-appcore-intf.c: main(261) > ------------------------------------------------
06-01 00:21:49.272+0900 D/PKGMGR_SERVER( 6293): pkgmgr-server.c: sighandler(387) > child exit [6307]
06-01 00:21:49.272+0900 E/PKGMGR_SERVER( 6293): pkgmgr-server.c: sighandler(402) > child NORMAL exit [6307]
06-01 00:21:49.992+0900 E/PKGMGR_SERVER( 6293): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-01 00:21:49.992+0900 E/PKGMGR_SERVER( 6293): pkgmgr-server.c: main(2265) > package manager server terminated.
06-01 00:21:50.102+0900 D/AUL_AMD ( 2773): amd_request.c: __request_handler(838) > __request_handler: 0
06-01 00:21:50.102+0900 D/AUL_AMD ( 2773): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-01 00:21:50.102+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 00:21:50.102+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 00:21:50.102+0900 I/AUL     ( 2773): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
06-01 00:21:50.102+0900 D/AUL     ( 2773): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 6361, pid = 6364
06-01 00:21:50.102+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 00:21:50.102+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 00:21:50.102+0900 I/AUL     ( 2773): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
06-01 00:21:50.102+0900 E/AUL_AMD ( 2773): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-01 00:21:50.102+0900 W/AUL_AMD ( 2773): amd_launch.c: _start_app(2233) > caller pid : 6364
06-01 00:21:50.102+0900 E/AUL_AMD ( 2773): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-01 00:21:50.112+0900 W/AUL_AMD ( 2773): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-01 00:21:50.112+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2648) > process_pool: false
06-01 00:21:50.112+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-01 00:21:50.112+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-01 00:21:50.112+0900 W/AUL_AMD ( 2773): amd_launch.c: _start_app(2665) > pad pid(-5)
06-01 00:21:50.112+0900 D/AUL_AMD ( 2773): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-01 00:21:50.112+0900 D/AUL_AMD ( 2773): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-01 00:21:50.112+0900 D/AUL     ( 2773): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-01 00:21:50.112+0900 D/AUL_PAD ( 2951): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-01 00:21:50.112+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 00:21:50.112+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 00:21:50.112+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 00:21:50.112+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 00:21:50.112+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 00:21:50.112+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 00:21:50.112+0900 D/AUL_PAD ( 2951): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-01 00:21:50.112+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-01 00:21:50.112+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-01 00:21:50.112+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-01 00:21:50.112+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-01 00:21:50.112+0900 D/AUL_PAD ( 2951): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-01 00:21:50.112+0900 D/AUL_PAD ( 2951): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-01 00:21:50.112+0900 W/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-01 00:21:50.112+0900 D/AUL     ( 2951): process_pool.c: __send_pkt_raw_data(219) > send(11) : 620 / 620
06-01 00:21:50.112+0900 D/AUL_PAD ( 2951): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 6161, bin path: /opt/usr/apps/org.example.example/bin/example
06-01 00:21:50.112+0900 W/AUL_PAD ( 2951): launchpad.c: __send_result_to_caller(265) > Check app launching
06-01 00:21:50.112+0900 D/AUL_PAD ( 2951): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-01 00:21:50.112+0900 D/RESOURCED( 2886): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-01 00:21:50.112+0900 D/AUL_PAD ( 6161): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-01 00:21:50.112+0900 D/RESOURCED( 2886): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-01 00:21:50.112+0900 D/AUL_PAD ( 6161): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
06-01 00:21:50.112+0900 E/RESOURCED( 2886): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-01 00:21:50.112+0900 D/AUL_PAD ( 6161): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-01 00:21:50.112+0900 D/AUL_PAD ( 6161): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-01 00:21:50.112+0900 D/AUL_PAD ( 6161): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-01 00:21:50.112+0900 D/AUL_PAD ( 6161): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-01 00:21:50.112+0900 D/AUL     ( 6161): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (6170) is sent.
06-01 00:21:50.112+0900 D/AUL     ( 6161): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 6170, signo: 10
06-01 00:21:50.112+0900 D/AUL     ( 6161): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-01 00:21:50.112+0900 D/AUL_PAD ( 6161): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-01 00:21:50.112+0900 D/AUL_PAD ( 6161): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-01 00:21:50.112+0900 D/AUL_PAD ( 6161): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-01 00:21:50.112+0900 D/AUL_PAD ( 6161): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-01 00:21:50.112+0900 D/AUL_PAD ( 6161): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTYyNDQxMTAvMTExODUwAA==##
06-01 00:21:50.112+0900 D/AUL_PAD ( 6161): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-01 00:21:50.112+0900 D/AUL_PAD ( 6161): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA2MzY0AA==##
06-01 00:21:50.112+0900 D/AUL_PAD ( 6161): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-01 00:21:50.112+0900 D/AUL_PAD ( 6161): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-01 00:21:50.112+0900 D/AUL_PAD ( 6161): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-01 00:21:50.112+0900 D/AUL_PAD ( 6161): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-01 00:21:50.112+0900 D/AUL_PAD ( 6161): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-01 00:21:50.122+0900 I/CAPI_APPFW_APPLICATION( 6161): app_main.c: ui_app_main(788) > app_efl_main
06-01 00:21:50.122+0900 D/LAUNCH  ( 6161): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-01 00:21:50.122+0900 D/APP_CORE( 6161): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-01 00:21:50.122+0900 D/APP_CORE( 6161): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-01 00:21:50.122+0900 D/APP_CORE( 6161): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-01 00:21:50.142+0900 D/APP_CORE( 6161): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-01 00:21:50.142+0900 D/AUL     ( 6161): app_sock.c: __create_server_sock(156) > pg path - already exists
06-01 00:21:50.142+0900 D/APP_CORE( 6161): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb4276520
06-01 00:21:50.142+0900 D/LAUNCH  ( 6161): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-01 00:21:50.142+0900 I/CAPI_APPFW_APPLICATION( 6161): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-01 00:21:50.212+0900 D/AUL_PAD ( 2951): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-01 00:21:50.212+0900 W/AUL     ( 2773): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 6161, appid: org.example.example
06-01 00:21:50.212+0900 D/AUL     ( 2773): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-01 00:21:50.212+0900 E/AUL     ( 2773): simple_util.c: __trm_app_info_send_socket(330) > access
06-01 00:21:50.212+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2700) > add app group info
06-01 00:21:50.212+0900 E/AUL     ( 2773): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-01 00:21:50.212+0900 D/AUL_AMD ( 2773): amd_status.c: _status_add_app_info_list(427) > pid(6161) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-01 00:21:50.222+0900 D/RESOURCED( 2886): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 6161
06-01 00:21:50.222+0900 D/RESOURCED( 2886): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-01 00:21:50.222+0900 E/RESOURCED( 2886): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-01 00:21:50.222+0900 D/RESOURCED( 2886): proc-main.c: resourced_proc_status_change(888) > available memory = 299
06-01 00:21:50.242+0900 I/user_tag0( 6161): /opt/usr/apps/org.example.example/data/test.db
06-01 00:21:50.322+0900 W/CRASH_MANAGER( 6369): worker.c: worker_job(1204) > 1106161657861149624411
