S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 5956
Date: 2017-06-01 00:16:04+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x1c

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x0000001c, esi = 0xb383ac61
ebp = 0xbfd34588, esp = 0xbfd34520
eax = 0xb9062ad8, ebx = 0xb6c300d4
ecx = 0xb9062ad8, edx = 0x0000001c
eip = 0xb6c0e1f6

Memory Information
MemTotal:      123 KB
MemFree:        27 KB
Buffers:         4 KB
Cached:     171208 KB
VmPeak:     100432 KB
VmSize:     100432 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22176 KB
VmRSS:       22176 KB
VmData:      32880 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34460 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 5956 TID = 5956
5956 5957 6157 6158 

Maps Information
b2bfa000 b2c04000 r-xp /usr/lib/libfeedback.so.0.1.4
b2c0a000 b2c16000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2c17000 b2c38000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2c3d000 b2c3e000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2c3f000 b2c44000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2c45000 b2c46000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2c47000 b2c49000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c4a000 b2c56000 r-xp /usr/lib/libdrm.so.2.4.0
b2c57000 b2c5a000 r-xp /usr/lib/libdri2.so.0.0.0
b2c5b000 b2c65000 r-xp /usr/lib/libtbm.so.1.0.0
b2c66000 b2c7b000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c7c000 b2c8e000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3490000 b34c1000 r-xp /usr/lib/libidn.so.11.5.44
b34c2000 b34e4000 r-xp /usr/lib/libnghttp2.so.5.4.0
b34e5000 b34f5000 r-xp /usr/lib/libcares.so.2.1.0
b34f6000 b34ff000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3500000 b3509000 r-xp /usr/lib/libefl-extension.so.0.1.0
b350a000 b3581000 r-xp /usr/lib/libcurl.so.4.3.0
b3583000 b3595000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3596000 b35b7000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b35be000 b35bf000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b35c0000 b35c1000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b35c2000 b35c5000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b35c6000 b35c9000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b36d1000 b36d7000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b36d8000 b381c000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b382c000 b382e000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b382f000 b3830000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b3831000 b383c000 r-xp /opt/usr/apps/org.example.example/bin/example
b383e000 b3877000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b427a000 b4285000 r-xp /lib/libnss_files-2.20-2014.11.so
b4287000 b4292000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4294000 b42ab000 r-xp /lib/libnsl-2.20-2014.11.so
b42af000 b42b7000 r-xp /lib/libnss_compat-2.20-2014.11.so
b42b9000 b42dd000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b42de000 b42df000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b42e0000 b42e3000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42e4000 b42eb000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42ec000 b42f6000 r-xp /usr/lib/libsensord-share.so
b42f7000 b4313000 r-xp /usr/lib/libsensor.so.1.2.0
b4315000 b431e000 r-xp /usr/lib/libappcore-common.so.1.1
b4321000 b4323000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4338000 b433a000 r-xp /usr/lib/libXau.so.6.0.0
b433b000 b435d000 r-xp /usr/lib/libxcb.so.1.1.0
b435f000 b4368000 r-xp /lib/libcrypt-2.20-2014.11.so
b4391000 b4393000 r-xp /usr/lib/libiri.so
b4394000 b43ba000 r-xp /lib/libexpat.so.1.5.2
b43bc000 b4427000 r-xp /usr/lib/libssl.so.1.0.0
b442d000 b4439000 r-xp /usr/lib/libethumb.so.1.13.0
b443a000 b443e000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b443f000 b4690000 r-xp /usr/lib/libcrypto.so.1.0.0
b5c0b000 b5c1b000 r-xp /usr/lib/libXi.so.6.1.0
b5c1c000 b5c1e000 r-xp /usr/lib/libXgesture.so.7.0.0
b5c1f000 b5c25000 r-xp /usr/lib/libXtst.so.6.1.0
b5c26000 b5c30000 r-xp /usr/lib/libXrender.so.1.3.0
b5c31000 b5c3a000 r-xp /usr/lib/libXrandr.so.2.2.0
b5c3c000 b5c3e000 r-xp /usr/lib/libXinerama.so.1.0.0
b5c3f000 b5c44000 r-xp /usr/lib/libXfixes.so.3.1.0
b5c45000 b5c57000 r-xp /usr/lib/libXext.so.6.4.0
b5c58000 b5c5a000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c5b000 b5c5d000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c5f000 b5da1000 r-xp /usr/lib/libX11.so.6.3.0
b5da5000 b5daf000 r-xp /usr/lib/libXcursor.so.1.0.2
b5db0000 b5dc6000 r-xp /usr/lib/libudev.so.1.6.0
b5dc9000 b5dcd000 r-xp /lib/libattr.so.1.1.0
b5dce000 b5dfd000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5dff000 b5e05000 r-xp /usr/lib/libffi.so.6.0.2
b5e06000 b5e29000 r-xp /lib/libz.so.1.2.8
b5e2a000 b5e2d000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5e2e000 b5f8a000 r-xp /usr/lib/libxml2.so.2.9.2
b5f90000 b6077000 r-xp /usr/lib/libstdc++.so.6.0.20
b6084000 b6087000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6088000 b60aa000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b60ab000 b60bf000 r-xp /lib/libresolv-2.20-2014.11.so
b60c3000 b60e7000 r-xp /usr/lib/liblzma.so.5.0.3
b60e8000 b60ea000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b60ec000 b60f6000 r-xp /usr/lib/libembryo.so.1.13.0
b60f7000 b6120000 r-xp /usr/lib/libpng12.so.0.50.0
b6121000 b616a000 r-xp /usr/lib/libjpeg.so.8.0.2
b617b000 b6182000 r-xp /lib/librt-2.20-2014.11.so
b6184000 b61a3000 r-xp /usr/lib/libector.so.1.13.0
b61a6000 b61d3000 r-xp /usr/lib/liblua-5.1.so
b61d4000 b6264000 r-xp /usr/lib/libfreetype.so.6.11.3
b6268000 b62a6000 r-xp /usr/lib/libfontconfig.so.1.8.0
b62a7000 b62bd000 r-xp /usr/lib/libfribidi.so.0.3.1
b62be000 b6317000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b631a000 b6365000 r-xp /lib/libm-2.20-2014.11.so
b6367000 b6379000 r-xp /usr/lib/libeio.so.1.13.0
b637a000 b637d000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b637e000 b6384000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6385000 b63a8000 r-xp /usr/lib/libefreet.so.1.13.0
b63ab000 b63d6000 r-xp /usr/lib/libeldbus.so.1.13.0
b63d7000 b640b000 r-xp /usr/lib/libecore_con.so.1.13.0
b640d000 b6416000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6417000 b6420000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6421000 b6434000 r-xp /usr/lib/libeo.so.1.13.0
b6436000 b6449000 r-xp /usr/lib/libecore_input.so.1.13.0
b644a000 b6451000 r-xp /usr/lib/libecore_file.so.1.13.0
b6452000 b6475000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6476000 b64a2000 r-xp /usr/lib/libeet.so.1.13.0
b64ab000 b6516000 r-xp /usr/lib/libeina.so.1.13.0
b6519000 b6530000 r-xp /usr/lib/libefl.so.1.13.0
b6532000 b6699000 r-xp /usr/lib/libicuuc.so.51.1
b66a7000 b68b3000 r-xp /usr/lib/libicui18n.so.51.1
b68bb000 b690a000 r-xp /usr/lib/libecore_x.so.1.13.0
b690c000 b6926000 r-xp /lib/libgcc_s-4.9.so.1
b6928000 b692c000 r-xp /lib/libcap.so.2.21
b692d000 b6973000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6974000 b697b000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b697d000 b69cf000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b69d1000 b6b5c000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b61000 b6c2f000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6c32000 b6c36000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6c37000 b6c46000 r-xp /usr/lib/libvconf.so.0.2.45
b6c47000 b6c4a000 r-xp /usr/lib/libvasum.so.0.3.1
b6c4b000 b6c4e000 r-xp /usr/lib/libttrace.so.1.1
b6c50000 b6c54000 r-xp /usr/lib/libiniparser.so.0
b6c55000 b6c85000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c86000 b6c8f000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c90000 b6cb5000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6cb6000 b6cc6000 r-xp /usr/lib/libunwind.so.8.0.1
b6cd0000 b6e7e000 r-xp /lib/libc-2.20-2014.11.so
b6e86000 b6fc9000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6fcb000 b7023000 r-xp /usr/lib/libdbus-1.so.3.8.11
b7024000 b7058000 r-xp /usr/lib/libsystemd.so.0.4.0
b705b000 b712f000 r-xp /usr/lib/libedje.so.1.13.0
b7132000 b715e000 r-xp /usr/lib/libecore.so.1.13.0
b716f000 b7395000 r-xp /usr/lib/libevas.so.1.13.0
b73bd000 b73d5000 r-xp /lib/libpthread-2.20-2014.11.so
b73d9000 b7753000 r-xp /usr/lib/libelementary.so.1.13.0
b7773000 b7777000 r-xp /usr/lib/libsmack.so.1.0.0
b7778000 b7781000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7782000 b7785000 r-xp /usr/lib/libdlog.so.0.0.0
b7786000 b778b000 r-xp /usr/lib/libbundle.so.0.1.22
b778c000 b778f000 r-xp /lib/libdl-2.20-2014.11.so
b7791000 b77b6000 r-xp /usr/lib/libaul.so.0.1.0
b77b9000 b77bb000 r-xp /usr/lib/libappsvc.so.0.1.0
b77bc000 b77c1000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b77c2000 b77c9000 r-xp /usr/lib/libappcore-efl.so.1.1
b77cb000 b77d0000 r-xp /usr/lib/libsys-assert.so
b77d3000 b77d4000 r-xp [vdso]
b77d4000 b77f6000 r-xp /lib/ld-2.20-2014.11.so
b77f8000 b7800000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:5956)
Call Stack Count: 21
 0: (0xb6c0e1f6) [/usr/lib/libsqlite3.so.0] + 0xad1f6
 1: init_db + 0x13f (0xb383a0df) [/opt/usr/apps/org.example.example/bin/example] + 0x90df
 2: create_button_view + 0x51f (0xb3839d9f) [/opt/usr/apps/org.example.example/bin/example] + 0x8d9f
 3: setting_view_cb + 0x54 (0xb38397c4) [/opt/usr/apps/org.example.example/bin/example] + 0x87c4
 4: (0xb71a3449) [/usr/lib/libevas.so.1] + 0x34449
 5: (0xb642f319) [/usr/lib/libeo.so.1] + 0xe319
 6: eo_event_callback_call + 0xb3 (0xb642cd63) [/usr/lib/libeo.so.1] + 0xbd63
 7: (0xb71a3a62) [/usr/lib/libevas.so.1] + 0x34a62
 8: (0xb71b2441) [/usr/lib/libevas.so.1] + 0x43441
 9: evas_canvas_event_feed_mouse_down + 0xcf (0xb71bc20f) [/usr/lib/libevas.so.1] + 0x4d20f
10: evas_event_feed_mouse_down + 0x6a (0xb71c2c2a) [/usr/lib/libevas.so.1] + 0x53c2a
11: (0xb443c49c) [/usr/lib/libecore_input_evas.so.1] + 0x249c
12: (0xb713f055) [/usr/lib/libecore.so.1] + 0xd055
13: (0xb71481b9) [/usr/lib/libecore.so.1] + 0x161b9
14: ecore_main_loop_begin + 0x57 (0xb7148587) [/usr/lib/libecore.so.1] + 0x16587
15: elm_run + 0x2d (0xb75a122d) [/usr/lib/libelementary.so.1] + 0x1c822d
16: appcore_efl_main + 0x4de (0xb77c5dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
17: ui_app_main + 0x140 (0xb77bec80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
18: main + 0x27e (0xb38388ae) [/opt/usr/apps/org.example.example/bin/example] + 0x78ae
19: (0xb77fa148) [/opt/usr/apps/org.example.example/bin/example] + 0xb77fa148
20: __libc_start_main + 0xde (0xb6ce7e4e) [/lib/libc.so.6] + 0x17e4e
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
t=[0]
06-01 00:16:01.316+0900 D/rpm-installer( 6099): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/bin, 0, org.example.example), result=[0]
06-01 00:16:01.316+0900 D/rpm-installer( 6099): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/data, 0, org.example.example), result=[0]
06-01 00:16:01.326+0900 D/rpm-installer( 6099): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/lib, 0, org.example.example), result=[0]
06-01 00:16:01.326+0900 D/rpm-installer( 6099): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/res, 0, org.example.example), result=[0]
06-01 00:16:01.326+0900 D/rpm-installer( 6099): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/cache, 0, org.example.example), result=[0]
06-01 00:16:01.336+0900 D/rpm-installer( 6099): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/tizen-manifest.xml, 0, org.example.example), result=[0]
06-01 00:16:01.336+0900 D/rpm-installer( 6099): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/author-signature.xml, 0, org.example.example), result=[0]
06-01 00:16:01.346+0900 D/rpm-installer( 6099): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/signature1.xml, 0, org.example.example), result=[0]
06-01 00:16:01.346+0900 D/rpm-installer( 6099): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/share/packages/org.example.example.xml, 0, org.example.example), result=[0]
06-01 00:16:01.356+0900 D/rpm-installer( 6099): rpm-installer-privilege.c: _ri_privilege_set_package_version(75) > [smack] app[org.example.example] version set to [2.4] result=[0]
06-01 00:16:01.356+0900 D/rpm-installer( 6099): rpm-installer.c: _ri_apply_privilege(1924) > api-version[2.4] fot privilege has done successfully.
06-01 00:16:01.356+0900 D/rpm-installer( 6099): rpm-installer-privilege.c: _ri_privilege_enable_permissions(106) > [smack] app_enable_permissions(org.example.example, 7), result=[0]
06-01 00:16:01.356+0900 D/rpm-installer( 6099): coretpk-installer.c: _coretpk_installer_install_package(3097) > permission applying done successfully.
06-01 00:16:01.356+0900 D/rpm-installer( 6099): rpm-vconf-intf.c: _ri_broadcast_status_notification(126) > pkgid=[org.example.example], key=[install_percent], val=[100]
06-01 00:16:01.356+0900 D/PKGMGR  ( 6099): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(6099), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
06-01 00:16:01.356+0900 D/PKGMGR  ( 6099): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(6099), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
06-01 00:16:01.356+0900 D/PKGMGR  ( 6099): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
06-01 00:16:01.356+0900 D/PKGMGR_INSTALLER( 6099): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.example] key[install_percent] value[100]
06-01 00:16:01.356+0900 D/PKGMGR  ( 6099): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(6099), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
06-01 00:16:01.356+0900 D/PKGMGR  ( 6099): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(6099), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
06-01 00:16:01.356+0900 D/PKGMGR  ( 6099): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.install.progress), signal_name(install_progress)
06-01 00:16:01.356+0900 D/rpm-installer( 6099): coretpk-installer.c: _coretpk_installer_install_package(3113) > install status is [2].
06-01 00:16:01.356+0900 E/rpm-installer( 6099): coretpk-installer.c: __post_install_for_mmc(449) > (handle == NULL) handle is NULL.
06-01 00:16:01.356+0900 D/rpm-installer( 6099): coretpk-installer.c: _coretpk_installer_install_package(3136) > _coretpk_installer_install_package is done.
06-01 00:16:01.356+0900 D/rpm-installer( 6099): coretpk-installer.c: _coretpk_installer_install_package(3141) > signature1 file is deleted. [/opt/usr/apps/org.example.example/signature1.xml]
06-01 00:16:01.356+0900 D/rpm-installer( 6099): rpm-vconf-intf.c: _ri_broadcast_status_notification(126) > pkgid=[org.example.example], key=[end], val=[ok]
06-01 00:16:01.356+0900 D/PKGMGR  ( 6099): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(6099), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
06-01 00:16:01.356+0900 D/PKGMGR  ( 6099): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(6099), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
06-01 00:16:01.356+0900 D/PKGMGR  ( 6099): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
06-01 00:16:01.356+0900 D/PKGMGR_INSTALLER( 6099): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.example] key[end] value[ok]
06-01 00:16:01.356+0900 D/PKGMGR  ( 6099): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(6099), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
06-01 00:16:01.356+0900 D/PKGMGR  ( 6099): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(6099), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
06-01 00:16:01.356+0900 D/PKGMGR  ( 6099): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.install), signal_name(install)
06-01 00:16:01.356+0900 D/rpm-installer( 6099): coretpk-installer.c: _coretpk_installer_prepare_package_install_with_debug(3277) > [/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk] is installed successfully.
06-01 00:16:01.366+0900 D/PKGMGR  ( 2954): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_1708958793], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
06-01 00:16:01.366+0900 D/DATA_PROVIDER_MASTER( 2954): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.example] 100
06-01 00:16:01.366+0900 D/PKGMGR  ( 2904): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_1708958793], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
06-01 00:16:01.366+0900 W/cluster-home( 2904): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[0], state[1], package[org.example.example]
06-01 00:16:01.366+0900 D/PKGMGR  ( 2904): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_1708958793], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
06-01 00:16:01.366+0900 D/cluster-home( 2904): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29040003] pkg_type[tpk] package[org.example.example] key[install_percent] val[100] pmsg[(null)]
06-01 00:16:01.366+0900 D/PKGMGR  ( 2966): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_1708958793], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
06-01 00:16:01.366+0900 D/PKGMGR  ( 6097): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_1708958793], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
06-01 00:16:01.366+0900 D/PKGMGR  ( 2977): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_1708958793], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
06-01 00:16:01.366+0900 D/PKGMGR  ( 2977): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
06-01 00:16:01.366+0900 D/PKGMGR  ( 2964): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_1708958793], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
06-01 00:16:01.366+0900 D/ESD     ( 2964): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29640002), pkg_type(tpk), pkgid(org.example.example), key(install_percent), val(100)
06-01 00:16:01.366+0900 D/PKGMGR  ( 3035): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_1708958793], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
06-01 00:16:01.366+0900 D/PKGMGR  ( 3109): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_1708958793], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
06-01 00:16:01.366+0900 D/PKGMGR  ( 2959): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_1708958793], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
06-01 00:16:01.366+0900 D/QUICKPANEL( 2959): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:install_percent val:100
06-01 00:16:01.366+0900 D/rpm-installer( 6099): rpm-installer-privilege.c: _ri_privilege_enable_permissions(106) > [smack] app_enable_permissions(org.example.example, 7), result=[0]
06-01 00:16:01.366+0900 D/rpm-installer( 6099): coretpk-installer.c: _coretpk_installer_prepare_package_install_with_debug(3285) > _ri_privilege_enable_permissions(privilege/appdebuging succeeded for debug_mode.
06-01 00:16:01.366+0900 D/rpm-installer( 6099): rpm-appcore-intf.c: main(236) > sync() start
06-01 00:16:01.366+0900 D/PKGMGR  ( 6097): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_1708958793], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 00:16:01.366+0900 D/PKGMGR  ( 3109): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_1708958793], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 00:16:01.366+0900 D/PKGMGR  ( 2959): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_1708958793], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 00:16:01.366+0900 D/QUICKPANEL( 2959): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:end val:ok
06-01 00:16:01.376+0900 D/PKGMGR  ( 3035): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_1708958793], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 00:16:01.376+0900 D/ISF_PANEL_EFL( 3035): isf_panel_efl.cpp: _package_manager_event_cb(1387) > type=tpk package=org.example.example event_type=INSTALL event_state=COMPLETED progress=100 error=0
06-01 00:16:01.376+0900 D/PKGMGR  ( 2966): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_1708958793], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 00:16:01.376+0900 D/PRIVILEGE_CHECKER( 2966): privilege_checker.c: __privilege_checker_check_privilege(45) > _ENTER_
06-01 00:16:01.376+0900 E/PRIVILEGE_CHECKER( 2966): privilege_checker.c: __privilege_checker_check_privilege(78) > Please declare http://tizen.org/privilege/package.info in tizen-manifest.xml or config.xml
06-01 00:16:01.376+0900 D/PRIVILEGE_CHECKER( 2966): privilege_checker.c: __privilege_checker_check_privilege(45) > _ENTER_
06-01 00:16:01.376+0900 D/PKGMGR  ( 2964): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_1708958793], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 00:16:01.376+0900 D/ESD     ( 2964): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29640002), pkg_type(tpk), pkgid(org.example.example), key(end), val(ok)
06-01 00:16:01.376+0900 D/ESD     ( 2964): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
06-01 00:16:01.386+0900 D/PKGMGR  ( 2904): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_1708958793], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 00:16:01.386+0900 D/PKGMGR  ( 2977): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_1708958793], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 00:16:01.386+0900 D/PKGMGR  ( 2977): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
06-01 00:16:01.386+0900 W/cluster-home( 2904): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[0], state[2], package[org.example.example]
06-01 00:16:01.386+0900 D/cluster-home( 2904): widget-data-provider.cpp: PackageUpdated(2160) >  No boxes that pkgname is[org.example.example]
06-01 00:16:01.386+0900 D/PKGMGR  ( 2904): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_1708958793], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 00:16:01.386+0900 D/cluster-home( 2904): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29040003] pkg_type[tpk] package[org.example.example] key[end] val[ok] pmsg[(null)]
06-01 00:16:01.386+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
06-01 00:16:01.386+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
06-01 00:16:01.386+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
06-01 00:16:01.386+0900 D/PKGMGR  ( 2954): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_1708958793], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 00:16:01.386+0900 D/DATA_PROVIDER_MASTER( 2954): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.example] ok
06-01 00:16:01.386+0900 D/DATA_PROVIDER_MASTER( 2954): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.example], event_type[1]
06-01 00:16:01.386+0900 D/DATA_PROVIDER_MASTER( 2954): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
06-01 00:16:01.386+0900 D/DATA_PROVIDER_MASTER( 2954): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
06-01 00:16:01.386+0900 D/DATA_PROVIDER_MASTER( 2954): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
06-01 00:16:01.386+0900 D/DATA_PROVIDER_MASTER( 2954): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.example]
06-01 00:16:01.386+0900 D/cluster-home( 2904): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
06-01 00:16:01.386+0900 D/cluster-home( 2904): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.example]
06-01 00:16:01.386+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.example]
06-01 00:16:01.386+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.example]
06-01 00:16:01.386+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
06-01 00:16:01.386+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
06-01 00:16:01.386+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.example]
06-01 00:16:01.386+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.example] Name[forpet] Icon[/opt/usr/apps/org.example.example/shared/res/1.jpg] enable[1] system[0]
06-01 00:16:01.386+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: OnAppInstalled(309) >  pAppId [org.example.example]
06-01 00:16:01.386+0900 D/cluster-home( 2904): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.example
06-01 00:16:01.386+0900 D/cluster-home( 2904): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[22], isFolder[0], pageId[1], col[1], row[5], appId[org.example.example], name[forpet], menuId[1], isPreload[0] isPreload[0]
06-01 00:16:01.386+0900 D/cluster-home( 2904): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
06-01 00:16:01.386+0900 W/ISF_PANEL_EFL( 3035): isf_panel_efl.cpp: _package_manager_event_cb(1512) > _isf_insert_ime_info_by_pkgid returned 0.
06-01 00:16:01.386+0900 D/PKGMGR  ( 2773): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[install], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_1708958793], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 00:16:01.386+0900 D/AUL_AMD ( 2773): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.example), key(end), value(ok)
06-01 00:16:01.386+0900 W/AUL_AMD ( 2773): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(install), value(ok)
06-01 00:16:01.396+0900 D/AUL_AMD ( 2773): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.example, type:rpm
06-01 00:16:01.426+0900 D/rpm-installer( 6099): rpm-appcore-intf.c: main(238) > sync() end
06-01 00:16:01.576+0900 D/rpm-installer( 6099): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
06-01 00:16:01.576+0900 D/rpm-installer( 6099): rpm-appcore-intf.c: main(259) > ------------------------------------------------
06-01 00:16:01.576+0900 D/rpm-installer( 6099): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
06-01 00:16:01.576+0900 D/rpm-installer( 6099): rpm-appcore-intf.c: main(261) > ------------------------------------------------
06-01 00:16:01.576+0900 D/PKGMGR_SERVER( 6085): pkgmgr-server.c: sighandler(387) > child exit [6099]
06-01 00:16:01.576+0900 E/PKGMGR_SERVER( 6085): pkgmgr-server.c: sighandler(402) > child NORMAL exit [6099]
06-01 00:16:02.436+0900 D/AUL_AMD ( 2773): amd_request.c: __request_handler(838) > __request_handler: 0
06-01 00:16:02.436+0900 D/AUL_AMD ( 2773): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-01 00:16:02.446+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 00:16:02.446+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 00:16:02.446+0900 I/AUL     ( 2773): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
06-01 00:16:02.446+0900 D/AUL     ( 2773): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 6151, pid = 6153
06-01 00:16:02.446+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 00:16:02.446+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 00:16:02.446+0900 I/AUL     ( 2773): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
06-01 00:16:02.446+0900 E/AUL_AMD ( 2773): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-01 00:16:02.446+0900 W/AUL_AMD ( 2773): amd_launch.c: _start_app(2233) > caller pid : 6153
06-01 00:16:02.446+0900 E/AUL_AMD ( 2773): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-01 00:16:02.446+0900 W/AUL_AMD ( 2773): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-01 00:16:02.446+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2648) > process_pool: false
06-01 00:16:02.446+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-01 00:16:02.446+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-01 00:16:02.446+0900 W/AUL_AMD ( 2773): amd_launch.c: _start_app(2665) > pad pid(-5)
06-01 00:16:02.446+0900 D/AUL_AMD ( 2773): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-01 00:16:02.446+0900 D/AUL_AMD ( 2773): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-01 00:16:02.446+0900 D/AUL     ( 2773): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-01 00:16:02.446+0900 D/AUL_PAD ( 2951): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-01 00:16:02.446+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 00:16:02.446+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 00:16:02.446+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 00:16:02.446+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 00:16:02.446+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 00:16:02.446+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 00:16:02.446+0900 D/AUL_PAD ( 2951): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-01 00:16:02.446+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-01 00:16:02.446+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-01 00:16:02.446+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-01 00:16:02.446+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-01 00:16:02.446+0900 D/AUL_PAD ( 2951): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-01 00:16:02.446+0900 D/AUL_PAD ( 2951): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-01 00:16:02.446+0900 W/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-01 00:16:02.446+0900 D/AUL     ( 2951): process_pool.c: __send_pkt_raw_data(219) > send(11) : 620 / 620
06-01 00:16:02.446+0900 D/AUL_PAD ( 2951): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 5956, bin path: /opt/usr/apps/org.example.example/bin/example
06-01 00:16:02.446+0900 W/AUL_PAD ( 2951): launchpad.c: __send_result_to_caller(265) > Check app launching
06-01 00:16:02.446+0900 D/AUL_PAD ( 2951): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-01 00:16:02.446+0900 D/RESOURCED( 2886): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-01 00:16:02.446+0900 D/RESOURCED( 2886): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-01 00:16:02.446+0900 E/RESOURCED( 2886): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-01 00:16:02.446+0900 D/AUL_PAD ( 5956): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-01 00:16:02.456+0900 D/AUL_PAD ( 5956): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
06-01 00:16:02.456+0900 D/AUL_PAD ( 5956): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-01 00:16:02.456+0900 D/AUL_PAD ( 5956): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-01 00:16:02.456+0900 D/AUL_PAD ( 5956): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-01 00:16:02.456+0900 D/AUL_PAD ( 5956): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-01 00:16:02.456+0900 D/AUL     ( 5956): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (5957) is sent.
06-01 00:16:02.456+0900 D/AUL     ( 5956): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 5957, signo: 10
06-01 00:16:02.456+0900 D/AUL     ( 5956): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-01 00:16:02.456+0900 D/AUL_PAD ( 5956): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-01 00:16:02.456+0900 D/AUL_PAD ( 5956): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-01 00:16:02.456+0900 D/AUL_PAD ( 5956): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-01 00:16:02.456+0900 D/AUL_PAD ( 5956): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-01 00:16:02.456+0900 D/AUL_PAD ( 5956): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTYyNDM3NjIvNDQ2NzIxAA==##
06-01 00:16:02.456+0900 D/AUL_PAD ( 5956): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-01 00:16:02.456+0900 D/AUL_PAD ( 5956): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA2MTUzAA==##
06-01 00:16:02.456+0900 D/AUL_PAD ( 5956): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-01 00:16:02.456+0900 D/AUL_PAD ( 5956): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-01 00:16:02.456+0900 D/AUL_PAD ( 5956): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-01 00:16:02.456+0900 D/AUL_PAD ( 5956): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-01 00:16:02.456+0900 D/AUL_PAD ( 5956): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-01 00:16:02.456+0900 I/CAPI_APPFW_APPLICATION( 5956): app_main.c: ui_app_main(788) > app_efl_main
06-01 00:16:02.456+0900 D/LAUNCH  ( 5956): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-01 00:16:02.456+0900 D/APP_CORE( 5956): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-01 00:16:02.456+0900 D/APP_CORE( 5956): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-01 00:16:02.456+0900 D/APP_CORE( 5956): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-01 00:16:02.486+0900 D/APP_CORE( 5956): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-01 00:16:02.486+0900 D/AUL     ( 5956): app_sock.c: __create_server_sock(156) > pg path - already exists
06-01 00:16:02.486+0900 D/APP_CORE( 5956): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb431e520
06-01 00:16:02.486+0900 D/LAUNCH  ( 5956): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-01 00:16:02.486+0900 I/CAPI_APPFW_APPLICATION( 5956): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-01 00:16:02.546+0900 D/AUL_PAD ( 2951): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-01 00:16:02.556+0900 W/AUL     ( 2773): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 5956, appid: org.example.example
06-01 00:16:02.556+0900 D/AUL     ( 2773): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-01 00:16:02.556+0900 E/AUL     ( 2773): simple_util.c: __trm_app_info_send_socket(330) > access
06-01 00:16:02.556+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2700) > add app group info
06-01 00:16:02.556+0900 E/AUL     ( 2773): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-01 00:16:02.556+0900 D/AUL_AMD ( 2773): amd_status.c: _status_add_app_info_list(427) > pid(5956) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-01 00:16:02.556+0900 D/RESOURCED( 2886): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 5956
06-01 00:16:02.556+0900 D/RESOURCED( 2886): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-01 00:16:02.556+0900 E/RESOURCED( 2886): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-01 00:16:02.556+0900 D/RESOURCED( 2886): proc-main.c: resourced_proc_status_change(888) > available memory = 298
06-01 00:16:02.586+0900 D/LAUNCH  ( 5956): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
06-01 00:16:02.596+0900 D/APP_CORE( 5956): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-01 00:16:02.596+0900 E/E17     ( 2798): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02c00002)
06-01 00:16:02.636+0900 E/E17     ( 2798): e_border.c: e_border_show(2088) > BD_SHOW(0x02c00002)
06-01 00:16:02.656+0900 D/APP_CORE( 5956): appcore.c: __aul_handler(587) > [APP 5956]     AUL event: AUL_START
06-01 00:16:02.666+0900 I/APP_CORE( 5956): appcore-efl.c: __do_app(496) > [APP 5956] Event: RESET State: CREATED
06-01 00:16:02.676+0900 D/APP_CORE( 5956): appcore-efl.c: __do_app(527) > [APP 5956] RESET
06-01 00:16:02.676+0900 D/LAUNCH  ( 5956): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
06-01 00:16:02.676+0900 D/APP_CORE( 5956): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-01 00:16:02.676+0900 D/APP_CORE( 5956): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-01 00:16:02.676+0900 I/CAPI_APPFW_APPLICATION( 5956): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-01 00:16:02.676+0900 D/AUL     ( 5956): service.c: __set_bundle(186) > __set_bundle
06-01 00:16:02.676+0900 D/LAUNCH  ( 5956): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-01 00:16:02.676+0900 D/APP_CORE( 5956): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-01 00:16:02.686+0900 E/EFL     ( 5956): edje<5956> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 00:16:02.686+0900 E/EFL     ( 5956): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 00:16:02.686+0900 E/EFL     ( 5956): edje<5956> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 00:16:02.686+0900 E/EFL     ( 5956): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 00:16:02.686+0900 E/EFL     ( 5956): edje<5956> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 00:16:02.686+0900 E/EFL     ( 5956): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 00:16:02.686+0900 E/EFL     ( 5956): edje<5956> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 00:16:02.686+0900 E/EFL     ( 5956): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 00:16:02.686+0900 E/EFL     ( 5956): edje<5956> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 00:16:02.686+0900 E/EFL     ( 5956): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 00:16:02.686+0900 W/PROCESSMGR( 2798): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=5956
06-01 00:16:02.706+0900 E/EFL     ( 2798): eo<2798> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 00:16:02.706+0900 E/EFL     ( 2798): eo<2798> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 00:16:02.726+0900 W/APP_CORE( 5956): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2c00002
06-01 00:16:02.726+0900 D/APP_CORE( 5956): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2c00002
06-01 00:16:02.726+0900 D/APP_CORE( 5956): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-01 00:16:02.726+0900 D/AUL     ( 5956): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-01 00:16:02.726+0900 D/AUL_AMD ( 2773): amd_request.c: __request_handler(838) > __request_handler: 34
06-01 00:16:02.726+0900 D/AUL_AMD ( 2773): amd_request.c: __request_handler(838) > __request_handler: 15
06-01 00:16:02.726+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 00:16:02.726+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 00:16:02.726+0900 D/INDICATOR( 2891): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
06-01 00:16:02.726+0900 D/AUL_AMD ( 2773): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 5956 is org.example.example
06-01 00:16:02.726+0900 D/AUL_AMD ( 2773): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 5956 : 0
06-01 00:16:02.726+0900 D/AUL     ( 2966): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-01 00:16:02.736+0900 D/INDICATOR( 2891): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-01 00:16:02.736+0900 D/INDICATOR( 2891): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-01 00:16:02.736+0900 D/INDICATOR( 2891): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-01 00:16:02.736+0900 D/INDICATOR( 2891): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-01 00:16:02.736+0900 D/INDICATOR( 2891): main.c: _rotate_window(252) > port :: hide more icon
06-01 00:16:02.996+0900 E/PKGMGR_SERVER( 6085): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-01 00:16:02.996+0900 E/PKGMGR_SERVER( 6085): pkgmgr-server.c: main(2265) > package manager server terminated.
06-01 00:16:03.016+0900 D/APP_CORE( 5956): appcore.c: __prt_ltime(236) > [APP 5956] first idle after reset: 582 msec
06-01 00:16:03.116+0900 E/E17     ( 2798): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
06-01 00:16:03.116+0900 D/APP_CORE( 2904): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
06-01 00:16:03.116+0900 D/APP_CORE( 2904): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-01 00:16:03.116+0900 D/APP_CORE( 2904): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-01 00:16:03.116+0900 I/APP_CORE( 2904): appcore-efl.c: __do_app(496) > [APP 2904] Event: PAUSE State: RUNNING
06-01 00:16:03.116+0900 D/APP_CORE( 2904): appcore-efl.c: __do_app(565) > [APP 2904] PAUSE
06-01 00:16:03.116+0900 I/CAPI_APPFW_APPLICATION( 2904): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-01 00:16:03.116+0900 E/cluster-home( 2904): homescreen.cpp: OnPause(84) >  app pause
06-01 00:16:03.116+0900 D/cluster-view( 2904): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-01 00:16:03.126+0900 D/cluster-view( 2904): homescreen-view-manager.cpp: AppPause(923) >  END
06-01 00:16:03.126+0900 D/APP_CORE( 2904): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-01 00:16:03.126+0900 E/APP_CORE( 2904): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-01 00:16:03.126+0900 D/AUL_AMD ( 2773): amd_status.c: _status_update_app_info_list(456) > pid(2904) status(4)
06-01 00:16:03.126+0900 D/AUL_AMD ( 2773): amd_status.c: _status_update_app_info_list(468) > pid(2904) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-01 00:16:03.126+0900 D/AUL     ( 2773): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-01 00:16:03.126+0900 W/AUL     ( 2773): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2904, appid: org.tizen.homescreen, status: bg
06-01 00:16:03.136+0900 D/APP_CORE( 5956): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2c00002 fully_obscured 0
06-01 00:16:03.136+0900 D/APP_CORE( 5956): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-01 00:16:03.136+0900 D/APP_CORE( 5956): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-01 00:16:03.136+0900 I/APP_CORE( 5956): appcore-efl.c: __do_app(496) > [APP 5956] Event: RESUME State: CREATED
06-01 00:16:03.136+0900 D/LAUNCH  ( 5956): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-01 00:16:03.136+0900 D/APP_CORE( 5956): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-01 00:16:03.136+0900 D/APP_CORE( 5956): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-01 00:16:03.136+0900 D/APP_CORE( 5956): appcore-efl.c: __do_app(607) > [APP 5956] RESUME
06-01 00:16:03.146+0900 I/APP_CORE( 5956): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-01 00:16:03.146+0900 I/APP_CORE( 5956): appcore-efl.c: __do_app(614) > [APP 5956] Initial Launching, call the resume_cb
06-01 00:16:03.146+0900 I/CAPI_APPFW_APPLICATION( 5956): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-01 00:16:03.146+0900 D/LAUNCH  ( 5956): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-01 00:16:03.146+0900 D/LAUNCH  ( 5956): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-01 00:16:03.146+0900 D/APP_CORE( 5956): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-01 00:16:03.146+0900 E/APP_CORE( 5956): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-01 00:16:03.156+0900 D/AUL_AMD ( 2773): amd_launch.c: __e17_status_handler(2891) > pid(5956) status(3)
06-01 00:16:03.156+0900 D/AUL_AMD ( 2773): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-01 00:16:03.156+0900 D/DATA_PROVIDER_MASTER( 2954): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2904 is paused
06-01 00:16:03.156+0900 D/DATA_PROVIDER_MASTER( 2954): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-01 00:16:03.156+0900 I/CAPI_WIDGET_APPLICATION( 3032): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-01 00:16:03.156+0900 I/CAPI_WIDGET_APPLICATION( 3032): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-01 00:16:03.156+0900 W/AUL     ( 3032): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3032, appid: org.tizen.calendar.widget, status: bg
06-01 00:16:03.166+0900 D/RESOURCED( 2886): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3032, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-01 00:16:03.166+0900 D/RESOURCED( 2886): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3032
06-01 00:16:03.166+0900 D/RESOURCED( 2886): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3032, appname = org.tizen.calendar.widget
06-01 00:16:03.166+0900 D/RESOURCED( 2886): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3032
06-01 00:16:03.166+0900 W/AUL_AMD ( 2773): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-01 00:16:03.176+0900 W/AUL_AMD ( 2773): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-01 00:16:03.176+0900 D/AUL_AMD ( 2773): amd_status.c: _status_update_app_info_list(456) > pid(5956) status(3)
06-01 00:16:03.176+0900 D/AUL_AMD ( 2773): amd_status.c: _status_update_app_info_list(468) > pid(5956) appid(org.example.example) pkgid(org.example.example) status(3)
06-01 00:16:03.176+0900 D/AUL     ( 2773): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-01 00:16:03.176+0900 W/AUL     ( 2773): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 5956, appid: org.example.example, status: fg
06-01 00:16:03.176+0900 D/RESOURCED( 2886): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 5956
06-01 00:16:03.176+0900 D/RESOURCED( 2886): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 5956, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-01 00:16:03.176+0900 D/RESOURCED( 2886): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 5956
06-01 00:16:03.226+0900 D/RESOURCED( 2886): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 5956, appname = org.example.example, pkgname = org.example.example
06-01 00:16:03.226+0900 D/RESOURCED( 2886): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 5956, appname = org.example.example
06-01 00:16:03.226+0900 D/RESOURCED( 2886): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 5956
06-01 00:16:03.226+0900 I/RESOURCED( 2886): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-01 00:16:03.226+0900 I/RESOURCED( 2886): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-01 00:16:03.316+0900 D/AUL_AMD ( 2773): amd_launch.c: __e17_status_handler(2910) > pid(5956) status(0)
06-01 00:16:03.556+0900 D/AUL_PAD ( 2951): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-01 00:16:03.556+0900 D/AUL_PAD ( 6161): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-01 00:16:03.566+0900 D/AUL_PAD ( 2951): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-01 00:16:03.576+0900 E/RESOURCED( 2886): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.371
06-01 00:16:04.066+0900 D/AUL_AMD ( 2773): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-01 00:16:04.066+0900 D/RUA     ( 2773): rua.c: rua_add_history(179) > rua_add_history start
06-01 00:16:04.096+0900 D/RUA     ( 2773): rua.c: rua_add_history(247) > rua_add_history ok
06-01 00:16:04.426+0900 I/user_tag0( 5956): /opt/usr/apps/org.example.example/data/test.db
06-01 00:16:04.486+0900 D/AUL_PAD ( 2951): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-01 00:16:04.486+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 00:16:04.486+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 00:16:04.486+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 00:16:04.486+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 00:16:04.486+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 00:16:04.486+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 00:16:04.486+0900 I/AUL_PAD ( 2951): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 5956 pgid = 5956
06-01 00:16:04.486+0900 I/AUL_PAD ( 2951): sigchild.h: __sigchild_action(142) > dead_pid(5956)
06-01 00:16:04.496+0900 E/EFL     ( 2798): eo<2798> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 00:16:04.516+0900 D/PROCESSMGR( 2798): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002e  register trigger_timer!  pointed_win=0x40090a 
06-01 00:16:04.516+0900 W/CRASH_MANAGER( 6162): worker.c: worker_job(1204) > 1105956657861149624376
