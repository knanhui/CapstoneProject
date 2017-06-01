S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 6954
Date: 2017-06-01 00:31:37+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x20

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000020, esi = 0xb37e0c81
ebp = 0xbf929188, esp = 0xbf929120
eax = 0xb7f40d70, ebx = 0xb6bd60d4
ecx = 0xb7f40d70, edx = 0x00000020
eip = 0xb6bb41f6

Memory Information
MemTotal:      123 KB
MemFree:        31 KB
Buffers:         4 KB
Cached:     167072 KB
VmPeak:      81152 KB
VmSize:      81152 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16220 KB
VmRSS:       16220 KB
VmData:      20064 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34460 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 6954 TID = 6954
6954 6972 7225 

Maps Information
b2ba0000 b2baa000 r-xp /usr/lib/libfeedback.so.0.1.4
b2bb0000 b2bbc000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2bbd000 b2bde000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2be3000 b2be4000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2be5000 b2bea000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2beb000 b2bec000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2bed000 b2bef000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2bf0000 b2bfc000 r-xp /usr/lib/libdrm.so.2.4.0
b2bfd000 b2c00000 r-xp /usr/lib/libdri2.so.0.0.0
b2c01000 b2c0b000 r-xp /usr/lib/libtbm.so.1.0.0
b2c0c000 b2c21000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c22000 b2c34000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3436000 b3467000 r-xp /usr/lib/libidn.so.11.5.44
b3468000 b348a000 r-xp /usr/lib/libnghttp2.so.5.4.0
b348b000 b349b000 r-xp /usr/lib/libcares.so.2.1.0
b349c000 b34a5000 r-xp /usr/lib/libeventsystem.so.0.0.1
b34a6000 b34af000 r-xp /usr/lib/libefl-extension.so.0.1.0
b34b0000 b3527000 r-xp /usr/lib/libcurl.so.4.3.0
b3529000 b353b000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b353c000 b355d000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b3564000 b3565000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3566000 b3567000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3568000 b356b000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b356c000 b356f000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3677000 b367d000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b367e000 b37c2000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37d2000 b37d4000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b37d5000 b37d6000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37d7000 b37e2000 r-xp /opt/usr/apps/org.example.example/bin/example
b37e4000 b381d000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4220000 b422b000 r-xp /lib/libnss_files-2.20-2014.11.so
b422d000 b4238000 r-xp /lib/libnss_nis-2.20-2014.11.so
b423a000 b4251000 r-xp /lib/libnsl-2.20-2014.11.so
b4255000 b425d000 r-xp /lib/libnss_compat-2.20-2014.11.so
b425f000 b4283000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4284000 b4285000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4286000 b4289000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b428a000 b4291000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4292000 b429c000 r-xp /usr/lib/libsensord-share.so
b429d000 b42b9000 r-xp /usr/lib/libsensor.so.1.2.0
b42bb000 b42c4000 r-xp /usr/lib/libappcore-common.so.1.1
b42c7000 b42c9000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42de000 b42e0000 r-xp /usr/lib/libXau.so.6.0.0
b42e1000 b4303000 r-xp /usr/lib/libxcb.so.1.1.0
b4305000 b430e000 r-xp /lib/libcrypt-2.20-2014.11.so
b4337000 b4339000 r-xp /usr/lib/libiri.so
b433a000 b4360000 r-xp /lib/libexpat.so.1.5.2
b4362000 b43cd000 r-xp /usr/lib/libssl.so.1.0.0
b43d3000 b43df000 r-xp /usr/lib/libethumb.so.1.13.0
b43e0000 b43e4000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43e5000 b4636000 r-xp /usr/lib/libcrypto.so.1.0.0
b5bb1000 b5bc1000 r-xp /usr/lib/libXi.so.6.1.0
b5bc2000 b5bc4000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bc5000 b5bcb000 r-xp /usr/lib/libXtst.so.6.1.0
b5bcc000 b5bd6000 r-xp /usr/lib/libXrender.so.1.3.0
b5bd7000 b5be0000 r-xp /usr/lib/libXrandr.so.2.2.0
b5be2000 b5be4000 r-xp /usr/lib/libXinerama.so.1.0.0
b5be5000 b5bea000 r-xp /usr/lib/libXfixes.so.3.1.0
b5beb000 b5bfd000 r-xp /usr/lib/libXext.so.6.4.0
b5bfe000 b5c00000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c01000 b5c03000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c05000 b5d47000 r-xp /usr/lib/libX11.so.6.3.0
b5d4b000 b5d55000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d56000 b5d6c000 r-xp /usr/lib/libudev.so.1.6.0
b5d6f000 b5d73000 r-xp /lib/libattr.so.1.1.0
b5d74000 b5da3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5da5000 b5dab000 r-xp /usr/lib/libffi.so.6.0.2
b5dac000 b5dcf000 r-xp /lib/libz.so.1.2.8
b5dd0000 b5dd3000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5dd4000 b5f30000 r-xp /usr/lib/libxml2.so.2.9.2
b5f36000 b601d000 r-xp /usr/lib/libstdc++.so.6.0.20
b602a000 b602d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b602e000 b6050000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6051000 b6065000 r-xp /lib/libresolv-2.20-2014.11.so
b6069000 b608d000 r-xp /usr/lib/liblzma.so.5.0.3
b608e000 b6090000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6092000 b609c000 r-xp /usr/lib/libembryo.so.1.13.0
b609d000 b60c6000 r-xp /usr/lib/libpng12.so.0.50.0
b60c7000 b6110000 r-xp /usr/lib/libjpeg.so.8.0.2
b6121000 b6128000 r-xp /lib/librt-2.20-2014.11.so
b612a000 b6149000 r-xp /usr/lib/libector.so.1.13.0
b614c000 b6179000 r-xp /usr/lib/liblua-5.1.so
b617a000 b620a000 r-xp /usr/lib/libfreetype.so.6.11.3
b620e000 b624c000 r-xp /usr/lib/libfontconfig.so.1.8.0
b624d000 b6263000 r-xp /usr/lib/libfribidi.so.0.3.1
b6264000 b62bd000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62c0000 b630b000 r-xp /lib/libm-2.20-2014.11.so
b630d000 b631f000 r-xp /usr/lib/libeio.so.1.13.0
b6320000 b6323000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6324000 b632a000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b632b000 b634e000 r-xp /usr/lib/libefreet.so.1.13.0
b6351000 b637c000 r-xp /usr/lib/libeldbus.so.1.13.0
b637d000 b63b1000 r-xp /usr/lib/libecore_con.so.1.13.0
b63b3000 b63bc000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63bd000 b63c6000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63c7000 b63da000 r-xp /usr/lib/libeo.so.1.13.0
b63dc000 b63ef000 r-xp /usr/lib/libecore_input.so.1.13.0
b63f0000 b63f7000 r-xp /usr/lib/libecore_file.so.1.13.0
b63f8000 b641b000 r-xp /usr/lib/libecore_evas.so.1.13.0
b641c000 b6448000 r-xp /usr/lib/libeet.so.1.13.0
b6451000 b64bc000 r-xp /usr/lib/libeina.so.1.13.0
b64bf000 b64d6000 r-xp /usr/lib/libefl.so.1.13.0
b64d8000 b663f000 r-xp /usr/lib/libicuuc.so.51.1
b664d000 b6859000 r-xp /usr/lib/libicui18n.so.51.1
b6861000 b68b0000 r-xp /usr/lib/libecore_x.so.1.13.0
b68b2000 b68cc000 r-xp /lib/libgcc_s-4.9.so.1
b68ce000 b68d2000 r-xp /lib/libcap.so.2.21
b68d3000 b6919000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b691a000 b6921000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6923000 b6975000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6977000 b6b02000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b07000 b6bd5000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bd8000 b6bdc000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bdd000 b6bec000 r-xp /usr/lib/libvconf.so.0.2.45
b6bed000 b6bf0000 r-xp /usr/lib/libvasum.so.0.3.1
b6bf1000 b6bf4000 r-xp /usr/lib/libttrace.so.1.1
b6bf6000 b6bfa000 r-xp /usr/lib/libiniparser.so.0
b6bfb000 b6c2b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c2c000 b6c35000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c36000 b6c5b000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c5c000 b6c6c000 r-xp /usr/lib/libunwind.so.8.0.1
b6c76000 b6e24000 r-xp /lib/libc-2.20-2014.11.so
b6e2c000 b6f6f000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f71000 b6fc9000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fca000 b6ffe000 r-xp /usr/lib/libsystemd.so.0.4.0
b7001000 b70d5000 r-xp /usr/lib/libedje.so.1.13.0
b70d8000 b7104000 r-xp /usr/lib/libecore.so.1.13.0
b7115000 b733b000 r-xp /usr/lib/libevas.so.1.13.0
b7363000 b737b000 r-xp /lib/libpthread-2.20-2014.11.so
b737f000 b76f9000 r-xp /usr/lib/libelementary.so.1.13.0
b7719000 b771d000 r-xp /usr/lib/libsmack.so.1.0.0
b771e000 b7727000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7728000 b772b000 r-xp /usr/lib/libdlog.so.0.0.0
b772c000 b7731000 r-xp /usr/lib/libbundle.so.0.1.22
b7732000 b7735000 r-xp /lib/libdl-2.20-2014.11.so
b7737000 b775c000 r-xp /usr/lib/libaul.so.0.1.0
b775f000 b7761000 r-xp /usr/lib/libappsvc.so.0.1.0
b7762000 b7767000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7768000 b776f000 r-xp /usr/lib/libappcore-efl.so.1.1
b7771000 b7776000 r-xp /usr/lib/libsys-assert.so
b7779000 b777a000 r-xp [vdso]
b777a000 b779c000 r-xp /lib/ld-2.20-2014.11.so
b779e000 b77a6000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:6954)
Call Stack Count: 10
 0: (0xb6bb41f6) [/usr/lib/libsqlite3.so.0] + 0xad1f6
 1: init_db + 0x13f (0xb37df8df) [/opt/usr/apps/org.example.example/bin/example] + 0x88df
 2: create_base_gui + 0xbfd (0xb37df6ed) [/opt/usr/apps/org.example.example/bin/example] + 0x86ed
 3: app_create + 0x2c (0xb37de95c) [/opt/usr/apps/org.example.example/bin/example] + 0x795c
 4: (0xb776465b) [/usr/lib/libcapi-appfw-application.so.0] + 0x265b
 5: appcore_efl_main + 0x327 (0xb776bc27) [/usr/lib/libappcore-efl.so.1] + 0x3c27
 6: ui_app_main + 0x140 (0xb7764c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
 7: main + 0x2a5 (0xb37de8d5) [/opt/usr/apps/org.example.example/bin/example] + 0x78d5
 8: (0xb77a0148) [/opt/usr/apps/org.example.example/bin/example] + 0xb77a0148
 9: __libc_start_main + 0xde (0xb6c8de4e) [/lib/libc.so.6] + 0x17e4e
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
s that pkgname is[org.example.example]
06-01 00:31:36.004+0900 D/PKGMGR  ( 2964): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_-1651442060], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 00:31:36.004+0900 D/ESD     ( 2964): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29640002), pkg_type(tpk), pkgid(org.example.example), key(end), val(ok)
06-01 00:31:36.004+0900 D/ESD     ( 2964): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
06-01 00:31:36.004+0900 D/PKGMGR  ( 2904): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_-1651442060], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 00:31:36.004+0900 D/cluster-home( 2904): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29040003] pkg_type[tpk] package[org.example.example] key[end] val[ok] pmsg[(null)]
06-01 00:31:36.004+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
06-01 00:31:36.004+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
06-01 00:31:36.004+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
06-01 00:31:36.004+0900 D/PKGMGR  ( 2954): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_-1651442060], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 00:31:36.004+0900 D/DATA_PROVIDER_MASTER( 2954): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.example] ok
06-01 00:31:36.004+0900 D/DATA_PROVIDER_MASTER( 2954): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.example], event_type[1]
06-01 00:31:36.004+0900 D/DATA_PROVIDER_MASTER( 2954): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
06-01 00:31:36.004+0900 D/PKGMGR  ( 2966): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_-1651442060], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 00:31:36.004+0900 D/PRIVILEGE_CHECKER( 2966): privilege_checker.c: __privilege_checker_check_privilege(45) > _ENTER_
06-01 00:31:36.004+0900 E/PRIVILEGE_CHECKER( 2966): privilege_checker.c: __privilege_checker_check_privilege(78) > Please declare http://tizen.org/privilege/package.info in tizen-manifest.xml or config.xml
06-01 00:31:36.004+0900 D/PRIVILEGE_CHECKER( 2966): privilege_checker.c: __privilege_checker_check_privilege(45) > _ENTER_
06-01 00:31:36.004+0900 D/cluster-home( 2904): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
06-01 00:31:36.004+0900 D/cluster-home( 2904): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.example]
06-01 00:31:36.004+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.example]
06-01 00:31:36.004+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.example]
06-01 00:31:36.004+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
06-01 00:31:36.004+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
06-01 00:31:36.004+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.example]
06-01 00:31:36.004+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.example] Name[forpet] Icon[/opt/usr/apps/org.example.example/shared/res/1.jpg] enable[1] system[0]
06-01 00:31:36.004+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: OnAppInstalled(309) >  pAppId [org.example.example]
06-01 00:31:36.004+0900 D/cluster-home( 2904): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.example
06-01 00:31:36.004+0900 D/cluster-home( 2904): mainmenu-data-manager.cpp: GetBoxDataByAppId(1879) >  cannot find box with appid[org.example.example]
06-01 00:31:36.004+0900 D/cluster-home( 2904): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
06-01 00:31:36.004+0900 D/cluster-home( 2904): mainmenu-data-manager.cpp: InsertBoxData(552) >  current last page [1, 1] box[20] [4, 4]
06-01 00:31:36.004+0900 D/PKGMGR  ( 3109): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_-1651442060], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 00:31:36.014+0900 D/PKGMGR  ( 2773): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[install], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_-1651442060], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 00:31:36.014+0900 D/AUL_AMD ( 2773): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.example), key(end), value(ok)
06-01 00:31:36.014+0900 W/AUL_AMD ( 2773): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(install), value(ok)
06-01 00:31:36.014+0900 D/AUL_AMD ( 2773): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.example, type:rpm
06-01 00:31:36.014+0900 D/DATA_PROVIDER_MASTER( 2954): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
06-01 00:31:36.014+0900 D/DATA_PROVIDER_MASTER( 2954): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
06-01 00:31:36.014+0900 D/DATA_PROVIDER_MASTER( 2954): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.example]
06-01 00:31:36.014+0900 D/PKGMGR  ( 3035): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_-1651442060], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 00:31:36.014+0900 D/ISF_PANEL_EFL( 3035): isf_panel_efl.cpp: _package_manager_event_cb(1387) > type=tpk package=org.example.example event_type=INSTALL event_state=COMPLETED progress=100 error=0
06-01 00:31:36.024+0900 D/PKGMGR  ( 2977): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_-1651442060], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 00:31:36.024+0900 D/PKGMGR  ( 2977): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
06-01 00:31:36.024+0900 D/PKGMGR  ( 2959): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_-1651442060], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 00:31:36.024+0900 D/QUICKPANEL( 2959): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:end val:ok
06-01 00:31:36.024+0900 W/ISF_PANEL_EFL( 3035): isf_panel_efl.cpp: _package_manager_event_cb(1512) > _isf_insert_ime_info_by_pkgid returned 0.
06-01 00:31:36.044+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: OnAppInstalled(316) >  box id [25]
06-01 00:31:36.044+0900 D/cluster-home( 2904): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
06-01 00:31:36.044+0900 D/cluster-home( 2904): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
06-01 00:31:36.044+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.example] Name[forpet] Icon[/opt/usr/apps/org.example.example/shared/res/1.jpg] enable[1] system[0]
06-01 00:31:36.044+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: OnAppInstalled(323) >  name [forpet]
06-01 00:31:36.044+0900 D/test-log( 2904): mainmenu-view-manager-impl.cpp: AddMenuBox(282) >  AppInfo name [forpet] [1] [1,5, 1]
06-01 00:31:36.044+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(347) >  AddBox Name[forpet] pageid[1] pos[1, 5]
06-01 00:31:36.044+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(354) >  menuPage.GetPageId() = 100001, boxPageId = 1
06-01 00:31:36.044+0900 D/cluster-home( 2904): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 1, appId = $appId, name = $name, col = 1, row = 5, isPreload = 0, isSystem = 0 WHERE boxId = 25]
06-01 00:31:36.054+0900 D/rpm-installer( 7166): rpm-appcore-intf.c: main(238) > sync() end
06-01 00:31:36.084+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(540) >  Do reorder
06-01 00:31:36.084+0900 D/cluster-home( 2904): mainmenu-data-manager.cpp: GetPageDataListByAlphabeticalOrder(1404) >  Alphabetical order Count : Box[17] Page[1]
06-01 00:31:36.084+0900 D/cluster-home( 2904): mainmenu-data-manager.cpp: GetPageDataListByAlphabeticalOrder(1411) >  page count[1]
06-01 00:31:36.084+0900 D/cluster-home( 2904): mainmenu-data-manager.cpp: GetPageDataListByAlphabeticalOrder(1423) >  nVirtualPageId[100001] pageNo[1]
06-01 00:31:36.084+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(559) >  pageId[100001]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuPage(689) >  BEGIN nTotalPageCount[1] mAppsPages.size[1]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuPage(701) >  pageId[100001] pageNo[1]
06-01 00:31:36.084+0900 D/cluster-view( 2904): homescreen-page-indicator.cpp: Update(281) >  Unit size is same [1]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuPage(760) >  _SortingPageOrder
06-01 00:31:36.084+0900 D/test-log( 2904): mainmenu-apps-view-impl.cpp: _SortingPageOrder(1065) >  !!!!!!!!!!!![1],[100001]!!!!!!!!!!!!!!
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: SetLayoutPosition(1115) >  layoutposition [1]
06-01 00:31:36.084+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: OnPageDataNotify(226) >  Page [1]
06-01 00:31:36.084+0900 D/cluster-home( 2904): mainmenu-data-manager.cpp: UpdatePageDataForAlphaBeticalOrder(822) >  Do nothing while alphabetical order
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuPage(763) >  END
06-01 00:31:36.084+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.basicui] Name[basicui] Icon[/opt/usr/apps/org.example.basicui/shared/res/basicui.png] enable[1] system[0]
06-01 00:31:36.084+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.basicui'], count[0]
06-01 00:31:36.084+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.basicui][-17956860][0]
06-01 00:31:36.084+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.basicui]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[basicui] pos[1, 1] pageId[100001]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[20]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[1], [1, 1]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[1], [1, 1]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:31:36.084+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.calendar] Name[Calendar] Icon[/usr/share/icons/default/small/calendar.png] enable[1] system[1]
06-01 00:31:36.084+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.calendar'], count[0]
06-01 00:31:36.084+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.calendar][-17956860][0]
06-01 00:31:36.084+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.calendar]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Calendar] pos[2, 1] pageId[100001]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[2]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[2], [2, 1]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[2], [2, 1]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:31:36.084+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.camera-app] Name[Camera] Icon[/usr/share/icons/default/small/org.tizen.camera-app.png] enable[1] system[1]
06-01 00:31:36.084+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.camera-app'], count[0]
06-01 00:31:36.084+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.camera-app][-17956860][0]
06-01 00:31:36.084+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.camera-app]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Camera] pos[3, 1] pageId[100001]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[3]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[3], [3, 1]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[3], [3, 1]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:31:36.084+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.clockui2] Name[clockui2] Icon[/opt/usr/apps/org.example.clockui2/shared/res/clockui2.png] enable[1] system[0]
06-01 00:31:36.084+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.clockui2'], count[0]
06-01 00:31:36.084+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.clockui2][-17956860][0]
06-01 00:31:36.084+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.clockui2]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[clockui2] pos[4, 1] pageId[100001]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[16]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[4], [4, 1]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[4], [4, 1]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:31:36.084+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.contacts] Name[Contacts] Icon[/usr/share/icons/default/small/org.tizen.contacts.png] enable[1] system[1]
06-01 00:31:36.084+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.contacts'], count[0]
06-01 00:31:36.084+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.contacts][-17956860][0]
06-01 00:31:36.084+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.contacts]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Contacts] pos[1, 2] pageId[100001]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[4]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[5], [1, 2]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[5], [1, 2]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:31:36.084+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.email] Name[Email] Icon[/usr/apps/org.tizen.email/shared/res/org.tizen.email.png] enable[1] system[1]
06-01 00:31:36.084+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.email'], count[1]
06-01 00:31:36.084+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.email]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Email] pos[2, 2] pageId[100001]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[5]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[6], [2, 2]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[6], [2, 2]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:31:36.084+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.emailui] Name[emailui] Icon[/opt/usr/apps/org.example.emailui/shared/res/emailui.png] enable[1] system[0]
06-01 00:31:36.084+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.emailui'], count[0]
06-01 00:31:36.084+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.emailui][-17956860][0]
06-01 00:31:36.084+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.emailui]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[emailui] pos[3, 2] pageId[100001]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[15]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[7], [3, 2]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[7], [3, 2]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:31:36.084+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.example] Name[forpet] Icon[/opt/usr/apps/org.example.example/shared/res/1.jpg] enable[1] system[0]
06-01 00:31:36.084+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.example'], count[0]
06-01 00:31:36.084+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.example][-17956860][0]
06-01 00:31:36.084+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.example]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[forpet] pos[4, 2] pageId[100001]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[0]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(787) >  AddBoxToMenuView
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(347) >  AddBox Name[forpet] pageid[100001] pos[4, 2]
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(354) >  menuPage.GetPageId() = 100001, boxPageId = 100001
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: AddBoxToPage(112) >  void ClusterHome3D::Internal::CMainMenuPage::AddBoxToPage(std::shared_ptr<CMainMenuBoxData>) : 112
06-01 00:31:36.084+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: AddBoxToPage(122) >  void ClusterHome3D::Internal::CMainMenuPage::AddBoxToPage(std::shared_ptr<CMainMenuBoxData>) : 122
06-01 00:31:36.084+0900 D/test-log( 2904): mainmenu-page-impl.cpp: AddBoxToPage(123) >  create box[org.example.example] [4,2]
06-01 00:31:36.084+0900 D/test-log( 2904): mainmenu-box-impl.cpp: CMainMenuBox(148) >  create box
06-01 00:31:36.084+0900 D/test-log( 2904): mainmenu-box-impl.cpp: SetPosition(459) >  cut Animation : forpet
06-01 00:31:36.094+0900 D/test-log( 2904): mainmenu-page-impl.cpp: AddBoxToPage(177) >  add created box
06-01 00:31:36.094+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.gallery] Name[Gallery] Icon[/usr/share/icons/default/small/org.tizen.gallery.png] enable[1] system[1]
06-01 00:31:36.094+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.gallery'], count[0]
06-01 00:31:36.094+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.gallery][-17956860][0]
06-01 00:31:36.094+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.gallery]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Gallery] pos[1, 3] pageId[100001]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[6]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[9], [1, 3]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[8], [4, 2]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:31:36.094+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.browser] Name[Internet] Icon[/usr/share/icons/default/small/org.tizen.browser.png] enable[1] system[1]
06-01 00:31:36.094+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.browser'], count[0]
06-01 00:31:36.094+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.browser][-17956860][0]
06-01 00:31:36.094+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.browser]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Internet] pos[2, 3] pageId[100001]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[1]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[10], [2, 3]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:31:36.094+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.message] Name[Messages] Icon[/usr/share/icons/default/small/org.tizen.message.png] enable[1] system[1]
06-01 00:31:36.094+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.message'], count[1]
06-01 00:31:36.094+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.message]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Messages] pos[3, 3] pageId[100001]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[7]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[11], [3, 3]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:31:36.094+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.music-player] Name[Music] Icon[/usr/share/icons/default/small/org.tizen.music-player.png] enable[1] system[1]
06-01 00:31:36.094+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.music-player'], count[0]
06-01 00:31:36.094+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.music-player][-17956860][0]
06-01 00:31:36.094+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.music-player]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Music] pos[4, 3] pageId[100001]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[8]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[12], [4, 3]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:31:36.094+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.myfile] Name[My Files] Icon[/usr/share/icons/default/small/org.tizen.myfile.png] enable[1] system[1]
06-01 00:31:36.094+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.myfile'], count[0]
06-01 00:31:36.094+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.myfile][-17956860][0]
06-01 00:31:36.094+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.myfile]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[My Files] pos[1, 4] pageId[100001]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[9]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[13], [1, 4]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:31:36.094+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.phone] Name[Phone] Icon[/usr/share/icons/default/small/org.tizen.phone.png] enable[1] system[1]
06-01 00:31:36.094+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.phone'], count[0]
06-01 00:31:36.094+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.phone][-17956860][0]
06-01 00:31:36.094+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.phone]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Phone] pos[2, 4] pageId[100001]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[10]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[14], [2, 4]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:31:36.094+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.setting] Name[Settings] Icon[/usr/share/icons/default/small/org.tizen.setting.png] enable[1] system[1]
06-01 00:31:36.094+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.setting'], count[0]
06-01 00:31:36.094+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.setting][-17956860][0]
06-01 00:31:36.094+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.setting]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Settings] pos[3, 4] pageId[100001]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[11]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[15], [3, 4]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:31:36.094+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.uibuildernavigationview] Name[uibuildernavigationview] Icon[/opt/usr/apps/org.example.uibuildernavigationview/shared/res/uibuildernavigationview.png] enable[1] system[0]
06-01 00:31:36.094+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.uibuildernavigationview'], count[0]
06-01 00:31:36.094+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.uibuildernavigationview][-17956860][0]
06-01 00:31:36.094+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.uibuildernavigationview]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[uibuildernavigationview] pos[4, 4] pageId[100001]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[14]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[16], [4, 4]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:31:36.094+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.videos] Name[Video] Icon[/usr/share/icons/default/small/org.tizen.videos.png] enable[1] system[1]
06-01 00:31:36.094+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.videos'], count[0]
06-01 00:31:36.094+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.videos][-17956860][0]
06-01 00:31:36.094+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.videos]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Video] pos[1, 5] pageId[100001]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[12]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[17], [1, 5]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 00:31:36.094+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: RearrangeItems(243) >  view type [1]
06-01 00:31:36.254+0900 D/rpm-installer( 7166): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
06-01 00:31:36.254+0900 D/rpm-installer( 7166): rpm-appcore-intf.c: main(259) > ------------------------------------------------
06-01 00:31:36.254+0900 D/rpm-installer( 7166): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
06-01 00:31:36.254+0900 D/rpm-installer( 7166): rpm-appcore-intf.c: main(261) > ------------------------------------------------
06-01 00:31:36.284+0900 D/PKGMGR_SERVER( 7152): pkgmgr-server.c: sighandler(387) > child exit [7166]
06-01 00:31:36.284+0900 E/PKGMGR_SERVER( 7152): pkgmgr-server.c: sighandler(402) > child NORMAL exit [7166]
06-01 00:31:36.994+0900 E/PKGMGR_SERVER( 7152): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-01 00:31:36.994+0900 E/PKGMGR_SERVER( 7152): pkgmgr-server.c: main(2265) > package manager server terminated.
06-01 00:31:37.134+0900 D/WIDGET_PROVIDER( 3032): widget_provider.c: widget_provider_send_ping(1671) > [SECURE_LOG] name[0_48.500311]
06-01 00:31:37.254+0900 D/AUL_AMD ( 2773): amd_request.c: __request_handler(838) > __request_handler: 0
06-01 00:31:37.254+0900 D/AUL_AMD ( 2773): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-01 00:31:37.254+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 00:31:37.254+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 00:31:37.254+0900 I/AUL     ( 2773): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
06-01 00:31:37.254+0900 D/AUL     ( 2773): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 7219, pid = 7221
06-01 00:31:37.254+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 00:31:37.254+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 00:31:37.254+0900 I/AUL     ( 2773): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
06-01 00:31:37.254+0900 E/AUL_AMD ( 2773): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-01 00:31:37.254+0900 W/AUL_AMD ( 2773): amd_launch.c: _start_app(2233) > caller pid : 7221
06-01 00:31:37.254+0900 E/AUL_AMD ( 2773): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-01 00:31:37.264+0900 W/AUL_AMD ( 2773): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-01 00:31:37.264+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2648) > process_pool: false
06-01 00:31:37.264+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-01 00:31:37.264+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-01 00:31:37.264+0900 W/AUL_AMD ( 2773): amd_launch.c: _start_app(2665) > pad pid(-5)
06-01 00:31:37.264+0900 D/AUL_AMD ( 2773): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-01 00:31:37.264+0900 D/AUL_AMD ( 2773): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-01 00:31:37.264+0900 D/AUL     ( 2773): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-01 00:31:37.264+0900 D/AUL_PAD ( 2951): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-01 00:31:37.264+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 00:31:37.264+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 00:31:37.264+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 00:31:37.264+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 00:31:37.264+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 00:31:37.264+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 00:31:37.264+0900 D/AUL_PAD ( 2951): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-01 00:31:37.264+0900 D/RESOURCED( 2886): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-01 00:31:37.264+0900 D/RESOURCED( 2886): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-01 00:31:37.264+0900 E/RESOURCED( 2886): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-01 00:31:37.274+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-01 00:31:37.274+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-01 00:31:37.274+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-01 00:31:37.274+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-01 00:31:37.274+0900 D/AUL_PAD ( 2951): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-01 00:31:37.274+0900 D/AUL_PAD ( 2951): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-01 00:31:37.274+0900 W/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-01 00:31:37.274+0900 D/AUL     ( 2951): process_pool.c: __send_pkt_raw_data(219) > send(11) : 620 / 620
06-01 00:31:37.274+0900 D/AUL_PAD ( 2951): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 6954, bin path: /opt/usr/apps/org.example.example/bin/example
06-01 00:31:37.274+0900 W/AUL_PAD ( 2951): launchpad.c: __send_result_to_caller(265) > Check app launching
06-01 00:31:37.274+0900 D/AUL_PAD ( 2951): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-01 00:31:37.274+0900 D/AUL_PAD ( 6954): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-01 00:31:37.274+0900 D/AUL_PAD ( 6954): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
06-01 00:31:37.274+0900 D/AUL_PAD ( 6954): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-01 00:31:37.274+0900 D/AUL_PAD ( 6954): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-01 00:31:37.274+0900 D/AUL_PAD ( 6954): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-01 00:31:37.274+0900 D/AUL_PAD ( 6954): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-01 00:31:37.274+0900 D/AUL     ( 6954): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (6972) is sent.
06-01 00:31:37.274+0900 D/AUL     ( 6954): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 6972, signo: 10
06-01 00:31:37.274+0900 D/AUL     ( 6954): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-01 00:31:37.274+0900 D/AUL_PAD ( 6954): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-01 00:31:37.274+0900 D/AUL_PAD ( 6954): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-01 00:31:37.274+0900 D/AUL_PAD ( 6954): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-01 00:31:37.274+0900 D/AUL_PAD ( 6954): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-01 00:31:37.274+0900 D/AUL_PAD ( 6954): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTYyNDQ2OTcvMjYyMzE0AA==##
06-01 00:31:37.274+0900 D/AUL_PAD ( 6954): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-01 00:31:37.274+0900 D/AUL_PAD ( 6954): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA3MjIxAA==##
06-01 00:31:37.274+0900 D/AUL_PAD ( 6954): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-01 00:31:37.274+0900 D/AUL_PAD ( 6954): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-01 00:31:37.274+0900 D/AUL_PAD ( 6954): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-01 00:31:37.274+0900 D/AUL_PAD ( 6954): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-01 00:31:37.274+0900 D/AUL_PAD ( 6954): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-01 00:31:37.284+0900 I/CAPI_APPFW_APPLICATION( 6954): app_main.c: ui_app_main(788) > app_efl_main
06-01 00:31:37.284+0900 D/LAUNCH  ( 6954): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-01 00:31:37.284+0900 D/APP_CORE( 6954): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-01 00:31:37.284+0900 D/APP_CORE( 6954): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-01 00:31:37.284+0900 D/APP_CORE( 6954): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-01 00:31:37.304+0900 D/APP_CORE( 6954): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-01 00:31:37.304+0900 D/AUL     ( 6954): app_sock.c: __create_server_sock(156) > pg path - already exists
06-01 00:31:37.304+0900 D/APP_CORE( 6954): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42c4520
06-01 00:31:37.304+0900 D/LAUNCH  ( 6954): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-01 00:31:37.304+0900 I/CAPI_APPFW_APPLICATION( 6954): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-01 00:31:37.354+0900 E/CAPI_NETWORK_WIFI( 2891): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-01 00:31:37.354+0900 E/INDICATOR( 2891): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001fcff)
06-01 00:31:37.354+0900 E/INDICATOR( 2891): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-01 00:31:37.354+0900 E/INDICATOR( 2891): 
06-01 00:31:37.374+0900 D/AUL_PAD ( 2951): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-01 00:31:37.374+0900 W/AUL     ( 2773): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 6954, appid: org.example.example
06-01 00:31:37.374+0900 D/AUL     ( 2773): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-01 00:31:37.374+0900 E/AUL     ( 2773): simple_util.c: __trm_app_info_send_socket(330) > access
06-01 00:31:37.374+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2700) > add app group info
06-01 00:31:37.374+0900 E/AUL     ( 2773): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-01 00:31:37.374+0900 D/AUL_AMD ( 2773): amd_status.c: _status_add_app_info_list(427) > pid(6954) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-01 00:31:37.374+0900 D/RESOURCED( 2886): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 6954
06-01 00:31:37.374+0900 D/RESOURCED( 2886): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-01 00:31:37.374+0900 E/RESOURCED( 2886): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-01 00:31:37.374+0900 D/RESOURCED( 2886): proc-main.c: resourced_proc_status_change(888) > available memory = 300
06-01 00:31:37.424+0900 I/user_tag0( 6954): /opt/usr/apps/org.example.example/data/test.db
06-01 00:31:37.514+0900 W/CRASH_MANAGER( 7226): worker.c: worker_job(1204) > 1106954657861149624469
