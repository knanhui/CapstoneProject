S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 10082
Date: 2017-06-01 14:11:32+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x8000aa56, esi = 0xb3806590
ebp = 0xbfc0bef8, esp = 0xbfc0ad80
eax = 0x00000000, ebx = 0xb380a000
ecx = 0xb42f1010, edx = 0x00000002
eip = 0xb38064af

Memory Information
MemTotal:      123 KB
MemFree:        32 KB
Buffers:         8 KB
Cached:     164908 KB
VmPeak:      81140 KB
VmSize:      81140 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16216 KB
VmRSS:       16216 KB
VmData:      20052 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34460 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 10082 TID = 10082
10082 10083 10242 

Maps Information
b2bc7000 b2bd1000 r-xp /usr/lib/libfeedback.so.0.1.4
b2bd7000 b2be3000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2be4000 b2c05000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2c0a000 b2c0b000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2c0c000 b2c11000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2c12000 b2c13000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2c14000 b2c16000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c17000 b2c23000 r-xp /usr/lib/libdrm.so.2.4.0
b2c24000 b2c27000 r-xp /usr/lib/libdri2.so.0.0.0
b2c28000 b2c32000 r-xp /usr/lib/libtbm.so.1.0.0
b2c33000 b2c48000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c49000 b2c5b000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b345d000 b348e000 r-xp /usr/lib/libidn.so.11.5.44
b348f000 b34b1000 r-xp /usr/lib/libnghttp2.so.5.4.0
b34b2000 b34c2000 r-xp /usr/lib/libcares.so.2.1.0
b34c3000 b34cc000 r-xp /usr/lib/libeventsystem.so.0.0.1
b34cd000 b34d6000 r-xp /usr/lib/libefl-extension.so.0.1.0
b34d7000 b354e000 r-xp /usr/lib/libcurl.so.4.3.0
b3550000 b3562000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3563000 b3584000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b358b000 b358c000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b358d000 b358e000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b358f000 b3592000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3593000 b3596000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b369e000 b36a4000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b36a5000 b37e9000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37f9000 b37fb000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b37fc000 b37fd000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37fe000 b3809000 r-xp /opt/usr/apps/org.example.example/bin/example
b380b000 b3844000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4247000 b4252000 r-xp /lib/libnss_files-2.20-2014.11.so
b4254000 b425f000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4261000 b4278000 r-xp /lib/libnsl-2.20-2014.11.so
b427c000 b4284000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4286000 b42aa000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b42ab000 b42ac000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b42ad000 b42b0000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42b1000 b42b8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42b9000 b42c3000 r-xp /usr/lib/libsensord-share.so
b42c4000 b42e0000 r-xp /usr/lib/libsensor.so.1.2.0
b42e2000 b42eb000 r-xp /usr/lib/libappcore-common.so.1.1
b42ee000 b42f0000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4305000 b4307000 r-xp /usr/lib/libXau.so.6.0.0
b4308000 b432a000 r-xp /usr/lib/libxcb.so.1.1.0
b432c000 b4335000 r-xp /lib/libcrypt-2.20-2014.11.so
b435e000 b4360000 r-xp /usr/lib/libiri.so
b4361000 b4387000 r-xp /lib/libexpat.so.1.5.2
b4389000 b43f4000 r-xp /usr/lib/libssl.so.1.0.0
b43fa000 b4406000 r-xp /usr/lib/libethumb.so.1.13.0
b4407000 b440b000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b440c000 b465d000 r-xp /usr/lib/libcrypto.so.1.0.0
b5bd8000 b5be8000 r-xp /usr/lib/libXi.so.6.1.0
b5be9000 b5beb000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bec000 b5bf2000 r-xp /usr/lib/libXtst.so.6.1.0
b5bf3000 b5bfd000 r-xp /usr/lib/libXrender.so.1.3.0
b5bfe000 b5c07000 r-xp /usr/lib/libXrandr.so.2.2.0
b5c09000 b5c0b000 r-xp /usr/lib/libXinerama.so.1.0.0
b5c0c000 b5c11000 r-xp /usr/lib/libXfixes.so.3.1.0
b5c12000 b5c24000 r-xp /usr/lib/libXext.so.6.4.0
b5c25000 b5c27000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c28000 b5c2a000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c2c000 b5d6e000 r-xp /usr/lib/libX11.so.6.3.0
b5d72000 b5d7c000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d7d000 b5d93000 r-xp /usr/lib/libudev.so.1.6.0
b5d96000 b5d9a000 r-xp /lib/libattr.so.1.1.0
b5d9b000 b5dca000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5dcc000 b5dd2000 r-xp /usr/lib/libffi.so.6.0.2
b5dd3000 b5df6000 r-xp /lib/libz.so.1.2.8
b5df7000 b5dfa000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5dfb000 b5f57000 r-xp /usr/lib/libxml2.so.2.9.2
b5f5d000 b6044000 r-xp /usr/lib/libstdc++.so.6.0.20
b6051000 b6054000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6055000 b6077000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6078000 b608c000 r-xp /lib/libresolv-2.20-2014.11.so
b6090000 b60b4000 r-xp /usr/lib/liblzma.so.5.0.3
b60b5000 b60b7000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b60b9000 b60c3000 r-xp /usr/lib/libembryo.so.1.13.0
b60c4000 b60ed000 r-xp /usr/lib/libpng12.so.0.50.0
b60ee000 b6137000 r-xp /usr/lib/libjpeg.so.8.0.2
b6148000 b614f000 r-xp /lib/librt-2.20-2014.11.so
b6151000 b6170000 r-xp /usr/lib/libector.so.1.13.0
b6173000 b61a0000 r-xp /usr/lib/liblua-5.1.so
b61a1000 b6231000 r-xp /usr/lib/libfreetype.so.6.11.3
b6235000 b6273000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6274000 b628a000 r-xp /usr/lib/libfribidi.so.0.3.1
b628b000 b62e4000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62e7000 b6332000 r-xp /lib/libm-2.20-2014.11.so
b6334000 b6346000 r-xp /usr/lib/libeio.so.1.13.0
b6347000 b634a000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b634b000 b6351000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6352000 b6375000 r-xp /usr/lib/libefreet.so.1.13.0
b6378000 b63a3000 r-xp /usr/lib/libeldbus.so.1.13.0
b63a4000 b63d8000 r-xp /usr/lib/libecore_con.so.1.13.0
b63da000 b63e3000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63e4000 b63ed000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63ee000 b6401000 r-xp /usr/lib/libeo.so.1.13.0
b6403000 b6416000 r-xp /usr/lib/libecore_input.so.1.13.0
b6417000 b641e000 r-xp /usr/lib/libecore_file.so.1.13.0
b641f000 b6442000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6443000 b646f000 r-xp /usr/lib/libeet.so.1.13.0
b6478000 b64e3000 r-xp /usr/lib/libeina.so.1.13.0
b64e6000 b64fd000 r-xp /usr/lib/libefl.so.1.13.0
b64ff000 b6666000 r-xp /usr/lib/libicuuc.so.51.1
b6674000 b6880000 r-xp /usr/lib/libicui18n.so.51.1
b6888000 b68d7000 r-xp /usr/lib/libecore_x.so.1.13.0
b68d9000 b68f3000 r-xp /lib/libgcc_s-4.9.so.1
b68f5000 b68f9000 r-xp /lib/libcap.so.2.21
b68fa000 b6940000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6941000 b6948000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b694a000 b699c000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b699e000 b6b29000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b2e000 b6bfc000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bff000 b6c03000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6c04000 b6c13000 r-xp /usr/lib/libvconf.so.0.2.45
b6c14000 b6c17000 r-xp /usr/lib/libvasum.so.0.3.1
b6c18000 b6c1b000 r-xp /usr/lib/libttrace.so.1.1
b6c1d000 b6c21000 r-xp /usr/lib/libiniparser.so.0
b6c22000 b6c52000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c53000 b6c5c000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c5d000 b6c82000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c83000 b6c93000 r-xp /usr/lib/libunwind.so.8.0.1
b6c9d000 b6e4b000 r-xp /lib/libc-2.20-2014.11.so
b6e53000 b6f96000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f98000 b6ff0000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6ff1000 b7025000 r-xp /usr/lib/libsystemd.so.0.4.0
b7028000 b70fc000 r-xp /usr/lib/libedje.so.1.13.0
b70ff000 b712b000 r-xp /usr/lib/libecore.so.1.13.0
b713c000 b7362000 r-xp /usr/lib/libevas.so.1.13.0
b738a000 b73a2000 r-xp /lib/libpthread-2.20-2014.11.so
b73a6000 b7720000 r-xp /usr/lib/libelementary.so.1.13.0
b7740000 b7744000 r-xp /usr/lib/libsmack.so.1.0.0
b7745000 b774e000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b774f000 b7752000 r-xp /usr/lib/libdlog.so.0.0.0
b7753000 b7758000 r-xp /usr/lib/libbundle.so.0.1.22
b7759000 b775c000 r-xp /lib/libdl-2.20-2014.11.so
b775e000 b7783000 r-xp /usr/lib/libaul.so.0.1.0
b7786000 b7788000 r-xp /usr/lib/libappsvc.so.0.1.0
b7789000 b778e000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b778f000 b7796000 r-xp /usr/lib/libappcore-efl.so.1.1
b7798000 b779d000 r-xp /usr/lib/libsys-assert.so
b77a0000 b77a1000 r-xp [vdso]
b77a1000 b77c3000 r-xp /lib/ld-2.20-2014.11.so
b77c5000 b77cd000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:10082)
Call Stack Count: 8
 0: create_base_gui + 0xc2f (0xb38064af) [/opt/usr/apps/org.example.example/bin/example] + 0x84af
 1: app_create + 0x2c (0xb38056ec) [/opt/usr/apps/org.example.example/bin/example] + 0x76ec
 2: (0xb778b65b) [/usr/lib/libcapi-appfw-application.so.0] + 0x265b
 3: appcore_efl_main + 0x327 (0xb7792c27) [/usr/lib/libappcore-efl.so.1] + 0x3c27
 4: ui_app_main + 0x140 (0xb778bc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
 5: main + 0x2e1 (0xb3805661) [/opt/usr/apps/org.example.example/bin/example] + 0x7661
 6: (0xb77c7148) [/opt/usr/apps/org.example.example/bin/example] + 0xb77c7148
 7: __libc_start_main + 0xde (0xb6cb4e4e) [/lib/libc.so.6] + 0x17e4e
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
> [SECURE_LOG] pkgid(org.example.example), key(end), value(ok)
06-01 14:11:31.608+0900 W/AUL_AMD ( 2858): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(install), value(ok)
06-01 14:11:31.608+0900 D/PKGMGR  ( 3032): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_299371017], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
06-01 14:11:31.608+0900 D/PKGMGR  ( 3032): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
06-01 14:11:31.608+0900 D/PKGMGR  ( 3032): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_299371017], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 14:11:31.608+0900 D/PKGMGR  ( 3032): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
06-01 14:11:31.608+0900 D/PKGMGR  (10181): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_299371017], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
06-01 14:11:31.608+0900 D/PKGMGR  (10181): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_299371017], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 14:11:31.608+0900 D/PKGMGR  ( 3191): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_299371017], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
06-01 14:11:31.608+0900 D/PKGMGR  ( 3191): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_299371017], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 14:11:31.608+0900 D/AUL_AMD ( 2858): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.example, type:rpm
06-01 14:11:31.608+0900 W/ISF_PANEL_EFL( 3115): isf_panel_efl.cpp: _package_manager_event_cb(1512) > _isf_insert_ime_info_by_pkgid returned 0.
06-01 14:11:31.608+0900 D/PKGMGR  ( 3009): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_299371017], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
06-01 14:11:31.608+0900 D/DATA_PROVIDER_MASTER( 3009): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.example] 100
06-01 14:11:31.608+0900 D/PKGMGR  ( 3017): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_299371017], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
06-01 14:11:31.608+0900 D/ESD     ( 3017): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(30170002), pkg_type(tpk), pkgid(org.example.example), key(install_percent), val(100)
06-01 14:11:31.608+0900 D/PKGMGR  ( 3017): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_299371017], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 14:11:31.608+0900 D/PKGMGR  ( 3009): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_299371017], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 14:11:31.608+0900 D/ESD     ( 3017): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(30170002), pkg_type(tpk), pkgid(org.example.example), key(end), val(ok)
06-01 14:11:31.608+0900 D/ESD     ( 3017): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
06-01 14:11:31.608+0900 D/DATA_PROVIDER_MASTER( 3009): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.example] ok
06-01 14:11:31.608+0900 D/DATA_PROVIDER_MASTER( 3009): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.example], event_type[1]
06-01 14:11:31.608+0900 D/DATA_PROVIDER_MASTER( 3009): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
06-01 14:11:31.608+0900 D/PKGMGR  ( 2945): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_299371017], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
06-01 14:11:31.608+0900 W/cluster-home( 2945): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[0], state[1], package[org.example.example]
06-01 14:11:31.608+0900 D/PKGMGR  ( 2945): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_299371017], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
06-01 14:11:31.608+0900 D/cluster-home( 2945): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29450003] pkg_type[tpk] package[org.example.example] key[install_percent] val[100] pmsg[(null)]
06-01 14:11:31.608+0900 D/PKGMGR  ( 2945): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_299371017], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 14:11:31.608+0900 W/cluster-home( 2945): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[0], state[2], package[org.example.example]
06-01 14:11:31.608+0900 D/cluster-home( 2945): widget-data-provider.cpp: PackageUpdated(2160) >  No boxes that pkgname is[org.example.example]
06-01 14:11:31.608+0900 D/PKGMGR  ( 2945): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[/opt/usr/apps/tmp/org.example.example-1.0.0-x86.tpk_299371017], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
06-01 14:11:31.608+0900 D/cluster-home( 2945): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29450003] pkg_type[tpk] package[org.example.example] key[end] val[ok] pmsg[(null)]
06-01 14:11:31.608+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
06-01 14:11:31.608+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
06-01 14:11:31.608+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
06-01 14:11:31.608+0900 D/DATA_PROVIDER_MASTER( 3009): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
06-01 14:11:31.608+0900 D/DATA_PROVIDER_MASTER( 3009): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
06-01 14:11:31.608+0900 D/DATA_PROVIDER_MASTER( 3009): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.example]
06-01 14:11:31.608+0900 D/cluster-home( 2945): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
06-01 14:11:31.608+0900 D/cluster-home( 2945): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.example]
06-01 14:11:31.608+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.example]
06-01 14:11:31.608+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.example]
06-01 14:11:31.608+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
06-01 14:11:31.608+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
06-01 14:11:31.608+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.example]
06-01 14:11:31.608+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.example] Name[forpet] Icon[/opt/usr/apps/org.example.example/shared/res/1.jpg] enable[1] system[0]
06-01 14:11:31.608+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: OnAppInstalled(309) >  pAppId [org.example.example]
06-01 14:11:31.608+0900 D/cluster-home( 2945): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.example
06-01 14:11:31.608+0900 D/cluster-home( 2945): mainmenu-data-manager.cpp: GetBoxDataByAppId(1879) >  cannot find box with appid[org.example.example]
06-01 14:11:31.608+0900 D/cluster-home( 2945): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
06-01 14:11:31.608+0900 D/cluster-home( 2945): mainmenu-data-manager.cpp: InsertBoxData(552) >  current last page [1, 1] box[16] [3, 4]
06-01 14:11:31.618+0900 D/rpm-installer(10183): rpm-installer-privilege.c: _ri_privilege_enable_permissions(106) > [smack] app_enable_permissions(org.example.example, 7), result=[0]
06-01 14:11:31.618+0900 D/rpm-installer(10183): coretpk-installer.c: _coretpk_installer_prepare_package_install_with_debug(3285) > _ri_privilege_enable_permissions(privilege/appdebuging succeeded for debug_mode.
06-01 14:11:31.618+0900 D/rpm-installer(10183): rpm-appcore-intf.c: main(236) > sync() start
06-01 14:11:31.658+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: OnAppInstalled(316) >  box id [49]
06-01 14:11:31.658+0900 D/cluster-home( 2945): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
06-01 14:11:31.658+0900 D/cluster-home( 2945): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
06-01 14:11:31.658+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.example] Name[forpet] Icon[/opt/usr/apps/org.example.example/shared/res/1.jpg] enable[1] system[0]
06-01 14:11:31.658+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: OnAppInstalled(323) >  name [forpet]
06-01 14:11:31.658+0900 D/test-log( 2945): mainmenu-view-manager-impl.cpp: AddMenuBox(282) >  AppInfo name [forpet] [1] [4,4, 1]
06-01 14:11:31.658+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(347) >  AddBox Name[forpet] pageid[1] pos[4, 4]
06-01 14:11:31.658+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(354) >  menuPage.GetPageId() = 100001, boxPageId = 1
06-01 14:11:31.658+0900 D/cluster-home( 2945): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 1, appId = $appId, name = $name, col = 4, row = 4, isPreload = 0, isSystem = 0 WHERE boxId = 49]
06-01 14:11:31.658+0900 D/rpm-installer(10183): rpm-appcore-intf.c: main(238) > sync() end
06-01 14:11:31.678+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(540) >  Do reorder
06-01 14:11:31.678+0900 D/cluster-home( 2945): mainmenu-data-manager.cpp: GetPageDataListByAlphabeticalOrder(1404) >  Alphabetical order Count : Box[16] Page[1]
06-01 14:11:31.678+0900 D/cluster-home( 2945): mainmenu-data-manager.cpp: GetPageDataListByAlphabeticalOrder(1411) >  page count[1]
06-01 14:11:31.678+0900 D/cluster-home( 2945): mainmenu-data-manager.cpp: GetPageDataListByAlphabeticalOrder(1423) >  nVirtualPageId[100001] pageNo[1]
06-01 14:11:31.678+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(559) >  pageId[100001]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuPage(689) >  BEGIN nTotalPageCount[1] mAppsPages.size[1]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuPage(701) >  pageId[100001] pageNo[1]
06-01 14:11:31.678+0900 D/cluster-view( 2945): homescreen-page-indicator.cpp: Update(281) >  Unit size is same [1]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuPage(760) >  _SortingPageOrder
06-01 14:11:31.678+0900 D/test-log( 2945): mainmenu-apps-view-impl.cpp: _SortingPageOrder(1065) >  !!!!!!!!!!!![1],[100001]!!!!!!!!!!!!!!
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: SetLayoutPosition(1115) >  layoutposition [1]
06-01 14:11:31.678+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: OnPageDataNotify(226) >  Page [1]
06-01 14:11:31.678+0900 D/cluster-home( 2945): mainmenu-data-manager.cpp: UpdatePageDataForAlphaBeticalOrder(822) >  Do nothing while alphabetical order
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuPage(763) >  END
06-01 14:11:31.678+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.basicui] Name[basicui] Icon[/opt/usr/apps/org.example.basicui/shared/res/basicui.png] enable[1] system[0]
06-01 14:11:31.678+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.basicui'], count[0]
06-01 14:11:31.678+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.basicui][-17956860][0]
06-01 14:11:31.678+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.basicui]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[basicui] pos[1, 1] pageId[100001]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[13]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[1], [1, 1]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[1], [1, 1]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 14:11:31.678+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.calendar] Name[Calendar] Icon[/usr/share/icons/default/small/calendar.png] enable[1] system[1]
06-01 14:11:31.678+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.calendar'], count[0]
06-01 14:11:31.678+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.calendar][-17956860][0]
06-01 14:11:31.678+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.calendar]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Calendar] pos[2, 1] pageId[100001]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[2]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[2], [2, 1]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[2], [2, 1]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 14:11:31.678+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.calendar] Name[calendar] Icon[/opt/usr/apps/org.example.calendar/shared/res/calendar.png] enable[1] system[0]
06-01 14:11:31.678+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.calendar'], count[0]
06-01 14:11:31.678+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.calendar][-17956860][0]
06-01 14:11:31.678+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.calendar]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[calendar] pos[3, 1] pageId[100001]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[16]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[3], [3, 1]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[3], [3, 1]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 14:11:31.678+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.camera-app] Name[Camera] Icon[/usr/share/icons/default/small/org.tizen.camera-app.png] enable[1] system[1]
06-01 14:11:31.678+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.camera-app'], count[0]
06-01 14:11:31.678+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.camera-app][-17956860][0]
06-01 14:11:31.678+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.camera-app]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Camera] pos[4, 1] pageId[100001]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[3]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[4], [4, 1]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[4], [4, 1]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 14:11:31.678+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.contacts] Name[Contacts] Icon[/usr/share/icons/default/small/org.tizen.contacts.png] enable[1] system[1]
06-01 14:11:31.678+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.contacts'], count[0]
06-01 14:11:31.678+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.contacts][-17956860][0]
06-01 14:11:31.678+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.contacts]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Contacts] pos[1, 2] pageId[100001]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[4]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[5], [1, 2]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[5], [1, 2]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 14:11:31.678+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.email] Name[Email] Icon[/usr/apps/org.tizen.email/shared/res/org.tizen.email.png] enable[1] system[1]
06-01 14:11:31.678+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.email'], count[1]
06-01 14:11:31.678+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.email]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Email] pos[2, 2] pageId[100001]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[5]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[6], [2, 2]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[6], [2, 2]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 14:11:31.678+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.example] Name[forpet] Icon[/opt/usr/apps/org.example.example/shared/res/1.jpg] enable[1] system[0]
06-01 14:11:31.678+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.example'], count[0]
06-01 14:11:31.678+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.example][-17956860][0]
06-01 14:11:31.678+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.example]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[forpet] pos[3, 2] pageId[100001]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[0]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(787) >  AddBoxToMenuView
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(347) >  AddBox Name[forpet] pageid[100001] pos[3, 2]
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(354) >  menuPage.GetPageId() = 100001, boxPageId = 100001
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: AddBoxToPage(112) >  void ClusterHome3D::Internal::CMainMenuPage::AddBoxToPage(std::shared_ptr<CMainMenuBoxData>) : 112
06-01 14:11:31.678+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: AddBoxToPage(122) >  void ClusterHome3D::Internal::CMainMenuPage::AddBoxToPage(std::shared_ptr<CMainMenuBoxData>) : 122
06-01 14:11:31.678+0900 D/test-log( 2945): mainmenu-page-impl.cpp: AddBoxToPage(123) >  create box[org.example.example] [3,2]
06-01 14:11:31.678+0900 D/test-log( 2945): mainmenu-box-impl.cpp: CMainMenuBox(148) >  create box
06-01 14:11:31.688+0900 D/test-log( 2945): mainmenu-box-impl.cpp: SetPosition(459) >  cut Animation : forpet
06-01 14:11:31.688+0900 D/test-log( 2945): mainmenu-page-impl.cpp: AddBoxToPage(177) >  add created box
06-01 14:11:31.688+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.gallery] Name[Gallery] Icon[/usr/share/icons/default/small/org.tizen.gallery.png] enable[1] system[1]
06-01 14:11:31.688+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.gallery'], count[0]
06-01 14:11:31.688+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.gallery][-17956860][0]
06-01 14:11:31.688+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.gallery]
06-01 14:11:31.688+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Gallery] pos[4, 2] pageId[100001]
06-01 14:11:31.688+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[6]
06-01 14:11:31.688+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[8], [4, 2]
06-01 14:11:31.688+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[7], [3, 2]
06-01 14:11:31.688+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 14:11:31.688+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.imageutil] Name[imageutil] Icon[/opt/usr/apps/org.example.imageutil/shared/res/imageutil.png] enable[1] system[0]
06-01 14:11:31.698+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.imageutil'], count[0]
06-01 14:11:31.698+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.imageutil][-17956860][0]
06-01 14:11:31.698+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.imageutil]
06-01 14:11:31.698+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[imageutil] pos[1, 3] pageId[100001]
06-01 14:11:31.698+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[15]
06-01 14:11:31.698+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[9], [1, 3]
06-01 14:11:31.698+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 14:11:31.698+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 14:11:31.698+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.browser] Name[Internet] Icon[/usr/share/icons/default/small/org.tizen.browser.png] enable[1] system[1]
06-01 14:11:31.698+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.browser'], count[0]
06-01 14:11:31.698+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.browser][-17956860][0]
06-01 14:11:31.698+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.browser]
06-01 14:11:31.698+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Internet] pos[2, 3] pageId[100001]
06-01 14:11:31.698+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[1]
06-01 14:11:31.698+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[10], [2, 3]
06-01 14:11:31.698+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 14:11:31.698+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 14:11:31.698+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.message] Name[Messages] Icon[/usr/share/icons/default/small/org.tizen.message.png] enable[1] system[1]
06-01 14:11:31.698+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.message'], count[1]
06-01 14:11:31.698+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.message]
06-01 14:11:31.698+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Messages] pos[3, 3] pageId[100001]
06-01 14:11:31.698+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[7]
06-01 14:11:31.698+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[11], [3, 3]
06-01 14:11:31.698+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 14:11:31.698+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 14:11:31.698+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.music-player] Name[Music] Icon[/usr/share/icons/default/small/org.tizen.music-player.png] enable[1] system[1]
06-01 14:11:31.698+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.music-player'], count[0]
06-01 14:11:31.698+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.music-player][-17956860][0]
06-01 14:11:31.698+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.music-player]
06-01 14:11:31.698+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Music] pos[4, 3] pageId[100001]
06-01 14:11:31.698+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[8]
06-01 14:11:31.698+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[12], [4, 3]
06-01 14:11:31.698+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 14:11:31.698+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 14:11:31.698+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.myfile] Name[My Files] Icon[/usr/share/icons/default/small/org.tizen.myfile.png] enable[1] system[1]
06-01 14:11:31.708+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.myfile'], count[0]
06-01 14:11:31.708+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.myfile][-17956860][0]
06-01 14:11:31.708+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.myfile]
06-01 14:11:31.708+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[My Files] pos[1, 4] pageId[100001]
06-01 14:11:31.708+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[9]
06-01 14:11:31.708+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[13], [1, 4]
06-01 14:11:31.708+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 14:11:31.708+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 14:11:31.708+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.phone] Name[Phone] Icon[/usr/share/icons/default/small/org.tizen.phone.png] enable[1] system[1]
06-01 14:11:31.708+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.phone'], count[0]
06-01 14:11:31.708+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.phone][-17956860][0]
06-01 14:11:31.718+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.phone]
06-01 14:11:31.718+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Phone] pos[2, 4] pageId[100001]
06-01 14:11:31.718+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[10]
06-01 14:11:31.718+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[14], [2, 4]
06-01 14:11:31.718+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 14:11:31.718+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 14:11:31.718+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.setting] Name[Settings] Icon[/usr/share/icons/default/small/org.tizen.setting.png] enable[1] system[1]
06-01 14:11:31.718+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.setting'], count[0]
06-01 14:11:31.718+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.setting][-17956860][0]
06-01 14:11:31.718+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.setting]
06-01 14:11:31.718+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Settings] pos[3, 4] pageId[100001]
06-01 14:11:31.718+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[11]
06-01 14:11:31.718+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[15], [3, 4]
06-01 14:11:31.718+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 14:11:31.718+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 14:11:31.718+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.videos] Name[Video] Icon[/usr/share/icons/default/small/org.tizen.videos.png] enable[1] system[1]
06-01 14:11:31.718+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.videos'], count[0]
06-01 14:11:31.718+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.videos][-17956860][0]
06-01 14:11:31.718+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.videos]
06-01 14:11:31.718+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Video] pos[4, 4] pageId[100001]
06-01 14:11:31.718+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[12]
06-01 14:11:31.718+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[16], [4, 4]
06-01 14:11:31.718+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 14:11:31.718+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 14:11:31.718+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: RearrangeItems(243) >  view type [1]
06-01 14:11:31.938+0900 D/rpm-installer(10183): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
06-01 14:11:31.938+0900 D/rpm-installer(10183): rpm-appcore-intf.c: main(259) > ------------------------------------------------
06-01 14:11:31.938+0900 D/rpm-installer(10183): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
06-01 14:11:31.938+0900 D/rpm-installer(10183): rpm-appcore-intf.c: main(261) > ------------------------------------------------
06-01 14:11:31.998+0900 D/PKGMGR_SERVER(10169): pkgmgr-server.c: sighandler(387) > child exit [10183]
06-01 14:11:31.998+0900 E/PKGMGR_SERVER(10169): pkgmgr-server.c: sighandler(402) > child NORMAL exit [10183]
06-01 14:11:31.998+0900 E/PKGMGR_SERVER(10169): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-01 14:11:31.998+0900 E/PKGMGR_SERVER(10169): pkgmgr-server.c: main(2265) > package manager server terminated.
06-01 14:11:32.808+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(838) > __request_handler: 0
06-01 14:11:32.808+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-01 14:11:32.808+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 14:11:32.808+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 14:11:32.818+0900 I/AUL     ( 2858): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
06-01 14:11:32.818+0900 D/AUL     ( 2858): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 10236, pid = 10238
06-01 14:11:32.818+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 14:11:32.818+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 14:11:32.818+0900 I/AUL     ( 2858): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
06-01 14:11:32.818+0900 E/AUL_AMD ( 2858): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-01 14:11:32.818+0900 W/AUL_AMD ( 2858): amd_launch.c: _start_app(2233) > caller pid : 10238
06-01 14:11:32.818+0900 E/AUL_AMD ( 2858): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-01 14:11:32.818+0900 W/AUL_AMD ( 2858): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-01 14:11:32.818+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2648) > process_pool: false
06-01 14:11:32.818+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-01 14:11:32.818+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-01 14:11:32.818+0900 W/AUL_AMD ( 2858): amd_launch.c: _start_app(2665) > pad pid(-5)
06-01 14:11:32.818+0900 D/AUL_AMD ( 2858): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-01 14:11:32.818+0900 D/AUL_AMD ( 2858): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-01 14:11:32.818+0900 D/AUL     ( 2858): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-01 14:11:32.818+0900 W/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-01 14:11:32.818+0900 D/AUL     ( 3003): process_pool.c: __send_pkt_raw_data(219) > send(11) : 624 / 624
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 10082, bin path: /opt/usr/apps/org.example.example/bin/example
06-01 14:11:32.818+0900 W/AUL_PAD ( 3003): launchpad.c: __send_result_to_caller(265) > Check app launching
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-01 14:11:32.818+0900 D/RESOURCED( 2893): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-01 14:11:32.828+0900 D/RESOURCED( 2893): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-01 14:11:32.828+0900 E/RESOURCED( 2893): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-01 14:11:32.828+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-01 14:11:32.828+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
06-01 14:11:32.828+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-01 14:11:32.828+0900 D/AUL_PAD (10082): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-01 14:11:32.828+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-01 14:11:32.828+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-01 14:11:32.828+0900 D/AUL     (10082): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (10083) is sent.
06-01 14:11:32.828+0900 D/AUL     (10082): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 10083, signo: 10
06-01 14:11:32.828+0900 D/AUL     (10082): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-01 14:11:32.828+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-01 14:11:32.838+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-01 14:11:32.838+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-01 14:11:32.838+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-01 14:11:32.838+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTYyOTM4OTIvODEzNTM2AA==##
06-01 14:11:32.838+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-01 14:11:32.838+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAxMDIzOAA=##
06-01 14:11:32.838+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-01 14:11:32.838+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-01 14:11:32.838+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-01 14:11:32.838+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-01 14:11:32.838+0900 D/AUL_PAD (10082): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-01 14:11:32.838+0900 I/CAPI_APPFW_APPLICATION(10082): app_main.c: ui_app_main(788) > app_efl_main
06-01 14:11:32.848+0900 D/LAUNCH  (10082): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-01 14:11:32.848+0900 D/APP_CORE(10082): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-01 14:11:32.848+0900 D/APP_CORE(10082): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-01 14:11:32.848+0900 D/APP_CORE(10082): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-01 14:11:32.868+0900 D/APP_CORE(10082): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-01 14:11:32.868+0900 D/AUL     (10082): app_sock.c: __create_server_sock(156) > pg path - already exists
06-01 14:11:32.868+0900 D/APP_CORE(10082): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42eb520
06-01 14:11:32.868+0900 D/LAUNCH  (10082): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-01 14:11:32.868+0900 I/CAPI_APPFW_APPLICATION(10082): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-01 14:11:32.918+0900 D/AUL_PAD ( 3003): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-01 14:11:32.918+0900 W/AUL     ( 2858): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 10082, appid: org.example.example
06-01 14:11:32.918+0900 D/AUL     ( 2858): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-01 14:11:32.918+0900 E/AUL     ( 2858): simple_util.c: __trm_app_info_send_socket(330) > access
06-01 14:11:32.918+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2700) > add app group info
06-01 14:11:32.918+0900 E/AUL     ( 2858): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-01 14:11:32.928+0900 D/AUL_AMD ( 2858): amd_status.c: _status_add_app_info_list(427) > pid(10082) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-01 14:11:32.928+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 10082
06-01 14:11:32.928+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-01 14:11:32.928+0900 E/RESOURCED( 2893): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-01 14:11:32.928+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(888) > available memory = 318
06-01 14:11:33.058+0900 W/CRASH_MANAGER(10243): worker.c: worker_job(1204) > 1110082657861149629389
