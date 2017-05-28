S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 2967
Date: 2017-05-22 17:42:58+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8000aa56

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x8000aa56, esi = 0x8002130a
ebp = 0xbff15468, esp = 0xbff15360
eax = 0x00000002, ebx = 0xb3742000
ecx = 0xb3742000, edx = 0xb373b3a0
eip = 0xb373c83b

Memory Information
MemTotal:      123 KB
MemFree:        32 KB
Buffers:         4 KB
Cached:     160224 KB
VmPeak:      99364 KB
VmSize:      99364 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21900 KB
VmRSS:       21900 KB
VmData:      32716 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33576 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 2967 TID = 2967
2967 3071 3373 3374 

Maps Information
b2be1000 b2beb000 r-xp /usr/lib/libfeedback.so.0.1.4
b2bf1000 b2bfd000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2bfe000 b2c1f000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2c24000 b2c25000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2c26000 b2c2b000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2c2c000 b2c2e000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c2f000 b2c31000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2c32000 b2c3e000 r-xp /usr/lib/libdrm.so.2.4.0
b2c3f000 b2c49000 r-xp /usr/lib/libtbm.so.1.0.0
b2c4a000 b2c5f000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c60000 b2c72000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3474000 b347d000 r-xp /usr/lib/libeventsystem.so.0.0.1
b347e000 b3487000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3488000 b349a000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b349b000 b34bc000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b34c3000 b34c4000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b34c5000 b34c6000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b34c7000 b34ca000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b34cb000 b34ce000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b35d6000 b35dc000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b35dd000 b3721000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3731000 b3732000 r-xp /usr/lib/libxshmfence.so.1.0.0
b3733000 b3736000 r-xp /usr/lib/libdri2.so.0.0.0
b3737000 b3738000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b3739000 b3741000 r-xp /opt/usr/apps/org.example.example/bin/example
b3743000 b377c000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b417f000 b418a000 r-xp /lib/libnss_files-2.20-2014.11.so
b418c000 b4197000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4199000 b41b0000 r-xp /lib/libnsl-2.20-2014.11.so
b41b4000 b41bc000 r-xp /lib/libnss_compat-2.20-2014.11.so
b41be000 b41e2000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b41e3000 b41e4000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b41e5000 b41e8000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b41e9000 b41f0000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b41f1000 b41fb000 r-xp /usr/lib/libsensord-share.so
b41fc000 b4218000 r-xp /usr/lib/libsensor.so.1.2.0
b421a000 b4223000 r-xp /usr/lib/libappcore-common.so.1.1
b4226000 b4228000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b423d000 b423f000 r-xp /usr/lib/libXau.so.6.0.0
b4240000 b4262000 r-xp /usr/lib/libxcb.so.1.1.0
b4264000 b426d000 r-xp /lib/libcrypt-2.20-2014.11.so
b4296000 b4298000 r-xp /usr/lib/libiri.so
b4299000 b42bf000 r-xp /lib/libexpat.so.1.5.2
b42c1000 b432c000 r-xp /usr/lib/libssl.so.1.0.0
b4332000 b433e000 r-xp /usr/lib/libethumb.so.1.13.0
b433f000 b4343000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4344000 b4595000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b10000 b5b20000 r-xp /usr/lib/libXi.so.6.1.0
b5b21000 b5b23000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b24000 b5b2a000 r-xp /usr/lib/libXtst.so.6.1.0
b5b2b000 b5b35000 r-xp /usr/lib/libXrender.so.1.3.0
b5b36000 b5b3f000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b41000 b5b43000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b44000 b5b49000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b4a000 b5b5c000 r-xp /usr/lib/libXext.so.6.4.0
b5b5d000 b5b5f000 r-xp /usr/lib/libXdamage.so.1.1.0
b5b60000 b5b62000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5b64000 b5ca6000 r-xp /usr/lib/libX11.so.6.3.0
b5caa000 b5cb4000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cb5000 b5ccb000 r-xp /usr/lib/libudev.so.1.6.0
b5cce000 b5cd2000 r-xp /lib/libattr.so.1.1.0
b5cd3000 b5d02000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d04000 b5d0a000 r-xp /usr/lib/libffi.so.6.0.2
b5d0b000 b5d2e000 r-xp /lib/libz.so.1.2.8
b5d2f000 b5d32000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d33000 b5e8f000 r-xp /usr/lib/libxml2.so.2.9.2
b5e95000 b5f7c000 r-xp /usr/lib/libstdc++.so.6.0.20
b5f89000 b5f8c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5f8d000 b5faf000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5fb0000 b5fc4000 r-xp /lib/libresolv-2.20-2014.11.so
b5fc8000 b5fec000 r-xp /usr/lib/liblzma.so.5.0.3
b5fed000 b5fef000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5ff1000 b5ffb000 r-xp /usr/lib/libembryo.so.1.13.0
b5ffc000 b6025000 r-xp /usr/lib/libpng12.so.0.50.0
b6026000 b606f000 r-xp /usr/lib/libjpeg.so.8.0.2
b6080000 b6087000 r-xp /lib/librt-2.20-2014.11.so
b6089000 b60a8000 r-xp /usr/lib/libector.so.1.13.0
b60ab000 b60d8000 r-xp /usr/lib/liblua-5.1.so
b60d9000 b6169000 r-xp /usr/lib/libfreetype.so.6.11.3
b616d000 b61ab000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61ac000 b61c2000 r-xp /usr/lib/libfribidi.so.0.3.1
b61c3000 b621c000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b621f000 b626a000 r-xp /lib/libm-2.20-2014.11.so
b626c000 b627e000 r-xp /usr/lib/libeio.so.1.13.0
b627f000 b6282000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6283000 b6289000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b628a000 b62ad000 r-xp /usr/lib/libefreet.so.1.13.0
b62b0000 b62db000 r-xp /usr/lib/libeldbus.so.1.13.0
b62dc000 b6310000 r-xp /usr/lib/libecore_con.so.1.13.0
b6312000 b631b000 r-xp /usr/lib/libecore_imf.so.1.13.0
b631c000 b6325000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6326000 b6339000 r-xp /usr/lib/libeo.so.1.13.0
b633b000 b634e000 r-xp /usr/lib/libecore_input.so.1.13.0
b634f000 b6356000 r-xp /usr/lib/libecore_file.so.1.13.0
b6357000 b637a000 r-xp /usr/lib/libecore_evas.so.1.13.0
b637b000 b63a7000 r-xp /usr/lib/libeet.so.1.13.0
b63b0000 b641b000 r-xp /usr/lib/libeina.so.1.13.0
b641e000 b6435000 r-xp /usr/lib/libefl.so.1.13.0
b6437000 b659e000 r-xp /usr/lib/libicuuc.so.51.1
b65ac000 b67b8000 r-xp /usr/lib/libicui18n.so.51.1
b67c0000 b680f000 r-xp /usr/lib/libecore_x.so.1.13.0
b6811000 b682b000 r-xp /lib/libgcc_s-4.9.so.1
b682d000 b6831000 r-xp /lib/libcap.so.2.21
b6832000 b6878000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6879000 b6880000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6882000 b68d4000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b68d6000 b6a61000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6a66000 b6b34000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b37000 b6b3b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b3c000 b6b4b000 r-xp /usr/lib/libvconf.so.0.2.45
b6b4c000 b6b4f000 r-xp /usr/lib/libvasum.so.0.3.1
b6b50000 b6b53000 r-xp /usr/lib/libttrace.so.1.1
b6b55000 b6b59000 r-xp /usr/lib/libiniparser.so.0
b6b5a000 b6b8a000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6b8b000 b6b94000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6b95000 b6bba000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bbb000 b6bcb000 r-xp /usr/lib/libunwind.so.8.0.1
b6bd5000 b6d83000 r-xp /lib/libc-2.20-2014.11.so
b6d8b000 b6ece000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6ed0000 b6f28000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f29000 b6f5d000 r-xp /usr/lib/libsystemd.so.0.4.0
b6f60000 b7034000 r-xp /usr/lib/libedje.so.1.13.0
b7037000 b7063000 r-xp /usr/lib/libecore.so.1.13.0
b7074000 b729a000 r-xp /usr/lib/libevas.so.1.13.0
b72c2000 b72da000 r-xp /lib/libpthread-2.20-2014.11.so
b72de000 b7658000 r-xp /usr/lib/libelementary.so.1.13.0
b7678000 b767c000 r-xp /usr/lib/libsmack.so.1.0.0
b767d000 b7686000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7687000 b768a000 r-xp /usr/lib/libdlog.so.0.0.0
b768b000 b7690000 r-xp /usr/lib/libbundle.so.0.1.22
b7691000 b7694000 r-xp /lib/libdl-2.20-2014.11.so
b7696000 b76bb000 r-xp /usr/lib/libaul.so.0.1.0
b76be000 b76c0000 r-xp /usr/lib/libappsvc.so.0.1.0
b76c1000 b76c6000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b76c7000 b76ce000 r-xp /usr/lib/libappcore-efl.so.1.1
b76d0000 b76d5000 r-xp /usr/lib/libsys-assert.so
b76d8000 b76d9000 r-xp [vdso]
b76d9000 b76fb000 r-xp /lib/ld-2.20-2014.11.so
b76fd000 b7705000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:2967)
Call Stack Count: 19
 0: create_button_view + 0x2fb (0xb373c83b) [/opt/usr/apps/org.example.example/bin/example] + 0x383b
 1: feeding_view_cb + 0x5a (0xb373c48a) [/opt/usr/apps/org.example.example/bin/example] + 0x348a
 2: (0xb70a8449) [/usr/lib/libevas.so.1] + 0x34449
 3: (0xb6334319) [/usr/lib/libeo.so.1] + 0xe319
 4: eo_event_callback_call + 0xb3 (0xb6331d63) [/usr/lib/libeo.so.1] + 0xbd63
 5: (0xb70a8a62) [/usr/lib/libevas.so.1] + 0x34a62
 6: (0xb70b7441) [/usr/lib/libevas.so.1] + 0x43441
 7: evas_canvas_event_feed_mouse_down + 0xcf (0xb70c120f) [/usr/lib/libevas.so.1] + 0x4d20f
 8: evas_event_feed_mouse_down + 0x6a (0xb70c7c2a) [/usr/lib/libevas.so.1] + 0x53c2a
 9: (0xb434149c) [/usr/lib/libecore_input_evas.so.1] + 0x249c
10: (0xb7044055) [/usr/lib/libecore.so.1] + 0xd055
11: (0xb704d1b9) [/usr/lib/libecore.so.1] + 0x161b9
12: ecore_main_loop_begin + 0x57 (0xb704d587) [/usr/lib/libecore.so.1] + 0x16587
13: elm_run + 0x2d (0xb74a622d) [/usr/lib/libelementary.so.1] + 0x1c822d
14: appcore_efl_main + 0x4de (0xb76cadde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
15: ui_app_main + 0x140 (0xb76c3c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
16: main + 0x27e (0xb373df5e) [/opt/usr/apps/org.example.example/bin/example] + 0x4f5e
17: create_time + 0x68 (0xb76ff148) [/opt/usr/apps/org.example.example/bin/example] + 0xb76ff148
18: __libc_start_main + 0xde (0xb6bece4e) [/lib/libc.so.6] + 0x17e4e
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
rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/lib, 0, org.example.example), result=[0]
05-22 17:42:55.309+0900 D/rpm-installer( 3316): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/res, 0, org.example.example), result=[0]
05-22 17:42:55.309+0900 D/rpm-installer( 3316): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/cache, 0, org.example.example), result=[0]
05-22 17:42:55.309+0900 D/rpm-installer( 3316): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/tizen-manifest.xml, 0, org.example.example), result=[0]
05-22 17:42:55.319+0900 D/rpm-installer( 3316): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/author-signature.xml, 0, org.example.example), result=[0]
05-22 17:42:55.319+0900 D/rpm-installer( 3316): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/signature1.xml, 0, org.example.example), result=[0]
05-22 17:42:55.339+0900 D/rpm-installer( 3316): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/share/packages/org.example.example.xml, 0, org.example.example), result=[0]
05-22 17:42:55.359+0900 D/rpm-installer( 3316): rpm-installer-privilege.c: _ri_privilege_set_package_version(75) > [smack] app[org.example.example] version set to [2.4] result=[0]
05-22 17:42:55.359+0900 D/rpm-installer( 3316): rpm-installer.c: _ri_apply_privilege(1924) > api-version[2.4] fot privilege has done successfully.
05-22 17:42:55.369+0900 D/rpm-installer( 3316): rpm-installer-privilege.c: _ri_privilege_enable_permissions(106) > [smack] app_enable_permissions(org.example.example, 7), result=[0]
05-22 17:42:55.369+0900 D/rpm-installer( 3316): coretpk-installer.c: _coretpk_installer_package_reinstall(5083) > #permission applying success.
05-22 17:42:55.369+0900 D/PKGMGR  ( 3316): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(3316), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
05-22 17:42:55.369+0900 D/PKGMGR  ( 3316): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(3316), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
05-22 17:42:55.369+0900 D/PKGMGR  ( 3316): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
05-22 17:42:55.369+0900 D/PKGMGR_INSTALLER( 3316): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.example] key[install_percent] value[100]
05-22 17:42:55.369+0900 D/PKGMGR  ( 3316): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(3316), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
05-22 17:42:55.369+0900 D/PKGMGR  ( 3316): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(3316), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
05-22 17:42:55.369+0900 D/PKGMGR  ( 3316): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.install.progress), signal_name(install_progress)
05-22 17:42:55.369+0900 D/rpm-installer( 3316): coretpk-installer.c: _coretpk_installer_package_reinstall(5096) > _coretpk_installer_package_reinstall(org.example.example) is done.
05-22 17:42:55.369+0900 D/PKGMGR  ( 3316): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(3316), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
05-22 17:42:55.369+0900 D/PKGMGR  ( 3316): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(3316), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
05-22 17:42:55.369+0900 D/PKGMGR  ( 3316): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
05-22 17:42:55.369+0900 D/PKGMGR_INSTALLER( 3316): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.example] key[end] value[ok]
05-22 17:42:55.369+0900 D/PKGMGR  ( 3316): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(3316), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
05-22 17:42:55.369+0900 D/PKGMGR  ( 3316): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(3316), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
05-22 17:42:55.369+0900 D/PKGMGR  ( 3316): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.upgrade), signal_name(upgrade)
05-22 17:42:55.379+0900 D/PKGMGR  ( 3050): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-613244413], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-22 17:42:55.379+0900 D/PKGMGR  ( 3050): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-613244413], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-22 17:42:55.379+0900 D/ISF_PANEL_EFL( 3050): isf_panel_efl.cpp: _package_manager_event_cb(1288) > type=tpk package=org.example.example event_type=UPDATE event_state=COMPLETED progress=100 error=0
05-22 17:42:55.379+0900 D/PKGMGR  ( 3311): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-613244413], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-22 17:42:55.379+0900 D/PKGMGR  ( 3311): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-613244413], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-22 17:42:55.379+0900 D/PKGMGR  ( 3118): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-613244413], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-22 17:42:55.379+0900 D/PKGMGR  ( 3118): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-613244413], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-22 17:42:55.389+0900 D/PKGMGR  ( 2766): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[upgrade], req_id=[org.example.example_-613244413], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-22 17:42:55.389+0900 D/AUL_AMD ( 2766): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.example), key(end), value(ok)
05-22 17:42:55.389+0900 W/AUL_AMD ( 2766): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(update), value(ok)
05-22 17:42:55.389+0900 D/PKGMGR  ( 2982): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-613244413], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-22 17:42:55.389+0900 D/PKGMGR  ( 2982): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-613244413], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-22 17:42:55.389+0900 D/PKGMGR  ( 2978): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-613244413], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-22 17:42:55.389+0900 D/ESD     ( 2978): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29780002), pkg_type(tpk), pkgid(org.example.example), key(install_percent), val(100)
05-22 17:42:55.389+0900 D/PKGMGR  ( 2978): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-613244413], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-22 17:42:55.389+0900 D/ESD     ( 2978): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29780002), pkg_type(tpk), pkgid(org.example.example), key(end), val(ok)
05-22 17:42:55.389+0900 D/ESD     ( 2978): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
05-22 17:42:55.389+0900 D/AUL_AMD ( 2766): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.example, type:rpm
05-22 17:42:55.389+0900 W/ISF_PANEL_EFL( 3050): isf_panel_efl.cpp: _package_manager_event_cb(1380) > isf_db_select_appids_by_pkgid returned 0.
05-22 17:42:55.389+0900 D/PKGMGR  ( 2966): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-613244413], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-22 17:42:55.389+0900 D/DATA_PROVIDER_MASTER( 2966): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.example] 100
05-22 17:42:55.389+0900 D/PKGMGR  ( 2966): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-613244413], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-22 17:42:55.389+0900 D/DATA_PROVIDER_MASTER( 2966): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.example] ok
05-22 17:42:55.389+0900 D/DATA_PROVIDER_MASTER( 2966): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.example], event_type[1]
05-22 17:42:55.389+0900 D/DATA_PROVIDER_MASTER( 2966): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
05-22 17:42:55.389+0900 D/DATA_PROVIDER_MASTER( 2966): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
05-22 17:42:55.389+0900 D/DATA_PROVIDER_MASTER( 2966): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
05-22 17:42:55.389+0900 D/DATA_PROVIDER_MASTER( 2966): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.example]
05-22 17:42:55.389+0900 D/PKGMGR  ( 2993): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-613244413], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-22 17:42:55.389+0900 D/PKGMGR  ( 2993): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
05-22 17:42:55.389+0900 D/PKGMGR  ( 2993): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-613244413], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-22 17:42:55.389+0900 D/PKGMGR  ( 2993): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
05-22 17:42:55.399+0900 D/PKGMGR  ( 2901): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-613244413], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-22 17:42:55.399+0900 W/cluster-home( 2901): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.example]
05-22 17:42:55.399+0900 D/PKGMGR  ( 2901): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-613244413], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-22 17:42:55.399+0900 D/cluster-home( 2901): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29010003] pkg_type[tpk] package[org.example.example] key[install_percent] val[100] pmsg[(null)]
05-22 17:42:55.399+0900 D/PKGMGR  ( 2901): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-613244413], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-22 17:42:55.399+0900 W/cluster-home( 2901): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[2], package[org.example.example]
05-22 17:42:55.399+0900 D/cluster-home( 2901): widget-data-provider.cpp: PackageUpdated(2160) >  No boxes that pkgname is[org.example.example]
05-22 17:42:55.399+0900 D/PKGMGR  ( 2901): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-613244413], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-22 17:42:55.399+0900 D/cluster-home( 2901): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29010003] pkg_type[tpk] package[org.example.example] key[end] val[ok] pmsg[(null)]
05-22 17:42:55.399+0900 E/cluster-home( 2901): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
05-22 17:42:55.399+0900 E/cluster-home( 2901): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
05-22 17:42:55.399+0900 E/cluster-home( 2901): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
05-22 17:42:55.399+0900 D/PKGMGR  ( 2976): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-613244413], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-22 17:42:55.399+0900 D/QUICKPANEL( 2976): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:install_percent val:100
05-22 17:42:55.399+0900 D/PKGMGR  ( 2976): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-613244413], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-22 17:42:55.399+0900 D/QUICKPANEL( 2976): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:end val:ok
05-22 17:42:55.399+0900 D/cluster-home( 2901): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
05-22 17:42:55.419+0900 D/cluster-home( 2901): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.example]
05-22 17:42:55.419+0900 E/cluster-home( 2901): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.example]
05-22 17:42:55.419+0900 E/cluster-home( 2901): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.example]
05-22 17:42:55.419+0900 E/cluster-home( 2901): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
05-22 17:42:55.419+0900 E/cluster-home( 2901): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
05-22 17:42:55.419+0900 E/cluster-home( 2901): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.example]
05-22 17:42:55.419+0900 E/cluster-home( 2901): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.example] Name[forpet] Icon[/opt/usr/apps/org.example.example/shared/res/1.jpg] enable[1] system[0]
05-22 17:42:55.419+0900 D/cluster-home( 2901): mainmenu-presenter.cpp: OnAppUpdated(337) >  pAppId [org.example.example]
05-22 17:42:55.419+0900 D/cluster-home( 2901): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.example
05-22 17:42:55.419+0900 D/cluster-home( 2901): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[18], isFolder[0], pageId[1], col[4], row[4], appId[org.example.example], name[forpet], menuId[1], isPreload[0] isPreload[0]
05-22 17:42:55.419+0900 D/cluster-home( 2901): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
05-22 17:42:55.419+0900 E/cluster-home( 2901): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.example] Name[forpet] Icon[/opt/usr/apps/org.example.example/shared/res/1.jpg] enable[1] system[0]
05-22 17:42:55.419+0900 D/cluster-home( 2901): mainmenu-presenter.cpp: OnAppUpdated(364) >  name [forpet]
05-22 17:42:55.419+0900 D/cluster-home( 2901): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
05-22 17:42:55.419+0900 D/cluster-home( 2901): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
05-22 17:42:55.419+0900 D/test-log( 2901): mainmenu-box-impl.cpp: UpdateBoxData(812) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.example/shared/res/1.jpg], New icon path[/opt/usr/apps/org.example.example/shared/res/1.jpg]!!!!!
05-22 17:42:55.419+0900 D/cluster-home( 2901): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 1, appId = $appId, name = $name, col = 4, row = 4, isPreload = 0, isSystem = 0 WHERE boxId = 18]
05-22 17:42:56.219+0900 D/AUL_AMD ( 2766): amd_request.c: __request_handler(838) > __request_handler: 0
05-22 17:42:56.219+0900 D/AUL_AMD ( 2766): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
05-22 17:42:56.219+0900 D/PKGMGR_INFO( 2766): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
05-22 17:42:56.219+0900 D/PKGMGR_INFO( 2766): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
05-22 17:42:56.229+0900 I/AUL     ( 2766): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
05-22 17:42:56.229+0900 D/AUL     ( 2766): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 3367, pid = 3369
05-22 17:42:56.229+0900 D/PKGMGR_INFO( 2766): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
05-22 17:42:56.229+0900 D/PKGMGR_INFO( 2766): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
05-22 17:42:56.229+0900 I/AUL     ( 2766): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
05-22 17:42:56.229+0900 E/AUL_AMD ( 2766): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
05-22 17:42:56.229+0900 W/AUL_AMD ( 2766): amd_launch.c: _start_app(2233) > caller pid : 3369
05-22 17:42:56.229+0900 E/AUL_AMD ( 2766): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
05-22 17:42:56.229+0900 W/AUL_AMD ( 2766): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
05-22 17:42:56.229+0900 D/AUL_AMD ( 2766): amd_launch.c: _start_app(2648) > process_pool: false
05-22 17:42:56.229+0900 D/AUL_AMD ( 2766): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
05-22 17:42:56.229+0900 D/AUL_AMD ( 2766): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
05-22 17:42:56.229+0900 W/AUL_AMD ( 2766): amd_launch.c: _start_app(2665) > pad pid(-5)
05-22 17:42:56.229+0900 D/AUL_AMD ( 2766): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
05-22 17:42:56.229+0900 D/AUL_AMD ( 2766): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
05-22 17:42:56.229+0900 D/AUL     ( 2766): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
05-22 17:42:56.229+0900 D/AUL_PAD ( 2962): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
05-22 17:42:56.229+0900 D/AUL_PAD ( 2962): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
05-22 17:42:56.229+0900 D/AUL_PAD ( 2962): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-22 17:42:56.229+0900 D/AUL_PAD ( 2962): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-22 17:42:56.229+0900 D/AUL_PAD ( 2962): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-22 17:42:56.229+0900 D/AUL_PAD ( 2962): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-22 17:42:56.229+0900 D/AUL_PAD ( 2962): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-22 17:42:56.229+0900 D/AUL_PAD ( 2962): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
05-22 17:42:56.229+0900 D/AUL_PAD ( 2962): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
05-22 17:42:56.229+0900 D/AUL_PAD ( 2962): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
05-22 17:42:56.229+0900 D/AUL_PAD ( 2962): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
05-22 17:42:56.229+0900 D/AUL_PAD ( 2962): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
05-22 17:42:56.229+0900 D/AUL_PAD ( 2962): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
05-22 17:42:56.229+0900 D/AUL_PAD ( 2962): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
05-22 17:42:56.229+0900 W/AUL_PAD ( 2962): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
05-22 17:42:56.229+0900 D/AUL     ( 2962): process_pool.c: __send_pkt_raw_data(219) > send(13) : 620 / 620
05-22 17:42:56.229+0900 D/AUL_PAD ( 2962): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 2967, bin path: /opt/usr/apps/org.example.example/bin/example
05-22 17:42:56.229+0900 W/AUL_PAD ( 2962): launchpad.c: __send_result_to_caller(265) > Check app launching
05-22 17:42:56.229+0900 D/AUL_PAD ( 2962): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
05-22 17:42:56.229+0900 D/RESOURCED( 2888): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
05-22 17:42:56.229+0900 D/AUL_PAD ( 2967): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
05-22 17:42:56.229+0900 D/RESOURCED( 2888): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
05-22 17:42:56.229+0900 D/AUL_PAD ( 2967): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
05-22 17:42:56.229+0900 E/RESOURCED( 2888): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
05-22 17:42:56.229+0900 D/AUL_PAD ( 2967): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
05-22 17:42:56.229+0900 D/AUL_PAD ( 2967): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
05-22 17:42:56.229+0900 D/AUL_PAD ( 2967): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
05-22 17:42:56.229+0900 D/AUL_PAD ( 2967): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
05-22 17:42:56.229+0900 D/AUL     ( 2967): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (3071) is sent.
05-22 17:42:56.229+0900 D/AUL     ( 2967): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 3071, signo: 10
05-22 17:42:56.229+0900 D/AUL     ( 2967): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
05-22 17:42:56.229+0900 D/AUL_PAD ( 2967): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
05-22 17:42:56.229+0900 D/AUL_PAD ( 2967): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
05-22 17:42:56.229+0900 D/AUL_PAD ( 2967): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
05-22 17:42:56.229+0900 D/AUL_PAD ( 2967): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
05-22 17:42:56.229+0900 D/AUL_PAD ( 2967): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTU0NDI1NzYvMjI1MDIyAA==##
05-22 17:42:56.229+0900 D/AUL_PAD ( 2967): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
05-22 17:42:56.229+0900 D/AUL_PAD ( 2967): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAAzMzY5AA==##
05-22 17:42:56.229+0900 D/AUL_PAD ( 2967): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
05-22 17:42:56.229+0900 D/AUL_PAD ( 2967): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
05-22 17:42:56.229+0900 D/AUL_PAD ( 2967): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
05-22 17:42:56.229+0900 D/AUL_PAD ( 2967): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
05-22 17:42:56.229+0900 D/AUL_PAD ( 2967): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
05-22 17:42:56.239+0900 I/CAPI_APPFW_APPLICATION( 2967): app_main.c: ui_app_main(788) > app_efl_main
05-22 17:42:56.239+0900 D/LAUNCH  ( 2967): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
05-22 17:42:56.239+0900 D/APP_CORE( 2967): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
05-22 17:42:56.239+0900 D/APP_CORE( 2967): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
05-22 17:42:56.239+0900 D/APP_CORE( 2967): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
05-22 17:42:56.249+0900 D/APP_CORE( 2967): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
05-22 17:42:56.249+0900 D/AUL     ( 2967): app_sock.c: __create_server_sock(156) > pg path - already exists
05-22 17:42:56.249+0900 D/APP_CORE( 2967): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb4223520
05-22 17:42:56.249+0900 D/LAUNCH  ( 2967): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
05-22 17:42:56.249+0900 I/CAPI_APPFW_APPLICATION( 2967): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
05-22 17:42:56.329+0900 D/AUL_PAD ( 2962): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
05-22 17:42:56.329+0900 W/AUL     ( 2766): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 2967, appid: org.example.example
05-22 17:42:56.329+0900 D/AUL     ( 2766): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
05-22 17:42:56.329+0900 E/AUL     ( 2766): simple_util.c: __trm_app_info_send_socket(330) > access
05-22 17:42:56.329+0900 D/AUL_AMD ( 2766): amd_launch.c: _start_app(2700) > add app group info
05-22 17:42:56.329+0900 E/AUL     ( 2766): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
05-22 17:42:56.339+0900 D/AUL_AMD ( 2766): amd_status.c: _status_add_app_info_list(427) > pid(2967) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
05-22 17:42:56.339+0900 D/RESOURCED( 2888): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 2967
05-22 17:42:56.339+0900 D/RESOURCED( 2888): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
05-22 17:42:56.339+0900 E/RESOURCED( 2888): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
05-22 17:42:56.339+0900 D/RESOURCED( 2888): proc-main.c: resourced_proc_status_change(888) > available memory = 306
05-22 17:42:56.359+0900 D/LAUNCH  ( 2967): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
05-22 17:42:56.359+0900 D/APP_CORE( 2967): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
05-22 17:42:56.359+0900 E/E17     ( 2781): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02600002)
05-22 17:42:56.429+0900 E/E17     ( 2781): e_border.c: e_border_show(2088) > BD_SHOW(0x02600002)
05-22 17:42:56.429+0900 D/APP_CORE( 2967): appcore.c: __aul_handler(587) > [APP 2967]     AUL event: AUL_START
05-22 17:42:56.429+0900 I/APP_CORE( 2967): appcore-efl.c: __do_app(496) > [APP 2967] Event: RESET State: CREATED
05-22 17:42:56.429+0900 D/APP_CORE( 2967): appcore-efl.c: __do_app(527) > [APP 2967] RESET
05-22 17:42:56.429+0900 D/LAUNCH  ( 2967): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
05-22 17:42:56.429+0900 D/APP_CORE( 2967): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
05-22 17:42:56.429+0900 D/APP_CORE( 2967): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-22 17:42:56.429+0900 I/CAPI_APPFW_APPLICATION( 2967): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
05-22 17:42:56.429+0900 D/AUL     ( 2967): service.c: __set_bundle(186) > __set_bundle
05-22 17:42:56.429+0900 D/LAUNCH  ( 2967): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
05-22 17:42:56.429+0900 D/APP_CORE( 2967): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
05-22 17:42:56.429+0900 E/EFL     ( 2967): edje<2967> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-22 17:42:56.429+0900 E/EFL     ( 2967): By the power of Grayskull, your previous Embryo stack is now broken!
05-22 17:42:56.429+0900 E/EFL     ( 2967): edje<2967> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-22 17:42:56.429+0900 E/EFL     ( 2967): By the power of Grayskull, your previous Embryo stack is now broken!
05-22 17:42:56.429+0900 E/EFL     ( 2967): edje<2967> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-22 17:42:56.429+0900 E/EFL     ( 2967): By the power of Grayskull, your previous Embryo stack is now broken!
05-22 17:42:56.429+0900 E/EFL     ( 2967): edje<2967> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-22 17:42:56.429+0900 E/EFL     ( 2967): By the power of Grayskull, your previous Embryo stack is now broken!
05-22 17:42:56.429+0900 E/EFL     ( 2967): edje<2967> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-22 17:42:56.429+0900 E/EFL     ( 2967): By the power of Grayskull, your previous Embryo stack is now broken!
05-22 17:42:56.469+0900 W/PROCESSMGR( 2781): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=2967
05-22 17:42:56.499+0900 D/rpm-installer( 3316): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
05-22 17:42:56.499+0900 D/rpm-installer( 3316): rpm-appcore-intf.c: main(259) > ------------------------------------------------
05-22 17:42:56.499+0900 D/rpm-installer( 3316): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
05-22 17:42:56.499+0900 D/rpm-installer( 3316): rpm-appcore-intf.c: main(261) > ------------------------------------------------
05-22 17:42:56.499+0900 D/PKGMGR_SERVER( 3313): pkgmgr-server.c: sighandler(387) > child exit [3316]
05-22 17:42:56.499+0900 E/PKGMGR_SERVER( 3313): pkgmgr-server.c: sighandler(402) > child NORMAL exit [3316]
05-22 17:42:56.519+0900 E/EFL     ( 2781): eo<2781> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-22 17:42:56.519+0900 E/EFL     ( 2781): eo<2781> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-22 17:42:56.559+0900 D/AUL_AMD ( 2766): amd_request.c: __request_handler(838) > __request_handler: 15
05-22 17:42:56.559+0900 D/PKGMGR_INFO( 2766): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-22 17:42:56.559+0900 D/PKGMGR_INFO( 2766): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-22 17:42:56.559+0900 D/AUL_AMD ( 2766): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 2967 is org.example.example
05-22 17:42:56.559+0900 D/AUL_AMD ( 2766): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 2967 : 0
05-22 17:42:56.559+0900 D/AUL     ( 2982): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
05-22 17:42:56.559+0900 D/INDICATOR( 2893): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
05-22 17:42:56.559+0900 D/INDICATOR( 2893): util.c: util_signal_emit_by_win(116) > emission bg.opaque
05-22 17:42:56.569+0900 D/INDICATOR( 2893): main.c: _rotate_window(229) > Indicator angle is 0 degree
05-22 17:42:56.569+0900 D/INDICATOR( 2893): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
05-22 17:42:56.569+0900 D/INDICATOR( 2893): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
05-22 17:42:56.569+0900 D/INDICATOR( 2893): main.c: _rotate_window(252) > port :: hide more icon
05-22 17:42:56.639+0900 I/CAPI_NETWORK_CONNECTION( 3143): connection.c: connection_destroy(426) > Destroy handle: 0xb8e9b300
05-22 17:42:56.639+0900 I/CAPI_NETWORK_CONNECTION( 3143): connection.c: __connection_set_type_changed_callback(175) > Successfully de-registered(0)
05-22 17:42:56.659+0900 D/APP_CORE( 2967): appcore.c: __prt_ltime(236) > [APP 2967] first idle after reset: 440 msec
05-22 17:42:56.669+0900 W/APP_CORE( 2967): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2600002
05-22 17:42:56.669+0900 D/APP_CORE( 2967): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2600002
05-22 17:42:56.669+0900 D/APP_CORE( 2967): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
05-22 17:42:56.669+0900 D/AUL     ( 2967): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
05-22 17:42:56.709+0900 D/AUL_AMD ( 2766): amd_request.c: __request_handler(838) > __request_handler: 34
05-22 17:42:56.999+0900 E/PKGMGR_SERVER( 3313): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
05-22 17:42:56.999+0900 E/PKGMGR_SERVER( 3313): pkgmgr-server.c: main(2265) > package manager server terminated.
05-22 17:42:57.039+0900 E/EFL     ( 2781): evas-software_x11<2781> modules/evas/engines/software_x11/evas_xlib_dri_image.c:157 _drm_init() Not supported by DRI2 version(1.4)
05-22 17:42:57.169+0900 E/E17     ( 2781): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
05-22 17:42:57.179+0900 D/APP_CORE( 2967): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2600002 fully_obscured 0
05-22 17:42:57.179+0900 D/APP_CORE( 2967): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
05-22 17:42:57.179+0900 D/APP_CORE( 2967): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
05-22 17:42:57.179+0900 I/APP_CORE( 2967): appcore-efl.c: __do_app(496) > [APP 2967] Event: RESUME State: CREATED
05-22 17:42:57.179+0900 D/LAUNCH  ( 2967): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
05-22 17:42:57.179+0900 D/APP_CORE( 2967): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
05-22 17:42:57.179+0900 D/APP_CORE( 2967): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-22 17:42:57.179+0900 D/APP_CORE( 2967): appcore-efl.c: __do_app(607) > [APP 2967] RESUME
05-22 17:42:57.179+0900 D/APP_CORE( 2901): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
05-22 17:42:57.179+0900 D/APP_CORE( 2901): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
05-22 17:42:57.179+0900 D/APP_CORE( 2901): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
05-22 17:42:57.179+0900 I/APP_CORE( 2901): appcore-efl.c: __do_app(496) > [APP 2901] Event: PAUSE State: RUNNING
05-22 17:42:57.179+0900 D/APP_CORE( 2901): appcore-efl.c: __do_app(565) > [APP 2901] PAUSE
05-22 17:42:57.179+0900 I/CAPI_APPFW_APPLICATION( 2901): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
05-22 17:42:57.179+0900 E/cluster-home( 2901): homescreen.cpp: OnPause(84) >  app pause
05-22 17:42:57.179+0900 D/cluster-view( 2901): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
05-22 17:42:57.179+0900 D/cluster-view( 2901): homescreen-view-manager.cpp: AppPause(923) >  END
05-22 17:42:57.179+0900 D/APP_CORE( 2901): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-22 17:42:57.179+0900 E/APP_CORE( 2901): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-22 17:42:57.179+0900 I/APP_CORE( 2967): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
05-22 17:42:57.179+0900 I/APP_CORE( 2967): appcore-efl.c: __do_app(614) > [APP 2967] Initial Launching, call the resume_cb
05-22 17:42:57.179+0900 I/CAPI_APPFW_APPLICATION( 2967): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
05-22 17:42:57.179+0900 D/LAUNCH  ( 2967): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
05-22 17:42:57.179+0900 D/LAUNCH  ( 2967): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
05-22 17:42:57.179+0900 D/APP_CORE( 2967): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-22 17:42:57.179+0900 E/APP_CORE( 2967): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-22 17:42:57.179+0900 D/AUL_AMD ( 2766): amd_status.c: _status_update_app_info_list(456) > pid(2901) status(4)
05-22 17:42:57.179+0900 D/AUL_AMD ( 2766): amd_status.c: _status_update_app_info_list(468) > pid(2901) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
05-22 17:42:57.179+0900 D/AUL     ( 2766): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
05-22 17:42:57.179+0900 W/AUL     ( 2766): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2901, appid: org.tizen.homescreen, status: bg
05-22 17:42:57.189+0900 D/DATA_PROVIDER_MASTER( 2966): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2901 is paused
05-22 17:42:57.189+0900 D/DATA_PROVIDER_MASTER( 2966): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
05-22 17:42:57.189+0900 I/CAPI_WIDGET_APPLICATION( 3057): widget_app.c: __provider_pause_cb(294) > widget obj was paused
05-22 17:42:57.189+0900 I/CAPI_WIDGET_APPLICATION( 3057): widget_app.c: __check_status_for_cgroup(142) > enter background group
05-22 17:42:57.189+0900 W/AUL     ( 3057): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3057, appid: org.tizen.calendar.widget, status: bg
05-22 17:42:57.189+0900 D/RESOURCED( 2888): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3057, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
05-22 17:42:57.189+0900 D/RESOURCED( 2888): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3057
05-22 17:42:57.189+0900 D/AUL_AMD ( 2766): amd_launch.c: __e17_status_handler(2891) > pid(2967) status(3)
05-22 17:42:57.189+0900 D/AUL_AMD ( 2766): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
05-22 17:42:57.239+0900 W/AUL_AMD ( 2766): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-22 17:42:57.239+0900 W/AUL_AMD ( 2766): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
05-22 17:42:57.239+0900 D/AUL_AMD ( 2766): amd_status.c: _status_update_app_info_list(456) > pid(2967) status(3)
05-22 17:42:57.239+0900 D/AUL_AMD ( 2766): amd_status.c: _status_update_app_info_list(468) > pid(2967) appid(org.example.example) pkgid(org.example.example) status(3)
05-22 17:42:57.239+0900 D/AUL     ( 2766): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
05-22 17:42:57.239+0900 W/AUL     ( 2766): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2967, appid: org.example.example, status: fg
05-22 17:42:57.269+0900 D/RESOURCED( 2888): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3057, appname = org.tizen.calendar.widget
05-22 17:42:57.269+0900 D/RESOURCED( 2888): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3057
05-22 17:42:57.269+0900 D/RESOURCED( 2888): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2967
05-22 17:42:57.269+0900 D/RESOURCED( 2888): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 2967, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
05-22 17:42:57.269+0900 D/RESOURCED( 2888): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 2967
05-22 17:42:57.329+0900 D/RESOURCED( 2888): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 2967, appname = org.example.example, pkgname = org.example.example
05-22 17:42:57.329+0900 D/RESOURCED( 2888): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2967, appname = org.example.example
05-22 17:42:57.329+0900 D/RESOURCED( 2888): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2967
05-22 17:42:57.339+0900 I/RESOURCED( 2888): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
05-22 17:42:57.339+0900 I/RESOURCED( 2888): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
05-22 17:42:57.339+0900 D/AUL_PAD ( 2962): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
05-22 17:42:57.339+0900 D/AUL_PAD ( 3377): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
05-22 17:42:57.339+0900 D/AUL_AMD ( 2766): amd_launch.c: __e17_status_handler(2910) > pid(2967) status(0)
05-22 17:42:57.359+0900 D/AUL_PAD ( 2962): sigchild.h: __send_app_launch_signal(131) > send launch signal done
05-22 17:42:57.359+0900 E/RESOURCED( 2888): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.148
05-22 17:42:57.839+0900 D/AUL_AMD ( 2766): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
05-22 17:42:57.839+0900 D/RUA     ( 2766): rua.c: rua_add_history(179) > rua_add_history start
05-22 17:42:57.929+0900 D/RUA     ( 2766): rua.c: rua_add_history(247) > rua_add_history ok
05-22 17:42:58.399+0900 D/AUL_PAD ( 3377): launchpad_loader.c: main(588) > sleeping 1 sec...
05-22 17:42:58.399+0900 D/AUL_PAD ( 3377): preload.h: __preload_init(52) > max_cmdline_size = 1053
05-22 17:42:58.449+0900 D/AUL_PAD ( 3377): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b8c11760
05-22 17:42:58.449+0900 D/AUL_PAD ( 3377): preload.h: __preload_init(69) > get pre-initialization function
05-22 17:42:58.449+0900 D/AUL_PAD ( 3377): preload.h: __preload_init(73) > get shutdown function
05-22 17:42:58.449+0900 D/AUL_PAD ( 3377): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b8c11a40
05-22 17:42:58.489+0900 D/AUL_PAD ( 3377): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b8c13640
05-22 17:42:58.489+0900 D/AUL_PAD ( 3377): preload.h: __preload_init(69) > get pre-initialization function
05-22 17:42:58.489+0900 D/AUL_PAD ( 3377): preload.h: __preload_init(73) > get shutdown function
05-22 17:42:58.489+0900 D/AUL_PAD ( 3377): preexec.h: __preexec_init(76) > preexec start
05-22 17:42:58.489+0900 D/AUL_PAD ( 3377): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
05-22 17:42:58.489+0900 D/AUL     ( 3377): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
05-22 17:42:58.489+0900 D/AUL     ( 3377): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
05-22 17:42:58.489+0900 D/AUL_PAD ( 2962): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-22 17:42:58.489+0900 D/AUL_PAD ( 2962): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
05-22 17:42:58.489+0900 D/AUL_PAD ( 2962): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-22 17:42:58.489+0900 D/AUL_PAD ( 2962): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-22 17:42:58.489+0900 D/AUL_PAD ( 2962): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-22 17:42:58.489+0900 D/AUL_PAD ( 2962): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-22 17:42:58.489+0900 D/AUL_PAD ( 2962): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-22 17:42:58.489+0900 D/AUL_PAD ( 2962): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
05-22 17:42:58.489+0900 D/AUL_PAD ( 2962): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 3377
05-22 17:42:58.489+0900 D/AUL     ( 3377): process_pool.c: __connect_to_launchpad(132) > send(3377) : 4
05-22 17:42:58.489+0900 D/AUL     ( 3377): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
05-22 17:42:58.759+0900 D/AUL_PAD ( 3377): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
05-22 17:42:58.759+0900 D/AUL_PAD ( 3377): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
05-22 17:42:58.759+0900 D/AUL_PAD ( 3377): launchpad_loader.c: main(693) > [candidate] ecore handler add
05-22 17:42:58.769+0900 D/AUL_PAD ( 3377): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
05-22 17:42:58.789+0900 W/CRASH_MANAGER( 2989): worker.c: worker_job(1204) > 1102967657861149544257
