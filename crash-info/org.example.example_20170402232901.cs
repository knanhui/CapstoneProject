S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 14685
Date: 2017-04-02 23:29:01+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x85355c84

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb8477420, esi = 0xb8495c18
ebp = 0xbf89b258, esp = 0xbf89b200
eax = 0xb37fecd9, ebx = 0xb735b5f0
ecx = 0x0000013b, edx = 0x800144a3
eip = 0xb7167c51

Memory Information
MemTotal:      123 KB
MemFree:        34 KB
Buffers:         5 KB
Cached:     162080 KB
VmPeak:      79908 KB
VmSize:      79908 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16040 KB
VmRSS:       16040 KB
VmData:      19992 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33320 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 14685 TID = 14685
14685 14687 14866 

Maps Information
b2ce3000 b2ced000 r-xp /usr/lib/libfeedback.so.0.1.4
b2cf3000 b2cff000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2d00000 b2d21000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2d26000 b2d27000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2d28000 b2d2d000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2d2e000 b2d2f000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2d30000 b2d32000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2d33000 b2d35000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2d36000 b2d42000 r-xp /usr/lib/libdrm.so.2.4.0
b2d43000 b2d46000 r-xp /usr/lib/libdri2.so.0.0.0
b2d47000 b2d51000 r-xp /usr/lib/libtbm.so.1.0.0
b2d58000 b2d59000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2d5a000 b2d5b000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2d5c000 b2d5f000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b2d60000 b2d63000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b2d64000 b2d79000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2d7a000 b2d8c000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3695000 b369b000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b369c000 b37e0000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37f0000 b37f1000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37f2000 b37fb000 r-xp /usr/lib/libefl-extension.so.0.1.0
b37fc000 b3800000 r-xp /opt/usr/apps/org.example.example/bin/example
b3802000 b383b000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b423e000 b4249000 r-xp /lib/libnss_files-2.20-2014.11.so
b424b000 b4256000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4258000 b426f000 r-xp /lib/libnsl-2.20-2014.11.so
b4273000 b427b000 r-xp /lib/libnss_compat-2.20-2014.11.so
b427d000 b42a1000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b42a2000 b42a3000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b42a4000 b42a7000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42a8000 b42af000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42b0000 b42ba000 r-xp /usr/lib/libsensord-share.so
b42bb000 b42d7000 r-xp /usr/lib/libsensor.so.1.2.0
b42d9000 b42e2000 r-xp /usr/lib/libappcore-common.so.1.1
b42e5000 b42e7000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42fc000 b42fe000 r-xp /usr/lib/libXau.so.6.0.0
b42ff000 b4321000 r-xp /usr/lib/libxcb.so.1.1.0
b4323000 b432c000 r-xp /lib/libcrypt-2.20-2014.11.so
b4355000 b4357000 r-xp /usr/lib/libiri.so
b4358000 b437e000 r-xp /lib/libexpat.so.1.5.2
b4380000 b43eb000 r-xp /usr/lib/libssl.so.1.0.0
b43f1000 b43fd000 r-xp /usr/lib/libethumb.so.1.13.0
b43fe000 b4402000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4403000 b4654000 r-xp /usr/lib/libcrypto.so.1.0.0
b5bcf000 b5bdf000 r-xp /usr/lib/libXi.so.6.1.0
b5be0000 b5be2000 r-xp /usr/lib/libXgesture.so.7.0.0
b5be3000 b5be9000 r-xp /usr/lib/libXtst.so.6.1.0
b5bea000 b5bf4000 r-xp /usr/lib/libXrender.so.1.3.0
b5bf5000 b5bfe000 r-xp /usr/lib/libXrandr.so.2.2.0
b5c00000 b5c02000 r-xp /usr/lib/libXinerama.so.1.0.0
b5c03000 b5c08000 r-xp /usr/lib/libXfixes.so.3.1.0
b5c09000 b5c1b000 r-xp /usr/lib/libXext.so.6.4.0
b5c1c000 b5c1e000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c1f000 b5c21000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c23000 b5d65000 r-xp /usr/lib/libX11.so.6.3.0
b5d69000 b5d73000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d74000 b5d8a000 r-xp /usr/lib/libudev.so.1.6.0
b5d8d000 b5d91000 r-xp /lib/libattr.so.1.1.0
b5d92000 b5dc1000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5dc3000 b5dc9000 r-xp /usr/lib/libffi.so.6.0.2
b5dca000 b5ded000 r-xp /lib/libz.so.1.2.8
b5dee000 b5df1000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5df2000 b5f4e000 r-xp /usr/lib/libxml2.so.2.9.2
b5f54000 b603b000 r-xp /usr/lib/libstdc++.so.6.0.20
b6048000 b604b000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b604c000 b606e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b606f000 b6083000 r-xp /lib/libresolv-2.20-2014.11.so
b6087000 b60ab000 r-xp /usr/lib/liblzma.so.5.0.3
b60ac000 b60ae000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b60b0000 b60ba000 r-xp /usr/lib/libembryo.so.1.13.0
b60bb000 b60e4000 r-xp /usr/lib/libpng12.so.0.50.0
b60e5000 b612e000 r-xp /usr/lib/libjpeg.so.8.0.2
b613f000 b6146000 r-xp /lib/librt-2.20-2014.11.so
b6148000 b6167000 r-xp /usr/lib/libector.so.1.13.0
b616a000 b6197000 r-xp /usr/lib/liblua-5.1.so
b6198000 b6228000 r-xp /usr/lib/libfreetype.so.6.11.3
b622c000 b626a000 r-xp /usr/lib/libfontconfig.so.1.8.0
b626b000 b6281000 r-xp /usr/lib/libfribidi.so.0.3.1
b6282000 b62db000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62de000 b6329000 r-xp /lib/libm-2.20-2014.11.so
b632b000 b633d000 r-xp /usr/lib/libeio.so.1.13.0
b633e000 b6341000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6342000 b6348000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6349000 b636c000 r-xp /usr/lib/libefreet.so.1.13.0
b636f000 b639a000 r-xp /usr/lib/libeldbus.so.1.13.0
b639b000 b63cf000 r-xp /usr/lib/libecore_con.so.1.13.0
b63d1000 b63da000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63db000 b63e4000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63e5000 b63f8000 r-xp /usr/lib/libeo.so.1.13.0
b63fa000 b640d000 r-xp /usr/lib/libecore_input.so.1.13.0
b640e000 b6415000 r-xp /usr/lib/libecore_file.so.1.13.0
b6416000 b6439000 r-xp /usr/lib/libecore_evas.so.1.13.0
b643a000 b6466000 r-xp /usr/lib/libeet.so.1.13.0
b646f000 b64da000 r-xp /usr/lib/libeina.so.1.13.0
b64dd000 b64f4000 r-xp /usr/lib/libefl.so.1.13.0
b64f6000 b665d000 r-xp /usr/lib/libicuuc.so.51.1
b666b000 b6877000 r-xp /usr/lib/libicui18n.so.51.1
b687f000 b68ce000 r-xp /usr/lib/libecore_x.so.1.13.0
b68d0000 b68ea000 r-xp /lib/libgcc_s-4.9.so.1
b68ec000 b68f0000 r-xp /lib/libcap.so.2.21
b68f1000 b6937000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6938000 b693f000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6941000 b6993000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6995000 b6b20000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b25000 b6bf3000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bf6000 b6bfa000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bfb000 b6c0a000 r-xp /usr/lib/libvconf.so.0.2.45
b6c0b000 b6c0e000 r-xp /usr/lib/libvasum.so.0.3.1
b6c0f000 b6c12000 r-xp /usr/lib/libttrace.so.1.1
b6c14000 b6c18000 r-xp /usr/lib/libiniparser.so.0
b6c19000 b6c49000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c4a000 b6c53000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c54000 b6c79000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c7a000 b6c8a000 r-xp /usr/lib/libunwind.so.8.0.1
b6c94000 b6e42000 r-xp /lib/libc-2.20-2014.11.so
b6e4a000 b6f8d000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f8f000 b6fe7000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fe8000 b701c000 r-xp /usr/lib/libsystemd.so.0.4.0
b701f000 b70f3000 r-xp /usr/lib/libedje.so.1.13.0
b70f6000 b7122000 r-xp /usr/lib/libecore.so.1.13.0
b7133000 b7359000 r-xp /usr/lib/libevas.so.1.13.0
b7381000 b7399000 r-xp /lib/libpthread-2.20-2014.11.so
b739d000 b7717000 r-xp /usr/lib/libelementary.so.1.13.0
b7737000 b773b000 r-xp /usr/lib/libsmack.so.1.0.0
b773c000 b7745000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7746000 b7749000 r-xp /usr/lib/libdlog.so.0.0.0
b774a000 b774f000 r-xp /usr/lib/libbundle.so.0.1.22
b7750000 b7753000 r-xp /lib/libdl-2.20-2014.11.so
b7755000 b777a000 r-xp /usr/lib/libaul.so.0.1.0
b777d000 b777f000 r-xp /usr/lib/libappsvc.so.0.1.0
b7780000 b7785000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7786000 b778d000 r-xp /usr/lib/libappcore-efl.so.1.1
b778f000 b7794000 r-xp /usr/lib/libsys-assert.so
b7797000 b7798000 r-xp [vdso]
b7798000 b77ba000 r-xp /lib/ld-2.20-2014.11.so
b77bc000 b77c4000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:14685)
Call Stack Count: 10
 0: evas_object_event_callback_priority_add + 0x81 (0xb7167c51) [/usr/lib/libevas.so.1] + 0x34c51
 1: evas_object_event_callback_add + 0x38 (0xb7167d48) [/usr/lib/libevas.so.1] + 0x34d48
 2: create_base_gui + 0x986 (0xb37fe9b6) [/opt/usr/apps/org.example.example/bin/example] + 0x29b6
 3: app_create + 0x2c (0xb37fde9c) [/opt/usr/apps/org.example.example/bin/example] + 0x1e9c
 4: (0xb778265b) [/usr/lib/libcapi-appfw-application.so.0] + 0x265b
 5: appcore_efl_main + 0x327 (0xb7789c27) [/usr/lib/libappcore-efl.so.1] + 0x3c27
 6: ui_app_main + 0x140 (0xb7782c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
 7: main + 0x27e (0xb37fde0e) [/opt/usr/apps/org.example.example/bin/example] + 0x1e0e
 8: create_base_gui + 0x118 (0xb77be148) [/opt/usr/apps/org.example.example/bin/example] + 0xb77be148
 9: __libc_start_main + 0xde (0xb6cabe4e) [/lib/libc.so.6] + 0x17e4e
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
_caflag(188) > [SECURE_LOG] root cert path : /usr/share/cert-svc/certs/code-signing/tizen/tizen-developers-root.pem
04-02 23:29:01.290+0900 D/rpm-installer(14810): rpm-installer.c: _ri_verify_sig_and_cert(1744) > cert_svc_verify() is done successfully. validity=[1]
04-02 23:29:01.290+0900 D/rpm-installer(14810): rpm-installer.c: _ri_verify_sig_and_cert(1758) > cert_svc_get_visibility() returns visibility=[1]
04-02 23:29:01.290+0900 D/rpm-installer(14810): rpm-installer.c: _ri_verify_sig_and_cert(1771) > Root CA cert path=[/usr/share/cert-svc/certs/code-signing/tizen/tizen-developers-root.pem]
04-02 23:29:01.300+0900 D/rpm-installer(14810): rpm-installer.c: __ri_verify_file(336) > valid signature
04-02 23:29:01.300+0900 D/rpm-installer(14810): rpm-installer.c: __ri_get_cert_from_file(1029) > Root CA, len=[1108]
04-02 23:29:01.300+0900 D/rpm-installer(14810): MIIDOzCCAiOgAwIBAgIBADANBgkqhkiG9w0BAQUFADBYMRowGAYDVQQKDBFUaXplbiBBc3NvY2lhdGlvbjEaMBgGA1UECwwRVGl6ZW4gQXNzb2NpYXRpb24xHjAcBgNVBAMMFVRpemVuIERldmVsb3BlcnMgUm9vdDAeFw0xMjAxMDEwMDAwMDBaFw0zMjAxMDEwMDAwMDBaMFgxGjAYBgNVBAoMEVRpemVuIEFzc29jaWF0aW9uMRowGAYDVQQLDBFUaXplbiBBc3NvY2lhdGlvbjEeMBwGA1UEAwwVVGl6ZW4gRGV2ZWxvcGVycyBSb290MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAp2rCwXTYh28vcagXWLIeVtEvXA5EeTR9UnL4Dzyd7hIq8rkxLbIMMOcCrXMTc7bEH2twFaTuXxyKXMW/2c+id3m3Z1B5caCqwSPr72oKPSI4jSkvrAC5W7EHx16M818aG4tQkXIUBhDrtSmH6dFOdt8zGq2fanj1sETfUmXAeLGE7OQYcEb2SoWGXR75Ytfp1LAw/L3luuG/kbzBcrZt1Cv05jfCP575eope6p5p80Gl0tieXyPYhSLVTLwhEdWx18CMaC7IXQo2Bm+JdjDH0Ruh/vTRnjFtmVB+nBOZNVzMHNOPUVFKSgysX/+PlM4jBTvbaTnPCZUkC/O75tYIpwIDAQABoxAwDjAMBgNVHRMEBTADAQH/MA0GCSqGSIb3DQEBBQUAA4IBAQBw95ibcuAiKpAEqBMyTZtOf0okhSi9NYfs/AFIPLH5REnhtQkPmKsvDp21OSdzrFEL42rV94K98QChD9tGO6Mwp1ZHM3No7/PLC3EelOwmn4dr3KPGdjvQNSwKRblGh0Hjn4fI+studFLLv6ldCLIpA/Ssgf9GuUbcjTC8OWBYPVUQ6YoXAcuHbfhr6a
04-02 23:29:01.300+0900 D/rpm-installer(14810): coretpk-installer.c: _coretpk_installer_verify_signatures(1274) > _ri_verify_sig_and_cert(/opt/usr/apps/org.example.example/author-signature.xml) succeed.
04-02 23:29:01.300+0900 D/rpm-installer(14810): rpm-installer-signature.c: _ri_process_signaturevalue(533) > SignatureValue, len=[176]
04-02 23:29:01.300+0900 D/rpm-installer(14810): 
04-02 23:29:01.300+0900 D/rpm-installer(14810): VTdJivTnYfjTDnzCLfb4j2TWuyF2qaVSYWBq0dlmwbC3keak7t7GYmY/Wat/zO1g0IW6SvVkJRqr
04-02 23:29:01.300+0900 D/rpm-installer(14810): WkKkdxfG5vIkB0pLolG9YNFgUnCvkxtur18S99H+6CJw3XS85BzEP/RPSB4v8guwezkoubtd2W1k
04-02 23:29:01.300+0900 D/rpm-installer(14810): IKt2UXVgy/6DhgTB4Yw=
04-02 23:29:01.300+0900 D/rpm-installer(14810): rpm-installer-signature.c: _ri_process_x509certificate(441) > x509certificate, len=[909]
04-02 23:29:01.300+0900 D/rpm-installer(14810): 
04-02 23:29:01.300+0900 D/rpm-installer(14810): MIICmzCCAgQCCQDXI7WLdVZwiTANBgkqhkiG9w0BAQUFADCBjzELMAkGA1UEBhMCS1IxDjAMBgNV
04-02 23:29:01.300+0900 D/rpm-installer(14810): BAgMBVN1d29uMQ4wDAYDVQQHDAVTdXdvbjEWMBQGA1UECgwNVGl6ZW4gVGVzdCBDQTEiMCAGA1UE
04-02 23:29:01.300+0900 D/rpm-installer(14810): CwwZVGl6ZW4gRGlzdHJpYnV0b3IgVGVzdCBDQTEkMCIGA1UEAwwbVGl6ZW4gUHVibGljIERpc3Ry
04-02 23:29:01.300+0900 D/rpm-installer(14810): aWJ1dG9yIENBMB4XDTEyMTAyOTEzMDMwNFoXDTIyMTAyNzEzMDMwNFowgZMxCzAJBgNVBAYTAktS
04-02 23:29:01.300+0900 D/rpm-installer(14810): MQ4wDAYDVQQIDAVTdXdvbjEOMAwGA1UEBwwFU3V3b24xFjAUBgNVBAoMDVRpemVuIFRlc3QgQ0Ex
04-02 23:29:01.300+0900 D/rpm-installer(14810): IjAgBgNVBAsMGVRpemVuIERpc3RyaWJ1dG9yIFRlc3QgQ0ExKDAmBgNVBAMMH1RpemVuIFB1Ymxp
04-02 23:29:01.300+0900 D/rpm-installer(14810): YyBEaXN0cmlidXRvciBTaWduZXIwgZ8wDQYJKoZIhvcNAQEBBQADgY0AMIGJAoGBALtMvlc5hENK
04-02 23:29:01.300+0900 D/rpm-installer(14810): 90ZdA+y66+Sy0enD1gpZDBh5T9RP0oRsptJv5jjNTseQbQi0SZOdOXb6J7iQdlBCtR343RpIEz8H
04-02 23:29:01.300+0900 D/rpm-installer(14810): mrBy7mSY7mgwoU4EPpp4CTSUeAuKcmvrNOngTp5Hv7Ngf02TTHOLK3hZLpGayaDviyNZB5PdqQdB
04-02 23:29:01.300+0900 D/rpm-installer(14810): hokKjzAzAgMBAAEwDQYJKoZIhvcNAQEFBQADgYEAvGp1gxxAIlFfhJH1efjb9BJK/rtRkbYn9+Ez
04-02 23:29:01.300+0900 D/rpm-installer(14810): GEbEULg1svsgnyWisFimI3uFvgI/swzr1eKVY3Sc8MQ3+Fdy3EkbDZ2+WAubhcEkorTWjzWz2fL1
04-02 23:29:01.300+0900 D/rpm-installer(14810): vKaYjeIsuEX6TVRUugHWudPzcEuQRLQf8ibZWjbQdBmpeQYBMg5x+xKLCJc=
04-02 23:29:01.300+0900 D/rpm-installer(14810): rpm-installer-signature.c: _ri_process_x509certificate(441) > x509certificate, len=[942]
04-02 23:29:01.300+0900 D/rpm-installer(14810): 
04-02 23:29:01.300+0900 D/rpm-installer(14810): MIICtDCCAh2gAwIBAgIJAMDbehElPNKvMA0GCSqGSIb3DQEBBQUAMIGVMQswCQYDVQQGEwJLUjEO
04-02 23:29:01.300+0900 D/rpm-installer(14810): MAwGA1UECAwFU3V3b24xDjAMBgNVBAcMBVN1d29uMRYwFAYDVQQKDA1UaXplbiBUZXN0IENBMSMw
04-02 23:29:01.300+0900 D/rpm-installer(14810): IQYDVQQLDBpUVGl6ZW4gRGlzdHJpYnV0b3IgVGVzdCBDQTEpMCcGA1UEAwwgVGl6ZW4gUHVibGlj
04-02 23:29:01.300+0900 D/rpm-installer(14810): IERpc3RyaWJ1dG9yIFJvb3QgQ0EwHhcNMTIxMDI5MTMwMjUwWhcNMjIxMDI3MTMwMjUwWjCBjzEL
04-02 23:29:01.300+0900 D/rpm-installer(14810): MAkGA1UEBhMCS1IxDjAMBgNVBAgMBVN1d29uMQ4wDAYDVQQHDAVTdXdvbjEWMBQGA1UECgwNVGl6
04-02 23:29:01.300+0900 D/rpm-installer(14810): ZW4gVGVzdCBDQTEiMCAGA1UECwwZVGl6ZW4gRGlzdHJpYnV0b3IgVGVzdCBDQTEkMCIGA1UEAwwb
04-02 23:29:01.300+0900 D/rpm-installer(14810): VGl6ZW4gUHVibGljIERpc3RyaWJ1dG9yIENBMIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQDe
04-02 23:29:01.300+0900 D/rpm-installer(14810): OTS/3nXvkDEmsFCJIvRlQ3RKDcxdWJJp625pFqHdmoJBdV+x6jl1raGK2Y1sp2Gdvpjc/z92yzAp
04-02 23:29:01.300+0900 D/rpm-installer(14810): bE/UVLPh/tRNZPeGhzU4ejDDm7kzdr2f7Ia0U98K+OoY12ucwg7TYNItj9is7Cj4blGfuMDzd2ah
04-02 23:29:01.300+0900 D/rpm-installer(14810): 2AgnCGlwNwV/pv+uVQIDAQABoxAwDjAMBgNVHRMEBTADAQH/MA0GCSqGSIb3DQEBBQUAA4GBACqJ
04-02 23:29:01.300+0900 D/rpm-installer(14810): KO33YdoGudwanZIxMdXuxnnD9R6u72ltKk1S4zPfMJJv482CRGCI4FK6djhlsI4i0Lt1SVIJEed+
04-02 23:29:01.300+0900 D/rpm-installer(14810): yc3qckGm19dW+4xdlkekon7pViEBWuyHw8OWv3RXtTum1+PGHjBJ2eYY4ZKIpz73U/1NC16sTB/0
04-02 23:29:01.300+0900 D/rpm-installer(14810): VhfnkHwPl
04-02 23:29:01.310+0900 D/CERT_SVC(14810): cert-service.c: _cert_svc_verify_certificate_with_caflag(188) > [SECURE_LOG] root cert path : /usr/share/cert-svc/certs/code-signing/tizen/tizen-distributor-root-ca-public.pem
04-02 23:29:01.310+0900 D/rpm-installer(14810): rpm-installer.c: _ri_verify_sig_and_cert(1744) > cert_svc_verify() is done successfully. validity=[1]
04-02 23:29:01.310+0900 D/rpm-installer(14810): rpm-installer.c: _ri_verify_sig_and_cert(1758) > cert_svc_get_visibility() returns visibility=[64]
04-02 23:29:01.310+0900 D/rpm-installer(14810): rpm-installer.c: _ri_verify_sig_and_cert(1771) > Root CA cert path=[/usr/share/cert-svc/certs/code-signing/tizen/tizen-distributor-root-ca-public.pem]
04-02 23:29:01.320+0900 D/rpm-installer(14810): rpm-installer.c: __ri_verify_file(336) > valid signature
04-02 23:29:01.320+0900 D/rpm-installer(14810): rpm-installer.c: __ri_get_cert_from_file(1029) > Root CA, len=[908]
04-02 23:29:01.320+0900 D/rpm-installer(14810): MIICozCCAgwCCQD9XW6kNg4bbjANBgkqhkiG9w0BAQUFADCBlTELMAkGA1UEBhMCS1IxDjAMBgNVBAgMBVN1d29uMQ4wDAYDVQQHDAVTdXdvbjEWMBQGA1UECgwNVGl6ZW4gVGVzdCBDQTEjMCEGA1UECwwaVFRpemVuIERpc3RyaWJ1dG9yIFRlc3QgQ0ExKTAnBgNVBAMMIFRpemVuIFB1YmxpYyBEaXN0cmlidXRvciBSb290IENBMB4XDTEyMTAyNjA4MDAyN1oXDTIyMTAyNDA4MDAyN1owgZUxCzAJBgNVBAYTAktSMQ4wDAYDVQQIDAVTdXdvbjEOMAwGA1UEBwwFU3V3b24xFjAUBgNVBAoMDVRpemVuIFRlc3QgQ0ExIzAhBgNVBAsMGlRUaXplbiBEaXN0cmlidXRvciBUZXN0IENBMSkwJwYDVQQDDCBUaXplbiBQdWJsaWMgRGlzdHJpYnV0b3IgUm9vdCBDQTCBnzANBgkqhkiG9w0BAQEFAAOBjQAwgYkCgYEA8o0kPY1U9El1BbBUF1k4jCq6mH8a6MmDJdjgsz+hILAYsPWimRTXUcW8GAUWhZWgm1Fbb49xWcasA8b4bIJabC/6hLb8uWiozzpRXyQJbe7k//RocskRqDmFOky8ANFsCCww72/Xbq8BFK1sxlGdmOWQiGwDWBDlS2Lw1XOMqb0CAwEAATANBgkqhkiG9w0BAQUFAAOBgQBUotZqTNFr+SNyqeZqhOToRsg3ojN1VJUa07qdlVo5I1UObSE+UTJPJ0NtSj7OyTY7fF3E4xzUv/w8aUoabQP1erEmztY/AVD+phHaPytkZ/Dx+zDZ1u5e9bKm5zfY4dQs/A53zDQta5a/NkZOEF97Dj3+bzAh2bP7KOszlocFYw==
04-02 23:29:01.320+0900 D/rpm-installer(14810): coretpk-installer.c: _coretpk_installer_verify_signatures(1284) > _ri_verify_sig_and_cert(/opt/usr/apps/org.example.example/signature1.xml) succeed.
04-02 23:29:01.320+0900 D/rpm-installer(14810): coretpk-installer.c: _coretpk_installer_package_reinstall(4980) > signature and certificate verifying success
04-02 23:29:01.320+0900 D/PKGMGR  (14810): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(14810), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(60)
04-02 23:29:01.320+0900 D/PKGMGR  (14810): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(14810), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(60)
04-02 23:29:01.320+0900 D/PKGMGR  (14810): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
04-02 23:29:01.320+0900 D/PKGMGR  (14808): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-584483273], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-02 23:29:01.320+0900 D/PKGMGR  ( 2940): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-584483273], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-02 23:29:01.320+0900 D/QUICKPANEL( 2940): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:install_percent val:60
04-02 23:29:01.320+0900 D/PKGMGR  ( 2922): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-584483273], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-02 23:29:01.320+0900 D/DATA_PROVIDER_MASTER( 2922): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.example] 60
04-02 23:29:01.320+0900 D/PKGMGR  ( 2951): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-584483273], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-02 23:29:01.320+0900 D/PKGMGR  ( 2951): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
04-02 23:29:01.320+0900 D/PKGMGR  ( 2944): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-584483273], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-02 23:29:01.320+0900 D/PKGMGR_INSTALLER(14810): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.example] key[install_percent] value[60]
04-02 23:29:01.320+0900 D/PKGMGR  (14810): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(14810), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(60)
04-02 23:29:01.320+0900 D/PKGMGR  (14810): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(14810), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(60)
04-02 23:29:01.320+0900 D/PKGMGR  (14810): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.install.progress), signal_name(install_progress)
04-02 23:29:01.320+0900 D/PKGMGR  ( 2870): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-584483273], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-02 23:29:01.320+0900 W/cluster-home( 2870): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.example]
04-02 23:29:01.320+0900 D/PKGMGR  ( 2870): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-584483273], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-02 23:29:01.320+0900 D/cluster-home( 2870): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[28700003] pkg_type[tpk] package[org.example.example] key[install_percent] val[60] pmsg[(null)]
04-02 23:29:01.320+0900 D/PKGMGR  ( 2942): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-584483273], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-02 23:29:01.320+0900 D/ESD     ( 2942): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29420002), pkg_type(tpk), pkgid(org.example.example), key(install_percent), val(60)
04-02 23:29:01.320+0900 D/PKGMGR  ( 3029): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-584483273], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-02 23:29:01.320+0900 E/PKGMGR_CERT(14810): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-02 23:29:01.320+0900 E/PKGMGR_CERT(14810): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 16
04-02 23:29:01.320+0900 E/PKGMGR_CERT(14810): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 16
04-02 23:29:01.320+0900 E/PKGMGR_CERT(14810): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 10 1
04-02 23:29:01.320+0900 E/PKGMGR_CERT(14810): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 7 4
04-02 23:29:01.320+0900 E/PKGMGR_CERT(14810): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 8 4
04-02 23:29:01.320+0900 E/PKGMGR_CERT(14810): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 9 4
04-02 23:29:01.320+0900 D/PKGMGR  ( 3091): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-584483273], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-02 23:29:01.330+0900 E/PKGMGR_CERT(14810): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-02 23:29:01.340+0900 D/rpm-installer(14810): rpm-installer-privilege.c: _ri_privilege_unregister_package(85) > [smack] app_uninstall(org.example.example), result=[0]
04-02 23:29:01.340+0900 D/rpm-installer(14810): rpm-installer-privilege.c: _ri_privilege_register_package(65) > [smack] app_install(org.example.example), result=[0]
04-02 23:29:01.340+0900 D/rpm-installer(14810): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example, 5, _), result=[0]
04-02 23:29:01.340+0900 D/rpm-installer(14810): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/shared, 5, _), result=[0]
04-02 23:29:01.340+0900 D/rpm-installer(14810): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/shared/res, 5, _), result=[0]
04-02 23:29:01.340+0900 D/rpm-installer(14810): rpm-installer-privilege.c: _ri_privilege_setup_path(117) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/shared/data, 2), result=[0]
04-02 23:29:01.340+0900 D/rpm-installer(14810): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1101) > [smack] get_smack_label, path=[/opt/usr/apps/org.example.example/shared/data], label=[$1$org.exam$u8BwfYMV9u%MYLLw2JGhj1]
04-02 23:29:01.340+0900 D/rpm-installer(14810): coretpk-installer.c: _coretpk_installer_set_smack_label_access(1088) > [smack] set_smack_label, path=[/opt/usr/apps/org.example.example/shared/cache], label=[$1$org.exam$u8BwfYMV9u%MYLLw2JGhj1]
04-02 23:29:01.340+0900 E/rpm-installer(14810): installer-util.c: _installer_util_get_configuration_value(418) > [signature]=[on]
04-02 23:29:01.340+0900 D/rpm-installer(14810): coretpk-installer.c: _coretpk_installer_get_group_id(2472) > encoding done, len=[28]
04-02 23:29:01.350+0900 D/rpm-installer(14810): coretpk-installer.c: _coretpk_installer_apply_smack(2575) > groupid = [lRCBhlfBM8hN+lAnIV9z4vodWRE=] for shared/trusted.
04-02 23:29:01.350+0900 D/rpm-installer(14810): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/shared/trusted, 1, lRCBhlfBM8hN+lAnIV9z4vodWRE=), result=[0]
04-02 23:29:01.350+0900 D/rpm-installer(14810): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/bin, 0, org.example.example), result=[0]
04-02 23:29:01.350+0900 D/rpm-installer(14810): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/data, 0, org.example.example), result=[0]
04-02 23:29:01.350+0900 D/rpm-installer(14810): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/lib, 0, org.example.example), result=[0]
04-02 23:29:01.350+0900 D/rpm-installer(14810): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/res, 0, org.example.example), result=[0]
04-02 23:29:01.360+0900 D/rpm-installer(14810): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/cache, 0, org.example.example), result=[0]
04-02 23:29:01.360+0900 D/rpm-installer(14810): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/tizen-manifest.xml, 0, org.example.example), result=[0]
04-02 23:29:01.360+0900 D/rpm-installer(14810): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/author-signature.xml, 0, org.example.example), result=[0]
04-02 23:29:01.360+0900 D/rpm-installer(14810): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/signature1.xml, 0, org.example.example), result=[0]
04-02 23:29:01.370+0900 D/rpm-installer(14810): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/share/packages/org.example.example.xml, 0, org.example.example), result=[0]
04-02 23:29:01.380+0900 D/rpm-installer(14810): rpm-installer-privilege.c: _ri_privilege_set_package_version(75) > [smack] app[org.example.example] version set to [2.4] result=[0]
04-02 23:29:01.380+0900 D/rpm-installer(14810): rpm-installer.c: _ri_apply_privilege(1924) > api-version[2.4] fot privilege has done successfully.
04-02 23:29:01.400+0900 D/rpm-installer(14810): rpm-installer-privilege.c: _ri_privilege_enable_permissions(106) > [smack] app_enable_permissions(org.example.example, 7), result=[0]
04-02 23:29:01.400+0900 D/rpm-installer(14810): coretpk-installer.c: _coretpk_installer_package_reinstall(5083) > #permission applying success.
04-02 23:29:01.400+0900 D/PKGMGR  (14810): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(14810), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
04-02 23:29:01.400+0900 D/PKGMGR  (14810): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(14810), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
04-02 23:29:01.400+0900 D/PKGMGR  (14810): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
04-02 23:29:01.400+0900 D/PKGMGR_INSTALLER(14810): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.example] key[install_percent] value[100]
04-02 23:29:01.400+0900 D/PKGMGR  (14810): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(14810), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
04-02 23:29:01.400+0900 D/PKGMGR  (14810): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(14810), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
04-02 23:29:01.400+0900 D/PKGMGR  (14810): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.install.progress), signal_name(install_progress)
04-02 23:29:01.400+0900 D/rpm-installer(14810): coretpk-installer.c: _coretpk_installer_package_reinstall(5096) > _coretpk_installer_package_reinstall(org.example.example) is done.
04-02 23:29:01.400+0900 D/PKGMGR  (14810): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(14810), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
04-02 23:29:01.400+0900 D/PKGMGR  (14810): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(14810), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
04-02 23:29:01.400+0900 D/PKGMGR  (14810): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
04-02 23:29:01.400+0900 D/PKGMGR_INSTALLER(14810): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.example] key[end] value[ok]
04-02 23:29:01.400+0900 D/PKGMGR  (14810): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(14810), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
04-02 23:29:01.400+0900 D/PKGMGR  (14810): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(14810), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
04-02 23:29:01.400+0900 D/PKGMGR  (14810): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.upgrade), signal_name(upgrade)
04-02 23:29:01.400+0900 D/PKGMGR  ( 2940): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-584483273], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-02 23:29:01.400+0900 D/QUICKPANEL( 2940): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:install_percent val:100
04-02 23:29:01.400+0900 D/PKGMGR  ( 2870): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-584483273], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-02 23:29:01.400+0900 W/cluster-home( 2870): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.example]
04-02 23:29:01.400+0900 D/PKGMGR  ( 2870): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-584483273], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-02 23:29:01.400+0900 D/cluster-home( 2870): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[28700003] pkg_type[tpk] package[org.example.example] key[install_percent] val[100] pmsg[(null)]
04-02 23:29:01.400+0900 D/PKGMGR  ( 2870): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-584483273], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 23:29:01.400+0900 W/cluster-home( 2870): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[2], package[org.example.example]
04-02 23:29:01.400+0900 D/cluster-home( 2870): widget-data-provider.cpp: PackageUpdated(2160) >  No boxes that pkgname is[org.example.example]
04-02 23:29:01.400+0900 D/PKGMGR  ( 2870): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-584483273], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 23:29:01.400+0900 D/cluster-home( 2870): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[28700003] pkg_type[tpk] package[org.example.example] key[end] val[ok] pmsg[(null)]
04-02 23:29:01.400+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
04-02 23:29:01.400+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
04-02 23:29:01.400+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
04-02 23:29:01.400+0900 D/PKGMGR  ( 3091): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-584483273], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-02 23:29:01.400+0900 D/PKGMGR  ( 3091): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-584483273], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 23:29:01.400+0900 D/PKGMGR  ( 2951): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-584483273], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-02 23:29:01.400+0900 D/PKGMGR  ( 2951): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
04-02 23:29:01.400+0900 D/PKGMGR  ( 2951): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-584483273], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 23:29:01.400+0900 D/PKGMGR  ( 2951): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
04-02 23:29:01.400+0900 D/PKGMGR  ( 2769): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[upgrade], req_id=[org.example.example_-584483273], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 23:29:01.400+0900 D/AUL_AMD ( 2769): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.example), key(end), value(ok)
04-02 23:29:01.400+0900 W/AUL_AMD ( 2769): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(update), value(ok)
04-02 23:29:01.400+0900 D/PKGMGR  ( 2922): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-584483273], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-02 23:29:01.400+0900 D/DATA_PROVIDER_MASTER( 2922): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.example] 100
04-02 23:29:01.400+0900 D/PKGMGR  ( 2922): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-584483273], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 23:29:01.400+0900 D/DATA_PROVIDER_MASTER( 2922): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.example] ok
04-02 23:29:01.400+0900 D/DATA_PROVIDER_MASTER( 2922): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.example], event_type[1]
04-02 23:29:01.400+0900 D/DATA_PROVIDER_MASTER( 2922): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
04-02 23:29:01.400+0900 D/DATA_PROVIDER_MASTER( 2922): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
04-02 23:29:01.400+0900 D/DATA_PROVIDER_MASTER( 2922): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
04-02 23:29:01.400+0900 D/DATA_PROVIDER_MASTER( 2922): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.example]
04-02 23:29:01.400+0900 D/PKGMGR  ( 2942): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-584483273], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-02 23:29:01.400+0900 D/ESD     ( 2942): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29420002), pkg_type(tpk), pkgid(org.example.example), key(install_percent), val(100)
04-02 23:29:01.400+0900 D/PKGMGR  ( 2942): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-584483273], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 23:29:01.400+0900 D/ESD     ( 2942): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29420002), pkg_type(tpk), pkgid(org.example.example), key(end), val(ok)
04-02 23:29:01.400+0900 D/ESD     ( 2942): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
04-02 23:29:01.400+0900 D/AUL_AMD ( 2769): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.example, type:rpm
04-02 23:29:01.400+0900 D/cluster-home( 2870): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
04-02 23:29:01.400+0900 D/cluster-home( 2870): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.example]
04-02 23:29:01.400+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.example]
04-02 23:29:01.400+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.example]
04-02 23:29:01.400+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
04-02 23:29:01.400+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
04-02 23:29:01.400+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.example]
04-02 23:29:01.400+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.example] Name[example] Icon[/opt/usr/apps/org.example.example/shared/res/example.png] enable[1] system[0]
04-02 23:29:01.400+0900 D/cluster-home( 2870): mainmenu-presenter.cpp: OnAppUpdated(337) >  pAppId [org.example.example]
04-02 23:29:01.400+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.example
04-02 23:29:01.400+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[13], isFolder[0], pageId[1], col[1], row[4], appId[org.example.example], name[example], menuId[1], isPreload[0] isPreload[0]
04-02 23:29:01.400+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
04-02 23:29:01.400+0900 E/cluster-home( 2870): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.example] Name[example] Icon[/opt/usr/apps/org.example.example/shared/res/example.png] enable[1] system[0]
04-02 23:29:01.400+0900 D/cluster-home( 2870): mainmenu-presenter.cpp: OnAppUpdated(364) >  name [example]
04-02 23:29:01.400+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
04-02 23:29:01.400+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
04-02 23:29:01.400+0900 D/test-log( 2870): mainmenu-box-impl.cpp: UpdateBoxData(812) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.example/shared/res/example.png], New icon path[/opt/usr/apps/org.example.example/shared/res/example.png]!!!!!
04-02 23:29:01.400+0900 D/cluster-home( 2870): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 1, appId = $appId, name = $name, col = 1, row = 4, isPreload = 0, isSystem = 0 WHERE boxId = 13]
04-02 23:29:01.400+0900 D/PKGMGR  ( 3029): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-584483273], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-02 23:29:01.400+0900 D/PKGMGR  ( 3029): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-584483273], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 23:29:01.400+0900 D/ISF_PANEL_EFL( 3029): isf_panel_efl.cpp: _package_manager_event_cb(1288) > type=tpk package=org.example.example event_type=UPDATE event_state=COMPLETED progress=100 error=0
04-02 23:29:01.410+0900 D/PKGMGR  ( 2944): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-584483273], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-02 23:29:01.410+0900 D/PKGMGR  ( 2944): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-584483273], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 23:29:01.410+0900 D/PKGMGR  ( 2940): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-584483273], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 23:29:01.410+0900 D/QUICKPANEL( 2940): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:end val:ok
04-02 23:29:01.410+0900 W/ISF_PANEL_EFL( 3029): isf_panel_efl.cpp: _package_manager_event_cb(1380) > isf_db_select_appids_by_pkgid returned 0.
04-02 23:29:01.410+0900 D/PKGMGR  (14808): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-584483273], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-02 23:29:01.410+0900 D/PKGMGR  (14808): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-584483273], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-02 23:29:01.430+0900 D/cluster-view( 2870): custom-cluster-impl.cpp: OnCustomScrollComplete(5141) >  ##################### scroll complete ########################### 
04-02 23:29:01.430+0900 D/cluster-view( 2870): cluster-impl.cpp: OnScrollComplete(639) >  Horizontal Cluster scrollview is stopped normally, pos[0.00, 0.00]
04-02 23:29:01.430+0900 D/cluster-view( 2870): cluster-impl.cpp: OnScrollComplete(653) >  scroll position x : -0.00 (page:0)
04-02 23:29:01.430+0900 D/test-log( 2870): cluster-impl.cpp: SetFocusedPage(791) >  Set mFocusedPage: 1
04-02 23:29:01.430+0900 D/test-log( 2870): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
04-02 23:29:01.430+0900 D/cluster-view( 2870): cluster-view-controller.cpp: OnClusterChangeFocusedPage(1779) >  Cluster[0:] 1 page focused
04-02 23:29:01.430+0900 D/cluster-home( 2870): widget-data-provider.cpp: OnCustomClusterFocusedPageChanged(2934) >  Cluster[0] page[1] focused
04-02 23:29:01.510+0900 D/rpm-installer(14810): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
04-02 23:29:01.510+0900 D/rpm-installer(14810): rpm-appcore-intf.c: main(259) > ------------------------------------------------
04-02 23:29:01.510+0900 D/rpm-installer(14810): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
04-02 23:29:01.510+0900 D/rpm-installer(14810): rpm-appcore-intf.c: main(261) > ------------------------------------------------
04-02 23:29:01.510+0900 D/PKGMGR_SERVER(14721): pkgmgr-server.c: sighandler(387) > child exit [14810]
04-02 23:29:01.510+0900 E/PKGMGR_SERVER(14721): pkgmgr-server.c: sighandler(402) > child NORMAL exit [14810]
04-02 23:29:01.700+0900 D/AUL_AMD ( 2769): amd_request.c: __request_handler(838) > __request_handler: 0
04-02 23:29:01.700+0900 D/AUL_AMD ( 2769): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
04-02 23:29:01.700+0900 D/PKGMGR_INFO( 2769): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
04-02 23:29:01.700+0900 D/PKGMGR_INFO( 2769): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
04-02 23:29:01.700+0900 I/AUL     ( 2769): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
04-02 23:29:01.700+0900 D/AUL     ( 2769): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 14860, pid = 14862
04-02 23:29:01.700+0900 D/PKGMGR_INFO( 2769): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
04-02 23:29:01.700+0900 D/PKGMGR_INFO( 2769): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
04-02 23:29:01.700+0900 I/AUL     ( 2769): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
04-02 23:29:01.700+0900 E/AUL_AMD ( 2769): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
04-02 23:29:01.700+0900 W/AUL_AMD ( 2769): amd_launch.c: _start_app(2233) > caller pid : 14862
04-02 23:29:01.700+0900 E/AUL_AMD ( 2769): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
04-02 23:29:01.700+0900 W/AUL_AMD ( 2769): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
04-02 23:29:01.700+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2648) > process_pool: false
04-02 23:29:01.700+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
04-02 23:29:01.700+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
04-02 23:29:01.700+0900 W/AUL_AMD ( 2769): amd_launch.c: _start_app(2665) > pad pid(-5)
04-02 23:29:01.700+0900 D/AUL_AMD ( 2769): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
04-02 23:29:01.700+0900 D/AUL_AMD ( 2769): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
04-02 23:29:01.700+0900 D/AUL     ( 2769): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
04-02 23:29:01.700+0900 D/RESOURCED( 2852): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
04-02 23:29:01.700+0900 D/RESOURCED( 2852): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
04-02 23:29:01.700+0900 E/RESOURCED( 2852): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-02 23:29:01.700+0900 D/AUL_PAD ( 2920): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
04-02 23:29:01.700+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
04-02 23:29:01.700+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
04-02 23:29:01.700+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
04-02 23:29:01.700+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
04-02 23:29:01.700+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
04-02 23:29:01.700+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
04-02 23:29:01.700+0900 D/AUL_PAD ( 2920): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
04-02 23:29:01.700+0900 D/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
04-02 23:29:01.700+0900 D/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
04-02 23:29:01.700+0900 D/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
04-02 23:29:01.700+0900 D/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
04-02 23:29:01.700+0900 D/AUL_PAD ( 2920): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
04-02 23:29:01.700+0900 D/AUL_PAD ( 2920): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
04-02 23:29:01.700+0900 W/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
04-02 23:29:01.700+0900 D/AUL     ( 2920): process_pool.c: __send_pkt_raw_data(219) > send(13) : 624 / 624
04-02 23:29:01.700+0900 D/AUL_PAD ( 2920): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 14685, bin path: /opt/usr/apps/org.example.example/bin/example
04-02 23:29:01.700+0900 W/AUL_PAD ( 2920): launchpad.c: __send_result_to_caller(265) > Check app launching
04-02 23:29:01.700+0900 D/AUL_PAD ( 2920): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
04-02 23:29:01.700+0900 D/AUL_PAD (14685): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
04-02 23:29:01.700+0900 D/AUL_PAD (14685): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
04-02 23:29:01.700+0900 D/AUL_PAD (14685): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
04-02 23:29:01.700+0900 D/AUL_PAD (14685): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
04-02 23:29:01.700+0900 D/AUL_PAD (14685): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
04-02 23:29:01.700+0900 D/AUL_PAD (14685): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
04-02 23:29:01.700+0900 D/AUL     (14685): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (14687) is sent.
04-02 23:29:01.700+0900 D/AUL     (14685): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 14687, signo: 10
04-02 23:29:01.710+0900 D/AUL     (14685): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
04-02 23:29:01.710+0900 D/AUL_PAD (14685): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
04-02 23:29:01.710+0900 D/AUL_PAD (14685): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
04-02 23:29:01.710+0900 D/AUL_PAD (14685): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
04-02 23:29:01.710+0900 D/AUL_PAD (14685): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
04-02 23:29:01.710+0900 D/AUL_PAD (14685): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTExNDMzNDEvNzAyMzAxAA==##
04-02 23:29:01.710+0900 D/AUL_PAD (14685): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
04-02 23:29:01.710+0900 D/AUL_PAD (14685): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAxNDg2MgA=##
04-02 23:29:01.710+0900 D/AUL_PAD (14685): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
04-02 23:29:01.710+0900 D/AUL_PAD (14685): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
04-02 23:29:01.710+0900 D/AUL_PAD (14685): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
04-02 23:29:01.710+0900 D/AUL_PAD (14685): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
04-02 23:29:01.710+0900 D/AUL_PAD (14685): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
04-02 23:29:01.710+0900 I/CAPI_APPFW_APPLICATION(14685): app_main.c: ui_app_main(788) > app_efl_main
04-02 23:29:01.710+0900 D/LAUNCH  (14685): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
04-02 23:29:01.710+0900 D/APP_CORE(14685): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
04-02 23:29:01.710+0900 D/APP_CORE(14685): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
04-02 23:29:01.710+0900 D/APP_CORE(14685): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
04-02 23:29:01.720+0900 D/APP_CORE(14685): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
04-02 23:29:01.720+0900 D/AUL     (14685): app_sock.c: __create_server_sock(156) > pg path - already exists
04-02 23:29:01.720+0900 D/APP_CORE(14685): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42e2520
04-02 23:29:01.720+0900 D/LAUNCH  (14685): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
04-02 23:29:01.720+0900 I/CAPI_APPFW_APPLICATION(14685): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
04-02 23:29:01.800+0900 E/AUL_PAD ( 2920): launchpad.c: __send_result_to_caller(280) > error founded when being launched with 14685
04-02 23:29:01.800+0900 E/AUL_PAD ( 2920): launchpad.c: __send_result_to_caller(282) > The app process might be terminated while we are wating 14685
04-02 23:29:01.800+0900 E/AUL_PAD ( 2920): launchpad.c: __send_result_to_caller(312) > process launched, but cmdline not changed
04-02 23:29:01.800+0900 W/AUL     ( 2769): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 14685, appid: org.example.example
04-02 23:29:01.800+0900 D/AUL     ( 2769): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
04-02 23:29:01.800+0900 E/AUL     ( 2769): simple_util.c: __trm_app_info_send_socket(330) > access
04-02 23:29:01.800+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2700) > add app group info
04-02 23:29:01.800+0900 E/AUL     ( 2769): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
04-02 23:29:01.800+0900 D/AUL_AMD ( 2769): amd_status.c: _status_add_app_info_list(427) > pid(14685) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
04-02 23:29:01.810+0900 D/RESOURCED( 2852): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 14685
04-02 23:29:01.810+0900 D/RESOURCED( 2852): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
04-02 23:29:01.810+0900 E/RESOURCED( 2852): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
04-02 23:29:01.810+0900 D/RESOURCED( 2852): proc-main.c: resourced_proc_status_change(888) > available memory = 318
04-02 23:29:01.820+0900 W/CRASH_MANAGER(14867): worker.c: worker_job(1204) > 1114685657861149114334
