S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 28255
Date: 2017-04-01 07:37:37+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x2c

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb7fcb610, esi = 0xb7fb0598
ebp = 0xbfcbe8d8, esp = 0xbfcbe880
eax = 0xb7fcb568, ebx = 0xb72a65f0
ecx = 0xb37485c0, edx = 0x00000000
eip = 0xb710a251

Memory Information
MemTotal:      123 KB
MemFree:        15 KB
Buffers:        12 KB
Cached:     178804 KB
VmPeak:      79908 KB
VmSize:      79908 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16040 KB
VmRSS:       16040 KB
VmData:      19992 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33320 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 28255 TID = 28255
28255 28257 28445 

Maps Information
b2c2e000 b2c38000 r-xp /usr/lib/libfeedback.so.0.1.4
b2c3e000 b2c4a000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2c4b000 b2c6c000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2c71000 b2c72000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2c73000 b2c78000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2c79000 b2c7a000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2c7b000 b2c7d000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c7e000 b2c80000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2c81000 b2c8d000 r-xp /usr/lib/libdrm.so.2.4.0
b2c8e000 b2c91000 r-xp /usr/lib/libdri2.so.0.0.0
b2c92000 b2c9c000 r-xp /usr/lib/libtbm.so.1.0.0
b2ca3000 b2ca4000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2ca5000 b2ca6000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2ca7000 b2caa000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b2cab000 b2cae000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b2caf000 b2cc4000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2cc5000 b2cd7000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b35e0000 b35e6000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b35e7000 b372b000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b373b000 b373c000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b373d000 b3746000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3747000 b374b000 r-xp /opt/usr/apps/org.example.example/bin/example
b374d000 b3786000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4189000 b4194000 r-xp /lib/libnss_files-2.20-2014.11.so
b4196000 b41a1000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41a3000 b41ba000 r-xp /lib/libnsl-2.20-2014.11.so
b41be000 b41c6000 r-xp /lib/libnss_compat-2.20-2014.11.so
b41c8000 b41ec000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b41ed000 b41ee000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b41ef000 b41f2000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b41f3000 b41fa000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b41fb000 b4205000 r-xp /usr/lib/libsensord-share.so
b4206000 b4222000 r-xp /usr/lib/libsensor.so.1.2.0
b4224000 b422d000 r-xp /usr/lib/libappcore-common.so.1.1
b4230000 b4232000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4247000 b4249000 r-xp /usr/lib/libXau.so.6.0.0
b424a000 b426c000 r-xp /usr/lib/libxcb.so.1.1.0
b426e000 b4277000 r-xp /lib/libcrypt-2.20-2014.11.so
b42a0000 b42a2000 r-xp /usr/lib/libiri.so
b42a3000 b42c9000 r-xp /lib/libexpat.so.1.5.2
b42cb000 b4336000 r-xp /usr/lib/libssl.so.1.0.0
b433c000 b4348000 r-xp /usr/lib/libethumb.so.1.13.0
b4349000 b434d000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b434e000 b459f000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b1a000 b5b2a000 r-xp /usr/lib/libXi.so.6.1.0
b5b2b000 b5b2d000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b2e000 b5b34000 r-xp /usr/lib/libXtst.so.6.1.0
b5b35000 b5b3f000 r-xp /usr/lib/libXrender.so.1.3.0
b5b40000 b5b49000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b4b000 b5b4d000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b4e000 b5b53000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b54000 b5b66000 r-xp /usr/lib/libXext.so.6.4.0
b5b67000 b5b69000 r-xp /usr/lib/libXdamage.so.1.1.0
b5b6a000 b5b6c000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5b6e000 b5cb0000 r-xp /usr/lib/libX11.so.6.3.0
b5cb4000 b5cbe000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cbf000 b5cd5000 r-xp /usr/lib/libudev.so.1.6.0
b5cd8000 b5cdc000 r-xp /lib/libattr.so.1.1.0
b5cdd000 b5d0c000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d0e000 b5d14000 r-xp /usr/lib/libffi.so.6.0.2
b5d15000 b5d38000 r-xp /lib/libz.so.1.2.8
b5d39000 b5d3c000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d3d000 b5e99000 r-xp /usr/lib/libxml2.so.2.9.2
b5e9f000 b5f86000 r-xp /usr/lib/libstdc++.so.6.0.20
b5f93000 b5f96000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5f97000 b5fb9000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5fba000 b5fce000 r-xp /lib/libresolv-2.20-2014.11.so
b5fd2000 b5ff6000 r-xp /usr/lib/liblzma.so.5.0.3
b5ff7000 b5ff9000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5ffb000 b6005000 r-xp /usr/lib/libembryo.so.1.13.0
b6006000 b602f000 r-xp /usr/lib/libpng12.so.0.50.0
b6030000 b6079000 r-xp /usr/lib/libjpeg.so.8.0.2
b608a000 b6091000 r-xp /lib/librt-2.20-2014.11.so
b6093000 b60b2000 r-xp /usr/lib/libector.so.1.13.0
b60b5000 b60e2000 r-xp /usr/lib/liblua-5.1.so
b60e3000 b6173000 r-xp /usr/lib/libfreetype.so.6.11.3
b6177000 b61b5000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61b6000 b61cc000 r-xp /usr/lib/libfribidi.so.0.3.1
b61cd000 b6226000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6229000 b6274000 r-xp /lib/libm-2.20-2014.11.so
b6276000 b6288000 r-xp /usr/lib/libeio.so.1.13.0
b6289000 b628c000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b628d000 b6293000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6294000 b62b7000 r-xp /usr/lib/libefreet.so.1.13.0
b62ba000 b62e5000 r-xp /usr/lib/libeldbus.so.1.13.0
b62e6000 b631a000 r-xp /usr/lib/libecore_con.so.1.13.0
b631c000 b6325000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6326000 b632f000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6330000 b6343000 r-xp /usr/lib/libeo.so.1.13.0
b6345000 b6358000 r-xp /usr/lib/libecore_input.so.1.13.0
b6359000 b6360000 r-xp /usr/lib/libecore_file.so.1.13.0
b6361000 b6384000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6385000 b63b1000 r-xp /usr/lib/libeet.so.1.13.0
b63ba000 b6425000 r-xp /usr/lib/libeina.so.1.13.0
b6428000 b643f000 r-xp /usr/lib/libefl.so.1.13.0
b6441000 b65a8000 r-xp /usr/lib/libicuuc.so.51.1
b65b6000 b67c2000 r-xp /usr/lib/libicui18n.so.51.1
b67ca000 b6819000 r-xp /usr/lib/libecore_x.so.1.13.0
b681b000 b6835000 r-xp /lib/libgcc_s-4.9.so.1
b6837000 b683b000 r-xp /lib/libcap.so.2.21
b683c000 b6882000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6883000 b688a000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b688c000 b68de000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b68e0000 b6a6b000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6a70000 b6b3e000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b41000 b6b45000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b46000 b6b55000 r-xp /usr/lib/libvconf.so.0.2.45
b6b56000 b6b59000 r-xp /usr/lib/libvasum.so.0.3.1
b6b5a000 b6b5d000 r-xp /usr/lib/libttrace.so.1.1
b6b5f000 b6b63000 r-xp /usr/lib/libiniparser.so.0
b6b64000 b6b94000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6b95000 b6b9e000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6b9f000 b6bc4000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bc5000 b6bd5000 r-xp /usr/lib/libunwind.so.8.0.1
b6bdf000 b6d8d000 r-xp /lib/libc-2.20-2014.11.so
b6d95000 b6ed8000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6eda000 b6f32000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f33000 b6f67000 r-xp /usr/lib/libsystemd.so.0.4.0
b6f6a000 b703e000 r-xp /usr/lib/libedje.so.1.13.0
b7041000 b706d000 r-xp /usr/lib/libecore.so.1.13.0
b707e000 b72a4000 r-xp /usr/lib/libevas.so.1.13.0
b72cc000 b72e4000 r-xp /lib/libpthread-2.20-2014.11.so
b72e8000 b7662000 r-xp /usr/lib/libelementary.so.1.13.0
b7682000 b7686000 r-xp /usr/lib/libsmack.so.1.0.0
b7687000 b7690000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7691000 b7694000 r-xp /usr/lib/libdlog.so.0.0.0
b7695000 b769a000 r-xp /usr/lib/libbundle.so.0.1.22
b769b000 b769e000 r-xp /lib/libdl-2.20-2014.11.so
b76a0000 b76c5000 r-xp /usr/lib/libaul.so.0.1.0
b76c8000 b76ca000 r-xp /usr/lib/libappsvc.so.0.1.0
b76cb000 b76d0000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b76d1000 b76d8000 r-xp /usr/lib/libappcore-efl.so.1.1
b76da000 b76df000 r-xp /usr/lib/libsys-assert.so
b76e2000 b76e3000 r-xp [vdso]
b76e3000 b7705000 r-xp /lib/ld-2.20-2014.11.so
b7707000 b770f000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:28255)
Call Stack Count: 10
 0: evas_object_smart_callback_priority_add + 0x91 (0xb710a251) [/usr/lib/libevas.so.1] + 0x8c251
 1: evas_object_smart_callback_add + 0x38 (0xb710a338) [/usr/lib/libevas.so.1] + 0x8c338
 2: create_base_gui + 0x8e4 (0xb3749834) [/opt/usr/apps/org.example.example/bin/example] + 0x2834
 3: app_create + 0x2c (0xb3748dbc) [/opt/usr/apps/org.example.example/bin/example] + 0x1dbc
 4: (0xb76cd65b) [/usr/lib/libcapi-appfw-application.so.0] + 0x265b
 5: appcore_efl_main + 0x327 (0xb76d4c27) [/usr/lib/libappcore-efl.so.1] + 0x3c27
 6: ui_app_main + 0x140 (0xb76cdc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
 7: main + 0x27e (0xb3748d2e) [/opt/usr/apps/org.example.example/bin/example] + 0x1d2e
 8: create_base_gui + 0x1f8 (0xb7709148) [/opt/usr/apps/org.example.example/bin/example] + 0xb7709148
 9: __libc_start_main + 0xde (0xb6bf6e4e) [/lib/libc.so.6] + 0x17e4e
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
_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(28381), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
04-01 07:37:36.559+0900 D/PKGMGR  (28381): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
04-01 07:37:36.559+0900 D/PKGMGR_INSTALLER(28381): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.example] key[install_percent] value[100]
04-01 07:37:36.559+0900 D/PKGMGR  (28381): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(28381), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
04-01 07:37:36.559+0900 D/PKGMGR  (28381): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(28381), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
04-01 07:37:36.559+0900 D/PKGMGR  (28381): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.install.progress), signal_name(install_progress)
04-01 07:37:36.559+0900 D/rpm-installer(28381): coretpk-installer.c: _coretpk_installer_package_reinstall(5096) > _coretpk_installer_package_reinstall(org.example.example) is done.
04-01 07:37:36.559+0900 D/PKGMGR  (28381): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(28381), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
04-01 07:37:36.559+0900 D/PKGMGR  (28381): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(28381), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
04-01 07:37:36.559+0900 D/PKGMGR  (28381): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
04-01 07:37:36.559+0900 D/PKGMGR_INSTALLER(28381): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.example] key[end] value[ok]
04-01 07:37:36.559+0900 D/PKGMGR  (28381): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(28381), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
04-01 07:37:36.559+0900 D/PKGMGR  (28381): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(28381), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
04-01 07:37:36.559+0900 D/PKGMGR  (28381): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.upgrade), signal_name(upgrade)
04-01 07:37:36.559+0900 D/PKGMGR  (28379): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 07:37:36.559+0900 D/PKGMGR  ( 2976): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 07:37:36.559+0900 D/PKGMGR  ( 3052): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 07:37:36.559+0900 D/PKGMGR  ( 2960): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 07:37:36.559+0900 D/DATA_PROVIDER_MASTER( 2960): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.example] 100
04-01 07:37:36.559+0900 D/PKGMGR  ( 2974): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 07:37:36.559+0900 D/ESD     ( 2974): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29740002), pkg_type(tpk), pkgid(org.example.example), key(install_percent), val(100)
04-01 07:37:36.559+0900 D/PKGMGR  ( 2983): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 07:37:36.559+0900 D/PKGMGR  ( 2983): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
04-01 07:37:36.559+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 07:37:36.559+0900 W/cluster-home( 2906): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.example]
04-01 07:37:36.559+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 07:37:36.559+0900 D/cluster-home( 2906): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29060003] pkg_type[tpk] package[org.example.example] key[install_percent] val[100] pmsg[(null)]
04-01 07:37:36.559+0900 D/PKGMGR  (28379): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 07:37:36.559+0900 D/PKGMGR  ( 3098): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 07:37:36.559+0900 D/PKGMGR  ( 2976): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 07:37:36.559+0900 D/PKGMGR  ( 2968): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 07:37:36.569+0900 D/QUICKPANEL( 2968): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:install_percent val:100
04-01 07:37:36.569+0900 D/PKGMGR  ( 3052): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 07:37:36.569+0900 D/ISF_PANEL_EFL( 3052): isf_panel_efl.cpp: _package_manager_event_cb(1288) > type=tpk package=org.example.example event_type=UPDATE event_state=COMPLETED progress=100 error=0
04-01 07:37:36.569+0900 D/PKGMGR  ( 3098): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 07:37:36.569+0900 D/PKGMGR  ( 2968): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 07:37:36.569+0900 D/QUICKPANEL( 2968): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:end val:ok
04-01 07:37:36.569+0900 W/ISF_PANEL_EFL( 3052): isf_panel_efl.cpp: _package_manager_event_cb(1380) > isf_db_select_appids_by_pkgid returned 0.
04-01 07:37:36.569+0900 D/PKGMGR  ( 2960): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 07:37:36.569+0900 D/DATA_PROVIDER_MASTER( 2960): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.example] ok
04-01 07:37:36.569+0900 D/DATA_PROVIDER_MASTER( 2960): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.example], event_type[1]
04-01 07:37:36.569+0900 D/DATA_PROVIDER_MASTER( 2960): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
04-01 07:37:36.569+0900 D/DATA_PROVIDER_MASTER( 2960): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
04-01 07:37:36.569+0900 D/DATA_PROVIDER_MASTER( 2960): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
04-01 07:37:36.569+0900 D/DATA_PROVIDER_MASTER( 2960): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.example]
04-01 07:37:36.569+0900 D/PKGMGR  ( 2974): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 07:37:36.569+0900 D/ESD     ( 2974): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29740002), pkg_type(tpk), pkgid(org.example.example), key(end), val(ok)
04-01 07:37:36.569+0900 D/ESD     ( 2974): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
04-01 07:37:36.569+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 07:37:36.569+0900 W/cluster-home( 2906): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[2], package[org.example.example]
04-01 07:37:36.569+0900 D/cluster-home( 2906): widget-data-provider.cpp: PackageUpdated(2160) >  No boxes that pkgname is[org.example.example]
04-01 07:37:36.569+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 07:37:36.569+0900 D/cluster-home( 2906): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29060003] pkg_type[tpk] package[org.example.example] key[end] val[ok] pmsg[(null)]
04-01 07:37:36.569+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
04-01 07:37:36.569+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
04-01 07:37:36.569+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
04-01 07:37:36.569+0900 D/PKGMGR  ( 2763): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[upgrade], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 07:37:36.569+0900 D/AUL_AMD ( 2763): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.example), key(end), value(ok)
04-01 07:37:36.569+0900 W/AUL_AMD ( 2763): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(update), value(ok)
04-01 07:37:36.569+0900 D/cluster-home( 2906): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
04-01 07:37:36.569+0900 D/cluster-home( 2906): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.example]
04-01 07:37:36.569+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.example]
04-01 07:37:36.569+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.example]
04-01 07:37:36.569+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
04-01 07:37:36.569+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
04-01 07:37:36.569+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.example]
04-01 07:37:36.569+0900 D/AUL_AMD ( 2763): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.example, type:rpm
04-01 07:37:36.579+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.example] Name[example] Icon[/opt/usr/apps/org.example.example/shared/res/example.png] enable[1] system[0]
04-01 07:37:36.579+0900 D/cluster-home( 2906): mainmenu-presenter.cpp: OnAppUpdated(337) >  pAppId [org.example.example]
04-01 07:37:36.579+0900 D/cluster-home( 2906): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.example
04-01 07:37:36.579+0900 D/cluster-home( 2906): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[14], isFolder[0], pageId[1], col[2], row[4], appId[org.example.example], name[example], menuId[1], isPreload[0] isPreload[0]
04-01 07:37:36.579+0900 D/cluster-home( 2906): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
04-01 07:37:36.579+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.example] Name[example] Icon[/opt/usr/apps/org.example.example/shared/res/example.png] enable[1] system[0]
04-01 07:37:36.579+0900 D/cluster-home( 2906): mainmenu-presenter.cpp: OnAppUpdated(364) >  name [example]
04-01 07:37:36.579+0900 D/cluster-home( 2906): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
04-01 07:37:36.579+0900 D/cluster-home( 2906): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
04-01 07:37:36.579+0900 D/test-log( 2906): mainmenu-box-impl.cpp: UpdateBoxData(812) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.example/shared/res/example.png], New icon path[/opt/usr/apps/org.example.example/shared/res/example.png]!!!!!
04-01 07:37:36.579+0900 D/cluster-home( 2906): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 1, appId = $appId, name = $name, col = 2, row = 4, isPreload = 0, isSystem = 0 WHERE boxId = 14]
04-01 07:37:36.579+0900 D/PKGMGR  ( 2983): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 07:37:36.579+0900 D/PKGMGR  ( 2983): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
04-01 07:37:36.639+0900 D/rpm-installer(28381): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
04-01 07:37:36.639+0900 D/rpm-installer(28381): rpm-appcore-intf.c: main(259) > ------------------------------------------------
04-01 07:37:36.639+0900 D/rpm-installer(28381): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
04-01 07:37:36.639+0900 D/rpm-installer(28381): rpm-appcore-intf.c: main(261) > ------------------------------------------------
04-01 07:37:36.639+0900 D/PKGMGR_SERVER(28292): pkgmgr-server.c: sighandler(387) > child exit [28381]
04-01 07:37:36.639+0900 E/PKGMGR_SERVER(28292): pkgmgr-server.c: sighandler(402) > child NORMAL exit [28381]
04-01 07:37:36.699+0900 W/PROCESSMGR( 2799): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=2906
04-01 07:37:36.759+0900 D/APP_CORE( 2906): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 0
04-01 07:37:36.759+0900 D/APP_CORE( 2906): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active 0
04-01 07:37:36.759+0900 D/APP_CORE( 2906): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
04-01 07:37:36.759+0900 I/APP_CORE( 2906): appcore-efl.c: __do_app(496) > [APP 2906] Event: RESUME State: PAUSED
04-01 07:37:36.759+0900 D/LAUNCH  ( 2906): appcore-efl.c: __do_app(597) > [homescreen:Application:resume:start]
04-01 07:37:36.759+0900 D/APP_CORE( 2906): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
04-01 07:37:36.759+0900 D/APP_CORE( 2906): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
04-01 07:37:36.759+0900 D/APP_CORE( 2906): appcore-efl.c: __do_app(607) > [APP 2906] RESUME
04-01 07:37:36.759+0900 I/CAPI_APPFW_APPLICATION( 2906): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
04-01 07:37:36.759+0900 E/cluster-home( 2906): homescreen.cpp: OnResume(66) >  app resume
04-01 07:37:36.759+0900 D/cluster-home( 2906): widget-data-provider.cpp: SetBoxVisibility(1543) >  
04-01 07:37:36.759+0900 D/cluster-home( 2906): cluster-data-list.cpp: GetWidgetListByPage(776) >  cluster[0] pageNum[1]
04-01 07:37:36.759+0900 D/WIDGET_VIEWER( 2906): widget.c: widget_viewer_set_visibility(3865) > [SECURE_LOG] org.tizen.calendar.widget has no changes
04-01 07:37:36.759+0900 D/cluster-home( 2906): cluster-data-list.cpp: GetWidgetListByPage(776) >  cluster[0] pageNum[2]
04-01 07:37:36.759+0900 D/cluster-home( 2906): widget-data-provider.cpp: SetBoxVisibility(1552) >  No boxes in page[2]
04-01 07:37:36.759+0900 D/cluster-view( 2906): homescreen-view-manager.cpp: AppResume(892) >  BEGIN
04-01 07:37:36.759+0900 D/cluster-view( 2906): homescreen-view-manager.cpp: AppResume(910) >  END
04-01 07:37:36.759+0900 D/cluster-view( 2906): cluster-view-controller.cpp: _OnTTSFocusChanged(1652) >  _OnTTSFocusChanged Order[0]
04-01 07:37:36.759+0900 D/cluster-view( 2906): custom-cluster-impl.cpp: OnFocusChanged(5705) >  OnFocusChanged[0]
04-01 07:37:36.759+0900 D/cluster-view( 2906): homescreen-page-indicator.cpp: CancelOperation(300) >  CancelOperation
04-01 07:37:36.759+0900 D/cluster-view( 2906): cluster-impl.cpp: ScrollToFitPage(466) >  ScrollToFitPage
04-01 07:37:36.759+0900 D/cluster-view( 2906): cluster-impl.cpp: OnScrollSnapStart(613) >  TODO current page[0] new page[0]
04-01 07:37:36.759+0900 D/cluster-view( 2906): cluster-impl.cpp: OnScrollSnapStart(623) >  TODO current page[0] new page[0]
04-01 07:37:36.759+0900 D/test-log( 2906): cluster-impl.cpp: SetFocusedPage(791) >  Set mFocusedPage: 1
04-01 07:37:36.759+0900 D/test-log( 2906): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
04-01 07:37:36.759+0900 D/cluster-view( 2906): cluster-view-controller.cpp: OnClusterChangeFocusedPage(1779) >  Cluster[0:] 1 page focused
04-01 07:37:36.759+0900 D/cluster-home( 2906): widget-data-provider.cpp: OnCustomClusterFocusedPageChanged(2934) >  Cluster[0] page[1] focused
04-01 07:37:36.759+0900 D/LAUNCH  ( 2906): appcore-efl.c: __do_app(636) > [homescreen:Application:resume:done]
04-01 07:37:36.759+0900 D/LAUNCH  ( 2906): appcore-efl.c: __do_app(638) > [homescreen:Application:Launching:done]
04-01 07:37:36.759+0900 D/APP_CORE( 2906): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
04-01 07:37:36.769+0900 E/APP_CORE( 2906): appcore-efl.c: __trm_app_info_send_socket(242) > access
04-01 07:37:36.769+0900 E/EFL     ( 2799): eo<2799> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
04-01 07:37:36.769+0900 I/TIZEN_N_SOUND_MANAGER( 2976): sound_manager.c: sound_manager_get_volume(80) > returns : type=0, volume=9, ret=0x0
04-01 07:37:36.769+0900 E/TIZEN_N_SOUND_MANAGER( 2976): sound_manager_private.c: __convert_sound_manager_error_code(74) > [sound_manager_get_volume(82)] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-01 07:37:36.769+0900 I/TIZEN_N_SOUND_MANAGER( 2976): sound_manager.c: sound_manager_get_volume(80) > returns : type=4, volume=7, ret=0x0
04-01 07:37:36.769+0900 E/TIZEN_N_SOUND_MANAGER( 2976): sound_manager_private.c: __convert_sound_manager_error_code(74) > [sound_manager_get_volume(82)] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-01 07:37:36.769+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(838) > __request_handler: 15
04-01 07:37:36.769+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
04-01 07:37:36.769+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
04-01 07:37:36.769+0900 D/AUL_AMD ( 2763): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 2906 is org.tizen.homescreen
04-01 07:37:36.769+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 2906 : 0
04-01 07:37:36.769+0900 D/AUL     ( 2976): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 29
04-01 07:37:36.779+0900 D/DATA_PROVIDER_MASTER( 2960): xmonitor.c: xmonitor_resume(339) > [SECURE_LOG] 2906 is resumed
04-01 07:37:36.779+0900 D/DATA_PROVIDER_MASTER( 2960): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
04-01 07:37:36.779+0900 E/DATA_PROVIDER_MASTER( 2960): setting.c: setting_is_lcd_off(95) > [SECURE_LOG] State: 1, (3:lcdoff, 4:sleep)
04-01 07:37:36.779+0900 I/CAPI_WIDGET_APPLICATION( 2963): widget_app.c: __provider_resume_cb(312) > widget obj was resumed
04-01 07:37:36.779+0900 I/CAPI_WIDGET_APPLICATION( 2963): widget_app.c: __check_status_for_cgroup(132) > enter foreground group
04-01 07:37:36.779+0900 W/AUL     ( 2963): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2963, appid: org.tizen.calendar.widget, status: fg
04-01 07:37:36.779+0900 D/RESOURCED( 2892): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2963
04-01 07:37:36.779+0900 D/RESOURCED( 2892): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 2963, proc_name: org.tizen.calendar.widget, cg_name: foreground, oom_score_adj: 200
04-01 07:37:36.779+0900 D/RESOURCED( 2892): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 2963
04-01 07:37:36.819+0900 D/RESOURCED( 2892): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2963, appname = org.tizen.calendar.widget
04-01 07:37:36.819+0900 D/RESOURCED( 2892): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2963
04-01 07:37:36.819+0900 I/RESOURCED( 2892): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
04-01 07:37:36.819+0900 I/RESOURCED( 2892): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
04-01 07:37:36.829+0900 W/CRASH_MANAGER(28386): worker.c: worker_job(1204) > 11280156578611490999856
04-01 07:37:36.839+0900 D/AUL_PAD ( 2958): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
04-01 07:37:36.839+0900 D/AUL_PAD ( 2958): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
04-01 07:37:36.839+0900 D/AUL_PAD ( 2958): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
04-01 07:37:36.839+0900 D/AUL_PAD ( 2958): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
04-01 07:37:36.839+0900 D/AUL_PAD ( 2958): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
04-01 07:37:36.839+0900 D/AUL_PAD ( 2958): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
04-01 07:37:36.839+0900 D/AUL_PAD ( 2958): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
04-01 07:37:36.839+0900 I/AUL_PAD ( 2958): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 28015 pgid = 28015
04-01 07:37:36.839+0900 I/AUL_PAD ( 2958): sigchild.h: __sigchild_action(142) > dead_pid(28015)
04-01 07:37:36.849+0900 D/AUL_PAD ( 2958): sigchild.h: __send_app_dead_signal(90) > send dead signal done
04-01 07:37:36.849+0900 I/AUL_PAD ( 2958): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
04-01 07:37:36.849+0900 I/AUL_PAD ( 2958): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
04-01 07:37:36.849+0900 E/AUL_PAD ( 2958): launchpad.c: main(688) > error reading sigchld info
04-01 07:37:36.849+0900 I/ESD     ( 2974): esd_main.c: __esd_app_dead_handler(1771) > pid: 28015
04-01 07:37:36.849+0900 W/AUL_AMD ( 2763): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 28015
04-01 07:37:36.849+0900 D/AUL_AMD ( 2763): amd_key.c: _unregister_key_event(179) > ===key stack===
04-01 07:37:36.849+0900 E/AUL_AMD ( 2763): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
04-01 07:37:36.849+0900 D/AUL_AMD ( 2763): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.example.example)
04-01 07:37:36.849+0900 D/AUL     ( 2763): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
04-01 07:37:36.849+0900 E/AUL     ( 2763): simple_util.c: __trm_app_info_send_socket(330) > access
04-01 07:37:36.849+0900 D/STARTER ( 2890): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 28015 is termianted
04-01 07:37:36.849+0900 D/STARTER ( 2890): starter.c: _check_dead_signal(202) > [_check_dead_signal:202] Unknown process, ignore it
04-01 07:37:36.849+0900 E/RESOURCED( 2892): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2049
04-01 07:37:36.849+0900 D/RESOURCED( 2892): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 28015
04-01 07:37:37.029+0900 D/cluster-view( 2906): custom-cluster-impl.cpp: OnCustomScrollComplete(5141) >  ##################### scroll complete ########################### 
04-01 07:37:37.029+0900 D/cluster-view( 2906): cluster-impl.cpp: OnScrollComplete(639) >  Horizontal Cluster scrollview is stopped normally, pos[0.00, 0.00]
04-01 07:37:37.029+0900 D/cluster-view( 2906): cluster-impl.cpp: OnScrollComplete(653) >  scroll position x : -0.00 (page:0)
04-01 07:37:37.029+0900 D/test-log( 2906): cluster-impl.cpp: SetFocusedPage(791) >  Set mFocusedPage: 1
04-01 07:37:37.029+0900 D/test-log( 2906): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
04-01 07:37:37.029+0900 D/cluster-view( 2906): cluster-view-controller.cpp: OnClusterChangeFocusedPage(1779) >  Cluster[0:] 1 page focused
04-01 07:37:37.029+0900 D/cluster-home( 2906): widget-data-provider.cpp: OnCustomClusterFocusedPageChanged(2934) >  Cluster[0] page[1] focused
04-01 07:37:37.369+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(838) > __request_handler: 0
04-01 07:37:37.369+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
04-01 07:37:37.369+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
04-01 07:37:37.369+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
04-01 07:37:37.369+0900 I/AUL     ( 2763): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
04-01 07:37:37.369+0900 D/AUL     ( 2763): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 28439, pid = 28441
04-01 07:37:37.369+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
04-01 07:37:37.369+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
04-01 07:37:37.369+0900 I/AUL     ( 2763): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
04-01 07:37:37.369+0900 E/AUL_AMD ( 2763): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
04-01 07:37:37.369+0900 W/AUL_AMD ( 2763): amd_launch.c: _start_app(2233) > caller pid : 28441
04-01 07:37:37.369+0900 E/AUL_AMD ( 2763): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
04-01 07:37:37.369+0900 W/AUL_AMD ( 2763): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
04-01 07:37:37.369+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2648) > process_pool: false
04-01 07:37:37.369+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
04-01 07:37:37.369+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
04-01 07:37:37.369+0900 W/AUL_AMD ( 2763): amd_launch.c: _start_app(2665) > pad pid(-5)
04-01 07:37:37.369+0900 D/AUL_AMD ( 2763): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
04-01 07:37:37.369+0900 D/AUL_AMD ( 2763): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
04-01 07:37:37.369+0900 D/AUL     ( 2763): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
04-01 07:37:37.369+0900 D/RESOURCED( 2892): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
04-01 07:37:37.369+0900 D/RESOURCED( 2892): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 100
04-01 07:37:37.369+0900 E/RESOURCED( 2892): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-01 07:37:37.369+0900 D/AUL_PAD ( 2958): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
04-01 07:37:37.379+0900 D/AUL_PAD ( 2958): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
04-01 07:37:37.379+0900 D/AUL_PAD ( 2958): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
04-01 07:37:37.379+0900 D/AUL_PAD ( 2958): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
04-01 07:37:37.379+0900 D/AUL_PAD ( 2958): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
04-01 07:37:37.379+0900 D/AUL_PAD ( 2958): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
04-01 07:37:37.379+0900 D/AUL_PAD ( 2958): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
04-01 07:37:37.379+0900 D/AUL_PAD ( 2958): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
04-01 07:37:37.379+0900 D/AUL_PAD ( 2958): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
04-01 07:37:37.379+0900 D/AUL_PAD ( 2958): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
04-01 07:37:37.379+0900 D/AUL_PAD ( 2958): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
04-01 07:37:37.379+0900 D/AUL_PAD ( 2958): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
04-01 07:37:37.379+0900 D/AUL_PAD ( 2958): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
04-01 07:37:37.379+0900 D/AUL_PAD ( 2958): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
04-01 07:37:37.379+0900 W/AUL_PAD ( 2958): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
04-01 07:37:37.379+0900 D/AUL     ( 2958): process_pool.c: __send_pkt_raw_data(219) > send(13) : 624 / 624
04-01 07:37:37.379+0900 D/AUL_PAD ( 2958): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 28255, bin path: /opt/usr/apps/org.example.example/bin/example
04-01 07:37:37.379+0900 W/AUL_PAD ( 2958): launchpad.c: __send_result_to_caller(265) > Check app launching
04-01 07:37:37.379+0900 D/AUL_PAD ( 2958): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
04-01 07:37:37.379+0900 D/AUL_PAD (28255): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
04-01 07:37:37.379+0900 D/AUL_PAD (28255): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
04-01 07:37:37.379+0900 D/AUL_PAD (28255): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
04-01 07:37:37.379+0900 D/AUL_PAD (28255): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
04-01 07:37:37.379+0900 D/AUL_PAD (28255): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
04-01 07:37:37.379+0900 D/AUL_PAD (28255): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
04-01 07:37:37.379+0900 D/AUL     (28255): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (28257) is sent.
04-01 07:37:37.379+0900 D/AUL     (28255): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 28257, signo: 10
04-01 07:37:37.379+0900 D/AUL     (28255): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
04-01 07:37:37.379+0900 D/AUL_PAD (28255): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
04-01 07:37:37.379+0900 D/AUL_PAD (28255): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
04-01 07:37:37.379+0900 D/AUL_PAD (28255): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
04-01 07:37:37.379+0900 D/AUL_PAD (28255): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
04-01 07:37:37.379+0900 D/AUL_PAD (28255): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTA5OTk4NTcvMzc0NzQ4AA==##
04-01 07:37:37.379+0900 D/AUL_PAD (28255): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
04-01 07:37:37.379+0900 D/AUL_PAD (28255): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAyODQ0MQA=##
04-01 07:37:37.379+0900 D/AUL_PAD (28255): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
04-01 07:37:37.379+0900 D/AUL_PAD (28255): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
04-01 07:37:37.379+0900 D/AUL_PAD (28255): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
04-01 07:37:37.379+0900 D/AUL_PAD (28255): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
04-01 07:37:37.379+0900 D/AUL_PAD (28255): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
04-01 07:37:37.379+0900 I/CAPI_APPFW_APPLICATION(28255): app_main.c: ui_app_main(788) > app_efl_main
04-01 07:37:37.389+0900 D/LAUNCH  (28255): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
04-01 07:37:37.389+0900 D/APP_CORE(28255): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
04-01 07:37:37.389+0900 D/APP_CORE(28255): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
04-01 07:37:37.389+0900 D/APP_CORE(28255): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
04-01 07:37:37.389+0900 D/APP_CORE(28255): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
04-01 07:37:37.389+0900 D/AUL     (28255): app_sock.c: __create_server_sock(156) > pg path - already exists
04-01 07:37:37.389+0900 D/APP_CORE(28255): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb422d520
04-01 07:37:37.389+0900 D/LAUNCH  (28255): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
04-01 07:37:37.389+0900 I/CAPI_APPFW_APPLICATION(28255): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
04-01 07:37:37.429+0900 E/EFL     (28255): eo<28255> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb7fb0598 is not pointing to a valid object. Maybe it has already been freed.
04-01 07:37:37.429+0900 E/EFL     (28255): eo<28255> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0xb7fb0598) is an invalid ref.
04-01 07:37:37.479+0900 D/AUL_PAD ( 2958): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
04-01 07:37:37.479+0900 W/AUL     ( 2763): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 28255, appid: org.example.example
04-01 07:37:37.479+0900 D/AUL     ( 2763): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
04-01 07:37:37.479+0900 E/AUL     ( 2763): simple_util.c: __trm_app_info_send_socket(330) > access
04-01 07:37:37.479+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2700) > add app group info
04-01 07:37:37.479+0900 E/AUL     ( 2763): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
04-01 07:37:37.479+0900 D/AUL_AMD ( 2763): amd_status.c: _status_add_app_info_list(427) > pid(28255) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
04-01 07:37:37.479+0900 D/RESOURCED( 2892): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 28255
04-01 07:37:37.479+0900 D/RESOURCED( 2892): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
04-01 07:37:37.479+0900 D/RESOURCED( 2892): proc-main.c: resourced_proc_status_change(888) > available memory = 274
04-01 07:37:37.569+0900 E/VCONF   (28386): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
04-01 07:37:37.569+0900 E/VCONF   (28386): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
04-01 07:37:37.569+0900 E/VCONF   (28386): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
04-01 07:37:37.569+0900 E/VCONF   (28386): vconf.c: vconf_get_str(2891) > vconf_get_str(28386) : db/menu_widget/language error
04-01 07:37:37.569+0900 E/PKGMGR_INFO(28386): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
04-01 07:37:37.569+0900 D/PKGMGR_INFO(28386): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3502) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
04-01 07:37:37.569+0900 D/PKGMGR_INFO(28386): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3508) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='No Locale' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
04-01 07:37:37.569+0900 E/VCONF   (28386): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
04-01 07:37:37.569+0900 E/VCONF   (28386): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
04-01 07:37:37.569+0900 E/VCONF   (28386): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
04-01 07:37:37.569+0900 E/VCONF   (28386): vconf.c: vconf_get_str(2891) > vconf_get_str(28386) : db/menu_widget/language error
04-01 07:37:37.569+0900 E/PKGMGR_INFO(28386): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
04-01 07:37:37.569+0900 D/PKGMGR_INFO(28386): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
04-01 07:37:37.569+0900 D/PKGMGR_INFO(28386): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
04-01 07:37:37.579+0900 E/VCONF   (28386): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
04-01 07:37:37.579+0900 E/VCONF   (28386): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
04-01 07:37:37.579+0900 E/VCONF   (28386): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
04-01 07:37:37.579+0900 E/VCONF   (28386): vconf.c: vconf_get_str(2891) > vconf_get_str(28386) : db/menu_widget/language error
04-01 07:37:37.579+0900 E/PKGMGR_INFO(28386): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
04-01 07:37:37.579+0900 D/PKGMGR_INFO(28386): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
04-01 07:37:37.579+0900 D/PKGMGR_INFO(28386): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
04-01 07:37:37.579+0900 E/VCONF   (28386): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
04-01 07:37:37.579+0900 E/VCONF   (28386): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
04-01 07:37:37.579+0900 E/VCONF   (28386): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
04-01 07:37:37.579+0900 E/VCONF   (28386): vconf.c: vconf_get_str(2891) > vconf_get_str(28386) : db/menu_widget/language error
04-01 07:37:37.579+0900 E/PKGMGR_INFO(28386): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
04-01 07:37:37.749+0900 D/LAUNCH  (28450): appcore-efl.c: appcore_efl_main(1692) > [crash-popup:Application:main:done]
04-01 07:37:37.749+0900 D/PKGMGR_INFO(28450): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.crash-popup/bin/crash-popup' and package_app_info.app_disable IN ('false','False')
04-01 07:37:37.749+0900 D/PKGMGR_INFO(28450): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.crash-popup/bin/crash-popup' and package_app_info.app_disable IN ('false','False')
04-01 07:37:37.749+0900 D/AUL     (28450): pkginfo.c: aul_app_get_appid_bypid(241) > [SECURE_LOG] appid for 28450 is org.tizen.crash-popup
04-01 07:37:37.869+0900 D/APP_CORE(28450): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
04-01 07:37:37.869+0900 D/APP_CORE(28450): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /usr/apps/org.tizen.crash-popup/res/locale
04-01 07:37:37.869+0900 D/APP_CORE(28450): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
04-01 07:37:37.869+0900 D/APP_CORE(28450): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
04-01 07:37:37.869+0900 D/APP_CORE(28450): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb7738520
04-01 07:37:37.869+0900 D/LAUNCH  (28450): appcore-efl.c: __before_loop(1136) > [crash-popup:Platform:appcore_init:done]
04-01 07:37:37.889+0900 D/APP_CORE(28450): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
04-01 07:37:37.899+0900 D/LAUNCH  (28450): appcore-efl.c: __before_loop(1154) > [crash-popup:Application:create:done]
04-01 07:37:37.899+0900 D/APP_CORE(28450): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
04-01 07:37:37.899+0900 W/E17_EXTRA_MODULES( 2799): e_mod_comp.c: _e_mod_comp_win_add(1727) > [CW Creating Fail!!(Attributes get)] Win:01200002, BD:(nil), POP:(nil), MENU:(nil)
04-01 07:37:38.129+0900 W/CRASH_MANAGER(28386): worker.c: worker_job(1204) > 1128255657861149099985
