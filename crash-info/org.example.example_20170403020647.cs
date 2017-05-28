S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 26233
Date: 2017-04-03 02:06:47+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x2c

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb88bcf70, esi = 0xb889f970
ebp = 0xbfff75e8, esp = 0xbfff7590
eax = 0xb88bd6f0, ebx = 0xb73465f0
ecx = 0xb37e8570, edx = 0x00000000
eip = 0xb71aa251

Memory Information
MemTotal:      123 KB
MemFree:        30 KB
Buffers:         8 KB
Cached:     165184 KB
VmPeak:      79908 KB
VmSize:      79908 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16044 KB
VmRSS:       16044 KB
VmData:      19992 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33320 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 26233 TID = 26233
26233 26255 26259 

Maps Information
b2cce000 b2cd8000 r-xp /usr/lib/libfeedback.so.0.1.4
b2cde000 b2cea000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2ceb000 b2d0c000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2d11000 b2d12000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2d13000 b2d18000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2d19000 b2d1a000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2d1b000 b2d1d000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2d1e000 b2d20000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2d21000 b2d2d000 r-xp /usr/lib/libdrm.so.2.4.0
b2d2e000 b2d31000 r-xp /usr/lib/libdri2.so.0.0.0
b2d32000 b2d3c000 r-xp /usr/lib/libtbm.so.1.0.0
b2d43000 b2d44000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2d45000 b2d46000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2d47000 b2d4a000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b2d4b000 b2d4e000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b2d4f000 b2d64000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2d65000 b2d77000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3680000 b3686000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3687000 b37cb000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37db000 b37dc000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37dd000 b37e6000 r-xp /usr/lib/libefl-extension.so.0.1.0
b37e7000 b37eb000 r-xp /opt/usr/apps/org.example.example/bin/example
b37ed000 b3826000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4229000 b4234000 r-xp /lib/libnss_files-2.20-2014.11.so
b4236000 b4241000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4243000 b425a000 r-xp /lib/libnsl-2.20-2014.11.so
b425e000 b4266000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4268000 b428c000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b428d000 b428e000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b428f000 b4292000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4293000 b429a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b429b000 b42a5000 r-xp /usr/lib/libsensord-share.so
b42a6000 b42c2000 r-xp /usr/lib/libsensor.so.1.2.0
b42c4000 b42cd000 r-xp /usr/lib/libappcore-common.so.1.1
b42d0000 b42d2000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42e7000 b42e9000 r-xp /usr/lib/libXau.so.6.0.0
b42ea000 b430c000 r-xp /usr/lib/libxcb.so.1.1.0
b430e000 b4317000 r-xp /lib/libcrypt-2.20-2014.11.so
b4340000 b4342000 r-xp /usr/lib/libiri.so
b4343000 b4369000 r-xp /lib/libexpat.so.1.5.2
b436b000 b43d6000 r-xp /usr/lib/libssl.so.1.0.0
b43dc000 b43e8000 r-xp /usr/lib/libethumb.so.1.13.0
b43e9000 b43ed000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43ee000 b463f000 r-xp /usr/lib/libcrypto.so.1.0.0
b5bba000 b5bca000 r-xp /usr/lib/libXi.so.6.1.0
b5bcb000 b5bcd000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bce000 b5bd4000 r-xp /usr/lib/libXtst.so.6.1.0
b5bd5000 b5bdf000 r-xp /usr/lib/libXrender.so.1.3.0
b5be0000 b5be9000 r-xp /usr/lib/libXrandr.so.2.2.0
b5beb000 b5bed000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bee000 b5bf3000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bf4000 b5c06000 r-xp /usr/lib/libXext.so.6.4.0
b5c07000 b5c09000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c0a000 b5c0c000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c0e000 b5d50000 r-xp /usr/lib/libX11.so.6.3.0
b5d54000 b5d5e000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d5f000 b5d75000 r-xp /usr/lib/libudev.so.1.6.0
b5d78000 b5d7c000 r-xp /lib/libattr.so.1.1.0
b5d7d000 b5dac000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5dae000 b5db4000 r-xp /usr/lib/libffi.so.6.0.2
b5db5000 b5dd8000 r-xp /lib/libz.so.1.2.8
b5dd9000 b5ddc000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5ddd000 b5f39000 r-xp /usr/lib/libxml2.so.2.9.2
b5f3f000 b6026000 r-xp /usr/lib/libstdc++.so.6.0.20
b6033000 b6036000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6037000 b6059000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b605a000 b606e000 r-xp /lib/libresolv-2.20-2014.11.so
b6072000 b6096000 r-xp /usr/lib/liblzma.so.5.0.3
b6097000 b6099000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b609b000 b60a5000 r-xp /usr/lib/libembryo.so.1.13.0
b60a6000 b60cf000 r-xp /usr/lib/libpng12.so.0.50.0
b60d0000 b6119000 r-xp /usr/lib/libjpeg.so.8.0.2
b612a000 b6131000 r-xp /lib/librt-2.20-2014.11.so
b6133000 b6152000 r-xp /usr/lib/libector.so.1.13.0
b6155000 b6182000 r-xp /usr/lib/liblua-5.1.so
b6183000 b6213000 r-xp /usr/lib/libfreetype.so.6.11.3
b6217000 b6255000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6256000 b626c000 r-xp /usr/lib/libfribidi.so.0.3.1
b626d000 b62c6000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62c9000 b6314000 r-xp /lib/libm-2.20-2014.11.so
b6316000 b6328000 r-xp /usr/lib/libeio.so.1.13.0
b6329000 b632c000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b632d000 b6333000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6334000 b6357000 r-xp /usr/lib/libefreet.so.1.13.0
b635a000 b6385000 r-xp /usr/lib/libeldbus.so.1.13.0
b6386000 b63ba000 r-xp /usr/lib/libecore_con.so.1.13.0
b63bc000 b63c5000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63c6000 b63cf000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63d0000 b63e3000 r-xp /usr/lib/libeo.so.1.13.0
b63e5000 b63f8000 r-xp /usr/lib/libecore_input.so.1.13.0
b63f9000 b6400000 r-xp /usr/lib/libecore_file.so.1.13.0
b6401000 b6424000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6425000 b6451000 r-xp /usr/lib/libeet.so.1.13.0
b645a000 b64c5000 r-xp /usr/lib/libeina.so.1.13.0
b64c8000 b64df000 r-xp /usr/lib/libefl.so.1.13.0
b64e1000 b6648000 r-xp /usr/lib/libicuuc.so.51.1
b6656000 b6862000 r-xp /usr/lib/libicui18n.so.51.1
b686a000 b68b9000 r-xp /usr/lib/libecore_x.so.1.13.0
b68bb000 b68d5000 r-xp /lib/libgcc_s-4.9.so.1
b68d7000 b68db000 r-xp /lib/libcap.so.2.21
b68dc000 b6922000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6923000 b692a000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b692c000 b697e000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6980000 b6b0b000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b10000 b6bde000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6be1000 b6be5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6be6000 b6bf5000 r-xp /usr/lib/libvconf.so.0.2.45
b6bf6000 b6bf9000 r-xp /usr/lib/libvasum.so.0.3.1
b6bfa000 b6bfd000 r-xp /usr/lib/libttrace.so.1.1
b6bff000 b6c03000 r-xp /usr/lib/libiniparser.so.0
b6c04000 b6c34000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c35000 b6c3e000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c3f000 b6c64000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c65000 b6c75000 r-xp /usr/lib/libunwind.so.8.0.1
b6c7f000 b6e2d000 r-xp /lib/libc-2.20-2014.11.so
b6e35000 b6f78000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f7a000 b6fd2000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fd3000 b7007000 r-xp /usr/lib/libsystemd.so.0.4.0
b700a000 b70de000 r-xp /usr/lib/libedje.so.1.13.0
b70e1000 b710d000 r-xp /usr/lib/libecore.so.1.13.0
b711e000 b7344000 r-xp /usr/lib/libevas.so.1.13.0
b736c000 b7384000 r-xp /lib/libpthread-2.20-2014.11.so
b7388000 b7702000 r-xp /usr/lib/libelementary.so.1.13.0
b7722000 b7726000 r-xp /usr/lib/libsmack.so.1.0.0
b7727000 b7730000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7731000 b7734000 r-xp /usr/lib/libdlog.so.0.0.0
b7735000 b773a000 r-xp /usr/lib/libbundle.so.0.1.22
b773b000 b773e000 r-xp /lib/libdl-2.20-2014.11.so
b7740000 b7765000 r-xp /usr/lib/libaul.so.0.1.0
b7768000 b776a000 r-xp /usr/lib/libappsvc.so.0.1.0
b776b000 b7770000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7771000 b7778000 r-xp /usr/lib/libappcore-efl.so.1.1
b777a000 b777f000 r-xp /usr/lib/libsys-assert.so
b7782000 b7783000 r-xp [vdso]
b7783000 b77a5000 r-xp /lib/ld-2.20-2014.11.so
b77a7000 b77af000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:26233)
Call Stack Count: 10
 0: evas_object_smart_callback_priority_add + 0x91 (0xb71aa251) [/usr/lib/libevas.so.1] + 0x8c251
 1: evas_object_smart_callback_add + 0x38 (0xb71aa338) [/usr/lib/libevas.so.1] + 0x8c338
 2: create_base_gui + 0x99b (0xb37e9beb) [/opt/usr/apps/org.example.example/bin/example] + 0x2beb
 3: app_create + 0x2c (0xb37e90bc) [/opt/usr/apps/org.example.example/bin/example] + 0x20bc
 4: (0xb776d65b) [/usr/lib/libcapi-appfw-application.so.0] + 0x265b
 5: appcore_efl_main + 0x327 (0xb7774c27) [/usr/lib/libappcore-efl.so.1] + 0x3c27
 6: ui_app_main + 0x140 (0xb776dc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
 7: main + 0x27e (0xb37e902e) [/opt/usr/apps/org.example.example/bin/example] + 0x202e
 8: ui_app_low_memory + 0x8 (0xb77a9148) [/opt/usr/apps/org.example.example/bin/example] + 0xb77a9148
 9: __libc_start_main + 0xde (0xb6c96e4e) [/lib/libc.so.6] + 0x17e4e
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
d_pkgmgr_event_callback(1710) > req_id(29420002), pkg_type(tpk), pkgid(org.example.example), key(install_percent), val(100)
04-03 02:06:43.841+0900 D/PKGMGR  ( 2942): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_288020975], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-03 02:06:43.841+0900 D/ESD     ( 2942): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29420002), pkg_type(tpk), pkgid(org.example.example), key(end), val(ok)
04-03 02:06:43.841+0900 D/ESD     ( 2942): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
04-03 02:06:43.841+0900 W/ISF_PANEL_EFL( 3029): isf_panel_efl.cpp: _package_manager_event_cb(1380) > isf_db_select_appids_by_pkgid returned 0.
04-03 02:06:43.841+0900 D/PKGMGR  ( 2951): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_288020975], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-03 02:06:43.841+0900 D/PKGMGR  ( 2951): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
04-03 02:06:43.841+0900 D/PKGMGR  ( 2951): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_288020975], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-03 02:06:43.841+0900 D/PKGMGR  ( 2951): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
04-03 02:06:43.841+0900 D/PKGMGR  ( 2769): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[upgrade], req_id=[org.example.example_288020975], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-03 02:06:43.841+0900 D/AUL_AMD ( 2769): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.example), key(end), value(ok)
04-03 02:06:43.841+0900 W/AUL_AMD ( 2769): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(update), value(ok)
04-03 02:06:43.841+0900 D/cluster-home( 2870): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
04-03 02:06:43.841+0900 D/cluster-home( 2870): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.example]
04-03 02:06:43.841+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.example]
04-03 02:06:43.841+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.example]
04-03 02:06:43.841+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
04-03 02:06:43.841+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
04-03 02:06:43.841+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.example]
04-03 02:06:43.841+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.example] Name[example] Icon[/opt/usr/apps/org.example.example/shared/res/example.png] enable[1] system[0]
04-03 02:06:43.861+0900 D/cluster-home( 2870): mainmenu-presenter.cpp: OnAppUpdated(337) >  pAppId [org.example.example]
04-03 02:06:43.861+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.example
04-03 02:06:43.861+0900 D/AUL_AMD ( 2769): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.example, type:rpm
04-03 02:06:43.861+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[13], isFolder[0], pageId[1], col[1], row[4], appId[org.example.example], name[example], menuId[1], isPreload[0] isPreload[0]
04-03 02:06:43.861+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
04-03 02:06:43.861+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.example] Name[example] Icon[/opt/usr/apps/org.example.example/shared/res/example.png] enable[1] system[0]
04-03 02:06:43.861+0900 D/cluster-home( 2870): mainmenu-presenter.cpp: OnAppUpdated(364) >  name [example]
04-03 02:06:43.861+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
04-03 02:06:43.861+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
04-03 02:06:43.861+0900 D/test-log( 2870): mainmenu-box-impl.cpp: UpdateBoxData(812) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.example/shared/res/example.png], New icon path[/opt/usr/apps/org.example.example/shared/res/example.png]!!!!!
04-03 02:06:43.861+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 1, appId = $appId, name = $name, col = 1, row = 4, isPreload = 0, isSystem = 0 WHERE boxId = 13]
04-03 02:06:43.861+0900 D/PKGMGR  (26153): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_288020975], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-03 02:06:43.861+0900 D/PKGMGR  ( 2940): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_288020975], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-03 02:06:43.861+0900 D/QUICKPANEL( 2940): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:end val:ok
04-03 02:06:43.961+0900 D/rpm-installer(26155): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
04-03 02:06:43.961+0900 D/rpm-installer(26155): rpm-appcore-intf.c: main(259) > ------------------------------------------------
04-03 02:06:43.961+0900 D/rpm-installer(26155): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
04-03 02:06:43.961+0900 D/rpm-installer(26155): rpm-appcore-intf.c: main(261) > ------------------------------------------------
04-03 02:06:43.961+0900 D/PKGMGR_SERVER(26066): pkgmgr-server.c: sighandler(387) > child exit [26155]
04-03 02:06:43.961+0900 E/PKGMGR_SERVER(26066): pkgmgr-server.c: sighandler(402) > child NORMAL exit [26155]
04-03 02:06:44.181+0900 D/AUL_AMD ( 2769): amd_request.c: __request_handler(838) > __request_handler: 0
04-03 02:06:44.181+0900 D/AUL_AMD ( 2769): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
04-03 02:06:44.181+0900 D/PKGMGR_INFO( 2769): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
04-03 02:06:44.181+0900 D/PKGMGR_INFO( 2769): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
04-03 02:06:44.181+0900 I/AUL     ( 2769): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
04-03 02:06:44.181+0900 D/AUL     ( 2769): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 26205, pid = 26207
04-03 02:06:44.181+0900 D/PKGMGR_INFO( 2769): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
04-03 02:06:44.181+0900 D/PKGMGR_INFO( 2769): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
04-03 02:06:44.181+0900 I/AUL     ( 2769): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
04-03 02:06:44.181+0900 E/AUL_AMD ( 2769): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
04-03 02:06:44.181+0900 W/AUL_AMD ( 2769): amd_launch.c: _start_app(2233) > caller pid : 26207
04-03 02:06:44.181+0900 E/AUL_AMD ( 2769): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
04-03 02:06:44.181+0900 W/AUL_AMD ( 2769): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
04-03 02:06:44.181+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2648) > process_pool: false
04-03 02:06:44.181+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
04-03 02:06:44.181+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
04-03 02:06:44.181+0900 W/AUL_AMD ( 2769): amd_launch.c: _start_app(2665) > pad pid(-5)
04-03 02:06:44.181+0900 D/AUL_AMD ( 2769): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
04-03 02:06:44.181+0900 D/AUL_AMD ( 2769): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
04-03 02:06:44.181+0900 D/AUL     ( 2769): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
04-03 02:06:44.181+0900 D/RESOURCED( 2852): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
04-03 02:06:44.181+0900 D/RESOURCED( 2852): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 2
04-03 02:06:44.181+0900 E/RESOURCED( 2852): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-03 02:06:44.181+0900 D/AUL_PAD ( 2920): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
04-03 02:06:44.181+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
04-03 02:06:44.181+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
04-03 02:06:44.181+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
04-03 02:06:44.181+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
04-03 02:06:44.181+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
04-03 02:06:44.181+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
04-03 02:06:44.181+0900 D/AUL_PAD ( 2920): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
04-03 02:06:44.181+0900 D/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
04-03 02:06:44.181+0900 D/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
04-03 02:06:44.181+0900 D/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
04-03 02:06:44.181+0900 D/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
04-03 02:06:44.181+0900 D/AUL_PAD ( 2920): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
04-03 02:06:44.181+0900 D/AUL_PAD ( 2920): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
04-03 02:06:44.181+0900 W/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
04-03 02:06:44.181+0900 D/AUL     ( 2920): process_pool.c: __send_pkt_raw_data(219) > send(13) : 624 / 624
04-03 02:06:44.181+0900 D/AUL_PAD ( 2920): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 26031, bin path: /opt/usr/apps/org.example.example/bin/example
04-03 02:06:44.181+0900 W/AUL_PAD ( 2920): launchpad.c: __send_result_to_caller(265) > Check app launching
04-03 02:06:44.181+0900 D/AUL_PAD ( 2920): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
04-03 02:06:44.181+0900 D/AUL_PAD (26031): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
04-03 02:06:44.181+0900 D/AUL_PAD (26031): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
04-03 02:06:44.181+0900 D/AUL_PAD (26031): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
04-03 02:06:44.181+0900 D/AUL_PAD (26031): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
04-03 02:06:44.181+0900 D/AUL_PAD (26031): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
04-03 02:06:44.181+0900 D/AUL_PAD (26031): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
04-03 02:06:44.181+0900 D/AUL     (26031): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (26032) is sent.
04-03 02:06:44.181+0900 D/AUL     (26031): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 26032, signo: 10
04-03 02:06:44.181+0900 D/AUL     (26031): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
04-03 02:06:44.181+0900 D/AUL_PAD (26031): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
04-03 02:06:44.201+0900 D/AUL_PAD (26031): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
04-03 02:06:44.201+0900 D/AUL_PAD (26031): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
04-03 02:06:44.201+0900 D/AUL_PAD (26031): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
04-03 02:06:44.201+0900 D/AUL_PAD (26031): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTExNTI4MDQvMTk0MTIyAA==##
04-03 02:06:44.201+0900 D/AUL_PAD (26031): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
04-03 02:06:44.201+0900 D/AUL_PAD (26031): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAyNjIwNwA=##
04-03 02:06:44.201+0900 D/AUL_PAD (26031): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
04-03 02:06:44.201+0900 D/AUL_PAD (26031): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
04-03 02:06:44.201+0900 D/AUL_PAD (26031): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
04-03 02:06:44.201+0900 D/AUL_PAD (26031): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
04-03 02:06:44.201+0900 D/AUL_PAD (26031): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
04-03 02:06:44.201+0900 I/CAPI_APPFW_APPLICATION(26031): app_main.c: ui_app_main(788) > app_efl_main
04-03 02:06:44.201+0900 D/LAUNCH  (26031): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
04-03 02:06:44.201+0900 D/APP_CORE(26031): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
04-03 02:06:44.201+0900 D/APP_CORE(26031): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
04-03 02:06:44.201+0900 D/APP_CORE(26031): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
04-03 02:06:44.201+0900 D/APP_CORE(26031): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
04-03 02:06:44.201+0900 D/AUL     (26031): app_sock.c: __create_server_sock(156) > pg path - already exists
04-03 02:06:44.201+0900 D/APP_CORE(26031): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42d4520
04-03 02:06:44.201+0900 D/LAUNCH  (26031): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
04-03 02:06:44.201+0900 I/CAPI_APPFW_APPLICATION(26031): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
04-03 02:06:44.231+0900 E/EFL     (26031): eo<26031> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb9597520 is not pointing to a valid object. Maybe it has already been freed.
04-03 02:06:44.231+0900 E/EFL     (26031): eo<26031> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0xb9597520) is an invalid ref.
04-03 02:06:44.261+0900 W/CRASH_MANAGER(26212): worker.c: worker_job(1204) > 11260316578611491152804
04-03 02:06:44.301+0900 E/AUL_PAD ( 2920): launchpad.c: __send_result_to_caller(280) > error founded when being launched with 26031
04-03 02:06:44.301+0900 E/AUL_PAD ( 2920): launchpad.c: __send_result_to_caller(282) > The app process might be terminated while we are wating 26031
04-03 02:06:44.301+0900 E/AUL_PAD ( 2920): launchpad.c: __send_result_to_caller(312) > process launched, but cmdline not changed
04-03 02:06:44.301+0900 W/AUL     ( 2769): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 26031, appid: org.example.example
04-03 02:06:44.301+0900 D/AUL     ( 2769): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
04-03 02:06:44.301+0900 E/AUL     ( 2769): simple_util.c: __trm_app_info_send_socket(330) > access
04-03 02:06:44.301+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2700) > add app group info
04-03 02:06:44.301+0900 E/AUL     ( 2769): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
04-03 02:06:44.301+0900 D/AUL_AMD ( 2769): amd_status.c: _status_add_app_info_list(427) > pid(26031) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
04-03 02:06:44.301+0900 D/RESOURCED( 2852): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 26031
04-03 02:06:44.301+0900 D/RESOURCED( 2852): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
04-03 02:06:44.301+0900 E/RESOURCED( 2852): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
04-03 02:06:44.301+0900 D/RESOURCED( 2852): proc-main.c: resourced_proc_status_change(888) > available memory = 314
04-03 02:06:45.001+0900 E/PKGMGR_SERVER(26066): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-03 02:06:45.001+0900 E/PKGMGR_SERVER(26066): pkgmgr-server.c: main(2265) > package manager server terminated.
04-03 02:06:45.011+0900 E/VCONF   (26212): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
04-03 02:06:45.011+0900 E/VCONF   (26212): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
04-03 02:06:45.011+0900 E/VCONF   (26212): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
04-03 02:06:45.011+0900 E/VCONF   (26212): vconf.c: vconf_get_str(2891) > vconf_get_str(26212) : db/menu_widget/language error
04-03 02:06:45.011+0900 E/PKGMGR_INFO(26212): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
04-03 02:06:45.011+0900 D/PKGMGR_INFO(26212): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3502) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
04-03 02:06:45.011+0900 D/PKGMGR_INFO(26212): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3508) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='No Locale' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
04-03 02:06:45.011+0900 E/VCONF   (26212): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
04-03 02:06:45.011+0900 E/VCONF   (26212): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
04-03 02:06:45.011+0900 E/VCONF   (26212): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
04-03 02:06:45.011+0900 E/VCONF   (26212): vconf.c: vconf_get_str(2891) > vconf_get_str(26212) : db/menu_widget/language error
04-03 02:06:45.011+0900 E/PKGMGR_INFO(26212): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
04-03 02:06:45.011+0900 D/PKGMGR_INFO(26212): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
04-03 02:06:45.011+0900 D/PKGMGR_INFO(26212): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
04-03 02:06:45.011+0900 E/VCONF   (26212): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
04-03 02:06:45.011+0900 E/VCONF   (26212): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
04-03 02:06:45.011+0900 E/VCONF   (26212): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
04-03 02:06:45.011+0900 E/VCONF   (26212): vconf.c: vconf_get_str(2891) > vconf_get_str(26212) : db/menu_widget/language error
04-03 02:06:45.011+0900 E/PKGMGR_INFO(26212): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
04-03 02:06:45.011+0900 D/PKGMGR_INFO(26212): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
04-03 02:06:45.011+0900 D/PKGMGR_INFO(26212): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
04-03 02:06:45.011+0900 E/VCONF   (26212): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
04-03 02:06:45.011+0900 E/VCONF   (26212): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
04-03 02:06:45.011+0900 E/VCONF   (26212): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
04-03 02:06:45.011+0900 E/VCONF   (26212): vconf.c: vconf_get_str(2891) > vconf_get_str(26212) : db/menu_widget/language error
04-03 02:06:45.011+0900 E/PKGMGR_INFO(26212): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
04-03 02:06:45.131+0900 D/LAUNCH  (26225): appcore-efl.c: appcore_efl_main(1692) > [crash-popup:Application:main:done]
04-03 02:06:45.131+0900 D/PKGMGR_INFO(26225): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.crash-popup/bin/crash-popup' and package_app_info.app_disable IN ('false','False')
04-03 02:06:45.131+0900 D/PKGMGR_INFO(26225): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.crash-popup/bin/crash-popup' and package_app_info.app_disable IN ('false','False')
04-03 02:06:45.131+0900 D/AUL     (26225): pkginfo.c: aul_app_get_appid_bypid(241) > [SECURE_LOG] appid for 26225 is org.tizen.crash-popup
04-03 02:06:45.181+0900 D/APP_CORE(26225): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
04-03 02:06:45.181+0900 D/APP_CORE(26225): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /usr/apps/org.tizen.crash-popup/res/locale
04-03 02:06:45.181+0900 D/APP_CORE(26225): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
04-03 02:06:45.191+0900 D/APP_CORE(26225): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
04-03 02:06:45.191+0900 D/APP_CORE(26225): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb77a7520
04-03 02:06:45.191+0900 D/LAUNCH  (26225): appcore-efl.c: __before_loop(1136) > [crash-popup:Platform:appcore_init:done]
04-03 02:06:45.201+0900 D/APP_CORE(26225): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
04-03 02:06:45.201+0900 D/LAUNCH  (26225): appcore-efl.c: __before_loop(1154) > [crash-popup:Application:create:done]
04-03 02:06:45.201+0900 D/APP_CORE(26225): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
04-03 02:06:45.311+0900 D/AUL_PAD ( 2920): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
04-03 02:06:45.311+0900 D/AUL_PAD (26233): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
04-03 02:06:45.311+0900 D/AUL_AMD ( 2769): amd_launch.c: __grab_timeout_handler(1445) > pid(26031) ecore_x_pointer_ungrab
04-03 02:06:45.311+0900 D/AUL_AMD ( 2769): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
04-03 02:06:45.311+0900 W/AUL_AMD ( 2769): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-03 02:06:45.311+0900 W/AUL_AMD ( 2769): amd_launch.c: __grab_timeout_handler(1447) > back key ungrab error
04-03 02:06:45.331+0900 D/AUL_PAD ( 2920): sigchild.h: __send_app_launch_signal(131) > send launch signal done
04-03 02:06:45.331+0900 D/AUL_PAD ( 2920): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
04-03 02:06:45.331+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
04-03 02:06:45.331+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
04-03 02:06:45.331+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
04-03 02:06:45.331+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
04-03 02:06:45.331+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
04-03 02:06:45.331+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
04-03 02:06:45.331+0900 I/AUL_PAD ( 2920): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 26031 pgid = 26031
04-03 02:06:45.331+0900 I/AUL_PAD ( 2920): sigchild.h: __sigchild_action(142) > dead_pid(26031)
04-03 02:06:45.331+0900 E/RESOURCED( 2852): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1771
04-03 02:06:45.331+0900 D/AUL_PAD ( 2920): sigchild.h: __send_app_dead_signal(90) > send dead signal done
04-03 02:06:45.331+0900 I/AUL_PAD ( 2920): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
04-03 02:06:45.331+0900 I/AUL_PAD ( 2920): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
04-03 02:06:45.331+0900 E/AUL_PAD ( 2920): launchpad.c: main(688) > error reading sigchld info
04-03 02:06:45.331+0900 I/ESD     ( 2942): esd_main.c: __esd_app_dead_handler(1771) > pid: 26031
04-03 02:06:45.331+0900 W/AUL_AMD ( 2769): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 26031
04-03 02:06:45.331+0900 W/AUL_AMD ( 2769): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 26031
04-03 02:06:45.331+0900 D/AUL_AMD ( 2769): amd_key.c: _unregister_key_event(179) > ===key stack===
04-03 02:06:45.331+0900 E/AUL_AMD ( 2769): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
04-03 02:06:45.331+0900 D/AUL_AMD ( 2769): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.example.example)
04-03 02:06:45.331+0900 D/AUL     ( 2769): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
04-03 02:06:45.331+0900 E/AUL     ( 2769): simple_util.c: __trm_app_info_send_socket(330) > access
04-03 02:06:45.331+0900 D/STARTER ( 2845): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 26031 is termianted
04-03 02:06:45.331+0900 D/STARTER ( 2845): starter.c: _check_dead_signal(202) > [_check_dead_signal:202] Unknown process, ignore it
04-03 02:06:45.331+0900 E/RESOURCED( 2852): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1772
04-03 02:06:45.331+0900 D/RESOURCED( 2852): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 26031
04-03 02:06:45.331+0900 D/RESOURCED( 2852): appinfo-list.c: resourced_appinfo_put(132) > appid org.example.example, pkgname = org.example.example, ref = 1
04-03 02:06:45.461+0900 E/RESOURCED( 2852): heart-abnormal.c: heart_abnormal_process_crashed(77) > Failed: dbus_message_get_args()
04-03 02:06:45.821+0900 D/AUL_AMD ( 2769): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
04-03 02:06:45.821+0900 D/RUA     ( 2769): rua.c: rua_add_history(179) > rua_add_history start
04-03 02:06:45.821+0900 D/RUA     ( 2769): rua.c: rua_add_history(247) > rua_add_history ok
04-03 02:06:46.351+0900 D/AUL_PAD (26233): launchpad_loader.c: main(588) > sleeping 1 sec...
04-03 02:06:46.351+0900 D/AUL_PAD (26233): preload.h: __preload_init(52) > max_cmdline_size = 1053
04-03 02:06:46.351+0900 D/AUL_PAD (26233): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b8720760
04-03 02:06:46.351+0900 D/AUL_PAD (26233): preload.h: __preload_init(69) > get pre-initialization function
04-03 02:06:46.351+0900 D/AUL_PAD (26233): preload.h: __preload_init(73) > get shutdown function
04-03 02:06:46.351+0900 D/AUL_PAD (26233): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b8720a40
04-03 02:06:46.351+0900 D/AUL_PAD (26233): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b8722640
04-03 02:06:46.351+0900 D/AUL_PAD (26233): preload.h: __preload_init(69) > get pre-initialization function
04-03 02:06:46.351+0900 D/AUL_PAD (26233): preload.h: __preload_init(73) > get shutdown function
04-03 02:06:46.351+0900 D/AUL_PAD (26233): preexec.h: __preexec_init(76) > preexec start
04-03 02:06:46.371+0900 D/AUL_PAD (26233): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
04-03 02:06:46.371+0900 D/AUL     (26233): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
04-03 02:06:46.371+0900 D/AUL     (26233): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
04-03 02:06:46.371+0900 D/AUL_PAD ( 2920): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
04-03 02:06:46.371+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
04-03 02:06:46.371+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
04-03 02:06:46.371+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
04-03 02:06:46.371+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
04-03 02:06:46.371+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
04-03 02:06:46.371+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
04-03 02:06:46.371+0900 D/AUL_PAD ( 2920): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
04-03 02:06:46.371+0900 D/AUL_PAD ( 2920): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 26233
04-03 02:06:46.371+0900 D/AUL     (26233): process_pool.c: __connect_to_launchpad(132) > send(26233) : 4
04-03 02:06:46.371+0900 D/AUL     (26233): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
04-03 02:06:46.431+0900 D/AUL_PAD (26233): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
04-03 02:06:46.431+0900 D/AUL_PAD (26233): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
04-03 02:06:46.431+0900 D/AUL_PAD (26233): launchpad_loader.c: main(693) > [candidate] ecore handler add
04-03 02:06:46.441+0900 D/AUL_PAD (26233): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
04-03 02:06:47.321+0900 D/test-log( 2870): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1023) >  menu box Pick touched
04-03 02:06:47.321+0900 D/test-log( 2870): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1034) >  Long Tap Timer Start
04-03 02:06:47.501+0900 D/test-log( 2870): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1194) >  Box[0] pick ended by Up
04-03 02:06:47.501+0900 D/test-log( 2870): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1199) >  Cancel Long Tap Timer
04-03 02:06:47.501+0900 D/test-log( 2870): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1240) >  app launch state[1]
04-03 02:06:47.501+0900 D/test-log( 2870): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1249) >  touch is moved upper position!!!
04-03 02:06:47.501+0900 D/test-log( 2870): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1298) >  laundch!!!!! touch position is moved from[91.00][451.00] to[91.00][451.00]!
04-03 02:06:47.501+0900 D/cluster-view( 2870): homescreen-view-manager.cpp: IsOverScrollThreshold(997) >  is Over Scrollview TreshHold?[0]
04-03 02:06:47.501+0900 D/PROCESSMGR( 2697): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x20004e 
04-03 02:06:47.501+0900 D/cluster-home( 2870): mainmenu-custom-box-impl.cpp: OnClicked(171) >  [13]MenuBox clicked
04-03 02:06:47.501+0900 D/cluster-home( 2870): mainmenu-custom-box-impl.cpp: OnClicked(184) >  launch application via service(operation APP_CONTROL_OPERATION_DEFAULT)
04-03 02:06:47.501+0900 D/AUL     ( 2870): service.c: __set_bundle(186) > __set_bundle
04-03 02:06:47.501+0900 D/AUL     ( 2870): service.c: __get_alias_appid(548) > [SECURE_LOG] alias_id : (null)
04-03 02:06:47.501+0900 D/AUL     ( 2870): service.c: __set_bundle(186) > __set_bundle
04-03 02:06:47.501+0900 D/AUL     ( 2870): service.c: __run_svc_with_pkgname(276) > [SECURE_LOG] pkg_name : org.example.example - no result
04-03 02:06:47.501+0900 D/AUL     ( 2870): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : org.example.example
04-03 02:06:47.501+0900 D/AUL     ( 2870): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(0)
04-03 02:06:47.501+0900 D/AUL_AMD ( 2769): amd_request.c: __request_handler(838) > __request_handler: 0
04-03 02:06:47.511+0900 D/AUL_AMD ( 2769): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
04-03 02:06:47.511+0900 W/AUL_AMD ( 2769): amd_launch.c: _start_app(2231) > [SECURE_LOG] caller appid : org.tizen.homescreen
04-03 02:06:47.511+0900 W/AUL_AMD ( 2769): amd_launch.c: _start_app(2233) > caller pid : 2870
04-03 02:06:47.511+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2443) > win(a00002) ecore_x_pointer_grab(1)
04-03 02:06:47.511+0900 D/AUL_AMD ( 2769): amd_key.c: _key_grab(243) > _key_grab, win : a00002
04-03 02:06:47.511+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2448) > back key grab
04-03 02:06:47.511+0900 W/AUL_AMD ( 2769): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
04-03 02:06:47.511+0900 D/RESOURCED( 2852): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
04-03 02:06:47.511+0900 D/RESOURCED( 2852): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 2
04-03 02:06:47.511+0900 E/RESOURCED( 2852): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-03 02:06:47.511+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2518) > org.tizen.system.deviced.PmQos-AppLaunch : 0
04-03 02:06:47.511+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2648) > process_pool: false
04-03 02:06:47.511+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
04-03 02:06:47.511+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
04-03 02:06:47.511+0900 W/AUL_AMD ( 2769): amd_launch.c: _start_app(2665) > pad pid(-5)
04-03 02:06:47.511+0900 D/AUL_AMD ( 2769): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
04-03 02:06:47.511+0900 D/AUL_AMD ( 2769): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
04-03 02:06:47.511+0900 D/AUL     ( 2769): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
04-03 02:06:47.511+0900 D/AUL_PAD ( 2920): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
04-03 02:06:47.511+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
04-03 02:06:47.511+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
04-03 02:06:47.511+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
04-03 02:06:47.511+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
04-03 02:06:47.511+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
04-03 02:06:47.511+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
04-03 02:06:47.511+0900 D/AUL_PAD ( 2920): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
04-03 02:06:47.511+0900 D/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
04-03 02:06:47.511+0900 D/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
04-03 02:06:47.511+0900 D/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
04-03 02:06:47.511+0900 D/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
04-03 02:06:47.511+0900 D/AUL_PAD ( 2920): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
04-03 02:06:47.511+0900 D/AUL_PAD ( 2920): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
04-03 02:06:47.511+0900 W/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
04-03 02:06:47.511+0900 D/AUL     ( 2920): process_pool.c: __send_pkt_raw_data(219) > send(13) : 884 / 884
04-03 02:06:47.511+0900 D/AUL_PAD ( 2920): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 26233, bin path: /opt/usr/apps/org.example.example/bin/example
04-03 02:06:47.511+0900 W/AUL_PAD ( 2920): launchpad.c: __send_result_to_caller(265) > Check app launching
04-03 02:06:47.511+0900 D/AUL_PAD ( 2920): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
04-03 02:06:47.511+0900 D/AUL_PAD (26233): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
04-03 02:06:47.511+0900 D/AUL_PAD (26233): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 884, pkt->len: 876
04-03 02:06:47.511+0900 D/AUL_PAD (26233): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
04-03 02:06:47.511+0900 D/AUL_PAD (26233): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
04-03 02:06:47.511+0900 D/AUL_PAD (26233): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
04-03 02:06:47.511+0900 D/AUL_PAD (26233): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
04-03 02:06:47.511+0900 D/AUL     (26233): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (26255) is sent.
04-03 02:06:47.511+0900 D/AUL     (26233): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 26255, signo: 10
04-03 02:06:47.511+0900 D/AUL     (26233): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
04-03 02:06:47.511+0900 D/AUL_PAD (26233): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
04-03 02:06:47.511+0900 D/AUL_PAD (26233): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
04-03 02:06:47.511+0900 D/AUL_PAD (26233): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
04-03 02:06:47.511+0900 D/AUL_PAD (26233): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
04-03 02:06:47.521+0900 D/AUL_PAD (26233): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : UgAAAAEEAAAUAAAAX19BUFBfU1ZDX09QX1RZUEVfXwAuAAAAaHR0cDovL3RpemVuLm9yZy9hcHBjb250cm9sL29wZXJhdGlvbi9kZWZhdWx0AA==##
04-03 02:06:47.521+0900 D/AUL_PAD (26233): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __APP_SVC_PKG_NAME__##
04-03 02:06:47.521+0900 D/AUL_PAD (26233): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : OQAAAAEEAAAVAAAAX19BUFBfU1ZDX1BLR19OQU1FX18AFAAAAG9yZy5leGFtcGxlLmV4YW1wbGUA##
04-03 02:06:47.521+0900 D/AUL_PAD (26233): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_STARTTIME__##
04-03 02:06:47.521+0900 D/AUL_PAD (26233): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTExNTI4MDcvNTE5MjE0AA==##
04-03 02:06:47.521+0900 D/AUL_PAD (26233): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 8 : __AUL_CALLER_PID__##
04-03 02:06:47.521+0900 D/AUL_PAD (26233): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 9 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAAyODcwAA==##
04-03 02:06:47.521+0900 D/AUL_PAD (26233): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 10 : __AUL_CALLER_APPID__##
04-03 02:06:47.521+0900 D/AUL_PAD (26233): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 11 : OgAAAAEEAAAVAAAAX19BVUxfQ0FMTEVSX0FQUElEX18AFQAAAG9yZy50aXplbi5ob21lc2NyZWVuAA==##
04-03 02:06:47.521+0900 D/AUL_PAD (26233): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 12 : __AUL_INTERNAL_POOL__##
04-03 02:06:47.521+0900 D/AUL_PAD (26233): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 13 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
04-03 02:06:47.521+0900 D/AUL_PAD (26233): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 14
04-03 02:06:47.521+0900 D/AUL_PAD (26233): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
04-03 02:06:47.521+0900 D/AUL_PAD (26233): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
04-03 02:06:47.521+0900 I/CAPI_APPFW_APPLICATION(26233): app_main.c: ui_app_main(788) > app_efl_main
04-03 02:06:47.521+0900 D/LAUNCH  (26233): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
04-03 02:06:47.521+0900 D/APP_CORE(26233): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
04-03 02:06:47.521+0900 D/APP_CORE(26233): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
04-03 02:06:47.521+0900 D/APP_CORE(26233): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
04-03 02:06:47.531+0900 D/APP_CORE(26233): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
04-03 02:06:47.531+0900 D/AUL     (26233): app_sock.c: __create_server_sock(156) > pg path - already exists
04-03 02:06:47.531+0900 D/APP_CORE(26233): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42cd520
04-03 02:06:47.531+0900 D/LAUNCH  (26233): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
04-03 02:06:47.531+0900 I/CAPI_APPFW_APPLICATION(26233): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
04-03 02:06:47.561+0900 E/EFL     (26233): eo<26233> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb889f970 is not pointing to a valid object. Maybe it has already been freed.
04-03 02:06:47.561+0900 E/EFL     (26233): eo<26233> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0xb889f970) is an invalid ref.
04-03 02:06:47.571+0900 W/CRASH_MANAGER(26212): worker.c: worker_job(1204) > 1126233657861149115280
