S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 4396
Date: 2017-06-01 12:18:45+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x14

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb90efb40, esi = 0x8001a8d5
ebp = 0xbfffc618, esp = 0xbfffc5e0
eax = 0x00000000, ebx = 0xb73615f0
ecx = 0x0000039b, edx = 0x00000015
eip = 0xb71b8bbf

Memory Information
MemTotal:      123 KB
MemFree:        33 KB
Buffers:         4 KB
Cached:     164624 KB
VmPeak:     100300 KB
VmSize:     100300 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22108 KB
VmRSS:       22108 KB
VmData:      32748 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34456 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 4396 TID = 4396
4396 4407 4598 4599 

Maps Information
b2bc4000 b2bce000 r-xp /usr/lib/libfeedback.so.0.1.4
b2bd4000 b2be0000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2be1000 b2c02000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2c07000 b2c08000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2c09000 b2c0e000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2c0f000 b2c10000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2c11000 b2c13000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c14000 b2c20000 r-xp /usr/lib/libdrm.so.2.4.0
b2c21000 b2c24000 r-xp /usr/lib/libdri2.so.0.0.0
b2c25000 b2c2f000 r-xp /usr/lib/libtbm.so.1.0.0
b2c30000 b2c45000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c46000 b2c58000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b345a000 b348b000 r-xp /usr/lib/libidn.so.11.5.44
b348c000 b34ae000 r-xp /usr/lib/libnghttp2.so.5.4.0
b34af000 b34bf000 r-xp /usr/lib/libcares.so.2.1.0
b34c0000 b34c9000 r-xp /usr/lib/libeventsystem.so.0.0.1
b34ca000 b34d3000 r-xp /usr/lib/libefl-extension.so.0.1.0
b34d4000 b354b000 r-xp /usr/lib/libcurl.so.4.3.0
b354d000 b355f000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3560000 b3581000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b3588000 b3589000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b358a000 b358b000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b358c000 b358f000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3590000 b3593000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b369b000 b36a1000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b36a2000 b37e6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37f6000 b37f8000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b37f9000 b37fa000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37fb000 b3805000 r-xp /opt/usr/apps/org.example.example/bin/example
b3808000 b3841000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4244000 b424f000 r-xp /lib/libnss_files-2.20-2014.11.so
b4251000 b425c000 r-xp /lib/libnss_nis-2.20-2014.11.so
b425e000 b4275000 r-xp /lib/libnsl-2.20-2014.11.so
b4279000 b4281000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4283000 b42a7000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b42a8000 b42a9000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b42aa000 b42ad000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42ae000 b42b5000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42b6000 b42c0000 r-xp /usr/lib/libsensord-share.so
b42c1000 b42dd000 r-xp /usr/lib/libsensor.so.1.2.0
b42df000 b42e8000 r-xp /usr/lib/libappcore-common.so.1.1
b42eb000 b42ed000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4302000 b4304000 r-xp /usr/lib/libXau.so.6.0.0
b4305000 b4327000 r-xp /usr/lib/libxcb.so.1.1.0
b4329000 b4332000 r-xp /lib/libcrypt-2.20-2014.11.so
b435b000 b435d000 r-xp /usr/lib/libiri.so
b435e000 b4384000 r-xp /lib/libexpat.so.1.5.2
b4386000 b43f1000 r-xp /usr/lib/libssl.so.1.0.0
b43f7000 b4403000 r-xp /usr/lib/libethumb.so.1.13.0
b4404000 b4408000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4409000 b465a000 r-xp /usr/lib/libcrypto.so.1.0.0
b5bd5000 b5be5000 r-xp /usr/lib/libXi.so.6.1.0
b5be6000 b5be8000 r-xp /usr/lib/libXgesture.so.7.0.0
b5be9000 b5bef000 r-xp /usr/lib/libXtst.so.6.1.0
b5bf0000 b5bfa000 r-xp /usr/lib/libXrender.so.1.3.0
b5bfb000 b5c04000 r-xp /usr/lib/libXrandr.so.2.2.0
b5c06000 b5c08000 r-xp /usr/lib/libXinerama.so.1.0.0
b5c09000 b5c0e000 r-xp /usr/lib/libXfixes.so.3.1.0
b5c0f000 b5c21000 r-xp /usr/lib/libXext.so.6.4.0
b5c22000 b5c24000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c25000 b5c27000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c29000 b5d6b000 r-xp /usr/lib/libX11.so.6.3.0
b5d6f000 b5d79000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d7a000 b5d90000 r-xp /usr/lib/libudev.so.1.6.0
b5d93000 b5d97000 r-xp /lib/libattr.so.1.1.0
b5d98000 b5dc7000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5dc9000 b5dcf000 r-xp /usr/lib/libffi.so.6.0.2
b5dd0000 b5df3000 r-xp /lib/libz.so.1.2.8
b5df4000 b5df7000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5df8000 b5f54000 r-xp /usr/lib/libxml2.so.2.9.2
b5f5a000 b6041000 r-xp /usr/lib/libstdc++.so.6.0.20
b604e000 b6051000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6052000 b6074000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6075000 b6089000 r-xp /lib/libresolv-2.20-2014.11.so
b608d000 b60b1000 r-xp /usr/lib/liblzma.so.5.0.3
b60b2000 b60b4000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b60b6000 b60c0000 r-xp /usr/lib/libembryo.so.1.13.0
b60c1000 b60ea000 r-xp /usr/lib/libpng12.so.0.50.0
b60eb000 b6134000 r-xp /usr/lib/libjpeg.so.8.0.2
b6145000 b614c000 r-xp /lib/librt-2.20-2014.11.so
b614e000 b616d000 r-xp /usr/lib/libector.so.1.13.0
b6170000 b619d000 r-xp /usr/lib/liblua-5.1.so
b619e000 b622e000 r-xp /usr/lib/libfreetype.so.6.11.3
b6232000 b6270000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6271000 b6287000 r-xp /usr/lib/libfribidi.so.0.3.1
b6288000 b62e1000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62e4000 b632f000 r-xp /lib/libm-2.20-2014.11.so
b6331000 b6343000 r-xp /usr/lib/libeio.so.1.13.0
b6344000 b6347000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6348000 b634e000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b634f000 b6372000 r-xp /usr/lib/libefreet.so.1.13.0
b6375000 b63a0000 r-xp /usr/lib/libeldbus.so.1.13.0
b63a1000 b63d5000 r-xp /usr/lib/libecore_con.so.1.13.0
b63d7000 b63e0000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63e1000 b63ea000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63eb000 b63fe000 r-xp /usr/lib/libeo.so.1.13.0
b6400000 b6413000 r-xp /usr/lib/libecore_input.so.1.13.0
b6414000 b641b000 r-xp /usr/lib/libecore_file.so.1.13.0
b641c000 b643f000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6440000 b646c000 r-xp /usr/lib/libeet.so.1.13.0
b6475000 b64e0000 r-xp /usr/lib/libeina.so.1.13.0
b64e3000 b64fa000 r-xp /usr/lib/libefl.so.1.13.0
b64fc000 b6663000 r-xp /usr/lib/libicuuc.so.51.1
b6671000 b687d000 r-xp /usr/lib/libicui18n.so.51.1
b6885000 b68d4000 r-xp /usr/lib/libecore_x.so.1.13.0
b68d6000 b68f0000 r-xp /lib/libgcc_s-4.9.so.1
b68f2000 b68f6000 r-xp /lib/libcap.so.2.21
b68f7000 b693d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b693e000 b6945000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6947000 b6999000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b699b000 b6b26000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b2b000 b6bf9000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bfc000 b6c00000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6c01000 b6c10000 r-xp /usr/lib/libvconf.so.0.2.45
b6c11000 b6c14000 r-xp /usr/lib/libvasum.so.0.3.1
b6c15000 b6c18000 r-xp /usr/lib/libttrace.so.1.1
b6c1a000 b6c1e000 r-xp /usr/lib/libiniparser.so.0
b6c1f000 b6c4f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c50000 b6c59000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c5a000 b6c7f000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c80000 b6c90000 r-xp /usr/lib/libunwind.so.8.0.1
b6c9a000 b6e48000 r-xp /lib/libc-2.20-2014.11.so
b6e50000 b6f93000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f95000 b6fed000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fee000 b7022000 r-xp /usr/lib/libsystemd.so.0.4.0
b7025000 b70f9000 r-xp /usr/lib/libedje.so.1.13.0
b70fc000 b7128000 r-xp /usr/lib/libecore.so.1.13.0
b7139000 b735f000 r-xp /usr/lib/libevas.so.1.13.0
b7387000 b739f000 r-xp /lib/libpthread-2.20-2014.11.so
b73a3000 b771d000 r-xp /usr/lib/libelementary.so.1.13.0
b773d000 b7741000 r-xp /usr/lib/libsmack.so.1.0.0
b7742000 b774b000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b774c000 b774f000 r-xp /usr/lib/libdlog.so.0.0.0
b7750000 b7755000 r-xp /usr/lib/libbundle.so.0.1.22
b7756000 b7759000 r-xp /lib/libdl-2.20-2014.11.so
b775b000 b7780000 r-xp /usr/lib/libaul.so.0.1.0
b7783000 b7785000 r-xp /usr/lib/libappsvc.so.0.1.0
b7786000 b778b000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b778c000 b7793000 r-xp /usr/lib/libappcore-efl.so.1.1
b7795000 b779a000 r-xp /usr/lib/libsys-assert.so
b779d000 b779e000 r-xp [vdso]
b779e000 b77c0000 r-xp /lib/ld-2.20-2014.11.so
b77c2000 b77ca000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:4396)
Call Stack Count: 41
 0: (0xb71b8bbf) [/usr/lib/libevas.so.1] + 0x7fbbf
 1: (0xb71aace8) [/usr/lib/libevas.so.1] + 0x71ce8
 2: evas_obj_size_hint_min_set + 0xb9 (0xb71a5629) [/usr/lib/libevas.so.1] + 0x6c629
 3: evas_object_size_hint_min_set + 0x60 (0xb71b2fa0) [/usr/lib/libevas.so.1] + 0x79fa0
 4: (0xb75b6d29) [/usr/lib/libelementary.so.1] + 0x213d29
 5: elm_obj_layout_sizing_eval + 0x99 (0xb754e559) [/usr/lib/libelementary.so.1] + 0x1ab559
 6: (0xb7555205) [/usr/lib/libelementary.so.1] + 0x1b2205
 7: evas_obj_smart_add + 0x99 (0xb71c3809) [/usr/lib/libevas.so.1] + 0x8a809
 8: (0xb754779a) [/usr/lib/libelementary.so.1] + 0x1a479a
 9: evas_obj_smart_add + 0x99 (0xb71c3809) [/usr/lib/libevas.so.1] + 0x8a809
10: (0xb75bb27b) [/usr/lib/libelementary.so.1] + 0x21827b
11: evas_obj_smart_add + 0x99 (0xb71c3809) [/usr/lib/libevas.so.1] + 0x8a809
12: (0xb71c6d8b) [/usr/lib/libevas.so.1] + 0x8dd8b
13: eo_constructor + 0x99 (0xb63f5899) [/usr/lib/libeo.so.1] + 0xa899
14: (0xb76144a6) [/usr/lib/libelementary.so.1] + 0x2714a6
15: eo_constructor + 0x99 (0xb63f5899) [/usr/lib/libeo.so.1] + 0xa899
16: (0xb7556c37) [/usr/lib/libelementary.so.1] + 0x1b3c37
17: eo_constructor + 0x99 (0xb63f5899) [/usr/lib/libeo.so.1] + 0xa899
18: (0xb7547879) [/usr/lib/libelementary.so.1] + 0x1a4879
19: eo_constructor + 0x99 (0xb63f5899) [/usr/lib/libeo.so.1] + 0xa899
20: (0xb75bb7c2) [/usr/lib/libelementary.so.1] + 0x2187c2
21: eo_constructor + 0x99 (0xb63f5899) [/usr/lib/libeo.so.1] + 0xa899
22: elm_scroller_add + 0x77 (0xb75b9db7) [/usr/lib/libelementary.so.1] + 0x216db7
23: setting_view_cb + 0x3f (0xb38034ff) [/opt/usr/apps/org.example.example/bin/example] + 0x84ff
24: (0xb716d449) [/usr/lib/libevas.so.1] + 0x34449
25: (0xb63f9319) [/usr/lib/libeo.so.1] + 0xe319
26: eo_event_callback_call + 0xb3 (0xb63f6d63) [/usr/lib/libeo.so.1] + 0xbd63
27: (0xb716da62) [/usr/lib/libevas.so.1] + 0x34a62
28: (0xb717c441) [/usr/lib/libevas.so.1] + 0x43441
29: evas_canvas_event_feed_mouse_down + 0xcf (0xb718620f) [/usr/lib/libevas.so.1] + 0x4d20f
30: evas_event_feed_mouse_down + 0x6a (0xb718cc2a) [/usr/lib/libevas.so.1] + 0x53c2a
31: (0xb440649c) [/usr/lib/libecore_input_evas.so.1] + 0x249c
32: (0xb7109055) [/usr/lib/libecore.so.1] + 0xd055
33: (0xb71121b9) [/usr/lib/libecore.so.1] + 0x161b9
34: ecore_main_loop_begin + 0x57 (0xb7112587) [/usr/lib/libecore.so.1] + 0x16587
35: elm_run + 0x2d (0xb756b22d) [/usr/lib/libelementary.so.1] + 0x1c822d
36: appcore_efl_main + 0x4de (0xb778fdde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
37: ui_app_main + 0x140 (0xb7788c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
38: main + 0x2a5 (0xb3802605) [/opt/usr/apps/org.example.example/bin/example] + 0x7605
39: (0xb77c4148) [/opt/usr/apps/org.example.example/bin/example] + 0xb77c4148
40: __libc_start_main + 0xde (0xb6cb1e4e) [/lib/libc.so.6] + 0x17e4e
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
e.example], key=[end], value=[ok]
06-01 12:18:20.174+0900 D/QUICKPANEL( 3014): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:end val:ok
06-01 12:18:20.174+0900 D/PKGMGR  ( 3009): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_2098184873], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 12:18:20.174+0900 D/DATA_PROVIDER_MASTER( 3009): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.example] ok
06-01 12:18:20.174+0900 D/DATA_PROVIDER_MASTER( 3009): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.example], event_type[1]
06-01 12:18:20.174+0900 D/DATA_PROVIDER_MASTER( 3009): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
06-01 12:18:20.174+0900 D/PKGMGR  ( 3017): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_2098184873], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
06-01 12:18:20.174+0900 D/ESD     ( 3017): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(30170002), pkg_type(tpk), pkgid(org.example.example), key(install_percent), val(100)
06-01 12:18:20.174+0900 D/PKGMGR  ( 3017): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_2098184873], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 12:18:20.174+0900 D/ESD     ( 3017): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(30170002), pkg_type(tpk), pkgid(org.example.example), key(end), val(ok)
06-01 12:18:20.174+0900 D/ESD     ( 3017): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
06-01 12:18:20.174+0900 D/PKGMGR  ( 3022): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_2098184873], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
06-01 12:18:20.174+0900 D/PKGMGR  ( 3022): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_2098184873], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 12:18:20.174+0900 D/PRIVILEGE_CHECKER( 3022): privilege_checker.c: __privilege_checker_check_privilege(45) > _ENTER_
06-01 12:18:20.174+0900 E/PRIVILEGE_CHECKER( 3022): privilege_checker.c: __privilege_checker_check_privilege(78) > Please declare http://tizen.org/privilege/package.info in tizen-manifest.xml or config.xml
06-01 12:18:20.174+0900 D/PRIVILEGE_CHECKER( 3022): privilege_checker.c: __privilege_checker_check_privilege(45) > _ENTER_
06-01 12:18:20.174+0900 W/ISF_PANEL_EFL( 3115): isf_panel_efl.cpp: _package_manager_event_cb(1512) > _isf_insert_ime_info_by_pkgid returned 0.
06-01 12:18:20.174+0900 D/PKGMGR  ( 2858): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[install], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_2098184873], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 12:18:20.174+0900 D/AUL_AMD ( 2858): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.example), key(end), value(ok)
06-01 12:18:20.174+0900 W/AUL_AMD ( 2858): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(install), value(ok)
06-01 12:18:20.174+0900 D/PKGMGR  ( 3191): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_2098184873], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
06-01 12:18:20.174+0900 D/PKGMGR  ( 3191): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_2098184873], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 12:18:20.174+0900 D/PKGMGR  ( 3032): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_2098184873], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
06-01 12:18:20.174+0900 D/PKGMGR  ( 3032): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
06-01 12:18:20.174+0900 D/PKGMGR  ( 3032): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_2098184873], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 12:18:20.174+0900 D/PKGMGR  ( 3032): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
06-01 12:18:20.174+0900 D/PKGMGR  ( 2945): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_2098184873], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
06-01 12:18:20.174+0900 W/cluster-home( 2945): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[0], state[1], package[org.example.example]
06-01 12:18:20.174+0900 D/PKGMGR  ( 2945): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_2098184873], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
06-01 12:18:20.174+0900 D/cluster-home( 2945): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29450003] pkg_type[tpk] package[org.example.example] key[install_percent] val[100] pmsg[(null)]
06-01 12:18:20.174+0900 D/PKGMGR  ( 2945): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_2098184873], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 12:18:20.174+0900 W/cluster-home( 2945): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[0], state[2], package[org.example.example]
06-01 12:18:20.174+0900 D/cluster-home( 2945): widget-data-provider.cpp: PackageUpdated(2160) >  No boxes that pkgname is[org.example.example]
06-01 12:18:20.174+0900 D/PKGMGR  ( 2945): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_2098184873], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 12:18:20.174+0900 D/cluster-home( 2945): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29450003] pkg_type[tpk] package[org.example.example] key[end] val[ok] pmsg[(null)]
06-01 12:18:20.174+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
06-01 12:18:20.174+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
06-01 12:18:20.174+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
06-01 12:18:20.174+0900 D/AUL_AMD ( 2858): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.example, type:rpm
06-01 12:18:20.174+0900 D/rpm-installer( 4540): rpm-installer-privilege.c: _ri_privilege_enable_permissions(106) > [smack] app_enable_permissions(org.example.example, 7), result=[0]
06-01 12:18:20.174+0900 D/rpm-installer( 4540): coretpk-installer.c: _coretpk_installer_prepare_package_install_with_debug(3285) > _ri_privilege_enable_permissions(privilege/appdebuging succeeded for debug_mode.
06-01 12:18:20.174+0900 D/rpm-installer( 4540): rpm-appcore-intf.c: main(236) > sync() start
06-01 12:18:20.174+0900 D/DATA_PROVIDER_MASTER( 3009): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
06-01 12:18:20.174+0900 D/DATA_PROVIDER_MASTER( 3009): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
06-01 12:18:20.174+0900 D/DATA_PROVIDER_MASTER( 3009): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.example]
06-01 12:18:20.174+0900 D/cluster-home( 2945): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
06-01 12:18:20.174+0900 D/cluster-home( 2945): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.example]
06-01 12:18:20.174+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.example]
06-01 12:18:20.174+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.example]
06-01 12:18:20.184+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
06-01 12:18:20.184+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
06-01 12:18:20.184+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.example]
06-01 12:18:20.184+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.example] Name[forpet] Icon[/opt/usr/apps/org.example.example/shared/res/1.jpg] enable[1] system[0]
06-01 12:18:20.184+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: OnAppInstalled(309) >  pAppId [org.example.example]
06-01 12:18:20.184+0900 D/cluster-home( 2945): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.example
06-01 12:18:20.184+0900 D/cluster-home( 2945): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[23], isFolder[0], pageId[1], col[4], row[4], appId[org.example.example], name[forpet], menuId[1], isPreload[0] isPreload[0]
06-01 12:18:20.184+0900 D/cluster-home( 2945): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
06-01 12:18:20.184+0900 D/PKGMGR  ( 4538): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_2098184873], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
06-01 12:18:20.194+0900 D/PKGMGR  ( 4538): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_2098184873], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 12:18:20.204+0900 D/rpm-installer( 4540): rpm-appcore-intf.c: main(238) > sync() end
06-01 12:18:20.354+0900 D/rpm-installer( 4540): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
06-01 12:18:20.354+0900 D/rpm-installer( 4540): rpm-appcore-intf.c: main(259) > ------------------------------------------------
06-01 12:18:20.354+0900 D/rpm-installer( 4540): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
06-01 12:18:20.354+0900 D/rpm-installer( 4540): rpm-appcore-intf.c: main(261) > ------------------------------------------------
06-01 12:18:20.424+0900 D/PKGMGR_SERVER( 4526): pkgmgr-server.c: sighandler(387) > child exit [4540]
06-01 12:18:20.424+0900 E/PKGMGR_SERVER( 4526): pkgmgr-server.c: sighandler(402) > child NORMAL exit [4540]
06-01 12:18:21.564+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(838) > __request_handler: 0
06-01 12:18:21.564+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-01 12:18:21.564+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 12:18:21.564+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 12:18:21.574+0900 I/AUL     ( 2858): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
06-01 12:18:21.574+0900 D/AUL     ( 2858): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 4592, pid = 4594
06-01 12:18:21.574+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 12:18:21.574+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 12:18:21.574+0900 I/AUL     ( 2858): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
06-01 12:18:21.574+0900 E/AUL_AMD ( 2858): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-01 12:18:21.574+0900 W/AUL_AMD ( 2858): amd_launch.c: _start_app(2233) > caller pid : 4594
06-01 12:18:21.574+0900 E/AUL_AMD ( 2858): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-01 12:18:21.574+0900 W/AUL_AMD ( 2858): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-01 12:18:21.574+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2648) > process_pool: false
06-01 12:18:21.574+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-01 12:18:21.574+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-01 12:18:21.574+0900 W/AUL_AMD ( 2858): amd_launch.c: _start_app(2665) > pad pid(-5)
06-01 12:18:21.574+0900 D/AUL_AMD ( 2858): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-01 12:18:21.574+0900 D/AUL_AMD ( 2858): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-01 12:18:21.574+0900 D/AUL     ( 2858): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-01 12:18:21.574+0900 D/AUL_PAD ( 3003): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-01 12:18:21.574+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 12:18:21.574+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 12:18:21.574+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 12:18:21.574+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 12:18:21.574+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 12:18:21.574+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 12:18:21.574+0900 D/AUL_PAD ( 3003): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-01 12:18:21.574+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-01 12:18:21.574+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-01 12:18:21.574+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-01 12:18:21.574+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-01 12:18:21.574+0900 D/AUL_PAD ( 3003): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-01 12:18:21.574+0900 D/AUL_PAD ( 3003): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-01 12:18:21.574+0900 W/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-01 12:18:21.574+0900 D/AUL     ( 3003): process_pool.c: __send_pkt_raw_data(219) > send(11) : 620 / 620
06-01 12:18:21.574+0900 D/AUL_PAD ( 3003): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 4396, bin path: /opt/usr/apps/org.example.example/bin/example
06-01 12:18:21.574+0900 W/AUL_PAD ( 3003): launchpad.c: __send_result_to_caller(265) > Check app launching
06-01 12:18:21.574+0900 D/AUL_PAD ( 3003): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-01 12:18:21.574+0900 D/RESOURCED( 2893): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-01 12:18:21.574+0900 D/RESOURCED( 2893): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-01 12:18:21.574+0900 E/RESOURCED( 2893): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-01 12:18:21.574+0900 D/AUL_PAD ( 4396): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-01 12:18:21.574+0900 D/AUL_PAD ( 4396): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
06-01 12:18:21.574+0900 D/AUL_PAD ( 4396): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-01 12:18:21.574+0900 D/AUL_PAD ( 4396): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-01 12:18:21.574+0900 D/AUL_PAD ( 4396): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-01 12:18:21.574+0900 D/AUL_PAD ( 4396): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-01 12:18:21.574+0900 D/AUL     ( 4396): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (4407) is sent.
06-01 12:18:21.584+0900 D/AUL     ( 4396): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 4407, signo: 10
06-01 12:18:21.584+0900 D/AUL     ( 4396): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-01 12:18:21.584+0900 D/AUL_PAD ( 4396): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-01 12:18:21.584+0900 D/AUL_PAD ( 4396): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-01 12:18:21.584+0900 D/AUL_PAD ( 4396): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-01 12:18:21.584+0900 D/AUL_PAD ( 4396): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-01 12:18:21.584+0900 D/AUL_PAD ( 4396): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTYyODcxMDEvNTc0MzYxAA==##
06-01 12:18:21.584+0900 D/AUL_PAD ( 4396): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-01 12:18:21.584+0900 D/AUL_PAD ( 4396): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA0NTk0AA==##
06-01 12:18:21.584+0900 D/AUL_PAD ( 4396): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-01 12:18:21.584+0900 D/AUL_PAD ( 4396): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-01 12:18:21.584+0900 D/AUL_PAD ( 4396): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-01 12:18:21.584+0900 D/AUL_PAD ( 4396): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-01 12:18:21.584+0900 D/AUL_PAD ( 4396): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-01 12:18:21.584+0900 I/CAPI_APPFW_APPLICATION( 4396): app_main.c: ui_app_main(788) > app_efl_main
06-01 12:18:21.584+0900 D/LAUNCH  ( 4396): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-01 12:18:21.584+0900 D/APP_CORE( 4396): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-01 12:18:21.584+0900 D/APP_CORE( 4396): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-01 12:18:21.584+0900 D/APP_CORE( 4396): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-01 12:18:21.604+0900 D/APP_CORE( 4396): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-01 12:18:21.604+0900 D/AUL     ( 4396): app_sock.c: __create_server_sock(156) > pg path - already exists
06-01 12:18:21.604+0900 D/APP_CORE( 4396): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42e8520
06-01 12:18:21.604+0900 D/LAUNCH  ( 4396): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-01 12:18:21.604+0900 I/CAPI_APPFW_APPLICATION( 4396): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-01 12:18:21.674+0900 D/AUL_PAD ( 3003): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-01 12:18:21.674+0900 W/AUL     ( 2858): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 4396, appid: org.example.example
06-01 12:18:21.674+0900 D/AUL     ( 2858): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-01 12:18:21.674+0900 E/AUL     ( 2858): simple_util.c: __trm_app_info_send_socket(330) > access
06-01 12:18:21.674+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2700) > add app group info
06-01 12:18:21.674+0900 E/AUL     ( 2858): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-01 12:18:21.674+0900 D/AUL_AMD ( 2858): amd_status.c: _status_add_app_info_list(427) > pid(4396) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-01 12:18:21.684+0900 D/LAUNCH  ( 4396): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
06-01 12:18:21.684+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 4396
06-01 12:18:21.684+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-01 12:18:21.684+0900 E/RESOURCED( 2893): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-01 12:18:21.684+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(888) > available memory = 321
06-01 12:18:21.694+0900 D/APP_CORE( 4396): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-01 12:18:21.694+0900 E/E17     ( 2741): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x01e00002)
06-01 12:18:21.744+0900 E/E17     ( 2741): e_border.c: e_border_show(2088) > BD_SHOW(0x01e00002)
06-01 12:18:21.764+0900 D/APP_CORE( 4396): appcore.c: __aul_handler(587) > [APP 4396]     AUL event: AUL_START
06-01 12:18:21.764+0900 I/APP_CORE( 4396): appcore-efl.c: __do_app(496) > [APP 4396] Event: RESET State: CREATED
06-01 12:18:21.764+0900 D/APP_CORE( 4396): appcore-efl.c: __do_app(527) > [APP 4396] RESET
06-01 12:18:21.764+0900 D/LAUNCH  ( 4396): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
06-01 12:18:21.764+0900 D/APP_CORE( 4396): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-01 12:18:21.764+0900 D/APP_CORE( 4396): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-01 12:18:21.764+0900 I/CAPI_APPFW_APPLICATION( 4396): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-01 12:18:21.764+0900 D/AUL     ( 4396): service.c: __set_bundle(186) > __set_bundle
06-01 12:18:21.764+0900 D/LAUNCH  ( 4396): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-01 12:18:21.764+0900 D/APP_CORE( 4396): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-01 12:18:21.764+0900 E/EFL     ( 4396): edje<4396> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 12:18:21.764+0900 E/EFL     ( 4396): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 12:18:21.764+0900 E/EFL     ( 4396): edje<4396> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 12:18:21.764+0900 E/EFL     ( 4396): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 12:18:21.764+0900 E/EFL     ( 4396): edje<4396> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 12:18:21.764+0900 E/EFL     ( 4396): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 12:18:21.764+0900 E/EFL     ( 4396): edje<4396> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 12:18:21.764+0900 E/EFL     ( 4396): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 12:18:21.764+0900 E/EFL     ( 4396): edje<4396> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 12:18:21.764+0900 E/EFL     ( 4396): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 12:18:21.774+0900 W/APP_CORE( 4396): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1e00002
06-01 12:18:21.774+0900 D/APP_CORE( 4396): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:1e00002
06-01 12:18:21.774+0900 D/APP_CORE( 4396): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-01 12:18:21.774+0900 D/AUL     ( 4396): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-01 12:18:21.774+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(838) > __request_handler: 34
06-01 12:18:21.794+0900 W/PROCESSMGR( 2741): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=4396
06-01 12:18:21.804+0900 E/EFL     ( 2741): eo<2741> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 12:18:21.804+0900 E/EFL     ( 2741): eo<2741> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 12:18:21.824+0900 D/INDICATOR( 2934): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
06-01 12:18:21.824+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(838) > __request_handler: 15
06-01 12:18:21.824+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 12:18:21.824+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 12:18:21.824+0900 D/AUL_AMD ( 2858): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 4396 is org.example.example
06-01 12:18:21.824+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 4396 : 0
06-01 12:18:21.824+0900 D/INDICATOR( 2934): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-01 12:18:21.824+0900 D/INDICATOR( 2934): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-01 12:18:21.824+0900 D/INDICATOR( 2934): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-01 12:18:21.824+0900 D/INDICATOR( 2934): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-01 12:18:21.824+0900 D/INDICATOR( 2934): main.c: _rotate_window(252) > port :: hide more icon
06-01 12:18:21.824+0900 D/AUL     ( 3022): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-01 12:18:21.994+0900 E/PKGMGR_SERVER( 4526): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-01 12:18:21.994+0900 E/PKGMGR_SERVER( 4526): pkgmgr-server.c: main(2265) > package manager server terminated.
06-01 12:18:22.434+0900 D/APP_CORE( 4396): appcore.c: __prt_ltime(236) > [APP 4396] first idle after reset: 875 msec
06-01 12:18:22.554+0900 E/E17     ( 2741): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
06-01 12:18:22.554+0900 D/APP_CORE( 2945): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
06-01 12:18:22.554+0900 D/APP_CORE( 2945): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-01 12:18:22.554+0900 D/APP_CORE( 2945): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-01 12:18:22.554+0900 I/APP_CORE( 2945): appcore-efl.c: __do_app(496) > [APP 2945] Event: PAUSE State: RUNNING
06-01 12:18:22.554+0900 D/APP_CORE( 2945): appcore-efl.c: __do_app(565) > [APP 2945] PAUSE
06-01 12:18:22.554+0900 I/CAPI_APPFW_APPLICATION( 2945): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-01 12:18:22.554+0900 E/cluster-home( 2945): homescreen.cpp: OnPause(84) >  app pause
06-01 12:18:22.554+0900 D/cluster-view( 2945): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-01 12:18:22.554+0900 D/cluster-view( 2945): homescreen-view-manager.cpp: AppPause(923) >  END
06-01 12:18:22.554+0900 D/APP_CORE( 4396): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1e00002 fully_obscured 0
06-01 12:18:22.554+0900 D/APP_CORE( 4396): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-01 12:18:22.554+0900 D/APP_CORE( 4396): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-01 12:18:22.554+0900 D/APP_CORE( 2945): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-01 12:18:22.554+0900 I/APP_CORE( 4396): appcore-efl.c: __do_app(496) > [APP 4396] Event: RESUME State: CREATED
06-01 12:18:22.554+0900 D/LAUNCH  ( 4396): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-01 12:18:22.554+0900 D/APP_CORE( 4396): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-01 12:18:22.554+0900 D/APP_CORE( 4396): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-01 12:18:22.554+0900 D/APP_CORE( 4396): appcore-efl.c: __do_app(607) > [APP 4396] RESUME
06-01 12:18:22.554+0900 E/APP_CORE( 2945): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-01 12:18:22.554+0900 I/APP_CORE( 4396): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-01 12:18:22.554+0900 I/APP_CORE( 4396): appcore-efl.c: __do_app(614) > [APP 4396] Initial Launching, call the resume_cb
06-01 12:18:22.554+0900 I/CAPI_APPFW_APPLICATION( 4396): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-01 12:18:22.554+0900 D/LAUNCH  ( 4396): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-01 12:18:22.554+0900 D/LAUNCH  ( 4396): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-01 12:18:22.554+0900 D/APP_CORE( 4396): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-01 12:18:22.554+0900 E/APP_CORE( 4396): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-01 12:18:22.564+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(456) > pid(2945) status(4)
06-01 12:18:22.564+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(468) > pid(2945) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-01 12:18:22.564+0900 D/AUL     ( 2858): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-01 12:18:22.564+0900 W/AUL     ( 2858): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2945, appid: org.tizen.homescreen, status: bg
06-01 12:18:22.574+0900 D/AUL_AMD ( 2858): amd_launch.c: __e17_status_handler(2891) > pid(4396) status(3)
06-01 12:18:22.574+0900 D/AUL_AMD ( 2858): amd_key.c: _key_ungrab(265) > _key_ungrab, win : c00002
06-01 12:18:22.574+0900 W/AUL_AMD ( 2858): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-01 12:18:22.574+0900 W/AUL_AMD ( 2858): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-01 12:18:22.574+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(456) > pid(4396) status(3)
06-01 12:18:22.574+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(468) > pid(4396) appid(org.example.example) pkgid(org.example.example) status(3)
06-01 12:18:22.574+0900 D/AUL     ( 2858): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-01 12:18:22.574+0900 W/AUL     ( 2858): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 4396, appid: org.example.example, status: fg
06-01 12:18:22.574+0900 D/DATA_PROVIDER_MASTER( 3009): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2945 is paused
06-01 12:18:22.574+0900 D/DATA_PROVIDER_MASTER( 3009): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-01 12:18:22.574+0900 I/CAPI_WIDGET_APPLICATION( 3084): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-01 12:18:22.574+0900 I/CAPI_WIDGET_APPLICATION( 3084): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-01 12:18:22.574+0900 W/AUL     ( 3084): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3084, appid: org.tizen.calendar.widget, status: bg
06-01 12:18:22.584+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 4396
06-01 12:18:22.584+0900 D/RESOURCED( 2893): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 4396, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-01 12:18:22.584+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 4396
06-01 12:18:22.624+0900 D/AUL_AMD ( 2858): amd_launch.c: __e17_status_handler(2910) > pid(4396) status(0)
06-01 12:18:22.644+0900 D/RESOURCED( 2893): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 4396, appname = org.example.example, pkgname = org.example.example
06-01 12:18:22.644+0900 D/RESOURCED( 2893): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 4396, appname = org.example.example
06-01 12:18:22.644+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 4396
06-01 12:18:22.644+0900 D/RESOURCED( 2893): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3084, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-01 12:18:22.644+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3084
06-01 12:18:22.644+0900 D/RESOURCED( 2893): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3084, appname = org.tizen.calendar.widget
06-01 12:18:22.644+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3084
06-01 12:18:22.644+0900 I/RESOURCED( 2893): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-01 12:18:22.644+0900 I/RESOURCED( 2893): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-01 12:18:22.684+0900 D/AUL_PAD ( 3003): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-01 12:18:22.684+0900 D/AUL_PAD ( 4603): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-01 12:18:22.694+0900 D/AUL_PAD ( 3003): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-01 12:18:22.704+0900 E/RESOURCED( 2893): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.268
06-01 12:18:23.194+0900 D/AUL_AMD ( 2858): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-01 12:18:23.194+0900 D/RUA     ( 2858): rua.c: rua_add_history(179) > rua_add_history start
06-01 12:18:23.234+0900 D/RUA     ( 2858): rua.c: rua_add_history(247) > rua_add_history ok
06-01 12:18:23.734+0900 D/AUL_PAD ( 4603): launchpad_loader.c: main(588) > sleeping 1 sec...
06-01 12:18:23.734+0900 D/AUL_PAD ( 4603): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-01 12:18:23.764+0900 D/AUL_PAD ( 4603): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b9126760
06-01 12:18:23.764+0900 D/AUL_PAD ( 4603): preload.h: __preload_init(69) > get pre-initialization function
06-01 12:18:23.764+0900 D/AUL_PAD ( 4603): preload.h: __preload_init(73) > get shutdown function
06-01 12:18:23.764+0900 D/AUL_PAD ( 4603): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b9126a40
06-01 12:18:23.764+0900 D/AUL_PAD ( 4603): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b9128640
06-01 12:18:23.764+0900 D/AUL_PAD ( 4603): preload.h: __preload_init(69) > get pre-initialization function
06-01 12:18:23.764+0900 D/AUL_PAD ( 4603): preload.h: __preload_init(73) > get shutdown function
06-01 12:18:23.764+0900 D/AUL_PAD ( 4603): preexec.h: __preexec_init(76) > preexec start
06-01 12:18:23.764+0900 D/AUL_PAD ( 4603): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-01 12:18:23.764+0900 D/AUL     ( 4603): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-01 12:18:23.764+0900 D/AUL     ( 4603): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-01 12:18:23.774+0900 D/AUL_PAD ( 3003): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-01 12:18:23.774+0900 D/AUL     ( 4603): process_pool.c: __connect_to_launchpad(132) > send(4603) : 4
06-01 12:18:23.774+0900 D/AUL     ( 4603): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-01 12:18:23.774+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-01 12:18:23.774+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 12:18:23.774+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 12:18:23.774+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 12:18:23.774+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 12:18:23.774+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 12:18:23.774+0900 D/AUL_PAD ( 3003): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-01 12:18:23.774+0900 D/AUL_PAD ( 3003): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 4603
06-01 12:18:23.984+0900 D/AUL_PAD ( 4603): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-01 12:18:23.994+0900 D/AUL_PAD ( 4603): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-01 12:18:23.994+0900 D/AUL_PAD ( 4603): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-01 12:18:23.994+0900 D/AUL_PAD ( 4603): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-01 12:18:27.574+0900 D/APP_CORE( 2945): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
06-01 12:18:27.574+0900 I/APP_CORE( 2945): appcore-efl.c: __do_app(496) > [APP 2945] Event: MEM_FLUSH State: PAUSED
06-01 12:18:27.574+0900 D/APP_CORE( 2945): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
06-01 12:18:27.574+0900 D/APP_CORE( 2945): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2945
06-01 12:18:27.574+0900 D/APP_CORE( 2945): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
06-01 12:18:27.574+0900 D/RESOURCED( 2893): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2945
06-01 12:18:39.673+0900 E/CAPI_NETWORK_WIFI( 2934): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-01 12:18:39.673+0900 E/INDICATOR( 2934): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001fafe)
06-01 12:18:39.673+0900 E/INDICATOR( 2934): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-01 12:18:39.673+0900 E/INDICATOR( 2934): 
06-01 12:18:45.633+0900 E/EFL     ( 4396): eo<4396> lib/eo/eo.c:676 _eo_call_resolve() in ../src/lib/evas/canvas/evas_common_interface.eo.c:1: func 'evas_common_evas_get' (62) could not be resolved for class 'Elm_Naviframe_Item'.
06-01 12:18:45.633+0900 E/EFL     ( 4396): eo<4396> lib/eo/eo.c:676 _eo_call_resolve() in ../src/lib/evas/canvas/evas_object.eo.c:74: func 'evas_obj_type_get' (128) could not be resolved for class 'Elm_Naviframe_Item'.
06-01 12:18:45.633+0900 E/EFL     ( 4396): elementary<4396> elm_widget.c:1101 elm_widget_sub_object_parent_add() You passed a wrong parent parameter (0x8000b85d (null)). Elementary widget's parent should be an elementary widget.
06-01 12:18:45.633+0900 E/EFL     ( 4396): <4396> lib/edje/edje_smart.c:22 edje_object_add() safety check failed: evas == NULL
06-01 12:18:45.683+0900 D/PROCESSMGR( 2741): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002f  register trigger_timer!  pointed_win=0x2003b9 
06-01 12:18:45.693+0900 D/AUL_PAD ( 3003): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-01 12:18:45.693+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 12:18:45.693+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 12:18:45.693+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 12:18:45.693+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 12:18:45.693+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 12:18:45.693+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 12:18:45.693+0900 I/AUL_PAD ( 3003): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 4396 pgid = 4396
06-01 12:18:45.693+0900 I/AUL_PAD ( 3003): sigchild.h: __sigchild_action(142) > dead_pid(4396)
06-01 12:18:45.703+0900 E/EFL     ( 2741): eo<2741> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 12:18:45.713+0900 D/AUL_AMD ( 2858): amd_launch.c: __e17_status_handler(2891) > pid(2945) status(3)
06-01 12:18:45.713+0900 D/AUL_AMD ( 2858): amd_key.c: _key_ungrab(265) > _key_ungrab, win : c00002
06-01 12:18:45.713+0900 W/AUL_AMD ( 2858): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-01 12:18:45.713+0900 W/AUL_AMD ( 2858): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-01 12:18:45.713+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(456) > pid(2945) status(3)
06-01 12:18:45.713+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(468) > pid(2945) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(3)
06-01 12:18:45.713+0900 D/AUL     ( 2858): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.tizen.homescreen
06-01 12:18:45.713+0900 W/AUL     ( 2858): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2945, appid: org.tizen.homescreen, status: fg
06-01 12:18:45.723+0900 D/AUL_PAD ( 3003): sigchild.h: __send_app_dead_signal(90) > send dead signal done
06-01 12:18:45.723+0900 I/AUL_PAD ( 3003): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
06-01 12:18:45.723+0900 I/AUL_PAD ( 3003): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
06-01 12:18:45.723+0900 E/AUL_PAD ( 3003): launchpad.c: main(688) > error reading sigchld info
06-01 12:18:45.733+0900 I/ESD     ( 3017): esd_main.c: __esd_app_dead_handler(1771) > pid: 4396
06-01 12:18:45.733+0900 W/AUL_AMD ( 2858): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 4396
06-01 12:18:45.733+0900 W/AUL_AMD ( 2858): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 4396
06-01 12:18:45.733+0900 D/STARTER ( 2935): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 4396 is termianted
06-01 12:18:45.733+0900 D/STARTER ( 2935): starter.c: _check_dead_signal(202) > [_check_dead_signal:202] Unknown process, ignore it
06-01 12:18:45.733+0900 D/AUL_AMD ( 2858): amd_key.c: _unregister_key_event(179) > ===key stack===
06-01 12:18:45.733+0900 E/AUL_AMD ( 2858): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
06-01 12:18:45.733+0900 D/AUL_AMD ( 2858): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.example.example)
06-01 12:18:45.733+0900 D/AUL     ( 2858): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-01 12:18:45.733+0900 E/AUL     ( 2858): simple_util.c: __trm_app_info_send_socket(330) > access
06-01 12:18:45.743+0900 E/RESOURCED( 2893): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.271
06-01 12:18:45.743+0900 E/E17     ( 2741): e_border.c: e_border_show(2088) > BD_SHOW(0x01600002)
06-01 12:18:45.743+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2945
06-01 12:18:45.743+0900 D/RESOURCED( 2893): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 2945, appname = org.tizen.homescreen, pkgname = org.tizen.homescreen
06-01 12:18:45.743+0900 D/RESOURCED( 2893): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2945, appname = org.tizen.homescreen
06-01 12:18:45.743+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2945
06-01 12:18:45.743+0900 D/RESOURCED( 2893): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 4396
06-01 12:18:45.743+0900 D/RESOURCED( 2893): appinfo-list.c: resourced_appinfo_put(132) > appid org.example.example, pkgname = org.example.example, ref = 0
06-01 12:18:45.753+0900 W/CRASH_MANAGER( 4605): worker.c: worker_job(1204) > 1104396657861149628712
