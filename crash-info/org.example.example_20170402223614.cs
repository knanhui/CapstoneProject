S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 9768
Date: 2017-04-02 22:36:14+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x4

Register Information
gs  = 0x00000033, fs  = 0xc1640000
es  = 0xffff007b, ds  = 0x0000007b
edi = 0xb79fb3f0, esi = 0x00000000
ebp = 0xbf81f248, esp = 0xbf81f230
eax = 0xb374c000, ebx = 0xb374c000
ecx = 0x00000000, edx = 0x00000000
eip = 0xb3748b12

Memory Information
MemTotal:      123 KB
MemFree:        32 KB
Buffers:         4 KB
Cached:     164976 KB
VmPeak:      99068 KB
VmSize:      99068 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21532 KB
VmRSS:       21532 KB
VmData:      32688 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33320 KB
VmPTE:          76 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 9768 TID = 9768
9768 9769 9948 9949 

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

Callstack Information (PID:9768)
Call Stack Count: 19
 0: set_button_text + 0x22 (0xb3748b12) [/opt/usr/apps/org.example.example/bin/example] + 0x1b12
 1: on_btn2_cb + 0x88 (0xb3749aa8) [/opt/usr/apps/org.example.example/bin/example] + 0x2aa8
 2: (0xb70b2449) [/usr/lib/libevas.so.1] + 0x34449
 3: (0xb633e319) [/usr/lib/libeo.so.1] + 0xe319
 4: eo_event_callback_call + 0xb3 (0xb633bd63) [/usr/lib/libeo.so.1] + 0xbd63
 5: (0xb70b2a62) [/usr/lib/libevas.so.1] + 0x34a62
 6: (0xb70c1e49) [/usr/lib/libevas.so.1] + 0x43e49
 7: evas_canvas_event_feed_mouse_up + 0xcf (0xb70cb0af) [/usr/lib/libevas.so.1] + 0x4d0af
 8: evas_event_feed_mouse_up + 0x6a (0xb70d1b8a) [/usr/lib/libevas.so.1] + 0x53b8a
 9: (0xb434b535) [/usr/lib/libecore_input_evas.so.1] + 0x2535
10: (0xb704e055) [/usr/lib/libecore.so.1] + 0xd055
11: (0xb70571b9) [/usr/lib/libecore.so.1] + 0x161b9
12: ecore_main_loop_begin + 0x57 (0xb7057587) [/usr/lib/libecore.so.1] + 0x16587
13: elm_run + 0x2d (0xb74b022d) [/usr/lib/libelementary.so.1] + 0x1c822d
14: appcore_efl_main + 0x4de (0xb76d4dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
15: ui_app_main + 0x140 (0xb76cdc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
16: main + 0x27e (0xb3748dfe) [/opt/usr/apps/org.example.example/bin/example] + 0x1dfe
17: create_base_gui + 0x128 (0xb7709148) [/opt/usr/apps/org.example.example/bin/example] + 0xb7709148
18: __libc_start_main + 0xde (0xb6bf6e4e) [/lib/libc.so.6] + 0x17e4e
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
9892): rpm-installer.c: _ri_apply_privilege(1924) > api-version[2.4] fot privilege has done successfully.
04-02 22:36:09.989+0900 D/rpm-installer( 9892): rpm-installer-privilege.c: _ri_privilege_enable_permissions(106) > [smack] app_enable_permissions(org.example.example, 7), result=[0]
04-02 22:36:09.989+0900 D/rpm-installer( 9892): coretpk-installer.c: _coretpk_installer_package_reinstall(5083) > #permission applying success.
04-02 22:36:09.989+0900 D/PKGMGR  ( 9892): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(9892), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
04-02 22:36:09.989+0900 D/PKGMGR  ( 9892): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(9892), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
04-02 22:36:09.989+0900 D/PKGMGR  ( 9892): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
04-02 22:36:09.989+0900 D/PKGMGR_INSTALLER( 9892): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.example] key[install_percent] value[100]
04-02 22:36:09.989+0900 D/PKGMGR  ( 9892): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(9892), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
04-02 22:36:09.989+0900 D/PKGMGR  ( 9892): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(9892), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
04-02 22:36:09.989+0900 D/PKGMGR  ( 9892): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.install.progress), signal_name(install_progress)
04-02 22:36:09.989+0900 D/rpm-installer( 9892): coretpk-installer.c: _coretpk_installer_package_reinstall(5096) > _coretpk_installer_package_reinstall(org.example.example) is done.
04-02 22:36:09.989+0900 D/PKGMGR  ( 9892): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(9892), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
04-02 22:36:09.989+0900 D/PKGMGR  ( 9892): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(9892), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
04-02 22:36:09.989+0900 D/PKGMGR  ( 9892): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
04-02 22:36:09.989+0900 D/PKGMGR_INSTALLER( 9892): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.example] key[end] value[ok]
04-02 22:36:09.989+0900 D/PKGMGR  ( 3029): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_539128465], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-02 22:36:09.989+0900 D/PKGMGR  ( 2870): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_539128465], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-02 22:36:09.989+0900 W/cluster-home( 2870): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.example]
04-02 22:36:09.989+0900 D/PKGMGR  ( 2870): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_539128465], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-02 22:36:09.989+0900 D/cluster-home( 2870): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[28700003] pkg_type[tpk] package[org.example.example] key[install_percent] val[100] pmsg[(null)]
04-02 22:36:09.989+0900 D/PKGMGR  ( 2951): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_539128465], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-02 22:36:09.989+0900 D/PKGMGR  ( 2951): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
04-02 22:36:09.989+0900 D/PKGMGR  ( 2944): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_539128465], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-02 22:36:09.989+0900 D/PKGMGR  ( 9892): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(9892), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
04-02 22:36:09.989+0900 D/PKGMGR  ( 9892): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(9892), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
04-02 22:36:09.989+0900 D/PKGMGR  ( 9892): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.upgrade), signal_name(upgrade)
04-02 22:36:09.989+0900 D/PKGMGR  ( 3029): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_539128465], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 22:36:09.989+0900 D/ISF_PANEL_EFL( 3029): isf_panel_efl.cpp: _package_manager_event_cb(1288) > type=tpk package=org.example.example event_type=UPDATE event_state=COMPLETED progress=100 error=0
04-02 22:36:09.989+0900 D/PKGMGR  ( 2922): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_539128465], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-02 22:36:09.989+0900 D/DATA_PROVIDER_MASTER( 2922): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.example] 100
04-02 22:36:09.989+0900 D/PKGMGR  ( 2942): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_539128465], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-02 22:36:09.989+0900 D/ESD     ( 2942): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29420002), pkg_type(tpk), pkgid(org.example.example), key(install_percent), val(100)
04-02 22:36:09.989+0900 D/PKGMGR  ( 3091): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_539128465], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-02 22:36:09.989+0900 D/PKGMGR  ( 3091): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_539128465], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 22:36:09.999+0900 D/PKGMGR  ( 9890): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_539128465], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-02 22:36:09.999+0900 D/PKGMGR  ( 2769): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[upgrade], req_id=[org.example.example_539128465], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 22:36:09.999+0900 D/AUL_AMD ( 2769): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.example), key(end), value(ok)
04-02 22:36:09.999+0900 W/AUL_AMD ( 2769): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(update), value(ok)
04-02 22:36:09.999+0900 D/PKGMGR  ( 2870): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_539128465], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 22:36:09.999+0900 D/PKGMGR  ( 9890): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_539128465], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 22:36:09.999+0900 W/cluster-home( 2870): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[2], package[org.example.example]
04-02 22:36:09.999+0900 D/cluster-home( 2870): widget-data-provider.cpp: PackageUpdated(2160) >  No boxes that pkgname is[org.example.example]
04-02 22:36:09.999+0900 D/PKGMGR  ( 2870): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_539128465], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 22:36:09.999+0900 D/cluster-home( 2870): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[28700003] pkg_type[tpk] package[org.example.example] key[end] val[ok] pmsg[(null)]
04-02 22:36:09.999+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
04-02 22:36:09.999+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
04-02 22:36:09.999+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
04-02 22:36:09.999+0900 W/ISF_PANEL_EFL( 3029): isf_panel_efl.cpp: _package_manager_event_cb(1380) > isf_db_select_appids_by_pkgid returned 0.
04-02 22:36:09.999+0900 D/AUL_AMD ( 2769): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.example, type:rpm
04-02 22:36:09.999+0900 D/cluster-home( 2870): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
04-02 22:36:09.999+0900 D/cluster-home( 2870): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.example]
04-02 22:36:09.999+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.example]
04-02 22:36:09.999+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.example]
04-02 22:36:09.999+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
04-02 22:36:09.999+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
04-02 22:36:09.999+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.example]
04-02 22:36:09.999+0900 D/PKGMGR  ( 2922): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_539128465], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 22:36:09.999+0900 D/DATA_PROVIDER_MASTER( 2922): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.example] ok
04-02 22:36:09.999+0900 D/DATA_PROVIDER_MASTER( 2922): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.example], event_type[1]
04-02 22:36:09.999+0900 D/DATA_PROVIDER_MASTER( 2922): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
04-02 22:36:09.999+0900 D/PKGMGR  ( 2942): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_539128465], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 22:36:09.999+0900 D/ESD     ( 2942): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29420002), pkg_type(tpk), pkgid(org.example.example), key(end), val(ok)
04-02 22:36:09.999+0900 D/ESD     ( 2942): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
04-02 22:36:09.999+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.example] Name[example] Icon[/opt/usr/apps/org.example.example/shared/res/example.png] enable[1] system[0]
04-02 22:36:09.999+0900 D/DATA_PROVIDER_MASTER( 2922): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
04-02 22:36:09.999+0900 D/DATA_PROVIDER_MASTER( 2922): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
04-02 22:36:09.999+0900 D/DATA_PROVIDER_MASTER( 2922): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.example]
04-02 22:36:09.999+0900 D/PKGMGR  ( 2944): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_539128465], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 22:36:09.999+0900 D/PKGMGR  ( 2951): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_539128465], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 22:36:09.999+0900 D/PKGMGR  ( 2951): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
04-02 22:36:09.999+0900 D/cluster-home( 2870): mainmenu-presenter.cpp: OnAppUpdated(337) >  pAppId [org.example.example]
04-02 22:36:09.999+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.example
04-02 22:36:09.999+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[13], isFolder[0], pageId[1], col[1], row[4], appId[org.example.example], name[example], menuId[1], isPreload[0] isPreload[0]
04-02 22:36:09.999+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
04-02 22:36:09.999+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.example] Name[example] Icon[/opt/usr/apps/org.example.example/shared/res/example.png] enable[1] system[0]
04-02 22:36:09.999+0900 D/cluster-home( 2870): mainmenu-presenter.cpp: OnAppUpdated(364) >  name [example]
04-02 22:36:09.999+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
04-02 22:36:09.999+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
04-02 22:36:09.999+0900 D/test-log( 2870): mainmenu-box-impl.cpp: UpdateBoxData(812) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.example/shared/res/example.png], New icon path[/opt/usr/apps/org.example.example/shared/res/example.png]!!!!!
04-02 22:36:10.009+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 1, appId = $appId, name = $name, col = 1, row = 4, isPreload = 0, isSystem = 0 WHERE boxId = 13]
04-02 22:36:10.009+0900 D/PKGMGR  ( 2940): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_539128465], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-02 22:36:10.009+0900 D/QUICKPANEL( 2940): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:install_percent val:100
04-02 22:36:10.009+0900 D/PKGMGR  ( 2940): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_539128465], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 22:36:10.009+0900 D/QUICKPANEL( 2940): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:end val:ok
04-02 22:36:10.119+0900 D/rpm-installer( 9892): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
04-02 22:36:10.119+0900 D/rpm-installer( 9892): rpm-appcore-intf.c: main(259) > ------------------------------------------------
04-02 22:36:10.119+0900 D/rpm-installer( 9892): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
04-02 22:36:10.119+0900 D/rpm-installer( 9892): rpm-appcore-intf.c: main(261) > ------------------------------------------------
04-02 22:36:10.129+0900 D/PKGMGR_SERVER( 9803): pkgmgr-server.c: sighandler(387) > child exit [9892]
04-02 22:36:10.129+0900 E/PKGMGR_SERVER( 9803): pkgmgr-server.c: sighandler(402) > child NORMAL exit [9892]
04-02 22:36:10.319+0900 D/AUL_AMD ( 2769): amd_request.c: __request_handler(838) > __request_handler: 0
04-02 22:36:10.339+0900 D/AUL_AMD ( 2769): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
04-02 22:36:10.339+0900 D/PKGMGR_INFO( 2769): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
04-02 22:36:10.339+0900 D/PKGMGR_INFO( 2769): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
04-02 22:36:10.339+0900 I/AUL     ( 2769): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
04-02 22:36:10.339+0900 D/AUL     ( 2769): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 9942, pid = 9944
04-02 22:36:10.339+0900 D/PKGMGR_INFO( 2769): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
04-02 22:36:10.339+0900 D/PKGMGR_INFO( 2769): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
04-02 22:36:10.339+0900 I/AUL     ( 2769): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
04-02 22:36:10.339+0900 E/AUL_AMD ( 2769): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
04-02 22:36:10.339+0900 W/AUL_AMD ( 2769): amd_launch.c: _start_app(2233) > caller pid : 9944
04-02 22:36:10.339+0900 E/AUL_AMD ( 2769): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
04-02 22:36:10.349+0900 W/AUL_AMD ( 2769): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
04-02 22:36:10.349+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2648) > process_pool: false
04-02 22:36:10.349+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
04-02 22:36:10.349+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
04-02 22:36:10.349+0900 W/AUL_AMD ( 2769): amd_launch.c: _start_app(2665) > pad pid(-5)
04-02 22:36:10.349+0900 D/AUL_AMD ( 2769): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
04-02 22:36:10.349+0900 D/AUL_AMD ( 2769): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
04-02 22:36:10.349+0900 D/AUL     ( 2769): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
04-02 22:36:10.349+0900 D/AUL_PAD ( 2920): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
04-02 22:36:10.349+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
04-02 22:36:10.349+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
04-02 22:36:10.349+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
04-02 22:36:10.349+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
04-02 22:36:10.349+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
04-02 22:36:10.349+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
04-02 22:36:10.349+0900 D/AUL_PAD ( 2920): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
04-02 22:36:10.349+0900 D/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
04-02 22:36:10.349+0900 D/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
04-02 22:36:10.349+0900 D/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
04-02 22:36:10.349+0900 D/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
04-02 22:36:10.349+0900 D/AUL_PAD ( 2920): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
04-02 22:36:10.349+0900 D/AUL_PAD ( 2920): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
04-02 22:36:10.349+0900 W/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
04-02 22:36:10.349+0900 D/AUL     ( 2920): process_pool.c: __send_pkt_raw_data(219) > send(13) : 620 / 620
04-02 22:36:10.349+0900 D/AUL_PAD ( 2920): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 9768, bin path: /opt/usr/apps/org.example.example/bin/example
04-02 22:36:10.349+0900 W/AUL_PAD ( 2920): launchpad.c: __send_result_to_caller(265) > Check app launching
04-02 22:36:10.349+0900 D/AUL_PAD ( 2920): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
04-02 22:36:10.349+0900 D/RESOURCED( 2852): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
04-02 22:36:10.349+0900 D/RESOURCED( 2852): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
04-02 22:36:10.349+0900 D/AUL_PAD ( 9768): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
04-02 22:36:10.349+0900 D/AUL_PAD ( 9768): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
04-02 22:36:10.349+0900 E/RESOURCED( 2852): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-02 22:36:10.349+0900 D/AUL_PAD ( 9768): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
04-02 22:36:10.349+0900 D/AUL_PAD ( 9768): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
04-02 22:36:10.349+0900 D/AUL_PAD ( 9768): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
04-02 22:36:10.349+0900 D/AUL_PAD ( 9768): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
04-02 22:36:10.349+0900 D/AUL     ( 9768): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (9769) is sent.
04-02 22:36:10.349+0900 D/AUL     ( 9768): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 9769, signo: 10
04-02 22:36:10.349+0900 D/AUL     ( 9768): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
04-02 22:36:10.349+0900 D/AUL_PAD ( 9768): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
04-02 22:36:10.349+0900 D/AUL_PAD ( 9768): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
04-02 22:36:10.349+0900 D/AUL_PAD ( 9768): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
04-02 22:36:10.349+0900 D/AUL_PAD ( 9768): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
04-02 22:36:10.349+0900 D/AUL_PAD ( 9768): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTExNDAxNzAvMzM4NTA2AA==##
04-02 22:36:10.349+0900 D/AUL_PAD ( 9768): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
04-02 22:36:10.349+0900 D/AUL_PAD ( 9768): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA5OTQ0AA==##
04-02 22:36:10.349+0900 D/AUL_PAD ( 9768): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
04-02 22:36:10.349+0900 D/AUL_PAD ( 9768): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
04-02 22:36:10.349+0900 D/AUL_PAD ( 9768): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
04-02 22:36:10.349+0900 D/AUL_PAD ( 9768): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
04-02 22:36:10.349+0900 D/AUL_PAD ( 9768): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
04-02 22:36:10.349+0900 I/CAPI_APPFW_APPLICATION( 9768): app_main.c: ui_app_main(788) > app_efl_main
04-02 22:36:10.349+0900 D/LAUNCH  ( 9768): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
04-02 22:36:10.349+0900 D/APP_CORE( 9768): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
04-02 22:36:10.349+0900 D/APP_CORE( 9768): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
04-02 22:36:10.349+0900 D/APP_CORE( 9768): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
04-02 22:36:10.349+0900 D/APP_CORE( 9768): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
04-02 22:36:10.349+0900 D/AUL     ( 9768): app_sock.c: __create_server_sock(156) > pg path - already exists
04-02 22:36:10.349+0900 D/APP_CORE( 9768): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb422d520
04-02 22:36:10.349+0900 D/LAUNCH  ( 9768): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
04-02 22:36:10.349+0900 I/CAPI_APPFW_APPLICATION( 9768): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
04-02 22:36:10.449+0900 D/AUL_PAD ( 2920): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
04-02 22:36:10.449+0900 W/AUL     ( 2769): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 9768, appid: org.example.example
04-02 22:36:10.449+0900 D/AUL     ( 2769): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
04-02 22:36:10.449+0900 E/AUL     ( 2769): simple_util.c: __trm_app_info_send_socket(330) > access
04-02 22:36:10.449+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2700) > add app group info
04-02 22:36:10.449+0900 E/AUL     ( 2769): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
04-02 22:36:10.449+0900 D/AUL_AMD ( 2769): amd_status.c: _status_add_app_info_list(427) > pid(9768) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
04-02 22:36:10.459+0900 D/RESOURCED( 2852): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 9768
04-02 22:36:10.459+0900 D/RESOURCED( 2852): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
04-02 22:36:10.459+0900 E/RESOURCED( 2852): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
04-02 22:36:10.459+0900 D/RESOURCED( 2852): proc-main.c: resourced_proc_status_change(888) > available memory = 316
04-02 22:36:10.469+0900 D/LAUNCH  ( 9768): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
04-02 22:36:10.469+0900 D/APP_CORE( 9768): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
04-02 22:36:10.479+0900 E/E17     ( 2697): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x01200002)
04-02 22:36:10.519+0900 E/E17     ( 2697): e_border.c: e_border_show(2088) > BD_SHOW(0x01200002)
04-02 22:36:10.519+0900 D/APP_CORE( 9768): appcore.c: __aul_handler(587) > [APP 9768]     AUL event: AUL_START
04-02 22:36:10.519+0900 I/APP_CORE( 9768): appcore-efl.c: __do_app(496) > [APP 9768] Event: RESET State: CREATED
04-02 22:36:10.519+0900 D/APP_CORE( 9768): appcore-efl.c: __do_app(527) > [APP 9768] RESET
04-02 22:36:10.519+0900 D/LAUNCH  ( 9768): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
04-02 22:36:10.519+0900 D/APP_CORE( 9768): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
04-02 22:36:10.519+0900 D/APP_CORE( 9768): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
04-02 22:36:10.519+0900 I/CAPI_APPFW_APPLICATION( 9768): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
04-02 22:36:10.519+0900 D/AUL     ( 9768): service.c: __set_bundle(186) > __set_bundle
04-02 22:36:10.519+0900 D/LAUNCH  ( 9768): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
04-02 22:36:10.519+0900 D/APP_CORE( 9768): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
04-02 22:36:10.519+0900 E/EFL     ( 9768): edje<9768> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
04-02 22:36:10.519+0900 E/EFL     ( 9768): By the power of Grayskull, your previous Embryo stack is now broken!
04-02 22:36:10.519+0900 E/EFL     ( 9768): edje<9768> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
04-02 22:36:10.519+0900 E/EFL     ( 9768): By the power of Grayskull, your previous Embryo stack is now broken!
04-02 22:36:10.519+0900 E/EFL     ( 9768): edje<9768> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
04-02 22:36:10.519+0900 E/EFL     ( 9768): By the power of Grayskull, your previous Embryo stack is now broken!
04-02 22:36:10.519+0900 E/EFL     ( 9768): edje<9768> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
04-02 22:36:10.519+0900 E/EFL     ( 9768): By the power of Grayskull, your previous Embryo stack is now broken!
04-02 22:36:10.529+0900 E/EFL     ( 9768): edje<9768> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
04-02 22:36:10.529+0900 E/EFL     ( 9768): By the power of Grayskull, your previous Embryo stack is now broken!
04-02 22:36:10.539+0900 W/APP_CORE( 9768): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1200002
04-02 22:36:10.539+0900 D/APP_CORE( 9768): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:1200002
04-02 22:36:10.539+0900 D/APP_CORE( 9768): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
04-02 22:36:10.539+0900 D/AUL     ( 9768): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
04-02 22:36:10.539+0900 D/AUL_AMD ( 2769): amd_request.c: __request_handler(838) > __request_handler: 34
04-02 22:36:10.559+0900 W/PROCESSMGR( 2697): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=9768
04-02 22:36:10.579+0900 E/EFL     ( 2697): eo<2697> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
04-02 22:36:10.579+0900 E/EFL     ( 2697): eo<2697> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
04-02 22:36:10.579+0900 D/AUL_AMD ( 2769): amd_request.c: __request_handler(838) > __request_handler: 15
04-02 22:36:10.579+0900 D/PKGMGR_INFO( 2769): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
04-02 22:36:10.579+0900 D/PKGMGR_INFO( 2769): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
04-02 22:36:10.589+0900 D/AUL_AMD ( 2769): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 9768 is org.example.example
04-02 22:36:10.589+0900 D/AUL_AMD ( 2769): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 9768 : 0
04-02 22:36:10.589+0900 D/AUL     ( 2944): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
04-02 22:36:10.609+0900 D/INDICATOR( 2855): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
04-02 22:36:10.609+0900 D/INDICATOR( 2855): util.c: util_signal_emit_by_win(116) > emission bg.opaque
04-02 22:36:10.609+0900 D/INDICATOR( 2855): main.c: _rotate_window(229) > Indicator angle is 0 degree
04-02 22:36:10.609+0900 D/INDICATOR( 2855): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
04-02 22:36:10.609+0900 D/INDICATOR( 2855): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
04-02 22:36:10.609+0900 D/INDICATOR( 2855): main.c: _rotate_window(252) > port :: hide more icon
04-02 22:36:10.739+0900 D/APP_CORE( 9768): appcore.c: __prt_ltime(236) > [APP 9768] first idle after reset: 416 msec
04-02 22:36:10.809+0900 E/E17     ( 2697): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
04-02 22:36:10.809+0900 D/APP_CORE( 2870): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
04-02 22:36:10.809+0900 D/APP_CORE( 2870): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
04-02 22:36:10.809+0900 D/APP_CORE( 2870): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
04-02 22:36:10.809+0900 I/APP_CORE( 2870): appcore-efl.c: __do_app(496) > [APP 2870] Event: PAUSE State: RUNNING
04-02 22:36:10.809+0900 D/APP_CORE( 2870): appcore-efl.c: __do_app(565) > [APP 2870] PAUSE
04-02 22:36:10.809+0900 I/CAPI_APPFW_APPLICATION( 2870): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
04-02 22:36:10.809+0900 E/cluster-home( 2870): homescreen.cpp: OnPause(84) >  app pause
04-02 22:36:10.809+0900 D/cluster-view( 2870): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
04-02 22:36:10.809+0900 D/cluster-view( 2870): homescreen-view-manager.cpp: AppPause(923) >  END
04-02 22:36:10.809+0900 D/APP_CORE( 2870): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
04-02 22:36:10.809+0900 E/APP_CORE( 2870): appcore-efl.c: __trm_app_info_send_socket(242) > access
04-02 22:36:10.809+0900 D/AUL_AMD ( 2769): amd_status.c: _status_update_app_info_list(456) > pid(2870) status(4)
04-02 22:36:10.809+0900 D/AUL_AMD ( 2769): amd_status.c: _status_update_app_info_list(468) > pid(2870) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
04-02 22:36:10.809+0900 D/AUL     ( 2769): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
04-02 22:36:10.809+0900 W/AUL     ( 2769): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2870, appid: org.tizen.homescreen, status: bg
04-02 22:36:10.809+0900 D/AUL_AMD ( 2769): amd_launch.c: __e17_status_handler(2891) > pid(9768) status(3)
04-02 22:36:10.809+0900 D/AUL_AMD ( 2769): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
04-02 22:36:10.809+0900 W/AUL_AMD ( 2769): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-02 22:36:10.809+0900 W/AUL_AMD ( 2769): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
04-02 22:36:10.809+0900 D/AUL_AMD ( 2769): amd_status.c: _status_update_app_info_list(456) > pid(9768) status(3)
04-02 22:36:10.809+0900 D/AUL_AMD ( 2769): amd_status.c: _status_update_app_info_list(468) > pid(9768) appid(org.example.example) pkgid(org.example.example) status(3)
04-02 22:36:10.809+0900 D/AUL     ( 2769): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
04-02 22:36:10.809+0900 W/AUL     ( 2769): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 9768, appid: org.example.example, status: fg
04-02 22:36:10.809+0900 D/RESOURCED( 2852): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 9768
04-02 22:36:10.809+0900 D/RESOURCED( 2852): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 9768, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
04-02 22:36:10.809+0900 D/RESOURCED( 2852): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 9768
04-02 22:36:10.809+0900 D/DATA_PROVIDER_MASTER( 2922): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2870 is paused
04-02 22:36:10.809+0900 D/DATA_PROVIDER_MASTER( 2922): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
04-02 22:36:10.809+0900 I/CAPI_WIDGET_APPLICATION( 2999): widget_app.c: __provider_pause_cb(294) > widget obj was paused
04-02 22:36:10.809+0900 I/CAPI_WIDGET_APPLICATION( 2999): widget_app.c: __check_status_for_cgroup(142) > enter background group
04-02 22:36:10.809+0900 W/AUL     ( 2999): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2999, appid: org.tizen.calendar.widget, status: bg
04-02 22:36:10.859+0900 D/APP_CORE( 9768): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1200002 fully_obscured 0
04-02 22:36:10.859+0900 D/APP_CORE( 9768): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
04-02 22:36:10.859+0900 D/APP_CORE( 9768): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
04-02 22:36:10.859+0900 I/APP_CORE( 9768): appcore-efl.c: __do_app(496) > [APP 9768] Event: RESUME State: CREATED
04-02 22:36:10.859+0900 D/LAUNCH  ( 9768): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
04-02 22:36:10.859+0900 D/APP_CORE( 9768): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
04-02 22:36:10.859+0900 D/APP_CORE( 9768): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
04-02 22:36:10.859+0900 D/APP_CORE( 9768): appcore-efl.c: __do_app(607) > [APP 9768] RESUME
04-02 22:36:10.859+0900 I/APP_CORE( 9768): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
04-02 22:36:10.859+0900 I/APP_CORE( 9768): appcore-efl.c: __do_app(614) > [APP 9768] Initial Launching, call the resume_cb
04-02 22:36:10.859+0900 I/CAPI_APPFW_APPLICATION( 9768): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
04-02 22:36:10.859+0900 D/LAUNCH  ( 9768): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
04-02 22:36:10.859+0900 D/LAUNCH  ( 9768): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
04-02 22:36:10.859+0900 D/APP_CORE( 9768): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
04-02 22:36:10.859+0900 E/APP_CORE( 9768): appcore-efl.c: __trm_app_info_send_socket(242) > access
04-02 22:36:10.909+0900 D/RESOURCED( 2852): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 9768, appname = org.example.example, pkgname = org.example.example
04-02 22:36:10.909+0900 D/RESOURCED( 2852): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 9768, appname = org.example.example
04-02 22:36:10.909+0900 D/RESOURCED( 2852): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 9768
04-02 22:36:10.919+0900 D/RESOURCED( 2852): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 2999, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
04-02 22:36:10.919+0900 D/RESOURCED( 2852): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 2999
04-02 22:36:10.919+0900 D/RESOURCED( 2852): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 2999, appname = org.tizen.calendar.widget
04-02 22:36:10.919+0900 D/RESOURCED( 2852): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 2999
04-02 22:36:10.919+0900 I/RESOURCED( 2852): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
04-02 22:36:10.919+0900 I/RESOURCED( 2852): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
04-02 22:36:10.929+0900 D/AUL_AMD ( 2769): amd_launch.c: __e17_status_handler(2910) > pid(9768) status(0)
04-02 22:36:11.009+0900 E/PKGMGR_SERVER( 9803): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-02 22:36:11.009+0900 E/PKGMGR_SERVER( 9803): pkgmgr-server.c: main(2265) > package manager server terminated.
04-02 22:36:11.459+0900 D/AUL_PAD ( 2920): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
04-02 22:36:11.459+0900 D/AUL_PAD ( 9952): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
04-02 22:36:11.469+0900 D/AUL_PAD ( 2920): sigchild.h: __send_app_launch_signal(131) > send launch signal done
04-02 22:36:11.479+0900 E/RESOURCED( 2852): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.667
04-02 22:36:11.959+0900 D/AUL_AMD ( 2769): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
04-02 22:36:11.959+0900 D/RUA     ( 2769): rua.c: rua_add_history(179) > rua_add_history start
04-02 22:36:11.979+0900 D/RUA     ( 2769): rua.c: rua_add_history(247) > rua_add_history ok
04-02 22:36:12.519+0900 D/AUL_PAD ( 9952): launchpad_loader.c: main(588) > sleeping 1 sec...
04-02 22:36:12.519+0900 D/AUL_PAD ( 9952): preload.h: __preload_init(52) > max_cmdline_size = 1053
04-02 22:36:12.519+0900 D/AUL_PAD ( 9952): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b9261760
04-02 22:36:12.529+0900 D/AUL_PAD ( 9952): preload.h: __preload_init(69) > get pre-initialization function
04-02 22:36:12.529+0900 D/AUL_PAD ( 9952): preload.h: __preload_init(73) > get shutdown function
04-02 22:36:12.529+0900 D/AUL_PAD ( 9952): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b9261a40
04-02 22:36:12.539+0900 D/AUL_PAD ( 9952): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b9263640
04-02 22:36:12.539+0900 D/AUL_PAD ( 9952): preload.h: __preload_init(69) > get pre-initialization function
04-02 22:36:12.539+0900 D/AUL_PAD ( 9952): preload.h: __preload_init(73) > get shutdown function
04-02 22:36:12.539+0900 D/AUL_PAD ( 9952): preexec.h: __preexec_init(76) > preexec start
04-02 22:36:12.539+0900 D/AUL_PAD ( 9952): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
04-02 22:36:12.539+0900 D/AUL     ( 9952): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
04-02 22:36:12.539+0900 D/AUL     ( 9952): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
04-02 22:36:12.539+0900 D/AUL     ( 9952): process_pool.c: __connect_to_launchpad(132) > send(9952) : 4
04-02 22:36:12.539+0900 D/AUL     ( 9952): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
04-02 22:36:12.539+0900 D/AUL_PAD ( 2920): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
04-02 22:36:12.539+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
04-02 22:36:12.539+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
04-02 22:36:12.539+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
04-02 22:36:12.539+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
04-02 22:36:12.539+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
04-02 22:36:12.539+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
04-02 22:36:12.539+0900 D/AUL_PAD ( 2920): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
04-02 22:36:12.539+0900 D/AUL_PAD ( 2920): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 9952
04-02 22:36:12.609+0900 D/AUL_PAD ( 9952): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
04-02 22:36:12.609+0900 D/AUL_PAD ( 9952): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
04-02 22:36:12.609+0900 D/AUL_PAD ( 9952): launchpad_loader.c: main(693) > [candidate] ecore handler add
04-02 22:36:12.619+0900 D/AUL_PAD ( 9952): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
04-02 22:36:13.159+0900 E/CAPI_NETWORK_WIFI( 2855): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
04-02 22:36:13.159+0900 E/INDICATOR( 2855): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
04-02 22:36:13.159+0900 E/INDICATOR( 2855): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
04-02 22:36:13.159+0900 E/INDICATOR( 2855): 
04-02 22:36:14.259+0900 D/AUL_AMD ( 2769): amd_status.c: __app_terminate_timer_cb(442) > pid(9584)
04-02 22:36:14.259+0900 W/AUL_AMD ( 2769): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
04-02 22:36:14.259+0900 D/AUL_AMD ( 2769): amd_status.c: __app_terminate_timer_cb(442) > pid(9584)
04-02 22:36:14.259+0900 W/AUL_AMD ( 2769): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
04-02 22:36:14.479+0900 D/PROCESSMGR( 2697): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x200e33 
04-02 22:36:14.479+0900 E/tag     ( 9768): on_btn2_cb-1
04-02 22:36:14.499+0900 E/EFL     ( 2697): eo<2697> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
04-02 22:36:14.499+0900 D/AUL_PAD ( 2920): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
04-02 22:36:14.499+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
04-02 22:36:14.499+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
04-02 22:36:14.499+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
04-02 22:36:14.499+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
04-02 22:36:14.499+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
04-02 22:36:14.499+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
04-02 22:36:14.499+0900 I/AUL_PAD ( 2920): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 9768 pgid = 9768
04-02 22:36:14.499+0900 I/AUL_PAD ( 2920): sigchild.h: __sigchild_action(142) > dead_pid(9768)
04-02 22:36:14.509+0900 W/CRASH_MANAGER( 9954): worker.c: worker_job(1204) > 1109768657861149114017
