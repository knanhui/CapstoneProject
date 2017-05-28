S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 8757
Date: 2017-04-02 22:28:07+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x4

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb94304a0, esi = 0x8000341b
ebp = 0xbfa08748, esp = 0xbfa08730
eax = 0xb3803000, ebx = 0xb3803000
ecx = 0x00000000, edx = 0x00000000
eip = 0xb37ffb12

Memory Information
MemTotal:      123 KB
MemFree:        32 KB
Buffers:         4 KB
Cached:     164804 KB
VmPeak:      99068 KB
VmSize:      99068 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21684 KB
VmRSS:       21684 KB
VmData:      32688 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33320 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 8757 TID = 8757
8757 8759 8938 8939 

Maps Information
b2ce5000 b2cef000 r-xp /usr/lib/libfeedback.so.0.1.4
b2cf5000 b2d01000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2d02000 b2d23000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2d28000 b2d29000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2d2a000 b2d2f000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2d30000 b2d31000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2d32000 b2d34000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2d35000 b2d37000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2d38000 b2d44000 r-xp /usr/lib/libdrm.so.2.4.0
b2d45000 b2d48000 r-xp /usr/lib/libdri2.so.0.0.0
b2d49000 b2d53000 r-xp /usr/lib/libtbm.so.1.0.0
b2d5a000 b2d5b000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2d5c000 b2d5d000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2d5e000 b2d61000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b2d62000 b2d65000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b2d66000 b2d7b000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2d7c000 b2d8e000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3697000 b369d000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b369e000 b37e2000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37f2000 b37f3000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37f4000 b37fd000 r-xp /usr/lib/libefl-extension.so.0.1.0
b37fe000 b3802000 r-xp /opt/usr/apps/org.example.example/bin/example
b3804000 b383d000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4240000 b424b000 r-xp /lib/libnss_files-2.20-2014.11.so
b424d000 b4258000 r-xp /lib/libnss_nis-2.20-2014.11.so
b425a000 b4271000 r-xp /lib/libnsl-2.20-2014.11.so
b4275000 b427d000 r-xp /lib/libnss_compat-2.20-2014.11.so
b427f000 b42a3000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b42a4000 b42a5000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b42a6000 b42a9000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42aa000 b42b1000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42b2000 b42bc000 r-xp /usr/lib/libsensord-share.so
b42bd000 b42d9000 r-xp /usr/lib/libsensor.so.1.2.0
b42db000 b42e4000 r-xp /usr/lib/libappcore-common.so.1.1
b42e7000 b42e9000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42fe000 b4300000 r-xp /usr/lib/libXau.so.6.0.0
b4301000 b4323000 r-xp /usr/lib/libxcb.so.1.1.0
b4325000 b432e000 r-xp /lib/libcrypt-2.20-2014.11.so
b4357000 b4359000 r-xp /usr/lib/libiri.so
b435a000 b4380000 r-xp /lib/libexpat.so.1.5.2
b4382000 b43ed000 r-xp /usr/lib/libssl.so.1.0.0
b43f3000 b43ff000 r-xp /usr/lib/libethumb.so.1.13.0
b4400000 b4404000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4405000 b4656000 r-xp /usr/lib/libcrypto.so.1.0.0
b5bd1000 b5be1000 r-xp /usr/lib/libXi.so.6.1.0
b5be2000 b5be4000 r-xp /usr/lib/libXgesture.so.7.0.0
b5be5000 b5beb000 r-xp /usr/lib/libXtst.so.6.1.0
b5bec000 b5bf6000 r-xp /usr/lib/libXrender.so.1.3.0
b5bf7000 b5c00000 r-xp /usr/lib/libXrandr.so.2.2.0
b5c02000 b5c04000 r-xp /usr/lib/libXinerama.so.1.0.0
b5c05000 b5c0a000 r-xp /usr/lib/libXfixes.so.3.1.0
b5c0b000 b5c1d000 r-xp /usr/lib/libXext.so.6.4.0
b5c1e000 b5c20000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c21000 b5c23000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c25000 b5d67000 r-xp /usr/lib/libX11.so.6.3.0
b5d6b000 b5d75000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d76000 b5d8c000 r-xp /usr/lib/libudev.so.1.6.0
b5d8f000 b5d93000 r-xp /lib/libattr.so.1.1.0
b5d94000 b5dc3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5dc5000 b5dcb000 r-xp /usr/lib/libffi.so.6.0.2
b5dcc000 b5def000 r-xp /lib/libz.so.1.2.8
b5df0000 b5df3000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5df4000 b5f50000 r-xp /usr/lib/libxml2.so.2.9.2
b5f56000 b603d000 r-xp /usr/lib/libstdc++.so.6.0.20
b604a000 b604d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b604e000 b6070000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6071000 b6085000 r-xp /lib/libresolv-2.20-2014.11.so
b6089000 b60ad000 r-xp /usr/lib/liblzma.so.5.0.3
b60ae000 b60b0000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b60b2000 b60bc000 r-xp /usr/lib/libembryo.so.1.13.0
b60bd000 b60e6000 r-xp /usr/lib/libpng12.so.0.50.0
b60e7000 b6130000 r-xp /usr/lib/libjpeg.so.8.0.2
b6141000 b6148000 r-xp /lib/librt-2.20-2014.11.so
b614a000 b6169000 r-xp /usr/lib/libector.so.1.13.0
b616c000 b6199000 r-xp /usr/lib/liblua-5.1.so
b619a000 b622a000 r-xp /usr/lib/libfreetype.so.6.11.3
b622e000 b626c000 r-xp /usr/lib/libfontconfig.so.1.8.0
b626d000 b6283000 r-xp /usr/lib/libfribidi.so.0.3.1
b6284000 b62dd000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62e0000 b632b000 r-xp /lib/libm-2.20-2014.11.so
b632d000 b633f000 r-xp /usr/lib/libeio.so.1.13.0
b6340000 b6343000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6344000 b634a000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b634b000 b636e000 r-xp /usr/lib/libefreet.so.1.13.0
b6371000 b639c000 r-xp /usr/lib/libeldbus.so.1.13.0
b639d000 b63d1000 r-xp /usr/lib/libecore_con.so.1.13.0
b63d3000 b63dc000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63dd000 b63e6000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63e7000 b63fa000 r-xp /usr/lib/libeo.so.1.13.0
b63fc000 b640f000 r-xp /usr/lib/libecore_input.so.1.13.0
b6410000 b6417000 r-xp /usr/lib/libecore_file.so.1.13.0
b6418000 b643b000 r-xp /usr/lib/libecore_evas.so.1.13.0
b643c000 b6468000 r-xp /usr/lib/libeet.so.1.13.0
b6471000 b64dc000 r-xp /usr/lib/libeina.so.1.13.0
b64df000 b64f6000 r-xp /usr/lib/libefl.so.1.13.0
b64f8000 b665f000 r-xp /usr/lib/libicuuc.so.51.1
b666d000 b6879000 r-xp /usr/lib/libicui18n.so.51.1
b6881000 b68d0000 r-xp /usr/lib/libecore_x.so.1.13.0
b68d2000 b68ec000 r-xp /lib/libgcc_s-4.9.so.1
b68ee000 b68f2000 r-xp /lib/libcap.so.2.21
b68f3000 b6939000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b693a000 b6941000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6943000 b6995000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6997000 b6b22000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b27000 b6bf5000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bf8000 b6bfc000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bfd000 b6c0c000 r-xp /usr/lib/libvconf.so.0.2.45
b6c0d000 b6c10000 r-xp /usr/lib/libvasum.so.0.3.1
b6c11000 b6c14000 r-xp /usr/lib/libttrace.so.1.1
b6c16000 b6c1a000 r-xp /usr/lib/libiniparser.so.0
b6c1b000 b6c4b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c4c000 b6c55000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c56000 b6c7b000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c7c000 b6c8c000 r-xp /usr/lib/libunwind.so.8.0.1
b6c96000 b6e44000 r-xp /lib/libc-2.20-2014.11.so
b6e4c000 b6f8f000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f91000 b6fe9000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fea000 b701e000 r-xp /usr/lib/libsystemd.so.0.4.0
b7021000 b70f5000 r-xp /usr/lib/libedje.so.1.13.0
b70f8000 b7124000 r-xp /usr/lib/libecore.so.1.13.0
b7135000 b735b000 r-xp /usr/lib/libevas.so.1.13.0
b7383000 b739b000 r-xp /lib/libpthread-2.20-2014.11.so
b739f000 b7719000 r-xp /usr/lib/libelementary.so.1.13.0
b7739000 b773d000 r-xp /usr/lib/libsmack.so.1.0.0
b773e000 b7747000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7748000 b774b000 r-xp /usr/lib/libdlog.so.0.0.0
b774c000 b7751000 r-xp /usr/lib/libbundle.so.0.1.22
b7752000 b7755000 r-xp /lib/libdl-2.20-2014.11.so
b7757000 b777c000 r-xp /usr/lib/libaul.so.0.1.0
b777f000 b7781000 r-xp /usr/lib/libappsvc.so.0.1.0
b7782000 b7787000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7788000 b778f000 r-xp /usr/lib/libappcore-efl.so.1.1
b7791000 b7796000 r-xp /usr/lib/libsys-assert.so
b7799000 b779a000 r-xp [vdso]
b779a000 b77bc000 r-xp /lib/ld-2.20-2014.11.so
b77be000 b77c6000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:8757)
Call Stack Count: 19
 0: set_button_text + 0x22 (0xb37ffb12) [/opt/usr/apps/org.example.example/bin/example] + 0x1b12
 1: on_btn2_cb + 0x4d (0xb3800a5d) [/opt/usr/apps/org.example.example/bin/example] + 0x2a5d
 2: (0xb7169449) [/usr/lib/libevas.so.1] + 0x34449
 3: (0xb63f5319) [/usr/lib/libeo.so.1] + 0xe319
 4: eo_event_callback_call + 0xb3 (0xb63f2d63) [/usr/lib/libeo.so.1] + 0xbd63
 5: (0xb7169a62) [/usr/lib/libevas.so.1] + 0x34a62
 6: (0xb7178e49) [/usr/lib/libevas.so.1] + 0x43e49
 7: evas_canvas_event_feed_mouse_up + 0xcf (0xb71820af) [/usr/lib/libevas.so.1] + 0x4d0af
 8: evas_event_feed_mouse_up + 0x6a (0xb7188b8a) [/usr/lib/libevas.so.1] + 0x53b8a
 9: (0xb4402535) [/usr/lib/libecore_input_evas.so.1] + 0x2535
10: (0xb7105055) [/usr/lib/libecore.so.1] + 0xd055
11: (0xb710e1b9) [/usr/lib/libecore.so.1] + 0x161b9
12: ecore_main_loop_begin + 0x57 (0xb710e587) [/usr/lib/libecore.so.1] + 0x16587
13: elm_run + 0x2d (0xb756722d) [/usr/lib/libelementary.so.1] + 0x1c822d
14: appcore_efl_main + 0x4de (0xb778bdde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
15: ui_app_main + 0x140 (0xb7784c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
16: main + 0x27e (0xb37ffdee) [/opt/usr/apps/org.example.example/bin/example] + 0x1dee
17: create_base_gui + 0x138 (0xb77c0148) [/opt/usr/apps/org.example.example/bin/example] + 0xb77c0148
18: __libc_start_main + 0xde (0xb6cade4e) [/lib/libc.so.6] + 0x17e4e
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
0 D/PKGMGR  ( 8882): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.install.progress), signal_name(install_progress)
04-02 22:27:57.196+0900 D/rpm-installer( 8882): coretpk-installer.c: _coretpk_installer_package_reinstall(5096) > _coretpk_installer_package_reinstall(org.example.example) is done.
04-02 22:27:57.196+0900 D/PKGMGR  ( 8882): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(8882), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
04-02 22:27:57.196+0900 D/PKGMGR  ( 8882): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(8882), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
04-02 22:27:57.196+0900 D/PKGMGR  ( 8882): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
04-02 22:27:57.196+0900 D/PKGMGR_INSTALLER( 8882): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.example] key[end] value[ok]
04-02 22:27:57.196+0900 D/PKGMGR  ( 8882): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(8882), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
04-02 22:27:57.196+0900 D/PKGMGR  ( 8882): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(8882), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
04-02 22:27:57.196+0900 D/PKGMGR  ( 8882): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.upgrade), signal_name(upgrade)
04-02 22:27:57.196+0900 D/PKGMGR  ( 2922): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_46212117], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-02 22:27:57.196+0900 D/DATA_PROVIDER_MASTER( 2922): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.example] 100
04-02 22:27:57.196+0900 D/PKGMGR  ( 2769): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[upgrade], req_id=[org.example.example_46212117], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 22:27:57.196+0900 D/AUL_AMD ( 2769): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.example), key(end), value(ok)
04-02 22:27:57.196+0900 W/AUL_AMD ( 2769): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(update), value(ok)
04-02 22:27:57.196+0900 D/PKGMGR  ( 3029): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_46212117], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-02 22:27:57.196+0900 D/PKGMGR  ( 2942): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_46212117], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-02 22:27:57.196+0900 D/ESD     ( 2942): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29420002), pkg_type(tpk), pkgid(org.example.example), key(install_percent), val(100)
04-02 22:27:57.196+0900 D/PKGMGR  ( 2940): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_46212117], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-02 22:27:57.196+0900 D/QUICKPANEL( 2940): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:install_percent val:100
04-02 22:27:57.196+0900 D/PKGMGR  ( 2940): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_46212117], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 22:27:57.196+0900 D/QUICKPANEL( 2940): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:end val:ok
04-02 22:27:57.196+0900 D/PKGMGR  ( 2951): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_46212117], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-02 22:27:57.196+0900 D/PKGMGR  ( 2951): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
04-02 22:27:57.196+0900 D/PKGMGR  ( 2951): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_46212117], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 22:27:57.196+0900 D/PKGMGR  ( 2951): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
04-02 22:27:57.196+0900 D/PKGMGR  ( 8880): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_46212117], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-02 22:27:57.206+0900 D/PKGMGR  ( 2944): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_46212117], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-02 22:27:57.206+0900 D/PKGMGR  ( 2944): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_46212117], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 22:27:57.206+0900 D/AUL_AMD ( 2769): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.example, type:rpm
04-02 22:27:57.206+0900 D/PKGMGR  ( 3091): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_46212117], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-02 22:27:57.206+0900 D/PKGMGR  ( 3091): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_46212117], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 22:27:57.206+0900 D/PKGMGR  ( 8880): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_46212117], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 22:27:57.216+0900 D/PKGMGR  ( 2922): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_46212117], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 22:27:57.216+0900 D/DATA_PROVIDER_MASTER( 2922): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.example] ok
04-02 22:27:57.216+0900 D/DATA_PROVIDER_MASTER( 2922): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.example], event_type[1]
04-02 22:27:57.216+0900 D/PKGMGR  ( 3029): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_46212117], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 22:27:57.216+0900 D/ISF_PANEL_EFL( 3029): isf_panel_efl.cpp: _package_manager_event_cb(1288) > type=tpk package=org.example.example event_type=UPDATE event_state=COMPLETED progress=100 error=0
04-02 22:27:57.216+0900 D/DATA_PROVIDER_MASTER( 2922): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
04-02 22:27:57.216+0900 D/PKGMGR  ( 2870): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_46212117], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-02 22:27:57.216+0900 W/cluster-home( 2870): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.example]
04-02 22:27:57.216+0900 D/PKGMGR  ( 2870): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_46212117], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-02 22:27:57.216+0900 D/cluster-home( 2870): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[28700003] pkg_type[tpk] package[org.example.example] key[install_percent] val[100] pmsg[(null)]
04-02 22:27:57.216+0900 D/PKGMGR  ( 2870): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_46212117], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 22:27:57.216+0900 W/cluster-home( 2870): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[2], package[org.example.example]
04-02 22:27:57.216+0900 D/cluster-home( 2870): widget-data-provider.cpp: PackageUpdated(2160) >  No boxes that pkgname is[org.example.example]
04-02 22:27:57.216+0900 D/PKGMGR  ( 2870): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_46212117], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 22:27:57.216+0900 D/cluster-home( 2870): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[28700003] pkg_type[tpk] package[org.example.example] key[end] val[ok] pmsg[(null)]
04-02 22:27:57.216+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
04-02 22:27:57.216+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
04-02 22:27:57.216+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
04-02 22:27:57.216+0900 D/PKGMGR  ( 2942): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_46212117], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 22:27:57.216+0900 D/ESD     ( 2942): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29420002), pkg_type(tpk), pkgid(org.example.example), key(end), val(ok)
04-02 22:27:57.216+0900 D/ESD     ( 2942): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
04-02 22:27:57.216+0900 D/cluster-home( 2870): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
04-02 22:27:57.216+0900 D/cluster-home( 2870): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.example]
04-02 22:27:57.216+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.example]
04-02 22:27:57.216+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.example]
04-02 22:27:57.216+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
04-02 22:27:57.216+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
04-02 22:27:57.216+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.example]
04-02 22:27:57.226+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.example] Name[example] Icon[/opt/usr/apps/org.example.example/shared/res/example.png] enable[1] system[0]
04-02 22:27:57.226+0900 D/cluster-home( 2870): mainmenu-presenter.cpp: OnAppUpdated(337) >  pAppId [org.example.example]
04-02 22:27:57.226+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.example
04-02 22:27:57.226+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[13], isFolder[0], pageId[1], col[1], row[4], appId[org.example.example], name[example], menuId[1], isPreload[0] isPreload[0]
04-02 22:27:57.226+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
04-02 22:27:57.226+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.example] Name[example] Icon[/opt/usr/apps/org.example.example/shared/res/example.png] enable[1] system[0]
04-02 22:27:57.226+0900 D/cluster-home( 2870): mainmenu-presenter.cpp: OnAppUpdated(364) >  name [example]
04-02 22:27:57.226+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
04-02 22:27:57.226+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
04-02 22:27:57.226+0900 D/test-log( 2870): mainmenu-box-impl.cpp: UpdateBoxData(812) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.example/shared/res/example.png], New icon path[/opt/usr/apps/org.example.example/shared/res/example.png]!!!!!
04-02 22:27:57.226+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 1, appId = $appId, name = $name, col = 1, row = 4, isPreload = 0, isSystem = 0 WHERE boxId = 13]
04-02 22:27:57.226+0900 D/DATA_PROVIDER_MASTER( 2922): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
04-02 22:27:57.226+0900 D/DATA_PROVIDER_MASTER( 2922): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
04-02 22:27:57.226+0900 D/DATA_PROVIDER_MASTER( 2922): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.example]
04-02 22:27:57.226+0900 W/ISF_PANEL_EFL( 3029): isf_panel_efl.cpp: _package_manager_event_cb(1380) > isf_db_select_appids_by_pkgid returned 0.
04-02 22:27:57.466+0900 D/rpm-installer( 8882): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
04-02 22:27:57.466+0900 D/rpm-installer( 8882): rpm-appcore-intf.c: main(259) > ------------------------------------------------
04-02 22:27:57.466+0900 D/rpm-installer( 8882): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
04-02 22:27:57.466+0900 D/rpm-installer( 8882): rpm-appcore-intf.c: main(261) > ------------------------------------------------
04-02 22:27:57.466+0900 D/PKGMGR_SERVER( 8793): pkgmgr-server.c: sighandler(387) > child exit [8882]
04-02 22:27:57.466+0900 E/PKGMGR_SERVER( 8793): pkgmgr-server.c: sighandler(402) > child NORMAL exit [8882]
04-02 22:27:57.876+0900 D/AUL_AMD ( 2769): amd_request.c: __request_handler(838) > __request_handler: 0
04-02 22:27:57.876+0900 D/AUL_AMD ( 2769): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
04-02 22:27:57.876+0900 D/PKGMGR_INFO( 2769): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
04-02 22:27:57.876+0900 D/PKGMGR_INFO( 2769): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
04-02 22:27:57.896+0900 I/AUL     ( 2769): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
04-02 22:27:57.896+0900 D/AUL     ( 2769): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 8932, pid = 8934
04-02 22:27:57.896+0900 D/PKGMGR_INFO( 2769): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
04-02 22:27:57.896+0900 D/PKGMGR_INFO( 2769): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
04-02 22:27:57.896+0900 I/AUL     ( 2769): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
04-02 22:27:57.896+0900 E/AUL_AMD ( 2769): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
04-02 22:27:57.896+0900 W/AUL_AMD ( 2769): amd_launch.c: _start_app(2233) > caller pid : 8934
04-02 22:27:57.896+0900 E/AUL_AMD ( 2769): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
04-02 22:27:57.896+0900 W/AUL_AMD ( 2769): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
04-02 22:27:57.896+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2648) > process_pool: false
04-02 22:27:57.896+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
04-02 22:27:57.896+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
04-02 22:27:57.896+0900 W/AUL_AMD ( 2769): amd_launch.c: _start_app(2665) > pad pid(-5)
04-02 22:27:57.896+0900 D/AUL_AMD ( 2769): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
04-02 22:27:57.896+0900 D/AUL_AMD ( 2769): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
04-02 22:27:57.896+0900 D/AUL     ( 2769): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
04-02 22:27:57.896+0900 D/AUL_PAD ( 2920): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
04-02 22:27:57.896+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
04-02 22:27:57.896+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
04-02 22:27:57.896+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
04-02 22:27:57.896+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
04-02 22:27:57.896+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
04-02 22:27:57.896+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
04-02 22:27:57.896+0900 D/AUL_PAD ( 2920): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
04-02 22:27:57.896+0900 D/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
04-02 22:27:57.896+0900 D/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
04-02 22:27:57.896+0900 D/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
04-02 22:27:57.896+0900 D/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
04-02 22:27:57.896+0900 D/AUL_PAD ( 2920): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
04-02 22:27:57.896+0900 D/AUL_PAD ( 2920): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
04-02 22:27:57.896+0900 W/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
04-02 22:27:57.896+0900 D/AUL     ( 2920): process_pool.c: __send_pkt_raw_data(219) > send(13) : 620 / 620
04-02 22:27:57.896+0900 D/RESOURCED( 2852): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
04-02 22:27:57.896+0900 D/AUL_PAD ( 2920): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 8757, bin path: /opt/usr/apps/org.example.example/bin/example
04-02 22:27:57.896+0900 D/RESOURCED( 2852): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
04-02 22:27:57.896+0900 W/AUL_PAD ( 2920): launchpad.c: __send_result_to_caller(265) > Check app launching
04-02 22:27:57.896+0900 D/AUL_PAD ( 2920): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
04-02 22:27:57.896+0900 E/RESOURCED( 2852): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-02 22:27:57.906+0900 D/AUL_PAD ( 8757): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
04-02 22:27:57.906+0900 D/AUL_PAD ( 8757): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
04-02 22:27:57.906+0900 D/AUL_PAD ( 8757): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
04-02 22:27:57.906+0900 D/AUL_PAD ( 8757): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
04-02 22:27:57.906+0900 D/AUL_PAD ( 8757): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
04-02 22:27:57.906+0900 D/AUL_PAD ( 8757): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
04-02 22:27:57.906+0900 D/AUL     ( 8757): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (8759) is sent.
04-02 22:27:57.906+0900 D/AUL     ( 8757): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 8759, signo: 10
04-02 22:27:57.906+0900 D/AUL     ( 8757): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
04-02 22:27:57.906+0900 D/AUL_PAD ( 8757): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
04-02 22:27:57.906+0900 D/AUL_PAD ( 8757): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
04-02 22:27:57.906+0900 D/AUL_PAD ( 8757): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
04-02 22:27:57.906+0900 D/AUL_PAD ( 8757): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
04-02 22:27:57.906+0900 D/AUL_PAD ( 8757): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTExMzk2NzcvOTAzNDkwAA==##
04-02 22:27:57.906+0900 D/AUL_PAD ( 8757): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
04-02 22:27:57.906+0900 D/AUL_PAD ( 8757): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA4OTM0AA==##
04-02 22:27:57.906+0900 D/AUL_PAD ( 8757): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
04-02 22:27:57.906+0900 D/AUL_PAD ( 8757): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
04-02 22:27:57.906+0900 D/AUL_PAD ( 8757): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
04-02 22:27:57.906+0900 D/AUL_PAD ( 8757): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
04-02 22:27:57.906+0900 D/AUL_PAD ( 8757): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
04-02 22:27:57.906+0900 I/CAPI_APPFW_APPLICATION( 8757): app_main.c: ui_app_main(788) > app_efl_main
04-02 22:27:57.906+0900 D/LAUNCH  ( 8757): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
04-02 22:27:57.906+0900 D/APP_CORE( 8757): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
04-02 22:27:57.906+0900 D/APP_CORE( 8757): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
04-02 22:27:57.906+0900 D/APP_CORE( 8757): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
04-02 22:27:57.926+0900 D/APP_CORE( 8757): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
04-02 22:27:57.926+0900 D/AUL     ( 8757): app_sock.c: __create_server_sock(156) > pg path - already exists
04-02 22:27:57.926+0900 D/APP_CORE( 8757): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42e4520
04-02 22:27:57.926+0900 D/LAUNCH  ( 8757): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
04-02 22:27:57.926+0900 I/CAPI_APPFW_APPLICATION( 8757): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
04-02 22:27:57.976+0900 D/LAUNCH  ( 8757): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
04-02 22:27:57.976+0900 D/APP_CORE( 8757): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
04-02 22:27:57.976+0900 E/E17     ( 2697): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02800002)
04-02 22:27:57.976+0900 D/APP_CORE( 8757): appcore.c: __aul_handler(587) > [APP 8757]     AUL event: AUL_START
04-02 22:27:57.976+0900 I/APP_CORE( 8757): appcore-efl.c: __do_app(496) > [APP 8757] Event: RESET State: CREATED
04-02 22:27:57.976+0900 D/APP_CORE( 8757): appcore-efl.c: __do_app(527) > [APP 8757] RESET
04-02 22:27:57.976+0900 D/LAUNCH  ( 8757): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
04-02 22:27:57.976+0900 D/APP_CORE( 8757): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
04-02 22:27:57.976+0900 D/APP_CORE( 8757): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
04-02 22:27:57.976+0900 I/CAPI_APPFW_APPLICATION( 8757): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
04-02 22:27:57.976+0900 D/AUL     ( 8757): service.c: __set_bundle(186) > __set_bundle
04-02 22:27:57.976+0900 D/LAUNCH  ( 8757): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
04-02 22:27:57.976+0900 D/APP_CORE( 8757): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
04-02 22:27:57.976+0900 E/EFL     ( 8757): edje<8757> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
04-02 22:27:57.976+0900 E/EFL     ( 8757): By the power of Grayskull, your previous Embryo stack is now broken!
04-02 22:27:57.976+0900 E/E17     ( 2697): e_border.c: e_border_show(2088) > BD_SHOW(0x02800002)
04-02 22:27:57.976+0900 E/EFL     ( 8757): edje<8757> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
04-02 22:27:57.976+0900 E/EFL     ( 8757): By the power of Grayskull, your previous Embryo stack is now broken!
04-02 22:27:57.976+0900 E/EFL     ( 8757): edje<8757> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
04-02 22:27:57.976+0900 E/EFL     ( 8757): By the power of Grayskull, your previous Embryo stack is now broken!
04-02 22:27:57.976+0900 E/EFL     ( 8757): edje<8757> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
04-02 22:27:57.976+0900 E/EFL     ( 8757): By the power of Grayskull, your previous Embryo stack is now broken!
04-02 22:27:57.976+0900 E/EFL     ( 8757): edje<8757> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
04-02 22:27:57.976+0900 E/EFL     ( 8757): By the power of Grayskull, your previous Embryo stack is now broken!
04-02 22:27:57.976+0900 W/PROCESSMGR( 2697): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=8757
04-02 22:27:57.996+0900 E/EFL     ( 2697): eo<2697> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
04-02 22:27:57.996+0900 E/EFL     ( 2697): eo<2697> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
04-02 22:27:57.996+0900 D/INDICATOR( 2855): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
04-02 22:27:57.996+0900 D/INDICATOR( 2855): util.c: util_signal_emit_by_win(116) > emission bg.opaque
04-02 22:27:57.996+0900 D/INDICATOR( 2855): main.c: _rotate_window(229) > Indicator angle is 0 degree
04-02 22:27:57.996+0900 D/INDICATOR( 2855): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
04-02 22:27:57.996+0900 D/INDICATOR( 2855): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
04-02 22:27:57.996+0900 D/INDICATOR( 2855): main.c: _rotate_window(252) > port :: hide more icon
04-02 22:27:58.016+0900 D/AUL_PAD ( 2920): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
04-02 22:27:58.016+0900 W/AUL     ( 2769): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 8757, appid: org.example.example
04-02 22:27:58.016+0900 D/AUL     ( 2769): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
04-02 22:27:58.016+0900 E/AUL     ( 2769): simple_util.c: __trm_app_info_send_socket(330) > access
04-02 22:27:58.016+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2700) > add app group info
04-02 22:27:58.016+0900 E/AUL     ( 2769): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
04-02 22:27:58.016+0900 D/AUL_AMD ( 2769): amd_status.c: _status_add_app_info_list(427) > pid(8757) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
04-02 22:27:58.016+0900 D/AUL_AMD ( 2769): amd_request.c: __request_handler(838) > __request_handler: 15
04-02 22:27:58.016+0900 D/PKGMGR_INFO( 2769): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
04-02 22:27:58.016+0900 D/PKGMGR_INFO( 2769): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
04-02 22:27:58.016+0900 D/RESOURCED( 2852): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 8757
04-02 22:27:58.016+0900 D/RESOURCED( 2852): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
04-02 22:27:58.016+0900 E/RESOURCED( 2852): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
04-02 22:27:58.016+0900 D/RESOURCED( 2852): proc-main.c: resourced_proc_status_change(888) > available memory = 306
04-02 22:27:58.016+0900 D/AUL_AMD ( 2769): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 8757 is org.example.example
04-02 22:27:58.016+0900 D/AUL_AMD ( 2769): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 8757 : 0
04-02 22:27:58.016+0900 D/AUL     ( 2944): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
04-02 22:27:58.096+0900 D/APP_CORE( 8757): appcore.c: __prt_ltime(236) > [APP 8757] first idle after reset: 202 msec
04-02 22:27:58.096+0900 W/APP_CORE( 8757): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2800002
04-02 22:27:58.096+0900 D/APP_CORE( 8757): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2800002
04-02 22:27:58.096+0900 D/APP_CORE( 8757): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
04-02 22:27:58.096+0900 D/AUL     ( 8757): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
04-02 22:27:58.096+0900 D/AUL_AMD ( 2769): amd_request.c: __request_handler(838) > __request_handler: 34
04-02 22:27:58.266+0900 E/E17     ( 2697): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
04-02 22:27:58.266+0900 D/APP_CORE( 8757): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2800002 fully_obscured 0
04-02 22:27:58.266+0900 D/APP_CORE( 8757): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
04-02 22:27:58.266+0900 D/APP_CORE( 8757): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
04-02 22:27:58.266+0900 I/APP_CORE( 8757): appcore-efl.c: __do_app(496) > [APP 8757] Event: RESUME State: CREATED
04-02 22:27:58.266+0900 D/LAUNCH  ( 8757): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
04-02 22:27:58.266+0900 D/APP_CORE( 8757): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
04-02 22:27:58.266+0900 D/APP_CORE( 8757): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
04-02 22:27:58.266+0900 D/APP_CORE( 8757): appcore-efl.c: __do_app(607) > [APP 8757] RESUME
04-02 22:27:58.266+0900 I/APP_CORE( 8757): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
04-02 22:27:58.266+0900 I/APP_CORE( 8757): appcore-efl.c: __do_app(614) > [APP 8757] Initial Launching, call the resume_cb
04-02 22:27:58.266+0900 I/CAPI_APPFW_APPLICATION( 8757): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
04-02 22:27:58.266+0900 D/LAUNCH  ( 8757): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
04-02 22:27:58.266+0900 D/LAUNCH  ( 8757): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
04-02 22:27:58.266+0900 D/APP_CORE( 8757): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
04-02 22:27:58.266+0900 E/APP_CORE( 8757): appcore-efl.c: __trm_app_info_send_socket(242) > access
04-02 22:27:58.266+0900 D/APP_CORE( 2870): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
04-02 22:27:58.266+0900 D/APP_CORE( 2870): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
04-02 22:27:58.266+0900 D/APP_CORE( 2870): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
04-02 22:27:58.266+0900 I/APP_CORE( 2870): appcore-efl.c: __do_app(496) > [APP 2870] Event: PAUSE State: RUNNING
04-02 22:27:58.266+0900 D/APP_CORE( 2870): appcore-efl.c: __do_app(565) > [APP 2870] PAUSE
04-02 22:27:58.266+0900 I/CAPI_APPFW_APPLICATION( 2870): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
04-02 22:27:58.266+0900 E/cluster-home( 2870): homescreen.cpp: OnPause(84) >  app pause
04-02 22:27:58.266+0900 D/cluster-view( 2870): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
04-02 22:27:58.266+0900 D/cluster-view( 2870): homescreen-view-manager.cpp: AppPause(923) >  END
04-02 22:27:58.266+0900 D/APP_CORE( 2870): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
04-02 22:27:58.266+0900 E/APP_CORE( 2870): appcore-efl.c: __trm_app_info_send_socket(242) > access
04-02 22:27:58.266+0900 D/AUL_AMD ( 2769): amd_status.c: _status_update_app_info_list(456) > pid(2870) status(4)
04-02 22:27:58.266+0900 D/AUL_AMD ( 2769): amd_status.c: _status_update_app_info_list(468) > pid(2870) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
04-02 22:27:58.266+0900 D/AUL     ( 2769): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
04-02 22:27:58.266+0900 W/AUL     ( 2769): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2870, appid: org.tizen.homescreen, status: bg
04-02 22:27:58.266+0900 D/AUL_AMD ( 2769): amd_launch.c: __e17_status_handler(2891) > pid(8757) status(3)
04-02 22:27:58.266+0900 D/AUL_AMD ( 2769): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
04-02 22:27:58.266+0900 W/AUL_AMD ( 2769): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-02 22:27:58.266+0900 W/AUL_AMD ( 2769): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
04-02 22:27:58.266+0900 D/AUL_AMD ( 2769): amd_status.c: _status_update_app_info_list(456) > pid(8757) status(3)
04-02 22:27:58.266+0900 D/AUL_AMD ( 2769): amd_status.c: _status_update_app_info_list(468) > pid(8757) appid(org.example.example) pkgid(org.example.example) status(3)
04-02 22:27:58.266+0900 D/AUL     ( 2769): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
04-02 22:27:58.266+0900 W/AUL     ( 2769): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 8757, appid: org.example.example, status: fg
04-02 22:27:58.266+0900 D/RESOURCED( 2852): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 8757
04-02 22:27:58.266+0900 D/RESOURCED( 2852): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 8757, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
04-02 22:27:58.266+0900 D/RESOURCED( 2852): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 8757
04-02 22:27:58.276+0900 D/DATA_PROVIDER_MASTER( 2922): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2870 is paused
04-02 22:27:58.276+0900 D/DATA_PROVIDER_MASTER( 2922): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
04-02 22:27:58.276+0900 I/CAPI_WIDGET_APPLICATION( 2999): widget_app.c: __provider_pause_cb(294) > widget obj was paused
04-02 22:27:58.276+0900 I/CAPI_WIDGET_APPLICATION( 2999): widget_app.c: __check_status_for_cgroup(142) > enter background group
04-02 22:27:58.276+0900 W/AUL     ( 2999): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2999, appid: org.tizen.calendar.widget, status: bg
04-02 22:27:58.376+0900 D/RESOURCED( 2852): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 8757, appname = org.example.example, pkgname = org.example.example
04-02 22:27:58.376+0900 D/RESOURCED( 2852): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 8757, appname = org.example.example
04-02 22:27:58.376+0900 D/RESOURCED( 2852): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 8757
04-02 22:27:58.376+0900 D/RESOURCED( 2852): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 2999, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
04-02 22:27:58.376+0900 D/RESOURCED( 2852): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 2999
04-02 22:27:58.376+0900 D/RESOURCED( 2852): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 2999, appname = org.tizen.calendar.widget
04-02 22:27:58.376+0900 D/RESOURCED( 2852): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 2999
04-02 22:27:58.376+0900 I/RESOURCED( 2852): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
04-02 22:27:58.376+0900 I/RESOURCED( 2852): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
04-02 22:27:58.416+0900 D/AUL_AMD ( 2769): amd_launch.c: __e17_status_handler(2910) > pid(8757) status(0)
04-02 22:27:59.006+0900 E/PKGMGR_SERVER( 8793): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-02 22:27:59.006+0900 E/PKGMGR_SERVER( 8793): pkgmgr-server.c: main(2265) > package manager server terminated.
04-02 22:27:59.016+0900 D/AUL_PAD ( 2920): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
04-02 22:27:59.026+0900 D/AUL_PAD ( 8942): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
04-02 22:27:59.066+0900 D/AUL_PAD ( 2920): sigchild.h: __send_app_launch_signal(131) > send launch signal done
04-02 22:27:59.066+0900 E/RESOURCED( 2852): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.604
04-02 22:27:59.536+0900 D/AUL_AMD ( 2769): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
04-02 22:27:59.536+0900 D/RUA     ( 2769): rua.c: rua_add_history(179) > rua_add_history start
04-02 22:27:59.536+0900 D/RUA     ( 2769): rua.c: rua_add_history(247) > rua_add_history ok
04-02 22:28:00.076+0900 D/AUL_PAD ( 8942): launchpad_loader.c: main(588) > sleeping 1 sec...
04-02 22:28:00.076+0900 D/AUL_PAD ( 8942): preload.h: __preload_init(52) > max_cmdline_size = 1053
04-02 22:28:00.076+0900 D/AUL_PAD ( 8942): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b9242760
04-02 22:28:00.076+0900 D/AUL_PAD ( 8942): preload.h: __preload_init(69) > get pre-initialization function
04-02 22:28:00.076+0900 D/AUL_PAD ( 8942): preload.h: __preload_init(73) > get shutdown function
04-02 22:28:00.076+0900 D/AUL_PAD ( 8942): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b9242a40
04-02 22:28:00.076+0900 D/AUL_PAD ( 8942): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b9244640
04-02 22:28:00.076+0900 D/AUL_PAD ( 8942): preload.h: __preload_init(69) > get pre-initialization function
04-02 22:28:00.076+0900 D/AUL_PAD ( 8942): preload.h: __preload_init(73) > get shutdown function
04-02 22:28:00.076+0900 D/AUL_PAD ( 8942): preexec.h: __preexec_init(76) > preexec start
04-02 22:28:00.076+0900 D/AUL_PAD ( 8942): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
04-02 22:28:00.076+0900 D/AUL     ( 8942): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
04-02 22:28:00.076+0900 D/AUL     ( 8942): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
04-02 22:28:00.106+0900 D/AUL_PAD ( 2920): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
04-02 22:28:00.106+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
04-02 22:28:00.106+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
04-02 22:28:00.106+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
04-02 22:28:00.106+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
04-02 22:28:00.106+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
04-02 22:28:00.106+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
04-02 22:28:00.106+0900 D/AUL_PAD ( 2920): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
04-02 22:28:00.106+0900 D/AUL_PAD ( 2920): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 8942
04-02 22:28:00.106+0900 D/AUL     ( 8942): process_pool.c: __connect_to_launchpad(132) > send(8942) : 4
04-02 22:28:00.106+0900 D/AUL     ( 8942): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
04-02 22:28:00.166+0900 D/AUL_PAD ( 8942): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
04-02 22:28:00.166+0900 D/AUL_PAD ( 8942): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
04-02 22:28:00.166+0900 D/AUL_PAD ( 8942): launchpad_loader.c: main(693) > [candidate] ecore handler add
04-02 22:28:00.176+0900 D/AUL_PAD ( 8942): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
04-02 22:28:00.516+0900 D/INDICATOR( 2855): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
04-02 22:28:00.516+0900 D/INDICATOR( 2855): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
04-02 22:28:00.516+0900 D/INDICATOR( 2855): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
04-02 22:28:00.516+0900 D/INDICATOR( 2855): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 10:28 5 h"
04-02 22:28:00.516+0900 D/INDICATOR( 2855): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 10:28"
04-02 22:28:00.516+0900 D/INDICATOR( 2855): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 10&#x2236;28"
04-02 22:28:00.516+0900 D/INDICATOR( 2855): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146810074 Time: <font_size=33>10&#x2236;28</font_size> <font_size=32>PM</font_size></font>
04-02 22:28:01.386+0900 D/AUL_AMD ( 2769): amd_status.c: __app_terminate_timer_cb(442) > pid(8531)
04-02 22:28:01.386+0900 W/AUL_AMD ( 2769): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
04-02 22:28:01.386+0900 D/AUL_AMD ( 2769): amd_status.c: __app_terminate_timer_cb(442) > pid(8531)
04-02 22:28:01.386+0900 W/AUL_AMD ( 2769): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
04-02 22:28:03.266+0900 D/APP_CORE( 2870): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
04-02 22:28:03.266+0900 I/APP_CORE( 2870): appcore-efl.c: __do_app(496) > [APP 2870] Event: MEM_FLUSH State: PAUSED
04-02 22:28:03.266+0900 D/APP_CORE( 2870): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
04-02 22:28:03.266+0900 D/APP_CORE( 2870): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2870
04-02 22:28:03.266+0900 D/APP_CORE( 2870): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
04-02 22:28:03.266+0900 D/RESOURCED( 2852): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2870
04-02 22:28:07.136+0900 D/PROCESSMGR( 2697): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x200c43 
04-02 22:28:07.156+0900 D/AUL_PAD ( 2920): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
04-02 22:28:07.156+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
04-02 22:28:07.156+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
04-02 22:28:07.156+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
04-02 22:28:07.156+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
04-02 22:28:07.156+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
04-02 22:28:07.156+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
04-02 22:28:07.156+0900 I/AUL_PAD ( 2920): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 8757 pgid = 8757
04-02 22:28:07.156+0900 I/AUL_PAD ( 2920): sigchild.h: __sigchild_action(142) > dead_pid(8757)
04-02 22:28:07.156+0900 E/EFL     ( 2697): eo<2697> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
04-02 22:28:07.166+0900 D/AUL_PAD ( 2920): sigchild.h: __send_app_dead_signal(90) > send dead signal done
04-02 22:28:07.166+0900 I/AUL_PAD ( 2920): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
04-02 22:28:07.166+0900 I/AUL_PAD ( 2920): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
04-02 22:28:07.166+0900 E/AUL_PAD ( 2920): launchpad.c: main(688) > error reading sigchld info
04-02 22:28:07.166+0900 W/CRASH_MANAGER( 8945): worker.c: worker_job(1204) > 1108757657861149113968
