S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 10663
Date: 2017-04-01 03:17:40+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x14

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb95bf8e0, esi = 0x8000fc7f
ebp = 0xbfb60b98, esp = 0xbfb60b60
eax = 0x00000000, ebx = 0xb729d5f0
ecx = 0x0000009b, edx = 0x00000015
eip = 0xb70f4bbf

Memory Information
MemTotal:      123 KB
MemFree:        20 KB
Buffers:         8 KB
Cached:     181084 KB
VmPeak:      79600 KB
VmSize:      79600 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14808 KB
VmRSS:       14808 KB
VmData:      19688 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33316 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 10663 TID = 10663
10663 10695 10902 

Maps Information
b2c25000 b2c2f000 r-xp /usr/lib/libfeedback.so.0.1.4
b2c35000 b2c41000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2c42000 b2c63000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2c68000 b2c69000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2c6a000 b2c6f000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2c70000 b2c71000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2c72000 b2c74000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c75000 b2c77000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2c78000 b2c84000 r-xp /usr/lib/libdrm.so.2.4.0
b2c85000 b2c88000 r-xp /usr/lib/libdri2.so.0.0.0
b2c89000 b2c93000 r-xp /usr/lib/libtbm.so.1.0.0
b2c9a000 b2c9b000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2c9c000 b2c9d000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2c9e000 b2ca1000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b2ca2000 b2ca5000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b2ca6000 b2cbb000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2cbc000 b2cce000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b35d7000 b35dd000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b35de000 b3722000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3733000 b3734000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b3735000 b373e000 r-xp /usr/lib/libefl-extension.so.0.1.0
b373f000 b3742000 r-xp /opt/usr/apps/org.example.example/bin/example
b3744000 b377d000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4180000 b418b000 r-xp /lib/libnss_files-2.20-2014.11.so
b418d000 b4198000 r-xp /lib/libnss_nis-2.20-2014.11.so
b419a000 b41b1000 r-xp /lib/libnsl-2.20-2014.11.so
b41b5000 b41bd000 r-xp /lib/libnss_compat-2.20-2014.11.so
b41bf000 b41e3000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b41e4000 b41e5000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b41e6000 b41e9000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b41ea000 b41f1000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b41f2000 b41fc000 r-xp /usr/lib/libsensord-share.so
b41fd000 b4219000 r-xp /usr/lib/libsensor.so.1.2.0
b421b000 b4224000 r-xp /usr/lib/libappcore-common.so.1.1
b4227000 b4229000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b423e000 b4240000 r-xp /usr/lib/libXau.so.6.0.0
b4241000 b4263000 r-xp /usr/lib/libxcb.so.1.1.0
b4265000 b426e000 r-xp /lib/libcrypt-2.20-2014.11.so
b4297000 b4299000 r-xp /usr/lib/libiri.so
b429a000 b42c0000 r-xp /lib/libexpat.so.1.5.2
b42c2000 b432d000 r-xp /usr/lib/libssl.so.1.0.0
b4333000 b433f000 r-xp /usr/lib/libethumb.so.1.13.0
b4340000 b4344000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4345000 b4596000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b11000 b5b21000 r-xp /usr/lib/libXi.so.6.1.0
b5b22000 b5b24000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b25000 b5b2b000 r-xp /usr/lib/libXtst.so.6.1.0
b5b2c000 b5b36000 r-xp /usr/lib/libXrender.so.1.3.0
b5b37000 b5b40000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b42000 b5b44000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b45000 b5b4a000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b4b000 b5b5d000 r-xp /usr/lib/libXext.so.6.4.0
b5b5e000 b5b60000 r-xp /usr/lib/libXdamage.so.1.1.0
b5b61000 b5b63000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5b65000 b5ca7000 r-xp /usr/lib/libX11.so.6.3.0
b5cab000 b5cb5000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cb6000 b5ccc000 r-xp /usr/lib/libudev.so.1.6.0
b5ccf000 b5cd3000 r-xp /lib/libattr.so.1.1.0
b5cd4000 b5d03000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d05000 b5d0b000 r-xp /usr/lib/libffi.so.6.0.2
b5d0c000 b5d2f000 r-xp /lib/libz.so.1.2.8
b5d30000 b5d33000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d34000 b5e90000 r-xp /usr/lib/libxml2.so.2.9.2
b5e96000 b5f7d000 r-xp /usr/lib/libstdc++.so.6.0.20
b5f8a000 b5f8d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5f8e000 b5fb0000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5fb1000 b5fc5000 r-xp /lib/libresolv-2.20-2014.11.so
b5fc9000 b5fed000 r-xp /usr/lib/liblzma.so.5.0.3
b5fee000 b5ff0000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5ff2000 b5ffc000 r-xp /usr/lib/libembryo.so.1.13.0
b5ffd000 b6026000 r-xp /usr/lib/libpng12.so.0.50.0
b6027000 b6070000 r-xp /usr/lib/libjpeg.so.8.0.2
b6081000 b6088000 r-xp /lib/librt-2.20-2014.11.so
b608a000 b60a9000 r-xp /usr/lib/libector.so.1.13.0
b60ac000 b60d9000 r-xp /usr/lib/liblua-5.1.so
b60da000 b616a000 r-xp /usr/lib/libfreetype.so.6.11.3
b616e000 b61ac000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61ad000 b61c3000 r-xp /usr/lib/libfribidi.so.0.3.1
b61c4000 b621d000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6220000 b626b000 r-xp /lib/libm-2.20-2014.11.so
b626d000 b627f000 r-xp /usr/lib/libeio.so.1.13.0
b6280000 b6283000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6284000 b628a000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b628b000 b62ae000 r-xp /usr/lib/libefreet.so.1.13.0
b62b1000 b62dc000 r-xp /usr/lib/libeldbus.so.1.13.0
b62dd000 b6311000 r-xp /usr/lib/libecore_con.so.1.13.0
b6313000 b631c000 r-xp /usr/lib/libecore_imf.so.1.13.0
b631d000 b6326000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6327000 b633a000 r-xp /usr/lib/libeo.so.1.13.0
b633c000 b634f000 r-xp /usr/lib/libecore_input.so.1.13.0
b6350000 b6357000 r-xp /usr/lib/libecore_file.so.1.13.0
b6358000 b637b000 r-xp /usr/lib/libecore_evas.so.1.13.0
b637c000 b63a8000 r-xp /usr/lib/libeet.so.1.13.0
b63b1000 b641c000 r-xp /usr/lib/libeina.so.1.13.0
b641f000 b6436000 r-xp /usr/lib/libefl.so.1.13.0
b6438000 b659f000 r-xp /usr/lib/libicuuc.so.51.1
b65ad000 b67b9000 r-xp /usr/lib/libicui18n.so.51.1
b67c1000 b6810000 r-xp /usr/lib/libecore_x.so.1.13.0
b6812000 b682c000 r-xp /lib/libgcc_s-4.9.so.1
b682e000 b6832000 r-xp /lib/libcap.so.2.21
b6833000 b6879000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b687a000 b6881000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6883000 b68d5000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b68d7000 b6a62000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6a67000 b6b35000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b38000 b6b3c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b3d000 b6b4c000 r-xp /usr/lib/libvconf.so.0.2.45
b6b4d000 b6b50000 r-xp /usr/lib/libvasum.so.0.3.1
b6b51000 b6b54000 r-xp /usr/lib/libttrace.so.1.1
b6b56000 b6b5a000 r-xp /usr/lib/libiniparser.so.0
b6b5b000 b6b8b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6b8c000 b6b95000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6b96000 b6bbb000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bbc000 b6bcc000 r-xp /usr/lib/libunwind.so.8.0.1
b6bd6000 b6d84000 r-xp /lib/libc-2.20-2014.11.so
b6d8c000 b6ecf000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6ed1000 b6f29000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f2a000 b6f5e000 r-xp /usr/lib/libsystemd.so.0.4.0
b6f61000 b7035000 r-xp /usr/lib/libedje.so.1.13.0
b7038000 b7064000 r-xp /usr/lib/libecore.so.1.13.0
b7075000 b729b000 r-xp /usr/lib/libevas.so.1.13.0
b72c3000 b72db000 r-xp /lib/libpthread-2.20-2014.11.so
b72df000 b7659000 r-xp /usr/lib/libelementary.so.1.13.0
b7679000 b767d000 r-xp /usr/lib/libsmack.so.1.0.0
b767e000 b7687000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7688000 b768b000 r-xp /usr/lib/libdlog.so.0.0.0
b768c000 b7691000 r-xp /usr/lib/libbundle.so.0.1.22
b7692000 b7695000 r-xp /lib/libdl-2.20-2014.11.so
b7697000 b76bc000 r-xp /usr/lib/libaul.so.0.1.0
b76bf000 b76c1000 r-xp /usr/lib/libappsvc.so.0.1.0
b76c2000 b76c7000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b76c8000 b76cf000 r-xp /usr/lib/libappcore-efl.so.1.1
b76d1000 b76d6000 r-xp /usr/lib/libsys-assert.so
b76d9000 b76da000 r-xp [vdso]
b76da000 b76fc000 r-xp /lib/ld-2.20-2014.11.so
b76fe000 b7706000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:10663)
Call Stack Count: 27
 0: (0xb70f4bbf) [/usr/lib/libevas.so.1] + 0x7fbbf
 1: (0xb70e6ce8) [/usr/lib/libevas.so.1] + 0x71ce8
 2: evas_obj_size_hint_min_set + 0xb9 (0xb70e1629) [/usr/lib/libevas.so.1] + 0x6c629
 3: evas_object_size_hint_min_set + 0x60 (0xb70eefa0) [/usr/lib/libevas.so.1] + 0x79fa0
 4: (0xb74877df) [/usr/lib/libelementary.so.1] + 0x1a87df
 5: elm_obj_layout_sizing_eval + 0x99 (0xb748a559) [/usr/lib/libelementary.so.1] + 0x1ab559
 6: (0xb7491205) [/usr/lib/libelementary.so.1] + 0x1b2205
 7: evas_obj_smart_add + 0x99 (0xb70ff809) [/usr/lib/libevas.so.1] + 0x8a809
 8: (0xb748824b) [/usr/lib/libelementary.so.1] + 0x1a924b
 9: evas_obj_smart_add + 0x99 (0xb70ff809) [/usr/lib/libevas.so.1] + 0x8a809
10: (0xb7102d8b) [/usr/lib/libevas.so.1] + 0x8dd8b
11: eo_constructor + 0x99 (0xb6331899) [/usr/lib/libeo.so.1] + 0xa899
12: (0xb75504a6) [/usr/lib/libelementary.so.1] + 0x2714a6
13: eo_constructor + 0x99 (0xb6331899) [/usr/lib/libeo.so.1] + 0xa899
14: (0xb7492c37) [/usr/lib/libelementary.so.1] + 0x1b3c37
15: eo_constructor + 0x99 (0xb6331899) [/usr/lib/libeo.so.1] + 0xa899
16: (0xb7488692) [/usr/lib/libelementary.so.1] + 0x1a9692
17: eo_constructor + 0x99 (0xb6331899) [/usr/lib/libeo.so.1] + 0xa899
18: elm_label_add + 0x77 (0xb7486cf7) [/usr/lib/libelementary.so.1] + 0x1a7cf7
19: create_base_gui + 0x43d (0xb3740f4d) [/opt/usr/apps/org.example.example/bin/example] + 0x1f4d
20: app_create + 0x2c (0xb374097c) [/opt/usr/apps/org.example.example/bin/example] + 0x197c
21: (0xb76c465b) [/usr/lib/libcapi-appfw-application.so.0] + 0x265b
22: appcore_efl_main + 0x327 (0xb76cbc27) [/usr/lib/libappcore-efl.so.1] + 0x3c27
23: ui_app_main + 0x140 (0xb76c4c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
24: main + 0x27e (0xb37408ee) [/opt/usr/apps/org.example.example/bin/example] + 0x18ee
25: create_base_gui + 0x638 (0xb7700148) [/opt/usr/apps/org.example.example/bin/example] + 0xb7700148
26: __libc_start_main + 0xde (0xb6bede4e) [/lib/libc.so.6] + 0x17e4e
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
=
04-01 03:17:40.275+0900 D/rpm-installer(10846): rpm-installer-signature.c: _ri_process_x509certificate(441) > x509certificate, len=[909]
04-01 03:17:40.275+0900 D/rpm-installer(10846): 
04-01 03:17:40.275+0900 D/rpm-installer(10846): MIICmzCCAgQCCQDXI7WLdVZwiTANBgkqhkiG9w0BAQUFADCBjzELMAkGA1UEBhMCS1IxDjAMBgNV
04-01 03:17:40.275+0900 D/rpm-installer(10846): BAgMBVN1d29uMQ4wDAYDVQQHDAVTdXdvbjEWMBQGA1UECgwNVGl6ZW4gVGVzdCBDQTEiMCAGA1UE
04-01 03:17:40.275+0900 D/rpm-installer(10846): CwwZVGl6ZW4gRGlzdHJpYnV0b3IgVGVzdCBDQTEkMCIGA1UEAwwbVGl6ZW4gUHVibGljIERpc3Ry
04-01 03:17:40.275+0900 D/rpm-installer(10846): aWJ1dG9yIENBMB4XDTEyMTAyOTEzMDMwNFoXDTIyMTAyNzEzMDMwNFowgZMxCzAJBgNVBAYTAktS
04-01 03:17:40.275+0900 D/rpm-installer(10846): MQ4wDAYDVQQIDAVTdXdvbjEOMAwGA1UEBwwFU3V3b24xFjAUBgNVBAoMDVRpemVuIFRlc3QgQ0Ex
04-01 03:17:40.275+0900 D/rpm-installer(10846): IjAgBgNVBAsMGVRpemVuIERpc3RyaWJ1dG9yIFRlc3QgQ0ExKDAmBgNVBAMMH1RpemVuIFB1Ymxp
04-01 03:17:40.275+0900 D/rpm-installer(10846): YyBEaXN0cmlidXRvciBTaWduZXIwgZ8wDQYJKoZIhvcNAQEBBQADgY0AMIGJAoGBALtMvlc5hENK
04-01 03:17:40.275+0900 D/rpm-installer(10846): 90ZdA+y66+Sy0enD1gpZDBh5T9RP0oRsptJv5jjNTseQbQi0SZOdOXb6J7iQdlBCtR343RpIEz8H
04-01 03:17:40.275+0900 D/rpm-installer(10846): mrBy7mSY7mgwoU4EPpp4CTSUeAuKcmvrNOngTp5Hv7Ngf02TTHOLK3hZLpGayaDviyNZB5PdqQdB
04-01 03:17:40.275+0900 D/rpm-installer(10846): hokKjzAzAgMBAAEwDQYJKoZIhvcNAQEFBQADgYEAvGp1gxxAIlFfhJH1efjb9BJK/rtRkbYn9+Ez
04-01 03:17:40.275+0900 D/rpm-installer(10846): GEbEULg1svsgnyWisFimI3uFvgI/swzr1eKVY3Sc8MQ3+Fdy3EkbDZ2+WAubhcEkorTWjzWz2fL1
04-01 03:17:40.275+0900 D/rpm-installer(10846): vKaYjeIsuEX6TVRUugHWudPzcEuQRLQf8ibZWjbQdBmpeQYBMg5x+xKLCJc=
04-01 03:17:40.275+0900 D/rpm-installer(10846): rpm-installer-signature.c: _ri_process_x509certificate(441) > x509certificate, len=[942]
04-01 03:17:40.275+0900 D/rpm-installer(10846): 
04-01 03:17:40.275+0900 D/rpm-installer(10846): MIICtDCCAh2gAwIBAgIJAMDbehElPNKvMA0GCSqGSIb3DQEBBQUAMIGVMQswCQYDVQQGEwJLUjEO
04-01 03:17:40.275+0900 D/rpm-installer(10846): MAwGA1UECAwFU3V3b24xDjAMBgNVBAcMBVN1d29uMRYwFAYDVQQKDA1UaXplbiBUZXN0IENBMSMw
04-01 03:17:40.275+0900 D/rpm-installer(10846): IQYDVQQLDBpUVGl6ZW4gRGlzdHJpYnV0b3IgVGVzdCBDQTEpMCcGA1UEAwwgVGl6ZW4gUHVibGlj
04-01 03:17:40.275+0900 D/rpm-installer(10846): IERpc3RyaWJ1dG9yIFJvb3QgQ0EwHhcNMTIxMDI5MTMwMjUwWhcNMjIxMDI3MTMwMjUwWjCBjzEL
04-01 03:17:40.275+0900 D/rpm-installer(10846): MAkGA1UEBhMCS1IxDjAMBgNVBAgMBVN1d29uMQ4wDAYDVQQHDAVTdXdvbjEWMBQGA1UECgwNVGl6
04-01 03:17:40.275+0900 D/rpm-installer(10846): ZW4gVGVzdCBDQTEiMCAGA1UECwwZVGl6ZW4gRGlzdHJpYnV0b3IgVGVzdCBDQTEkMCIGA1UEAwwb
04-01 03:17:40.275+0900 D/rpm-installer(10846): VGl6ZW4gUHVibGljIERpc3RyaWJ1dG9yIENBMIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQDe
04-01 03:17:40.275+0900 D/rpm-installer(10846): OTS/3nXvkDEmsFCJIvRlQ3RKDcxdWJJp625pFqHdmoJBdV+x6jl1raGK2Y1sp2Gdvpjc/z92yzAp
04-01 03:17:40.275+0900 D/rpm-installer(10846): bE/UVLPh/tRNZPeGhzU4ejDDm7kzdr2f7Ia0U98K+OoY12ucwg7TYNItj9is7Cj4blGfuMDzd2ah
04-01 03:17:40.275+0900 D/rpm-installer(10846): 2AgnCGlwNwV/pv+uVQIDAQABoxAwDjAMBgNVHRMEBTADAQH/MA0GCSqGSIb3DQEBBQUAA4GBACqJ
04-01 03:17:40.275+0900 D/rpm-installer(10846): KO33YdoGudwanZIxMdXuxnnD9R6u72ltKk1S4zPfMJJv482CRGCI4FK6djhlsI4i0Lt1SVIJEed+
04-01 03:17:40.275+0900 D/rpm-installer(10846): yc3qckGm19dW+4xdlkekon7pViEBWuyHw8OWv3RXtTum1+PGHjBJ2eYY4ZKIpz73U/1NC16sTB/0
04-01 03:17:40.275+0900 D/rpm-installer(10846): VhfnkHwPl
04-01 03:17:40.275+0900 D/CERT_SVC(10846): cert-service.c: _cert_svc_verify_certificate_with_caflag(188) > [SECURE_LOG] root cert path : /usr/share/cert-svc/certs/code-signing/tizen/tizen-distributor-root-ca-public.pem
04-01 03:17:40.275+0900 D/rpm-installer(10846): rpm-installer.c: _ri_verify_sig_and_cert(1744) > cert_svc_verify() is done successfully. validity=[1]
04-01 03:17:40.275+0900 D/rpm-installer(10846): rpm-installer.c: _ri_verify_sig_and_cert(1758) > cert_svc_get_visibility() returns visibility=[64]
04-01 03:17:40.275+0900 D/rpm-installer(10846): rpm-installer.c: _ri_verify_sig_and_cert(1771) > Root CA cert path=[/usr/share/cert-svc/certs/code-signing/tizen/tizen-distributor-root-ca-public.pem]
04-01 03:17:40.275+0900 D/rpm-installer(10846): rpm-installer.c: __ri_verify_file(336) > valid signature
04-01 03:17:40.275+0900 D/rpm-installer(10846): rpm-installer.c: __ri_get_cert_from_file(1029) > Root CA, len=[908]
04-01 03:17:40.275+0900 D/rpm-installer(10846): MIICozCCAgwCCQD9XW6kNg4bbjANBgkqhkiG9w0BAQUFADCBlTELMAkGA1UEBhMCS1IxDjAMBgNVBAgMBVN1d29uMQ4wDAYDVQQHDAVTdXdvbjEWMBQGA1UECgwNVGl6ZW4gVGVzdCBDQTEjMCEGA1UECwwaVFRpemVuIERpc3RyaWJ1dG9yIFRlc3QgQ0ExKTAnBgNVBAMMIFRpemVuIFB1YmxpYyBEaXN0cmlidXRvciBSb290IENBMB4XDTEyMTAyNjA4MDAyN1oXDTIyMTAyNDA4MDAyN1owgZUxCzAJBgNVBAYTAktSMQ4wDAYDVQQIDAVTdXdvbjEOMAwGA1UEBwwFU3V3b24xFjAUBgNVBAoMDVRpemVuIFRlc3QgQ0ExIzAhBgNVBAsMGlRUaXplbiBEaXN0cmlidXRvciBUZXN0IENBMSkwJwYDVQQDDCBUaXplbiBQdWJsaWMgRGlzdHJpYnV0b3IgUm9vdCBDQTCBnzANBgkqhkiG9w0BAQEFAAOBjQAwgYkCgYEA8o0kPY1U9El1BbBUF1k4jCq6mH8a6MmDJdjgsz+hILAYsPWimRTXUcW8GAUWhZWgm1Fbb49xWcasA8b4bIJabC/6hLb8uWiozzpRXyQJbe7k//RocskRqDmFOky8ANFsCCww72/Xbq8BFK1sxlGdmOWQiGwDWBDlS2Lw1XOMqb0CAwEAATANBgkqhkiG9w0BAQUFAAOBgQBUotZqTNFr+SNyqeZqhOToRsg3ojN1VJUa07qdlVo5I1UObSE+UTJPJ0NtSj7OyTY7fF3E4xzUv/w8aUoabQP1erEmztY/AVD+phHaPytkZ/Dx+zDZ1u5e9bKm5zfY4dQs/A53zDQta5a/NkZOEF97Dj3+bzAh2bP7KOszlocFYw==
04-01 03:17:40.275+0900 D/rpm-installer(10846): coretpk-installer.c: _coretpk_installer_verify_signatures(1284) > _ri_verify_sig_and_cert(/opt/usr/apps/org.example.example/signature1.xml) succeed.
04-01 03:17:40.275+0900 D/rpm-installer(10846): coretpk-installer.c: _coretpk_installer_package_reinstall(4980) > signature and certificate verifying success
04-01 03:17:40.275+0900 D/PKGMGR  (10846): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(10846), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(60)
04-01 03:17:40.275+0900 D/PKGMGR  (10846): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(10846), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(60)
04-01 03:17:40.275+0900 D/PKGMGR  (10846): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
04-01 03:17:40.275+0900 D/PKGMGR_INSTALLER(10846): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.example] key[install_percent] value[60]
04-01 03:17:40.275+0900 D/PKGMGR  (10846): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(10846), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(60)
04-01 03:17:40.275+0900 D/PKGMGR  (10846): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(10846), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(60)
04-01 03:17:40.275+0900 D/PKGMGR  (10846): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.install.progress), signal_name(install_progress)
04-01 03:17:40.275+0900 E/PKGMGR_CERT(10846): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-01 03:17:40.275+0900 E/PKGMGR_CERT(10846): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 17
04-01 03:17:40.275+0900 E/PKGMGR_CERT(10846): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 17
04-01 03:17:40.275+0900 E/PKGMGR_CERT(10846): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 10 2
04-01 03:17:40.275+0900 E/PKGMGR_CERT(10846): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 7 5
04-01 03:17:40.275+0900 E/PKGMGR_CERT(10846): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 8 5
04-01 03:17:40.275+0900 E/PKGMGR_CERT(10846): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 9 5
04-01 03:17:40.295+0900 D/PKGMGR  (10844): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
04-01 03:17:40.295+0900 D/PKGMGR  ( 2968): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
04-01 03:17:40.295+0900 D/QUICKPANEL( 2968): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:install_percent val:30
04-01 03:17:40.295+0900 D/PKGMGR  ( 2976): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
04-01 03:17:40.295+0900 D/PKGMGR  ( 2983): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
04-01 03:17:40.295+0900 D/PKGMGR  ( 2983): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
04-01 03:17:40.295+0900 D/PKGMGR  ( 3052): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
04-01 03:17:40.295+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
04-01 03:17:40.295+0900 W/cluster-home( 2906): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.example]
04-01 03:17:40.295+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
04-01 03:17:40.295+0900 D/cluster-home( 2906): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29060003] pkg_type[tpk] package[org.example.example] key[install_percent] val[30] pmsg[(null)]
04-01 03:17:40.295+0900 D/PKGMGR  ( 2974): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
04-01 03:17:40.295+0900 D/ESD     ( 2974): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29740002), pkg_type(tpk), pkgid(org.example.example), key(install_percent), val(30)
04-01 03:17:40.295+0900 D/PKGMGR  ( 2960): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
04-01 03:17:40.295+0900 D/DATA_PROVIDER_MASTER( 2960): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.example] 30
04-01 03:17:40.295+0900 D/PKGMGR  ( 3098): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
04-01 03:17:40.295+0900 D/PKGMGR  ( 2968): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-01 03:17:40.295+0900 D/QUICKPANEL( 2968): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:install_percent val:60
04-01 03:17:40.295+0900 D/PKGMGR  (10844): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-01 03:17:40.295+0900 D/PKGMGR  ( 2983): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-01 03:17:40.295+0900 D/PKGMGR  ( 2983): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
04-01 03:17:40.295+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-01 03:17:40.295+0900 W/cluster-home( 2906): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.example]
04-01 03:17:40.295+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-01 03:17:40.295+0900 D/PKGMGR  ( 3052): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-01 03:17:40.295+0900 D/cluster-home( 2906): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29060003] pkg_type[tpk] package[org.example.example] key[install_percent] val[60] pmsg[(null)]
04-01 03:17:40.295+0900 D/PKGMGR  ( 2960): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-01 03:17:40.295+0900 D/PKGMGR  ( 3098): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-01 03:17:40.295+0900 D/DATA_PROVIDER_MASTER( 2960): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.example] 60
04-01 03:17:40.295+0900 D/PKGMGR  ( 2974): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-01 03:17:40.295+0900 D/ESD     ( 2974): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29740002), pkg_type(tpk), pkgid(org.example.example), key(install_percent), val(60)
04-01 03:17:40.295+0900 D/PKGMGR  ( 2976): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
04-01 03:17:40.295+0900 E/PKGMGR_CERT(10846): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-01 03:17:40.295+0900 D/rpm-installer(10846): rpm-installer-privilege.c: _ri_privilege_unregister_package(85) > [smack] app_uninstall(org.example.example), result=[0]
04-01 03:17:40.295+0900 D/rpm-installer(10846): rpm-installer-privilege.c: _ri_privilege_register_package(65) > [smack] app_install(org.example.example), result=[0]
04-01 03:17:40.295+0900 D/rpm-installer(10846): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example, 5, _), result=[0]
04-01 03:17:40.295+0900 D/rpm-installer(10846): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/shared, 5, _), result=[0]
04-01 03:17:40.295+0900 D/rpm-installer(10846): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/shared/res, 5, _), result=[0]
04-01 03:17:40.295+0900 D/rpm-installer(10846): rpm-installer-privilege.c: _ri_privilege_setup_path(117) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/shared/data, 2), result=[0]
04-01 03:17:40.295+0900 D/rpm-installer(10846): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1101) > [smack] get_smack_label, path=[/opt/usr/apps/org.example.example/shared/data], label=[$1$org.exam$u8BwfYMV9u%MYLLw2JGhj1]
04-01 03:17:40.295+0900 D/rpm-installer(10846): coretpk-installer.c: _coretpk_installer_set_smack_label_access(1088) > [smack] set_smack_label, path=[/opt/usr/apps/org.example.example/shared/cache], label=[$1$org.exam$u8BwfYMV9u%MYLLw2JGhj1]
04-01 03:17:40.295+0900 E/rpm-installer(10846): installer-util.c: _installer_util_get_configuration_value(418) > [signature]=[on]
04-01 03:17:40.295+0900 D/rpm-installer(10846): coretpk-installer.c: _coretpk_installer_get_group_id(2472) > encoding done, len=[28]
04-01 03:17:40.295+0900 D/rpm-installer(10846): coretpk-installer.c: _coretpk_installer_apply_smack(2575) > groupid = [lRCBhlfBM8hN+lAnIV9z4vodWRE=] for shared/trusted.
04-01 03:17:40.295+0900 D/rpm-installer(10846): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/shared/trusted, 1, lRCBhlfBM8hN+lAnIV9z4vodWRE=), result=[0]
04-01 03:17:40.295+0900 D/rpm-installer(10846): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/bin, 0, org.example.example), result=[0]
04-01 03:17:40.295+0900 D/rpm-installer(10846): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/data, 0, org.example.example), result=[0]
04-01 03:17:40.295+0900 D/rpm-installer(10846): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/lib, 0, org.example.example), result=[0]
04-01 03:17:40.295+0900 D/rpm-installer(10846): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/res, 0, org.example.example), result=[0]
04-01 03:17:40.295+0900 D/rpm-installer(10846): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/cache, 0, org.example.example), result=[0]
04-01 03:17:40.295+0900 D/rpm-installer(10846): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/tizen-manifest.xml, 0, org.example.example), result=[0]
04-01 03:17:40.295+0900 D/rpm-installer(10846): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/author-signature.xml, 0, org.example.example), result=[0]
04-01 03:17:40.315+0900 D/rpm-installer(10846): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/signature1.xml, 0, org.example.example), result=[0]
04-01 03:17:40.315+0900 D/rpm-installer(10846): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/share/packages/org.example.example.xml, 0, org.example.example), result=[0]
04-01 03:17:40.315+0900 D/rpm-installer(10846): rpm-installer-privilege.c: _ri_privilege_set_package_version(75) > [smack] app[org.example.example] version set to [2.4] result=[0]
04-01 03:17:40.315+0900 D/rpm-installer(10846): rpm-installer.c: _ri_apply_privilege(1924) > api-version[2.4] fot privilege has done successfully.
04-01 03:17:40.315+0900 D/rpm-installer(10846): rpm-installer-privilege.c: _ri_privilege_enable_permissions(106) > [smack] app_enable_permissions(org.example.example, 7), result=[0]
04-01 03:17:40.315+0900 D/rpm-installer(10846): coretpk-installer.c: _coretpk_installer_package_reinstall(5083) > #permission applying success.
04-01 03:17:40.315+0900 D/PKGMGR  (10846): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(10846), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
04-01 03:17:40.315+0900 D/PKGMGR  (10846): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(10846), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
04-01 03:17:40.315+0900 D/PKGMGR  (10846): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
04-01 03:17:40.315+0900 D/PKGMGR_INSTALLER(10846): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.example] key[install_percent] value[100]
04-01 03:17:40.315+0900 D/PKGMGR  (10846): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(10846), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
04-01 03:17:40.315+0900 D/PKGMGR  ( 2968): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 03:17:40.315+0900 D/PKGMGR  (10846): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(10846), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
04-01 03:17:40.315+0900 D/PKGMGR  (10846): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.install.progress), signal_name(install_progress)
04-01 03:17:40.315+0900 D/QUICKPANEL( 2968): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:install_percent val:100
04-01 03:17:40.315+0900 D/PKGMGR  (10844): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 03:17:40.315+0900 D/rpm-installer(10846): coretpk-installer.c: _coretpk_installer_package_reinstall(5096) > _coretpk_installer_package_reinstall(org.example.example) is done.
04-01 03:17:40.315+0900 D/PKGMGR  (10846): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(10846), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
04-01 03:17:40.315+0900 D/PKGMGR  (10846): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(10846), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
04-01 03:17:40.315+0900 D/PKGMGR  (10846): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
04-01 03:17:40.315+0900 D/PKGMGR  ( 2983): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 03:17:40.315+0900 D/PKGMGR  ( 2983): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
04-01 03:17:40.315+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 03:17:40.315+0900 W/cluster-home( 2906): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.example]
04-01 03:17:40.315+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 03:17:40.315+0900 D/cluster-home( 2906): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29060003] pkg_type[tpk] package[org.example.example] key[install_percent] val[100] pmsg[(null)]
04-01 03:17:40.315+0900 D/PKGMGR  ( 3052): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 03:17:40.315+0900 D/PKGMGR  ( 2960): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 03:17:40.315+0900 D/DATA_PROVIDER_MASTER( 2960): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.example] 100
04-01 03:17:40.315+0900 D/PKGMGR  ( 2976): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 03:17:40.315+0900 D/PKGMGR  ( 2974): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 03:17:40.315+0900 D/ESD     ( 2974): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29740002), pkg_type(tpk), pkgid(org.example.example), key(install_percent), val(100)
04-01 03:17:40.315+0900 D/PKGMGR  ( 3098): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
04-01 03:17:40.315+0900 D/PKGMGR  (10844): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 03:17:40.315+0900 D/PKGMGR_INSTALLER(10846): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.example] key[end] value[ok]
04-01 03:17:40.315+0900 D/PKGMGR  (10846): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(10846), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
04-01 03:17:40.315+0900 D/PKGMGR  (10846): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(10846), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
04-01 03:17:40.315+0900 D/PKGMGR  (10846): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.upgrade), signal_name(upgrade)
04-01 03:17:40.315+0900 D/PKGMGR  ( 3052): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 03:17:40.315+0900 D/ISF_PANEL_EFL( 3052): isf_panel_efl.cpp: _package_manager_event_cb(1288) > type=tpk package=org.example.example event_type=UPDATE event_state=COMPLETED progress=100 error=0
04-01 03:17:40.315+0900 D/PKGMGR  ( 2763): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[upgrade], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 03:17:40.315+0900 D/AUL_AMD ( 2763): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.example), key(end), value(ok)
04-01 03:17:40.315+0900 W/AUL_AMD ( 2763): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(update), value(ok)
04-01 03:17:40.315+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 03:17:40.315+0900 W/cluster-home( 2906): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[2], package[org.example.example]
04-01 03:17:40.315+0900 D/cluster-home( 2906): widget-data-provider.cpp: PackageUpdated(2160) >  No boxes that pkgname is[org.example.example]
04-01 03:17:40.315+0900 D/PKGMGR  ( 2906): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 03:17:40.315+0900 D/cluster-home( 2906): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29060003] pkg_type[tpk] package[org.example.example] key[end] val[ok] pmsg[(null)]
04-01 03:17:40.315+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
04-01 03:17:40.315+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
04-01 03:17:40.315+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
04-01 03:17:40.315+0900 W/ISF_PANEL_EFL( 3052): isf_panel_efl.cpp: _package_manager_event_cb(1380) > isf_db_select_appids_by_pkgid returned 0.
04-01 03:17:40.315+0900 D/AUL_AMD ( 2763): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.example, type:rpm
04-01 03:17:40.315+0900 D/PKGMGR  ( 2983): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 03:17:40.315+0900 D/PKGMGR  ( 2983): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
04-01 03:17:40.315+0900 D/PKGMGR  ( 2974): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 03:17:40.315+0900 D/ESD     ( 2974): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29740002), pkg_type(tpk), pkgid(org.example.example), key(end), val(ok)
04-01 03:17:40.315+0900 D/ESD     ( 2974): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
04-01 03:17:40.315+0900 D/PKGMGR  ( 3098): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 03:17:40.315+0900 D/cluster-home( 2906): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
04-01 03:17:40.315+0900 D/cluster-home( 2906): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.example]
04-01 03:17:40.315+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.example]
04-01 03:17:40.315+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.example]
04-01 03:17:40.315+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
04-01 03:17:40.315+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
04-01 03:17:40.315+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.example]
04-01 03:17:40.315+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.example] Name[example] Icon[/opt/usr/apps/org.example.example/shared/res/example.png] enable[1] system[0]
04-01 03:17:40.315+0900 D/cluster-home( 2906): mainmenu-presenter.cpp: OnAppUpdated(337) >  pAppId [org.example.example]
04-01 03:17:40.315+0900 D/cluster-home( 2906): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.example
04-01 03:17:40.315+0900 D/cluster-home( 2906): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[14], isFolder[0], pageId[1], col[2], row[4], appId[org.example.example], name[example], menuId[1], isPreload[0] isPreload[0]
04-01 03:17:40.315+0900 D/cluster-home( 2906): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
04-01 03:17:40.315+0900 E/cluster-home( 2906): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.example] Name[example] Icon[/opt/usr/apps/org.example.example/shared/res/example.png] enable[1] system[0]
04-01 03:17:40.315+0900 D/cluster-home( 2906): mainmenu-presenter.cpp: OnAppUpdated(364) >  name [example]
04-01 03:17:40.315+0900 D/cluster-home( 2906): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
04-01 03:17:40.325+0900 D/cluster-home( 2906): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
04-01 03:17:40.325+0900 D/test-log( 2906): mainmenu-box-impl.cpp: UpdateBoxData(812) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.example/shared/res/example.png], New icon path[/opt/usr/apps/org.example.example/shared/res/example.png]!!!!!
04-01 03:17:40.325+0900 D/PKGMGR  ( 2968): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 03:17:40.325+0900 D/QUICKPANEL( 2968): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:end val:ok
04-01 03:17:40.325+0900 D/cluster-home( 2906): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 1, appId = $appId, name = $name, col = 2, row = 4, isPreload = 0, isSystem = 0 WHERE boxId = 14]
04-01 03:17:40.325+0900 D/PKGMGR  ( 2960): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 03:17:40.325+0900 D/DATA_PROVIDER_MASTER( 2960): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.example] ok
04-01 03:17:40.325+0900 D/DATA_PROVIDER_MASTER( 2960): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.example], event_type[1]
04-01 03:17:40.325+0900 D/DATA_PROVIDER_MASTER( 2960): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
04-01 03:17:40.325+0900 D/DATA_PROVIDER_MASTER( 2960): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
04-01 03:17:40.325+0900 D/DATA_PROVIDER_MASTER( 2960): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
04-01 03:17:40.325+0900 D/DATA_PROVIDER_MASTER( 2960): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.example]
04-01 03:17:40.325+0900 D/PKGMGR  ( 2976): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-751677310], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
04-01 03:17:40.395+0900 D/rpm-installer(10846): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
04-01 03:17:40.395+0900 D/rpm-installer(10846): rpm-appcore-intf.c: main(259) > ------------------------------------------------
04-01 03:17:40.395+0900 D/rpm-installer(10846): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
04-01 03:17:40.395+0900 D/rpm-installer(10846): rpm-appcore-intf.c: main(261) > ------------------------------------------------
04-01 03:17:40.415+0900 D/PKGMGR_SERVER(10757): pkgmgr-server.c: sighandler(387) > child exit [10846]
04-01 03:17:40.415+0900 E/PKGMGR_SERVER(10757): pkgmgr-server.c: sighandler(402) > child NORMAL exit [10846]
04-01 03:17:40.565+0900 D/WIDGET_PROVIDER( 2963): widget_provider.c: widget_provider_send_ping(1671) > [SECURE_LOG] name[0_38.711975]
04-01 03:17:40.585+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(838) > __request_handler: 0
04-01 03:17:40.585+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
04-01 03:17:40.585+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
04-01 03:17:40.585+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
04-01 03:17:40.585+0900 I/AUL     ( 2763): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
04-01 03:17:40.585+0900 D/AUL     ( 2763): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 10896, pid = 10898
04-01 03:17:40.585+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
04-01 03:17:40.585+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
04-01 03:17:40.585+0900 I/AUL     ( 2763): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
04-01 03:17:40.585+0900 E/AUL_AMD ( 2763): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
04-01 03:17:40.585+0900 W/AUL_AMD ( 2763): amd_launch.c: _start_app(2233) > caller pid : 10898
04-01 03:17:40.585+0900 E/AUL_AMD ( 2763): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
04-01 03:17:40.585+0900 W/AUL_AMD ( 2763): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
04-01 03:17:40.585+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2648) > process_pool: false
04-01 03:17:40.585+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
04-01 03:17:40.585+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
04-01 03:17:40.585+0900 W/AUL_AMD ( 2763): amd_launch.c: _start_app(2665) > pad pid(-5)
04-01 03:17:40.585+0900 D/AUL_AMD ( 2763): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
04-01 03:17:40.585+0900 D/AUL_AMD ( 2763): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
04-01 03:17:40.585+0900 D/AUL     ( 2763): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
04-01 03:17:40.585+0900 D/AUL_PAD ( 2958): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
04-01 03:17:40.585+0900 D/AUL_PAD ( 2958): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
04-01 03:17:40.585+0900 D/AUL_PAD ( 2958): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
04-01 03:17:40.585+0900 D/AUL_PAD ( 2958): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
04-01 03:17:40.585+0900 D/AUL_PAD ( 2958): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
04-01 03:17:40.585+0900 D/AUL_PAD ( 2958): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
04-01 03:17:40.585+0900 D/AUL_PAD ( 2958): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
04-01 03:17:40.585+0900 D/AUL_PAD ( 2958): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
04-01 03:17:40.585+0900 D/AUL_PAD ( 2958): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
04-01 03:17:40.585+0900 D/AUL_PAD ( 2958): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
04-01 03:17:40.585+0900 D/AUL_PAD ( 2958): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
04-01 03:17:40.585+0900 D/AUL_PAD ( 2958): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
04-01 03:17:40.585+0900 D/AUL_PAD ( 2958): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
04-01 03:17:40.585+0900 D/AUL_PAD ( 2958): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
04-01 03:17:40.585+0900 W/AUL_PAD ( 2958): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
04-01 03:17:40.585+0900 D/AUL     ( 2958): process_pool.c: __send_pkt_raw_data(219) > send(13) : 624 / 624
04-01 03:17:40.585+0900 D/AUL_PAD ( 2958): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 10663, bin path: /opt/usr/apps/org.example.example/bin/example
04-01 03:17:40.585+0900 W/AUL_PAD ( 2958): launchpad.c: __send_result_to_caller(265) > Check app launching
04-01 03:17:40.585+0900 D/AUL_PAD ( 2958): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
04-01 03:17:40.585+0900 D/AUL_PAD (10663): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
04-01 03:17:40.585+0900 D/AUL_PAD (10663): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
04-01 03:17:40.585+0900 D/RESOURCED( 2892): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
04-01 03:17:40.585+0900 D/RESOURCED( 2892): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 2
04-01 03:17:40.585+0900 D/AUL_PAD (10663): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
04-01 03:17:40.585+0900 D/AUL_PAD (10663): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
04-01 03:17:40.585+0900 D/AUL_PAD (10663): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
04-01 03:17:40.585+0900 D/AUL_PAD (10663): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
04-01 03:17:40.585+0900 E/RESOURCED( 2892): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-01 03:17:40.585+0900 D/AUL     (10663): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (10695) is sent.
04-01 03:17:40.585+0900 D/AUL     (10663): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 10695, signo: 10
04-01 03:17:40.595+0900 D/AUL     (10663): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
04-01 03:17:40.595+0900 D/AUL_PAD (10663): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
04-01 03:17:40.595+0900 D/AUL_PAD (10663): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
04-01 03:17:40.595+0900 D/AUL_PAD (10663): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
04-01 03:17:40.595+0900 D/AUL_PAD (10663): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
04-01 03:17:40.595+0900 D/AUL_PAD (10663): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTA5ODQyNjAvNTk3MzEwAA==##
04-01 03:17:40.595+0900 D/AUL_PAD (10663): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
04-01 03:17:40.595+0900 D/AUL_PAD (10663): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAxMDg5OAA=##
04-01 03:17:40.595+0900 D/AUL_PAD (10663): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
04-01 03:17:40.595+0900 D/AUL_PAD (10663): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
04-01 03:17:40.595+0900 D/AUL_PAD (10663): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
04-01 03:17:40.595+0900 D/AUL_PAD (10663): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
04-01 03:17:40.595+0900 D/AUL_PAD (10663): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
04-01 03:17:40.595+0900 I/CAPI_APPFW_APPLICATION(10663): app_main.c: ui_app_main(788) > app_efl_main
04-01 03:17:40.595+0900 D/LAUNCH  (10663): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
04-01 03:17:40.595+0900 D/APP_CORE(10663): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
04-01 03:17:40.595+0900 D/APP_CORE(10663): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
04-01 03:17:40.595+0900 D/APP_CORE(10663): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
04-01 03:17:40.595+0900 D/APP_CORE(10663): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
04-01 03:17:40.595+0900 D/AUL     (10663): app_sock.c: __create_server_sock(156) > pg path - already exists
04-01 03:17:40.595+0900 D/APP_CORE(10663): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb4224520
04-01 03:17:40.595+0900 D/LAUNCH  (10663): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
04-01 03:17:40.595+0900 I/CAPI_APPFW_APPLICATION(10663): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
04-01 03:17:40.695+0900 D/AUL_PAD ( 2958): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
04-01 03:17:40.695+0900 W/AUL     ( 2763): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 10663, appid: org.example.example
04-01 03:17:40.695+0900 D/AUL     ( 2763): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
04-01 03:17:40.695+0900 E/AUL     ( 2763): simple_util.c: __trm_app_info_send_socket(330) > access
04-01 03:17:40.695+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2700) > add app group info
04-01 03:17:40.695+0900 E/AUL     ( 2763): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
04-01 03:17:40.695+0900 D/AUL_AMD ( 2763): amd_status.c: _status_add_app_info_list(427) > pid(10663) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
04-01 03:17:40.695+0900 D/RESOURCED( 2892): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 10663
04-01 03:17:40.695+0900 D/RESOURCED( 2892): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
04-01 03:17:40.695+0900 E/RESOURCED( 2892): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
04-01 03:17:40.695+0900 D/RESOURCED( 2892): proc-main.c: resourced_proc_status_change(888) > available memory = 281
04-01 03:17:40.725+0900 E/EFL     (10663): <10663> lib/edje/edje_smart.c:22 edje_object_add() safety check failed: evas == NULL
04-01 03:17:40.755+0900 W/CRASH_MANAGER(10903): worker.c: worker_job(1204) > 1110663657861149098426
