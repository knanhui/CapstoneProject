S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 16743
Date: 2017-05-31 18:29:53+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 2
      invalid permissions for mapped object
      si_addr = 0xb37b3058

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xbf9c1c20, esi = 0xb37b3059
ebp = 0xbf9c2108, esp = 0xbf9c1c18
eax = 0xb37b3058, ebx = 0xb37b5000
ecx = 0xb6cd5320, edx = 0x004e4f4d
eip = 0xb6cd5322

Memory Information
MemTotal:      123 KB
MemFree:        24 KB
Buffers:         6 KB
Cached:     187664 KB
VmPeak:     121144 KB
VmSize:     115164 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       34056 KB
VmRSS:       27968 KB
VmData:      45264 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34624 KB
VmPTE:         104 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 16743 TID = 16743
16743 16744 16966 16967 16971 

Maps Information
b0eae000 b0ec6000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b180c000 b1813000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b1816000 b181d000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b189a000 b189e000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2b73000 b2b7d000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b83000 b2b8f000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b90000 b2bb1000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2bb6000 b2bb7000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2bb8000 b2bbd000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2bbe000 b2bbf000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2bc0000 b2bc2000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2bc3000 b2bc5000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2bc6000 b2bd2000 r-xp /usr/lib/libdrm.so.2.4.0
b2bd3000 b2bdd000 r-xp /usr/lib/libtbm.so.1.0.0
b2bde000 b2bf3000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2bf4000 b2c06000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3408000 b3439000 r-xp /usr/lib/libidn.so.11.5.44
b343a000 b345c000 r-xp /usr/lib/libnghttp2.so.5.4.0
b345d000 b346d000 r-xp /usr/lib/libcares.so.2.1.0
b346e000 b3477000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3478000 b3481000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3482000 b34f9000 r-xp /usr/lib/libcurl.so.4.3.0
b34fb000 b350d000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b350e000 b352f000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b3536000 b3537000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3538000 b3539000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b353a000 b353d000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b353e000 b3541000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3649000 b364f000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3650000 b3794000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37a4000 b37a7000 r-xp /usr/lib/libdri2.so.0.0.0
b37a8000 b37a9000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37aa000 b37b4000 r-xp /opt/usr/apps/org.example.example/bin/example
b37b6000 b37ef000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41f2000 b41fd000 r-xp /lib/libnss_files-2.20-2014.11.so
b41ff000 b420a000 r-xp /lib/libnss_nis-2.20-2014.11.so
b420c000 b4223000 r-xp /lib/libnsl-2.20-2014.11.so
b4227000 b422f000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4231000 b4255000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4256000 b4257000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4258000 b425b000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b425c000 b4263000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4264000 b426e000 r-xp /usr/lib/libsensord-share.so
b426f000 b428b000 r-xp /usr/lib/libsensor.so.1.2.0
b428d000 b4296000 r-xp /usr/lib/libappcore-common.so.1.1
b4299000 b429b000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42b0000 b42b2000 r-xp /usr/lib/libXau.so.6.0.0
b42b3000 b42d5000 r-xp /usr/lib/libxcb.so.1.1.0
b42d7000 b42e0000 r-xp /lib/libcrypt-2.20-2014.11.so
b4309000 b430b000 r-xp /usr/lib/libiri.so
b430c000 b4332000 r-xp /lib/libexpat.so.1.5.2
b4334000 b439f000 r-xp /usr/lib/libssl.so.1.0.0
b43a5000 b43b1000 r-xp /usr/lib/libethumb.so.1.13.0
b43b2000 b43b6000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43b7000 b4608000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b83000 b5b93000 r-xp /usr/lib/libXi.so.6.1.0
b5b94000 b5b96000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b97000 b5b9d000 r-xp /usr/lib/libXtst.so.6.1.0
b5b9e000 b5ba8000 r-xp /usr/lib/libXrender.so.1.3.0
b5ba9000 b5bb2000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bb4000 b5bb6000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bb7000 b5bbc000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bbd000 b5bcf000 r-xp /usr/lib/libXext.so.6.4.0
b5bd0000 b5bd2000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bd3000 b5bd5000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bd7000 b5d19000 r-xp /usr/lib/libX11.so.6.3.0
b5d1d000 b5d27000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d28000 b5d3e000 r-xp /usr/lib/libudev.so.1.6.0
b5d41000 b5d45000 r-xp /lib/libattr.so.1.1.0
b5d46000 b5d75000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d77000 b5d7d000 r-xp /usr/lib/libffi.so.6.0.2
b5d7e000 b5da1000 r-xp /lib/libz.so.1.2.8
b5da2000 b5da5000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5da6000 b5f02000 r-xp /usr/lib/libxml2.so.2.9.2
b5f08000 b5fef000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ffc000 b5fff000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6000000 b6022000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6023000 b6037000 r-xp /lib/libresolv-2.20-2014.11.so
b603b000 b605f000 r-xp /usr/lib/liblzma.so.5.0.3
b6060000 b6062000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6064000 b606e000 r-xp /usr/lib/libembryo.so.1.13.0
b606f000 b6098000 r-xp /usr/lib/libpng12.so.0.50.0
b6099000 b60e2000 r-xp /usr/lib/libjpeg.so.8.0.2
b60f3000 b60fa000 r-xp /lib/librt-2.20-2014.11.so
b60fc000 b611b000 r-xp /usr/lib/libector.so.1.13.0
b611e000 b614b000 r-xp /usr/lib/liblua-5.1.so
b614c000 b61dc000 r-xp /usr/lib/libfreetype.so.6.11.3
b61e0000 b621e000 r-xp /usr/lib/libfontconfig.so.1.8.0
b621f000 b6235000 r-xp /usr/lib/libfribidi.so.0.3.1
b6236000 b628f000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6292000 b62dd000 r-xp /lib/libm-2.20-2014.11.so
b62df000 b62f1000 r-xp /usr/lib/libeio.so.1.13.0
b62f2000 b62f5000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62f6000 b62fc000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62fd000 b6320000 r-xp /usr/lib/libefreet.so.1.13.0
b6323000 b634e000 r-xp /usr/lib/libeldbus.so.1.13.0
b634f000 b6383000 r-xp /usr/lib/libecore_con.so.1.13.0
b6385000 b638e000 r-xp /usr/lib/libecore_imf.so.1.13.0
b638f000 b6398000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6399000 b63ac000 r-xp /usr/lib/libeo.so.1.13.0
b63ae000 b63c1000 r-xp /usr/lib/libecore_input.so.1.13.0
b63c2000 b63c9000 r-xp /usr/lib/libecore_file.so.1.13.0
b63ca000 b63ed000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63ee000 b641a000 r-xp /usr/lib/libeet.so.1.13.0
b6423000 b648e000 r-xp /usr/lib/libeina.so.1.13.0
b6491000 b64a8000 r-xp /usr/lib/libefl.so.1.13.0
b64aa000 b6611000 r-xp /usr/lib/libicuuc.so.51.1
b661f000 b682b000 r-xp /usr/lib/libicui18n.so.51.1
b6833000 b6882000 r-xp /usr/lib/libecore_x.so.1.13.0
b6884000 b689e000 r-xp /lib/libgcc_s-4.9.so.1
b68a0000 b68a4000 r-xp /lib/libcap.so.2.21
b68a5000 b68eb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68ec000 b68f3000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68f5000 b6947000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6949000 b6ad4000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6ad9000 b6ba7000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6baa000 b6bae000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6baf000 b6bbe000 r-xp /usr/lib/libvconf.so.0.2.45
b6bbf000 b6bc2000 r-xp /usr/lib/libvasum.so.0.3.1
b6bc3000 b6bc6000 r-xp /usr/lib/libttrace.so.1.1
b6bc8000 b6bcc000 r-xp /usr/lib/libiniparser.so.0
b6bcd000 b6bfd000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bfe000 b6c07000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c08000 b6c2d000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c2e000 b6c3e000 r-xp /usr/lib/libunwind.so.8.0.1
b6c48000 b6df6000 r-xp /lib/libc-2.20-2014.11.so
b6dfe000 b6f41000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f43000 b6f9b000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f9c000 b6fd0000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fd3000 b70a7000 r-xp /usr/lib/libedje.so.1.13.0
b70aa000 b70d6000 r-xp /usr/lib/libecore.so.1.13.0
b70e7000 b730d000 r-xp /usr/lib/libevas.so.1.13.0
b7335000 b734d000 r-xp /lib/libpthread-2.20-2014.11.so
b7351000 b76cb000 r-xp /usr/lib/libelementary.so.1.13.0
b76eb000 b76ef000 r-xp /usr/lib/libsmack.so.1.0.0
b76f0000 b76f9000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76fa000 b76fd000 r-xp /usr/lib/libdlog.so.0.0.0
b76fe000 b7703000 r-xp /usr/lib/libbundle.so.0.1.22
b7704000 b7707000 r-xp /lib/libdl-2.20-2014.11.so
b7709000 b772e000 r-xp /usr/lib/libaul.so.0.1.0
b7731000 b7733000 r-xp /usr/lib/libappsvc.so.0.1.0
b7734000 b7739000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b773a000 b7741000 r-xp /usr/lib/libappcore-efl.so.1.1
b7743000 b7748000 r-xp /usr/lib/libsys-assert.so
b774b000 b774c000 r-xp [vdso]
b774c000 b776e000 r-xp /lib/ld-2.20-2014.11.so
b7770000 b7778000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:16743)
Call Stack Count: 29
 0: (0xb6cd5322) [/lib/libc.so.6] + 0x8d322
 1: (0xb749cd77) [/usr/lib/libelementary.so.1] + 0x14bd77
 2: (0xb74a2216) [/usr/lib/libelementary.so.1] + 0x151216
 3: (0xb74a2802) [/usr/lib/libelementary.so.1] + 0x151802
 4: (0xb74a2f64) [/usr/lib/libelementary.so.1] + 0x151f64
 5: (0xb74a3440) [/usr/lib/libelementary.so.1] + 0x152440
 6: (0xb74a42d9) [/usr/lib/libelementary.so.1] + 0x1532d9
 7: elm_genlist_item_append + 0x1bb (0xb74abbcb) [/usr/lib/libelementary.so.1] + 0x15abcb
 8: popup_set_btn_clicked_cb + 0x20e (0xb37af2de) [/opt/usr/apps/org.example.example/bin/example] + 0x52de
 9: (0xb7170116) [/usr/lib/libevas.so.1] + 0x89116
10: (0xb63a7319) [/usr/lib/libeo.so.1] + 0xe319
11: eo_event_callback_call + 0xb3 (0xb63a4d63) [/usr/lib/libeo.so.1] + 0xbd63
12: evas_object_smart_callback_call + 0x75 (0xb71729e5) [/usr/lib/libevas.so.1] + 0x8b9e5
13: (0xb7423404) [/usr/lib/libelementary.so.1] + 0xd2404
14: (0xb7056f39) [/usr/lib/libedje.so.1] + 0x83f39
15: (0xb705da11) [/usr/lib/libedje.so.1] + 0x8aa11
16: (0xb7057fdc) [/usr/lib/libedje.so.1] + 0x84fdc
17: (0xb70584cb) [/usr/lib/libedje.so.1] + 0x854cb
18: (0xb705868f) [/usr/lib/libedje.so.1] + 0x8568f
19: (0xb70bd702) [/usr/lib/libecore.so.1] + 0x13702
20: (0xb70b7055) [/usr/lib/libecore.so.1] + 0xd055
21: (0xb70c01b9) [/usr/lib/libecore.so.1] + 0x161b9
22: ecore_main_loop_begin + 0x57 (0xb70c0587) [/usr/lib/libecore.so.1] + 0x16587
23: elm_run + 0x2d (0xb751922d) [/usr/lib/libelementary.so.1] + 0x1c822d
24: appcore_efl_main + 0x4de (0xb773ddde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
25: ui_app_main + 0x140 (0xb7736c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
26: main + 0x27e (0xb37b10ae) [/opt/usr/apps/org.example.example/bin/example] + 0x70ae
27: (0xb7772148) [/opt/usr/apps/org.example.example/bin/example] + 0xb7772148
28: __libc_start_main + 0xde (0xb6c5fe4e) [/lib/libc.so.6] + 0x17e4e
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
53) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1891769644], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-31 18:29:40.638+0900 D/DATA_PROVIDER_MASTER( 2929): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
05-31 18:29:40.638+0900 D/PKGMGR  ( 2870): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1891769644], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-31 18:29:40.638+0900 W/cluster-home( 2870): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[2], package[org.example.example]
05-31 18:29:40.638+0900 D/cluster-home( 2870): widget-data-provider.cpp: PackageUpdated(2160) >  No boxes that pkgname is[org.example.example]
05-31 18:29:40.638+0900 D/PKGMGR  ( 2870): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1891769644], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-31 18:29:40.638+0900 D/cluster-home( 2870): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[28700003] pkg_type[tpk] package[org.example.example] key[end] val[ok] pmsg[(null)]
05-31 18:29:40.638+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
05-31 18:29:40.638+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
05-31 18:29:40.638+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
05-31 18:29:40.638+0900 D/DATA_PROVIDER_MASTER( 2929): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
05-31 18:29:40.638+0900 D/DATA_PROVIDER_MASTER( 2929): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
05-31 18:29:40.638+0900 D/DATA_PROVIDER_MASTER( 2929): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.example]
05-31 18:29:40.638+0900 D/cluster-home( 2870): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
05-31 18:29:40.638+0900 D/cluster-home( 2870): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.example]
05-31 18:29:40.638+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.example]
05-31 18:29:40.638+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.example]
05-31 18:29:40.638+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
05-31 18:29:40.638+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
05-31 18:29:40.638+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.example]
05-31 18:29:40.638+0900 D/AUL_AMD ( 2765): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.example, type:rpm
05-31 18:29:40.648+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.example] Name[forpet] Icon[/opt/usr/apps/org.example.example/shared/res/1.jpg] enable[1] system[0]
05-31 18:29:40.648+0900 D/cluster-home( 2870): mainmenu-presenter.cpp: OnAppUpdated(337) >  pAppId [org.example.example]
05-31 18:29:40.648+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.example
05-31 18:29:40.648+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[17], isFolder[0], pageId[1], col[4], row[4], appId[org.example.example], name[forpet], menuId[1], isPreload[0] isPreload[0]
05-31 18:29:40.648+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
05-31 18:29:40.648+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.example] Name[forpet] Icon[/opt/usr/apps/org.example.example/shared/res/1.jpg] enable[1] system[0]
05-31 18:29:40.648+0900 D/cluster-home( 2870): mainmenu-presenter.cpp: OnAppUpdated(364) >  name [forpet]
05-31 18:29:40.648+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
05-31 18:29:40.648+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
05-31 18:29:40.648+0900 D/test-log( 2870): mainmenu-box-impl.cpp: UpdateBoxData(812) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.example/shared/res/1.jpg], New icon path[/opt/usr/apps/org.example.example/shared/res/1.jpg]!!!!!
05-31 18:29:40.648+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 1, appId = $appId, name = $name, col = 4, row = 4, isPreload = 0, isSystem = 0 WHERE boxId = 17]
05-31 18:29:40.648+0900 D/PKGMGR  ( 2935): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-1891769644], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-31 18:29:40.648+0900 D/ESD     ( 2935): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29350002), pkg_type(tpk), pkgid(org.example.example), key(end), val(ok)
05-31 18:29:40.648+0900 D/ESD     ( 2935): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
05-31 18:29:40.838+0900 D/rpm-installer(16909): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
05-31 18:29:40.838+0900 D/rpm-installer(16909): rpm-appcore-intf.c: main(259) > ------------------------------------------------
05-31 18:29:40.838+0900 D/rpm-installer(16909): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
05-31 18:29:40.838+0900 D/rpm-installer(16909): rpm-appcore-intf.c: main(261) > ------------------------------------------------
05-31 18:29:40.848+0900 D/PKGMGR_SERVER(16820): pkgmgr-server.c: sighandler(387) > child exit [16909]
05-31 18:29:40.848+0900 E/PKGMGR_SERVER(16820): pkgmgr-server.c: sighandler(402) > child NORMAL exit [16909]
05-31 18:29:40.988+0900 E/PKGMGR_SERVER(16820): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
05-31 18:29:40.998+0900 E/PKGMGR_SERVER(16820): pkgmgr-server.c: main(2265) > package manager server terminated.
05-31 18:29:41.388+0900 D/AUL_AMD ( 2765): amd_request.c: __request_handler(838) > __request_handler: 0
05-31 18:29:41.388+0900 D/AUL_AMD ( 2765): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
05-31 18:29:41.388+0900 D/PKGMGR_INFO( 2765): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
05-31 18:29:41.388+0900 D/PKGMGR_INFO( 2765): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
05-31 18:29:41.388+0900 I/AUL     ( 2765): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
05-31 18:29:41.388+0900 D/AUL     ( 2765): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 16960, pid = 16962
05-31 18:29:41.388+0900 D/PKGMGR_INFO( 2765): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
05-31 18:29:41.388+0900 D/PKGMGR_INFO( 2765): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
05-31 18:29:41.388+0900 I/AUL     ( 2765): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
05-31 18:29:41.388+0900 E/AUL_AMD ( 2765): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
05-31 18:29:41.388+0900 W/AUL_AMD ( 2765): amd_launch.c: _start_app(2233) > caller pid : 16962
05-31 18:29:41.388+0900 E/AUL_AMD ( 2765): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
05-31 18:29:41.388+0900 W/AUL_AMD ( 2765): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
05-31 18:29:41.388+0900 D/AUL_AMD ( 2765): amd_launch.c: _start_app(2648) > process_pool: false
05-31 18:29:41.388+0900 D/AUL_AMD ( 2765): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
05-31 18:29:41.388+0900 D/AUL_AMD ( 2765): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
05-31 18:29:41.388+0900 W/AUL_AMD ( 2765): amd_launch.c: _start_app(2665) > pad pid(-5)
05-31 18:29:41.388+0900 D/AUL_AMD ( 2765): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
05-31 18:29:41.388+0900 D/AUL_AMD ( 2765): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
05-31 18:29:41.388+0900 D/AUL     ( 2765): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
05-31 18:29:41.398+0900 D/AUL_PAD ( 2922): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
05-31 18:29:41.398+0900 D/AUL_PAD ( 2922): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
05-31 18:29:41.398+0900 D/AUL_PAD ( 2922): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-31 18:29:41.398+0900 D/AUL_PAD ( 2922): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-31 18:29:41.398+0900 D/AUL_PAD ( 2922): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-31 18:29:41.398+0900 D/AUL_PAD ( 2922): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-31 18:29:41.398+0900 D/AUL_PAD ( 2922): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-31 18:29:41.398+0900 D/AUL_PAD ( 2922): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
05-31 18:29:41.398+0900 D/AUL_PAD ( 2922): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
05-31 18:29:41.398+0900 D/AUL_PAD ( 2922): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
05-31 18:29:41.398+0900 D/AUL_PAD ( 2922): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
05-31 18:29:41.398+0900 D/AUL_PAD ( 2922): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
05-31 18:29:41.398+0900 D/AUL_PAD ( 2922): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
05-31 18:29:41.398+0900 D/AUL_PAD ( 2922): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
05-31 18:29:41.398+0900 W/AUL_PAD ( 2922): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
05-31 18:29:41.398+0900 D/AUL     ( 2922): process_pool.c: __send_pkt_raw_data(219) > send(11) : 624 / 624
05-31 18:29:41.398+0900 D/AUL_PAD ( 2922): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 16743, bin path: /opt/usr/apps/org.example.example/bin/example
05-31 18:29:41.398+0900 W/AUL_PAD ( 2922): launchpad.c: __send_result_to_caller(265) > Check app launching
05-31 18:29:41.398+0900 D/AUL_PAD ( 2922): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
05-31 18:29:41.398+0900 D/RESOURCED( 2857): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
05-31 18:29:41.398+0900 D/RESOURCED( 2857): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 3
05-31 18:29:41.398+0900 D/AUL_PAD (16743): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
05-31 18:29:41.398+0900 D/AUL_PAD (16743): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
05-31 18:29:41.398+0900 E/RESOURCED( 2857): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
05-31 18:29:41.398+0900 D/AUL_PAD (16743): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
05-31 18:29:41.398+0900 D/AUL_PAD (16743): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
05-31 18:29:41.398+0900 D/AUL_PAD (16743): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
05-31 18:29:41.398+0900 D/AUL_PAD (16743): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
05-31 18:29:41.398+0900 D/AUL     (16743): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (16744) is sent.
05-31 18:29:41.398+0900 D/AUL     (16743): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 16744, signo: 10
05-31 18:29:41.398+0900 D/AUL     (16743): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
05-31 18:29:41.398+0900 D/AUL_PAD (16743): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
05-31 18:29:41.398+0900 D/AUL_PAD (16743): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
05-31 18:29:41.398+0900 D/AUL_PAD (16743): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
05-31 18:29:41.398+0900 D/AUL_PAD (16743): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
05-31 18:29:41.398+0900 D/AUL_PAD (16743): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTYyMjI5ODEvMzkxNzM2AA==##
05-31 18:29:41.398+0900 D/AUL_PAD (16743): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
05-31 18:29:41.398+0900 D/AUL_PAD (16743): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAxNjk2MgA=##
05-31 18:29:41.398+0900 D/AUL_PAD (16743): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
05-31 18:29:41.398+0900 D/AUL_PAD (16743): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
05-31 18:29:41.398+0900 D/AUL_PAD (16743): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
05-31 18:29:41.398+0900 D/AUL_PAD (16743): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
05-31 18:29:41.398+0900 D/AUL_PAD (16743): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
05-31 18:29:41.408+0900 I/CAPI_APPFW_APPLICATION(16743): app_main.c: ui_app_main(788) > app_efl_main
05-31 18:29:41.408+0900 D/LAUNCH  (16743): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
05-31 18:29:41.408+0900 D/APP_CORE(16743): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
05-31 18:29:41.408+0900 D/APP_CORE(16743): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
05-31 18:29:41.408+0900 D/APP_CORE(16743): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
05-31 18:29:41.428+0900 D/APP_CORE(16743): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
05-31 18:29:41.428+0900 D/AUL     (16743): app_sock.c: __create_server_sock(156) > pg path - already exists
05-31 18:29:41.428+0900 D/APP_CORE(16743): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb4296520
05-31 18:29:41.428+0900 D/LAUNCH  (16743): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
05-31 18:29:41.428+0900 I/CAPI_APPFW_APPLICATION(16743): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
05-31 18:29:41.498+0900 D/AUL_PAD ( 2922): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
05-31 18:29:41.498+0900 W/AUL     ( 2765): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 16743, appid: org.example.example
05-31 18:29:41.498+0900 D/AUL     ( 2765): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
05-31 18:29:41.498+0900 E/AUL     ( 2765): simple_util.c: __trm_app_info_send_socket(330) > access
05-31 18:29:41.498+0900 D/AUL_AMD ( 2765): amd_launch.c: _start_app(2700) > add app group info
05-31 18:29:41.498+0900 E/AUL     ( 2765): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
05-31 18:29:41.498+0900 D/AUL_AMD ( 2765): amd_status.c: _status_add_app_info_list(427) > pid(16743) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
05-31 18:29:41.498+0900 D/RESOURCED( 2857): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 16743
05-31 18:29:41.498+0900 D/RESOURCED( 2857): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
05-31 18:29:41.498+0900 E/RESOURCED( 2857): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
05-31 18:29:41.498+0900 D/RESOURCED( 2857): proc-main.c: resourced_proc_status_change(888) > available memory = 316
05-31 18:29:41.558+0900 D/LAUNCH  (16743): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
05-31 18:29:41.558+0900 D/APP_CORE(16743): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
05-31 18:29:41.558+0900 E/E17     ( 2735): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02000002)
05-31 18:29:41.598+0900 E/E17     ( 2735): e_border.c: e_border_show(2088) > BD_SHOW(0x02000002)
05-31 18:29:41.628+0900 D/APP_CORE(16743): appcore.c: __aul_handler(587) > [APP 16743]     AUL event: AUL_START
05-31 18:29:41.628+0900 I/APP_CORE(16743): appcore-efl.c: __do_app(496) > [APP 16743] Event: RESET State: CREATED
05-31 18:29:41.628+0900 D/APP_CORE(16743): appcore-efl.c: __do_app(527) > [APP 16743] RESET
05-31 18:29:41.628+0900 D/LAUNCH  (16743): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
05-31 18:29:41.628+0900 D/APP_CORE(16743): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
05-31 18:29:41.628+0900 D/APP_CORE(16743): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-31 18:29:41.628+0900 I/CAPI_APPFW_APPLICATION(16743): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
05-31 18:29:41.628+0900 D/AUL     (16743): service.c: __set_bundle(186) > __set_bundle
05-31 18:29:41.628+0900 D/LAUNCH  (16743): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
05-31 18:29:41.628+0900 D/APP_CORE(16743): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
05-31 18:29:41.638+0900 E/EFL     (16743): edje<16743> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-31 18:29:41.638+0900 E/EFL     (16743): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 18:29:41.638+0900 E/EFL     (16743): edje<16743> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-31 18:29:41.638+0900 E/EFL     (16743): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 18:29:41.638+0900 E/EFL     (16743): edje<16743> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-31 18:29:41.638+0900 E/EFL     (16743): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 18:29:41.638+0900 E/EFL     (16743): edje<16743> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-31 18:29:41.638+0900 E/EFL     (16743): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 18:29:41.638+0900 E/EFL     (16743): edje<16743> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-31 18:29:41.638+0900 E/EFL     (16743): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 18:29:41.658+0900 W/APP_CORE(16743): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2000002
05-31 18:29:41.658+0900 D/APP_CORE(16743): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2000002
05-31 18:29:41.658+0900 D/APP_CORE(16743): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
05-31 18:29:41.658+0900 D/AUL     (16743): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
05-31 18:29:41.658+0900 D/AUL_AMD ( 2765): amd_request.c: __request_handler(838) > __request_handler: 34
05-31 18:29:41.658+0900 W/PROCESSMGR( 2735): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=16743
05-31 18:29:41.678+0900 E/EFL     ( 2735): eo<2735> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-31 18:29:41.678+0900 E/EFL     ( 2735): eo<2735> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-31 18:29:41.698+0900 D/AUL_AMD ( 2765): amd_request.c: __request_handler(838) > __request_handler: 15
05-31 18:29:41.698+0900 D/PKGMGR_INFO( 2765): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-31 18:29:41.698+0900 D/PKGMGR_INFO( 2765): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-31 18:29:41.708+0900 D/AUL_AMD ( 2765): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 16743 is org.example.example
05-31 18:29:41.708+0900 D/AUL_AMD ( 2765): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 16743 : 0
05-31 18:29:41.708+0900 D/AUL     ( 2938): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
05-31 18:29:41.708+0900 D/INDICATOR( 2861): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
05-31 18:29:41.708+0900 D/INDICATOR( 2861): util.c: util_signal_emit_by_win(116) > emission bg.opaque
05-31 18:29:41.708+0900 D/INDICATOR( 2861): main.c: _rotate_window(229) > Indicator angle is 0 degree
05-31 18:29:41.708+0900 D/INDICATOR( 2861): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
05-31 18:29:41.708+0900 D/INDICATOR( 2861): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
05-31 18:29:41.708+0900 D/INDICATOR( 2861): main.c: _rotate_window(252) > port :: hide more icon
05-31 18:29:41.958+0900 D/APP_CORE(16743): appcore.c: __prt_ltime(236) > [APP 16743] first idle after reset: 577 msec
05-31 18:29:42.068+0900 E/E17     ( 2735): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
05-31 18:29:42.078+0900 D/APP_CORE( 2870): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
05-31 18:29:42.078+0900 D/APP_CORE( 2870): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
05-31 18:29:42.078+0900 D/APP_CORE( 2870): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
05-31 18:29:42.078+0900 I/APP_CORE( 2870): appcore-efl.c: __do_app(496) > [APP 2870] Event: PAUSE State: RUNNING
05-31 18:29:42.078+0900 D/APP_CORE( 2870): appcore-efl.c: __do_app(565) > [APP 2870] PAUSE
05-31 18:29:42.078+0900 I/CAPI_APPFW_APPLICATION( 2870): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
05-31 18:29:42.078+0900 E/cluster-home( 2870): homescreen.cpp: OnPause(84) >  app pause
05-31 18:29:42.078+0900 D/cluster-view( 2870): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
05-31 18:29:42.078+0900 D/cluster-view( 2870): homescreen-view-manager.cpp: AppPause(923) >  END
05-31 18:29:42.078+0900 D/APP_CORE( 2870): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-31 18:29:42.078+0900 E/APP_CORE( 2870): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-31 18:29:42.078+0900 D/AUL_AMD ( 2765): amd_status.c: _status_update_app_info_list(456) > pid(2870) status(4)
05-31 18:29:42.078+0900 D/AUL_AMD ( 2765): amd_status.c: _status_update_app_info_list(468) > pid(2870) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
05-31 18:29:42.078+0900 D/AUL     ( 2765): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
05-31 18:29:42.078+0900 W/AUL     ( 2765): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2870, appid: org.tizen.homescreen, status: bg
05-31 18:29:42.088+0900 D/DATA_PROVIDER_MASTER( 2929): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2870 is paused
05-31 18:29:42.098+0900 D/DATA_PROVIDER_MASTER( 2929): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
05-31 18:29:42.098+0900 D/AUL_AMD ( 2765): amd_launch.c: __e17_status_handler(2891) > pid(16743) status(3)
05-31 18:29:42.098+0900 D/AUL_AMD ( 2765): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
05-31 18:29:42.098+0900 W/AUL_AMD ( 2765): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-31 18:29:42.098+0900 W/AUL_AMD ( 2765): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
05-31 18:29:42.098+0900 D/AUL_AMD ( 2765): amd_status.c: _status_update_app_info_list(456) > pid(16743) status(3)
05-31 18:29:42.098+0900 D/AUL_AMD ( 2765): amd_status.c: _status_update_app_info_list(468) > pid(16743) appid(org.example.example) pkgid(org.example.example) status(3)
05-31 18:29:42.098+0900 D/AUL     ( 2765): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
05-31 18:29:42.098+0900 W/AUL     ( 2765): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 16743, appid: org.example.example, status: fg
05-31 18:29:42.108+0900 I/CAPI_WIDGET_APPLICATION( 3020): widget_app.c: __provider_pause_cb(294) > widget obj was paused
05-31 18:29:42.108+0900 I/CAPI_WIDGET_APPLICATION( 3020): widget_app.c: __check_status_for_cgroup(142) > enter background group
05-31 18:29:42.108+0900 W/AUL     ( 3020): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3020, appid: org.tizen.calendar.widget, status: bg
05-31 18:29:42.108+0900 D/RESOURCED( 2857): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 16743
05-31 18:29:42.108+0900 D/RESOURCED( 2857): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 16743, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
05-31 18:29:42.108+0900 D/RESOURCED( 2857): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 16743
05-31 18:29:42.138+0900 D/APP_CORE(16743): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2000002 fully_obscured 0
05-31 18:29:42.138+0900 D/APP_CORE(16743): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
05-31 18:29:42.138+0900 D/APP_CORE(16743): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
05-31 18:29:42.138+0900 I/APP_CORE(16743): appcore-efl.c: __do_app(496) > [APP 16743] Event: RESUME State: CREATED
05-31 18:29:42.138+0900 D/LAUNCH  (16743): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
05-31 18:29:42.138+0900 D/APP_CORE(16743): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
05-31 18:29:42.138+0900 D/APP_CORE(16743): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-31 18:29:42.138+0900 D/APP_CORE(16743): appcore-efl.c: __do_app(607) > [APP 16743] RESUME
05-31 18:29:42.138+0900 I/APP_CORE(16743): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
05-31 18:29:42.138+0900 I/APP_CORE(16743): appcore-efl.c: __do_app(614) > [APP 16743] Initial Launching, call the resume_cb
05-31 18:29:42.138+0900 I/CAPI_APPFW_APPLICATION(16743): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
05-31 18:29:42.138+0900 D/LAUNCH  (16743): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
05-31 18:29:42.138+0900 D/LAUNCH  (16743): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
05-31 18:29:42.138+0900 D/APP_CORE(16743): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-31 18:29:42.138+0900 E/APP_CORE(16743): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-31 18:29:42.168+0900 D/RESOURCED( 2857): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 16743, appname = org.example.example, pkgname = org.example.example
05-31 18:29:42.168+0900 D/RESOURCED( 2857): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 16743, appname = org.example.example
05-31 18:29:42.168+0900 D/RESOURCED( 2857): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 16743
05-31 18:29:42.168+0900 D/RESOURCED( 2857): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3020, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
05-31 18:29:42.168+0900 D/RESOURCED( 2857): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3020
05-31 18:29:42.168+0900 D/RESOURCED( 2857): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3020, appname = org.tizen.calendar.widget
05-31 18:29:42.168+0900 D/RESOURCED( 2857): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3020
05-31 18:29:42.168+0900 I/RESOURCED( 2857): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
05-31 18:29:42.168+0900 I/RESOURCED( 2857): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
05-31 18:29:42.288+0900 D/AUL_AMD ( 2765): amd_launch.c: __e17_status_handler(2910) > pid(16743) status(0)
05-31 18:29:42.508+0900 D/AUL_PAD ( 2922): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
05-31 18:29:42.508+0900 D/AUL_PAD (16969): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
05-31 18:29:42.528+0900 D/AUL_PAD ( 2922): sigchild.h: __send_app_launch_signal(131) > send launch signal done
05-31 18:29:42.538+0900 E/RESOURCED( 2857): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1131
05-31 18:29:43.008+0900 D/AUL_AMD ( 2765): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
05-31 18:29:43.008+0900 D/RUA     ( 2765): rua.c: rua_add_history(179) > rua_add_history start
05-31 18:29:43.028+0900 D/RUA     ( 2765): rua.c: rua_add_history(247) > rua_add_history ok
05-31 18:29:43.198+0900 D/PROCESSMGR( 2735): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x402d1e 
05-31 18:29:43.548+0900 D/AUL_PAD (16969): launchpad_loader.c: main(588) > sleeping 1 sec...
05-31 18:29:43.548+0900 D/AUL_PAD (16969): preload.h: __preload_init(52) > max_cmdline_size = 1053
05-31 18:29:43.548+0900 D/AUL_PAD (16969): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b95a4760
05-31 18:29:43.558+0900 D/AUL_PAD (16969): preload.h: __preload_init(69) > get pre-initialization function
05-31 18:29:43.558+0900 D/AUL_PAD (16969): preload.h: __preload_init(73) > get shutdown function
05-31 18:29:43.558+0900 D/AUL_PAD (16969): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b95a4a40
05-31 18:29:43.558+0900 D/AUL_PAD (16969): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b95a6640
05-31 18:29:43.558+0900 D/AUL_PAD (16969): preload.h: __preload_init(69) > get pre-initialization function
05-31 18:29:43.568+0900 D/AUL_PAD (16969): preload.h: __preload_init(73) > get shutdown function
05-31 18:29:43.568+0900 D/AUL_PAD (16969): preexec.h: __preexec_init(76) > preexec start
05-31 18:29:43.568+0900 D/AUL_PAD (16969): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
05-31 18:29:43.568+0900 D/AUL     (16969): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
05-31 18:29:43.568+0900 D/AUL     (16969): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
05-31 18:29:43.568+0900 D/AUL     (16969): process_pool.c: __connect_to_launchpad(132) > send(16969) : 4
05-31 18:29:43.568+0900 D/AUL     (16969): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
05-31 18:29:43.568+0900 D/AUL_PAD ( 2922): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-31 18:29:43.568+0900 D/AUL_PAD ( 2922): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
05-31 18:29:43.568+0900 D/AUL_PAD ( 2922): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-31 18:29:43.568+0900 D/AUL_PAD ( 2922): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-31 18:29:43.568+0900 D/AUL_PAD ( 2922): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-31 18:29:43.568+0900 D/AUL_PAD ( 2922): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-31 18:29:43.568+0900 D/AUL_PAD ( 2922): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-31 18:29:43.568+0900 D/AUL_PAD ( 2922): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
05-31 18:29:43.568+0900 D/AUL_PAD ( 2922): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 16969
05-31 18:29:43.788+0900 D/AUL_PAD (16969): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
05-31 18:29:43.788+0900 D/AUL_PAD (16969): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
05-31 18:29:43.788+0900 D/AUL_PAD (16969): launchpad_loader.c: main(693) > [candidate] ecore handler add
05-31 18:29:43.798+0900 D/AUL_PAD (16969): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
05-31 18:29:44.088+0900 D/PROCESSMGR( 2735): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x402d1e 
05-31 18:29:44.348+0900 E/EFL     (16743): edje<16743> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 18:29:44.358+0900 E/EFL     (16743): edje<16743> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 18:29:44.408+0900 E/EFL     (16743): edje<16743> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 18:29:44.418+0900 E/EFL     (16743): edje<16743> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 18:29:44.418+0900 E/EFL     (16743): edje<16743> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 18:29:44.418+0900 E/EFL     (16743): edje<16743> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 18:29:44.418+0900 E/EFL     (16743): edje<16743> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 18:29:44.428+0900 E/EFL     (16743): edje<16743> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 18:29:44.428+0900 E/EFL     (16743): edje<16743> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 18:29:44.448+0900 D/IMMODULE(16743): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
05-31 18:29:44.448+0900 D/ISF_SOCKET(16743): scim_socket.cpp: connect(515) > ppid:2922  trying connect() to local:/tmp/scim-socket-frontend, example
05-31 18:29:44.448+0900 D/ISF_SOCKET(16743): scim_socket.cpp: connect(524) > connect() succeeded
05-31 18:29:44.458+0900 D/ISF_SOCKET(16743): scim_socket.cpp: connect(515) > ppid:2922  trying connect() to local:/tmp/scim-socket-frontend, example
05-31 18:29:44.458+0900 D/ISF_SOCKET(16743): scim_socket.cpp: connect(524) > connect() succeeded
05-31 18:29:44.518+0900 D/ISF_SOCKET(16743): scim_socket.cpp: connect(515) > ppid:2922  trying connect() to local:/tmp/scim-socket-frontend, example
05-31 18:29:44.518+0900 D/ISF_SOCKET(16743): scim_socket.cpp: connect(524) > connect() succeeded
05-31 18:29:44.528+0900 D/ISF_QUERY(16743): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
05-31 18:29:44.528+0900 D/ISF_QUERY(16743): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-31 18:29:44.538+0900 D/ISF_QUERY(16743): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-31 18:29:44.538+0900 D/ISF_QUERY(16743): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-31 18:29:44.538+0900 D/ISF_QUERY(16743): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-31 18:29:44.538+0900 D/ISF_QUERY(16743): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-31 18:29:44.538+0900 D/ISF_QUERY(16743): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-31 18:29:44.548+0900 D/ISF_SOCKET(16743): scim_socket.cpp: connect(515) > ppid:2922  trying connect() to local:/tmp/scim-socket-frontend, example
05-31 18:29:44.548+0900 D/ISF_SOCKET(16743): scim_socket.cpp: connect(524) > connect() succeeded
05-31 18:29:44.558+0900 D/IMMODULE(16743): scim_panel_client.cpp: open_connection(162) > 
05-31 18:29:44.558+0900 D/ISF_SOCKET(16743): scim_socket.cpp: connect(515) > ppid:2922  trying connect() to local:/tmp/scim-panel-socket:0, example
05-31 18:29:44.558+0900 D/ISF_SOCKET(16743): scim_socket.cpp: connect(524) > connect() succeeded
05-31 18:29:44.568+0900 D/ISF_SOCKET(16743): scim_socket.cpp: connect(515) > ppid:2922  trying connect() to local:/tmp/scim-panel-socket:0, example
05-31 18:29:44.568+0900 D/ISF_SOCKET(16743): scim_socket.cpp: connect(524) > connect() succeeded
05-31 18:29:44.588+0900 D/IMMODULE(16743): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 1
05-31 18:29:45.098+0900 D/PROCESSMGR( 2735): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2000002
05-31 18:29:45.438+0900 D/PROCESSMGR( 2735): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x402d1e 
05-31 18:29:46.087+0900 D/PROCESSMGR( 2735): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x402d1e 
05-31 18:29:47.087+0900 D/APP_CORE( 2870): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
05-31 18:29:47.087+0900 I/APP_CORE( 2870): appcore-efl.c: __do_app(496) > [APP 2870] Event: MEM_FLUSH State: PAUSED
05-31 18:29:47.087+0900 D/APP_CORE( 2870): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
05-31 18:29:47.087+0900 D/APP_CORE( 2870): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2870
05-31 18:29:47.087+0900 D/APP_CORE( 2870): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
05-31 18:29:47.087+0900 D/RESOURCED( 2857): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2870
05-31 18:29:47.607+0900 D/PROCESSMGR( 2735): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x402d1e 
05-31 18:29:48.497+0900 D/PROCESSMGR( 2735): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x402d1e 
05-31 18:29:49.847+0900 D/PROCESSMGR( 2735): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x402d1e 
05-31 18:29:50.007+0900 E/EFL     (16743): edje<16743> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
05-31 18:29:50.007+0900 E/EFL     (16743): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 18:29:50.017+0900 I/user_tag(16743): SUN
05-31 18:29:50.017+0900 I/user_tag(16743): 설마
05-31 18:29:50.017+0900 I/user_tag(16743): MON
05-31 18:29:50.107+0900 D/PROCESSMGR( 2735): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x402d1e bd->visible=1
05-31 18:29:53.057+0900 D/PROCESSMGR( 2735): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x402d1e 
05-31 18:29:53.207+0900 I/user_tag(16743): 06:29 PM
05-31 18:29:53.227+0900 E/EFL     (16743): edje<16743> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 18:29:53.227+0900 E/EFL     (16743): edje<16743> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 18:29:53.227+0900 E/EFL     (16743): edje<16743> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 18:29:53.237+0900 E/EFL     (16743): edje<16743> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 18:29:53.247+0900 E/EFL     (16743): edje<16743> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 18:29:53.287+0900 W/CRASH_MANAGER(16746): worker.c: worker_job(1204) > 1116743657861149622299
