S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 28015
Date: 2017-04-01 07:37:36+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x1356

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb837c510, esi = 0x00000008
ebp = 0xbf9295a8, esp = 0xbf9294cc
eax = 0x00000000, ebx = 0xb3783000
ecx = 0xb6dc7848, edx = 0xb837af01
eip = 0x00001356

Memory Information
MemTotal:      123 KB
MemFree:        16 KB
Buffers:        12 KB
Cached:     174560 KB
VmPeak:     100136 KB
VmSize:      87908 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22736 KB
VmRSS:       16816 KB
VmData:      28488 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33132 KB
VmPTE:          72 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 28015 TID = 28015
28015 28253 

Maps Information
b2c75000 b2c81000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2ca8000 b2ca9000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2caa000 b2caf000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2cb0000 b2cb1000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2cb2000 b2cb4000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2cb5000 b2cb7000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2cb8000 b2cc4000 r-xp /usr/lib/libdrm.so.2.4.0
b2cc5000 b2cc8000 r-xp /usr/lib/libdri2.so.0.0.0
b2cc9000 b2cd3000 r-xp /usr/lib/libtbm.so.1.0.0
b2cde000 b2ce1000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b2ce2000 b2ce5000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b2ce6000 b2cfb000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2cfc000 b2d0e000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3617000 b361d000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b361e000 b3762000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3772000 b3773000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b3774000 b377d000 r-xp /usr/lib/libefl-extension.so.0.1.0
b377e000 b3782000 r-xp /opt/usr/apps/org.example.example/bin/example
b3784000 b37bd000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41c0000 b41cb000 r-xp /lib/libnss_files-2.20-2014.11.so
b41cd000 b41d8000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41da000 b41f1000 r-xp /lib/libnsl-2.20-2014.11.so
b41f5000 b41fd000 r-xp /lib/libnss_compat-2.20-2014.11.so
b41ff000 b4223000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4224000 b4225000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4226000 b4229000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b422a000 b4231000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4232000 b423c000 r-xp /usr/lib/libsensord-share.so
b423d000 b4259000 r-xp /usr/lib/libsensor.so.1.2.0
b425b000 b4264000 r-xp /usr/lib/libappcore-common.so.1.1
b427e000 b4280000 r-xp /usr/lib/libXau.so.6.0.0
b4281000 b42a3000 r-xp /usr/lib/libxcb.so.1.1.0
b42a5000 b42ae000 r-xp /lib/libcrypt-2.20-2014.11.so
b42d7000 b42d9000 r-xp /usr/lib/libiri.so
b42da000 b4300000 r-xp /lib/libexpat.so.1.5.2
b4302000 b436d000 r-xp /usr/lib/libssl.so.1.0.0
b4373000 b437f000 r-xp /usr/lib/libethumb.so.1.13.0
b4380000 b4384000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4385000 b45d6000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b51000 b5b61000 r-xp /usr/lib/libXi.so.6.1.0
b5b62000 b5b64000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b65000 b5b6b000 r-xp /usr/lib/libXtst.so.6.1.0
b5b6c000 b5b76000 r-xp /usr/lib/libXrender.so.1.3.0
b5b77000 b5b80000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b82000 b5b84000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b85000 b5b8a000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b8b000 b5b9d000 r-xp /usr/lib/libXext.so.6.4.0
b5b9e000 b5ba0000 r-xp /usr/lib/libXdamage.so.1.1.0
b5ba1000 b5ba3000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5ba5000 b5ce7000 r-xp /usr/lib/libX11.so.6.3.0
b5ceb000 b5cf5000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cf6000 b5d0c000 r-xp /usr/lib/libudev.so.1.6.0
b5d0f000 b5d13000 r-xp /lib/libattr.so.1.1.0
b5d14000 b5d43000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d45000 b5d4b000 r-xp /usr/lib/libffi.so.6.0.2
b5d4c000 b5d6f000 r-xp /lib/libz.so.1.2.8
b5d70000 b5d73000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d74000 b5ed0000 r-xp /usr/lib/libxml2.so.2.9.2
b5ed6000 b5fbd000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fca000 b5fcd000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fce000 b5ff0000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ff1000 b6005000 r-xp /lib/libresolv-2.20-2014.11.so
b6009000 b602d000 r-xp /usr/lib/liblzma.so.5.0.3
b602e000 b6030000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6032000 b603c000 r-xp /usr/lib/libembryo.so.1.13.0
b603d000 b6066000 r-xp /usr/lib/libpng12.so.0.50.0
b6067000 b60b0000 r-xp /usr/lib/libjpeg.so.8.0.2
b60c1000 b60c8000 r-xp /lib/librt-2.20-2014.11.so
b60ca000 b60e9000 r-xp /usr/lib/libector.so.1.13.0
b60ec000 b6119000 r-xp /usr/lib/liblua-5.1.so
b611a000 b61aa000 r-xp /usr/lib/libfreetype.so.6.11.3
b61ae000 b61ec000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61ed000 b6203000 r-xp /usr/lib/libfribidi.so.0.3.1
b6204000 b625d000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6260000 b62ab000 r-xp /lib/libm-2.20-2014.11.so
b62ad000 b62bf000 r-xp /usr/lib/libeio.so.1.13.0
b62c0000 b62c3000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62c4000 b62ca000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62cb000 b62ee000 r-xp /usr/lib/libefreet.so.1.13.0
b62f1000 b631c000 r-xp /usr/lib/libeldbus.so.1.13.0
b631d000 b6351000 r-xp /usr/lib/libecore_con.so.1.13.0
b6353000 b635c000 r-xp /usr/lib/libecore_imf.so.1.13.0
b635d000 b6366000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6367000 b637a000 r-xp /usr/lib/libeo.so.1.13.0
b637c000 b638f000 r-xp /usr/lib/libecore_input.so.1.13.0
b6390000 b6397000 r-xp /usr/lib/libecore_file.so.1.13.0
b6398000 b63bb000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63bc000 b63e8000 r-xp /usr/lib/libeet.so.1.13.0
b63f1000 b645c000 r-xp /usr/lib/libeina.so.1.13.0
b645f000 b6476000 r-xp /usr/lib/libefl.so.1.13.0
b6478000 b65df000 r-xp /usr/lib/libicuuc.so.51.1
b65ed000 b67f9000 r-xp /usr/lib/libicui18n.so.51.1
b6801000 b6850000 r-xp /usr/lib/libecore_x.so.1.13.0
b6852000 b686c000 r-xp /lib/libgcc_s-4.9.so.1
b686e000 b6872000 r-xp /lib/libcap.so.2.21
b6873000 b68b9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68ba000 b68c1000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68c3000 b6915000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6917000 b6aa2000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6aa7000 b6b75000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b78000 b6b7c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b7d000 b6b8c000 r-xp /usr/lib/libvconf.so.0.2.45
b6b8d000 b6b90000 r-xp /usr/lib/libvasum.so.0.3.1
b6b91000 b6b94000 r-xp /usr/lib/libttrace.so.1.1
b6b96000 b6b9a000 r-xp /usr/lib/libiniparser.so.0
b6b9b000 b6bcb000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bcc000 b6bd5000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bd6000 b6bfb000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bfc000 b6c0c000 r-xp /usr/lib/libunwind.so.8.0.1
b6c16000 b6dc4000 r-xp /lib/libc-2.20-2014.11.so
b6dcc000 b6f0f000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f11000 b6f69000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f6a000 b6f9e000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fa1000 b7075000 r-xp /usr/lib/libedje.so.1.13.0
b7078000 b70a4000 r-xp /usr/lib/libecore.so.1.13.0
b70b5000 b72db000 r-xp /usr/lib/libevas.so.1.13.0
b7303000 b731b000 r-xp /lib/libpthread-2.20-2014.11.so
b731f000 b7699000 r-xp /usr/lib/libelementary.so.1.13.0
b76b9000 b76bd000 r-xp /usr/lib/libsmack.so.1.0.0
b76be000 b76c7000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76c8000 b76cb000 r-xp /usr/lib/libdlog.so.0.0.0
b76cc000 b76d1000 r-xp /usr/lib/libbundle.so.0.1.22
b76d2000 b76d5000 r-xp /lib/libdl-2.20-2014.11.so
b76d7000 b76fc000 r-xp /usr/lib/libaul.so.0.1.0
b76ff000 b7701000 r-xp /usr/lib/libappsvc.so.0.1.0
b7702000 b7707000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7708000 b770f000 r-xp /usr/lib/libappcore-efl.so.1.1
b7711000 b7716000 r-xp /usr/lib/libsys-assert.so
b7719000 b771a000 r-xp [vdso]
b771a000 b773c000 r-xp /lib/ld-2.20-2014.11.so
b773e000 b7746000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:28015)
Call Stack Count: 3
 0: (0x1356) (null)
 1: create_base_gui + 0x1f8 (0xb7740148) [/opt/usr/apps/org.example.example/bin/example] + 0xb7740148
 2: __libc_start_main + 0xde (0xb6c2de4e) [/lib/libc.so.6] + 0x17e4e
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
wKRblGh0Hjn4fI+studFLLv6ldCLIpA/Ssgf9GuUbcjTC8OWBYPVUQ6YoXAcuHbfhr6a
04-01 07:37:36.529+0900 D/PKGMGR  ( 2976): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[start], value=[update]
04-01 07:37:36.529+0900 D/PKGMGR  (28379): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[start], value=[update]
04-01 07:37:36.529+0900 D/PKGMGR  ( 2960): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[start], value=[update]
04-01 07:37:36.529+0900 D/DATA_PROVIDER_MASTER( 2960): pkgmgr.c: start_cb(201) > [SECURE_LOG] [org.example.example] update
04-01 07:37:36.529+0900 D/PKGMGR  ( 2974): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[start], value=[update]
04-01 07:37:36.529+0900 D/ESD     ( 2974): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29740002), pkg_type(tpk), pkgid(org.example.example), key(start), val(update)
04-01 07:37:36.529+0900 D/ESD     ( 2974): esd_main.c: __esd_pkgmgr_event_callback(1720) > update start
04-01 07:37:36.529+0900 D/PKGMGR  ( 3098): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[start], value=[update]
04-01 07:37:36.529+0900 D/rpm-installer(28381): coretpk-installer.c: _coretpk_installer_verify_signatures(1274) > _ri_verify_sig_and_cert(/opt/usr/apps/org.example.example/author-signature.xml) succeed.
04-01 07:37:36.529+0900 D/PKGMGR  ( 3052): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[start], value=[update]
04-01 07:37:36.529+0900 D/PKGMGR  ( 2983): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[start], value=[update]
04-01 07:37:36.529+0900 D/PKGMGR  ( 2983): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
04-01 07:37:36.529+0900 D/PKGMGR  ( 2763): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[upgrade], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[start], value=[update]
04-01 07:37:36.529+0900 D/rpm-installer(28381): rpm-installer-signature.c: _ri_process_signaturevalue(533) > SignatureValue, len=[176]
04-01 07:37:36.529+0900 D/rpm-installer(28381): 
04-01 07:37:36.529+0900 D/rpm-installer(28381): spJJAVGeiHHD12otogOP5CINTH6G3ngd3/opnmgjXD6Q8uiCYC8FBhzG4CZ1a1ITEdNLowzovbHk
04-01 07:37:36.529+0900 D/rpm-installer(28381): LLUfjzrPirrT+Ycvdq2lO3K1RzsUuA9rwStuFZEjHKnMEaHz0VN+lZKqHFb0leiIyx9w4su+v5jW
04-01 07:37:36.529+0900 D/rpm-installer(28381): CseP/T6GAoOw9AMa0ls=
04-01 07:37:36.529+0900 D/AUL_AMD ( 2763): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.example), key(start), value(update)
04-01 07:37:36.529+0900 D/rpm-installer(28381): rpm-installer-signature.c: _ri_process_x509certificate(441) > x509certificate, len=[909]
04-01 07:37:36.529+0900 D/rpm-installer(28381): 
04-01 07:37:36.529+0900 D/rpm-installer(28381): MIICmzCCAgQCCQDXI7WLdVZwiTANBgkqhkiG9w0BAQUFADCBjzELMAkGA1UEBhMCS1IxDjAMBgNV
04-01 07:37:36.529+0900 D/rpm-installer(28381): BAgMBVN1d29uMQ4wDAYDVQQHDAVTdXdvbjEWMBQGA1UECgwNVGl6ZW4gVGVzdCBDQTEiMCAGA1UE
04-01 07:37:36.529+0900 D/rpm-installer(28381): CwwZVGl6ZW4gRGlzdHJpYnV0b3IgVGVzdCBDQTEkMCIGA1UEAwwbVGl6ZW4gUHVibGljIERpc3Ry
04-01 07:37:36.529+0900 D/rpm-installer(28381): aWJ1dG9yIENBMB4XDTEyMTAyOTEzMDMwNFoXDTIyMTAyNzEzMDMwNFowgZMxCzAJBgNVBAYTAktS
04-01 07:37:36.529+0900 D/rpm-installer(28381): MQ4wDAYDVQQIDAVTdXdvbjEOMAwGA1UEBwwFU3V3b24xFjAUBgNVBAoMDVRpemVuIFRlc3QgQ0Ex
04-01 07:37:36.529+0900 D/rpm-installer(28381): IjAgBgNVBAsMGVRpemVuIERpc3RyaWJ1dG9yIFRlc3QgQ0ExKDAmBgNVBAMMH1RpemVuIFB1Ymxp
04-01 07:37:36.529+0900 D/rpm-installer(28381): YyBEaXN0cmlidXRvciBTaWduZXIwgZ8wDQYJKoZIhvcNAQEBBQADgY0AMIGJAoGBALtMvlc5hENK
04-01 07:37:36.529+0900 D/rpm-installer(28381): 90ZdA+y66+Sy0enD1gpZDBh5T9RP0oRsptJv5jjNTseQbQi0SZOdOXb6J7iQdlBCtR343RpIEz8H
04-01 07:37:36.529+0900 D/rpm-installer(28381): mrBy7mSY7mgwoU4EPpp4CTSUeAuKcmvrNOngTp5Hv7Ngf02TTHOLK3hZLpGayaDviyNZB5PdqQdB
04-01 07:37:36.529+0900 D/rpm-installer(28381): hokKjzAzAgMBAAEwDQYJKoZIhvcNAQEFBQADgYEAvGp1gxxAIlFfhJH1efjb9BJK/rtRkbYn9+Ez
04-01 07:37:36.529+0900 D/rpm-installer(28381): GEbEULg1svsgnyWisFimI3uFvgI/swzr1eKVY3Sc8MQ3+Fdy3EkbDZ2+WAubhcEkorTWjzWz2fL1
04-01 07:37:36.529+0900 D/rpm-installer(28381): vKaYjeIsuEX6TVRUugHWudPzcEuQRLQf8ibZWjbQdBmpeQYBMg5x+xKLCJc=
04-01 07:37:36.529+0900 D/AUL_AMD ( 2763): amd_appinfo.c: __amd_pkgmgrinfo_start_handler(544) > [SECURE_LOG] pkgmgr working for this application(org.example.example)
04-01 07:37:36.529+0900 D/AUL_AMD ( 2763): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(656) > __amd_pkgmgrinfo_start_handler
04-01 07:37:36.529+0900 D/rpm-installer(28381): rpm-installer-signature.c: _ri_process_x509certificate(441) > x509certificate, len=[942]
04-01 07:37:36.529+0900 D/rpm-installer(28381): 
04-01 07:37:36.529+0900 D/rpm-installer(28381): MIICtDCCAh2gAwIBAgIJAMDbehElPNKvMA0GCSqGSIb3DQEBBQUAMIGVMQswCQYDVQQGEwJLUjEO
04-01 07:37:36.529+0900 D/rpm-installer(28381): MAwGA1UECAwFU3V3b24xDjAMBgNVBAcMBVN1d29uMRYwFAYDVQQKDA1UaXplbiBUZXN0IENBMSMw
04-01 07:37:36.529+0900 D/rpm-installer(28381): IQYDVQQLDBpUVGl6ZW4gRGlzdHJpYnV0b3IgVGVzdCBDQTEpMCcGA1UEAwwgVGl6ZW4gUHVibGlj
04-01 07:37:36.529+0900 D/rpm-installer(28381): IERpc3RyaWJ1dG9yIFJvb3QgQ0EwHhcNMTIxMDI5MTMwMjUwWhcNMjIxMDI3MTMwMjUwWjCBjzEL
04-01 07:37:36.529+0900 D/rpm-installer(28381): MAkGA1UEBhMCS1IxDjAMBgNVBAgMBVN1d29uMQ4wDAYDVQQHDAVTdXdvbjEWMBQGA1UECgwNVGl6
04-01 07:37:36.529+0900 D/rpm-installer(28381): ZW4gVGVzdCBDQTEiMCAGA1UECwwZVGl6ZW4gRGlzdHJpYnV0b3IgVGVzdCBDQTEkMCIGA1UEAwwb
04-01 07:37:36.529+0900 D/rpm-installer(28381): VGl6ZW4gUHVibGljIERpc3RyaWJ1dG9yIENBMIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQDe
04-01 07:37:36.529+0900 D/rpm-installer(28381): OTS/3nXvkDEmsFCJIvRlQ3RKDcxdWJJp625pFqHdmoJBdV+x6jl1raGK2Y1sp2Gdvpjc/z92yzAp
04-01 07:37:36.529+0900 D/rpm-installer(28381): bE/UVLPh/tRNZPeGhzU4ejDDm7kzdr2f7Ia0U98K+OoY12ucwg7TYNItj9is7Cj4blGfuMDzd2ah
04-01 07:37:36.529+0900 D/rpm-installer(28381): 2AgnCGlwNwV/pv+uVQIDAQABoxAwDjAMBgNVHRMEBTADAQH/MA0GCSqGSIb3DQEBBQUAA4GBACqJ
04-01 07:37:36.529+0900 D/rpm-installer(28381): KO33YdoGudwanZIxMdXuxnnD9R6u72ltKk1S4zPfMJJv482CRGCI4FK6djhlsI4i0Lt1SVIJEed+
04-01 07:37:36.529+0900 D/rpm-installer(28381): yc3qckGm19dW+4xdlkekon7pViEBWuyHw8OWv3RXtTum1+PGHjBJ2eYY4ZKIpz73U/1NC16sTB/0
04-01 07:37:36.529+0900 D/rpm-installer(28381): VhfnkHwPl
04-01 07:37:36.529+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[start], value=[update]
04-01 07:37:36.529+0900 W/cluster-home( 2906): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[0], package[org.example.example]
04-01 07:37:36.529+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[start], value=[update]
04-01 07:37:36.529+0900 D/cluster-home( 2906): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29060003] pkg_type[tpk] package[org.example.example] key[start] val[update] pmsg[(null)]
04-01 07:37:36.529+0900 D/PKGMGR  (28379): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
04-01 07:37:36.529+0900 D/PKGMGR  ( 2976): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
04-01 07:37:36.529+0900 D/PKGMGR  ( 2968): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[start], value=[update]
04-01 07:37:36.529+0900 D/QUICKPANEL( 2968): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:start val:update
04-01 07:37:36.529+0900 D/PKGMGR  ( 2968): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
04-01 07:37:36.529+0900 D/QUICKPANEL( 2968): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:install_percent val:30
04-01 07:37:36.529+0900 D/PKGMGR  ( 3052): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
04-01 07:37:36.529+0900 D/PKGMGR  ( 2960): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
04-01 07:37:36.529+0900 D/DATA_PROVIDER_MASTER( 2960): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.example] 30
04-01 07:37:36.529+0900 D/PKGMGR  ( 2974): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
04-01 07:37:36.529+0900 D/ESD     ( 2974): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29740002), pkg_type(tpk), pkgid(org.example.example), key(install_percent), val(30)
04-01 07:37:36.539+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
04-01 07:37:36.539+0900 W/cluster-home( 2906): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.example]
04-01 07:37:36.539+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
04-01 07:37:36.539+0900 D/cluster-home( 2906): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29060003] pkg_type[tpk] package[org.example.example] key[install_percent] val[30] pmsg[(null)]
04-01 07:37:36.539+0900 D/PKGMGR  ( 2983): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
04-01 07:37:36.539+0900 D/PKGMGR  ( 2983): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
04-01 07:37:36.539+0900 D/PKGMGR  ( 3098): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
04-01 07:37:36.539+0900 D/CERT_SVC(28381): cert-service.c: _cert_svc_verify_certificate_with_caflag(188) > [SECURE_LOG] root cert path : /usr/share/cert-svc/certs/code-signing/tizen/tizen-distributor-root-ca-public.pem
04-01 07:37:36.539+0900 D/rpm-installer(28381): rpm-installer.c: _ri_verify_sig_and_cert(1744) > cert_svc_verify() is done successfully. validity=[1]
04-01 07:37:36.539+0900 D/rpm-installer(28381): rpm-installer.c: _ri_verify_sig_and_cert(1758) > cert_svc_get_visibility() returns visibility=[64]
04-01 07:37:36.539+0900 D/rpm-installer(28381): rpm-installer.c: _ri_verify_sig_and_cert(1771) > Root CA cert path=[/usr/share/cert-svc/certs/code-signing/tizen/tizen-distributor-root-ca-public.pem]
04-01 07:37:36.539+0900 D/rpm-installer(28381): rpm-installer.c: __ri_verify_file(336) > valid signature
04-01 07:37:36.539+0900 D/rpm-installer(28381): rpm-installer.c: __ri_get_cert_from_file(1029) > Root CA, len=[908]
04-01 07:37:36.539+0900 D/rpm-installer(28381): MIICozCCAgwCCQD9XW6kNg4bbjANBgkqhkiG9w0BAQUFADCBlTELMAkGA1UEBhMCS1IxDjAMBgNVBAgMBVN1d29uMQ4wDAYDVQQHDAVTdXdvbjEWMBQGA1UECgwNVGl6ZW4gVGVzdCBDQTEjMCEGA1UECwwaVFRpemVuIERpc3RyaWJ1dG9yIFRlc3QgQ0ExKTAnBgNVBAMMIFRpemVuIFB1YmxpYyBEaXN0cmlidXRvciBSb290IENBMB4XDTEyMTAyNjA4MDAyN1oXDTIyMTAyNDA4MDAyN1owgZUxCzAJBgNVBAYTAktSMQ4wDAYDVQQIDAVTdXdvbjEOMAwGA1UEBwwFU3V3b24xFjAUBgNVBAoMDVRpemVuIFRlc3QgQ0ExIzAhBgNVBAsMGlRUaXplbiBEaXN0cmlidXRvciBUZXN0IENBMSkwJwYDVQQDDCBUaXplbiBQdWJsaWMgRGlzdHJpYnV0b3IgUm9vdCBDQTCBnzANBgkqhkiG9w0BAQEFAAOBjQAwgYkCgYEA8o0kPY1U9El1BbBUF1k4jCq6mH8a6MmDJdjgsz+hILAYsPWimRTXUcW8GAUWhZWgm1Fbb49xWcasA8b4bIJabC/6hLb8uWiozzpRXyQJbe7k//RocskRqDmFOky8ANFsCCww72/Xbq8BFK1sxlGdmOWQiGwDWBDlS2Lw1XOMqb0CAwEAATANBgkqhkiG9w0BAQUFAAOBgQBUotZqTNFr+SNyqeZqhOToRsg3ojN1VJUa07qdlVo5I1UObSE+UTJPJ0NtSj7OyTY7fF3E4xzUv/w8aUoabQP1erEmztY/AVD+phHaPytkZ/Dx+zDZ1u5e9bKm5zfY4dQs/A53zDQta5a/NkZOEF97Dj3+bzAh2bP7KOszlocFYw==
04-01 07:37:36.539+0900 D/rpm-installer(28381): coretpk-installer.c: _coretpk_installer_verify_signatures(1284) > _ri_verify_sig_and_cert(/opt/usr/apps/org.example.example/signature1.xml) succeed.
04-01 07:37:36.539+0900 D/rpm-installer(28381): coretpk-installer.c: _coretpk_installer_package_reinstall(4980) > signature and certificate verifying success
04-01 07:37:36.539+0900 D/PKGMGR  (28381): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(28381), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(60)
04-01 07:37:36.539+0900 D/PKGMGR  (28381): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(28381), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(60)
04-01 07:37:36.539+0900 D/PKGMGR  (28381): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
04-01 07:37:36.539+0900 D/PKGMGR_INSTALLER(28381): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.example] key[install_percent] value[60]
04-01 07:37:36.539+0900 D/PKGMGR  (28381): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(28381), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(60)
04-01 07:37:36.539+0900 D/PKGMGR  (28381): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(28381), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(60)
04-01 07:37:36.539+0900 D/PKGMGR  (28381): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.install.progress), signal_name(install_progress)
04-01 07:37:36.539+0900 E/PKGMGR_CERT(28381): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-01 07:37:36.539+0900 D/PKGMGR  ( 2976): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-01 07:37:36.549+0900 D/PKGMGR  (28379): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-01 07:37:36.549+0900 D/PKGMGR  ( 2968): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-01 07:37:36.549+0900 D/QUICKPANEL( 2968): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:install_percent val:60
04-01 07:37:36.549+0900 D/PKGMGR  ( 3052): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-01 07:37:36.549+0900 E/PKGMGR_CERT(28381): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 17
04-01 07:37:36.549+0900 D/PKGMGR  ( 2960): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-01 07:37:36.549+0900 E/PKGMGR_CERT(28381): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 17
04-01 07:37:36.549+0900 D/PKGMGR  ( 3098): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-01 07:37:36.549+0900 D/DATA_PROVIDER_MASTER( 2960): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.example] 60
04-01 07:37:36.549+0900 E/PKGMGR_CERT(28381): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 10 2
04-01 07:37:36.549+0900 E/PKGMGR_CERT(28381): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 7 5
04-01 07:37:36.549+0900 E/PKGMGR_CERT(28381): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 8 5
04-01 07:37:36.549+0900 E/PKGMGR_CERT(28381): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 9 5
04-01 07:37:36.549+0900 D/PKGMGR  ( 2974): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-01 07:37:36.549+0900 D/ESD     ( 2974): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29740002), pkg_type(tpk), pkgid(org.example.example), key(install_percent), val(60)
04-01 07:37:36.549+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-01 07:37:36.549+0900 W/cluster-home( 2906): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.example]
04-01 07:37:36.549+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-01 07:37:36.549+0900 D/cluster-home( 2906): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29060003] pkg_type[tpk] package[org.example.example] key[install_percent] val[60] pmsg[(null)]
04-01 07:37:36.549+0900 D/PKGMGR  ( 2983): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-01 07:37:36.549+0900 D/PKGMGR  ( 2983): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
04-01 07:37:36.549+0900 E/PKGMGR_CERT(28381): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-01 07:37:36.549+0900 D/rpm-installer(28381): rpm-installer-privilege.c: _ri_privilege_unregister_package(85) > [smack] app_uninstall(org.example.example), result=[0]
04-01 07:37:36.549+0900 D/rpm-installer(28381): rpm-installer-privilege.c: _ri_privilege_register_package(65) > [smack] app_install(org.example.example), result=[0]
04-01 07:37:36.549+0900 D/rpm-installer(28381): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example, 5, _), result=[0]
04-01 07:37:36.549+0900 D/rpm-installer(28381): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/shared, 5, _), result=[0]
04-01 07:37:36.549+0900 D/rpm-installer(28381): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/shared/res, 5, _), result=[0]
04-01 07:37:36.549+0900 D/rpm-installer(28381): rpm-installer-privilege.c: _ri_privilege_setup_path(117) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/shared/data, 2), result=[0]
04-01 07:37:36.549+0900 D/rpm-installer(28381): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1101) > [smack] get_smack_label, path=[/opt/usr/apps/org.example.example/shared/data], label=[$1$org.exam$u8BwfYMV9u%MYLLw2JGhj1]
04-01 07:37:36.549+0900 D/rpm-installer(28381): coretpk-installer.c: _coretpk_installer_set_smack_label_access(1088) > [smack] set_smack_label, path=[/opt/usr/apps/org.example.example/shared/cache], label=[$1$org.exam$u8BwfYMV9u%MYLLw2JGhj1]
04-01 07:37:36.549+0900 E/rpm-installer(28381): installer-util.c: _installer_util_get_configuration_value(418) > [signature]=[on]
04-01 07:37:36.549+0900 D/rpm-installer(28381): coretpk-installer.c: _coretpk_installer_get_group_id(2472) > encoding done, len=[28]
04-01 07:37:36.549+0900 D/rpm-installer(28381): coretpk-installer.c: _coretpk_installer_apply_smack(2575) > groupid = [lRCBhlfBM8hN+lAnIV9z4vodWRE=] for shared/trusted.
04-01 07:37:36.549+0900 D/rpm-installer(28381): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/shared/trusted, 1, lRCBhlfBM8hN+lAnIV9z4vodWRE=), result=[0]
04-01 07:37:36.549+0900 D/rpm-installer(28381): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/bin, 0, org.example.example), result=[0]
04-01 07:37:36.549+0900 D/rpm-installer(28381): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/data, 0, org.example.example), result=[0]
04-01 07:37:36.549+0900 D/rpm-installer(28381): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/lib, 0, org.example.example), result=[0]
04-01 07:37:36.549+0900 D/rpm-installer(28381): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/res, 0, org.example.example), result=[0]
04-01 07:37:36.559+0900 D/rpm-installer(28381): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/cache, 0, org.example.example), result=[0]
04-01 07:37:36.559+0900 D/rpm-installer(28381): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/tizen-manifest.xml, 0, org.example.example), result=[0]
04-01 07:37:36.559+0900 D/rpm-installer(28381): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/author-signature.xml, 0, org.example.example), result=[0]
04-01 07:37:36.559+0900 D/rpm-installer(28381): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/signature1.xml, 0, org.example.example), result=[0]
04-01 07:37:36.559+0900 D/rpm-installer(28381): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/share/packages/org.example.example.xml, 0, org.example.example), result=[0]
04-01 07:37:36.559+0900 D/rpm-installer(28381): rpm-installer-privilege.c: _ri_privilege_set_package_version(75) > [smack] app[org.example.example] version set to [2.4] result=[0]
04-01 07:37:36.559+0900 D/rpm-installer(28381): rpm-installer.c: _ri_apply_privilege(1924) > api-version[2.4] fot privilege has done successfully.
04-01 07:37:36.559+0900 D/rpm-installer(28381): rpm-installer-privilege.c: _ri_privilege_enable_permissions(106) > [smack] app_enable_permissions(org.example.example, 7), result=[0]
04-01 07:37:36.559+0900 D/rpm-installer(28381): coretpk-installer.c: _coretpk_installer_package_reinstall(5083) > #permission applying success.
04-01 07:37:36.559+0900 D/PKGMGR  (28381): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(28381), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
04-01 07:37:36.559+0900 D/PKGMGR  (28381): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(28381), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
04-01 07:37:36.559+0900 D/PKGMGR  (28381): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
04-01 07:37:36.559+0900 D/PKGMGR_INSTALLER(28381): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.example] key[install_percent] value[100]
04-01 07:37:36.559+0900 D/PKGMGR  (28381): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(28381), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
04-01 07:37:36.559+0900 D/PKGMGR  (28381): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(28381), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
04-01 07:37:36.559+0900 D/PKGMGR  (28381): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.install.progress), signal_name(install_progress)
04-01 07:37:36.559+0900 D/rpm-installer(28381): coretpk-installer.c: _coretpk_installer_package_reinstall(5096) > _coretpk_installer_package_reinstall(org.example.example) is done.
04-01 07:37:36.559+0900 D/PKGMGR  (28381): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(28381), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
04-01 07:37:36.559+0900 D/PKGMGR  (28381): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(28381), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
04-01 07:37:36.559+0900 D/PKGMGR  (28381): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
04-01 07:37:36.559+0900 D/PKGMGR_INSTALLER(28381): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.example] key[end] value[ok]
04-01 07:37:36.559+0900 D/PKGMGR  (28381): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(28381), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
04-01 07:37:36.559+0900 D/PKGMGR  (28381): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(28381), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
04-01 07:37:36.559+0900 D/PKGMGR  (28381): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.upgrade), signal_name(upgrade)
04-01 07:37:36.559+0900 D/PKGMGR  (28379): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 07:37:36.559+0900 D/PKGMGR  ( 2976): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 07:37:36.559+0900 D/PKGMGR  ( 3052): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 07:37:36.559+0900 D/PKGMGR  ( 2960): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 07:37:36.559+0900 D/DATA_PROVIDER_MASTER( 2960): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.example] 100
04-01 07:37:36.559+0900 D/PKGMGR  ( 2974): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 07:37:36.559+0900 D/ESD     ( 2974): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29740002), pkg_type(tpk), pkgid(org.example.example), key(install_percent), val(100)
04-01 07:37:36.559+0900 D/PKGMGR  ( 2983): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 07:37:36.559+0900 D/PKGMGR  ( 2983): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
04-01 07:37:36.559+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 07:37:36.559+0900 W/cluster-home( 2906): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.example]
04-01 07:37:36.559+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 07:37:36.559+0900 D/cluster-home( 2906): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29060003] pkg_type[tpk] package[org.example.example] key[install_percent] val[100] pmsg[(null)]
04-01 07:37:36.559+0900 D/PKGMGR  (28379): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 07:37:36.559+0900 D/PKGMGR  ( 3098): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 07:37:36.559+0900 D/PKGMGR  ( 2976): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 07:37:36.559+0900 D/PKGMGR  ( 2968): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 07:37:36.569+0900 D/QUICKPANEL( 2968): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:install_percent val:100
04-01 07:37:36.569+0900 D/PKGMGR  ( 3052): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 07:37:36.569+0900 D/ISF_PANEL_EFL( 3052): isf_panel_efl.cpp: _package_manager_event_cb(1288) > type=tpk package=org.example.example event_type=UPDATE event_state=COMPLETED progress=100 error=0
04-01 07:37:36.569+0900 D/PKGMGR  ( 3098): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 07:37:36.569+0900 D/PKGMGR  ( 2968): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 07:37:36.569+0900 D/QUICKPANEL( 2968): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:end val:ok
04-01 07:37:36.569+0900 W/ISF_PANEL_EFL( 3052): isf_panel_efl.cpp: _package_manager_event_cb(1380) > isf_db_select_appids_by_pkgid returned 0.
04-01 07:37:36.569+0900 D/PKGMGR  ( 2960): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 07:37:36.569+0900 D/DATA_PROVIDER_MASTER( 2960): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.example] ok
04-01 07:37:36.569+0900 D/DATA_PROVIDER_MASTER( 2960): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.example], event_type[1]
04-01 07:37:36.569+0900 D/DATA_PROVIDER_MASTER( 2960): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
04-01 07:37:36.569+0900 D/DATA_PROVIDER_MASTER( 2960): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
04-01 07:37:36.569+0900 D/DATA_PROVIDER_MASTER( 2960): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
04-01 07:37:36.569+0900 D/DATA_PROVIDER_MASTER( 2960): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.example]
04-01 07:37:36.569+0900 D/PKGMGR  ( 2974): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 07:37:36.569+0900 D/ESD     ( 2974): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29740002), pkg_type(tpk), pkgid(org.example.example), key(end), val(ok)
04-01 07:37:36.569+0900 D/ESD     ( 2974): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
04-01 07:37:36.569+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 07:37:36.569+0900 W/cluster-home( 2906): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[2], package[org.example.example]
04-01 07:37:36.569+0900 D/cluster-home( 2906): widget-data-provider.cpp: PackageUpdated(2160) >  No boxes that pkgname is[org.example.example]
04-01 07:37:36.569+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 07:37:36.569+0900 D/cluster-home( 2906): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29060003] pkg_type[tpk] package[org.example.example] key[end] val[ok] pmsg[(null)]
04-01 07:37:36.569+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
04-01 07:37:36.569+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
04-01 07:37:36.569+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
04-01 07:37:36.569+0900 D/PKGMGR  ( 2763): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[upgrade], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 07:37:36.569+0900 D/AUL_AMD ( 2763): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.example), key(end), value(ok)
04-01 07:37:36.569+0900 W/AUL_AMD ( 2763): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(update), value(ok)
04-01 07:37:36.569+0900 D/cluster-home( 2906): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
04-01 07:37:36.569+0900 D/cluster-home( 2906): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.example]
04-01 07:37:36.569+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.example]
04-01 07:37:36.569+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.example]
04-01 07:37:36.569+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
04-01 07:37:36.569+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
04-01 07:37:36.569+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.example]
04-01 07:37:36.569+0900 D/AUL_AMD ( 2763): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.example, type:rpm
04-01 07:37:36.579+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.example] Name[example] Icon[/opt/usr/apps/org.example.example/shared/res/example.png] enable[1] system[0]
04-01 07:37:36.579+0900 D/cluster-home( 2906): mainmenu-presenter.cpp: OnAppUpdated(337) >  pAppId [org.example.example]
04-01 07:37:36.579+0900 D/cluster-home( 2906): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.example
04-01 07:37:36.579+0900 D/cluster-home( 2906): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[14], isFolder[0], pageId[1], col[2], row[4], appId[org.example.example], name[example], menuId[1], isPreload[0] isPreload[0]
04-01 07:37:36.579+0900 D/cluster-home( 2906): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
04-01 07:37:36.579+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.example] Name[example] Icon[/opt/usr/apps/org.example.example/shared/res/example.png] enable[1] system[0]
04-01 07:37:36.579+0900 D/cluster-home( 2906): mainmenu-presenter.cpp: OnAppUpdated(364) >  name [example]
04-01 07:37:36.579+0900 D/cluster-home( 2906): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
04-01 07:37:36.579+0900 D/cluster-home( 2906): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
04-01 07:37:36.579+0900 D/test-log( 2906): mainmenu-box-impl.cpp: UpdateBoxData(812) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.example/shared/res/example.png], New icon path[/opt/usr/apps/org.example.example/shared/res/example.png]!!!!!
04-01 07:37:36.579+0900 D/cluster-home( 2906): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 1, appId = $appId, name = $name, col = 2, row = 4, isPreload = 0, isSystem = 0 WHERE boxId = 14]
04-01 07:37:36.579+0900 D/PKGMGR  ( 2983): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_1916638889], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 07:37:36.579+0900 D/PKGMGR  ( 2983): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
04-01 07:37:36.639+0900 D/rpm-installer(28381): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
04-01 07:37:36.639+0900 D/rpm-installer(28381): rpm-appcore-intf.c: main(259) > ------------------------------------------------
04-01 07:37:36.639+0900 D/rpm-installer(28381): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
04-01 07:37:36.639+0900 D/rpm-installer(28381): rpm-appcore-intf.c: main(261) > ------------------------------------------------
04-01 07:37:36.639+0900 D/PKGMGR_SERVER(28292): pkgmgr-server.c: sighandler(387) > child exit [28381]
04-01 07:37:36.639+0900 E/PKGMGR_SERVER(28292): pkgmgr-server.c: sighandler(402) > child NORMAL exit [28381]
04-01 07:37:36.699+0900 W/PROCESSMGR( 2799): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=2906
04-01 07:37:36.759+0900 D/APP_CORE( 2906): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 0
04-01 07:37:36.759+0900 D/APP_CORE( 2906): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active 0
04-01 07:37:36.759+0900 D/APP_CORE( 2906): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
04-01 07:37:36.759+0900 I/APP_CORE( 2906): appcore-efl.c: __do_app(496) > [APP 2906] Event: RESUME State: PAUSED
04-01 07:37:36.759+0900 D/LAUNCH  ( 2906): appcore-efl.c: __do_app(597) > [homescreen:Application:resume:start]
04-01 07:37:36.759+0900 D/APP_CORE( 2906): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
04-01 07:37:36.759+0900 D/APP_CORE( 2906): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
04-01 07:37:36.759+0900 D/APP_CORE( 2906): appcore-efl.c: __do_app(607) > [APP 2906] RESUME
04-01 07:37:36.759+0900 I/CAPI_APPFW_APPLICATION( 2906): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
04-01 07:37:36.759+0900 E/cluster-home( 2906): homescreen.cpp: OnResume(66) >  app resume
04-01 07:37:36.759+0900 D/cluster-home( 2906): widget-data-provider.cpp: SetBoxVisibility(1543) >  
04-01 07:37:36.759+0900 D/cluster-home( 2906): cluster-data-list.cpp: GetWidgetListByPage(776) >  cluster[0] pageNum[1]
04-01 07:37:36.759+0900 D/WIDGET_VIEWER( 2906): widget.c: widget_viewer_set_visibility(3865) > [SECURE_LOG] org.tizen.calendar.widget has no changes
04-01 07:37:36.759+0900 D/cluster-home( 2906): cluster-data-list.cpp: GetWidgetListByPage(776) >  cluster[0] pageNum[2]
04-01 07:37:36.759+0900 D/cluster-home( 2906): widget-data-provider.cpp: SetBoxVisibility(1552) >  No boxes in page[2]
04-01 07:37:36.759+0900 D/cluster-view( 2906): homescreen-view-manager.cpp: AppResume(892) >  BEGIN
04-01 07:37:36.759+0900 D/cluster-view( 2906): homescreen-view-manager.cpp: AppResume(910) >  END
04-01 07:37:36.759+0900 D/cluster-view( 2906): cluster-view-controller.cpp: _OnTTSFocusChanged(1652) >  _OnTTSFocusChanged Order[0]
04-01 07:37:36.759+0900 D/cluster-view( 2906): custom-cluster-impl.cpp: OnFocusChanged(5705) >  OnFocusChanged[0]
04-01 07:37:36.759+0900 D/cluster-view( 2906): homescreen-page-indicator.cpp: CancelOperation(300) >  CancelOperation
04-01 07:37:36.759+0900 D/cluster-view( 2906): cluster-impl.cpp: ScrollToFitPage(466) >  ScrollToFitPage
04-01 07:37:36.759+0900 D/cluster-view( 2906): cluster-impl.cpp: OnScrollSnapStart(613) >  TODO current page[0] new page[0]
04-01 07:37:36.759+0900 D/cluster-view( 2906): cluster-impl.cpp: OnScrollSnapStart(623) >  TODO current page[0] new page[0]
04-01 07:37:36.759+0900 D/test-log( 2906): cluster-impl.cpp: SetFocusedPage(791) >  Set mFocusedPage: 1
04-01 07:37:36.759+0900 D/test-log( 2906): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
04-01 07:37:36.759+0900 D/cluster-view( 2906): cluster-view-controller.cpp: OnClusterChangeFocusedPage(1779) >  Cluster[0:] 1 page focused
04-01 07:37:36.759+0900 D/cluster-home( 2906): widget-data-provider.cpp: OnCustomClusterFocusedPageChanged(2934) >  Cluster[0] page[1] focused
04-01 07:37:36.759+0900 D/LAUNCH  ( 2906): appcore-efl.c: __do_app(636) > [homescreen:Application:resume:done]
04-01 07:37:36.759+0900 D/LAUNCH  ( 2906): appcore-efl.c: __do_app(638) > [homescreen:Application:Launching:done]
04-01 07:37:36.759+0900 D/APP_CORE( 2906): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
04-01 07:37:36.769+0900 E/APP_CORE( 2906): appcore-efl.c: __trm_app_info_send_socket(242) > access
04-01 07:37:36.769+0900 E/EFL     ( 2799): eo<2799> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
04-01 07:37:36.769+0900 I/TIZEN_N_SOUND_MANAGER( 2976): sound_manager.c: sound_manager_get_volume(80) > returns : type=0, volume=9, ret=0x0
04-01 07:37:36.769+0900 E/TIZEN_N_SOUND_MANAGER( 2976): sound_manager_private.c: __convert_sound_manager_error_code(74) > [sound_manager_get_volume(82)] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-01 07:37:36.769+0900 I/TIZEN_N_SOUND_MANAGER( 2976): sound_manager.c: sound_manager_get_volume(80) > returns : type=4, volume=7, ret=0x0
04-01 07:37:36.769+0900 E/TIZEN_N_SOUND_MANAGER( 2976): sound_manager_private.c: __convert_sound_manager_error_code(74) > [sound_manager_get_volume(82)] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-01 07:37:36.769+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(838) > __request_handler: 15
04-01 07:37:36.769+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
04-01 07:37:36.769+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
04-01 07:37:36.769+0900 D/AUL_AMD ( 2763): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 2906 is org.tizen.homescreen
04-01 07:37:36.769+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 2906 : 0
04-01 07:37:36.769+0900 D/AUL     ( 2976): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 29
04-01 07:37:36.779+0900 D/DATA_PROVIDER_MASTER( 2960): xmonitor.c: xmonitor_resume(339) > [SECURE_LOG] 2906 is resumed
04-01 07:37:36.779+0900 D/DATA_PROVIDER_MASTER( 2960): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
04-01 07:37:36.779+0900 E/DATA_PROVIDER_MASTER( 2960): setting.c: setting_is_lcd_off(95) > [SECURE_LOG] State: 1, (3:lcdoff, 4:sleep)
04-01 07:37:36.779+0900 I/CAPI_WIDGET_APPLICATION( 2963): widget_app.c: __provider_resume_cb(312) > widget obj was resumed
04-01 07:37:36.779+0900 I/CAPI_WIDGET_APPLICATION( 2963): widget_app.c: __check_status_for_cgroup(132) > enter foreground group
04-01 07:37:36.779+0900 W/AUL     ( 2963): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2963, appid: org.tizen.calendar.widget, status: fg
04-01 07:37:36.779+0900 D/RESOURCED( 2892): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2963
04-01 07:37:36.779+0900 D/RESOURCED( 2892): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 2963, proc_name: org.tizen.calendar.widget, cg_name: foreground, oom_score_adj: 200
04-01 07:37:36.779+0900 D/RESOURCED( 2892): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 2963
04-01 07:37:36.819+0900 D/RESOURCED( 2892): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2963, appname = org.tizen.calendar.widget
04-01 07:37:36.819+0900 D/RESOURCED( 2892): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2963
04-01 07:37:36.819+0900 I/RESOURCED( 2892): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
04-01 07:37:36.819+0900 I/RESOURCED( 2892): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
04-01 07:37:36.829+0900 W/CRASH_MANAGER(28386): worker.c: worker_job(1204) > 1128015657861149099985
