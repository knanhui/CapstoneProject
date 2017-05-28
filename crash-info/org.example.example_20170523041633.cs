S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 17037
Date: 2017-05-23 04:16:32+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x28

Register Information
gs  = 0x00000033, fs  = 0xc1640000
es  = 0xffff007b, ds  = 0x0000007b
edi = 0x00000000, esi = 0xb8af0200
ebp = 0xbfa2a9f8, esp = 0xbfa2a9a0
eax = 0xb42b5000, ebx = 0xb73285f0
ecx = 0xb42b5030, edx = 0xb42b5030
eip = 0xb7134cb6

Memory Information
MemTotal:      123 KB
MemFree:        26 KB
Buffers:         8 KB
Cached:     169612 KB
VmPeak:     113452 KB
VmSize:     113452 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       26280 KB
VmRSS:       26280 KB
VmData:      44632 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33592 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 17037 TID = 17037
17037 17038 17226 17227 17231 

Maps Information
b1994000 b1998000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2c6d000 b2c77000 r-xp /usr/lib/libfeedback.so.0.1.4
b2c7d000 b2c89000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2c8a000 b2cab000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2cb0000 b2cb1000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2cb2000 b2cb7000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2cb8000 b2cba000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2cbb000 b2cbd000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2cbe000 b2cca000 r-xp /usr/lib/libdrm.so.2.4.0
b2ccb000 b2cd5000 r-xp /usr/lib/libtbm.so.1.0.0
b2cd6000 b2ceb000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2cec000 b2cfe000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3500000 b3509000 r-xp /usr/lib/libeventsystem.so.0.0.1
b350a000 b3513000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3514000 b3526000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3527000 b3548000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b354f000 b3550000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3551000 b3552000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3553000 b3556000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3557000 b355a000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3662000 b3668000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3669000 b37ad000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37bd000 b37be000 r-xp /usr/lib/libxshmfence.so.1.0.0
b37bf000 b37c2000 r-xp /usr/lib/libdri2.so.0.0.0
b37c3000 b37c4000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37c5000 b37cd000 r-xp /opt/usr/apps/org.example.example/bin/example
b37cf000 b3808000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b420b000 b4216000 r-xp /lib/libnss_files-2.20-2014.11.so
b4218000 b4223000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4225000 b423c000 r-xp /lib/libnsl-2.20-2014.11.so
b4240000 b4248000 r-xp /lib/libnss_compat-2.20-2014.11.so
b424a000 b426e000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b426f000 b4270000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4271000 b4274000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4275000 b427c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b427d000 b4287000 r-xp /usr/lib/libsensord-share.so
b4288000 b42a4000 r-xp /usr/lib/libsensor.so.1.2.0
b42a6000 b42af000 r-xp /usr/lib/libappcore-common.so.1.1
b42b2000 b42b4000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42c9000 b42cb000 r-xp /usr/lib/libXau.so.6.0.0
b42cc000 b42ee000 r-xp /usr/lib/libxcb.so.1.1.0
b42f0000 b42f9000 r-xp /lib/libcrypt-2.20-2014.11.so
b4322000 b4324000 r-xp /usr/lib/libiri.so
b4325000 b434b000 r-xp /lib/libexpat.so.1.5.2
b434d000 b43b8000 r-xp /usr/lib/libssl.so.1.0.0
b43be000 b43ca000 r-xp /usr/lib/libethumb.so.1.13.0
b43cb000 b43cf000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43d0000 b4621000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b9c000 b5bac000 r-xp /usr/lib/libXi.so.6.1.0
b5bad000 b5baf000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bb0000 b5bb6000 r-xp /usr/lib/libXtst.so.6.1.0
b5bb7000 b5bc1000 r-xp /usr/lib/libXrender.so.1.3.0
b5bc2000 b5bcb000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bcd000 b5bcf000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bd0000 b5bd5000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bd6000 b5be8000 r-xp /usr/lib/libXext.so.6.4.0
b5be9000 b5beb000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bec000 b5bee000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bf0000 b5d32000 r-xp /usr/lib/libX11.so.6.3.0
b5d36000 b5d40000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d41000 b5d57000 r-xp /usr/lib/libudev.so.1.6.0
b5d5a000 b5d5e000 r-xp /lib/libattr.so.1.1.0
b5d5f000 b5d8e000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d90000 b5d96000 r-xp /usr/lib/libffi.so.6.0.2
b5d97000 b5dba000 r-xp /lib/libz.so.1.2.8
b5dbb000 b5dbe000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5dbf000 b5f1b000 r-xp /usr/lib/libxml2.so.2.9.2
b5f21000 b6008000 r-xp /usr/lib/libstdc++.so.6.0.20
b6015000 b6018000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6019000 b603b000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b603c000 b6050000 r-xp /lib/libresolv-2.20-2014.11.so
b6054000 b6078000 r-xp /usr/lib/liblzma.so.5.0.3
b6079000 b607b000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b607d000 b6087000 r-xp /usr/lib/libembryo.so.1.13.0
b6088000 b60b1000 r-xp /usr/lib/libpng12.so.0.50.0
b60b2000 b60fb000 r-xp /usr/lib/libjpeg.so.8.0.2
b610c000 b6113000 r-xp /lib/librt-2.20-2014.11.so
b6115000 b6134000 r-xp /usr/lib/libector.so.1.13.0
b6137000 b6164000 r-xp /usr/lib/liblua-5.1.so
b6165000 b61f5000 r-xp /usr/lib/libfreetype.so.6.11.3
b61f9000 b6237000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6238000 b624e000 r-xp /usr/lib/libfribidi.so.0.3.1
b624f000 b62a8000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62ab000 b62f6000 r-xp /lib/libm-2.20-2014.11.so
b62f8000 b630a000 r-xp /usr/lib/libeio.so.1.13.0
b630b000 b630e000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b630f000 b6315000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6316000 b6339000 r-xp /usr/lib/libefreet.so.1.13.0
b633c000 b6367000 r-xp /usr/lib/libeldbus.so.1.13.0
b6368000 b639c000 r-xp /usr/lib/libecore_con.so.1.13.0
b639e000 b63a7000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63a8000 b63b1000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63b2000 b63c5000 r-xp /usr/lib/libeo.so.1.13.0
b63c7000 b63da000 r-xp /usr/lib/libecore_input.so.1.13.0
b63db000 b63e2000 r-xp /usr/lib/libecore_file.so.1.13.0
b63e3000 b6406000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6407000 b6433000 r-xp /usr/lib/libeet.so.1.13.0
b643c000 b64a7000 r-xp /usr/lib/libeina.so.1.13.0
b64aa000 b64c1000 r-xp /usr/lib/libefl.so.1.13.0
b64c3000 b662a000 r-xp /usr/lib/libicuuc.so.51.1
b6638000 b6844000 r-xp /usr/lib/libicui18n.so.51.1
b684c000 b689b000 r-xp /usr/lib/libecore_x.so.1.13.0
b689d000 b68b7000 r-xp /lib/libgcc_s-4.9.so.1
b68b9000 b68bd000 r-xp /lib/libcap.so.2.21
b68be000 b6904000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6905000 b690c000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b690e000 b6960000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6962000 b6aed000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6af2000 b6bc0000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bc3000 b6bc7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bc8000 b6bd7000 r-xp /usr/lib/libvconf.so.0.2.45
b6bd8000 b6bdb000 r-xp /usr/lib/libvasum.so.0.3.1
b6bdc000 b6bdf000 r-xp /usr/lib/libttrace.so.1.1
b6be1000 b6be5000 r-xp /usr/lib/libiniparser.so.0
b6be6000 b6c16000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c17000 b6c20000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c21000 b6c46000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c47000 b6c57000 r-xp /usr/lib/libunwind.so.8.0.1
b6c61000 b6e0f000 r-xp /lib/libc-2.20-2014.11.so
b6e17000 b6f5a000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f5c000 b6fb4000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fb5000 b6fe9000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fec000 b70c0000 r-xp /usr/lib/libedje.so.1.13.0
b70c3000 b70ef000 r-xp /usr/lib/libecore.so.1.13.0
b7100000 b7326000 r-xp /usr/lib/libevas.so.1.13.0
b734e000 b7366000 r-xp /lib/libpthread-2.20-2014.11.so
b736a000 b76e4000 r-xp /usr/lib/libelementary.so.1.13.0
b7704000 b7708000 r-xp /usr/lib/libsmack.so.1.0.0
b7709000 b7712000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7713000 b7716000 r-xp /usr/lib/libdlog.so.0.0.0
b7717000 b771c000 r-xp /usr/lib/libbundle.so.0.1.22
b771d000 b7720000 r-xp /lib/libdl-2.20-2014.11.so
b7722000 b7747000 r-xp /usr/lib/libaul.so.0.1.0
b774a000 b774c000 r-xp /usr/lib/libappsvc.so.0.1.0
b774d000 b7752000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7753000 b775a000 r-xp /usr/lib/libappcore-efl.so.1.1
b775c000 b7761000 r-xp /usr/lib/libsys-assert.so
b7764000 b7765000 r-xp [vdso]
b7765000 b7787000 r-xp /lib/ld-2.20-2014.11.so
b7789000 b7791000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:17037)
Call Stack Count: 28
 0: evas_object_event_callback_priority_add + 0xe6 (0xb7134cb6) [/usr/lib/libevas.so.1] + 0x34cb6
 1: evas_object_event_callback_add + 0x38 (0xb7134d48) [/usr/lib/libevas.so.1] + 0x34d48
 2: (0xb740f497) [/usr/lib/libelementary.so.1] + 0xa5497
 3: (0xb740f952) [/usr/lib/libelementary.so.1] + 0xa5952
 4: elm_obj_container_content_set + 0xb3 (0xb7466393) [/usr/lib/libelementary.so.1] + 0xfc393
 5: elm_widget_content_part_set + 0x71 (0xb75d9b41) [/usr/lib/libelementary.so.1] + 0x26fb41
 6: elm_object_part_content_set + 0x2f (0xb7532b3f) [/usr/lib/libelementary.so.1] + 0x1c8b3f
 7: make_popup_time + 0x286 (0xb37c8da6) [/opt/usr/apps/org.example.example/bin/example] + 0x3da6
 8: (0xb7189116) [/usr/lib/libevas.so.1] + 0x89116
 9: (0xb63c0319) [/usr/lib/libeo.so.1] + 0xe319
10: eo_event_callback_call + 0xb3 (0xb63bdd63) [/usr/lib/libeo.so.1] + 0xbd63
11: evas_object_smart_callback_call + 0x75 (0xb718b9e5) [/usr/lib/libevas.so.1] + 0x8b9e5
12: (0xb743c404) [/usr/lib/libelementary.so.1] + 0xd2404
13: (0xb706ff39) [/usr/lib/libedje.so.1] + 0x83f39
14: (0xb7076a11) [/usr/lib/libedje.so.1] + 0x8aa11
15: (0xb7070fdc) [/usr/lib/libedje.so.1] + 0x84fdc
16: (0xb70714cb) [/usr/lib/libedje.so.1] + 0x854cb
17: (0xb707168f) [/usr/lib/libedje.so.1] + 0x8568f
18: (0xb70d6702) [/usr/lib/libecore.so.1] + 0x13702
19: (0xb70d0055) [/usr/lib/libecore.so.1] + 0xd055
20: (0xb70d91b9) [/usr/lib/libecore.so.1] + 0x161b9
21: ecore_main_loop_begin + 0x57 (0xb70d9587) [/usr/lib/libecore.so.1] + 0x16587
22: elm_run + 0x2d (0xb753222d) [/usr/lib/libelementary.so.1] + 0x1c822d
23: appcore_efl_main + 0x4de (0xb7756dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
24: ui_app_main + 0x140 (0xb774fc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
25: main + 0x27e (0xb37ca19e) [/opt/usr/apps/org.example.example/bin/example] + 0x519e
26: diary_view_cb + 0x18 (0xb778b148) [/opt/usr/apps/org.example.example/bin/example] + 0xb778b148
27: __libc_start_main + 0xde (0xb6c78e4e) [/lib/libc.so.6] + 0x17e4e
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
l_percent], value=[100]
05-23 04:16:14.307+0900 W/cluster-home( 2918): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.example]
05-23 04:16:14.307+0900 D/PKGMGR  ( 2918): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1270852662], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-23 04:16:14.307+0900 D/cluster-home( 2918): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29180003] pkg_type[tpk] package[org.example.example] key[install_percent] val[100] pmsg[(null)]
05-23 04:16:14.307+0900 D/PKGMGR  (17163): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1270852662], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-23 04:16:14.307+0900 D/PKGMGR  ( 2983): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1270852662], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-23 04:16:14.307+0900 D/ESD     ( 2983): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29830002), pkg_type(tpk), pkgid(org.example.example), key(install_percent), val(100)
05-23 04:16:14.307+0900 D/PKGMGR  ( 3113): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1270852662], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-23 04:16:14.317+0900 D/PKGMGR  ( 2973): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1270852662], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-23 04:16:14.317+0900 D/DATA_PROVIDER_MASTER( 2973): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.example] 100
05-23 04:16:14.317+0900 D/PKGMGR  (17163): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1270852662], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-23 04:16:14.317+0900 D/PKGMGR  ( 2978): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1270852662], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-23 04:16:14.317+0900 D/QUICKPANEL( 2978): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:end val:ok
05-23 04:16:14.327+0900 D/PKGMGR  ( 3069): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1270852662], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-23 04:16:14.347+0900 D/PKGMGR  ( 2985): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1270852662], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-23 04:16:14.347+0900 D/PKGMGR  ( 3069): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1270852662], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-23 04:16:14.357+0900 D/PKGMGR  ( 2918): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1270852662], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-23 04:16:14.357+0900 W/cluster-home( 2918): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[2], package[org.example.example]
05-23 04:16:14.357+0900 D/cluster-home( 2918): widget-data-provider.cpp: PackageUpdated(2160) >  No boxes that pkgname is[org.example.example]
05-23 04:16:14.367+0900 D/PKGMGR  ( 2992): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1270852662], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-23 04:16:14.367+0900 D/PKGMGR  ( 2992): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
05-23 04:16:14.367+0900 D/PKGMGR  ( 2983): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1270852662], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-23 04:16:14.367+0900 D/ESD     ( 2983): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29830002), pkg_type(tpk), pkgid(org.example.example), key(end), val(ok)
05-23 04:16:14.367+0900 D/ESD     ( 2983): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
05-23 04:16:14.367+0900 D/PKGMGR  ( 2973): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1270852662], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-23 04:16:14.367+0900 D/DATA_PROVIDER_MASTER( 2973): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.example] ok
05-23 04:16:14.367+0900 D/DATA_PROVIDER_MASTER( 2973): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.example], event_type[1]
05-23 04:16:14.367+0900 D/DATA_PROVIDER_MASTER( 2973): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
05-23 04:16:14.377+0900 D/DATA_PROVIDER_MASTER( 2973): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
05-23 04:16:14.377+0900 D/DATA_PROVIDER_MASTER( 2973): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
05-23 04:16:14.377+0900 D/DATA_PROVIDER_MASTER( 2973): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.example]
05-23 04:16:14.377+0900 D/PKGMGR  ( 2918): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1270852662], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-23 04:16:14.377+0900 D/cluster-home( 2918): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29180003] pkg_type[tpk] package[org.example.example] key[end] val[ok] pmsg[(null)]
05-23 04:16:14.377+0900 E/cluster-home( 2918): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
05-23 04:16:14.377+0900 E/cluster-home( 2918): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
05-23 04:16:14.377+0900 E/cluster-home( 2918): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
05-23 04:16:14.387+0900 D/ISF_PANEL_EFL( 3069): isf_panel_efl.cpp: _package_manager_event_cb(1288) > type=tpk package=org.example.example event_type=UPDATE event_state=COMPLETED progress=100 error=0
05-23 04:16:14.387+0900 D/PKGMGR  ( 2832): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[upgrade], req_id=[org.example.example_-1270852662], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-23 04:16:14.387+0900 D/AUL_AMD ( 2832): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.example), key(end), value(ok)
05-23 04:16:14.387+0900 W/AUL_AMD ( 2832): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(update), value(ok)
05-23 04:16:14.397+0900 D/PKGMGR  ( 3113): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1270852662], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-23 04:16:14.417+0900 D/AUL_AMD ( 2832): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.example, type:rpm
05-23 04:16:14.467+0900 W/ISF_PANEL_EFL( 3069): isf_panel_efl.cpp: _package_manager_event_cb(1380) > isf_db_select_appids_by_pkgid returned 0.
05-23 04:16:14.477+0900 D/cluster-home( 2918): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
05-23 04:16:14.477+0900 D/cluster-home( 2918): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.example]
05-23 04:16:14.477+0900 E/cluster-home( 2918): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.example]
05-23 04:16:14.477+0900 E/cluster-home( 2918): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.example]
05-23 04:16:14.477+0900 E/cluster-home( 2918): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
05-23 04:16:14.477+0900 E/cluster-home( 2918): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
05-23 04:16:14.477+0900 E/cluster-home( 2918): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.example]
05-23 04:16:14.487+0900 E/cluster-home( 2918): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.example] Name[forpet] Icon[/opt/usr/apps/org.example.example/shared/res/1.jpg] enable[1] system[0]
05-23 04:16:14.487+0900 D/cluster-home( 2918): mainmenu-presenter.cpp: OnAppUpdated(337) >  pAppId [org.example.example]
05-23 04:16:14.487+0900 D/cluster-home( 2918): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.example
05-23 04:16:14.487+0900 D/cluster-home( 2918): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[14], isFolder[0], pageId[1], col[2], row[4], appId[org.example.example], name[forpet], menuId[1], isPreload[0] isPreload[0]
05-23 04:16:14.487+0900 D/cluster-home( 2918): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
05-23 04:16:14.487+0900 E/cluster-home( 2918): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.example] Name[forpet] Icon[/opt/usr/apps/org.example.example/shared/res/1.jpg] enable[1] system[0]
05-23 04:16:14.487+0900 D/cluster-home( 2918): mainmenu-presenter.cpp: OnAppUpdated(364) >  name [forpet]
05-23 04:16:14.487+0900 D/cluster-home( 2918): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
05-23 04:16:14.497+0900 D/cluster-home( 2918): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
05-23 04:16:14.497+0900 D/test-log( 2918): mainmenu-box-impl.cpp: UpdateBoxData(812) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.example/shared/res/1.jpg], New icon path[/opt/usr/apps/org.example.example/shared/res/1.jpg]!!!!!
05-23 04:16:14.497+0900 D/cluster-home( 2918): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 1, appId = $appId, name = $name, col = 2, row = 4, isPreload = 0, isSystem = 0 WHERE boxId = 14]
05-23 04:16:15.157+0900 E/PKGMGR_SERVER(17165): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
05-23 04:16:16.997+0900 E/PKGMGR_SERVER(17165): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
05-23 04:16:17.037+0900 D/rpm-installer(17168): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
05-23 04:16:17.037+0900 D/rpm-installer(17168): rpm-appcore-intf.c: main(259) > ------------------------------------------------
05-23 04:16:17.037+0900 D/rpm-installer(17168): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
05-23 04:16:17.037+0900 D/rpm-installer(17168): rpm-appcore-intf.c: main(261) > ------------------------------------------------
05-23 04:16:17.097+0900 D/PKGMGR_SERVER(17165): pkgmgr-server.c: sighandler(387) > child exit [17168]
05-23 04:16:17.097+0900 E/PKGMGR_SERVER(17165): pkgmgr-server.c: sighandler(402) > child NORMAL exit [17168]
05-23 04:16:18.997+0900 E/PKGMGR_SERVER(17165): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
05-23 04:16:19.007+0900 E/PKGMGR_SERVER(17165): pkgmgr-server.c: main(2265) > package manager server terminated.
05-23 04:16:21.687+0900 D/AUL_AMD ( 2832): amd_request.c: __request_handler(838) > __request_handler: 0
05-23 04:16:21.727+0900 D/AUL_AMD ( 2832): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
05-23 04:16:21.727+0900 D/PKGMGR_INFO( 2832): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
05-23 04:16:21.727+0900 D/PKGMGR_INFO( 2832): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
05-23 04:16:21.737+0900 I/AUL     ( 2832): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
05-23 04:16:21.737+0900 D/AUL     ( 2832): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 17220, pid = 17222
05-23 04:16:21.737+0900 D/PKGMGR_INFO( 2832): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
05-23 04:16:21.737+0900 D/PKGMGR_INFO( 2832): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
05-23 04:16:21.747+0900 I/AUL     ( 2832): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
05-23 04:16:21.757+0900 E/AUL_AMD ( 2832): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
05-23 04:16:21.757+0900 W/AUL_AMD ( 2832): amd_launch.c: _start_app(2233) > caller pid : 17222
05-23 04:16:21.757+0900 E/AUL_AMD ( 2832): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
05-23 04:16:21.757+0900 W/AUL_AMD ( 2832): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
05-23 04:16:21.767+0900 D/AUL_AMD ( 2832): amd_launch.c: _start_app(2648) > process_pool: false
05-23 04:16:21.767+0900 D/AUL_AMD ( 2832): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
05-23 04:16:21.767+0900 D/AUL_AMD ( 2832): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
05-23 04:16:21.767+0900 W/AUL_AMD ( 2832): amd_launch.c: _start_app(2665) > pad pid(-5)
05-23 04:16:21.767+0900 D/AUL_AMD ( 2832): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
05-23 04:16:21.767+0900 D/AUL_AMD ( 2832): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
05-23 04:16:21.767+0900 D/AUL     ( 2832): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
05-23 04:16:21.777+0900 D/AUL_PAD ( 2966): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
05-23 04:16:21.777+0900 D/AUL_PAD ( 2966): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
05-23 04:16:21.777+0900 D/AUL_PAD ( 2966): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-23 04:16:21.777+0900 D/AUL_PAD ( 2966): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-23 04:16:21.777+0900 D/AUL_PAD ( 2966): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-23 04:16:21.777+0900 D/AUL_PAD ( 2966): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-23 04:16:21.777+0900 D/AUL_PAD ( 2966): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-23 04:16:21.777+0900 D/AUL_PAD ( 2966): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
05-23 04:16:21.777+0900 D/RESOURCED( 2897): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
05-23 04:16:21.777+0900 D/RESOURCED( 2897): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
05-23 04:16:21.777+0900 D/AUL_PAD ( 2966): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
05-23 04:16:21.777+0900 D/AUL_PAD ( 2966): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
05-23 04:16:21.777+0900 D/AUL_PAD ( 2966): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
05-23 04:16:21.777+0900 D/AUL_PAD ( 2966): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
05-23 04:16:21.777+0900 D/AUL_PAD ( 2966): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
05-23 04:16:21.777+0900 D/AUL_PAD ( 2966): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
05-23 04:16:21.777+0900 W/AUL_PAD ( 2966): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
05-23 04:16:21.777+0900 E/RESOURCED( 2897): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
05-23 04:16:21.777+0900 D/AUL     ( 2966): process_pool.c: __send_pkt_raw_data(219) > send(13) : 624 / 624
05-23 04:16:21.777+0900 D/AUL_PAD ( 2966): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 17037, bin path: /opt/usr/apps/org.example.example/bin/example
05-23 04:16:21.777+0900 W/AUL_PAD ( 2966): launchpad.c: __send_result_to_caller(265) > Check app launching
05-23 04:16:21.777+0900 D/AUL_PAD ( 2966): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
05-23 04:16:21.787+0900 D/AUL_PAD (17037): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
05-23 04:16:21.797+0900 D/AUL_PAD (17037): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
05-23 04:16:21.797+0900 D/AUL_PAD (17037): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
05-23 04:16:21.807+0900 D/AUL_PAD (17037): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
05-23 04:16:21.807+0900 D/AUL_PAD (17037): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
05-23 04:16:21.807+0900 D/AUL_PAD (17037): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
05-23 04:16:21.807+0900 D/AUL     (17037): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (17038) is sent.
05-23 04:16:21.807+0900 D/AUL     (17037): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 17038, signo: 10
05-23 04:16:21.807+0900 D/AUL     (17037): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
05-23 04:16:21.807+0900 D/AUL_PAD (17037): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
05-23 04:16:21.807+0900 D/AUL_PAD (17037): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
05-23 04:16:21.807+0900 D/AUL_PAD (17037): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
05-23 04:16:21.807+0900 D/AUL_PAD (17037): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
05-23 04:16:21.807+0900 D/AUL_PAD (17037): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTU0ODA1ODEvNjk0NTk4AA==##
05-23 04:16:21.807+0900 D/AUL_PAD (17037): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
05-23 04:16:21.807+0900 D/AUL_PAD (17037): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAxNzIyMgA=##
05-23 04:16:21.807+0900 D/AUL_PAD (17037): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
05-23 04:16:21.807+0900 D/AUL_PAD (17037): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
05-23 04:16:21.807+0900 D/AUL_PAD (17037): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
05-23 04:16:21.807+0900 D/AUL_PAD (17037): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
05-23 04:16:21.807+0900 D/AUL_PAD (17037): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
05-23 04:16:21.837+0900 I/CAPI_APPFW_APPLICATION(17037): app_main.c: ui_app_main(788) > app_efl_main
05-23 04:16:21.837+0900 D/LAUNCH  (17037): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
05-23 04:16:21.837+0900 D/APP_CORE(17037): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
05-23 04:16:21.837+0900 D/APP_CORE(17037): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
05-23 04:16:21.837+0900 D/APP_CORE(17037): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
05-23 04:16:21.887+0900 D/AUL_PAD ( 2966): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
05-23 04:16:21.977+0900 D/APP_CORE(17037): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
05-23 04:16:21.987+0900 D/AUL     (17037): app_sock.c: __create_server_sock(156) > pg path - already exists
05-23 04:16:21.987+0900 D/AUL_PAD ( 2966): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
05-23 04:16:21.987+0900 D/APP_CORE(17037): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42af520
05-23 04:16:21.997+0900 W/AUL     ( 2832): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 17037, appid: org.example.example
05-23 04:16:21.997+0900 D/LAUNCH  (17037): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
05-23 04:16:21.997+0900 I/CAPI_APPFW_APPLICATION(17037): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
05-23 04:16:22.007+0900 D/AUL     ( 2832): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
05-23 04:16:22.007+0900 E/AUL     ( 2832): simple_util.c: __trm_app_info_send_socket(330) > access
05-23 04:16:22.007+0900 D/AUL_AMD ( 2832): amd_launch.c: _start_app(2700) > add app group info
05-23 04:16:22.007+0900 E/AUL     ( 2832): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
05-23 04:16:22.007+0900 D/AUL_AMD ( 2832): amd_status.c: _status_add_app_info_list(427) > pid(17037) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
05-23 04:16:22.017+0900 D/RESOURCED( 2897): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 17037
05-23 04:16:22.017+0900 D/RESOURCED( 2897): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
05-23 04:16:22.017+0900 E/RESOURCED( 2897): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
05-23 04:16:22.017+0900 D/RESOURCED( 2897): proc-main.c: resourced_proc_status_change(888) > available memory = 317
05-23 04:16:22.687+0900 D/LAUNCH  (17037): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
05-23 04:16:22.727+0900 D/APP_CORE(17037): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
05-23 04:16:22.767+0900 E/E17     ( 2842): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02000002)
05-23 04:16:22.997+0900 D/APP_CORE(17037): appcore.c: __aul_handler(587) > [APP 17037]     AUL event: AUL_START
05-23 04:16:22.997+0900 I/APP_CORE(17037): appcore-efl.c: __do_app(496) > [APP 17037] Event: RESET State: CREATED
05-23 04:16:22.997+0900 D/APP_CORE(17037): appcore-efl.c: __do_app(527) > [APP 17037] RESET
05-23 04:16:22.997+0900 D/LAUNCH  (17037): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
05-23 04:16:22.997+0900 D/APP_CORE(17037): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
05-23 04:16:22.997+0900 D/APP_CORE(17037): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-23 04:16:22.997+0900 I/CAPI_APPFW_APPLICATION(17037): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
05-23 04:16:22.997+0900 D/AUL     (17037): service.c: __set_bundle(186) > __set_bundle
05-23 04:16:22.997+0900 D/LAUNCH  (17037): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
05-23 04:16:22.997+0900 D/APP_CORE(17037): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
05-23 04:16:22.997+0900 E/EFL     (17037): edje<17037> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-23 04:16:22.997+0900 E/EFL     (17037): By the power of Grayskull, your previous Embryo stack is now broken!
05-23 04:16:23.007+0900 E/EFL     (17037): edje<17037> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-23 04:16:23.007+0900 E/EFL     (17037): By the power of Grayskull, your previous Embryo stack is now broken!
05-23 04:16:23.007+0900 E/EFL     (17037): edje<17037> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-23 04:16:23.007+0900 E/EFL     (17037): By the power of Grayskull, your previous Embryo stack is now broken!
05-23 04:16:23.007+0900 E/EFL     (17037): edje<17037> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-23 04:16:23.007+0900 E/EFL     (17037): By the power of Grayskull, your previous Embryo stack is now broken!
05-23 04:16:23.007+0900 E/EFL     (17037): edje<17037> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-23 04:16:23.007+0900 E/EFL     (17037): By the power of Grayskull, your previous Embryo stack is now broken!
05-23 04:16:23.017+0900 D/AUL_PAD (17229): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
05-23 04:16:23.017+0900 D/AUL_AMD ( 2832): amd_launch.c: __grab_timeout_handler(1445) > pid(17037) ecore_x_pointer_ungrab
05-23 04:16:23.017+0900 D/AUL_AMD ( 2832): amd_key.c: _key_ungrab(265) > _key_ungrab, win : 600002
05-23 04:16:23.027+0900 W/AUL_AMD ( 2832): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-23 04:16:23.027+0900 W/AUL_AMD ( 2832): amd_launch.c: __grab_timeout_handler(1447) > back key ungrab error
05-23 04:16:23.047+0900 D/AUL_PAD ( 2966): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
05-23 04:16:23.177+0900 D/AUL_PAD ( 2966): sigchild.h: __send_app_launch_signal(131) > send launch signal done
05-23 04:16:23.217+0900 E/RESOURCED( 2897): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1147
05-23 04:16:23.287+0900 E/E17     ( 2842): e_border.c: e_border_show(2088) > BD_SHOW(0x02000002)
05-23 04:16:23.397+0900 D/APP_CORE(17037): appcore.c: __prt_ltime(236) > [APP 17037] first idle after reset: 1714 msec
05-23 04:16:23.517+0900 D/AUL_AMD ( 2832): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
05-23 04:16:23.527+0900 D/RUA     ( 2832): rua.c: rua_add_history(179) > rua_add_history start
05-23 04:16:23.637+0900 W/APP_CORE(17037): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2000002
05-23 04:16:23.647+0900 D/APP_CORE(17037): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2000002
05-23 04:16:23.647+0900 D/APP_CORE(17037): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
05-23 04:16:23.647+0900 D/AUL     (17037): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
05-23 04:16:23.657+0900 W/PROCESSMGR( 2842): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=17037
05-23 04:16:23.687+0900 D/RUA     ( 2832): rua.c: rua_add_history(247) > rua_add_history ok
05-23 04:16:23.717+0900 D/AUL_AMD ( 2832): amd_request.c: __request_handler(838) > __request_handler: 34
05-23 04:16:23.727+0900 E/EFL     ( 2842): eo<2842> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-23 04:16:23.727+0900 E/EFL     ( 2842): eo<2842> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-23 04:16:23.857+0900 D/INDICATOR( 2900): main.c: _property_changed_cb(432) > UNSNIFF API 1400002
05-23 04:16:23.867+0900 D/INDICATOR( 2900): util.c: util_signal_emit_by_win(116) > emission bg.opaque
05-23 04:16:23.867+0900 D/AUL_AMD ( 2832): amd_request.c: __request_handler(838) > __request_handler: 15
05-23 04:16:23.877+0900 D/PKGMGR_INFO( 2832): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-23 04:16:23.877+0900 D/PKGMGR_INFO( 2832): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-23 04:16:23.887+0900 D/AUL_AMD ( 2832): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 17037 is org.example.example
05-23 04:16:23.897+0900 D/AUL_AMD ( 2832): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 17037 : 0
05-23 04:16:23.897+0900 D/AUL     ( 2985): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
05-23 04:16:23.897+0900 D/INDICATOR( 2900): main.c: _rotate_window(229) > Indicator angle is 0 degree
05-23 04:16:23.897+0900 D/INDICATOR( 2900): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
05-23 04:16:23.897+0900 D/INDICATOR( 2900): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
05-23 04:16:23.897+0900 D/INDICATOR( 2900): main.c: _rotate_window(252) > port :: hide more icon
05-23 04:16:24.397+0900 D/AUL_PAD (17229): launchpad_loader.c: main(588) > sleeping 1 sec...
05-23 04:16:24.397+0900 D/AUL_PAD (17229): preload.h: __preload_init(52) > max_cmdline_size = 1053
05-23 04:16:24.457+0900 D/AUL_PAD (17229): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b8beb760
05-23 04:16:24.477+0900 D/AUL_PAD (17229): preload.h: __preload_init(69) > get pre-initialization function
05-23 04:16:24.477+0900 D/AUL_PAD (17229): preload.h: __preload_init(73) > get shutdown function
05-23 04:16:24.497+0900 D/AUL_PAD (17229): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b8beba40
05-23 04:16:24.867+0900 D/AUL_PAD (17229): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b8bed640
05-23 04:16:24.867+0900 D/AUL_PAD (17229): preload.h: __preload_init(69) > get pre-initialization function
05-23 04:16:24.867+0900 D/AUL_PAD (17229): preload.h: __preload_init(73) > get shutdown function
05-23 04:16:24.867+0900 D/AUL_PAD (17229): preexec.h: __preexec_init(76) > preexec start
05-23 04:16:24.867+0900 D/AUL_PAD (17229): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
05-23 04:16:24.867+0900 D/AUL     (17229): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
05-23 04:16:24.867+0900 D/AUL     (17229): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
05-23 04:16:24.887+0900 D/AUL     (17229): process_pool.c: __connect_to_launchpad(132) > send(17229) : 4
05-23 04:16:24.887+0900 D/AUL     (17229): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
05-23 04:16:24.887+0900 D/AUL_PAD ( 2966): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-23 04:16:24.887+0900 D/AUL_PAD ( 2966): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
05-23 04:16:24.887+0900 D/AUL_PAD ( 2966): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-23 04:16:24.887+0900 D/AUL_PAD ( 2966): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-23 04:16:24.887+0900 D/AUL_PAD ( 2966): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-23 04:16:24.887+0900 D/AUL_PAD ( 2966): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-23 04:16:24.887+0900 D/AUL_PAD ( 2966): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-23 04:16:24.887+0900 D/AUL_PAD ( 2966): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
05-23 04:16:24.887+0900 D/AUL_PAD ( 2966): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 17229
05-23 04:16:25.007+0900 E/RESOURCED( 2897): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1148
05-23 04:16:25.687+0900 E/CAPI_NETWORK_WIFI( 2900): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
05-23 04:16:25.687+0900 E/INDICATOR( 2900): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
05-23 04:16:25.687+0900 E/INDICATOR( 2900): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
05-23 04:16:25.687+0900 E/INDICATOR( 2900): 
05-23 04:16:26.647+0900 E/E17     ( 2842): e_border.c: e_border_hide(2248) > BD_HIDE(0x01400002), visible:1
05-23 04:16:26.687+0900 D/APP_CORE( 2918): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1400002 fully_obscured 1
05-23 04:16:26.687+0900 D/APP_CORE(17037): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2000002 fully_obscured 0
05-23 04:16:26.687+0900 D/APP_CORE( 2918): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
05-23 04:16:26.687+0900 D/APP_CORE( 2918): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
05-23 04:16:26.687+0900 I/APP_CORE( 2918): appcore-efl.c: __do_app(496) > [APP 2918] Event: PAUSE State: RUNNING
05-23 04:16:26.687+0900 D/APP_CORE( 2918): appcore-efl.c: __do_app(565) > [APP 2918] PAUSE
05-23 04:16:26.687+0900 I/CAPI_APPFW_APPLICATION( 2918): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
05-23 04:16:26.687+0900 E/cluster-home( 2918): homescreen.cpp: OnPause(84) >  app pause
05-23 04:16:26.687+0900 D/APP_CORE(17037): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
05-23 04:16:26.687+0900 D/APP_CORE(17037): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
05-23 04:16:26.687+0900 I/APP_CORE(17037): appcore-efl.c: __do_app(496) > [APP 17037] Event: RESUME State: CREATED
05-23 04:16:26.687+0900 D/LAUNCH  (17037): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
05-23 04:16:26.687+0900 D/APP_CORE(17037): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
05-23 04:16:26.687+0900 D/APP_CORE(17037): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-23 04:16:26.687+0900 D/APP_CORE(17037): appcore-efl.c: __do_app(607) > [APP 17037] RESUME
05-23 04:16:26.697+0900 D/cluster-view( 2918): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
05-23 04:16:26.697+0900 D/cluster-view( 2918): homescreen-view-manager.cpp: AppPause(923) >  END
05-23 04:16:26.697+0900 D/APP_CORE( 2918): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-23 04:16:26.697+0900 E/APP_CORE( 2918): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-23 04:16:26.787+0900 D/DATA_PROVIDER_MASTER( 2973): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2918 is paused
05-23 04:16:26.787+0900 D/DATA_PROVIDER_MASTER( 2973): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
05-23 04:16:26.867+0900 I/CAPI_WIDGET_APPLICATION( 3067): widget_app.c: __provider_pause_cb(294) > widget obj was paused
05-23 04:16:26.877+0900 I/APP_CORE(17037): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
05-23 04:16:26.877+0900 I/APP_CORE(17037): appcore-efl.c: __do_app(614) > [APP 17037] Initial Launching, call the resume_cb
05-23 04:16:26.877+0900 I/CAPI_APPFW_APPLICATION(17037): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
05-23 04:16:26.877+0900 D/LAUNCH  (17037): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
05-23 04:16:26.877+0900 D/LAUNCH  (17037): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
05-23 04:16:26.877+0900 D/APP_CORE(17037): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-23 04:16:26.877+0900 E/APP_CORE(17037): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-23 04:16:26.897+0900 I/CAPI_WIDGET_APPLICATION( 3067): widget_app.c: __check_status_for_cgroup(142) > enter background group
05-23 04:16:26.897+0900 W/AUL     ( 3067): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3067, appid: org.tizen.calendar.widget, status: bg
05-23 04:16:26.967+0900 D/RESOURCED( 2897): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3067, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
05-23 04:16:26.977+0900 D/RESOURCED( 2897): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3067
05-23 04:16:26.997+0900 D/RESOURCED( 2897): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3067, appname = org.tizen.calendar.widget
05-23 04:16:26.997+0900 D/RESOURCED( 2897): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3067
05-23 04:16:27.007+0900 D/AUL_AMD ( 2832): amd_status.c: _status_update_app_info_list(456) > pid(2918) status(4)
05-23 04:16:27.007+0900 D/AUL_AMD ( 2832): amd_status.c: _status_update_app_info_list(468) > pid(2918) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
05-23 04:16:27.007+0900 D/AUL     ( 2832): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
05-23 04:16:27.007+0900 W/AUL     ( 2832): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2918, appid: org.tizen.homescreen, status: bg
05-23 04:16:27.017+0900 D/AUL_AMD ( 2832): amd_status.c: _status_update_app_info_list(456) > pid(17037) status(4)
05-23 04:16:27.017+0900 D/AUL_AMD ( 2832): amd_status.c: _status_update_app_info_list(468) > pid(17037) appid(org.example.example) pkgid(org.example.example) status(4)
05-23 04:16:27.017+0900 D/AUL     ( 2832): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.example.example
05-23 04:16:27.017+0900 W/AUL     ( 2832): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 17037, appid: org.example.example, status: bg
05-23 04:16:27.047+0900 D/RESOURCED( 2897): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 17037, proc_name: org.example.example, cg_name: previous, oom_score_adj: 300
05-23 04:16:27.067+0900 D/RESOURCED( 2897): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 17037
05-23 04:16:27.217+0900 D/PROCESSMGR( 2842): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x20219a 
05-23 04:16:27.217+0900 D/AUL_PAD (17229): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
05-23 04:16:27.227+0900 D/AUL_AMD ( 2832): amd_launch.c: __e17_status_handler(2891) > pid(17037) status(3)
05-23 04:16:27.227+0900 D/AUL_AMD ( 2832): amd_key.c: _key_ungrab(265) > _key_ungrab, win : 600002
05-23 04:16:27.227+0900 W/AUL_AMD ( 2832): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-23 04:16:27.237+0900 W/AUL_AMD ( 2832): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
05-23 04:16:27.237+0900 D/AUL_AMD ( 2832): amd_status.c: _status_update_app_info_list(456) > pid(17037) status(3)
05-23 04:16:27.237+0900 D/AUL_AMD ( 2832): amd_status.c: _status_update_app_info_list(468) > pid(17037) appid(org.example.example) pkgid(org.example.example) status(3)
05-23 04:16:27.237+0900 D/AUL     ( 2832): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
05-23 04:16:27.237+0900 W/AUL     ( 2832): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 17037, appid: org.example.example, status: fg
05-23 04:16:27.267+0900 D/RESOURCED( 2897): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 17037
05-23 04:16:27.267+0900 D/RESOURCED( 2897): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 17037, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
05-23 04:16:27.277+0900 D/RESOURCED( 2897): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 17037
05-23 04:16:27.357+0900 D/RESOURCED( 2897): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 17037, appname = org.example.example, pkgname = org.example.example
05-23 04:16:27.377+0900 D/RESOURCED( 2897): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 17037, appname = org.example.example
05-23 04:16:27.377+0900 D/RESOURCED( 2897): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 17037
05-23 04:16:27.387+0900 I/RESOURCED( 2897): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
05-23 04:16:27.387+0900 I/RESOURCED( 2897): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
05-23 04:16:27.387+0900 D/RESOURCED( 2897): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
05-23 04:16:27.387+0900 I/RESOURCED( 2897): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
05-23 04:16:27.387+0900 D/RESOURCED( 2897): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
05-23 04:16:27.387+0900 I/RESOURCED( 2897): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
05-23 04:16:27.437+0900 D/AUL_PAD (17229): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
05-23 04:16:27.447+0900 D/AUL_PAD (17229): launchpad_loader.c: main(693) > [candidate] ecore handler add
05-23 04:16:27.477+0900 D/AUL_AMD ( 2832): amd_launch.c: __e17_status_handler(2910) > pid(17037) status(0)
05-23 04:16:27.527+0900 D/AUL_PAD (17229): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
05-23 04:16:28.227+0900 D/PROCESSMGR( 2842): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2000002
05-23 04:16:28.547+0900 D/PROCESSMGR( 2842): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x20219a 
05-23 04:16:30.807+0900 D/PROCESSMGR( 2842): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x20219a 
05-23 04:16:30.867+0900 E/EFL     (17037): edje<17037> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p15';
05-23 04:16:30.867+0900 E/EFL     (17037): By the power of Grayskull, your previous Embryo stack is now broken!
05-23 04:16:31.707+0900 D/APP_CORE( 2918): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
05-23 04:16:31.707+0900 I/APP_CORE( 2918): appcore-efl.c: __do_app(496) > [APP 2918] Event: MEM_FLUSH State: PAUSED
05-23 04:16:31.707+0900 D/APP_CORE( 2918): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
05-23 04:16:31.707+0900 D/APP_CORE( 2918): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2918
05-23 04:16:31.707+0900 D/APP_CORE( 2918): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
05-23 04:16:31.737+0900 D/RESOURCED( 2897): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2918
05-23 04:16:31.787+0900 E/EFL     (17037): eo<17037> lib/eo/eo.c:676 _eo_call_resolve() in elm_popup.eo.c:20: func 'elm_obj_popup_align_set' (1815) could not be resolved for class 'Elm_Grid'.
05-23 04:16:32.707+0900 E/EFL     (17037): edje<17037> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-23 04:16:32.737+0900 E/EFL     (17037): edje<17037> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-23 04:16:32.857+0900 E/EFL     (17037): eo<17037> lib/eo/eo.c:485 _eo_do_internal() Obj (0xa) is an invalid ref.
05-23 04:16:32.867+0900 E/EFL     (17037): eo<17037> lib/eo/eo.c:485 _eo_do_internal() Obj (0xa) is an invalid ref.
05-23 04:16:32.867+0900 E/EFL     (17037): eo<17037> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0xa) is an invalid ref.
05-23 04:16:32.867+0900 E/EFL     (17037): eo<17037> lib/eo/eo.c:485 _eo_do_internal() Obj (0xa) is an invalid ref.
05-23 04:16:33.237+0900 D/PROCESSMGR( 2842): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x20219a bd->visible=1
05-23 04:16:33.707+0900 D/AUL_PAD ( 2966): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-23 04:16:33.727+0900 D/AUL_PAD ( 2966): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
05-23 04:16:33.727+0900 D/AUL_PAD ( 2966): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-23 04:16:33.727+0900 D/AUL_PAD ( 2966): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-23 04:16:33.727+0900 D/AUL_PAD ( 2966): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-23 04:16:33.727+0900 D/AUL_PAD ( 2966): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-23 04:16:33.727+0900 D/AUL_PAD ( 2966): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-23 04:16:33.727+0900 I/AUL_PAD ( 2966): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 17037 pgid = 17037
05-23 04:16:33.727+0900 I/AUL_PAD ( 2966): sigchild.h: __sigchild_action(142) > dead_pid(17037)
05-23 04:16:33.747+0900 W/CRASH_MANAGER(17232): worker.c: worker_job(1204) > 1117037657861149548059
