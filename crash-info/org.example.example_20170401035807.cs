S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 11248
Date: 2017-04-01 03:58:07+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x14

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb8b65420, esi = 0x8000b45b
ebp = 0xbffd9768, esp = 0xbffd9730
eax = 0x00000000, ebx = 0xb73525f0
ecx = 0x00000059, edx = 0x00000015
eip = 0xb71a9bbf

Memory Information
MemTotal:      123 KB
MemFree:        20 KB
Buffers:         8 KB
Cached:     181340 KB
VmPeak:      79200 KB
VmSize:      79200 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14008 KB
VmRSS:       14008 KB
VmData:      19560 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33316 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 11248 TID = 11248
11248 11270 11486 

Maps Information
b2cda000 b2ce4000 r-xp /usr/lib/libfeedback.so.0.1.4
b2cea000 b2cf6000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2cf7000 b2d18000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2d1d000 b2d1e000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2d1f000 b2d24000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2d25000 b2d26000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2d27000 b2d29000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2d2a000 b2d2c000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2d2d000 b2d39000 r-xp /usr/lib/libdrm.so.2.4.0
b2d3a000 b2d3d000 r-xp /usr/lib/libdri2.so.0.0.0
b2d3e000 b2d48000 r-xp /usr/lib/libtbm.so.1.0.0
b2d4f000 b2d50000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2d51000 b2d52000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2d53000 b2d56000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b2d57000 b2d5a000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b2d5b000 b2d70000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2d71000 b2d83000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b368c000 b3692000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3693000 b37d7000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37e8000 b37e9000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37ea000 b37f3000 r-xp /usr/lib/libefl-extension.so.0.1.0
b37f4000 b37f7000 r-xp /opt/usr/apps/org.example.example/bin/example
b37f9000 b3832000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4235000 b4240000 r-xp /lib/libnss_files-2.20-2014.11.so
b4242000 b424d000 r-xp /lib/libnss_nis-2.20-2014.11.so
b424f000 b4266000 r-xp /lib/libnsl-2.20-2014.11.so
b426a000 b4272000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4274000 b4298000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4299000 b429a000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b429b000 b429e000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b429f000 b42a6000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42a7000 b42b1000 r-xp /usr/lib/libsensord-share.so
b42b2000 b42ce000 r-xp /usr/lib/libsensor.so.1.2.0
b42d0000 b42d9000 r-xp /usr/lib/libappcore-common.so.1.1
b42dc000 b42de000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42f3000 b42f5000 r-xp /usr/lib/libXau.so.6.0.0
b42f6000 b4318000 r-xp /usr/lib/libxcb.so.1.1.0
b431a000 b4323000 r-xp /lib/libcrypt-2.20-2014.11.so
b434c000 b434e000 r-xp /usr/lib/libiri.so
b434f000 b4375000 r-xp /lib/libexpat.so.1.5.2
b4377000 b43e2000 r-xp /usr/lib/libssl.so.1.0.0
b43e8000 b43f4000 r-xp /usr/lib/libethumb.so.1.13.0
b43f5000 b43f9000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43fa000 b464b000 r-xp /usr/lib/libcrypto.so.1.0.0
b5bc6000 b5bd6000 r-xp /usr/lib/libXi.so.6.1.0
b5bd7000 b5bd9000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bda000 b5be0000 r-xp /usr/lib/libXtst.so.6.1.0
b5be1000 b5beb000 r-xp /usr/lib/libXrender.so.1.3.0
b5bec000 b5bf5000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bf7000 b5bf9000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bfa000 b5bff000 r-xp /usr/lib/libXfixes.so.3.1.0
b5c00000 b5c12000 r-xp /usr/lib/libXext.so.6.4.0
b5c13000 b5c15000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c16000 b5c18000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c1a000 b5d5c000 r-xp /usr/lib/libX11.so.6.3.0
b5d60000 b5d6a000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d6b000 b5d81000 r-xp /usr/lib/libudev.so.1.6.0
b5d84000 b5d88000 r-xp /lib/libattr.so.1.1.0
b5d89000 b5db8000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5dba000 b5dc0000 r-xp /usr/lib/libffi.so.6.0.2
b5dc1000 b5de4000 r-xp /lib/libz.so.1.2.8
b5de5000 b5de8000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5de9000 b5f45000 r-xp /usr/lib/libxml2.so.2.9.2
b5f4b000 b6032000 r-xp /usr/lib/libstdc++.so.6.0.20
b603f000 b6042000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6043000 b6065000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6066000 b607a000 r-xp /lib/libresolv-2.20-2014.11.so
b607e000 b60a2000 r-xp /usr/lib/liblzma.so.5.0.3
b60a3000 b60a5000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b60a7000 b60b1000 r-xp /usr/lib/libembryo.so.1.13.0
b60b2000 b60db000 r-xp /usr/lib/libpng12.so.0.50.0
b60dc000 b6125000 r-xp /usr/lib/libjpeg.so.8.0.2
b6136000 b613d000 r-xp /lib/librt-2.20-2014.11.so
b613f000 b615e000 r-xp /usr/lib/libector.so.1.13.0
b6161000 b618e000 r-xp /usr/lib/liblua-5.1.so
b618f000 b621f000 r-xp /usr/lib/libfreetype.so.6.11.3
b6223000 b6261000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6262000 b6278000 r-xp /usr/lib/libfribidi.so.0.3.1
b6279000 b62d2000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62d5000 b6320000 r-xp /lib/libm-2.20-2014.11.so
b6322000 b6334000 r-xp /usr/lib/libeio.so.1.13.0
b6335000 b6338000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6339000 b633f000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6340000 b6363000 r-xp /usr/lib/libefreet.so.1.13.0
b6366000 b6391000 r-xp /usr/lib/libeldbus.so.1.13.0
b6392000 b63c6000 r-xp /usr/lib/libecore_con.so.1.13.0
b63c8000 b63d1000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63d2000 b63db000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63dc000 b63ef000 r-xp /usr/lib/libeo.so.1.13.0
b63f1000 b6404000 r-xp /usr/lib/libecore_input.so.1.13.0
b6405000 b640c000 r-xp /usr/lib/libecore_file.so.1.13.0
b640d000 b6430000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6431000 b645d000 r-xp /usr/lib/libeet.so.1.13.0
b6466000 b64d1000 r-xp /usr/lib/libeina.so.1.13.0
b64d4000 b64eb000 r-xp /usr/lib/libefl.so.1.13.0
b64ed000 b6654000 r-xp /usr/lib/libicuuc.so.51.1
b6662000 b686e000 r-xp /usr/lib/libicui18n.so.51.1
b6876000 b68c5000 r-xp /usr/lib/libecore_x.so.1.13.0
b68c7000 b68e1000 r-xp /lib/libgcc_s-4.9.so.1
b68e3000 b68e7000 r-xp /lib/libcap.so.2.21
b68e8000 b692e000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b692f000 b6936000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6938000 b698a000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b698c000 b6b17000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b1c000 b6bea000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bed000 b6bf1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bf2000 b6c01000 r-xp /usr/lib/libvconf.so.0.2.45
b6c02000 b6c05000 r-xp /usr/lib/libvasum.so.0.3.1
b6c06000 b6c09000 r-xp /usr/lib/libttrace.so.1.1
b6c0b000 b6c0f000 r-xp /usr/lib/libiniparser.so.0
b6c10000 b6c40000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c41000 b6c4a000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c4b000 b6c70000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c71000 b6c81000 r-xp /usr/lib/libunwind.so.8.0.1
b6c8b000 b6e39000 r-xp /lib/libc-2.20-2014.11.so
b6e41000 b6f84000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f86000 b6fde000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fdf000 b7013000 r-xp /usr/lib/libsystemd.so.0.4.0
b7016000 b70ea000 r-xp /usr/lib/libedje.so.1.13.0
b70ed000 b7119000 r-xp /usr/lib/libecore.so.1.13.0
b712a000 b7350000 r-xp /usr/lib/libevas.so.1.13.0
b7378000 b7390000 r-xp /lib/libpthread-2.20-2014.11.so
b7394000 b770e000 r-xp /usr/lib/libelementary.so.1.13.0
b772e000 b7732000 r-xp /usr/lib/libsmack.so.1.0.0
b7733000 b773c000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b773d000 b7740000 r-xp /usr/lib/libdlog.so.0.0.0
b7741000 b7746000 r-xp /usr/lib/libbundle.so.0.1.22
b7747000 b774a000 r-xp /lib/libdl-2.20-2014.11.so
b774c000 b7771000 r-xp /usr/lib/libaul.so.0.1.0
b7774000 b7776000 r-xp /usr/lib/libappsvc.so.0.1.0
b7777000 b777c000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b777d000 b7784000 r-xp /usr/lib/libappcore-efl.so.1.1
b7786000 b778b000 r-xp /usr/lib/libsys-assert.so
b778e000 b778f000 r-xp [vdso]
b778f000 b77b1000 r-xp /lib/ld-2.20-2014.11.so
b77b3000 b77bb000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:11248)
Call Stack Count: 27
 0: (0xb71a9bbf) [/usr/lib/libevas.so.1] + 0x7fbbf
 1: (0xb719bce8) [/usr/lib/libevas.so.1] + 0x71ce8
 2: evas_obj_size_hint_min_set + 0xb9 (0xb7196629) [/usr/lib/libevas.so.1] + 0x6c629
 3: evas_object_size_hint_min_set + 0x60 (0xb71a3fa0) [/usr/lib/libevas.so.1] + 0x79fa0
 4: (0xb753c7df) [/usr/lib/libelementary.so.1] + 0x1a87df
 5: elm_obj_layout_sizing_eval + 0x99 (0xb753f559) [/usr/lib/libelementary.so.1] + 0x1ab559
 6: (0xb7546205) [/usr/lib/libelementary.so.1] + 0x1b2205
 7: evas_obj_smart_add + 0x99 (0xb71b4809) [/usr/lib/libevas.so.1] + 0x8a809
 8: (0xb753d24b) [/usr/lib/libelementary.so.1] + 0x1a924b
 9: evas_obj_smart_add + 0x99 (0xb71b4809) [/usr/lib/libevas.so.1] + 0x8a809
10: (0xb71b7d8b) [/usr/lib/libevas.so.1] + 0x8dd8b
11: eo_constructor + 0x99 (0xb63e6899) [/usr/lib/libeo.so.1] + 0xa899
12: (0xb76054a6) [/usr/lib/libelementary.so.1] + 0x2714a6
13: eo_constructor + 0x99 (0xb63e6899) [/usr/lib/libeo.so.1] + 0xa899
14: (0xb7547c37) [/usr/lib/libelementary.so.1] + 0x1b3c37
15: eo_constructor + 0x99 (0xb63e6899) [/usr/lib/libeo.so.1] + 0xa899
16: (0xb753d692) [/usr/lib/libelementary.so.1] + 0x1a9692
17: eo_constructor + 0x99 (0xb63e6899) [/usr/lib/libeo.so.1] + 0xa899
18: elm_label_add + 0x77 (0xb753bcf7) [/usr/lib/libelementary.so.1] + 0x1a7cf7
19: create_base_gui + 0x3e8 (0xb37f5ef8) [/opt/usr/apps/org.example.example/bin/example] + 0x1ef8
20: app_create + 0x2c (0xb37f597c) [/opt/usr/apps/org.example.example/bin/example] + 0x197c
21: (0xb777965b) [/usr/lib/libcapi-appfw-application.so.0] + 0x265b
22: appcore_efl_main + 0x327 (0xb7780c27) [/usr/lib/libappcore-efl.so.1] + 0x3c27
23: ui_app_main + 0x140 (0xb7779c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
24: main + 0x27e (0xb37f58ee) [/opt/usr/apps/org.example.example/bin/example] + 0x18ee
25: create_base_gui + 0x638 (0xb77b5148) [/opt/usr/apps/org.example.example/bin/example] + 0xb77b5148
26: __libc_start_main + 0xde (0xb6ca2e4e) [/lib/libc.so.6] + 0x17e4e
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
_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
04-01 03:58:06.664+0900 D/PKGMGR  ( 2983): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
04-01 03:58:06.664+0900 D/PKGMGR  ( 2983): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
04-01 03:58:06.664+0900 D/PKGMGR  ( 2968): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
04-01 03:58:06.664+0900 D/QUICKPANEL( 2968): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:install_percent val:30
04-01 03:58:06.664+0900 D/PKGMGR  ( 2960): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
04-01 03:58:06.664+0900 D/DATA_PROVIDER_MASTER( 2960): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.example] 30
04-01 03:58:06.664+0900 D/PKGMGR  ( 3052): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
04-01 03:58:06.664+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
04-01 03:58:06.664+0900 W/cluster-home( 2906): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.example]
04-01 03:58:06.664+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
04-01 03:58:06.664+0900 D/cluster-home( 2906): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29060003] pkg_type[tpk] package[org.example.example] key[install_percent] val[30] pmsg[(null)]
04-01 03:58:06.674+0900 D/CERT_SVC(11430): cert-service.c: _cert_svc_verify_certificate_with_caflag(188) > [SECURE_LOG] root cert path : /usr/share/cert-svc/certs/code-signing/tizen/tizen-developers-root.pem
04-01 03:58:06.674+0900 D/rpm-installer(11430): rpm-installer.c: _ri_verify_sig_and_cert(1744) > cert_svc_verify() is done successfully. validity=[1]
04-01 03:58:06.674+0900 D/rpm-installer(11430): rpm-installer.c: _ri_verify_sig_and_cert(1758) > cert_svc_get_visibility() returns visibility=[1]
04-01 03:58:06.674+0900 D/rpm-installer(11430): rpm-installer.c: _ri_verify_sig_and_cert(1771) > Root CA cert path=[/usr/share/cert-svc/certs/code-signing/tizen/tizen-developers-root.pem]
04-01 03:58:06.674+0900 D/rpm-installer(11430): rpm-installer.c: __ri_verify_file(336) > valid signature
04-01 03:58:06.674+0900 D/rpm-installer(11430): rpm-installer.c: __ri_get_cert_from_file(1029) > Root CA, len=[1108]
04-01 03:58:06.674+0900 D/rpm-installer(11430): MIIDOzCCAiOgAwIBAgIBADANBgkqhkiG9w0BAQUFADBYMRowGAYDVQQKDBFUaXplbiBBc3NvY2lhdGlvbjEaMBgGA1UECwwRVGl6ZW4gQXNzb2NpYXRpb24xHjAcBgNVBAMMFVRpemVuIERldmVsb3BlcnMgUm9vdDAeFw0xMjAxMDEwMDAwMDBaFw0zMjAxMDEwMDAwMDBaMFgxGjAYBgNVBAoMEVRpemVuIEFzc29jaWF0aW9uMRowGAYDVQQLDBFUaXplbiBBc3NvY2lhdGlvbjEeMBwGA1UEAwwVVGl6ZW4gRGV2ZWxvcGVycyBSb290MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAp2rCwXTYh28vcagXWLIeVtEvXA5EeTR9UnL4Dzyd7hIq8rkxLbIMMOcCrXMTc7bEH2twFaTuXxyKXMW/2c+id3m3Z1B5caCqwSPr72oKPSI4jSkvrAC5W7EHx16M818aG4tQkXIUBhDrtSmH6dFOdt8zGq2fanj1sETfUmXAeLGE7OQYcEb2SoWGXR75Ytfp1LAw/L3luuG/kbzBcrZt1Cv05jfCP575eope6p5p80Gl0tieXyPYhSLVTLwhEdWx18CMaC7IXQo2Bm+JdjDH0Ruh/vTRnjFtmVB+nBOZNVzMHNOPUVFKSgysX/+PlM4jBTvbaTnPCZUkC/O75tYIpwIDAQABoxAwDjAMBgNVHRMEBTADAQH/MA0GCSqGSIb3DQEBBQUAA4IBAQBw95ibcuAiKpAEqBMyTZtOf0okhSi9NYfs/AFIPLH5REnhtQkPmKsvDp21OSdzrFEL42rV94K98QChD9tGO6Mwp1ZHM3No7/PLC3EelOwmn4dr3KPGdjvQNSwKRblGh0Hjn4fI+studFLLv6ldCLIpA/Ssgf9GuUbcjTC8OWBYPVUQ6YoXAcuHbfhr6a
04-01 03:58:06.674+0900 D/rpm-installer(11430): coretpk-installer.c: _coretpk_installer_verify_signatures(1274) > _ri_verify_sig_and_cert(/opt/usr/apps/org.example.example/author-signature.xml) succeed.
04-01 03:58:06.674+0900 D/rpm-installer(11430): rpm-installer-signature.c: _ri_process_signaturevalue(533) > SignatureValue, len=[176]
04-01 03:58:06.674+0900 D/rpm-installer(11430): 
04-01 03:58:06.674+0900 D/rpm-installer(11430): pizObLjDtWfHi+QqAzA7MyxJ61OElahSpY0ylI0kuAP+VGoqk3VZ2ASRjeo3j9riAxr0nWdAZs/g
04-01 03:58:06.674+0900 D/rpm-installer(11430): gEUOPJhBA+Nu6FyZi1A0J6aBfvMd/UBo4mFOR7rlA6fz2/AbwLu8NXgA5hunY8BUMXAn9UegngcB
04-01 03:58:06.674+0900 D/rpm-installer(11430): EFF52Ch1KRqd52u4+QE=
04-01 03:58:06.674+0900 D/rpm-installer(11430): rpm-installer-signature.c: _ri_process_x509certificate(441) > x509certificate, len=[909]
04-01 03:58:06.674+0900 D/rpm-installer(11430): 
04-01 03:58:06.674+0900 D/rpm-installer(11430): MIICmzCCAgQCCQDXI7WLdVZwiTANBgkqhkiG9w0BAQUFADCBjzELMAkGA1UEBhMCS1IxDjAMBgNV
04-01 03:58:06.674+0900 D/rpm-installer(11430): BAgMBVN1d29uMQ4wDAYDVQQHDAVTdXdvbjEWMBQGA1UECgwNVGl6ZW4gVGVzdCBDQTEiMCAGA1UE
04-01 03:58:06.674+0900 D/rpm-installer(11430): CwwZVGl6ZW4gRGlzdHJpYnV0b3IgVGVzdCBDQTEkMCIGA1UEAwwbVGl6ZW4gUHVibGljIERpc3Ry
04-01 03:58:06.674+0900 D/rpm-installer(11430): aWJ1dG9yIENBMB4XDTEyMTAyOTEzMDMwNFoXDTIyMTAyNzEzMDMwNFowgZMxCzAJBgNVBAYTAktS
04-01 03:58:06.674+0900 D/rpm-installer(11430): MQ4wDAYDVQQIDAVTdXdvbjEOMAwGA1UEBwwFU3V3b24xFjAUBgNVBAoMDVRpemVuIFRlc3QgQ0Ex
04-01 03:58:06.674+0900 D/rpm-installer(11430): IjAgBgNVBAsMGVRpemVuIERpc3RyaWJ1dG9yIFRlc3QgQ0ExKDAmBgNVBAMMH1RpemVuIFB1Ymxp
04-01 03:58:06.674+0900 D/rpm-installer(11430): YyBEaXN0cmlidXRvciBTaWduZXIwgZ8wDQYJKoZIhvcNAQEBBQADgY0AMIGJAoGBALtMvlc5hENK
04-01 03:58:06.674+0900 D/rpm-installer(11430): 90ZdA+y66+Sy0enD1gpZDBh5T9RP0oRsptJv5jjNTseQbQi0SZOdOXb6J7iQdlBCtR343RpIEz8H
04-01 03:58:06.674+0900 D/rpm-installer(11430): mrBy7mSY7mgwoU4EPpp4CTSUeAuKcmvrNOngTp5Hv7Ngf02TTHOLK3hZLpGayaDviyNZB5PdqQdB
04-01 03:58:06.674+0900 D/rpm-installer(11430): hokKjzAzAgMBAAEwDQYJKoZIhvcNAQEFBQADgYEAvGp1gxxAIlFfhJH1efjb9BJK/rtRkbYn9+Ez
04-01 03:58:06.674+0900 D/rpm-installer(11430): GEbEULg1svsgnyWisFimI3uFvgI/swzr1eKVY3Sc8MQ3+Fdy3EkbDZ2+WAubhcEkorTWjzWz2fL1
04-01 03:58:06.674+0900 D/rpm-installer(11430): vKaYjeIsuEX6TVRUugHWudPzcEuQRLQf8ibZWjbQdBmpeQYBMg5x+xKLCJc=
04-01 03:58:06.674+0900 D/rpm-installer(11430): rpm-installer-signature.c: _ri_process_x509certificate(441) > x509certificate, len=[942]
04-01 03:58:06.674+0900 D/rpm-installer(11430): 
04-01 03:58:06.674+0900 D/rpm-installer(11430): MIICtDCCAh2gAwIBAgIJAMDbehElPNKvMA0GCSqGSIb3DQEBBQUAMIGVMQswCQYDVQQGEwJLUjEO
04-01 03:58:06.674+0900 D/rpm-installer(11430): MAwGA1UECAwFU3V3b24xDjAMBgNVBAcMBVN1d29uMRYwFAYDVQQKDA1UaXplbiBUZXN0IENBMSMw
04-01 03:58:06.674+0900 D/rpm-installer(11430): IQYDVQQLDBpUVGl6ZW4gRGlzdHJpYnV0b3IgVGVzdCBDQTEpMCcGA1UEAwwgVGl6ZW4gUHVibGlj
04-01 03:58:06.674+0900 D/rpm-installer(11430): IERpc3RyaWJ1dG9yIFJvb3QgQ0EwHhcNMTIxMDI5MTMwMjUwWhcNMjIxMDI3MTMwMjUwWjCBjzEL
04-01 03:58:06.674+0900 D/rpm-installer(11430): MAkGA1UEBhMCS1IxDjAMBgNVBAgMBVN1d29uMQ4wDAYDVQQHDAVTdXdvbjEWMBQGA1UECgwNVGl6
04-01 03:58:06.674+0900 D/rpm-installer(11430): ZW4gVGVzdCBDQTEiMCAGA1UECwwZVGl6ZW4gRGlzdHJpYnV0b3IgVGVzdCBDQTEkMCIGA1UEAwwb
04-01 03:58:06.674+0900 D/rpm-installer(11430): VGl6ZW4gUHVibGljIERpc3RyaWJ1dG9yIENBMIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQDe
04-01 03:58:06.674+0900 D/rpm-installer(11430): OTS/3nXvkDEmsFCJIvRlQ3RKDcxdWJJp625pFqHdmoJBdV+x6jl1raGK2Y1sp2Gdvpjc/z92yzAp
04-01 03:58:06.674+0900 D/rpm-installer(11430): bE/UVLPh/tRNZPeGhzU4ejDDm7kzdr2f7Ia0U98K+OoY12ucwg7TYNItj9is7Cj4blGfuMDzd2ah
04-01 03:58:06.674+0900 D/rpm-installer(11430): 2AgnCGlwNwV/pv+uVQIDAQABoxAwDjAMBgNVHRMEBTADAQH/MA0GCSqGSIb3DQEBBQUAA4GBACqJ
04-01 03:58:06.674+0900 D/rpm-installer(11430): KO33YdoGudwanZIxMdXuxnnD9R6u72ltKk1S4zPfMJJv482CRGCI4FK6djhlsI4i0Lt1SVIJEed+
04-01 03:58:06.674+0900 D/rpm-installer(11430): yc3qckGm19dW+4xdlkekon7pViEBWuyHw8OWv3RXtTum1+PGHjBJ2eYY4ZKIpz73U/1NC16sTB/0
04-01 03:58:06.674+0900 D/rpm-installer(11430): VhfnkHwPl
04-01 03:58:06.674+0900 D/CERT_SVC(11430): cert-service.c: _cert_svc_verify_certificate_with_caflag(188) > [SECURE_LOG] root cert path : /usr/share/cert-svc/certs/code-signing/tizen/tizen-distributor-root-ca-public.pem
04-01 03:58:06.674+0900 D/rpm-installer(11430): rpm-installer.c: _ri_verify_sig_and_cert(1744) > cert_svc_verify() is done successfully. validity=[1]
04-01 03:58:06.674+0900 D/rpm-installer(11430): rpm-installer.c: _ri_verify_sig_and_cert(1758) > cert_svc_get_visibility() returns visibility=[64]
04-01 03:58:06.674+0900 D/rpm-installer(11430): rpm-installer.c: _ri_verify_sig_and_cert(1771) > Root CA cert path=[/usr/share/cert-svc/certs/code-signing/tizen/tizen-distributor-root-ca-public.pem]
04-01 03:58:06.674+0900 D/rpm-installer(11430): rpm-installer.c: __ri_verify_file(336) > valid signature
04-01 03:58:06.674+0900 D/rpm-installer(11430): rpm-installer.c: __ri_get_cert_from_file(1029) > Root CA, len=[908]
04-01 03:58:06.674+0900 D/rpm-installer(11430): MIICozCCAgwCCQD9XW6kNg4bbjANBgkqhkiG9w0BAQUFADCBlTELMAkGA1UEBhMCS1IxDjAMBgNVBAgMBVN1d29uMQ4wDAYDVQQHDAVTdXdvbjEWMBQGA1UECgwNVGl6ZW4gVGVzdCBDQTEjMCEGA1UECwwaVFRpemVuIERpc3RyaWJ1dG9yIFRlc3QgQ0ExKTAnBgNVBAMMIFRpemVuIFB1YmxpYyBEaXN0cmlidXRvciBSb290IENBMB4XDTEyMTAyNjA4MDAyN1oXDTIyMTAyNDA4MDAyN1owgZUxCzAJBgNVBAYTAktSMQ4wDAYDVQQIDAVTdXdvbjEOMAwGA1UEBwwFU3V3b24xFjAUBgNVBAoMDVRpemVuIFRlc3QgQ0ExIzAhBgNVBAsMGlRUaXplbiBEaXN0cmlidXRvciBUZXN0IENBMSkwJwYDVQQDDCBUaXplbiBQdWJsaWMgRGlzdHJpYnV0b3IgUm9vdCBDQTCBnzANBgkqhkiG9w0BAQEFAAOBjQAwgYkCgYEA8o0kPY1U9El1BbBUF1k4jCq6mH8a6MmDJdjgsz+hILAYsPWimRTXUcW8GAUWhZWgm1Fbb49xWcasA8b4bIJabC/6hLb8uWiozzpRXyQJbe7k//RocskRqDmFOky8ANFsCCww72/Xbq8BFK1sxlGdmOWQiGwDWBDlS2Lw1XOMqb0CAwEAATANBgkqhkiG9w0BAQUFAAOBgQBUotZqTNFr+SNyqeZqhOToRsg3ojN1VJUa07qdlVo5I1UObSE+UTJPJ0NtSj7OyTY7fF3E4xzUv/w8aUoabQP1erEmztY/AVD+phHaPytkZ/Dx+zDZ1u5e9bKm5zfY4dQs/A53zDQta5a/NkZOEF97Dj3+bzAh2bP7KOszlocFYw==
04-01 03:58:06.674+0900 D/rpm-installer(11430): coretpk-installer.c: _coretpk_installer_verify_signatures(1284) > _ri_verify_sig_and_cert(/opt/usr/apps/org.example.example/signature1.xml) succeed.
04-01 03:58:06.674+0900 D/rpm-installer(11430): coretpk-installer.c: _coretpk_installer_package_reinstall(4980) > signature and certificate verifying success
04-01 03:58:06.674+0900 D/PKGMGR  (11430): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(11430), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(60)
04-01 03:58:06.674+0900 D/PKGMGR  (11430): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(11430), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(60)
04-01 03:58:06.674+0900 D/PKGMGR  (11430): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
04-01 03:58:06.674+0900 D/PKGMGR_INSTALLER(11430): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.example] key[install_percent] value[60]
04-01 03:58:06.674+0900 D/PKGMGR  (11430): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(11430), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(60)
04-01 03:58:06.674+0900 D/PKGMGR  (11430): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(11430), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(60)
04-01 03:58:06.674+0900 D/PKGMGR  (11430): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.install.progress), signal_name(install_progress)
04-01 03:58:06.674+0900 E/PKGMGR_CERT(11430): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-01 03:58:06.674+0900 D/PKGMGR  ( 3098): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-01 03:58:06.674+0900 D/PKGMGR  (11428): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-01 03:58:06.674+0900 D/PKGMGR  ( 2976): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-01 03:58:06.674+0900 D/PKGMGR  ( 2974): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-01 03:58:06.674+0900 D/ESD     ( 2974): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29740002), pkg_type(tpk), pkgid(org.example.example), key(install_percent), val(60)
04-01 03:58:06.674+0900 D/PKGMGR  ( 2968): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-01 03:58:06.674+0900 D/QUICKPANEL( 2968): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:install_percent val:60
04-01 03:58:06.674+0900 E/PKGMGR_CERT(11430): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 17
04-01 03:58:06.674+0900 D/PKGMGR  ( 2983): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-01 03:58:06.674+0900 D/PKGMGR  ( 2983): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
04-01 03:58:06.674+0900 E/PKGMGR_CERT(11430): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 17
04-01 03:58:06.674+0900 D/PKGMGR  ( 2960): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-01 03:58:06.674+0900 E/PKGMGR_CERT(11430): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 10 2
04-01 03:58:06.674+0900 D/DATA_PROVIDER_MASTER( 2960): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.example] 60
04-01 03:58:06.674+0900 E/PKGMGR_CERT(11430): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 7 5
04-01 03:58:06.674+0900 E/PKGMGR_CERT(11430): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 8 5
04-01 03:58:06.674+0900 E/PKGMGR_CERT(11430): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 9 5
04-01 03:58:06.694+0900 D/PKGMGR  ( 3052): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-01 03:58:06.694+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-01 03:58:06.694+0900 W/cluster-home( 2906): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.example]
04-01 03:58:06.694+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-01 03:58:06.694+0900 D/cluster-home( 2906): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29060003] pkg_type[tpk] package[org.example.example] key[install_percent] val[60] pmsg[(null)]
04-01 03:58:06.694+0900 E/PKGMGR_CERT(11430): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-01 03:58:06.694+0900 D/rpm-installer(11430): rpm-installer-privilege.c: _ri_privilege_unregister_package(85) > [smack] app_uninstall(org.example.example), result=[0]
04-01 03:58:06.694+0900 D/rpm-installer(11430): rpm-installer-privilege.c: _ri_privilege_register_package(65) > [smack] app_install(org.example.example), result=[0]
04-01 03:58:06.694+0900 D/rpm-installer(11430): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example, 5, _), result=[0]
04-01 03:58:06.694+0900 D/rpm-installer(11430): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/shared, 5, _), result=[0]
04-01 03:58:06.694+0900 D/rpm-installer(11430): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/shared/res, 5, _), result=[0]
04-01 03:58:06.694+0900 D/rpm-installer(11430): rpm-installer-privilege.c: _ri_privilege_setup_path(117) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/shared/data, 2), result=[0]
04-01 03:58:06.694+0900 D/rpm-installer(11430): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1101) > [smack] get_smack_label, path=[/opt/usr/apps/org.example.example/shared/data], label=[$1$org.exam$u8BwfYMV9u%MYLLw2JGhj1]
04-01 03:58:06.694+0900 D/rpm-installer(11430): coretpk-installer.c: _coretpk_installer_set_smack_label_access(1088) > [smack] set_smack_label, path=[/opt/usr/apps/org.example.example/shared/cache], label=[$1$org.exam$u8BwfYMV9u%MYLLw2JGhj1]
04-01 03:58:06.694+0900 E/rpm-installer(11430): installer-util.c: _installer_util_get_configuration_value(418) > [signature]=[on]
04-01 03:58:06.694+0900 D/rpm-installer(11430): coretpk-installer.c: _coretpk_installer_get_group_id(2472) > encoding done, len=[28]
04-01 03:58:06.694+0900 D/rpm-installer(11430): coretpk-installer.c: _coretpk_installer_apply_smack(2575) > groupid = [lRCBhlfBM8hN+lAnIV9z4vodWRE=] for shared/trusted.
04-01 03:58:06.694+0900 D/rpm-installer(11430): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/shared/trusted, 1, lRCBhlfBM8hN+lAnIV9z4vodWRE=), result=[0]
04-01 03:58:06.694+0900 D/rpm-installer(11430): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/bin, 0, org.example.example), result=[0]
04-01 03:58:06.694+0900 D/rpm-installer(11430): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/data, 0, org.example.example), result=[0]
04-01 03:58:06.694+0900 D/rpm-installer(11430): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/lib, 0, org.example.example), result=[0]
04-01 03:58:06.694+0900 D/rpm-installer(11430): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/res, 0, org.example.example), result=[0]
04-01 03:58:06.694+0900 D/rpm-installer(11430): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/cache, 0, org.example.example), result=[0]
04-01 03:58:06.694+0900 D/rpm-installer(11430): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/tizen-manifest.xml, 0, org.example.example), result=[0]
04-01 03:58:06.694+0900 D/rpm-installer(11430): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/author-signature.xml, 0, org.example.example), result=[0]
04-01 03:58:06.694+0900 D/rpm-installer(11430): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/signature1.xml, 0, org.example.example), result=[0]
04-01 03:58:06.694+0900 D/rpm-installer(11430): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/share/packages/org.example.example.xml, 0, org.example.example), result=[0]
04-01 03:58:06.714+0900 D/rpm-installer(11430): rpm-installer-privilege.c: _ri_privilege_set_package_version(75) > [smack] app[org.example.example] version set to [2.4] result=[0]
04-01 03:58:06.714+0900 D/rpm-installer(11430): rpm-installer.c: _ri_apply_privilege(1924) > api-version[2.4] fot privilege has done successfully.
04-01 03:58:06.714+0900 D/rpm-installer(11430): rpm-installer-privilege.c: _ri_privilege_enable_permissions(106) > [smack] app_enable_permissions(org.example.example, 7), result=[0]
04-01 03:58:06.714+0900 D/rpm-installer(11430): coretpk-installer.c: _coretpk_installer_package_reinstall(5083) > #permission applying success.
04-01 03:58:06.714+0900 D/PKGMGR  (11430): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(11430), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
04-01 03:58:06.714+0900 D/PKGMGR  (11430): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(11430), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
04-01 03:58:06.714+0900 D/PKGMGR  (11430): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
04-01 03:58:06.714+0900 D/PKGMGR_INSTALLER(11430): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.example] key[install_percent] value[100]
04-01 03:58:06.714+0900 D/PKGMGR  (11430): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(11430), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
04-01 03:58:06.714+0900 D/PKGMGR  (11430): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(11430), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
04-01 03:58:06.714+0900 D/PKGMGR  (11430): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.install.progress), signal_name(install_progress)
04-01 03:58:06.714+0900 D/rpm-installer(11430): coretpk-installer.c: _coretpk_installer_package_reinstall(5096) > _coretpk_installer_package_reinstall(org.example.example) is done.
04-01 03:58:06.714+0900 D/PKGMGR  (11430): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(11430), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
04-01 03:58:06.714+0900 D/PKGMGR  (11430): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(11430), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
04-01 03:58:06.714+0900 D/PKGMGR  (11430): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
04-01 03:58:06.714+0900 D/PKGMGR_INSTALLER(11430): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.example] key[end] value[ok]
04-01 03:58:06.714+0900 D/PKGMGR  (11430): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(11430), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
04-01 03:58:06.714+0900 D/PKGMGR  (11430): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(11430), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
04-01 03:58:06.714+0900 D/PKGMGR  (11430): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.upgrade), signal_name(upgrade)
04-01 03:58:06.714+0900 D/PKGMGR  ( 2976): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 03:58:06.714+0900 D/PKGMGR  ( 2968): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 03:58:06.714+0900 D/QUICKPANEL( 2968): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:install_percent val:100
04-01 03:58:06.714+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 03:58:06.714+0900 W/cluster-home( 2906): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.example]
04-01 03:58:06.714+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 03:58:06.714+0900 D/cluster-home( 2906): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29060003] pkg_type[tpk] package[org.example.example] key[install_percent] val[100] pmsg[(null)]
04-01 03:58:06.714+0900 D/PKGMGR  ( 2976): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 03:58:06.714+0900 D/PKGMGR  ( 2968): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 03:58:06.714+0900 D/QUICKPANEL( 2968): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:end val:ok
04-01 03:58:06.714+0900 D/PKGMGR  ( 2763): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[upgrade], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 03:58:06.714+0900 D/AUL_AMD ( 2763): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.example), key(end), value(ok)
04-01 03:58:06.714+0900 W/AUL_AMD ( 2763): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(update), value(ok)
04-01 03:58:06.714+0900 D/PKGMGR  ( 3098): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 03:58:06.714+0900 D/PKGMGR  ( 3098): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 03:58:06.714+0900 D/PKGMGR  ( 2974): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 03:58:06.714+0900 D/ESD     ( 2974): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29740002), pkg_type(tpk), pkgid(org.example.example), key(install_percent), val(100)
04-01 03:58:06.714+0900 D/PKGMGR  ( 2974): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 03:58:06.714+0900 D/ESD     ( 2974): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29740002), pkg_type(tpk), pkgid(org.example.example), key(end), val(ok)
04-01 03:58:06.714+0900 D/ESD     ( 2974): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
04-01 03:58:06.714+0900 D/AUL_AMD ( 2763): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.example, type:rpm
04-01 03:58:06.714+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 03:58:06.714+0900 W/cluster-home( 2906): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[2], package[org.example.example]
04-01 03:58:06.714+0900 D/cluster-home( 2906): widget-data-provider.cpp: PackageUpdated(2160) >  No boxes that pkgname is[org.example.example]
04-01 03:58:06.714+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 03:58:06.714+0900 D/cluster-home( 2906): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29060003] pkg_type[tpk] package[org.example.example] key[end] val[ok] pmsg[(null)]
04-01 03:58:06.714+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
04-01 03:58:06.714+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
04-01 03:58:06.714+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
04-01 03:58:06.714+0900 D/PKGMGR  ( 2983): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 03:58:06.714+0900 D/PKGMGR  ( 2983): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
04-01 03:58:06.714+0900 D/PKGMGR  ( 2983): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 03:58:06.714+0900 D/PKGMGR  ( 2983): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
04-01 03:58:06.714+0900 D/cluster-home( 2906): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
04-01 03:58:06.714+0900 D/cluster-home( 2906): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.example]
04-01 03:58:06.714+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.example]
04-01 03:58:06.714+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.example]
04-01 03:58:06.714+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
04-01 03:58:06.714+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
04-01 03:58:06.714+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.example]
04-01 03:58:06.714+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.example] Name[example] Icon[/opt/usr/apps/org.example.example/shared/res/example.png] enable[1] system[0]
04-01 03:58:06.714+0900 D/cluster-home( 2906): mainmenu-presenter.cpp: OnAppUpdated(337) >  pAppId [org.example.example]
04-01 03:58:06.714+0900 D/cluster-home( 2906): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.example
04-01 03:58:06.714+0900 D/cluster-home( 2906): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[14], isFolder[0], pageId[1], col[2], row[4], appId[org.example.example], name[example], menuId[1], isPreload[0] isPreload[0]
04-01 03:58:06.714+0900 D/cluster-home( 2906): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
04-01 03:58:06.714+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.example] Name[example] Icon[/opt/usr/apps/org.example.example/shared/res/example.png] enable[1] system[0]
04-01 03:58:06.714+0900 D/cluster-home( 2906): mainmenu-presenter.cpp: OnAppUpdated(364) >  name [example]
04-01 03:58:06.714+0900 D/cluster-home( 2906): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
04-01 03:58:06.714+0900 D/cluster-home( 2906): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
04-01 03:58:06.714+0900 D/test-log( 2906): mainmenu-box-impl.cpp: UpdateBoxData(812) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.example/shared/res/example.png], New icon path[/opt/usr/apps/org.example.example/shared/res/example.png]!!!!!
04-01 03:58:06.714+0900 D/cluster-home( 2906): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 1, appId = $appId, name = $name, col = 2, row = 4, isPreload = 0, isSystem = 0 WHERE boxId = 14]
04-01 03:58:06.724+0900 D/PKGMGR  ( 3052): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 03:58:06.724+0900 D/PKGMGR  ( 3052): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 03:58:06.724+0900 D/ISF_PANEL_EFL( 3052): isf_panel_efl.cpp: _package_manager_event_cb(1288) > type=tpk package=org.example.example event_type=UPDATE event_state=COMPLETED progress=100 error=0
04-01 03:58:06.724+0900 W/ISF_PANEL_EFL( 3052): isf_panel_efl.cpp: _package_manager_event_cb(1380) > isf_db_select_appids_by_pkgid returned 0.
04-01 03:58:06.724+0900 D/PKGMGR  (11428): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 03:58:06.724+0900 D/PKGMGR  ( 2960): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 03:58:06.724+0900 D/DATA_PROVIDER_MASTER( 2960): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.example] 100
04-01 03:58:06.724+0900 D/PKGMGR  ( 2960): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 03:58:06.724+0900 D/DATA_PROVIDER_MASTER( 2960): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.example] ok
04-01 03:58:06.724+0900 D/DATA_PROVIDER_MASTER( 2960): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.example], event_type[1]
04-01 03:58:06.724+0900 D/PKGMGR  (11428): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1674722505], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 03:58:06.724+0900 D/DATA_PROVIDER_MASTER( 2960): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
04-01 03:58:06.724+0900 D/DATA_PROVIDER_MASTER( 2960): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
04-01 03:58:06.724+0900 D/DATA_PROVIDER_MASTER( 2960): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
04-01 03:58:06.724+0900 D/DATA_PROVIDER_MASTER( 2960): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.example]
04-01 03:58:06.844+0900 D/rpm-installer(11430): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
04-01 03:58:06.844+0900 D/rpm-installer(11430): rpm-appcore-intf.c: main(259) > ------------------------------------------------
04-01 03:58:06.844+0900 D/rpm-installer(11430): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
04-01 03:58:06.844+0900 D/rpm-installer(11430): rpm-appcore-intf.c: main(261) > ------------------------------------------------
04-01 03:58:06.854+0900 D/PKGMGR_SERVER(11340): pkgmgr-server.c: sighandler(387) > child exit [11430]
04-01 03:58:06.854+0900 E/PKGMGR_SERVER(11340): pkgmgr-server.c: sighandler(402) > child NORMAL exit [11430]
04-01 03:58:07.034+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(838) > __request_handler: 0
04-01 03:58:07.034+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
04-01 03:58:07.034+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
04-01 03:58:07.034+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
04-01 03:58:07.034+0900 I/AUL     ( 2763): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
04-01 03:58:07.034+0900 D/AUL     ( 2763): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 11480, pid = 11482
04-01 03:58:07.034+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
04-01 03:58:07.034+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
04-01 03:58:07.034+0900 I/AUL     ( 2763): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
04-01 03:58:07.034+0900 E/AUL_AMD ( 2763): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
04-01 03:58:07.034+0900 W/AUL_AMD ( 2763): amd_launch.c: _start_app(2233) > caller pid : 11482
04-01 03:58:07.034+0900 E/AUL_AMD ( 2763): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
04-01 03:58:07.034+0900 W/AUL_AMD ( 2763): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
04-01 03:58:07.034+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2648) > process_pool: false
04-01 03:58:07.034+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
04-01 03:58:07.034+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
04-01 03:58:07.034+0900 W/AUL_AMD ( 2763): amd_launch.c: _start_app(2665) > pad pid(-5)
04-01 03:58:07.034+0900 D/AUL_AMD ( 2763): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
04-01 03:58:07.034+0900 D/AUL_AMD ( 2763): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
04-01 03:58:07.034+0900 D/AUL     ( 2763): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
04-01 03:58:07.034+0900 W/AUL_PAD ( 2958): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
04-01 03:58:07.034+0900 D/AUL     ( 2958): process_pool.c: __send_pkt_raw_data(219) > send(13) : 620 / 620
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 11248, bin path: /opt/usr/apps/org.example.example/bin/example
04-01 03:58:07.034+0900 W/AUL_PAD ( 2958): launchpad.c: __send_result_to_caller(265) > Check app launching
04-01 03:58:07.034+0900 D/AUL_PAD ( 2958): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
04-01 03:58:07.034+0900 D/RESOURCED( 2892): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
04-01 03:58:07.034+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
04-01 03:58:07.034+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
04-01 03:58:07.034+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
04-01 03:58:07.034+0900 D/RESOURCED( 2892): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 2
04-01 03:58:07.064+0900 E/RESOURCED( 2892): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-01 03:58:07.064+0900 D/AUL_PAD (11248): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
04-01 03:58:07.064+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
04-01 03:58:07.064+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
04-01 03:58:07.064+0900 D/AUL     (11248): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (11270) is sent.
04-01 03:58:07.064+0900 D/AUL     (11248): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 11270, signo: 10
04-01 03:58:07.064+0900 D/AUL     (11248): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
04-01 03:58:07.064+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
04-01 03:58:07.064+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
04-01 03:58:07.064+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
04-01 03:58:07.064+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
04-01 03:58:07.064+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : MwAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEQAAADE0OTA5ODY2ODcvNjYzODUA##
04-01 03:58:07.064+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
04-01 03:58:07.064+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAxMTQ4MgA=##
04-01 03:58:07.064+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
04-01 03:58:07.064+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
04-01 03:58:07.064+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
04-01 03:58:07.064+0900 D/AUL_PAD (11248): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
04-01 03:58:07.064+0900 D/AUL_PAD (11248): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
04-01 03:58:07.064+0900 I/CAPI_APPFW_APPLICATION(11248): app_main.c: ui_app_main(788) > app_efl_main
04-01 03:58:07.064+0900 D/LAUNCH  (11248): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
04-01 03:58:07.064+0900 D/APP_CORE(11248): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
04-01 03:58:07.064+0900 D/APP_CORE(11248): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
04-01 03:58:07.064+0900 D/APP_CORE(11248): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
04-01 03:58:07.064+0900 D/APP_CORE(11248): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
04-01 03:58:07.064+0900 D/AUL     (11248): app_sock.c: __create_server_sock(156) > pg path - already exists
04-01 03:58:07.064+0900 D/APP_CORE(11248): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42d9520
04-01 03:58:07.064+0900 D/LAUNCH  (11248): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
04-01 03:58:07.064+0900 I/CAPI_APPFW_APPLICATION(11248): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
04-01 03:58:07.084+0900 E/EFL     (11248): <11248> lib/edje/edje_smart.c:22 edje_object_add() safety check failed: evas == NULL
04-01 03:58:07.104+0900 W/CRASH_MANAGER(11487): worker.c: worker_job(1204) > 1111248657861149098668
