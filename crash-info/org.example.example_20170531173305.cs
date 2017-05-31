S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 12127
Date: 2017-05-31 17:33:05+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb37e1fb7, esi = 0xb37e4214
ebp = 0xbfda6ae8, esp = 0xbfda6a30
eax = 0x00000000, ebx = 0x00000004
ecx = 0x00000000, edx = 0xb940f2d0
eip = 0xb37df342

Memory Information
MemTotal:      123 KB
MemFree:        24 KB
Buffers:         5 KB
Cached:     186864 KB
VmPeak:     122284 KB
VmSize:     122284 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       35132 KB
VmRSS:       35132 KB
VmData:      52384 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34624 KB
VmPTE:         104 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 12127 TID = 12127
12127 12128 12352 12353 12356 

Maps Information
b0ee6000 b0efe000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b1803000 b180a000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b180d000 b1814000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b18c9000 b18cd000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2ba2000 b2bac000 r-xp /usr/lib/libfeedback.so.0.1.4
b2bb2000 b2bbe000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2bbf000 b2be0000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2be5000 b2be6000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2be7000 b2bec000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2bed000 b2bee000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2bef000 b2bf1000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2bf2000 b2bf4000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2bf5000 b2c01000 r-xp /usr/lib/libdrm.so.2.4.0
b2c02000 b2c0c000 r-xp /usr/lib/libtbm.so.1.0.0
b2c0d000 b2c22000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c23000 b2c35000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3437000 b3468000 r-xp /usr/lib/libidn.so.11.5.44
b3469000 b348b000 r-xp /usr/lib/libnghttp2.so.5.4.0
b348c000 b349c000 r-xp /usr/lib/libcares.so.2.1.0
b349d000 b34a6000 r-xp /usr/lib/libeventsystem.so.0.0.1
b34a7000 b34b0000 r-xp /usr/lib/libefl-extension.so.0.1.0
b34b1000 b3528000 r-xp /usr/lib/libcurl.so.4.3.0
b352a000 b353c000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b353d000 b355e000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b3565000 b3566000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3567000 b3568000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3569000 b356c000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b356d000 b3570000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3678000 b367e000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b367f000 b37c3000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37d3000 b37d6000 r-xp /usr/lib/libdri2.so.0.0.0
b37d7000 b37d8000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37d9000 b37e3000 r-xp /opt/usr/apps/org.example.example/bin/example
b37e5000 b381e000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4221000 b422c000 r-xp /lib/libnss_files-2.20-2014.11.so
b422e000 b4239000 r-xp /lib/libnss_nis-2.20-2014.11.so
b423b000 b4252000 r-xp /lib/libnsl-2.20-2014.11.so
b4256000 b425e000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4260000 b4284000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4285000 b4286000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4287000 b428a000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b428b000 b4292000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4293000 b429d000 r-xp /usr/lib/libsensord-share.so
b429e000 b42ba000 r-xp /usr/lib/libsensor.so.1.2.0
b42bc000 b42c5000 r-xp /usr/lib/libappcore-common.so.1.1
b42c8000 b42ca000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42df000 b42e1000 r-xp /usr/lib/libXau.so.6.0.0
b42e2000 b4304000 r-xp /usr/lib/libxcb.so.1.1.0
b4306000 b430f000 r-xp /lib/libcrypt-2.20-2014.11.so
b4338000 b433a000 r-xp /usr/lib/libiri.so
b433b000 b4361000 r-xp /lib/libexpat.so.1.5.2
b4363000 b43ce000 r-xp /usr/lib/libssl.so.1.0.0
b43d4000 b43e0000 r-xp /usr/lib/libethumb.so.1.13.0
b43e1000 b43e5000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43e6000 b4637000 r-xp /usr/lib/libcrypto.so.1.0.0
b5bb2000 b5bc2000 r-xp /usr/lib/libXi.so.6.1.0
b5bc3000 b5bc5000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bc6000 b5bcc000 r-xp /usr/lib/libXtst.so.6.1.0
b5bcd000 b5bd7000 r-xp /usr/lib/libXrender.so.1.3.0
b5bd8000 b5be1000 r-xp /usr/lib/libXrandr.so.2.2.0
b5be3000 b5be5000 r-xp /usr/lib/libXinerama.so.1.0.0
b5be6000 b5beb000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bec000 b5bfe000 r-xp /usr/lib/libXext.so.6.4.0
b5bff000 b5c01000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c02000 b5c04000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c06000 b5d48000 r-xp /usr/lib/libX11.so.6.3.0
b5d4c000 b5d56000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d57000 b5d6d000 r-xp /usr/lib/libudev.so.1.6.0
b5d70000 b5d74000 r-xp /lib/libattr.so.1.1.0
b5d75000 b5da4000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5da6000 b5dac000 r-xp /usr/lib/libffi.so.6.0.2
b5dad000 b5dd0000 r-xp /lib/libz.so.1.2.8
b5dd1000 b5dd4000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5dd5000 b5f31000 r-xp /usr/lib/libxml2.so.2.9.2
b5f37000 b601e000 r-xp /usr/lib/libstdc++.so.6.0.20
b602b000 b602e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b602f000 b6051000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6052000 b6066000 r-xp /lib/libresolv-2.20-2014.11.so
b606a000 b608e000 r-xp /usr/lib/liblzma.so.5.0.3
b608f000 b6091000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6093000 b609d000 r-xp /usr/lib/libembryo.so.1.13.0
b609e000 b60c7000 r-xp /usr/lib/libpng12.so.0.50.0
b60c8000 b6111000 r-xp /usr/lib/libjpeg.so.8.0.2
b6122000 b6129000 r-xp /lib/librt-2.20-2014.11.so
b612b000 b614a000 r-xp /usr/lib/libector.so.1.13.0
b614d000 b617a000 r-xp /usr/lib/liblua-5.1.so
b617b000 b620b000 r-xp /usr/lib/libfreetype.so.6.11.3
b620f000 b624d000 r-xp /usr/lib/libfontconfig.so.1.8.0
b624e000 b6264000 r-xp /usr/lib/libfribidi.so.0.3.1
b6265000 b62be000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62c1000 b630c000 r-xp /lib/libm-2.20-2014.11.so
b630e000 b6320000 r-xp /usr/lib/libeio.so.1.13.0
b6321000 b6324000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6325000 b632b000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b632c000 b634f000 r-xp /usr/lib/libefreet.so.1.13.0
b6352000 b637d000 r-xp /usr/lib/libeldbus.so.1.13.0
b637e000 b63b2000 r-xp /usr/lib/libecore_con.so.1.13.0
b63b4000 b63bd000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63be000 b63c7000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63c8000 b63db000 r-xp /usr/lib/libeo.so.1.13.0
b63dd000 b63f0000 r-xp /usr/lib/libecore_input.so.1.13.0
b63f1000 b63f8000 r-xp /usr/lib/libecore_file.so.1.13.0
b63f9000 b641c000 r-xp /usr/lib/libecore_evas.so.1.13.0
b641d000 b6449000 r-xp /usr/lib/libeet.so.1.13.0
b6452000 b64bd000 r-xp /usr/lib/libeina.so.1.13.0
b64c0000 b64d7000 r-xp /usr/lib/libefl.so.1.13.0
b64d9000 b6640000 r-xp /usr/lib/libicuuc.so.51.1
b664e000 b685a000 r-xp /usr/lib/libicui18n.so.51.1
b6862000 b68b1000 r-xp /usr/lib/libecore_x.so.1.13.0
b68b3000 b68cd000 r-xp /lib/libgcc_s-4.9.so.1
b68cf000 b68d3000 r-xp /lib/libcap.so.2.21
b68d4000 b691a000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b691b000 b6922000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6924000 b6976000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6978000 b6b03000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b08000 b6bd6000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bd9000 b6bdd000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bde000 b6bed000 r-xp /usr/lib/libvconf.so.0.2.45
b6bee000 b6bf1000 r-xp /usr/lib/libvasum.so.0.3.1
b6bf2000 b6bf5000 r-xp /usr/lib/libttrace.so.1.1
b6bf7000 b6bfb000 r-xp /usr/lib/libiniparser.so.0
b6bfc000 b6c2c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c2d000 b6c36000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c37000 b6c5c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c5d000 b6c6d000 r-xp /usr/lib/libunwind.so.8.0.1
b6c77000 b6e25000 r-xp /lib/libc-2.20-2014.11.so
b6e2d000 b6f70000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f72000 b6fca000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fcb000 b6fff000 r-xp /usr/lib/libsystemd.so.0.4.0
b7002000 b70d6000 r-xp /usr/lib/libedje.so.1.13.0
b70d9000 b7105000 r-xp /usr/lib/libecore.so.1.13.0
b7116000 b733c000 r-xp /usr/lib/libevas.so.1.13.0
b7364000 b737c000 r-xp /lib/libpthread-2.20-2014.11.so
b7380000 b76fa000 r-xp /usr/lib/libelementary.so.1.13.0
b771a000 b771e000 r-xp /usr/lib/libsmack.so.1.0.0
b771f000 b7728000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7729000 b772c000 r-xp /usr/lib/libdlog.so.0.0.0
b772d000 b7732000 r-xp /usr/lib/libbundle.so.0.1.22
b7733000 b7736000 r-xp /lib/libdl-2.20-2014.11.so
b7738000 b775d000 r-xp /usr/lib/libaul.so.0.1.0
b7760000 b7762000 r-xp /usr/lib/libappsvc.so.0.1.0
b7763000 b7768000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7769000 b7770000 r-xp /usr/lib/libappcore-efl.so.1.1
b7772000 b7777000 r-xp /usr/lib/libsys-assert.so
b777a000 b777b000 r-xp [vdso]
b777b000 b779d000 r-xp /lib/ld-2.20-2014.11.so
b779f000 b77a7000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:12127)
Call Stack Count: 21
 0: rep_set_btn_clicked_cb + 0x92 (0xb37df342) [/opt/usr/apps/org.example.example/bin/example] + 0x6342
 1: (0xb719f116) [/usr/lib/libevas.so.1] + 0x89116
 2: (0xb63d6319) [/usr/lib/libeo.so.1] + 0xe319
 3: eo_event_callback_call + 0xb3 (0xb63d3d63) [/usr/lib/libeo.so.1] + 0xbd63
 4: evas_object_smart_callback_call + 0x75 (0xb71a19e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 5: (0xb7452404) [/usr/lib/libelementary.so.1] + 0xd2404
 6: (0xb7085f39) [/usr/lib/libedje.so.1] + 0x83f39
 7: (0xb708ca11) [/usr/lib/libedje.so.1] + 0x8aa11
 8: (0xb7086fdc) [/usr/lib/libedje.so.1] + 0x84fdc
 9: (0xb70874cb) [/usr/lib/libedje.so.1] + 0x854cb
10: (0xb708768f) [/usr/lib/libedje.so.1] + 0x8568f
11: (0xb70ec702) [/usr/lib/libecore.so.1] + 0x13702
12: (0xb70e6055) [/usr/lib/libecore.so.1] + 0xd055
13: (0xb70ef1b9) [/usr/lib/libecore.so.1] + 0x161b9
14: ecore_main_loop_begin + 0x57 (0xb70ef587) [/usr/lib/libecore.so.1] + 0x16587
15: elm_run + 0x2d (0xb754822d) [/usr/lib/libelementary.so.1] + 0x1c822d
16: appcore_efl_main + 0x4de (0xb776cdde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
17: ui_app_main + 0x140 (0xb7765c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
18: main + 0x27e (0xb37e002e) [/opt/usr/apps/org.example.example/bin/example] + 0x702e
19: (0xb77a1148) [/opt/usr/apps/org.example.example/bin/example] + 0xb77a1148
20: __libc_start_main + 0xde (0xb6c8ee4e) [/lib/libc.so.6] + 0x17e4e
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
update), value(ok)
05-31 17:32:57.500+0900 W/cluster-home( 2870): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[2], package[org.example.example]
05-31 17:32:57.500+0900 D/cluster-home( 2870): widget-data-provider.cpp: PackageUpdated(2160) >  No boxes that pkgname is[org.example.example]
05-31 17:32:57.500+0900 D/PKGMGR  ( 2870): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-999839505], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-31 17:32:57.500+0900 D/cluster-home( 2870): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[28700003] pkg_type[tpk] package[org.example.example] key[end] val[ok] pmsg[(null)]
05-31 17:32:57.500+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
05-31 17:32:57.500+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
05-31 17:32:57.500+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
05-31 17:32:57.500+0900 D/AUL_AMD ( 2765): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.example, type:rpm
05-31 17:32:57.500+0900 D/cluster-home( 2870): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
05-31 17:32:57.500+0900 D/cluster-home( 2870): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.example]
05-31 17:32:57.500+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.example]
05-31 17:32:57.500+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.example]
05-31 17:32:57.500+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
05-31 17:32:57.500+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
05-31 17:32:57.500+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.example]
05-31 17:32:57.500+0900 D/PKGMGR  ( 2929): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-999839505], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-31 17:32:57.500+0900 D/DATA_PROVIDER_MASTER( 2929): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.example] 100
05-31 17:32:57.500+0900 D/PKGMGR  ( 2929): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-999839505], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-31 17:32:57.500+0900 D/DATA_PROVIDER_MASTER( 2929): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.example] ok
05-31 17:32:57.500+0900 D/DATA_PROVIDER_MASTER( 2929): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.example], event_type[1]
05-31 17:32:57.500+0900 D/DATA_PROVIDER_MASTER( 2929): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
05-31 17:32:57.500+0900 D/DATA_PROVIDER_MASTER( 2929): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
05-31 17:32:57.500+0900 D/DATA_PROVIDER_MASTER( 2929): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
05-31 17:32:57.500+0900 D/DATA_PROVIDER_MASTER( 2929): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.example]
05-31 17:32:57.500+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.example] Name[forpet] Icon[/opt/usr/apps/org.example.example/shared/res/1.jpg] enable[1] system[0]
05-31 17:32:57.500+0900 D/cluster-home( 2870): mainmenu-presenter.cpp: OnAppUpdated(337) >  pAppId [org.example.example]
05-31 17:32:57.500+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.example
05-31 17:32:57.500+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[17], isFolder[0], pageId[1], col[4], row[4], appId[org.example.example], name[forpet], menuId[1], isPreload[0] isPreload[0]
05-31 17:32:57.500+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
05-31 17:32:57.500+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.example] Name[forpet] Icon[/opt/usr/apps/org.example.example/shared/res/1.jpg] enable[1] system[0]
05-31 17:32:57.500+0900 D/cluster-home( 2870): mainmenu-presenter.cpp: OnAppUpdated(364) >  name [forpet]
05-31 17:32:57.500+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
05-31 17:32:57.500+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
05-31 17:32:57.500+0900 D/test-log( 2870): mainmenu-box-impl.cpp: UpdateBoxData(812) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.example/shared/res/1.jpg], New icon path[/opt/usr/apps/org.example.example/shared/res/1.jpg]!!!!!
05-31 17:32:57.500+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 1, appId = $appId, name = $name, col = 4, row = 4, isPreload = 0, isSystem = 0 WHERE boxId = 17]
05-31 17:32:57.700+0900 D/rpm-installer(12295): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
05-31 17:32:57.700+0900 D/rpm-installer(12295): rpm-appcore-intf.c: main(259) > ------------------------------------------------
05-31 17:32:57.700+0900 D/rpm-installer(12295): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
05-31 17:32:57.700+0900 D/rpm-installer(12295): rpm-appcore-intf.c: main(261) > ------------------------------------------------
05-31 17:32:57.700+0900 D/PKGMGR_SERVER(12206): pkgmgr-server.c: sighandler(387) > child exit [12295]
05-31 17:32:57.700+0900 E/PKGMGR_SERVER(12206): pkgmgr-server.c: sighandler(402) > child NORMAL exit [12295]
05-31 17:32:58.000+0900 E/PKGMGR_SERVER(12206): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
05-31 17:32:58.000+0900 E/PKGMGR_SERVER(12206): pkgmgr-server.c: main(2265) > package manager server terminated.
05-31 17:32:58.260+0900 D/AUL_AMD ( 2765): amd_request.c: __request_handler(838) > __request_handler: 0
05-31 17:32:58.260+0900 D/AUL_AMD ( 2765): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
05-31 17:32:58.260+0900 D/PKGMGR_INFO( 2765): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
05-31 17:32:58.260+0900 D/PKGMGR_INFO( 2765): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
05-31 17:32:58.260+0900 I/AUL     ( 2765): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
05-31 17:32:58.260+0900 D/AUL     ( 2765): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 12346, pid = 12348
05-31 17:32:58.260+0900 D/PKGMGR_INFO( 2765): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
05-31 17:32:58.260+0900 D/PKGMGR_INFO( 2765): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
05-31 17:32:58.280+0900 I/AUL     ( 2765): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
05-31 17:32:58.280+0900 E/AUL_AMD ( 2765): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
05-31 17:32:58.280+0900 W/AUL_AMD ( 2765): amd_launch.c: _start_app(2233) > caller pid : 12348
05-31 17:32:58.280+0900 E/AUL_AMD ( 2765): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
05-31 17:32:58.280+0900 W/AUL_AMD ( 2765): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
05-31 17:32:58.280+0900 D/AUL_AMD ( 2765): amd_launch.c: _start_app(2648) > process_pool: false
05-31 17:32:58.280+0900 D/AUL_AMD ( 2765): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
05-31 17:32:58.280+0900 D/AUL_AMD ( 2765): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
05-31 17:32:58.280+0900 W/AUL_AMD ( 2765): amd_launch.c: _start_app(2665) > pad pid(-5)
05-31 17:32:58.280+0900 D/AUL_AMD ( 2765): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
05-31 17:32:58.280+0900 D/AUL_AMD ( 2765): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
05-31 17:32:58.280+0900 D/AUL     ( 2765): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
05-31 17:32:58.280+0900 D/AUL_PAD ( 2922): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
05-31 17:32:58.280+0900 D/AUL_PAD ( 2922): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
05-31 17:32:58.280+0900 D/AUL_PAD ( 2922): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-31 17:32:58.280+0900 D/AUL_PAD ( 2922): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-31 17:32:58.280+0900 D/AUL_PAD ( 2922): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-31 17:32:58.280+0900 D/AUL_PAD ( 2922): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-31 17:32:58.280+0900 D/AUL_PAD ( 2922): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-31 17:32:58.280+0900 D/AUL_PAD ( 2922): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
05-31 17:32:58.280+0900 D/AUL_PAD ( 2922): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
05-31 17:32:58.280+0900 D/AUL_PAD ( 2922): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
05-31 17:32:58.280+0900 D/AUL_PAD ( 2922): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
05-31 17:32:58.280+0900 D/AUL_PAD ( 2922): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
05-31 17:32:58.280+0900 D/AUL_PAD ( 2922): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
05-31 17:32:58.280+0900 D/AUL_PAD ( 2922): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
05-31 17:32:58.280+0900 W/AUL_PAD ( 2922): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
05-31 17:32:58.280+0900 D/AUL     ( 2922): process_pool.c: __send_pkt_raw_data(219) > send(11) : 624 / 624
05-31 17:32:58.280+0900 D/AUL_PAD ( 2922): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 12127, bin path: /opt/usr/apps/org.example.example/bin/example
05-31 17:32:58.280+0900 W/AUL_PAD ( 2922): launchpad.c: __send_result_to_caller(265) > Check app launching
05-31 17:32:58.280+0900 D/AUL_PAD ( 2922): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
05-31 17:32:58.280+0900 D/RESOURCED( 2857): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
05-31 17:32:58.280+0900 D/RESOURCED( 2857): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 3
05-31 17:32:58.280+0900 E/RESOURCED( 2857): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
05-31 17:32:58.280+0900 D/AUL_PAD (12127): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
05-31 17:32:58.280+0900 D/AUL_PAD (12127): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
05-31 17:32:58.280+0900 D/AUL_PAD (12127): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
05-31 17:32:58.280+0900 D/AUL_PAD (12127): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
05-31 17:32:58.280+0900 D/AUL_PAD (12127): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
05-31 17:32:58.280+0900 D/AUL_PAD (12127): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
05-31 17:32:58.280+0900 D/AUL     (12127): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (12128) is sent.
05-31 17:32:58.280+0900 D/AUL     (12127): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 12128, signo: 10
05-31 17:32:58.290+0900 D/AUL     (12127): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
05-31 17:32:58.290+0900 D/AUL_PAD (12127): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
05-31 17:32:58.290+0900 D/AUL_PAD (12127): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
05-31 17:32:58.290+0900 D/AUL_PAD (12127): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
05-31 17:32:58.290+0900 D/AUL_PAD (12127): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
05-31 17:32:58.290+0900 D/AUL_PAD (12127): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTYyMTk1NzgvMjczOTQ5AA==##
05-31 17:32:58.290+0900 D/AUL_PAD (12127): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
05-31 17:32:58.290+0900 D/AUL_PAD (12127): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAxMjM0OAA=##
05-31 17:32:58.290+0900 D/AUL_PAD (12127): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
05-31 17:32:58.290+0900 D/AUL_PAD (12127): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
05-31 17:32:58.290+0900 D/AUL_PAD (12127): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
05-31 17:32:58.290+0900 D/AUL_PAD (12127): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
05-31 17:32:58.290+0900 D/AUL_PAD (12127): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
05-31 17:32:58.290+0900 I/CAPI_APPFW_APPLICATION(12127): app_main.c: ui_app_main(788) > app_efl_main
05-31 17:32:58.290+0900 D/LAUNCH  (12127): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
05-31 17:32:58.290+0900 D/APP_CORE(12127): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
05-31 17:32:58.290+0900 D/APP_CORE(12127): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
05-31 17:32:58.290+0900 D/APP_CORE(12127): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
05-31 17:32:58.320+0900 D/APP_CORE(12127): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
05-31 17:32:58.320+0900 D/AUL     (12127): app_sock.c: __create_server_sock(156) > pg path - already exists
05-31 17:32:58.320+0900 D/APP_CORE(12127): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42c5520
05-31 17:32:58.320+0900 D/LAUNCH  (12127): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
05-31 17:32:58.320+0900 I/CAPI_APPFW_APPLICATION(12127): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
05-31 17:32:58.380+0900 D/AUL_PAD ( 2922): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
05-31 17:32:58.380+0900 W/AUL     ( 2765): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 12127, appid: org.example.example
05-31 17:32:58.380+0900 D/AUL     ( 2765): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
05-31 17:32:58.380+0900 E/AUL     ( 2765): simple_util.c: __trm_app_info_send_socket(330) > access
05-31 17:32:58.380+0900 D/AUL_AMD ( 2765): amd_launch.c: _start_app(2700) > add app group info
05-31 17:32:58.380+0900 E/AUL     ( 2765): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
05-31 17:32:58.380+0900 D/AUL_AMD ( 2765): amd_status.c: _status_add_app_info_list(427) > pid(12127) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
05-31 17:32:58.390+0900 D/RESOURCED( 2857): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 12127
05-31 17:32:58.390+0900 D/RESOURCED( 2857): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
05-31 17:32:58.390+0900 E/RESOURCED( 2857): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
05-31 17:32:58.390+0900 D/RESOURCED( 2857): proc-main.c: resourced_proc_status_change(888) > available memory = 317
05-31 17:32:58.410+0900 D/LAUNCH  (12127): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
05-31 17:32:58.410+0900 D/APP_CORE(12127): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
05-31 17:32:58.430+0900 E/E17     ( 2735): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x01200002)
05-31 17:32:58.470+0900 E/E17     ( 2735): e_border.c: e_border_show(2088) > BD_SHOW(0x01200002)
05-31 17:32:58.480+0900 D/APP_CORE(12127): appcore.c: __aul_handler(587) > [APP 12127]     AUL event: AUL_START
05-31 17:32:58.480+0900 I/APP_CORE(12127): appcore-efl.c: __do_app(496) > [APP 12127] Event: RESET State: CREATED
05-31 17:32:58.480+0900 D/APP_CORE(12127): appcore-efl.c: __do_app(527) > [APP 12127] RESET
05-31 17:32:58.480+0900 D/LAUNCH  (12127): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
05-31 17:32:58.480+0900 D/APP_CORE(12127): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
05-31 17:32:58.480+0900 D/APP_CORE(12127): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-31 17:32:58.480+0900 I/CAPI_APPFW_APPLICATION(12127): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
05-31 17:32:58.480+0900 D/AUL     (12127): service.c: __set_bundle(186) > __set_bundle
05-31 17:32:58.480+0900 D/LAUNCH  (12127): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
05-31 17:32:58.480+0900 D/APP_CORE(12127): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
05-31 17:32:58.480+0900 E/EFL     (12127): edje<12127> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-31 17:32:58.480+0900 E/EFL     (12127): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 17:32:58.480+0900 E/EFL     (12127): edje<12127> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-31 17:32:58.480+0900 E/EFL     (12127): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 17:32:58.480+0900 E/EFL     (12127): edje<12127> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-31 17:32:58.480+0900 E/EFL     (12127): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 17:32:58.480+0900 E/EFL     (12127): edje<12127> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-31 17:32:58.480+0900 E/EFL     (12127): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 17:32:58.480+0900 E/EFL     (12127): edje<12127> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-31 17:32:58.480+0900 E/EFL     (12127): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 17:32:58.490+0900 W/PROCESSMGR( 2735): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=12127
05-31 17:32:58.510+0900 E/EFL     ( 2735): eo<2735> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-31 17:32:58.510+0900 E/EFL     ( 2735): eo<2735> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-31 17:32:58.510+0900 W/APP_CORE(12127): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1200002
05-31 17:32:58.510+0900 D/APP_CORE(12127): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:1200002
05-31 17:32:58.510+0900 D/APP_CORE(12127): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
05-31 17:32:58.510+0900 D/AUL     (12127): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
05-31 17:32:58.510+0900 D/AUL_AMD ( 2765): amd_request.c: __request_handler(838) > __request_handler: 34
05-31 17:32:58.520+0900 D/AUL_AMD ( 2765): amd_request.c: __request_handler(838) > __request_handler: 15
05-31 17:32:58.520+0900 D/PKGMGR_INFO( 2765): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-31 17:32:58.520+0900 D/PKGMGR_INFO( 2765): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-31 17:32:58.520+0900 D/AUL_AMD ( 2765): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 12127 is org.example.example
05-31 17:32:58.520+0900 D/AUL_AMD ( 2765): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 12127 : 0
05-31 17:32:58.540+0900 D/AUL     ( 2938): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
05-31 17:32:58.540+0900 D/INDICATOR( 2861): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
05-31 17:32:58.540+0900 D/INDICATOR( 2861): util.c: util_signal_emit_by_win(116) > emission bg.opaque
05-31 17:32:58.540+0900 D/INDICATOR( 2861): main.c: _rotate_window(229) > Indicator angle is 0 degree
05-31 17:32:58.540+0900 D/INDICATOR( 2861): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
05-31 17:32:58.540+0900 D/INDICATOR( 2861): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
05-31 17:32:58.540+0900 D/INDICATOR( 2861): main.c: _rotate_window(252) > port :: hide more icon
05-31 17:32:58.790+0900 D/APP_CORE(12127): appcore.c: __prt_ltime(236) > [APP 12127] first idle after reset: 525 msec
05-31 17:32:58.920+0900 E/E17     ( 2735): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
05-31 17:32:58.920+0900 D/APP_CORE( 2870): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
05-31 17:32:58.920+0900 D/APP_CORE( 2870): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
05-31 17:32:58.920+0900 D/APP_CORE( 2870): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
05-31 17:32:58.920+0900 I/APP_CORE( 2870): appcore-efl.c: __do_app(496) > [APP 2870] Event: PAUSE State: RUNNING
05-31 17:32:58.920+0900 D/APP_CORE( 2870): appcore-efl.c: __do_app(565) > [APP 2870] PAUSE
05-31 17:32:58.920+0900 I/CAPI_APPFW_APPLICATION( 2870): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
05-31 17:32:58.920+0900 E/cluster-home( 2870): homescreen.cpp: OnPause(84) >  app pause
05-31 17:32:58.920+0900 D/cluster-view( 2870): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
05-31 17:32:58.920+0900 D/cluster-view( 2870): homescreen-view-manager.cpp: AppPause(923) >  END
05-31 17:32:58.920+0900 D/APP_CORE( 2870): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-31 17:32:58.920+0900 E/APP_CORE( 2870): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-31 17:32:58.930+0900 D/AUL_AMD ( 2765): amd_status.c: _status_update_app_info_list(456) > pid(2870) status(4)
05-31 17:32:58.930+0900 D/AUL_AMD ( 2765): amd_status.c: _status_update_app_info_list(468) > pid(2870) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
05-31 17:32:58.930+0900 D/AUL     ( 2765): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
05-31 17:32:58.930+0900 W/AUL     ( 2765): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2870, appid: org.tizen.homescreen, status: bg
05-31 17:32:58.940+0900 D/DATA_PROVIDER_MASTER( 2929): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2870 is paused
05-31 17:32:58.940+0900 D/DATA_PROVIDER_MASTER( 2929): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
05-31 17:32:58.940+0900 D/AUL_AMD ( 2765): amd_launch.c: __e17_status_handler(2891) > pid(12127) status(3)
05-31 17:32:58.940+0900 D/AUL_AMD ( 2765): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
05-31 17:32:58.940+0900 I/CAPI_WIDGET_APPLICATION( 3020): widget_app.c: __provider_pause_cb(294) > widget obj was paused
05-31 17:32:58.940+0900 I/CAPI_WIDGET_APPLICATION( 3020): widget_app.c: __check_status_for_cgroup(142) > enter background group
05-31 17:32:58.940+0900 W/AUL     ( 3020): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3020, appid: org.tizen.calendar.widget, status: bg
05-31 17:32:58.940+0900 D/RESOURCED( 2857): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3020, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
05-31 17:32:58.940+0900 D/RESOURCED( 2857): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3020
05-31 17:32:58.940+0900 D/RESOURCED( 2857): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3020, appname = org.tizen.calendar.widget
05-31 17:32:58.940+0900 D/RESOURCED( 2857): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3020
05-31 17:32:58.950+0900 D/APP_CORE(12127): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1200002 fully_obscured 0
05-31 17:32:58.950+0900 D/APP_CORE(12127): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
05-31 17:32:58.950+0900 D/APP_CORE(12127): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
05-31 17:32:58.950+0900 I/APP_CORE(12127): appcore-efl.c: __do_app(496) > [APP 12127] Event: RESUME State: CREATED
05-31 17:32:58.950+0900 D/LAUNCH  (12127): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
05-31 17:32:58.950+0900 D/APP_CORE(12127): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
05-31 17:32:58.950+0900 D/APP_CORE(12127): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-31 17:32:58.950+0900 D/APP_CORE(12127): appcore-efl.c: __do_app(607) > [APP 12127] RESUME
05-31 17:32:58.960+0900 W/AUL_AMD ( 2765): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-31 17:32:58.960+0900 W/AUL_AMD ( 2765): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
05-31 17:32:58.960+0900 D/AUL_AMD ( 2765): amd_status.c: _status_update_app_info_list(456) > pid(12127) status(3)
05-31 17:32:58.960+0900 D/AUL_AMD ( 2765): amd_status.c: _status_update_app_info_list(468) > pid(12127) appid(org.example.example) pkgid(org.example.example) status(3)
05-31 17:32:58.960+0900 D/AUL     ( 2765): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
05-31 17:32:58.960+0900 W/AUL     ( 2765): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 12127, appid: org.example.example, status: fg
05-31 17:32:58.960+0900 I/APP_CORE(12127): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
05-31 17:32:58.960+0900 I/APP_CORE(12127): appcore-efl.c: __do_app(614) > [APP 12127] Initial Launching, call the resume_cb
05-31 17:32:58.960+0900 I/CAPI_APPFW_APPLICATION(12127): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
05-31 17:32:58.960+0900 D/LAUNCH  (12127): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
05-31 17:32:58.960+0900 D/LAUNCH  (12127): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
05-31 17:32:58.960+0900 D/APP_CORE(12127): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-31 17:32:58.960+0900 E/APP_CORE(12127): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-31 17:32:58.980+0900 D/RESOURCED( 2857): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 12127
05-31 17:32:58.980+0900 D/RESOURCED( 2857): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 12127, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
05-31 17:32:58.980+0900 D/RESOURCED( 2857): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 12127
05-31 17:32:59.070+0900 D/AUL_AMD ( 2765): amd_launch.c: __e17_status_handler(2910) > pid(12127) status(0)
05-31 17:32:59.070+0900 D/RESOURCED( 2857): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 12127, appname = org.example.example, pkgname = org.example.example
05-31 17:32:59.070+0900 D/RESOURCED( 2857): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 12127, appname = org.example.example
05-31 17:32:59.070+0900 D/RESOURCED( 2857): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 12127
05-31 17:32:59.070+0900 I/RESOURCED( 2857): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
05-31 17:32:59.070+0900 I/RESOURCED( 2857): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
05-31 17:32:59.400+0900 D/AUL_PAD ( 2922): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
05-31 17:32:59.410+0900 D/AUL_PAD (12355): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
05-31 17:32:59.430+0900 D/AUL_PAD ( 2922): sigchild.h: __send_app_launch_signal(131) > send launch signal done
05-31 17:32:59.460+0900 E/RESOURCED( 2857): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.795
05-31 17:32:59.670+0900 D/PROCESSMGR( 2735): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x401da4 
05-31 17:32:59.890+0900 D/AUL_AMD ( 2765): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
05-31 17:32:59.890+0900 D/RUA     ( 2765): rua.c: rua_add_history(179) > rua_add_history start
05-31 17:32:59.920+0900 D/RUA     ( 2765): rua.c: rua_add_history(247) > rua_add_history ok
05-31 17:33:00.380+0900 D/PROCESSMGR( 2735): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x401da4 
05-31 17:33:00.480+0900 D/AUL_PAD (12355): launchpad_loader.c: main(588) > sleeping 1 sec...
05-31 17:33:00.480+0900 D/AUL_PAD (12355): preload.h: __preload_init(52) > max_cmdline_size = 1053
05-31 17:33:00.490+0900 D/AUL_PAD (12355): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b8061760
05-31 17:33:00.490+0900 D/AUL_PAD (12355): preload.h: __preload_init(69) > get pre-initialization function
05-31 17:33:00.490+0900 D/AUL_PAD (12355): preload.h: __preload_init(73) > get shutdown function
05-31 17:33:00.490+0900 D/AUL_PAD (12355): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b8061a40
05-31 17:33:00.490+0900 D/AUL_PAD (12355): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b8063640
05-31 17:33:00.490+0900 D/AUL_PAD (12355): preload.h: __preload_init(69) > get pre-initialization function
05-31 17:33:00.490+0900 D/AUL_PAD (12355): preload.h: __preload_init(73) > get shutdown function
05-31 17:33:00.490+0900 D/AUL_PAD (12355): preexec.h: __preexec_init(76) > preexec start
05-31 17:33:00.490+0900 D/AUL_PAD (12355): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
05-31 17:33:00.490+0900 D/AUL     (12355): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
05-31 17:33:00.490+0900 D/AUL     (12355): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
05-31 17:33:00.490+0900 D/AUL     (12355): process_pool.c: __connect_to_launchpad(132) > send(12355) : 4
05-31 17:33:00.490+0900 D/AUL     (12355): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
05-31 17:33:00.490+0900 D/AUL_PAD ( 2922): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-31 17:33:00.490+0900 D/AUL_PAD ( 2922): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
05-31 17:33:00.490+0900 D/AUL_PAD ( 2922): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-31 17:33:00.490+0900 D/AUL_PAD ( 2922): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-31 17:33:00.490+0900 D/AUL_PAD ( 2922): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-31 17:33:00.490+0900 D/AUL_PAD ( 2922): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-31 17:33:00.490+0900 D/AUL_PAD ( 2922): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-31 17:33:00.490+0900 D/AUL_PAD ( 2922): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
05-31 17:33:00.490+0900 D/AUL_PAD ( 2922): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 12355
05-31 17:33:00.620+0900 E/EFL     (12127): edje<12127> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 17:33:00.630+0900 E/EFL     (12127): edje<12127> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 17:33:00.690+0900 E/EFL     (12127): edje<12127> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 17:33:00.700+0900 E/EFL     (12127): edje<12127> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 17:33:00.700+0900 E/EFL     (12127): edje<12127> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 17:33:00.700+0900 E/EFL     (12127): edje<12127> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 17:33:00.700+0900 E/EFL     (12127): edje<12127> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 17:33:00.700+0900 D/INDICATOR( 2861): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
05-31 17:33:00.700+0900 E/EFL     (12127): edje<12127> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 17:33:00.700+0900 D/INDICATOR( 2861): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
05-31 17:33:00.700+0900 D/INDICATOR( 2861): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
05-31 17:33:00.700+0900 D/INDICATOR( 2861): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 5:33 4 h"
05-31 17:33:00.700+0900 D/INDICATOR( 2861): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 5:33"
05-31 17:33:00.700+0900 D/INDICATOR( 2861): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 5&#x2236;33"
05-31 17:33:00.700+0900 D/INDICATOR( 2861): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146729020 Time: <font_size=33>5&#x2236;33</font_size> <font_size=32>PM</font_size></font>
05-31 17:33:00.700+0900 E/EFL     (12127): edje<12127> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 17:33:00.710+0900 D/IMMODULE(12127): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
05-31 17:33:00.710+0900 D/AUL_PAD (12355): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
05-31 17:33:00.710+0900 D/ISF_SOCKET(12127): scim_socket.cpp: connect(515) > ppid:2922  trying connect() to local:/tmp/scim-socket-frontend, example
05-31 17:33:00.710+0900 D/ISF_SOCKET(12127): scim_socket.cpp: connect(524) > connect() succeeded
05-31 17:33:00.720+0900 D/ISF_SOCKET(12127): scim_socket.cpp: connect(515) > ppid:2922  trying connect() to local:/tmp/scim-socket-frontend, example
05-31 17:33:00.720+0900 D/AUL_PAD (12355): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
05-31 17:33:00.720+0900 D/AUL_PAD (12355): launchpad_loader.c: main(693) > [candidate] ecore handler add
05-31 17:33:00.720+0900 D/ISF_SOCKET(12127): scim_socket.cpp: connect(524) > connect() succeeded
05-31 17:33:00.730+0900 D/AUL_PAD (12355): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
05-31 17:33:00.780+0900 D/ISF_SOCKET(12127): scim_socket.cpp: connect(515) > ppid:2922  trying connect() to local:/tmp/scim-socket-frontend, example
05-31 17:33:00.780+0900 D/ISF_SOCKET(12127): scim_socket.cpp: connect(524) > connect() succeeded
05-31 17:33:00.780+0900 D/ISF_QUERY(12127): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
05-31 17:33:00.800+0900 D/ISF_QUERY(12127): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-31 17:33:00.800+0900 D/ISF_QUERY(12127): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-31 17:33:00.800+0900 D/ISF_QUERY(12127): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-31 17:33:00.800+0900 D/ISF_QUERY(12127): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-31 17:33:00.800+0900 D/ISF_QUERY(12127): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-31 17:33:00.800+0900 D/ISF_QUERY(12127): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-31 17:33:00.810+0900 D/ISF_SOCKET(12127): scim_socket.cpp: connect(515) > ppid:2922  trying connect() to local:/tmp/scim-socket-frontend, example
05-31 17:33:00.810+0900 D/ISF_SOCKET(12127): scim_socket.cpp: connect(524) > connect() succeeded
05-31 17:33:00.810+0900 D/IMMODULE(12127): scim_panel_client.cpp: open_connection(162) > 
05-31 17:33:00.810+0900 D/ISF_SOCKET(12127): scim_socket.cpp: connect(515) > ppid:2922  trying connect() to local:/tmp/scim-panel-socket:0, example
05-31 17:33:00.810+0900 D/ISF_SOCKET(12127): scim_socket.cpp: connect(524) > connect() succeeded
05-31 17:33:00.820+0900 D/ISF_SOCKET(12127): scim_socket.cpp: connect(515) > ppid:2922  trying connect() to local:/tmp/scim-panel-socket:0, example
05-31 17:33:00.820+0900 D/ISF_SOCKET(12127): scim_socket.cpp: connect(524) > connect() succeeded
05-31 17:33:00.840+0900 D/IMMODULE(12127): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 1
05-31 17:33:01.380+0900 D/PROCESSMGR( 2735): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1200002
05-31 17:33:01.900+0900 D/PROCESSMGR( 2735): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x401da4 
05-31 17:33:02.000+0900 E/EFL     (12127): edje<12127> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
05-31 17:33:02.000+0900 E/EFL     (12127): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 17:33:03.260+0900 D/PROCESSMGR( 2735): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x401da4 
05-31 17:33:03.930+0900 D/APP_CORE( 2870): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
05-31 17:33:03.930+0900 I/APP_CORE( 2870): appcore-efl.c: __do_app(496) > [APP 2870] Event: MEM_FLUSH State: PAUSED
05-31 17:33:03.930+0900 D/APP_CORE( 2870): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
05-31 17:33:03.930+0900 D/RESOURCED( 2857): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2870
05-31 17:33:03.930+0900 D/APP_CORE( 2870): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2870
05-31 17:33:03.930+0900 D/APP_CORE( 2870): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
05-31 17:33:04.110+0900 D/PROCESSMGR( 2735): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x401da4 
05-31 17:33:05.160+0900 D/PROCESSMGR( 2735): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x401da4 
05-31 17:33:05.270+0900 E/EFL     (12127): edje<12127> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
05-31 17:33:05.270+0900 E/EFL     (12127): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 17:33:05.730+0900 D/AUL_PAD ( 2922): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-31 17:33:05.730+0900 D/AUL_PAD ( 2922): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
05-31 17:33:05.730+0900 D/AUL_PAD ( 2922): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-31 17:33:05.730+0900 D/AUL_PAD ( 2922): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-31 17:33:05.730+0900 D/AUL_PAD ( 2922): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-31 17:33:05.730+0900 D/AUL_PAD ( 2922): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-31 17:33:05.730+0900 D/AUL_PAD ( 2922): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-31 17:33:05.730+0900 I/AUL_PAD ( 2922): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 12127 pgid = 12127
05-31 17:33:05.730+0900 I/AUL_PAD ( 2922): sigchild.h: __sigchild_action(142) > dead_pid(12127)
05-31 17:33:05.730+0900 W/CRASH_MANAGER(12358): worker.c: worker_job(1204) > 1112127657861149621958
