S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 8716
Date: 2017-05-29 21:42:26+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 2
      invalid permissions for mapped object
      si_addr = 0xb6443890

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x80148a4b, esi = 0xb379f010
ebp = 0xbf9079a8, esp = 0xbf907900
eax = 0x80157cc4, ebx = 0xb37a5000
ecx = 0xb6443890, edx = 0x00000002
eip = 0xb379f469

Memory Information
MemTotal:      123 KB
MemFree:        28 KB
Buffers:         5 KB
Cached:     168344 KB
VmPeak:     122316 KB
VmSize:     122316 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       34988 KB
VmRSS:       34988 KB
VmData:      52416 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34624 KB
VmPTE:         108 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 8716 TID = 8716
8716 8717 8943 8944 8947 

Maps Information
b0ea6000 b0ead000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b0eae000 b0ec6000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b1806000 b180d000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b188a000 b188e000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2b63000 b2b6d000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b73000 b2b7f000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b80000 b2ba1000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2ba6000 b2ba7000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2ba8000 b2bad000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2bae000 b2baf000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2bb0000 b2bb2000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2bb3000 b2bb5000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2bb6000 b2bc2000 r-xp /usr/lib/libdrm.so.2.4.0
b2bc3000 b2bcd000 r-xp /usr/lib/libtbm.so.1.0.0
b2bce000 b2be3000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2be4000 b2bf6000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b33f8000 b3429000 r-xp /usr/lib/libidn.so.11.5.44
b342a000 b344c000 r-xp /usr/lib/libnghttp2.so.5.4.0
b344d000 b345d000 r-xp /usr/lib/libcares.so.2.1.0
b345e000 b3467000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3468000 b3471000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3472000 b34e9000 r-xp /usr/lib/libcurl.so.4.3.0
b34eb000 b34fd000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34fe000 b351f000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b3526000 b3527000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3528000 b3529000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b352a000 b352d000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b352e000 b3531000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3639000 b363f000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3640000 b3784000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3794000 b3797000 r-xp /usr/lib/libdri2.so.0.0.0
b3798000 b3799000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b379a000 b37a4000 r-xp /opt/usr/apps/org.example.example/bin/example
b37a6000 b37df000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41e2000 b41ed000 r-xp /lib/libnss_files-2.20-2014.11.so
b41ef000 b41fa000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41fc000 b4213000 r-xp /lib/libnsl-2.20-2014.11.so
b4217000 b421f000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4221000 b4245000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4246000 b4247000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4248000 b424b000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b424c000 b4253000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4254000 b425e000 r-xp /usr/lib/libsensord-share.so
b425f000 b427b000 r-xp /usr/lib/libsensor.so.1.2.0
b427d000 b4286000 r-xp /usr/lib/libappcore-common.so.1.1
b4289000 b428b000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42a0000 b42a2000 r-xp /usr/lib/libXau.so.6.0.0
b42a3000 b42c5000 r-xp /usr/lib/libxcb.so.1.1.0
b42c7000 b42d0000 r-xp /lib/libcrypt-2.20-2014.11.so
b42f9000 b42fb000 r-xp /usr/lib/libiri.so
b42fc000 b4322000 r-xp /lib/libexpat.so.1.5.2
b4324000 b438f000 r-xp /usr/lib/libssl.so.1.0.0
b4395000 b43a1000 r-xp /usr/lib/libethumb.so.1.13.0
b43a2000 b43a6000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43a7000 b45f8000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b73000 b5b83000 r-xp /usr/lib/libXi.so.6.1.0
b5b84000 b5b86000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b87000 b5b8d000 r-xp /usr/lib/libXtst.so.6.1.0
b5b8e000 b5b98000 r-xp /usr/lib/libXrender.so.1.3.0
b5b99000 b5ba2000 r-xp /usr/lib/libXrandr.so.2.2.0
b5ba4000 b5ba6000 r-xp /usr/lib/libXinerama.so.1.0.0
b5ba7000 b5bac000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bad000 b5bbf000 r-xp /usr/lib/libXext.so.6.4.0
b5bc0000 b5bc2000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bc3000 b5bc5000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bc7000 b5d09000 r-xp /usr/lib/libX11.so.6.3.0
b5d0d000 b5d17000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d18000 b5d2e000 r-xp /usr/lib/libudev.so.1.6.0
b5d31000 b5d35000 r-xp /lib/libattr.so.1.1.0
b5d36000 b5d65000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d67000 b5d6d000 r-xp /usr/lib/libffi.so.6.0.2
b5d6e000 b5d91000 r-xp /lib/libz.so.1.2.8
b5d92000 b5d95000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d96000 b5ef2000 r-xp /usr/lib/libxml2.so.2.9.2
b5ef8000 b5fdf000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fec000 b5fef000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ff0000 b6012000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6013000 b6027000 r-xp /lib/libresolv-2.20-2014.11.so
b602b000 b604f000 r-xp /usr/lib/liblzma.so.5.0.3
b6050000 b6052000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6054000 b605e000 r-xp /usr/lib/libembryo.so.1.13.0
b605f000 b6088000 r-xp /usr/lib/libpng12.so.0.50.0
b6089000 b60d2000 r-xp /usr/lib/libjpeg.so.8.0.2
b60e3000 b60ea000 r-xp /lib/librt-2.20-2014.11.so
b60ec000 b610b000 r-xp /usr/lib/libector.so.1.13.0
b610e000 b613b000 r-xp /usr/lib/liblua-5.1.so
b613c000 b61cc000 r-xp /usr/lib/libfreetype.so.6.11.3
b61d0000 b620e000 r-xp /usr/lib/libfontconfig.so.1.8.0
b620f000 b6225000 r-xp /usr/lib/libfribidi.so.0.3.1
b6226000 b627f000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6282000 b62cd000 r-xp /lib/libm-2.20-2014.11.so
b62cf000 b62e1000 r-xp /usr/lib/libeio.so.1.13.0
b62e2000 b62e5000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62e6000 b62ec000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62ed000 b6310000 r-xp /usr/lib/libefreet.so.1.13.0
b6313000 b633e000 r-xp /usr/lib/libeldbus.so.1.13.0
b633f000 b6373000 r-xp /usr/lib/libecore_con.so.1.13.0
b6375000 b637e000 r-xp /usr/lib/libecore_imf.so.1.13.0
b637f000 b6388000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6389000 b639c000 r-xp /usr/lib/libeo.so.1.13.0
b639e000 b63b1000 r-xp /usr/lib/libecore_input.so.1.13.0
b63b2000 b63b9000 r-xp /usr/lib/libecore_file.so.1.13.0
b63ba000 b63dd000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63de000 b640a000 r-xp /usr/lib/libeet.so.1.13.0
b6413000 b647e000 r-xp /usr/lib/libeina.so.1.13.0
b6481000 b6498000 r-xp /usr/lib/libefl.so.1.13.0
b649a000 b6601000 r-xp /usr/lib/libicuuc.so.51.1
b660f000 b681b000 r-xp /usr/lib/libicui18n.so.51.1
b6823000 b6872000 r-xp /usr/lib/libecore_x.so.1.13.0
b6874000 b688e000 r-xp /lib/libgcc_s-4.9.so.1
b6890000 b6894000 r-xp /lib/libcap.so.2.21
b6895000 b68db000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68dc000 b68e3000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68e5000 b6937000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6939000 b6ac4000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6ac9000 b6b97000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b9a000 b6b9e000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b9f000 b6bae000 r-xp /usr/lib/libvconf.so.0.2.45
b6baf000 b6bb2000 r-xp /usr/lib/libvasum.so.0.3.1
b6bb3000 b6bb6000 r-xp /usr/lib/libttrace.so.1.1
b6bb8000 b6bbc000 r-xp /usr/lib/libiniparser.so.0
b6bbd000 b6bed000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bee000 b6bf7000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bf8000 b6c1d000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c1e000 b6c2e000 r-xp /usr/lib/libunwind.so.8.0.1
b6c38000 b6de6000 r-xp /lib/libc-2.20-2014.11.so
b6dee000 b6f31000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f33000 b6f8b000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f8c000 b6fc0000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fc3000 b7097000 r-xp /usr/lib/libedje.so.1.13.0
b709a000 b70c6000 r-xp /usr/lib/libecore.so.1.13.0
b70d7000 b72fd000 r-xp /usr/lib/libevas.so.1.13.0
b7325000 b733d000 r-xp /lib/libpthread-2.20-2014.11.so
b7341000 b76bb000 r-xp /usr/lib/libelementary.so.1.13.0
b76db000 b76df000 r-xp /usr/lib/libsmack.so.1.0.0
b76e0000 b76e9000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76ea000 b76ed000 r-xp /usr/lib/libdlog.so.0.0.0
b76ee000 b76f3000 r-xp /usr/lib/libbundle.so.0.1.22
b76f4000 b76f7000 r-xp /lib/libdl-2.20-2014.11.so
b76f9000 b771e000 r-xp /usr/lib/libaul.so.0.1.0
b7721000 b7723000 r-xp /usr/lib/libappsvc.so.0.1.0
b7724000 b7729000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b772a000 b7731000 r-xp /usr/lib/libappcore-efl.so.1.1
b7733000 b7738000 r-xp /usr/lib/libsys-assert.so
b773b000 b773c000 r-xp [vdso]
b773c000 b775e000 r-xp /lib/ld-2.20-2014.11.so
b7760000 b7768000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:8716)
Call Stack Count: 21
 0: make_popup_rep + 0x1d9 (0xb379f469) [/opt/usr/apps/org.example.example/bin/example] + 0x5469
 1: (0xb7160116) [/usr/lib/libevas.so.1] + 0x89116
 2: (0xb6397319) [/usr/lib/libeo.so.1] + 0xe319
 3: eo_event_callback_call + 0xb3 (0xb6394d63) [/usr/lib/libeo.so.1] + 0xbd63
 4: evas_object_smart_callback_call + 0x75 (0xb71629e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 5: (0xb7413404) [/usr/lib/libelementary.so.1] + 0xd2404
 6: (0xb7046f39) [/usr/lib/libedje.so.1] + 0x83f39
 7: (0xb704da11) [/usr/lib/libedje.so.1] + 0x8aa11
 8: (0xb7047fdc) [/usr/lib/libedje.so.1] + 0x84fdc
 9: (0xb70484cb) [/usr/lib/libedje.so.1] + 0x854cb
10: (0xb704868f) [/usr/lib/libedje.so.1] + 0x8568f
11: (0xb70ad702) [/usr/lib/libecore.so.1] + 0x13702
12: (0xb70a7055) [/usr/lib/libecore.so.1] + 0xd055
13: (0xb70b01b9) [/usr/lib/libecore.so.1] + 0x161b9
14: ecore_main_loop_begin + 0x57 (0xb70b0587) [/usr/lib/libecore.so.1] + 0x16587
15: elm_run + 0x2d (0xb750922d) [/usr/lib/libelementary.so.1] + 0x1c822d
16: appcore_efl_main + 0x4de (0xb772ddde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
17: ui_app_main + 0x140 (0xb7726c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
18: main + 0x27e (0xb37a081e) [/opt/usr/apps/org.example.example/bin/example] + 0x681e
19: (0xb7762148) [/opt/usr/apps/org.example.example/bin/example] + 0xb7762148
20: __libc_start_main + 0xde (0xb6c4fe4e) [/lib/libc.so.6] + 0x17e4e
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
us], req_id=[org.example.example_77909628], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-29 21:42:21.440+0900 W/cluster-home( 2923): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[2], package[org.example.example]
05-29 21:42:21.440+0900 D/cluster-home( 2923): widget-data-provider.cpp: PackageUpdated(2160) >  No boxes that pkgname is[org.example.example]
05-29 21:42:21.440+0900 D/PKGMGR  ( 2923): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_77909628], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-29 21:42:21.440+0900 D/cluster-home( 2923): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29230003] pkg_type[tpk] package[org.example.example] key[end] val[ok] pmsg[(null)]
05-29 21:42:21.440+0900 E/cluster-home( 2923): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
05-29 21:42:21.440+0900 E/cluster-home( 2923): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
05-29 21:42:21.440+0900 E/cluster-home( 2923): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
05-29 21:42:21.440+0900 D/PKGMGR  ( 3139): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_77909628], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-29 21:42:21.440+0900 D/PKGMGR  ( 2992): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_77909628], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-29 21:42:21.440+0900 D/ESD     ( 2992): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29920002), pkg_type(tpk), pkgid(org.example.example), key(end), val(ok)
05-29 21:42:21.440+0900 D/ESD     ( 2992): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
05-29 21:42:21.440+0900 D/PKGMGR  ( 2837): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[upgrade], req_id=[org.example.example_77909628], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-29 21:42:21.440+0900 D/AUL_AMD ( 2837): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.example), key(end), value(ok)
05-29 21:42:21.440+0900 W/AUL_AMD ( 2837): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(update), value(ok)
05-29 21:42:21.440+0900 D/PKGMGR  ( 2987): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_77909628], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-29 21:42:21.440+0900 D/QUICKPANEL( 2987): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:end val:ok
05-29 21:42:21.440+0900 D/PKGMGR  ( 2994): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_77909628], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-29 21:42:21.440+0900 D/cluster-home( 2923): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
05-29 21:42:21.440+0900 D/cluster-home( 2923): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.example]
05-29 21:42:21.440+0900 E/cluster-home( 2923): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.example]
05-29 21:42:21.440+0900 E/cluster-home( 2923): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.example]
05-29 21:42:21.440+0900 E/cluster-home( 2923): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
05-29 21:42:21.440+0900 E/cluster-home( 2923): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
05-29 21:42:21.440+0900 E/cluster-home( 2923): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.example]
05-29 21:42:21.450+0900 D/PKGMGR  ( 3073): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_77909628], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-29 21:42:21.450+0900 D/ISF_PANEL_EFL( 3073): isf_panel_efl.cpp: _package_manager_event_cb(1288) > type=tpk package=org.example.example event_type=UPDATE event_state=COMPLETED progress=100 error=0
05-29 21:42:21.450+0900 D/AUL_AMD ( 2837): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.example, type:rpm
05-29 21:42:21.450+0900 E/cluster-home( 2923): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.example] Name[forpet] Icon[/opt/usr/apps/org.example.example/shared/res/1.jpg] enable[1] system[0]
05-29 21:42:21.450+0900 D/cluster-home( 2923): mainmenu-presenter.cpp: OnAppUpdated(337) >  pAppId [org.example.example]
05-29 21:42:21.450+0900 D/cluster-home( 2923): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.example
05-29 21:42:21.450+0900 D/cluster-home( 2923): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[17], isFolder[0], pageId[1], col[4], row[4], appId[org.example.example], name[forpet], menuId[1], isPreload[0] isPreload[0]
05-29 21:42:21.450+0900 D/cluster-home( 2923): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
05-29 21:42:21.450+0900 E/cluster-home( 2923): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.example] Name[forpet] Icon[/opt/usr/apps/org.example.example/shared/res/1.jpg] enable[1] system[0]
05-29 21:42:21.450+0900 D/cluster-home( 2923): mainmenu-presenter.cpp: OnAppUpdated(364) >  name [forpet]
05-29 21:42:21.450+0900 D/cluster-home( 2923): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
05-29 21:42:21.450+0900 D/PKGMGR  ( 3000): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_77909628], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-29 21:42:21.450+0900 D/PKGMGR  ( 3000): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
05-29 21:42:21.450+0900 D/cluster-home( 2923): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
05-29 21:42:21.450+0900 D/test-log( 2923): mainmenu-box-impl.cpp: UpdateBoxData(812) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.example/shared/res/1.jpg], New icon path[/opt/usr/apps/org.example.example/shared/res/1.jpg]!!!!!
05-29 21:42:21.450+0900 D/cluster-home( 2923): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 1, appId = $appId, name = $name, col = 4, row = 4, isPreload = 0, isSystem = 0 WHERE boxId = 17]
05-29 21:42:21.450+0900 W/ISF_PANEL_EFL( 3073): isf_panel_efl.cpp: _package_manager_event_cb(1380) > isf_db_select_appids_by_pkgid returned 0.
05-29 21:42:21.450+0900 D/PKGMGR  ( 2982): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_77909628], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-29 21:42:21.450+0900 D/DATA_PROVIDER_MASTER( 2982): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.example] ok
05-29 21:42:21.450+0900 D/DATA_PROVIDER_MASTER( 2982): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.example], event_type[1]
05-29 21:42:21.450+0900 D/DATA_PROVIDER_MASTER( 2982): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
05-29 21:42:21.450+0900 D/DATA_PROVIDER_MASTER( 2982): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
05-29 21:42:21.450+0900 D/DATA_PROVIDER_MASTER( 2982): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
05-29 21:42:21.450+0900 D/DATA_PROVIDER_MASTER( 2982): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.example]
05-29 21:42:21.450+0900 D/PKGMGR  ( 8885): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_77909628], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-29 21:42:21.610+0900 D/rpm-installer( 8887): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
05-29 21:42:21.610+0900 D/rpm-installer( 8887): rpm-appcore-intf.c: main(259) > ------------------------------------------------
05-29 21:42:21.610+0900 D/rpm-installer( 8887): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
05-29 21:42:21.610+0900 D/rpm-installer( 8887): rpm-appcore-intf.c: main(261) > ------------------------------------------------
05-29 21:42:21.610+0900 D/PKGMGR_SERVER( 8798): pkgmgr-server.c: sighandler(387) > child exit [8887]
05-29 21:42:21.610+0900 E/PKGMGR_SERVER( 8798): pkgmgr-server.c: sighandler(402) > child NORMAL exit [8887]
05-29 21:42:22.000+0900 E/PKGMGR_SERVER( 8798): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
05-29 21:42:22.000+0900 E/PKGMGR_SERVER( 8798): pkgmgr-server.c: main(2265) > package manager server terminated.
05-29 21:42:22.280+0900 D/AUL_AMD ( 2837): amd_request.c: __request_handler(838) > __request_handler: 0
05-29 21:42:22.280+0900 D/AUL_AMD ( 2837): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
05-29 21:42:22.280+0900 D/PKGMGR_INFO( 2837): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
05-29 21:42:22.280+0900 D/PKGMGR_INFO( 2837): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
05-29 21:42:22.290+0900 I/AUL     ( 2837): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
05-29 21:42:22.290+0900 D/AUL     ( 2837): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 8937, pid = 8939
05-29 21:42:22.290+0900 D/PKGMGR_INFO( 2837): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
05-29 21:42:22.290+0900 D/PKGMGR_INFO( 2837): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
05-29 21:42:22.290+0900 I/AUL     ( 2837): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
05-29 21:42:22.290+0900 E/AUL_AMD ( 2837): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
05-29 21:42:22.290+0900 W/AUL_AMD ( 2837): amd_launch.c: _start_app(2233) > caller pid : 8939
05-29 21:42:22.290+0900 E/AUL_AMD ( 2837): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
05-29 21:42:22.290+0900 W/AUL_AMD ( 2837): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
05-29 21:42:22.290+0900 D/AUL_AMD ( 2837): amd_launch.c: _start_app(2648) > process_pool: false
05-29 21:42:22.290+0900 D/AUL_AMD ( 2837): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
05-29 21:42:22.290+0900 D/AUL_AMD ( 2837): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
05-29 21:42:22.290+0900 W/AUL_AMD ( 2837): amd_launch.c: _start_app(2665) > pad pid(-5)
05-29 21:42:22.290+0900 D/AUL_AMD ( 2837): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
05-29 21:42:22.290+0900 D/AUL_AMD ( 2837): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
05-29 21:42:22.290+0900 D/AUL     ( 2837): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
05-29 21:42:22.290+0900 D/RESOURCED( 2889): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
05-29 21:42:22.290+0900 D/AUL_PAD ( 2976): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
05-29 21:42:22.290+0900 D/AUL_PAD ( 2976): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
05-29 21:42:22.290+0900 D/AUL_PAD ( 2976): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-29 21:42:22.290+0900 D/AUL_PAD ( 2976): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-29 21:42:22.290+0900 D/AUL_PAD ( 2976): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-29 21:42:22.290+0900 D/AUL_PAD ( 2976): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-29 21:42:22.290+0900 D/AUL_PAD ( 2976): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-29 21:42:22.290+0900 D/AUL_PAD ( 2976): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
05-29 21:42:22.290+0900 D/RESOURCED( 2889): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
05-29 21:42:22.290+0900 D/AUL_PAD ( 2976): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
05-29 21:42:22.290+0900 D/AUL_PAD ( 2976): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
05-29 21:42:22.290+0900 D/AUL_PAD ( 2976): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
05-29 21:42:22.290+0900 D/AUL_PAD ( 2976): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
05-29 21:42:22.290+0900 D/AUL_PAD ( 2976): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
05-29 21:42:22.290+0900 D/AUL_PAD ( 2976): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
05-29 21:42:22.290+0900 W/AUL_PAD ( 2976): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
05-29 21:42:22.290+0900 E/RESOURCED( 2889): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
05-29 21:42:22.290+0900 D/AUL     ( 2976): process_pool.c: __send_pkt_raw_data(219) > send(12) : 620 / 620
05-29 21:42:22.290+0900 D/AUL_PAD ( 2976): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 8716, bin path: /opt/usr/apps/org.example.example/bin/example
05-29 21:42:22.290+0900 W/AUL_PAD ( 2976): launchpad.c: __send_result_to_caller(265) > Check app launching
05-29 21:42:22.290+0900 D/AUL_PAD ( 2976): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
05-29 21:42:22.290+0900 D/AUL_PAD ( 8716): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
05-29 21:42:22.290+0900 D/AUL_PAD ( 8716): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
05-29 21:42:22.290+0900 D/AUL_PAD ( 8716): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
05-29 21:42:22.290+0900 D/AUL_PAD ( 8716): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
05-29 21:42:22.290+0900 D/AUL_PAD ( 8716): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
05-29 21:42:22.290+0900 D/AUL_PAD ( 8716): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
05-29 21:42:22.290+0900 D/AUL     ( 8716): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (8717) is sent.
05-29 21:42:22.290+0900 D/AUL     ( 8716): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 8717, signo: 10
05-29 21:42:22.300+0900 D/AUL     ( 8716): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
05-29 21:42:22.300+0900 D/AUL_PAD ( 8716): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
05-29 21:42:22.300+0900 D/AUL_PAD ( 8716): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
05-29 21:42:22.300+0900 D/AUL_PAD ( 8716): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
05-29 21:42:22.300+0900 D/AUL_PAD ( 8716): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
05-29 21:42:22.300+0900 D/AUL_PAD ( 8716): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTYwNjE3NDIvMjg0Njg4AA==##
05-29 21:42:22.300+0900 D/AUL_PAD ( 8716): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
05-29 21:42:22.300+0900 D/AUL_PAD ( 8716): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA4OTM5AA==##
05-29 21:42:22.300+0900 D/AUL_PAD ( 8716): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
05-29 21:42:22.300+0900 D/AUL_PAD ( 8716): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
05-29 21:42:22.300+0900 D/AUL_PAD ( 8716): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
05-29 21:42:22.300+0900 D/AUL_PAD ( 8716): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
05-29 21:42:22.300+0900 D/AUL_PAD ( 8716): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
05-29 21:42:22.300+0900 I/CAPI_APPFW_APPLICATION( 8716): app_main.c: ui_app_main(788) > app_efl_main
05-29 21:42:22.300+0900 D/LAUNCH  ( 8716): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
05-29 21:42:22.300+0900 D/APP_CORE( 8716): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
05-29 21:42:22.300+0900 D/APP_CORE( 8716): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
05-29 21:42:22.300+0900 D/APP_CORE( 8716): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
05-29 21:42:22.320+0900 D/APP_CORE( 8716): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
05-29 21:42:22.320+0900 D/AUL     ( 8716): app_sock.c: __create_server_sock(156) > pg path - already exists
05-29 21:42:22.320+0900 D/APP_CORE( 8716): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb4286520
05-29 21:42:22.320+0900 D/LAUNCH  ( 8716): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
05-29 21:42:22.320+0900 I/CAPI_APPFW_APPLICATION( 8716): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
05-29 21:42:22.390+0900 D/AUL_PAD ( 2976): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
05-29 21:42:22.390+0900 W/AUL     ( 2837): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 8716, appid: org.example.example
05-29 21:42:22.400+0900 D/AUL     ( 2837): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
05-29 21:42:22.400+0900 E/AUL     ( 2837): simple_util.c: __trm_app_info_send_socket(330) > access
05-29 21:42:22.400+0900 D/AUL_AMD ( 2837): amd_launch.c: _start_app(2700) > add app group info
05-29 21:42:22.400+0900 E/AUL     ( 2837): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
05-29 21:42:22.400+0900 D/AUL_AMD ( 2837): amd_status.c: _status_add_app_info_list(427) > pid(8716) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
05-29 21:42:22.400+0900 D/RESOURCED( 2889): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 8716
05-29 21:42:22.400+0900 D/RESOURCED( 2889): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
05-29 21:42:22.400+0900 E/RESOURCED( 2889): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
05-29 21:42:22.400+0900 D/RESOURCED( 2889): proc-main.c: resourced_proc_status_change(888) > available memory = 318
05-29 21:42:22.420+0900 D/LAUNCH  ( 8716): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
05-29 21:42:22.420+0900 E/E17     ( 2733): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02c00002)
05-29 21:42:22.420+0900 D/APP_CORE( 8716): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
05-29 21:42:22.460+0900 E/E17     ( 2733): e_border.c: e_border_show(2088) > BD_SHOW(0x02c00002)
05-29 21:42:22.480+0900 D/APP_CORE( 8716): appcore.c: __aul_handler(587) > [APP 8716]     AUL event: AUL_START
05-29 21:42:22.480+0900 I/APP_CORE( 8716): appcore-efl.c: __do_app(496) > [APP 8716] Event: RESET State: CREATED
05-29 21:42:22.480+0900 D/APP_CORE( 8716): appcore-efl.c: __do_app(527) > [APP 8716] RESET
05-29 21:42:22.480+0900 D/LAUNCH  ( 8716): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
05-29 21:42:22.480+0900 D/APP_CORE( 8716): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
05-29 21:42:22.480+0900 D/APP_CORE( 8716): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-29 21:42:22.480+0900 I/CAPI_APPFW_APPLICATION( 8716): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
05-29 21:42:22.480+0900 D/AUL     ( 8716): service.c: __set_bundle(186) > __set_bundle
05-29 21:42:22.480+0900 D/LAUNCH  ( 8716): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
05-29 21:42:22.480+0900 D/APP_CORE( 8716): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
05-29 21:42:22.480+0900 E/EFL     ( 8716): edje<8716> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-29 21:42:22.480+0900 E/EFL     ( 8716): By the power of Grayskull, your previous Embryo stack is now broken!
05-29 21:42:22.480+0900 E/EFL     ( 8716): edje<8716> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-29 21:42:22.480+0900 E/EFL     ( 8716): By the power of Grayskull, your previous Embryo stack is now broken!
05-29 21:42:22.480+0900 E/EFL     ( 8716): edje<8716> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-29 21:42:22.480+0900 E/EFL     ( 8716): By the power of Grayskull, your previous Embryo stack is now broken!
05-29 21:42:22.480+0900 E/EFL     ( 8716): edje<8716> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-29 21:42:22.480+0900 E/EFL     ( 8716): By the power of Grayskull, your previous Embryo stack is now broken!
05-29 21:42:22.480+0900 E/EFL     ( 8716): edje<8716> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-29 21:42:22.480+0900 E/EFL     ( 8716): By the power of Grayskull, your previous Embryo stack is now broken!
05-29 21:42:22.480+0900 W/APP_CORE( 8716): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2c00002
05-29 21:42:22.480+0900 D/APP_CORE( 8716): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2c00002
05-29 21:42:22.480+0900 D/APP_CORE( 8716): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
05-29 21:42:22.480+0900 D/AUL     ( 8716): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
05-29 21:42:22.490+0900 D/AUL_AMD ( 2837): amd_request.c: __request_handler(838) > __request_handler: 34
05-29 21:42:22.490+0900 W/PROCESSMGR( 2733): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=8716
05-29 21:42:22.520+0900 E/EFL     ( 2733): eo<2733> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-29 21:42:22.520+0900 E/EFL     ( 2733): eo<2733> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-29 21:42:22.530+0900 D/AUL_AMD ( 2837): amd_request.c: __request_handler(838) > __request_handler: 15
05-29 21:42:22.530+0900 D/PKGMGR_INFO( 2837): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-29 21:42:22.530+0900 D/PKGMGR_INFO( 2837): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-29 21:42:22.530+0900 D/AUL_AMD ( 2837): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 8716 is org.example.example
05-29 21:42:22.530+0900 D/AUL_AMD ( 2837): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 8716 : 0
05-29 21:42:22.540+0900 D/AUL     ( 2994): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
05-29 21:42:22.540+0900 D/INDICATOR( 2919): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
05-29 21:42:22.550+0900 D/INDICATOR( 2919): util.c: util_signal_emit_by_win(116) > emission bg.opaque
05-29 21:42:22.550+0900 D/INDICATOR( 2919): main.c: _rotate_window(229) > Indicator angle is 0 degree
05-29 21:42:22.550+0900 D/INDICATOR( 2919): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
05-29 21:42:22.550+0900 D/INDICATOR( 2919): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
05-29 21:42:22.550+0900 D/INDICATOR( 2919): main.c: _rotate_window(252) > port :: hide more icon
05-29 21:42:22.750+0900 D/APP_CORE( 8716): appcore.c: __prt_ltime(236) > [APP 8716] first idle after reset: 472 msec
05-29 21:42:22.890+0900 E/E17     ( 2733): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
05-29 21:42:22.900+0900 D/APP_CORE( 2923): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
05-29 21:42:22.900+0900 D/APP_CORE( 2923): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
05-29 21:42:22.900+0900 D/APP_CORE( 2923): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
05-29 21:42:22.900+0900 I/APP_CORE( 2923): appcore-efl.c: __do_app(496) > [APP 2923] Event: PAUSE State: RUNNING
05-29 21:42:22.900+0900 D/APP_CORE( 2923): appcore-efl.c: __do_app(565) > [APP 2923] PAUSE
05-29 21:42:22.900+0900 I/CAPI_APPFW_APPLICATION( 2923): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
05-29 21:42:22.900+0900 E/cluster-home( 2923): homescreen.cpp: OnPause(84) >  app pause
05-29 21:42:22.900+0900 D/cluster-view( 2923): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
05-29 21:42:22.900+0900 D/cluster-view( 2923): homescreen-view-manager.cpp: AppPause(923) >  END
05-29 21:42:22.900+0900 D/APP_CORE( 2923): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-29 21:42:22.900+0900 E/APP_CORE( 2923): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-29 21:42:22.900+0900 D/AUL_AMD ( 2837): amd_status.c: _status_update_app_info_list(456) > pid(2923) status(4)
05-29 21:42:22.900+0900 D/AUL_AMD ( 2837): amd_status.c: _status_update_app_info_list(468) > pid(2923) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
05-29 21:42:22.900+0900 D/AUL     ( 2837): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
05-29 21:42:22.900+0900 W/AUL     ( 2837): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2923, appid: org.tizen.homescreen, status: bg
05-29 21:42:22.920+0900 D/APP_CORE( 8716): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2c00002 fully_obscured 0
05-29 21:42:22.920+0900 D/APP_CORE( 8716): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
05-29 21:42:22.920+0900 D/APP_CORE( 8716): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
05-29 21:42:22.920+0900 I/APP_CORE( 8716): appcore-efl.c: __do_app(496) > [APP 8716] Event: RESUME State: CREATED
05-29 21:42:22.920+0900 D/LAUNCH  ( 8716): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
05-29 21:42:22.920+0900 D/APP_CORE( 8716): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
05-29 21:42:22.920+0900 D/APP_CORE( 8716): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-29 21:42:22.920+0900 D/APP_CORE( 8716): appcore-efl.c: __do_app(607) > [APP 8716] RESUME
05-29 21:42:22.920+0900 I/APP_CORE( 8716): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
05-29 21:42:22.920+0900 D/DATA_PROVIDER_MASTER( 2982): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2923 is paused
05-29 21:42:22.920+0900 D/AUL_AMD ( 2837): amd_launch.c: __e17_status_handler(2891) > pid(8716) status(3)
05-29 21:42:22.920+0900 D/AUL_AMD ( 2837): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
05-29 21:42:22.920+0900 I/APP_CORE( 8716): appcore-efl.c: __do_app(614) > [APP 8716] Initial Launching, call the resume_cb
05-29 21:42:22.920+0900 I/CAPI_APPFW_APPLICATION( 8716): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
05-29 21:42:22.920+0900 D/LAUNCH  ( 8716): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
05-29 21:42:22.920+0900 D/LAUNCH  ( 8716): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
05-29 21:42:22.920+0900 D/APP_CORE( 8716): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-29 21:42:22.920+0900 E/APP_CORE( 8716): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-29 21:42:22.920+0900 D/DATA_PROVIDER_MASTER( 2982): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
05-29 21:42:22.920+0900 I/CAPI_WIDGET_APPLICATION( 2979): widget_app.c: __provider_pause_cb(294) > widget obj was paused
05-29 21:42:22.920+0900 I/CAPI_WIDGET_APPLICATION( 2979): widget_app.c: __check_status_for_cgroup(142) > enter background group
05-29 21:42:22.920+0900 W/AUL     ( 2979): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2979, appid: org.tizen.calendar.widget, status: bg
05-29 21:42:22.920+0900 W/AUL_AMD ( 2837): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-29 21:42:22.920+0900 W/AUL_AMD ( 2837): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
05-29 21:42:22.920+0900 D/AUL_AMD ( 2837): amd_status.c: _status_update_app_info_list(456) > pid(8716) status(3)
05-29 21:42:22.920+0900 D/AUL_AMD ( 2837): amd_status.c: _status_update_app_info_list(468) > pid(8716) appid(org.example.example) pkgid(org.example.example) status(3)
05-29 21:42:22.920+0900 D/AUL     ( 2837): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
05-29 21:42:22.920+0900 W/AUL     ( 2837): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 8716, appid: org.example.example, status: fg
05-29 21:42:22.930+0900 D/RESOURCED( 2889): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 2979, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
05-29 21:42:22.930+0900 D/RESOURCED( 2889): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 2979
05-29 21:42:22.930+0900 D/RESOURCED( 2889): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 2979, appname = org.tizen.calendar.widget
05-29 21:42:22.930+0900 D/RESOURCED( 2889): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 2979
05-29 21:42:22.930+0900 D/RESOURCED( 2889): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 8716
05-29 21:42:22.930+0900 D/RESOURCED( 2889): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 8716, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
05-29 21:42:22.930+0900 D/RESOURCED( 2889): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 8716
05-29 21:42:22.980+0900 D/RESOURCED( 2889): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 8716, appname = org.example.example, pkgname = org.example.example
05-29 21:42:22.980+0900 D/RESOURCED( 2889): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 8716, appname = org.example.example
05-29 21:42:22.980+0900 D/RESOURCED( 2889): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 8716
05-29 21:42:22.980+0900 I/RESOURCED( 2889): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
05-29 21:42:22.980+0900 I/RESOURCED( 2889): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
05-29 21:42:22.990+0900 D/AUL_AMD ( 2837): amd_launch.c: __e17_status_handler(2910) > pid(8716) status(0)
05-29 21:42:23.400+0900 D/AUL_PAD ( 2976): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
05-29 21:42:23.410+0900 D/AUL_PAD ( 8946): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
05-29 21:42:23.450+0900 D/AUL_PAD ( 2976): sigchild.h: __send_app_launch_signal(131) > send launch signal done
05-29 21:42:23.460+0900 E/RESOURCED( 2889): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.564
05-29 21:42:23.720+0900 D/PROCESSMGR( 2733): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002f  register trigger_timer!  pointed_win=0x200f93 
05-29 21:42:23.900+0900 D/AUL_AMD ( 2837): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
05-29 21:42:23.900+0900 D/RUA     ( 2837): rua.c: rua_add_history(179) > rua_add_history start
05-29 21:42:23.930+0900 D/RUA     ( 2837): rua.c: rua_add_history(247) > rua_add_history ok
05-29 21:42:24.490+0900 D/AUL_PAD ( 8946): launchpad_loader.c: main(588) > sleeping 1 sec...
05-29 21:42:24.490+0900 D/AUL_PAD ( 8946): preload.h: __preload_init(52) > max_cmdline_size = 1053
05-29 21:42:24.490+0900 D/AUL_PAD ( 8946): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b8adc760
05-29 21:42:24.490+0900 D/AUL_PAD ( 8946): preload.h: __preload_init(69) > get pre-initialization function
05-29 21:42:24.490+0900 D/AUL_PAD ( 8946): preload.h: __preload_init(73) > get shutdown function
05-29 21:42:24.490+0900 D/AUL_PAD ( 8946): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b8adca40
05-29 21:42:24.490+0900 D/AUL_PAD ( 8946): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b8ade640
05-29 21:42:24.490+0900 D/AUL_PAD ( 8946): preload.h: __preload_init(69) > get pre-initialization function
05-29 21:42:24.490+0900 D/AUL_PAD ( 8946): preload.h: __preload_init(73) > get shutdown function
05-29 21:42:24.490+0900 D/AUL_PAD ( 8946): preexec.h: __preexec_init(76) > preexec start
05-29 21:42:24.490+0900 D/AUL_PAD ( 8946): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
05-29 21:42:24.490+0900 D/AUL     ( 8946): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
05-29 21:42:24.490+0900 D/AUL     ( 8946): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
05-29 21:42:24.490+0900 D/AUL     ( 8946): process_pool.c: __connect_to_launchpad(132) > send(8946) : 4
05-29 21:42:24.490+0900 D/AUL     ( 8946): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
05-29 21:42:24.490+0900 D/AUL_PAD ( 2976): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-29 21:42:24.490+0900 D/AUL_PAD ( 2976): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
05-29 21:42:24.490+0900 D/AUL_PAD ( 2976): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-29 21:42:24.490+0900 D/AUL_PAD ( 2976): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-29 21:42:24.490+0900 D/AUL_PAD ( 2976): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-29 21:42:24.490+0900 D/AUL_PAD ( 2976): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-29 21:42:24.490+0900 D/AUL_PAD ( 2976): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-29 21:42:24.490+0900 D/AUL_PAD ( 2976): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
05-29 21:42:24.490+0900 D/AUL_PAD ( 2976): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 8946
05-29 21:42:24.520+0900 D/PROCESSMGR( 2733): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002f  register trigger_timer!  pointed_win=0x200f93 
05-29 21:42:24.780+0900 E/EFL     ( 8716): edje<8716> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:42:24.790+0900 E/EFL     ( 8716): edje<8716> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:42:24.810+0900 D/AUL_PAD ( 8946): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
05-29 21:42:24.820+0900 D/AUL_PAD ( 8946): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
05-29 21:42:24.830+0900 D/AUL_PAD ( 8946): launchpad_loader.c: main(693) > [candidate] ecore handler add
05-29 21:42:24.830+0900 D/AUL_PAD ( 8946): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
05-29 21:42:24.850+0900 E/EFL     ( 8716): edje<8716> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:42:24.860+0900 E/EFL     ( 8716): edje<8716> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:42:24.860+0900 E/EFL     ( 8716): edje<8716> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:42:24.860+0900 E/EFL     ( 8716): edje<8716> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:42:24.860+0900 E/EFL     ( 8716): edje<8716> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:42:24.860+0900 E/EFL     ( 8716): edje<8716> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:42:24.860+0900 E/EFL     ( 8716): edje<8716> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:42:24.870+0900 D/IMMODULE( 8716): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
05-29 21:42:24.870+0900 D/ISF_SOCKET( 8716): scim_socket.cpp: connect(515) > ppid:2976  trying connect() to local:/tmp/scim-socket-frontend, example
05-29 21:42:24.880+0900 D/ISF_SOCKET( 8716): scim_socket.cpp: connect(524) > connect() succeeded
05-29 21:42:24.880+0900 D/ISF_SOCKET( 8716): scim_socket.cpp: connect(515) > ppid:2976  trying connect() to local:/tmp/scim-socket-frontend, example
05-29 21:42:24.880+0900 D/ISF_SOCKET( 8716): scim_socket.cpp: connect(524) > connect() succeeded
05-29 21:42:24.940+0900 D/ISF_SOCKET( 8716): scim_socket.cpp: connect(515) > ppid:2976  trying connect() to local:/tmp/scim-socket-frontend, example
05-29 21:42:24.940+0900 D/ISF_SOCKET( 8716): scim_socket.cpp: connect(524) > connect() succeeded
05-29 21:42:24.950+0900 D/ISF_QUERY( 8716): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
05-29 21:42:24.950+0900 D/ISF_QUERY( 8716): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-29 21:42:24.950+0900 D/ISF_QUERY( 8716): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-29 21:42:24.950+0900 D/ISF_QUERY( 8716): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-29 21:42:24.950+0900 D/ISF_QUERY( 8716): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-29 21:42:24.950+0900 D/ISF_QUERY( 8716): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-29 21:42:24.950+0900 D/ISF_QUERY( 8716): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-29 21:42:24.960+0900 D/ISF_SOCKET( 8716): scim_socket.cpp: connect(515) > ppid:2976  trying connect() to local:/tmp/scim-socket-frontend, example
05-29 21:42:24.960+0900 D/ISF_SOCKET( 8716): scim_socket.cpp: connect(524) > connect() succeeded
05-29 21:42:24.970+0900 D/IMMODULE( 8716): scim_panel_client.cpp: open_connection(162) > 
05-29 21:42:24.970+0900 D/ISF_SOCKET( 8716): scim_socket.cpp: connect(515) > ppid:2976  trying connect() to local:/tmp/scim-panel-socket:0, example
05-29 21:42:24.970+0900 D/ISF_SOCKET( 8716): scim_socket.cpp: connect(524) > connect() succeeded
05-29 21:42:24.970+0900 D/ISF_SOCKET( 8716): scim_socket.cpp: connect(515) > ppid:2976  trying connect() to local:/tmp/scim-panel-socket:0, example
05-29 21:42:24.980+0900 D/ISF_SOCKET( 8716): scim_socket.cpp: connect(524) > connect() succeeded
05-29 21:42:24.990+0900 D/IMMODULE( 8716): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 1
05-29 21:42:25.530+0900 D/PROCESSMGR( 2733): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2c00002
05-29 21:42:25.980+0900 D/PROCESSMGR( 2733): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002f  register trigger_timer!  pointed_win=0x200f93 
05-29 21:42:26.310+0900 E/EFL     ( 2733): eo<2733> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-29 21:42:26.320+0900 D/AUL_PAD ( 2976): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-29 21:42:26.320+0900 D/AUL_PAD ( 2976): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
05-29 21:42:26.320+0900 D/AUL_PAD ( 2976): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-29 21:42:26.320+0900 D/AUL_PAD ( 2976): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-29 21:42:26.320+0900 D/AUL_PAD ( 2976): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-29 21:42:26.320+0900 D/AUL_PAD ( 2976): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-29 21:42:26.320+0900 D/AUL_PAD ( 2976): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-29 21:42:26.320+0900 I/AUL_PAD ( 2976): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 8716 pgid = 8716
05-29 21:42:26.320+0900 I/AUL_PAD ( 2976): sigchild.h: __sigchild_action(142) > dead_pid(8716)
05-29 21:42:26.340+0900 W/CRASH_MANAGER( 8949): worker.c: worker_job(1204) > 1108716657861149606174
