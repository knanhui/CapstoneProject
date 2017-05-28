S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 20238
Date: 2017-05-09 14:02:05+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 2
      invalid permissions for mapped object
      si_addr = 0xb75d5f90

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb34acb06, esi = 0xb75d5f90
ebp = 0xbfb78f58, esp = 0xbfb78e00
eax = 0xb8a751e0, ebx = 0xb34b32f0
ecx = 0x00000000, edx = 0x0000000b
eip = 0xb34aa423

Memory Information
MemTotal:      123 KB
MemFree:        21 KB
Buffers:         7 KB
Cached:     178568 KB
VmPeak:     101444 KB
VmSize:     101444 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24024 KB
VmRSS:       24024 KB
VmData:      34800 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33568 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 20238 TID = 20238
20238 20239 20462 20463 

Maps Information
b2bfb000 b2c05000 r-xp /usr/lib/libfeedback.so.0.1.4
b2c0b000 b2c17000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2c18000 b2c39000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2c3e000 b2c3f000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2c40000 b2c45000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2c46000 b2c47000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2c48000 b2c4a000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c4b000 b2c57000 r-xp /usr/lib/libdrm.so.2.4.0
b2c58000 b2c62000 r-xp /usr/lib/libtbm.so.1.0.0
b2c63000 b2c78000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c79000 b2c8b000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b348d000 b3496000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3497000 b34a0000 r-xp /usr/lib/libefl-extension.so.0.1.0
b34a1000 b34b3000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34b4000 b34d5000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b34dc000 b34dd000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b34de000 b34df000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b34e0000 b34e3000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b34e4000 b34e7000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b35ef000 b35f5000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b35f6000 b373a000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b374a000 b374c000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b374d000 b3750000 r-xp /usr/lib/libdri2.so.0.0.0
b3751000 b3752000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b3753000 b3759000 r-xp /opt/usr/apps/org.example.example/bin/example
b375c000 b3795000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4198000 b41a3000 r-xp /lib/libnss_files-2.20-2014.11.so
b41a5000 b41b0000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41b2000 b41c9000 r-xp /lib/libnsl-2.20-2014.11.so
b41cd000 b41d5000 r-xp /lib/libnss_compat-2.20-2014.11.so
b41d7000 b41fb000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b41fc000 b41fd000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b41fe000 b4201000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4202000 b4209000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b420a000 b4214000 r-xp /usr/lib/libsensord-share.so
b4215000 b4231000 r-xp /usr/lib/libsensor.so.1.2.0
b4233000 b423c000 r-xp /usr/lib/libappcore-common.so.1.1
b423f000 b4241000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4256000 b4258000 r-xp /usr/lib/libXau.so.6.0.0
b4259000 b427b000 r-xp /usr/lib/libxcb.so.1.1.0
b427d000 b4286000 r-xp /lib/libcrypt-2.20-2014.11.so
b42af000 b42b1000 r-xp /usr/lib/libiri.so
b42b2000 b42d8000 r-xp /lib/libexpat.so.1.5.2
b42da000 b4345000 r-xp /usr/lib/libssl.so.1.0.0
b434b000 b4357000 r-xp /usr/lib/libethumb.so.1.13.0
b4358000 b435c000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b435d000 b45ae000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b29000 b5b39000 r-xp /usr/lib/libXi.so.6.1.0
b5b3a000 b5b3c000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b3d000 b5b43000 r-xp /usr/lib/libXtst.so.6.1.0
b5b44000 b5b4e000 r-xp /usr/lib/libXrender.so.1.3.0
b5b4f000 b5b58000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b5a000 b5b5c000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b5d000 b5b62000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b63000 b5b75000 r-xp /usr/lib/libXext.so.6.4.0
b5b76000 b5b78000 r-xp /usr/lib/libXdamage.so.1.1.0
b5b79000 b5b7b000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5b7d000 b5cbf000 r-xp /usr/lib/libX11.so.6.3.0
b5cc3000 b5ccd000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cce000 b5ce4000 r-xp /usr/lib/libudev.so.1.6.0
b5ce7000 b5ceb000 r-xp /lib/libattr.so.1.1.0
b5cec000 b5d1b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d1d000 b5d23000 r-xp /usr/lib/libffi.so.6.0.2
b5d24000 b5d47000 r-xp /lib/libz.so.1.2.8
b5d48000 b5d4b000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d4c000 b5ea8000 r-xp /usr/lib/libxml2.so.2.9.2
b5eae000 b5f95000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fa2000 b5fa5000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fa6000 b5fc8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5fc9000 b5fdd000 r-xp /lib/libresolv-2.20-2014.11.so
b5fe1000 b6005000 r-xp /usr/lib/liblzma.so.5.0.3
b6006000 b6008000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b600a000 b6014000 r-xp /usr/lib/libembryo.so.1.13.0
b6015000 b603e000 r-xp /usr/lib/libpng12.so.0.50.0
b603f000 b6088000 r-xp /usr/lib/libjpeg.so.8.0.2
b6099000 b60a0000 r-xp /lib/librt-2.20-2014.11.so
b60a2000 b60c1000 r-xp /usr/lib/libector.so.1.13.0
b60c4000 b60f1000 r-xp /usr/lib/liblua-5.1.so
b60f2000 b6182000 r-xp /usr/lib/libfreetype.so.6.11.3
b6186000 b61c4000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61c5000 b61db000 r-xp /usr/lib/libfribidi.so.0.3.1
b61dc000 b6235000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6238000 b6283000 r-xp /lib/libm-2.20-2014.11.so
b6285000 b6297000 r-xp /usr/lib/libeio.so.1.13.0
b6298000 b629b000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b629c000 b62a2000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62a3000 b62c6000 r-xp /usr/lib/libefreet.so.1.13.0
b62c9000 b62f4000 r-xp /usr/lib/libeldbus.so.1.13.0
b62f5000 b6329000 r-xp /usr/lib/libecore_con.so.1.13.0
b632b000 b6334000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6335000 b633e000 r-xp /usr/lib/libethumb_client.so.1.13.0
b633f000 b6352000 r-xp /usr/lib/libeo.so.1.13.0
b6354000 b6367000 r-xp /usr/lib/libecore_input.so.1.13.0
b6368000 b636f000 r-xp /usr/lib/libecore_file.so.1.13.0
b6370000 b6393000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6394000 b63c0000 r-xp /usr/lib/libeet.so.1.13.0
b63c9000 b6434000 r-xp /usr/lib/libeina.so.1.13.0
b6437000 b644e000 r-xp /usr/lib/libefl.so.1.13.0
b6450000 b65b7000 r-xp /usr/lib/libicuuc.so.51.1
b65c5000 b67d1000 r-xp /usr/lib/libicui18n.so.51.1
b67d9000 b6828000 r-xp /usr/lib/libecore_x.so.1.13.0
b682a000 b6844000 r-xp /lib/libgcc_s-4.9.so.1
b6846000 b684a000 r-xp /lib/libcap.so.2.21
b684b000 b6891000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6892000 b6899000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b689b000 b68ed000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b68ef000 b6a7a000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6a7f000 b6b4d000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b50000 b6b54000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b55000 b6b64000 r-xp /usr/lib/libvconf.so.0.2.45
b6b65000 b6b68000 r-xp /usr/lib/libvasum.so.0.3.1
b6b69000 b6b6c000 r-xp /usr/lib/libttrace.so.1.1
b6b6e000 b6b72000 r-xp /usr/lib/libiniparser.so.0
b6b73000 b6ba3000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6ba4000 b6bad000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bae000 b6bd3000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bd4000 b6be4000 r-xp /usr/lib/libunwind.so.8.0.1
b6bee000 b6d9c000 r-xp /lib/libc-2.20-2014.11.so
b6da4000 b6ee7000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6ee9000 b6f41000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f42000 b6f76000 r-xp /usr/lib/libsystemd.so.0.4.0
b6f79000 b704d000 r-xp /usr/lib/libedje.so.1.13.0
b7050000 b707c000 r-xp /usr/lib/libecore.so.1.13.0
b708d000 b72b3000 r-xp /usr/lib/libevas.so.1.13.0
b72db000 b72f3000 r-xp /lib/libpthread-2.20-2014.11.so
b72f7000 b7671000 r-xp /usr/lib/libelementary.so.1.13.0
b7691000 b7695000 r-xp /usr/lib/libsmack.so.1.0.0
b7696000 b769f000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76a0000 b76a3000 r-xp /usr/lib/libdlog.so.0.0.0
b76a4000 b76a9000 r-xp /usr/lib/libbundle.so.0.1.22
b76aa000 b76ad000 r-xp /lib/libdl-2.20-2014.11.so
b76af000 b76d4000 r-xp /usr/lib/libaul.so.0.1.0
b76d7000 b76d9000 r-xp /usr/lib/libappsvc.so.0.1.0
b76da000 b76df000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b76e0000 b76e7000 r-xp /usr/lib/libappcore-efl.so.1.1
b76e9000 b76ee000 r-xp /usr/lib/libsys-assert.so
b76f1000 b76f2000 r-xp [vdso]
b76f2000 b7714000 r-xp /lib/ld-2.20-2014.11.so
b7716000 b771e000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:20238)
Call Stack Count: 22
 0: system_setting_get_locale_timezone + 0x113 (0xb34aa423) [/usr/lib/libcapi-system-system-settings.so.0] + 0x9423
 1: system_settings_get_value + 0xb8 (0xb34a5418) [/usr/lib/libcapi-system-system-settings.so.0] + 0x4418
 2: system_settings_get_value_string + 0x80 (0xb34a5b70) [/usr/lib/libcapi-system-system-settings.so.0] + 0x4b70
 3: create_button_view + 0x488 (0xb37551f8) [/opt/usr/apps/org.example.example/bin/example] + 0x21f8
 4: diary_view_cb + 0x54 (0xb3754cb4) [/opt/usr/apps/org.example.example/bin/example] + 0x1cb4
 5: (0xb70c1449) [/usr/lib/libevas.so.1] + 0x34449
 6: (0xb634d319) [/usr/lib/libeo.so.1] + 0xe319
 7: eo_event_callback_call + 0xb3 (0xb634ad63) [/usr/lib/libeo.so.1] + 0xbd63
 8: (0xb70c1a62) [/usr/lib/libevas.so.1] + 0x34a62
 9: (0xb70d0441) [/usr/lib/libevas.so.1] + 0x43441
10: evas_canvas_event_feed_mouse_down + 0xcf (0xb70da20f) [/usr/lib/libevas.so.1] + 0x4d20f
11: evas_event_feed_mouse_down + 0x6a (0xb70e0c2a) [/usr/lib/libevas.so.1] + 0x53c2a
12: (0xb435a49c) [/usr/lib/libecore_input_evas.so.1] + 0x249c
13: (0xb705d055) [/usr/lib/libecore.so.1] + 0xd055
14: (0xb70661b9) [/usr/lib/libecore.so.1] + 0x161b9
15: ecore_main_loop_begin + 0x57 (0xb7066587) [/usr/lib/libecore.so.1] + 0x16587
16: elm_run + 0x2d (0xb74bf22d) [/usr/lib/libelementary.so.1] + 0x1c822d
17: appcore_efl_main + 0x4de (0xb76e3dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
18: ui_app_main + 0x140 (0xb76dcc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
19: main + 0x27e (0xb3756c1e) [/opt/usr/apps/org.example.example/bin/example] + 0x3c1e
20: create_button_view + 0x3d8 (0xb7718148) [/opt/usr/apps/org.example.example/bin/example] + 0xb7718148
21: __libc_start_main + 0xde (0xb6c05e4e) [/lib/libc.so.6] + 0x17e4e
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
8+0900 D/PKGMGR  (20403): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1097255377], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-09 14:01:59.138+0900 D/PKGMGR  (20403): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1097255377], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-09 14:01:59.138+0900 D/PKGMGR  ( 3033): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1097255377], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-09 14:01:59.138+0900 D/PKGMGR  ( 3082): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1097255377], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-09 14:01:59.138+0900 D/PKGMGR  ( 3033): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1097255377], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-09 14:01:59.138+0900 D/ISF_PANEL_EFL( 3033): isf_panel_efl.cpp: _package_manager_event_cb(1288) > type=tpk package=org.example.example event_type=UPDATE event_state=COMPLETED progress=100 error=0
05-09 14:01:59.148+0900 D/PKGMGR  ( 2962): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1097255377], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-09 14:01:59.148+0900 D/PKGMGR  ( 2962): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
05-09 14:01:59.148+0900 D/PKGMGR  ( 2962): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1097255377], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-09 14:01:59.148+0900 D/PKGMGR  ( 2962): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
05-09 14:01:59.148+0900 D/PKGMGR  ( 2938): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1097255377], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-09 14:01:59.148+0900 D/ESD     ( 2938): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29380002), pkg_type(tpk), pkgid(org.example.example), key(install_percent), val(100)
05-09 14:01:59.148+0900 W/ISF_PANEL_EFL( 3033): isf_panel_efl.cpp: _package_manager_event_cb(1380) > isf_db_select_appids_by_pkgid returned 0.
05-09 14:01:59.148+0900 D/PKGMGR  ( 2938): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1097255377], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-09 14:01:59.148+0900 D/ESD     ( 2938): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29380002), pkg_type(tpk), pkgid(org.example.example), key(end), val(ok)
05-09 14:01:59.148+0900 D/ESD     ( 2938): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
05-09 14:01:59.148+0900 D/PKGMGR  ( 2940): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1097255377], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-09 14:01:59.148+0900 D/PKGMGR  ( 2940): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1097255377], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-09 14:01:59.148+0900 D/PKGMGR  ( 2936): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1097255377], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-09 14:01:59.148+0900 D/QUICKPANEL( 2936): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:end val:ok
05-09 14:01:59.148+0900 D/PKGMGR  ( 2932): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1097255377], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-09 14:01:59.148+0900 D/DATA_PROVIDER_MASTER( 2932): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.example] 100
05-09 14:01:59.148+0900 D/PKGMGR  ( 2932): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1097255377], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-09 14:01:59.148+0900 D/DATA_PROVIDER_MASTER( 2932): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.example] ok
05-09 14:01:59.148+0900 D/DATA_PROVIDER_MASTER( 2932): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.example], event_type[1]
05-09 14:01:59.148+0900 D/DATA_PROVIDER_MASTER( 2932): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
05-09 14:01:59.148+0900 D/DATA_PROVIDER_MASTER( 2932): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
05-09 14:01:59.148+0900 D/DATA_PROVIDER_MASTER( 2932): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
05-09 14:01:59.148+0900 D/DATA_PROVIDER_MASTER( 2932): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.example]
05-09 14:01:59.148+0900 D/PKGMGR  ( 2878): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1097255377], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-09 14:01:59.148+0900 W/cluster-home( 2878): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.example]
05-09 14:01:59.148+0900 D/PKGMGR  ( 2878): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1097255377], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-09 14:01:59.148+0900 D/cluster-home( 2878): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[28780003] pkg_type[tpk] package[org.example.example] key[install_percent] val[100] pmsg[(null)]
05-09 14:01:59.148+0900 D/PKGMGR  ( 2878): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1097255377], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-09 14:01:59.148+0900 W/cluster-home( 2878): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[2], package[org.example.example]
05-09 14:01:59.148+0900 D/cluster-home( 2878): widget-data-provider.cpp: PackageUpdated(2160) >  No boxes that pkgname is[org.example.example]
05-09 14:01:59.148+0900 D/PKGMGR  ( 2878): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1097255377], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-09 14:01:59.148+0900 D/cluster-home( 2878): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[28780003] pkg_type[tpk] package[org.example.example] key[end] val[ok] pmsg[(null)]
05-09 14:01:59.148+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
05-09 14:01:59.148+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
05-09 14:01:59.148+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
05-09 14:01:59.148+0900 D/cluster-home( 2878): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
05-09 14:01:59.148+0900 D/cluster-home( 2878): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.example]
05-09 14:01:59.148+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.example]
05-09 14:01:59.148+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.example]
05-09 14:01:59.148+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
05-09 14:01:59.148+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
05-09 14:01:59.148+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.example]
05-09 14:01:59.148+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.example] Name[example] Icon[/opt/usr/apps/org.example.example/shared/res/example.png] enable[1] system[0]
05-09 14:01:59.158+0900 D/PKGMGR  ( 2763): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[upgrade], req_id=[org.example.example_1097255377], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-09 14:01:59.158+0900 D/AUL_AMD ( 2763): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.example), key(end), value(ok)
05-09 14:01:59.158+0900 W/AUL_AMD ( 2763): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(update), value(ok)
05-09 14:01:59.158+0900 D/AUL_AMD ( 2763): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.example, type:rpm
05-09 14:01:59.168+0900 D/cluster-home( 2878): mainmenu-presenter.cpp: OnAppUpdated(337) >  pAppId [org.example.example]
05-09 14:01:59.168+0900 D/cluster-home( 2878): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.example
05-09 14:01:59.168+0900 D/cluster-home( 2878): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[13], isFolder[0], pageId[1], col[1], row[4], appId[org.example.example], name[example], menuId[1], isPreload[0] isPreload[0]
05-09 14:01:59.168+0900 D/cluster-home( 2878): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
05-09 14:01:59.168+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.example] Name[example] Icon[/opt/usr/apps/org.example.example/shared/res/example.png] enable[1] system[0]
05-09 14:01:59.168+0900 D/cluster-home( 2878): mainmenu-presenter.cpp: OnAppUpdated(364) >  name [example]
05-09 14:01:59.168+0900 D/cluster-home( 2878): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
05-09 14:01:59.168+0900 D/cluster-home( 2878): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
05-09 14:01:59.168+0900 D/test-log( 2878): mainmenu-box-impl.cpp: UpdateBoxData(812) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.example/shared/res/example.png], New icon path[/opt/usr/apps/org.example.example/shared/res/example.png]!!!!!
05-09 14:01:59.168+0900 D/cluster-home( 2878): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 1, appId = $appId, name = $name, col = 1, row = 4, isPreload = 0, isSystem = 0 WHERE boxId = 13]
05-09 14:01:59.328+0900 D/rpm-installer(20405): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
05-09 14:01:59.328+0900 D/rpm-installer(20405): rpm-appcore-intf.c: main(259) > ------------------------------------------------
05-09 14:01:59.328+0900 D/rpm-installer(20405): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
05-09 14:01:59.328+0900 D/rpm-installer(20405): rpm-appcore-intf.c: main(261) > ------------------------------------------------
05-09 14:01:59.328+0900 D/PKGMGR_SERVER(20316): pkgmgr-server.c: sighandler(387) > child exit [20405]
05-09 14:01:59.328+0900 E/PKGMGR_SERVER(20316): pkgmgr-server.c: sighandler(402) > child NORMAL exit [20405]
05-09 14:01:59.998+0900 E/PKGMGR_SERVER(20316): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
05-09 14:01:59.998+0900 E/PKGMGR_SERVER(20316): pkgmgr-server.c: main(2265) > package manager server terminated.
05-09 14:02:00.108+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(838) > __request_handler: 0
05-09 14:02:00.118+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
05-09 14:02:00.118+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
05-09 14:02:00.118+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
05-09 14:02:00.118+0900 I/AUL     ( 2763): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
05-09 14:02:00.118+0900 D/AUL     ( 2763): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 20455, pid = 20457
05-09 14:02:00.118+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
05-09 14:02:00.118+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
05-09 14:02:00.128+0900 I/AUL     ( 2763): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
05-09 14:02:00.128+0900 E/AUL_AMD ( 2763): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
05-09 14:02:00.128+0900 W/AUL_AMD ( 2763): amd_launch.c: _start_app(2233) > caller pid : 20457
05-09 14:02:00.128+0900 E/AUL_AMD ( 2763): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
05-09 14:02:00.128+0900 W/AUL_AMD ( 2763): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
05-09 14:02:00.128+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2648) > process_pool: false
05-09 14:02:00.128+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
05-09 14:02:00.128+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
05-09 14:02:00.128+0900 W/AUL_AMD ( 2763): amd_launch.c: _start_app(2665) > pad pid(-5)
05-09 14:02:00.128+0900 D/AUL_AMD ( 2763): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
05-09 14:02:00.128+0900 D/AUL_AMD ( 2763): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
05-09 14:02:00.128+0900 D/AUL     ( 2763): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
05-09 14:02:00.128+0900 D/AUL_PAD ( 2926): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
05-09 14:02:00.128+0900 D/AUL_PAD ( 2926): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
05-09 14:02:00.128+0900 D/AUL_PAD ( 2926): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-09 14:02:00.128+0900 D/AUL_PAD ( 2926): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-09 14:02:00.128+0900 D/AUL_PAD ( 2926): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-09 14:02:00.128+0900 D/AUL_PAD ( 2926): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-09 14:02:00.128+0900 D/AUL_PAD ( 2926): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-09 14:02:00.128+0900 D/AUL_PAD ( 2926): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
05-09 14:02:00.128+0900 D/AUL_PAD ( 2926): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
05-09 14:02:00.128+0900 D/AUL_PAD ( 2926): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
05-09 14:02:00.128+0900 D/AUL_PAD ( 2926): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
05-09 14:02:00.128+0900 D/AUL_PAD ( 2926): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
05-09 14:02:00.128+0900 D/AUL_PAD ( 2926): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
05-09 14:02:00.128+0900 D/AUL_PAD ( 2926): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
05-09 14:02:00.128+0900 W/AUL_PAD ( 2926): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
05-09 14:02:00.128+0900 D/AUL     ( 2926): process_pool.c: __send_pkt_raw_data(219) > send(13) : 624 / 624
05-09 14:02:00.128+0900 D/AUL_PAD ( 2926): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 20238, bin path: /opt/usr/apps/org.example.example/bin/example
05-09 14:02:00.128+0900 W/AUL_PAD ( 2926): launchpad.c: __send_result_to_caller(265) > Check app launching
05-09 14:02:00.128+0900 D/AUL_PAD ( 2926): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
05-09 14:02:00.138+0900 D/RESOURCED( 2860): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
05-09 14:02:00.138+0900 D/RESOURCED( 2860): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 2
05-09 14:02:00.138+0900 E/RESOURCED( 2860): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
05-09 14:02:00.138+0900 D/AUL_PAD (20238): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
05-09 14:02:00.138+0900 D/AUL_PAD (20238): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
05-09 14:02:00.138+0900 D/AUL_PAD (20238): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
05-09 14:02:00.138+0900 D/AUL_PAD (20238): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
05-09 14:02:00.138+0900 D/AUL_PAD (20238): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
05-09 14:02:00.138+0900 D/AUL_PAD (20238): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
05-09 14:02:00.138+0900 D/AUL     (20238): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (20239) is sent.
05-09 14:02:00.148+0900 D/AUL     (20238): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 20239, signo: 10
05-09 14:02:00.148+0900 D/AUL     (20238): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
05-09 14:02:00.148+0900 D/AUL_PAD (20238): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
05-09 14:02:00.168+0900 D/AUL_PAD (20238): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
05-09 14:02:00.168+0900 D/AUL_PAD (20238): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
05-09 14:02:00.168+0900 D/AUL_PAD (20238): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
05-09 14:02:00.168+0900 D/AUL_PAD (20238): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTQzMDYxMjAvMTE2NDg4AA==##
05-09 14:02:00.168+0900 D/AUL_PAD (20238): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
05-09 14:02:00.168+0900 D/AUL_PAD (20238): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAyMDQ1NwA=##
05-09 14:02:00.168+0900 D/AUL_PAD (20238): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
05-09 14:02:00.168+0900 D/AUL_PAD (20238): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
05-09 14:02:00.168+0900 D/AUL_PAD (20238): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
05-09 14:02:00.168+0900 D/AUL_PAD (20238): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
05-09 14:02:00.168+0900 D/AUL_PAD (20238): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
05-09 14:02:00.178+0900 I/CAPI_APPFW_APPLICATION(20238): app_main.c: ui_app_main(788) > app_efl_main
05-09 14:02:00.178+0900 D/LAUNCH  (20238): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
05-09 14:02:00.178+0900 D/APP_CORE(20238): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
05-09 14:02:00.178+0900 D/APP_CORE(20238): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
05-09 14:02:00.178+0900 D/APP_CORE(20238): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
05-09 14:02:00.228+0900 D/APP_CORE(20238): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
05-09 14:02:00.228+0900 D/AUL     (20238): app_sock.c: __create_server_sock(156) > pg path - already exists
05-09 14:02:00.228+0900 D/APP_CORE(20238): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb423c520
05-09 14:02:00.228+0900 D/LAUNCH  (20238): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
05-09 14:02:00.228+0900 I/CAPI_APPFW_APPLICATION(20238): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
05-09 14:02:00.238+0900 D/AUL_PAD ( 2926): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
05-09 14:02:00.238+0900 W/AUL     ( 2763): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 20238, appid: org.example.example
05-09 14:02:00.238+0900 D/AUL     ( 2763): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
05-09 14:02:00.238+0900 E/AUL     ( 2763): simple_util.c: __trm_app_info_send_socket(330) > access
05-09 14:02:00.238+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2700) > add app group info
05-09 14:02:00.238+0900 E/AUL     ( 2763): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
05-09 14:02:00.238+0900 D/AUL_AMD ( 2763): amd_status.c: _status_add_app_info_list(427) > pid(20238) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
05-09 14:02:00.258+0900 D/RESOURCED( 2860): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 20238
05-09 14:02:00.258+0900 D/RESOURCED( 2860): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
05-09 14:02:00.258+0900 E/RESOURCED( 2860): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
05-09 14:02:00.258+0900 D/RESOURCED( 2860): proc-main.c: resourced_proc_status_change(888) > available memory = 297
05-09 14:02:00.458+0900 D/LAUNCH  (20238): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
05-09 14:02:00.468+0900 D/APP_CORE(20238): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
05-09 14:02:00.468+0900 E/E17     ( 2725): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x01200002)
05-09 14:02:00.548+0900 E/E17     ( 2725): e_border.c: e_border_show(2088) > BD_SHOW(0x01200002)
05-09 14:02:00.608+0900 W/PROCESSMGR( 2725): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=20238
05-09 14:02:00.618+0900 E/EFL     ( 2725): eo<2725> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-09 14:02:00.618+0900 E/EFL     ( 2725): eo<2725> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-09 14:02:00.618+0900 D/APP_CORE(20238): appcore.c: __aul_handler(587) > [APP 20238]     AUL event: AUL_START
05-09 14:02:00.618+0900 I/APP_CORE(20238): appcore-efl.c: __do_app(496) > [APP 20238] Event: RESET State: CREATED
05-09 14:02:00.618+0900 D/APP_CORE(20238): appcore-efl.c: __do_app(527) > [APP 20238] RESET
05-09 14:02:00.618+0900 D/LAUNCH  (20238): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
05-09 14:02:00.618+0900 D/APP_CORE(20238): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
05-09 14:02:00.618+0900 D/APP_CORE(20238): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-09 14:02:00.618+0900 I/CAPI_APPFW_APPLICATION(20238): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
05-09 14:02:00.618+0900 D/AUL     (20238): service.c: __set_bundle(186) > __set_bundle
05-09 14:02:00.628+0900 D/LAUNCH  (20238): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
05-09 14:02:00.628+0900 D/APP_CORE(20238): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
05-09 14:02:00.628+0900 E/EFL     (20238): edje<20238> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-09 14:02:00.628+0900 E/EFL     (20238): By the power of Grayskull, your previous Embryo stack is now broken!
05-09 14:02:00.628+0900 E/EFL     (20238): edje<20238> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-09 14:02:00.628+0900 E/EFL     (20238): By the power of Grayskull, your previous Embryo stack is now broken!
05-09 14:02:00.628+0900 E/EFL     (20238): edje<20238> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-09 14:02:00.628+0900 E/EFL     (20238): By the power of Grayskull, your previous Embryo stack is now broken!
05-09 14:02:00.628+0900 E/EFL     (20238): edje<20238> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-09 14:02:00.628+0900 E/EFL     (20238): By the power of Grayskull, your previous Embryo stack is now broken!
05-09 14:02:00.628+0900 E/EFL     (20238): edje<20238> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-09 14:02:00.628+0900 E/EFL     (20238): By the power of Grayskull, your previous Embryo stack is now broken!
05-09 14:02:00.658+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(838) > __request_handler: 15
05-09 14:02:00.658+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-09 14:02:00.658+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-09 14:02:00.658+0900 D/AUL_AMD ( 2763): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 20238 is org.example.example
05-09 14:02:00.658+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 20238 : 0
05-09 14:02:00.668+0900 D/AUL     ( 2940): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
05-09 14:02:00.668+0900 D/INDICATOR( 2864): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
05-09 14:02:00.678+0900 D/INDICATOR( 2864): util.c: util_signal_emit_by_win(116) > emission bg.opaque
05-09 14:02:00.678+0900 D/INDICATOR( 2864): main.c: _rotate_window(229) > Indicator angle is 0 degree
05-09 14:02:00.678+0900 D/INDICATOR( 2864): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
05-09 14:02:00.678+0900 D/INDICATOR( 2864): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
05-09 14:02:00.678+0900 D/INDICATOR( 2864): main.c: _rotate_window(252) > port :: hide more icon
05-09 14:02:00.688+0900 W/APP_CORE(20238): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1200002
05-09 14:02:00.688+0900 D/APP_CORE(20238): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:1200002
05-09 14:02:00.688+0900 D/APP_CORE(20238): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
05-09 14:02:00.688+0900 D/AUL     (20238): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
05-09 14:02:00.688+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(838) > __request_handler: 34
05-09 14:02:00.728+0900 D/INDICATOR( 2864): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
05-09 14:02:00.728+0900 D/INDICATOR( 2864): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
05-09 14:02:00.728+0900 D/INDICATOR( 2864): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
05-09 14:02:00.738+0900 D/INDICATOR( 2864): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 2:02 4 h"
05-09 14:02:00.738+0900 D/INDICATOR( 2864): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 2:02"
05-09 14:02:00.738+0900 D/INDICATOR( 2864): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 2&#x2236;02"
05-09 14:02:00.738+0900 D/INDICATOR( 2864): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146109823 Time: <font_size=33>2&#x2236;02</font_size> <font_size=32>PM</font_size></font>
05-09 14:02:00.978+0900 D/APP_CORE(20238): appcore.c: __prt_ltime(236) > [APP 20238] first idle after reset: 871 msec
05-09 14:02:01.018+0900 E/E17     ( 2725): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
05-09 14:02:01.018+0900 D/APP_CORE( 2878): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
05-09 14:02:01.018+0900 D/APP_CORE( 2878): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
05-09 14:02:01.018+0900 D/APP_CORE( 2878): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
05-09 14:02:01.018+0900 I/APP_CORE( 2878): appcore-efl.c: __do_app(496) > [APP 2878] Event: PAUSE State: RUNNING
05-09 14:02:01.018+0900 D/APP_CORE( 2878): appcore-efl.c: __do_app(565) > [APP 2878] PAUSE
05-09 14:02:01.018+0900 I/CAPI_APPFW_APPLICATION( 2878): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
05-09 14:02:01.018+0900 E/cluster-home( 2878): homescreen.cpp: OnPause(84) >  app pause
05-09 14:02:01.018+0900 D/cluster-view( 2878): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
05-09 14:02:01.018+0900 D/cluster-view( 2878): homescreen-view-manager.cpp: AppPause(923) >  END
05-09 14:02:01.018+0900 D/APP_CORE( 2878): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-09 14:02:01.018+0900 E/APP_CORE( 2878): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-09 14:02:01.018+0900 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(456) > pid(2878) status(4)
05-09 14:02:01.018+0900 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(468) > pid(2878) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
05-09 14:02:01.018+0900 D/AUL     ( 2763): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
05-09 14:02:01.018+0900 W/AUL     ( 2763): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2878, appid: org.tizen.homescreen, status: bg
05-09 14:02:01.028+0900 D/DATA_PROVIDER_MASTER( 2932): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2878 is paused
05-09 14:02:01.028+0900 D/DATA_PROVIDER_MASTER( 2932): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
05-09 14:02:01.038+0900 D/AUL_AMD ( 2763): amd_launch.c: __e17_status_handler(2891) > pid(20238) status(3)
05-09 14:02:01.038+0900 D/AUL_AMD ( 2763): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
05-09 14:02:01.038+0900 W/AUL_AMD ( 2763): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-09 14:02:01.038+0900 W/AUL_AMD ( 2763): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
05-09 14:02:01.038+0900 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(456) > pid(20238) status(3)
05-09 14:02:01.038+0900 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(468) > pid(20238) appid(org.example.example) pkgid(org.example.example) status(3)
05-09 14:02:01.038+0900 D/AUL     ( 2763): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
05-09 14:02:01.038+0900 W/AUL     ( 2763): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 20238, appid: org.example.example, status: fg
05-09 14:02:01.038+0900 I/CAPI_WIDGET_APPLICATION( 3017): widget_app.c: __provider_pause_cb(294) > widget obj was paused
05-09 14:02:01.038+0900 I/CAPI_WIDGET_APPLICATION( 3017): widget_app.c: __check_status_for_cgroup(142) > enter background group
05-09 14:02:01.038+0900 W/AUL     ( 3017): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3017, appid: org.tizen.calendar.widget, status: bg
05-09 14:02:01.038+0900 D/RESOURCED( 2860): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 20238
05-09 14:02:01.038+0900 D/RESOURCED( 2860): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 20238, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
05-09 14:02:01.038+0900 D/RESOURCED( 2860): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 20238
05-09 14:02:01.088+0900 D/RESOURCED( 2860): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 20238, appname = org.example.example, pkgname = org.example.example
05-09 14:02:01.088+0900 D/RESOURCED( 2860): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 20238, appname = org.example.example
05-09 14:02:01.088+0900 D/RESOURCED( 2860): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 20238
05-09 14:02:01.088+0900 D/RESOURCED( 2860): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3017, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
05-09 14:02:01.088+0900 D/RESOURCED( 2860): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3017
05-09 14:02:01.088+0900 D/RESOURCED( 2860): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3017, appname = org.tizen.calendar.widget
05-09 14:02:01.088+0900 D/RESOURCED( 2860): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3017
05-09 14:02:01.088+0900 I/RESOURCED( 2860): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
05-09 14:02:01.088+0900 I/RESOURCED( 2860): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
05-09 14:02:01.108+0900 D/APP_CORE(20238): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1200002 fully_obscured 0
05-09 14:02:01.108+0900 D/APP_CORE(20238): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
05-09 14:02:01.108+0900 D/APP_CORE(20238): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
05-09 14:02:01.108+0900 I/APP_CORE(20238): appcore-efl.c: __do_app(496) > [APP 20238] Event: RESUME State: CREATED
05-09 14:02:01.108+0900 D/LAUNCH  (20238): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
05-09 14:02:01.108+0900 D/APP_CORE(20238): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
05-09 14:02:01.108+0900 D/APP_CORE(20238): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-09 14:02:01.108+0900 D/APP_CORE(20238): appcore-efl.c: __do_app(607) > [APP 20238] RESUME
05-09 14:02:01.108+0900 I/APP_CORE(20238): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
05-09 14:02:01.108+0900 I/APP_CORE(20238): appcore-efl.c: __do_app(614) > [APP 20238] Initial Launching, call the resume_cb
05-09 14:02:01.108+0900 I/CAPI_APPFW_APPLICATION(20238): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
05-09 14:02:01.108+0900 D/LAUNCH  (20238): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
05-09 14:02:01.108+0900 D/LAUNCH  (20238): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
05-09 14:02:01.108+0900 D/APP_CORE(20238): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-09 14:02:01.108+0900 E/APP_CORE(20238): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-09 14:02:01.228+0900 D/AUL_AMD ( 2763): amd_launch.c: __e17_status_handler(2910) > pid(20238) status(0)
05-09 14:02:01.248+0900 D/AUL_PAD (20465): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
05-09 14:02:01.248+0900 D/AUL_PAD ( 2926): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
05-09 14:02:01.258+0900 D/AUL_PAD ( 2926): sigchild.h: __send_app_launch_signal(131) > send launch signal done
05-09 14:02:01.748+0900 D/AUL_AMD ( 2763): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
05-09 14:02:01.748+0900 D/RUA     ( 2763): rua.c: rua_add_history(179) > rua_add_history start
05-09 14:02:01.808+0900 D/RUA     ( 2763): rua.c: rua_add_history(247) > rua_add_history ok
05-09 14:02:02.298+0900 D/AUL_PAD (20465): launchpad_loader.c: main(588) > sleeping 1 sec...
05-09 14:02:02.298+0900 D/AUL_PAD (20465): preload.h: __preload_init(52) > max_cmdline_size = 1053
05-09 14:02:02.298+0900 D/AUL_PAD (20465): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b8d33760
05-09 14:02:02.298+0900 D/AUL_PAD (20465): preload.h: __preload_init(69) > get pre-initialization function
05-09 14:02:02.298+0900 D/AUL_PAD (20465): preload.h: __preload_init(73) > get shutdown function
05-09 14:02:02.298+0900 D/AUL_PAD (20465): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b8d33a40
05-09 14:02:02.298+0900 D/AUL_PAD (20465): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b8d35640
05-09 14:02:02.298+0900 D/AUL_PAD (20465): preload.h: __preload_init(69) > get pre-initialization function
05-09 14:02:02.298+0900 D/AUL_PAD (20465): preload.h: __preload_init(73) > get shutdown function
05-09 14:02:02.298+0900 D/AUL_PAD (20465): preexec.h: __preexec_init(76) > preexec start
05-09 14:02:02.298+0900 D/AUL_PAD (20465): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
05-09 14:02:02.298+0900 D/AUL     (20465): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
05-09 14:02:02.298+0900 D/AUL     (20465): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
05-09 14:02:02.298+0900 D/AUL     (20465): process_pool.c: __connect_to_launchpad(132) > send(20465) : 4
05-09 14:02:02.298+0900 D/AUL     (20465): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
05-09 14:02:02.298+0900 D/AUL_PAD ( 2926): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-09 14:02:02.308+0900 D/AUL_PAD ( 2926): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
05-09 14:02:02.308+0900 D/AUL_PAD ( 2926): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-09 14:02:02.308+0900 D/AUL_PAD ( 2926): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-09 14:02:02.308+0900 D/AUL_PAD ( 2926): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-09 14:02:02.308+0900 D/AUL_PAD ( 2926): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-09 14:02:02.308+0900 D/AUL_PAD ( 2926): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-09 14:02:02.308+0900 D/AUL_PAD ( 2926): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
05-09 14:02:02.308+0900 D/AUL_PAD ( 2926): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 20465
05-09 14:02:02.458+0900 D/AUL_PAD (20465): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
05-09 14:02:02.468+0900 D/AUL_PAD (20465): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
05-09 14:02:02.468+0900 D/AUL_PAD (20465): launchpad_loader.c: main(693) > [candidate] ecore handler add
05-09 14:02:02.478+0900 D/AUL_PAD (20465): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
05-09 14:02:05.607+0900 E/TIZEN_N_SYSTEM_SETTINGS(20238): system_settings.c: system_settings_get_value_string(540) > Enter [system_settings_get_value_string]
05-09 14:02:05.607+0900 E/TIZEN_N_SYSTEM_SETTINGS(20238): system_settings.c: system_settings_get_value(404) > Enter [system_settings_get_value]
05-09 14:02:05.607+0900 E/TIZEN_N_SYSTEM_SETTINGS(20238): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=15
05-09 14:02:05.607+0900 E/TIZEN_N_SYSTEM_SETTINGS(20238): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 14, key = 15, type = 0
05-09 14:02:05.607+0900 D/SYSTEM-SETTINGS(20238): system_setting_platform.c: system_setting_get_locale_timezone(1620) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_get_locale_timezone. [0m
05-09 14:02:05.607+0900 I/SYSTEM-SETTINGS(20238): system_setting_platform.c: system_setting_get_locale_timezone(1631) > [SECURE_LOG] [0;36mtzpath : Asia/Seoul [0m
05-09 14:02:05.677+0900 D/AUL_PAD ( 2926): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-09 14:02:05.677+0900 D/AUL_PAD ( 2926): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
05-09 14:02:05.677+0900 D/AUL_PAD ( 2926): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-09 14:02:05.677+0900 D/AUL_PAD ( 2926): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-09 14:02:05.677+0900 D/AUL_PAD ( 2926): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-09 14:02:05.677+0900 D/AUL_PAD ( 2926): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-09 14:02:05.677+0900 D/AUL_PAD ( 2926): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-09 14:02:05.677+0900 I/AUL_PAD ( 2926): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 20238 pgid = 20238
05-09 14:02:05.677+0900 I/AUL_PAD ( 2926): sigchild.h: __sigchild_action(142) > dead_pid(20238)
05-09 14:02:05.687+0900 E/EFL     ( 2725): eo<2725> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-09 14:02:05.707+0900 D/AUL_AMD ( 2763): amd_launch.c: __e17_status_handler(2891) > pid(2878) status(3)
05-09 14:02:05.707+0900 D/AUL_AMD ( 2763): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
05-09 14:02:05.707+0900 W/AUL_AMD ( 2763): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-09 14:02:05.707+0900 W/AUL_AMD ( 2763): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
05-09 14:02:05.707+0900 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(456) > pid(2878) status(3)
05-09 14:02:05.707+0900 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(468) > pid(2878) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(3)
05-09 14:02:05.707+0900 D/AUL     ( 2763): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.tizen.homescreen
05-09 14:02:05.707+0900 W/AUL     ( 2763): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2878, appid: org.tizen.homescreen, status: fg
05-09 14:02:05.717+0900 D/RESOURCED( 2860): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2878
05-09 14:02:05.717+0900 D/RESOURCED( 2860): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 2878, appname = org.tizen.homescreen, pkgname = org.tizen.homescreen
05-09 14:02:05.717+0900 D/RESOURCED( 2860): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2878, appname = org.tizen.homescreen
05-09 14:02:05.717+0900 D/RESOURCED( 2860): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2878
05-09 14:02:05.717+0900 D/AUL_PAD ( 2926): sigchild.h: __send_app_dead_signal(90) > send dead signal done
05-09 14:02:05.717+0900 I/AUL_PAD ( 2926): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
05-09 14:02:05.717+0900 I/AUL_PAD ( 2926): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
05-09 14:02:05.717+0900 E/AUL_PAD ( 2926): launchpad.c: main(688) > error reading sigchld info
05-09 14:02:05.727+0900 W/AUL_AMD ( 2763): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 20238
05-09 14:02:05.727+0900 W/AUL_AMD ( 2763): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 20238
05-09 14:02:05.727+0900 D/AUL_AMD ( 2763): amd_key.c: _unregister_key_event(179) > ===key stack===
05-09 14:02:05.727+0900 E/AUL_AMD ( 2763): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
05-09 14:02:05.727+0900 D/AUL_AMD ( 2763): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.example.example)
05-09 14:02:05.727+0900 D/AUL     ( 2763): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
05-09 14:02:05.727+0900 E/AUL     ( 2763): simple_util.c: __trm_app_info_send_socket(330) > access
05-09 14:02:05.727+0900 D/STARTER ( 2857): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 20238 is termianted
05-09 14:02:05.727+0900 D/STARTER ( 2857): starter.c: _check_dead_signal(202) > [_check_dead_signal:202] Unknown process, ignore it
05-09 14:02:05.727+0900 I/ESD     ( 2938): esd_main.c: __esd_app_dead_handler(1771) > pid: 20238
05-09 14:02:05.727+0900 E/RESOURCED( 2860): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1315
05-09 14:02:05.727+0900 W/CRASH_MANAGER(20467): worker.c: worker_job(1204) > 1120238657861149430612
