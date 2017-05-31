S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 8443
Date: 2017-05-30 23:44:12+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xffffffcf

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xfbad8001, esi = 0xb7776f84
ebp = 0xbf803b08, esp = 0xbf8035c8
eax = 0xffffffcf, ebx = 0xb6dfa000
ecx = 0x00002525, edx = 0x25252525
eip = 0xb6cc49c7

Memory Information
MemTotal:      123 KB
MemFree:        10 KB
Buffers:         4 KB
Cached:     232060 KB
VmPeak:     122316 KB
VmSize:     122316 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       35156 KB
VmRSS:       35156 KB
VmData:      52416 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34624 KB
VmPTE:         112 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 8443 TID = 8443
8443 8444 8625 8626 8630 

Maps Information
b0eae000 b0ec6000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b180d000 b1814000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b1817000 b181e000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b189b000 b189f000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2b74000 b2b7e000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b84000 b2b90000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b91000 b2bb2000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2bb7000 b2bb8000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2bb9000 b2bbe000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2bbf000 b2bc0000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2bc1000 b2bc3000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2bc4000 b2bc6000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2bc7000 b2bd3000 r-xp /usr/lib/libdrm.so.2.4.0
b2bd4000 b2bde000 r-xp /usr/lib/libtbm.so.1.0.0
b2bdf000 b2bf4000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2bf5000 b2c07000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3409000 b343a000 r-xp /usr/lib/libidn.so.11.5.44
b343b000 b345d000 r-xp /usr/lib/libnghttp2.so.5.4.0
b345e000 b346e000 r-xp /usr/lib/libcares.so.2.1.0
b346f000 b3478000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3479000 b3482000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3483000 b34fa000 r-xp /usr/lib/libcurl.so.4.3.0
b34fc000 b350e000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b350f000 b3530000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b3537000 b3538000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3539000 b353a000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b353b000 b353e000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b353f000 b3542000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b364a000 b3650000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3651000 b3795000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37a5000 b37a8000 r-xp /usr/lib/libdri2.so.0.0.0
b37a9000 b37aa000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37ab000 b37b5000 r-xp /opt/usr/apps/org.example.example/bin/example
b37b7000 b37f0000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41f3000 b41fe000 r-xp /lib/libnss_files-2.20-2014.11.so
b4200000 b420b000 r-xp /lib/libnss_nis-2.20-2014.11.so
b420d000 b4224000 r-xp /lib/libnsl-2.20-2014.11.so
b4228000 b4230000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4232000 b4256000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4257000 b4258000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4259000 b425c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b425d000 b4264000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4265000 b426f000 r-xp /usr/lib/libsensord-share.so
b4270000 b428c000 r-xp /usr/lib/libsensor.so.1.2.0
b428e000 b4297000 r-xp /usr/lib/libappcore-common.so.1.1
b429a000 b429c000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42b1000 b42b3000 r-xp /usr/lib/libXau.so.6.0.0
b42b4000 b42d6000 r-xp /usr/lib/libxcb.so.1.1.0
b42d8000 b42e1000 r-xp /lib/libcrypt-2.20-2014.11.so
b430a000 b430c000 r-xp /usr/lib/libiri.so
b430d000 b4333000 r-xp /lib/libexpat.so.1.5.2
b4335000 b43a0000 r-xp /usr/lib/libssl.so.1.0.0
b43a6000 b43b2000 r-xp /usr/lib/libethumb.so.1.13.0
b43b3000 b43b7000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43b8000 b4609000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b84000 b5b94000 r-xp /usr/lib/libXi.so.6.1.0
b5b95000 b5b97000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b98000 b5b9e000 r-xp /usr/lib/libXtst.so.6.1.0
b5b9f000 b5ba9000 r-xp /usr/lib/libXrender.so.1.3.0
b5baa000 b5bb3000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bb5000 b5bb7000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bb8000 b5bbd000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bbe000 b5bd0000 r-xp /usr/lib/libXext.so.6.4.0
b5bd1000 b5bd3000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bd4000 b5bd6000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bd8000 b5d1a000 r-xp /usr/lib/libX11.so.6.3.0
b5d1e000 b5d28000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d29000 b5d3f000 r-xp /usr/lib/libudev.so.1.6.0
b5d42000 b5d46000 r-xp /lib/libattr.so.1.1.0
b5d47000 b5d76000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d78000 b5d7e000 r-xp /usr/lib/libffi.so.6.0.2
b5d7f000 b5da2000 r-xp /lib/libz.so.1.2.8
b5da3000 b5da6000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5da7000 b5f03000 r-xp /usr/lib/libxml2.so.2.9.2
b5f09000 b5ff0000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ffd000 b6000000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6001000 b6023000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6024000 b6038000 r-xp /lib/libresolv-2.20-2014.11.so
b603c000 b6060000 r-xp /usr/lib/liblzma.so.5.0.3
b6061000 b6063000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6065000 b606f000 r-xp /usr/lib/libembryo.so.1.13.0
b6070000 b6099000 r-xp /usr/lib/libpng12.so.0.50.0
b609a000 b60e3000 r-xp /usr/lib/libjpeg.so.8.0.2
b60f4000 b60fb000 r-xp /lib/librt-2.20-2014.11.so
b60fd000 b611c000 r-xp /usr/lib/libector.so.1.13.0
b611f000 b614c000 r-xp /usr/lib/liblua-5.1.so
b614d000 b61dd000 r-xp /usr/lib/libfreetype.so.6.11.3
b61e1000 b621f000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6220000 b6236000 r-xp /usr/lib/libfribidi.so.0.3.1
b6237000 b6290000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6293000 b62de000 r-xp /lib/libm-2.20-2014.11.so
b62e0000 b62f2000 r-xp /usr/lib/libeio.so.1.13.0
b62f3000 b62f6000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62f7000 b62fd000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62fe000 b6321000 r-xp /usr/lib/libefreet.so.1.13.0
b6324000 b634f000 r-xp /usr/lib/libeldbus.so.1.13.0
b6350000 b6384000 r-xp /usr/lib/libecore_con.so.1.13.0
b6386000 b638f000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6390000 b6399000 r-xp /usr/lib/libethumb_client.so.1.13.0
b639a000 b63ad000 r-xp /usr/lib/libeo.so.1.13.0
b63af000 b63c2000 r-xp /usr/lib/libecore_input.so.1.13.0
b63c3000 b63ca000 r-xp /usr/lib/libecore_file.so.1.13.0
b63cb000 b63ee000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63ef000 b641b000 r-xp /usr/lib/libeet.so.1.13.0
b6424000 b648f000 r-xp /usr/lib/libeina.so.1.13.0
b6492000 b64a9000 r-xp /usr/lib/libefl.so.1.13.0
b64ab000 b6612000 r-xp /usr/lib/libicuuc.so.51.1
b6620000 b682c000 r-xp /usr/lib/libicui18n.so.51.1
b6834000 b6883000 r-xp /usr/lib/libecore_x.so.1.13.0
b6885000 b689f000 r-xp /lib/libgcc_s-4.9.so.1
b68a1000 b68a5000 r-xp /lib/libcap.so.2.21
b68a6000 b68ec000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68ed000 b68f4000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68f6000 b6948000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b694a000 b6ad5000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6ada000 b6ba8000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bab000 b6baf000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bb0000 b6bbf000 r-xp /usr/lib/libvconf.so.0.2.45
b6bc0000 b6bc3000 r-xp /usr/lib/libvasum.so.0.3.1
b6bc4000 b6bc7000 r-xp /usr/lib/libttrace.so.1.1
b6bc9000 b6bcd000 r-xp /usr/lib/libiniparser.so.0
b6bce000 b6bfe000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bff000 b6c08000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c09000 b6c2e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c2f000 b6c3f000 r-xp /usr/lib/libunwind.so.8.0.1
b6c49000 b6df7000 r-xp /lib/libc-2.20-2014.11.so
b6dff000 b6f42000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f44000 b6f9c000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f9d000 b6fd1000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fd4000 b70a8000 r-xp /usr/lib/libedje.so.1.13.0
b70ab000 b70d7000 r-xp /usr/lib/libecore.so.1.13.0
b70e8000 b730e000 r-xp /usr/lib/libevas.so.1.13.0
b7336000 b734e000 r-xp /lib/libpthread-2.20-2014.11.so
b7352000 b76cc000 r-xp /usr/lib/libelementary.so.1.13.0
b76ec000 b76f0000 r-xp /usr/lib/libsmack.so.1.0.0
b76f1000 b76fa000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76fb000 b76fe000 r-xp /usr/lib/libdlog.so.0.0.0
b76ff000 b7704000 r-xp /usr/lib/libbundle.so.0.1.22
b7705000 b7708000 r-xp /lib/libdl-2.20-2014.11.so
b770a000 b772f000 r-xp /usr/lib/libaul.so.0.1.0
b7732000 b7734000 r-xp /usr/lib/libappsvc.so.0.1.0
b7735000 b773a000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b773b000 b7742000 r-xp /usr/lib/libappcore-efl.so.1.1
b7744000 b7749000 r-xp /usr/lib/libsys-assert.so
b774c000 b774d000 r-xp [vdso]
b774d000 b776f000 r-xp /lib/ld-2.20-2014.11.so
b7771000 b7779000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:8443)
Call Stack Count: 3
 0: strchrnul + 0x17 (0xb6cc49c7) [/lib/libc.so.6] + 0x7b9c7
 1: __vsnprintf_chk + 0xac (0xb6d3e7ac) [/lib/libc.so.6] + 0xf57ac
 2: (0xb75cb7e0) [/usr/lib/libelementary.so.1] + 0x2797e0
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
menu-presenter.cpp: OnAppUpdated(337) >  pAppId [org.example.example]
05-30 23:44:01.792+0900 D/cluster-home( 2892): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.example
05-30 23:44:01.792+0900 D/cluster-home( 2892): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[19], isFolder[0], pageId[1], col[4], row[4], appId[org.example.example], name[forpet], menuId[1], isPreload[0] isPreload[0]
05-30 23:44:01.792+0900 D/cluster-home( 2892): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
05-30 23:44:01.792+0900 E/cluster-home( 2892): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.example] Name[forpet] Icon[/opt/usr/apps/org.example.example/shared/res/1.jpg] enable[1] system[0]
05-30 23:44:01.792+0900 D/cluster-home( 2892): mainmenu-presenter.cpp: OnAppUpdated(364) >  name [forpet]
05-30 23:44:01.792+0900 D/cluster-home( 2892): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
05-30 23:44:01.792+0900 D/cluster-home( 2892): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
05-30 23:44:01.792+0900 D/test-log( 2892): mainmenu-box-impl.cpp: UpdateBoxData(812) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.example/shared/res/1.jpg], New icon path[/opt/usr/apps/org.example.example/shared/res/1.jpg]!!!!!
05-30 23:44:01.792+0900 D/cluster-home( 2892): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 1, appId = $appId, name = $name, col = 4, row = 4, isPreload = 0, isSystem = 0 WHERE boxId = 19]
05-30 23:44:01.792+0900 D/PKGMGR  ( 3172): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-711119321], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-30 23:44:01.792+0900 D/PKGMGR  ( 3172): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-711119321], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-30 23:44:01.792+0900 D/PKGMGR  ( 2787): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[upgrade], req_id=[org.example.example_-711119321], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-30 23:44:01.792+0900 D/AUL_AMD ( 2787): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.example), key(end), value(ok)
05-30 23:44:01.792+0900 W/AUL_AMD ( 2787): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(update), value(ok)
05-30 23:44:01.792+0900 D/PKGMGR  ( 2979): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-711119321], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-30 23:44:01.792+0900 D/PKGMGR  ( 2979): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
05-30 23:44:01.792+0900 D/PKGMGR  ( 2979): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-711119321], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-30 23:44:01.792+0900 D/PKGMGR  ( 2979): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
05-30 23:44:01.792+0900 D/PKGMGR  ( 2967): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-711119321], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-30 23:44:01.792+0900 D/ESD     ( 2967): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29670002), pkg_type(tpk), pkgid(org.example.example), key(install_percent), val(100)
05-30 23:44:01.792+0900 D/PKGMGR  ( 2967): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-711119321], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-30 23:44:01.792+0900 D/ESD     ( 2967): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29670002), pkg_type(tpk), pkgid(org.example.example), key(end), val(ok)
05-30 23:44:01.792+0900 D/ESD     ( 2967): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
05-30 23:44:01.792+0900 D/AUL_AMD ( 2787): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.example, type:rpm
05-30 23:44:01.792+0900 D/PKGMGR  ( 2969): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-711119321], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-30 23:44:01.792+0900 D/PKGMGR  ( 2969): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-711119321], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-30 23:44:01.792+0900 D/PKGMGR  ( 3062): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-711119321], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-30 23:44:01.792+0900 D/PKGMGR  ( 3062): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-711119321], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-30 23:44:01.792+0900 D/ISF_PANEL_EFL( 3062): isf_panel_efl.cpp: _package_manager_event_cb(1288) > type=tpk package=org.example.example event_type=UPDATE event_state=COMPLETED progress=100 error=0
05-30 23:44:01.802+0900 W/ISF_PANEL_EFL( 3062): isf_panel_efl.cpp: _package_manager_event_cb(1380) > isf_db_select_appids_by_pkgid returned 0.
05-30 23:44:01.972+0900 D/rpm-installer( 8568): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
05-30 23:44:01.972+0900 D/rpm-installer( 8568): rpm-appcore-intf.c: main(259) > ------------------------------------------------
05-30 23:44:01.972+0900 D/rpm-installer( 8568): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
05-30 23:44:01.972+0900 D/rpm-installer( 8568): rpm-appcore-intf.c: main(261) > ------------------------------------------------
05-30 23:44:01.992+0900 D/PKGMGR_SERVER( 8479): pkgmgr-server.c: sighandler(387) > child exit [8568]
05-30 23:44:01.992+0900 E/PKGMGR_SERVER( 8479): pkgmgr-server.c: sighandler(402) > child NORMAL exit [8568]
05-30 23:44:01.992+0900 E/PKGMGR_SERVER( 8479): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
05-30 23:44:01.992+0900 E/PKGMGR_SERVER( 8479): pkgmgr-server.c: main(2265) > package manager server terminated.
05-30 23:44:02.622+0900 D/AUL_AMD ( 2787): amd_request.c: __request_handler(838) > __request_handler: 0
05-30 23:44:02.622+0900 D/AUL_AMD ( 2787): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
05-30 23:44:02.622+0900 D/PKGMGR_INFO( 2787): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
05-30 23:44:02.622+0900 D/PKGMGR_INFO( 2787): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
05-30 23:44:02.622+0900 I/AUL     ( 2787): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
05-30 23:44:02.622+0900 D/AUL     ( 2787): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 8619, pid = 8621
05-30 23:44:02.622+0900 D/PKGMGR_INFO( 2787): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
05-30 23:44:02.622+0900 D/PKGMGR_INFO( 2787): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
05-30 23:44:02.622+0900 I/AUL     ( 2787): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
05-30 23:44:02.622+0900 E/AUL_AMD ( 2787): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
05-30 23:44:02.622+0900 W/AUL_AMD ( 2787): amd_launch.c: _start_app(2233) > caller pid : 8621
05-30 23:44:02.622+0900 E/AUL_AMD ( 2787): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
05-30 23:44:02.632+0900 W/AUL_AMD ( 2787): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
05-30 23:44:02.632+0900 D/AUL_AMD ( 2787): amd_launch.c: _start_app(2648) > process_pool: false
05-30 23:44:02.632+0900 D/AUL_AMD ( 2787): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
05-30 23:44:02.632+0900 D/AUL_AMD ( 2787): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
05-30 23:44:02.632+0900 W/AUL_AMD ( 2787): amd_launch.c: _start_app(2665) > pad pid(-5)
05-30 23:44:02.632+0900 D/AUL_AMD ( 2787): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
05-30 23:44:02.632+0900 D/AUL_AMD ( 2787): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
05-30 23:44:02.632+0900 D/AUL     ( 2787): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
05-30 23:44:02.632+0900 D/AUL_PAD ( 2955): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
05-30 23:44:02.632+0900 D/AUL_PAD ( 2955): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
05-30 23:44:02.632+0900 D/AUL_PAD ( 2955): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-30 23:44:02.632+0900 D/AUL_PAD ( 2955): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-30 23:44:02.632+0900 D/AUL_PAD ( 2955): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-30 23:44:02.632+0900 D/AUL_PAD ( 2955): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-30 23:44:02.632+0900 D/AUL_PAD ( 2955): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-30 23:44:02.632+0900 D/AUL_PAD ( 2955): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
05-30 23:44:02.632+0900 D/AUL_PAD ( 2955): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
05-30 23:44:02.632+0900 D/AUL_PAD ( 2955): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
05-30 23:44:02.632+0900 D/AUL_PAD ( 2955): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
05-30 23:44:02.632+0900 D/AUL_PAD ( 2955): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
05-30 23:44:02.632+0900 D/AUL_PAD ( 2955): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
05-30 23:44:02.632+0900 D/AUL_PAD ( 2955): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
05-30 23:44:02.632+0900 W/AUL_PAD ( 2955): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
05-30 23:44:02.632+0900 D/AUL     ( 2955): process_pool.c: __send_pkt_raw_data(219) > send(13) : 620 / 620
05-30 23:44:02.632+0900 D/AUL_PAD ( 2955): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 8443, bin path: /opt/usr/apps/org.example.example/bin/example
05-30 23:44:02.632+0900 W/AUL_PAD ( 2955): launchpad.c: __send_result_to_caller(265) > Check app launching
05-30 23:44:02.632+0900 D/AUL_PAD ( 2955): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
05-30 23:44:02.632+0900 D/AUL_PAD ( 8443): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
05-30 23:44:02.632+0900 D/AUL_PAD ( 8443): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
05-30 23:44:02.632+0900 D/AUL_PAD ( 8443): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
05-30 23:44:02.632+0900 D/AUL_PAD ( 8443): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
05-30 23:44:02.632+0900 D/AUL_PAD ( 8443): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
05-30 23:44:02.632+0900 D/AUL_PAD ( 8443): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
05-30 23:44:02.632+0900 D/AUL     ( 8443): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (8444) is sent.
05-30 23:44:02.632+0900 D/RESOURCED( 2880): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
05-30 23:44:02.632+0900 D/RESOURCED( 2880): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
05-30 23:44:02.632+0900 E/RESOURCED( 2880): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
05-30 23:44:02.632+0900 D/AUL     ( 8443): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 8444, signo: 10
05-30 23:44:02.632+0900 D/AUL     ( 8443): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
05-30 23:44:02.632+0900 D/AUL_PAD ( 8443): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
05-30 23:44:02.632+0900 D/AUL_PAD ( 8443): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
05-30 23:44:02.632+0900 D/AUL_PAD ( 8443): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
05-30 23:44:02.632+0900 D/AUL_PAD ( 8443): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
05-30 23:44:02.632+0900 D/AUL_PAD ( 8443): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTYxNTU0NDIvNjM0NDg2AA==##
05-30 23:44:02.632+0900 D/AUL_PAD ( 8443): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
05-30 23:44:02.632+0900 D/AUL_PAD ( 8443): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA4NjIxAA==##
05-30 23:44:02.632+0900 D/AUL_PAD ( 8443): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
05-30 23:44:02.632+0900 D/AUL_PAD ( 8443): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
05-30 23:44:02.632+0900 D/AUL_PAD ( 8443): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
05-30 23:44:02.632+0900 D/AUL_PAD ( 8443): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
05-30 23:44:02.632+0900 D/AUL_PAD ( 8443): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
05-30 23:44:02.632+0900 I/CAPI_APPFW_APPLICATION( 8443): app_main.c: ui_app_main(788) > app_efl_main
05-30 23:44:02.632+0900 D/LAUNCH  ( 8443): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
05-30 23:44:02.632+0900 D/APP_CORE( 8443): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
05-30 23:44:02.632+0900 D/APP_CORE( 8443): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
05-30 23:44:02.632+0900 D/APP_CORE( 8443): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
05-30 23:44:02.652+0900 D/APP_CORE( 8443): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
05-30 23:44:02.652+0900 D/AUL     ( 8443): app_sock.c: __create_server_sock(156) > pg path - already exists
05-30 23:44:02.652+0900 D/APP_CORE( 8443): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb4297520
05-30 23:44:02.652+0900 D/LAUNCH  ( 8443): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
05-30 23:44:02.652+0900 I/CAPI_APPFW_APPLICATION( 8443): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
05-30 23:44:02.732+0900 D/AUL_PAD ( 2955): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
05-30 23:44:02.732+0900 W/AUL     ( 2787): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 8443, appid: org.example.example
05-30 23:44:02.732+0900 D/AUL     ( 2787): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
05-30 23:44:02.732+0900 E/AUL     ( 2787): simple_util.c: __trm_app_info_send_socket(330) > access
05-30 23:44:02.732+0900 D/AUL_AMD ( 2787): amd_launch.c: _start_app(2700) > add app group info
05-30 23:44:02.732+0900 E/AUL     ( 2787): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
05-30 23:44:02.732+0900 D/AUL_AMD ( 2787): amd_status.c: _status_add_app_info_list(427) > pid(8443) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
05-30 23:44:02.732+0900 D/RESOURCED( 2880): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 8443
05-30 23:44:02.732+0900 D/RESOURCED( 2880): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
05-30 23:44:02.732+0900 E/RESOURCED( 2880): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
05-30 23:44:02.732+0900 D/RESOURCED( 2880): proc-main.c: resourced_proc_status_change(888) > available memory = 303
05-30 23:44:02.772+0900 D/LAUNCH  ( 8443): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
05-30 23:44:02.772+0900 D/APP_CORE( 8443): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
05-30 23:44:02.772+0900 E/E17     ( 2739): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02000002)
05-30 23:44:02.822+0900 E/E17     ( 2739): e_border.c: e_border_show(2088) > BD_SHOW(0x02000002)
05-30 23:44:02.842+0900 D/APP_CORE( 8443): appcore.c: __aul_handler(587) > [APP 8443]     AUL event: AUL_START
05-30 23:44:02.842+0900 I/APP_CORE( 8443): appcore-efl.c: __do_app(496) > [APP 8443] Event: RESET State: CREATED
05-30 23:44:02.842+0900 D/APP_CORE( 8443): appcore-efl.c: __do_app(527) > [APP 8443] RESET
05-30 23:44:02.852+0900 D/LAUNCH  ( 8443): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
05-30 23:44:02.852+0900 D/APP_CORE( 8443): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
05-30 23:44:02.852+0900 D/APP_CORE( 8443): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-30 23:44:02.852+0900 I/CAPI_APPFW_APPLICATION( 8443): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
05-30 23:44:02.852+0900 D/AUL     ( 8443): service.c: __set_bundle(186) > __set_bundle
05-30 23:44:02.852+0900 D/LAUNCH  ( 8443): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
05-30 23:44:02.852+0900 D/APP_CORE( 8443): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
05-30 23:44:02.852+0900 E/EFL     ( 8443): edje<8443> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-30 23:44:02.852+0900 E/EFL     ( 8443): By the power of Grayskull, your previous Embryo stack is now broken!
05-30 23:44:02.862+0900 E/EFL     ( 8443): edje<8443> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-30 23:44:02.862+0900 E/EFL     ( 8443): By the power of Grayskull, your previous Embryo stack is now broken!
05-30 23:44:02.862+0900 E/EFL     ( 8443): edje<8443> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-30 23:44:02.862+0900 E/EFL     ( 8443): By the power of Grayskull, your previous Embryo stack is now broken!
05-30 23:44:02.862+0900 E/EFL     ( 8443): edje<8443> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-30 23:44:02.862+0900 E/EFL     ( 8443): By the power of Grayskull, your previous Embryo stack is now broken!
05-30 23:44:02.862+0900 E/EFL     ( 8443): edje<8443> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-30 23:44:02.862+0900 E/EFL     ( 8443): By the power of Grayskull, your previous Embryo stack is now broken!
05-30 23:44:02.872+0900 W/APP_CORE( 8443): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2000002
05-30 23:44:02.872+0900 W/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=8443
05-30 23:44:02.872+0900 D/APP_CORE( 8443): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2000002
05-30 23:44:02.872+0900 D/APP_CORE( 8443): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
05-30 23:44:02.872+0900 D/AUL     ( 8443): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
05-30 23:44:02.872+0900 D/AUL_AMD ( 2787): amd_request.c: __request_handler(838) > __request_handler: 34
05-30 23:44:02.892+0900 E/EFL     ( 2739): eo<2739> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-30 23:44:02.892+0900 E/EFL     ( 2739): eo<2739> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-30 23:44:02.912+0900 D/INDICATOR( 2886): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
05-30 23:44:02.922+0900 D/AUL_AMD ( 2787): amd_request.c: __request_handler(838) > __request_handler: 15
05-30 23:44:02.922+0900 D/PKGMGR_INFO( 2787): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-30 23:44:02.922+0900 D/PKGMGR_INFO( 2787): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-30 23:44:02.922+0900 D/AUL_AMD ( 2787): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 8443 is org.example.example
05-30 23:44:02.922+0900 D/AUL_AMD ( 2787): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 8443 : 0
05-30 23:44:02.922+0900 D/AUL     ( 2969): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
05-30 23:44:02.932+0900 D/INDICATOR( 2886): util.c: util_signal_emit_by_win(116) > emission bg.opaque
05-30 23:44:02.932+0900 D/INDICATOR( 2886): main.c: _rotate_window(229) > Indicator angle is 0 degree
05-30 23:44:02.932+0900 D/INDICATOR( 2886): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
05-30 23:44:02.932+0900 D/INDICATOR( 2886): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
05-30 23:44:02.932+0900 D/INDICATOR( 2886): main.c: _rotate_window(252) > port :: hide more icon
05-30 23:44:03.142+0900 D/APP_CORE( 8443): appcore.c: __prt_ltime(236) > [APP 8443] first idle after reset: 520 msec
05-30 23:44:03.282+0900 E/E17     ( 2739): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
05-30 23:44:03.282+0900 D/APP_CORE( 2892): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
05-30 23:44:03.282+0900 D/APP_CORE( 2892): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
05-30 23:44:03.282+0900 D/APP_CORE( 2892): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
05-30 23:44:03.282+0900 I/APP_CORE( 2892): appcore-efl.c: __do_app(496) > [APP 2892] Event: PAUSE State: RUNNING
05-30 23:44:03.282+0900 D/APP_CORE( 2892): appcore-efl.c: __do_app(565) > [APP 2892] PAUSE
05-30 23:44:03.282+0900 I/CAPI_APPFW_APPLICATION( 2892): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
05-30 23:44:03.282+0900 E/cluster-home( 2892): homescreen.cpp: OnPause(84) >  app pause
05-30 23:44:03.282+0900 D/cluster-view( 2892): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
05-30 23:44:03.282+0900 D/cluster-view( 2892): homescreen-view-manager.cpp: AppPause(923) >  END
05-30 23:44:03.282+0900 D/APP_CORE( 2892): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-30 23:44:03.282+0900 E/APP_CORE( 2892): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-30 23:44:03.282+0900 D/APP_CORE( 8443): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2000002 fully_obscured 0
05-30 23:44:03.282+0900 D/APP_CORE( 8443): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
05-30 23:44:03.282+0900 D/APP_CORE( 8443): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
05-30 23:44:03.282+0900 I/APP_CORE( 8443): appcore-efl.c: __do_app(496) > [APP 8443] Event: RESUME State: CREATED
05-30 23:44:03.282+0900 D/LAUNCH  ( 8443): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
05-30 23:44:03.282+0900 D/APP_CORE( 8443): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
05-30 23:44:03.282+0900 D/APP_CORE( 8443): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-30 23:44:03.282+0900 D/APP_CORE( 8443): appcore-efl.c: __do_app(607) > [APP 8443] RESUME
05-30 23:44:03.292+0900 I/APP_CORE( 8443): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
05-30 23:44:03.292+0900 D/AUL_AMD ( 2787): amd_status.c: _status_update_app_info_list(456) > pid(2892) status(4)
05-30 23:44:03.292+0900 D/AUL_AMD ( 2787): amd_status.c: _status_update_app_info_list(468) > pid(2892) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
05-30 23:44:03.292+0900 D/AUL     ( 2787): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
05-30 23:44:03.292+0900 W/AUL     ( 2787): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2892, appid: org.tizen.homescreen, status: bg
05-30 23:44:03.292+0900 I/APP_CORE( 8443): appcore-efl.c: __do_app(614) > [APP 8443] Initial Launching, call the resume_cb
05-30 23:44:03.292+0900 D/AUL_AMD ( 2787): amd_launch.c: __e17_status_handler(2891) > pid(8443) status(3)
05-30 23:44:03.292+0900 I/CAPI_APPFW_APPLICATION( 8443): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
05-30 23:44:03.292+0900 D/LAUNCH  ( 8443): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
05-30 23:44:03.292+0900 D/LAUNCH  ( 8443): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
05-30 23:44:03.292+0900 D/APP_CORE( 8443): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-30 23:44:03.292+0900 E/APP_CORE( 8443): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-30 23:44:03.292+0900 D/AUL_AMD ( 2787): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
05-30 23:44:03.302+0900 W/AUL_AMD ( 2787): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-30 23:44:03.302+0900 W/AUL_AMD ( 2787): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
05-30 23:44:03.302+0900 D/AUL_AMD ( 2787): amd_status.c: _status_update_app_info_list(456) > pid(8443) status(3)
05-30 23:44:03.302+0900 D/AUL_AMD ( 2787): amd_status.c: _status_update_app_info_list(468) > pid(8443) appid(org.example.example) pkgid(org.example.example) status(3)
05-30 23:44:03.302+0900 D/AUL     ( 2787): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
05-30 23:44:03.302+0900 W/AUL     ( 2787): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 8443, appid: org.example.example, status: fg
05-30 23:44:03.302+0900 D/RESOURCED( 2880): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 8443
05-30 23:44:03.312+0900 D/DATA_PROVIDER_MASTER( 2957): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2892 is paused
05-30 23:44:03.312+0900 D/DATA_PROVIDER_MASTER( 2957): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
05-30 23:44:03.312+0900 I/CAPI_WIDGET_APPLICATION( 3050): widget_app.c: __provider_pause_cb(294) > widget obj was paused
05-30 23:44:03.312+0900 I/CAPI_WIDGET_APPLICATION( 3050): widget_app.c: __check_status_for_cgroup(142) > enter background group
05-30 23:44:03.312+0900 W/AUL     ( 3050): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3050, appid: org.tizen.calendar.widget, status: bg
05-30 23:44:03.312+0900 D/RESOURCED( 2880): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 8443, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
05-30 23:44:03.312+0900 D/RESOURCED( 2880): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 8443
05-30 23:44:03.392+0900 D/RESOURCED( 2880): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 8443, appname = org.example.example, pkgname = org.example.example
05-30 23:44:03.392+0900 D/RESOURCED( 2880): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 8443, appname = org.example.example
05-30 23:44:03.392+0900 D/RESOURCED( 2880): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 8443
05-30 23:44:03.392+0900 I/RESOURCED( 2880): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
05-30 23:44:03.392+0900 I/RESOURCED( 2880): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
05-30 23:44:03.392+0900 D/RESOURCED( 2880): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3050, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
05-30 23:44:03.392+0900 D/RESOURCED( 2880): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3050
05-30 23:44:03.392+0900 D/RESOURCED( 2880): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3050, appname = org.tizen.calendar.widget
05-30 23:44:03.392+0900 D/RESOURCED( 2880): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3050
05-30 23:44:03.442+0900 D/AUL_AMD ( 2787): amd_launch.c: __e17_status_handler(2910) > pid(8443) status(0)
05-30 23:44:03.732+0900 D/AUL_PAD ( 2955): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
05-30 23:44:03.742+0900 D/AUL_PAD ( 8628): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
05-30 23:44:03.792+0900 D/AUL_PAD ( 2955): sigchild.h: __send_app_launch_signal(131) > send launch signal done
05-30 23:44:03.802+0900 E/RESOURCED( 2880): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.613
05-30 23:44:04.242+0900 D/AUL_AMD ( 2787): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
05-30 23:44:04.242+0900 D/RUA     ( 2787): rua.c: rua_add_history(179) > rua_add_history start
05-30 23:44:04.332+0900 D/RUA     ( 2787): rua.c: rua_add_history(247) > rua_add_history ok
05-30 23:44:04.412+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x60136c 
05-30 23:44:04.822+0900 D/AUL_PAD ( 8628): launchpad_loader.c: main(588) > sleeping 1 sec...
05-30 23:44:04.822+0900 D/AUL_PAD ( 8628): preload.h: __preload_init(52) > max_cmdline_size = 1053
05-30 23:44:04.832+0900 D/AUL_PAD ( 8628): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b7fa8760
05-30 23:44:04.832+0900 D/AUL_PAD ( 8628): preload.h: __preload_init(69) > get pre-initialization function
05-30 23:44:04.832+0900 D/AUL_PAD ( 8628): preload.h: __preload_init(73) > get shutdown function
05-30 23:44:04.832+0900 D/AUL_PAD ( 8628): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b7fa8a40
05-30 23:44:04.832+0900 D/AUL_PAD ( 8628): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b7faa640
05-30 23:44:04.832+0900 D/AUL_PAD ( 8628): preload.h: __preload_init(69) > get pre-initialization function
05-30 23:44:04.832+0900 D/AUL_PAD ( 8628): preload.h: __preload_init(73) > get shutdown function
05-30 23:44:04.832+0900 D/AUL_PAD ( 8628): preexec.h: __preexec_init(76) > preexec start
05-30 23:44:04.832+0900 D/AUL_PAD ( 8628): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
05-30 23:44:04.832+0900 D/AUL     ( 8628): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
05-30 23:44:04.832+0900 D/AUL     ( 8628): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
05-30 23:44:04.832+0900 D/AUL     ( 8628): process_pool.c: __connect_to_launchpad(132) > send(8628) : 4
05-30 23:44:04.832+0900 D/AUL     ( 8628): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
05-30 23:44:04.842+0900 D/AUL_PAD ( 2955): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-30 23:44:04.842+0900 D/AUL_PAD ( 2955): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
05-30 23:44:04.842+0900 D/AUL_PAD ( 2955): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-30 23:44:04.842+0900 D/AUL_PAD ( 2955): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-30 23:44:04.842+0900 D/AUL_PAD ( 2955): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-30 23:44:04.842+0900 D/AUL_PAD ( 2955): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-30 23:44:04.842+0900 D/AUL_PAD ( 2955): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-30 23:44:04.842+0900 D/AUL_PAD ( 2955): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
05-30 23:44:04.842+0900 D/AUL_PAD ( 2955): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 8628
05-30 23:44:05.032+0900 D/AUL_PAD ( 8628): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
05-30 23:44:05.042+0900 D/AUL_PAD ( 8628): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
05-30 23:44:05.042+0900 D/AUL_PAD ( 8628): launchpad_loader.c: main(693) > [candidate] ecore handler add
05-30 23:44:05.052+0900 D/AUL_PAD ( 8628): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
05-30 23:44:05.432+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2000002
05-30 23:44:05.562+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x60136c 
05-30 23:44:05.772+0900 E/EFL     ( 8443): edje<8443> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-30 23:44:05.782+0900 E/EFL     ( 8443): edje<8443> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-30 23:44:05.842+0900 E/EFL     ( 8443): edje<8443> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-30 23:44:05.852+0900 E/EFL     ( 8443): edje<8443> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-30 23:44:05.852+0900 E/EFL     ( 8443): edje<8443> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-30 23:44:05.852+0900 E/EFL     ( 8443): edje<8443> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-30 23:44:05.852+0900 E/EFL     ( 8443): edje<8443> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-30 23:44:05.862+0900 E/EFL     ( 8443): edje<8443> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-30 23:44:05.862+0900 E/EFL     ( 8443): edje<8443> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-30 23:44:05.872+0900 D/IMMODULE( 8443): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
05-30 23:44:05.872+0900 D/ISF_SOCKET( 8443): scim_socket.cpp: connect(515) > ppid:2955  trying connect() to local:/tmp/scim-socket-frontend, example
05-30 23:44:05.872+0900 D/ISF_SOCKET( 8443): scim_socket.cpp: connect(524) > connect() succeeded
05-30 23:44:05.882+0900 D/ISF_SOCKET( 8443): scim_socket.cpp: connect(515) > ppid:2955  trying connect() to local:/tmp/scim-socket-frontend, example
05-30 23:44:05.882+0900 D/ISF_SOCKET( 8443): scim_socket.cpp: connect(524) > connect() succeeded
05-30 23:44:05.952+0900 D/ISF_SOCKET( 8443): scim_socket.cpp: connect(515) > ppid:2955  trying connect() to local:/tmp/scim-socket-frontend, example
05-30 23:44:05.962+0900 D/ISF_SOCKET( 8443): scim_socket.cpp: connect(524) > connect() succeeded
05-30 23:44:05.962+0900 D/ISF_QUERY( 8443): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
05-30 23:44:05.972+0900 D/ISF_QUERY( 8443): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-30 23:44:05.972+0900 D/ISF_QUERY( 8443): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-30 23:44:05.972+0900 D/ISF_QUERY( 8443): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-30 23:44:05.972+0900 D/ISF_QUERY( 8443): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-30 23:44:05.972+0900 D/ISF_QUERY( 8443): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-30 23:44:05.972+0900 D/ISF_QUERY( 8443): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-30 23:44:05.972+0900 D/ISF_SOCKET( 8443): scim_socket.cpp: connect(515) > ppid:2955  trying connect() to local:/tmp/scim-socket-frontend, example
05-30 23:44:05.972+0900 D/ISF_SOCKET( 8443): scim_socket.cpp: connect(524) > connect() succeeded
05-30 23:44:05.982+0900 D/IMMODULE( 8443): scim_panel_client.cpp: open_connection(162) > 
05-30 23:44:05.982+0900 D/ISF_SOCKET( 8443): scim_socket.cpp: connect(515) > ppid:2955  trying connect() to local:/tmp/scim-panel-socket:0, example
05-30 23:44:05.982+0900 D/ISF_SOCKET( 8443): scim_socket.cpp: connect(524) > connect() succeeded
05-30 23:44:05.992+0900 D/ISF_SOCKET( 8443): scim_socket.cpp: connect(515) > ppid:2955  trying connect() to local:/tmp/scim-panel-socket:0, example
05-30 23:44:05.992+0900 D/ISF_SOCKET( 8443): scim_socket.cpp: connect(524) > connect() succeeded
05-30 23:44:06.022+0900 D/IMMODULE( 8443): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 1
05-30 23:44:07.122+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x60136c 
05-30 23:44:07.212+0900 E/EFL     ( 8443): edje<8443> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
05-30 23:44:07.212+0900 E/EFL     ( 8443): By the power of Grayskull, your previous Embryo stack is now broken!
05-30 23:44:08.292+0900 D/APP_CORE( 2892): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
05-30 23:44:08.292+0900 I/APP_CORE( 2892): appcore-efl.c: __do_app(496) > [APP 2892] Event: MEM_FLUSH State: PAUSED
05-30 23:44:08.292+0900 D/APP_CORE( 2892): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
05-30 23:44:08.292+0900 D/RESOURCED( 2880): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2892
05-30 23:44:08.302+0900 D/APP_CORE( 2892): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2892
05-30 23:44:08.302+0900 D/APP_CORE( 2892): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
05-30 23:44:09.212+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x60136c 
05-30 23:44:10.132+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x60136c 
05-30 23:44:10.472+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x60136c bd->visible=1
05-30 23:44:11.062+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x60136c 
05-30 23:44:12.122+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x60136c 
05-30 23:44:12.242+0900 E/EFL     ( 8443): edje<8443> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
05-30 23:44:12.242+0900 E/EFL     ( 8443): By the power of Grayskull, your previous Embryo stack is now broken!
05-30 23:44:12.702+0900 D/AUL_PAD ( 2955): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-30 23:44:12.702+0900 D/AUL_PAD ( 2955): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
05-30 23:44:12.702+0900 D/AUL_PAD ( 2955): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-30 23:44:12.702+0900 D/AUL_PAD ( 2955): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-30 23:44:12.702+0900 D/AUL_PAD ( 2955): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-30 23:44:12.702+0900 D/AUL_PAD ( 2955): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-30 23:44:12.702+0900 D/AUL_PAD ( 2955): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-30 23:44:12.702+0900 I/AUL_PAD ( 2955): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 8443 pgid = 8443
05-30 23:44:12.702+0900 I/AUL_PAD ( 2955): sigchild.h: __sigchild_action(142) > dead_pid(8443)
05-30 23:44:12.742+0900 E/EFL     ( 2739): eo<2739> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-30 23:44:12.742+0900 D/AUL_PAD ( 2955): sigchild.h: __send_app_dead_signal(90) > send dead signal done
05-30 23:44:12.742+0900 I/AUL_PAD ( 2955): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
05-30 23:44:12.742+0900 I/AUL_PAD ( 2955): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
05-30 23:44:12.742+0900 E/AUL_PAD ( 2955): launchpad.c: main(688) > error reading sigchld info
05-30 23:44:12.742+0900 W/CRASH_MANAGER( 8631): worker.c: worker_job(1204) > 1108443657861149615545
