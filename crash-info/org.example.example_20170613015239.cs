S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 18613
Date: 2017-06-13 01:52:39+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000008, esi = 0xbf8e0540
ebp = 0xbf8e05a8, esp = 0xbf8e053c
eax = 0xb378c1a1, ebx = 0xb378f000
ecx = 0x00000050, edx = 0x00000000
eip = 0xb6d53c0b

Memory Information
MemTotal:      123 KB
MemFree:        17 KB
Buffers:        14 KB
Cached:     168836 KB
VmPeak:     124224 KB
VmSize:     118256 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       37200 KB
VmRSS:       31100 KB
VmData:      48636 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34640 KB
VmPTE:         104 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 18613 TID = 18613
18613 18616 18785 18791 

Maps Information
b0e90000 b0e97000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b0e98000 b0eb0000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0eb1000 b0eb8000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1870000 b1874000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2b49000 b2b53000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b59000 b2b65000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b66000 b2b87000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2b8c000 b2b8d000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2b8e000 b2b93000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2b94000 b2b95000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2b96000 b2b98000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2b99000 b2b9b000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2b9c000 b2ba8000 r-xp /usr/lib/libdrm.so.2.4.0
b2ba9000 b2bac000 r-xp /usr/lib/libdri2.so.0.0.0
b2bad000 b2bb7000 r-xp /usr/lib/libtbm.so.1.0.0
b2bb8000 b2bcd000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2bce000 b2be0000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b33e2000 b3413000 r-xp /usr/lib/libidn.so.11.5.44
b3414000 b3436000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3437000 b3447000 r-xp /usr/lib/libcares.so.2.1.0
b3448000 b3451000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3452000 b345b000 r-xp /usr/lib/libefl-extension.so.0.1.0
b345c000 b34d3000 r-xp /usr/lib/libcurl.so.4.3.0
b34d5000 b34e7000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34e8000 b3509000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b3510000 b3511000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3512000 b3513000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3514000 b3517000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3518000 b351b000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3623000 b3629000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b362a000 b376e000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b377e000 b377f000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b3780000 b378e000 r-xp /opt/usr/apps/org.example.example/bin/example
b3790000 b37c9000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41cc000 b41d7000 r-xp /lib/libnss_files-2.20-2014.11.so
b41d9000 b41e4000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41e6000 b41fd000 r-xp /lib/libnsl-2.20-2014.11.so
b4201000 b4209000 r-xp /lib/libnss_compat-2.20-2014.11.so
b420b000 b422f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4230000 b4231000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4232000 b4235000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4236000 b423d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b423e000 b4248000 r-xp /usr/lib/libsensord-share.so
b4249000 b4265000 r-xp /usr/lib/libsensor.so.1.2.0
b4267000 b4270000 r-xp /usr/lib/libappcore-common.so.1.1
b4273000 b4275000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b428a000 b428c000 r-xp /usr/lib/libXau.so.6.0.0
b428d000 b42af000 r-xp /usr/lib/libxcb.so.1.1.0
b42b1000 b42ba000 r-xp /lib/libcrypt-2.20-2014.11.so
b42e3000 b42e5000 r-xp /usr/lib/libiri.so
b42e6000 b430c000 r-xp /lib/libexpat.so.1.5.2
b430e000 b4379000 r-xp /usr/lib/libssl.so.1.0.0
b437f000 b438b000 r-xp /usr/lib/libethumb.so.1.13.0
b438c000 b4390000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4391000 b45e2000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b5d000 b5b6d000 r-xp /usr/lib/libXi.so.6.1.0
b5b6e000 b5b70000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b71000 b5b77000 r-xp /usr/lib/libXtst.so.6.1.0
b5b78000 b5b82000 r-xp /usr/lib/libXrender.so.1.3.0
b5b83000 b5b8c000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b8e000 b5b90000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b91000 b5b96000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b97000 b5ba9000 r-xp /usr/lib/libXext.so.6.4.0
b5baa000 b5bac000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bad000 b5baf000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bb1000 b5cf3000 r-xp /usr/lib/libX11.so.6.3.0
b5cf7000 b5d01000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d02000 b5d18000 r-xp /usr/lib/libudev.so.1.6.0
b5d1b000 b5d1f000 r-xp /lib/libattr.so.1.1.0
b5d20000 b5d4f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d51000 b5d57000 r-xp /usr/lib/libffi.so.6.0.2
b5d58000 b5d7b000 r-xp /lib/libz.so.1.2.8
b5d7c000 b5d7f000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d80000 b5edc000 r-xp /usr/lib/libxml2.so.2.9.2
b5ee2000 b5fc9000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fd6000 b5fd9000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fda000 b5ffc000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ffd000 b6011000 r-xp /lib/libresolv-2.20-2014.11.so
b6015000 b6039000 r-xp /usr/lib/liblzma.so.5.0.3
b603a000 b603c000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b603e000 b6048000 r-xp /usr/lib/libembryo.so.1.13.0
b6049000 b6072000 r-xp /usr/lib/libpng12.so.0.50.0
b6073000 b60bc000 r-xp /usr/lib/libjpeg.so.8.0.2
b60cd000 b60d4000 r-xp /lib/librt-2.20-2014.11.so
b60d6000 b60f5000 r-xp /usr/lib/libector.so.1.13.0
b60f8000 b6125000 r-xp /usr/lib/liblua-5.1.so
b6126000 b61b6000 r-xp /usr/lib/libfreetype.so.6.11.3
b61ba000 b61f8000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61f9000 b620f000 r-xp /usr/lib/libfribidi.so.0.3.1
b6210000 b6269000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b626c000 b62b7000 r-xp /lib/libm-2.20-2014.11.so
b62b9000 b62cb000 r-xp /usr/lib/libeio.so.1.13.0
b62cc000 b62cf000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62d0000 b62d6000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62d7000 b62fa000 r-xp /usr/lib/libefreet.so.1.13.0
b62fd000 b6328000 r-xp /usr/lib/libeldbus.so.1.13.0
b6329000 b635d000 r-xp /usr/lib/libecore_con.so.1.13.0
b635f000 b6368000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6369000 b6372000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6373000 b6386000 r-xp /usr/lib/libeo.so.1.13.0
b6388000 b639b000 r-xp /usr/lib/libecore_input.so.1.13.0
b639c000 b63a3000 r-xp /usr/lib/libecore_file.so.1.13.0
b63a4000 b63c7000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63c8000 b63f4000 r-xp /usr/lib/libeet.so.1.13.0
b63fd000 b6468000 r-xp /usr/lib/libeina.so.1.13.0
b646b000 b6482000 r-xp /usr/lib/libefl.so.1.13.0
b6484000 b65eb000 r-xp /usr/lib/libicuuc.so.51.1
b65f9000 b6805000 r-xp /usr/lib/libicui18n.so.51.1
b680d000 b685c000 r-xp /usr/lib/libecore_x.so.1.13.0
b685e000 b6878000 r-xp /lib/libgcc_s-4.9.so.1
b687a000 b687e000 r-xp /lib/libcap.so.2.21
b687f000 b68c5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68c6000 b68cd000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68cf000 b6921000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6923000 b6aae000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6ab3000 b6b81000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b84000 b6b88000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b89000 b6b98000 r-xp /usr/lib/libvconf.so.0.2.45
b6b99000 b6b9c000 r-xp /usr/lib/libvasum.so.0.3.1
b6b9d000 b6ba0000 r-xp /usr/lib/libttrace.so.1.1
b6ba2000 b6ba6000 r-xp /usr/lib/libiniparser.so.0
b6ba7000 b6bd7000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bd8000 b6be1000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6be2000 b6c07000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c08000 b6c18000 r-xp /usr/lib/libunwind.so.8.0.1
b6c22000 b6dd0000 r-xp /lib/libc-2.20-2014.11.so
b6dd8000 b6f1b000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f1d000 b6f75000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f76000 b6faa000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fad000 b7081000 r-xp /usr/lib/libedje.so.1.13.0
b7084000 b70b0000 r-xp /usr/lib/libecore.so.1.13.0
b70c1000 b72e7000 r-xp /usr/lib/libevas.so.1.13.0
b730f000 b7327000 r-xp /lib/libpthread-2.20-2014.11.so
b732b000 b76a5000 r-xp /usr/lib/libelementary.so.1.13.0
b76c5000 b76c9000 r-xp /usr/lib/libsmack.so.1.0.0
b76ca000 b76d3000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76d4000 b76d7000 r-xp /usr/lib/libdlog.so.0.0.0
b76d8000 b76dd000 r-xp /usr/lib/libbundle.so.0.1.22
b76de000 b76e1000 r-xp /lib/libdl-2.20-2014.11.so
b76e3000 b7708000 r-xp /usr/lib/libaul.so.0.1.0
b770b000 b770d000 r-xp /usr/lib/libappsvc.so.0.1.0
b770e000 b7713000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7714000 b771b000 r-xp /usr/lib/libappcore-efl.so.1.1
b771d000 b7722000 r-xp /usr/lib/libsys-assert.so
b7725000 b7726000 r-xp [vdso]
b7726000 b7748000 r-xp /lib/ld-2.20-2014.11.so
b774a000 b7752000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:18613)
Call Stack Count: 97
 0: (0xb6d53c0b) [/lib/libc.so.6] + 0x131c0b
 1: gl_del_cb + 0xa8 (0xb37866c8) [/opt/usr/apps/org.example.example/bin/example] + 0x66c8
 2: (0xb74871f9) [/usr/lib/libelementary.so.1] + 0x15c1f9
 3: elm_genlist_clear + 0x9b (0xb748742b) [/usr/lib/libelementary.so.1] + 0x15c42b
 4: (0xb7487669) [/usr/lib/libelementary.so.1] + 0x15c669
 5: evas_obj_smart_del + 0x99 (0xb714beb9) [/usr/lib/libevas.so.1] + 0x8aeb9
 6: (0xb714d6f1) [/usr/lib/libevas.so.1] + 0x8c6f1
 7: (0xb714075b) [/usr/lib/libevas.so.1] + 0x7f75b
 8: eo_destructor + 0x99 (0xb637e079) [/usr/lib/libeo.so.1] + 0xb079
 9: (0xb759c38b) [/usr/lib/libelementary.so.1] + 0x27138b
10: eo_destructor + 0x99 (0xb637e079) [/usr/lib/libeo.so.1] + 0xb079
11: _eo_do_end + 0x15b (0xb63765ab) [/usr/lib/libeo.so.1] + 0x35ab
12: eo_del + 0xb3 (0xb637b7a3) [/usr/lib/libeo.so.1] + 0x87a3
13: evas_object_del + 0x81 (0xb7135cc1) [/usr/lib/libevas.so.1] + 0x74cc1
14: (0xb75aa245) [/usr/lib/libelementary.so.1] + 0x27f245
15: evas_obj_smart_del + 0x99 (0xb714beb9) [/usr/lib/libevas.so.1] + 0x8aeb9
16: (0xb7499bf9) [/usr/lib/libelementary.so.1] + 0x16ebf9
17: evas_obj_smart_del + 0x99 (0xb714beb9) [/usr/lib/libevas.so.1] + 0x8aeb9
18: (0xb714d6f1) [/usr/lib/libevas.so.1] + 0x8c6f1
19: (0xb714075b) [/usr/lib/libevas.so.1] + 0x7f75b
20: eo_destructor + 0x99 (0xb637e079) [/usr/lib/libeo.so.1] + 0xb079
21: (0xb759c38b) [/usr/lib/libelementary.so.1] + 0x27138b
22: eo_destructor + 0x99 (0xb637e079) [/usr/lib/libeo.so.1] + 0xb079
23: _eo_do_end + 0x15b (0xb63765ab) [/usr/lib/libeo.so.1] + 0x35ab
24: eo_del + 0xb3 (0xb637b7a3) [/usr/lib/libeo.so.1] + 0x87a3
25: evas_object_del + 0x81 (0xb7135cc1) [/usr/lib/libevas.so.1] + 0x74cc1
26: (0xb75aa245) [/usr/lib/libelementary.so.1] + 0x27f245
27: evas_obj_smart_del + 0x99 (0xb714beb9) [/usr/lib/libevas.so.1] + 0x8aeb9
28: (0xb74df706) [/usr/lib/libelementary.so.1] + 0x1b4706
29: evas_obj_smart_del + 0x99 (0xb714beb9) [/usr/lib/libevas.so.1] + 0x8aeb9
30: (0xb74cf53f) [/usr/lib/libelementary.so.1] + 0x1a453f
31: evas_obj_smart_del + 0x99 (0xb714beb9) [/usr/lib/libevas.so.1] + 0x8aeb9
32: (0xb714d6f1) [/usr/lib/libevas.so.1] + 0x8c6f1
33: (0xb714075b) [/usr/lib/libevas.so.1] + 0x7f75b
34: eo_destructor + 0x99 (0xb637e079) [/usr/lib/libeo.so.1] + 0xb079
35: (0xb759c38b) [/usr/lib/libelementary.so.1] + 0x27138b
36: eo_destructor + 0x99 (0xb637e079) [/usr/lib/libeo.so.1] + 0xb079
37: _eo_do_end + 0x15b (0xb63765ab) [/usr/lib/libeo.so.1] + 0x35ab
38: eo_del + 0xb3 (0xb637b7a3) [/usr/lib/libeo.so.1] + 0x87a3
39: evas_object_del + 0x81 (0xb7135cc1) [/usr/lib/libevas.so.1] + 0x74cc1
40: (0xb75aa245) [/usr/lib/libelementary.so.1] + 0x27f245
41: evas_obj_smart_del + 0x99 (0xb714beb9) [/usr/lib/libevas.so.1] + 0x8aeb9
42: (0xb74df706) [/usr/lib/libelementary.so.1] + 0x1b4706
43: evas_obj_smart_del + 0x99 (0xb714beb9) [/usr/lib/libevas.so.1] + 0x8aeb9
44: (0xb714d6f1) [/usr/lib/libevas.so.1] + 0x8c6f1
45: (0xb714075b) [/usr/lib/libevas.so.1] + 0x7f75b
46: eo_destructor + 0x99 (0xb637e079) [/usr/lib/libeo.so.1] + 0xb079
47: (0xb759c38b) [/usr/lib/libelementary.so.1] + 0x27138b
48: eo_destructor + 0x99 (0xb637e079) [/usr/lib/libeo.so.1] + 0xb079
49: _eo_do_end + 0x15b (0xb63765ab) [/usr/lib/libeo.so.1] + 0x35ab
50: eo_del + 0xb3 (0xb637b7a3) [/usr/lib/libeo.so.1] + 0x87a3
51: evas_object_del + 0x81 (0xb7135cc1) [/usr/lib/libevas.so.1] + 0x74cc1
52: (0xb75999d1) [/usr/lib/libelementary.so.1] + 0x26e9d1
53: eo_destructor + 0x99 (0xb637e079) [/usr/lib/libeo.so.1] + 0xb079
54: (0xb73cb6af) [/usr/lib/libelementary.so.1] + 0xa06af
55: eo_destructor + 0x99 (0xb637e079) [/usr/lib/libeo.so.1] + 0xb079
56: _eo_do_end + 0x15b (0xb63765ab) [/usr/lib/libeo.so.1] + 0x35ab
57: (0xb73cab61) [/usr/lib/libelementary.so.1] + 0x9fb61
58: evas_obj_smart_del + 0x99 (0xb714beb9) [/usr/lib/libevas.so.1] + 0x8aeb9
59: (0xb714d6f1) [/usr/lib/libevas.so.1] + 0x8c6f1
60: (0xb714075b) [/usr/lib/libevas.so.1] + 0x7f75b
61: eo_destructor + 0x99 (0xb637e079) [/usr/lib/libeo.so.1] + 0xb079
62: (0xb759c38b) [/usr/lib/libelementary.so.1] + 0x27138b
63: eo_destructor + 0x99 (0xb637e079) [/usr/lib/libeo.so.1] + 0xb079
64: _eo_do_end + 0x15b (0xb63765ab) [/usr/lib/libeo.so.1] + 0x35ab
65: eo_del + 0xb3 (0xb637b7a3) [/usr/lib/libeo.so.1] + 0x87a3
66: evas_object_del + 0x81 (0xb7135cc1) [/usr/lib/libevas.so.1] + 0x74cc1
67: (0xb75aa245) [/usr/lib/libelementary.so.1] + 0x27f245
68: evas_obj_smart_del + 0x99 (0xb714beb9) [/usr/lib/libevas.so.1] + 0x8aeb9
69: (0xb74df706) [/usr/lib/libelementary.so.1] + 0x1b4706
70: evas_obj_smart_del + 0x99 (0xb714beb9) [/usr/lib/libevas.so.1] + 0x8aeb9
71: (0xb7425425) [/usr/lib/libelementary.so.1] + 0xfa425
72: evas_obj_smart_del + 0x99 (0xb714beb9) [/usr/lib/libevas.so.1] + 0x8aeb9
73: (0xb714d6f1) [/usr/lib/libevas.so.1] + 0x8c6f1
74: (0xb714075b) [/usr/lib/libevas.so.1] + 0x7f75b
75: eo_destructor + 0x99 (0xb637e079) [/usr/lib/libeo.so.1] + 0xb079
76: (0xb759c38b) [/usr/lib/libelementary.so.1] + 0x27138b
77: eo_destructor + 0x99 (0xb637e079) [/usr/lib/libeo.so.1] + 0xb079
78: _eo_do_end + 0x15b (0xb63765ab) [/usr/lib/libeo.so.1] + 0x35ab
79: eo_del + 0xb3 (0xb637b7a3) [/usr/lib/libeo.so.1] + 0x87a3
80: evas_object_del + 0x81 (0xb7135cc1) [/usr/lib/libevas.so.1] + 0x74cc1
81: (0xb714d087) [/usr/lib/libevas.so.1] + 0x8c087
82: (0xb714febb) [/usr/lib/libevas.so.1] + 0x8eebb
83: evas_obj_smart_del + 0x99 (0xb714beb9) [/usr/lib/libevas.so.1] + 0x8aeb9
84: (0xb7157f8c) [/usr/lib/libevas.so.1] + 0x96f8c
85: evas_obj_smart_del + 0x99 (0xb714beb9) [/usr/lib/libevas.so.1] + 0x8aeb9
86: (0xb714d6f1) [/usr/lib/libevas.so.1] + 0x8c6f1
87: (0xb714075b) [/usr/lib/libevas.so.1] + 0x7f75b
88: eo_destructor + 0x99 (0xb637e079) [/usr/lib/libeo.so.1] + 0xb079
89: _eo_do_end + 0x15b (0xb63765ab) [/usr/lib/libeo.so.1] + 0x35ab
90: eo_del + 0xb3 (0xb637b7a3) [/usr/lib/libeo.so.1] + 0x87a3
91: evas_object_del + 0x81 (0xb7135cc1) [/usr/lib/libevas.so.1] + 0x74cc1
92: (0xb75bbf44) [/usr/lib/libelementary.so.1] + 0x290f44
93: evas_obj_smart_del + 0x99 (0xb714beb9) [/usr/lib/libevas.so.1] + 0x8aeb9
94: (0xb714d6f1) [/usr/lib/libevas.so.1] + 0x8c6f1
95: (0xb714075b) [/usr/lib/libevas.so.1] + 0x7f75b
96: eo_destructor + 0x99 (0xb637e079) [/usr/lib/libeo.so.1] + 0xb079
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
   ( 2740): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 18613, appid: org.example.example, status: fg
06-13 01:51:04.252+0900 D/RESOURCED( 2846): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 18613
06-13 01:51:04.252+0900 D/RESOURCED( 2846): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 18613, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-13 01:51:04.252+0900 D/RESOURCED( 2846): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 18613
06-13 01:51:04.322+0900 D/RESOURCED( 2846): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 18613, appname = org.example.example, pkgname = org.example.example
06-13 01:51:04.322+0900 D/RESOURCED( 2846): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 18613, appname = org.example.example
06-13 01:51:04.322+0900 D/RESOURCED( 2846): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 18613
06-13 01:51:04.322+0900 I/RESOURCED( 2846): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-13 01:51:04.322+0900 I/RESOURCED( 2846): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-13 01:51:04.322+0900 D/AUL_AMD ( 2740): amd_launch.c: __e17_status_handler(2910) > pid(18613) status(0)
06-13 01:51:04.792+0900 D/AUL_AMD ( 2740): amd_status.c: __app_terminate_timer_cb(442) > pid(18449)
06-13 01:51:04.792+0900 W/AUL_AMD ( 2740): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
06-13 01:51:04.792+0900 D/AUL_AMD ( 2740): amd_status.c: __app_terminate_timer_cb(442) > pid(18449)
06-13 01:51:04.792+0900 W/AUL_AMD ( 2740): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
06-13 01:51:04.822+0900 D/AUL_PAD ( 2914): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-13 01:51:04.822+0900 D/AUL_PAD (18787): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-13 01:51:04.832+0900 D/AUL_PAD ( 2914): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-13 01:51:05.002+0900 E/PKGMGR_SERVER(18711): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 01:51:05.002+0900 E/PKGMGR_SERVER(18711): pkgmgr-server.c: main(2265) > package manager server terminated.
06-13 01:51:05.322+0900 D/AUL_AMD ( 2740): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-13 01:51:05.322+0900 D/RUA     ( 2740): rua.c: rua_add_history(179) > rua_add_history start
06-13 01:51:05.332+0900 D/RUA     ( 2740): rua.c: rua_add_history(247) > rua_add_history ok
06-13 01:51:05.532+0900 I/user_tag0(18613): /opt/usr/apps/org.example.example/data/feeding.db
06-13 01:51:05.542+0900 I/tag     (18613): eonji~
06-13 01:51:05.562+0900 D/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x605a47 
06-13 01:51:05.872+0900 D/AUL_PAD (18787): launchpad_loader.c: main(588) > sleeping 1 sec...
06-13 01:51:05.872+0900 D/AUL_PAD (18787): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-13 01:51:05.872+0900 D/AUL_PAD (18787): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b8197760
06-13 01:51:05.872+0900 D/AUL_PAD (18787): preload.h: __preload_init(69) > get pre-initialization function
06-13 01:51:05.872+0900 D/AUL_PAD (18787): preload.h: __preload_init(73) > get shutdown function
06-13 01:51:05.882+0900 D/AUL_PAD (18787): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b8197a40
06-13 01:51:05.892+0900 D/AUL_PAD (18787): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b8199640
06-13 01:51:05.892+0900 D/AUL_PAD (18787): preload.h: __preload_init(69) > get pre-initialization function
06-13 01:51:05.892+0900 D/AUL_PAD (18787): preload.h: __preload_init(73) > get shutdown function
06-13 01:51:05.892+0900 D/AUL_PAD (18787): preexec.h: __preexec_init(76) > preexec start
06-13 01:51:05.892+0900 D/AUL_PAD (18787): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-13 01:51:05.892+0900 D/AUL     (18787): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-13 01:51:05.892+0900 D/AUL     (18787): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-13 01:51:05.892+0900 D/AUL     (18787): process_pool.c: __connect_to_launchpad(132) > send(18787) : 4
06-13 01:51:05.892+0900 D/AUL     (18787): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-13 01:51:05.892+0900 D/AUL_PAD ( 2914): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-13 01:51:05.892+0900 D/AUL_PAD ( 2914): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-13 01:51:05.892+0900 D/AUL_PAD ( 2914): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-13 01:51:05.892+0900 D/AUL_PAD ( 2914): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-13 01:51:05.892+0900 D/AUL_PAD ( 2914): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-13 01:51:05.892+0900 D/AUL_PAD ( 2914): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-13 01:51:05.892+0900 D/AUL_PAD ( 2914): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-13 01:51:05.892+0900 D/AUL_PAD ( 2914): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-13 01:51:05.892+0900 D/AUL_PAD ( 2914): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 18787
06-13 01:51:05.962+0900 D/AUL_PAD (18787): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-13 01:51:05.972+0900 D/AUL_PAD (18787): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-13 01:51:05.972+0900 D/AUL_PAD (18787): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-13 01:51:05.972+0900 D/AUL_PAD (18787): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-13 01:51:06.432+0900 D/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x605a47 
06-13 01:51:06.522+0900 E/EFL     (18613): edje<18613> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 01:51:06.532+0900 E/EFL     (18613): edje<18613> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 01:51:06.572+0900 E/EFL     (18613): edje<18613> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 01:51:06.572+0900 E/EFL     (18613): edje<18613> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 01:51:06.572+0900 E/EFL     (18613): edje<18613> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 01:51:06.572+0900 E/EFL     (18613): edje<18613> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 01:51:06.582+0900 E/EFL     (18613): edje<18613> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 01:51:06.582+0900 E/EFL     (18613): edje<18613> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 01:51:06.582+0900 E/EFL     (18613): edje<18613> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 01:51:06.582+0900 D/IMMODULE(18613): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
06-13 01:51:06.582+0900 D/ISF_SOCKET(18613): scim_socket.cpp: connect(515) > ppid:2914  trying connect() to local:/tmp/scim-socket-frontend, example
06-13 01:51:06.582+0900 D/ISF_SOCKET(18613): scim_socket.cpp: connect(524) > connect() succeeded
06-13 01:51:06.592+0900 D/ISF_SOCKET(18613): scim_socket.cpp: connect(515) > ppid:2914  trying connect() to local:/tmp/scim-socket-frontend, example
06-13 01:51:06.592+0900 D/ISF_SOCKET(18613): scim_socket.cpp: connect(524) > connect() succeeded
06-13 01:51:06.592+0900 D/ISF_SOCKET(18613): scim_socket.cpp: connect(515) > ppid:2914  trying connect() to local:/tmp/scim-socket-frontend, example
06-13 01:51:06.602+0900 D/ISF_SOCKET(18613): scim_socket.cpp: connect(524) > connect() succeeded
06-13 01:51:06.602+0900 D/ISF_QUERY(18613): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
06-13 01:51:06.602+0900 D/ISF_QUERY(18613): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-13 01:51:06.602+0900 D/ISF_QUERY(18613): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-13 01:51:06.602+0900 D/ISF_QUERY(18613): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-13 01:51:06.602+0900 D/ISF_QUERY(18613): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-13 01:51:06.602+0900 D/ISF_QUERY(18613): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-13 01:51:06.602+0900 D/ISF_QUERY(18613): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-13 01:51:06.602+0900 D/ISF_SOCKET(18613): scim_socket.cpp: connect(515) > ppid:2914  trying connect() to local:/tmp/scim-socket-frontend, example
06-13 01:51:06.602+0900 D/ISF_SOCKET(18613): scim_socket.cpp: connect(524) > connect() succeeded
06-13 01:51:06.602+0900 D/IMMODULE(18613): scim_panel_client.cpp: open_connection(162) > 
06-13 01:51:06.602+0900 D/ISF_SOCKET(18613): scim_socket.cpp: connect(515) > ppid:2914  trying connect() to local:/tmp/scim-panel-socket:0, example
06-13 01:51:06.602+0900 D/ISF_SOCKET(18613): scim_socket.cpp: connect(524) > connect() succeeded
06-13 01:51:06.602+0900 D/ISF_SOCKET(18613): scim_socket.cpp: connect(515) > ppid:2914  trying connect() to local:/tmp/scim-panel-socket:0, example
06-13 01:51:06.602+0900 D/ISF_SOCKET(18613): scim_socket.cpp: connect(524) > connect() succeeded
06-13 01:51:06.602+0900 D/IMMODULE(18613): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 1
06-13 01:51:07.162+0900 D/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x605a47 
06-13 01:51:07.322+0900 I/tag     (18613): insert
06-13 01:51:07.332+0900 E/EFL     (18613): edje<18613> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 01:51:07.332+0900 E/EFL     (18613): edje<18613> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 01:51:07.332+0900 E/EFL     (18613): edje<18613> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 01:51:07.332+0900 E/EFL     (18613): edje<18613> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 01:51:07.332+0900 E/EFL     (18613): edje<18613> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 01:51:07.342+0900 I/get     (18613): 51
06-13 01:51:07.342+0900 I/get     (18613): 51
06-13 01:51:07.342+0900 I/get     (18613): 51
06-13 01:51:07.342+0900 I/get     (18613): 51
06-13 01:51:07.352+0900 I/get     (18613): 51
06-13 01:51:07.352+0900 I/get     (18613): 51
06-13 01:51:07.352+0900 I/get     (18613): 51
06-13 01:51:07.352+0900 I/get     (18613): 51
06-13 01:51:08.082+0900 E/CAPI_NETWORK_WIFI( 2850): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 01:51:08.082+0900 E/INDICATOR( 2850): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 01:51:08.082+0900 E/INDICATOR( 2850): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 01:51:08.082+0900 E/INDICATOR( 2850): 
06-13 01:51:08.162+0900 D/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2a00002
06-13 01:51:08.542+0900 D/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x605a47 
06-13 01:51:08.702+0900 E/EFL     (18613): edje<18613> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 01:51:08.702+0900 E/EFL     (18613): edje<18613> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 01:51:08.742+0900 E/EFL     (18613): edje<18613> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 01:51:08.752+0900 E/EFL     (18613): edje<18613> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 01:51:08.752+0900 E/EFL     (18613): edje<18613> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 01:51:08.752+0900 E/EFL     (18613): edje<18613> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 01:51:08.752+0900 E/EFL     (18613): edje<18613> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 01:51:08.752+0900 E/EFL     (18613): edje<18613> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 01:51:08.762+0900 E/EFL     (18613): edje<18613> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 01:51:09.232+0900 D/APP_CORE( 2866): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
06-13 01:51:09.232+0900 I/APP_CORE( 2866): appcore-efl.c: __do_app(496) > [APP 2866] Event: MEM_FLUSH State: PAUSED
06-13 01:51:09.232+0900 D/APP_CORE( 2866): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
06-13 01:51:09.232+0900 D/APP_CORE( 2866): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2866
06-13 01:51:09.232+0900 D/APP_CORE( 2866): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
06-13 01:51:09.232+0900 D/RESOURCED( 2846): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2866
06-13 01:51:09.452+0900 D/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x605a47 
06-13 01:51:10.042+0900 D/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x605a47 
06-13 01:51:10.362+0900 I/tag     (18613): insert
06-13 01:51:10.372+0900 E/EFL     (18613): edje<18613> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 01:51:10.372+0900 E/EFL     (18613): edje<18613> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 01:51:10.372+0900 E/EFL     (18613): edje<18613> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 01:51:10.382+0900 E/EFL     (18613): edje<18613> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 01:51:10.382+0900 E/EFL     (18613): edje<18613> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-13 01:51:10.382+0900 I/get     (18613): 50
06-13 01:51:10.382+0900 I/get     (18613): 50
06-13 01:51:10.382+0900 I/get     (18613): 50
06-13 01:51:10.382+0900 I/get     (18613): 50
06-13 01:51:10.402+0900 I/get     (18613): 50
06-13 01:51:10.402+0900 I/get     (18613): 50
06-13 01:51:10.402+0900 I/get     (18613): 50
06-13 01:51:10.402+0900 I/get     (18613): 50
06-13 01:51:11.112+0900 D/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x605a47 
06-13 01:51:11.182+0900 I/tag     (18613): make!
06-13 01:51:11.932+0900 D/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x605a47 
06-13 01:51:12.072+0900 E/EFL     (18613): edje<18613> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
06-13 01:51:12.072+0900 E/EFL     (18613): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 01:51:12.432+0900 I/tag     (18613): 0
06-13 01:51:12.432+0900 I/delete  (18613): 1 50
06-13 01:51:12.432+0900 I/tag     (18613): delete~~~
06-13 01:51:12.432+0900 I/tag     (18613): DELETE FROM feeding WHERE TM_HOUR = '1' AND TM_MIN = '50';
06-13 01:51:12.442+0900 I/tag     (18613): 0
06-13 01:51:12.442+0900 I/tag     (18613): 지우고~
06-13 01:51:12.442+0900 I/tag     (18613): 팝업 지워~
06-13 01:51:12.442+0900 I/tag     (18613): 끝
06-13 01:51:13.172+0900 D/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x605a47 bd->visible=1
06-13 01:51:13.542+0900 D/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x605a47 
06-13 01:51:14.342+0900 I/user_tag0(18613): /opt/usr/apps/org.example.example/data/feeding.db
06-13 01:51:14.342+0900 I/tag     (18613): eonji~
06-13 01:51:14.342+0900 I/tag     (18613): 들어와!
06-13 01:51:14.342+0900 I/tag     (18613): 언지
06-13 01:51:14.342+0900 I/tag     (18613): 1 51
06-13 01:51:14.342+0900 I/tag     (18613): insert
06-13 01:51:14.342+0900 I/tag     (18613): 1:51
06-13 01:51:14.342+0900 I/saved time(18613): 1 51
06-13 01:51:14.342+0900 I/tag     (18613): 들어와!
06-13 01:51:14.342+0900 I/tag     (18613): 언지
06-13 01:51:14.342+0900 I/tag     (18613): 1 50
06-13 01:51:14.342+0900 I/tag     (18613): insert
06-13 01:51:14.342+0900 I/tag     (18613): 1:50
06-13 01:51:14.342+0900 I/saved time(18613): 1 50
06-13 01:51:14.342+0900 I/get     (18613): 51
06-13 01:51:14.342+0900 I/get     (18613): 51
06-13 01:51:14.342+0900 I/get     (18613): 51
06-13 01:51:14.342+0900 I/get     (18613): 51
06-13 01:51:14.352+0900 I/get     (18613): 50
06-13 01:51:14.352+0900 I/get     (18613): 50
06-13 01:51:14.352+0900 I/get     (18613): 50
06-13 01:51:14.352+0900 I/get     (18613): 50
06-13 01:51:14.362+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.362+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.362+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.362+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.362+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.362+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.362+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.362+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.362+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.362+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.362+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.362+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.362+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.362+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.362+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.362+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.362+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.362+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.362+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.362+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.362+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.372+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.372+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.372+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.372+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.372+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.372+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.372+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.372+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.372+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.372+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.372+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.372+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.372+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.372+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.372+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.372+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.372+0900 E/EFL     (18613): evas_main<18613> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800e6027 is not stable during recalc loop
06-13 01:51:14.402+0900 D/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x605a47 
06-13 01:51:14.402+0900 I/get     (18613): 51
06-13 01:51:14.402+0900 I/get     (18613): 51
06-13 01:51:14.402+0900 I/get     (18613): 51
06-13 01:51:14.402+0900 I/get     (18613): 51
06-13 01:51:14.402+0900 I/get     (18613): 50
06-13 01:51:14.402+0900 I/get     (18613): 50
06-13 01:51:14.402+0900 I/get     (18613): 50
06-13 01:51:14.402+0900 I/get     (18613): 50
06-13 01:51:28.102+0900 E/CAPI_NETWORK_WIFI( 2850): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 01:51:28.102+0900 E/INDICATOR( 2850): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 01:51:28.102+0900 E/INDICATOR( 2850): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 01:51:28.102+0900 E/INDICATOR( 2850): 
06-13 01:51:42.502+0900 D/RESOURCED( 2846): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 01:51:42.502+0900 I/RESOURCED( 2846): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 01:51:42.502+0900 D/RESOURCED( 2846): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 01:51:42.502+0900 I/RESOURCED( 2846): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 01:51:48.132+0900 E/CAPI_NETWORK_WIFI( 2850): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 01:51:48.132+0900 E/INDICATOR( 2850): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 01:51:48.132+0900 E/INDICATOR( 2850): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 01:51:48.132+0900 E/INDICATOR( 2850): 
06-13 01:52:00.322+0900 D/INDICATOR( 2850): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-13 01:52:00.322+0900 D/INDICATOR( 2850): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-13 01:52:00.322+0900 D/INDICATOR( 2850): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 01:52:00.322+0900 D/INDICATOR( 2850): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 1:52 4 h"
06-13 01:52:00.322+0900 D/INDICATOR( 2850): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 1:52"
06-13 01:52:00.322+0900 D/INDICATOR( 2850): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 1&#x2236;52"
06-13 01:52:00.322+0900 D/INDICATOR( 2850): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146012866 Time: <font_size=33>1&#x2236;52</font_size> <font_size=32>AM</font_size></font>
06-13 01:52:08.142+0900 E/CAPI_NETWORK_WIFI( 2850): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 01:52:08.142+0900 E/INDICATOR( 2850): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 01:52:08.142+0900 E/INDICATOR( 2850): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 01:52:08.142+0900 E/INDICATOR( 2850): 
06-13 01:52:17.751+0900 D/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x605a47 
06-13 01:52:18.761+0900 D/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2a00002
06-13 01:52:18.911+0900 D/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x605a47 
06-13 01:52:18.981+0900 I/tag     (18613): make!
06-13 01:52:19.811+0900 D/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x605a47 
06-13 01:52:19.951+0900 E/EFL     (18613): edje<18613> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
06-13 01:52:19.951+0900 E/EFL     (18613): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 01:52:20.301+0900 I/tag     (18613): 0
06-13 01:52:20.301+0900 I/delete  (18613): 1 50
06-13 01:52:20.301+0900 I/tag     (18613): delete~~~
06-13 01:52:20.301+0900 I/tag     (18613): DELETE FROM feeding WHERE TM_HOUR = '1' AND TM_MIN = '50';
06-13 01:52:20.301+0900 I/tag     (18613): 21
06-13 01:52:20.301+0900 I/tag     (18613): 1
06-13 01:52:20.301+0900 I/tag     (18613): 지우고~
06-13 01:52:20.311+0900 I/tag     (18613): 팝업 지워~
06-13 01:52:20.311+0900 I/tag     (18613): 끝
06-13 01:52:23.761+0900 D/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x605a47 bd->visible=1
06-13 01:52:28.151+0900 E/CAPI_NETWORK_WIFI( 2850): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 01:52:28.151+0900 E/INDICATOR( 2850): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 01:52:28.151+0900 E/INDICATOR( 2850): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 01:52:28.151+0900 E/INDICATOR( 2850): 
06-13 01:52:39.041+0900 E/PKGMGR_SERVER(18843): pkgmgr-server.c: main(2209) > package manager server start
06-13 01:52:39.041+0900 D/PKGMGR  (18843): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(405) > initialize_gdbus Enter
06-13 01:52:39.041+0900 D/PKGMGR  (18843): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(423) > initialize_gdbus Exit
06-13 01:52:39.051+0900 D/PKGMGR  (18843): comm_pkg_mgr_server.c: on_bus_acquired(376) > on_bus_acquired
06-13 01:52:39.051+0900 D/PKGMGR  (18843): comm_pkg_mgr_server.c: on_bus_acquired(400) > on_bus_acquired done
06-13 01:52:39.061+0900 D/PKGMGR  (18843): comm_pkg_mgr_server.c: pkgmgr_request(145) > Called
06-13 01:52:39.061+0900 D/PKGMGR  (18843): comm_pkg_mgr_server.c: pkgmgr_request(164) > sender_name: :1.1690
06-13 01:52:39.061+0900 D/PKGMGR  (18843): comm_pkg_mgr_server.c: pkg_mgr_get_sender_pid(79) > zone pid : 18841
06-13 01:52:39.061+0900 D/PKGMGR  (18843): comm_pkg_mgr_server.c: pkgmgr_request(166) > sender_pid: 18841
06-13 01:52:39.061+0900 D/PKGMGR  (18843): comm_pkg_mgr_server.c: pkgmgr_request(175) > [SECURE_LOG] Call request callback(obj, org.example.example_630115189, 14, tpk, org.example.example, , host)
06-13 01:52:39.061+0900 D/PKGMGR_SERVER(18843): pkgmgr-server.c: req_cb(625) > [SECURE_LOG] >> in callback >> Got request: [org.example.example_630115189] [14] [tpk] [org.example.example] [] [] [host]
06-13 01:52:39.061+0900 D/PKGMGR_SERVER(18843): pkgmgr-server.c: req_cb(646) > req_type=(14)  backend_flag=(0) zone(host)
06-13 01:52:39.061+0900 D/PKGMGR_SERVER(18843): pkgmgr-server.c: queue_job(1880) > target zone(host, host)
06-13 01:52:39.061+0900 D/PKGMGR_SERVER(18843): pkgmgr-server.c: queue_job(1884) > child forked [18846] for request type [14]
06-13 01:52:39.061+0900 D/PKGMGR_SERVER(18843): pkgmgr-server.c: queue_job(2126) > parent exit
06-13 01:52:39.061+0900 D/PKGMGR_SERVER(18846): pkgmgr-server.c: queue_job(1884) > child forked [0] for request type [14]
06-13 01:52:39.061+0900 D/PKGMGR_SERVER(18846): pkgmgr-server.c: queue_job(2057) > kill/check request
06-13 01:52:39.061+0900 D/PKGMGR  (18841): pkgmgr.c: __check_sync_process(868) > info_file file is generated, result = 0
06-13 01:52:39.061+0900 D/PKGMGR  (18841): . 
06-13 01:52:39.071+0900 E/PKGMGR  (18841): pkgmgr.c: __check_sync_process(884) > file is can not remove[/tmp/org.example.example, -1]
06-13 01:52:39.071+0900 D/PKGMGR_SERVER(18846): pkgmgr-server.c: __pkgcmd_app_cb(1458) > sub_cmd(kill), zone_name(host)
06-13 01:52:39.071+0900 D/AUL     (18846): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(14)
06-13 01:52:39.071+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 14
06-13 01:52:39.071+0900 D/AUL_AMD ( 2740): amd_status.c: _status_app_is_running_from_cache(836) > is_running hit cache, return immediately
06-13 01:52:39.071+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(1028) > [SECURE_LOG] APP_IS_RUNNING : org.example.example : 18613
06-13 01:52:39.071+0900 W/AUL_AMD ( 2740): amd_request.c: __send_result_to_client(150) > __send_result_to_client, pid: 18613
06-13 01:52:39.081+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 12
06-13 01:52:39.081+0900 D/AUL     (18846): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 293
06-13 01:52:39.081+0900 D/AUL     (18846): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : 18613
06-13 01:52:39.081+0900 D/AUL     (18846): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(5)
06-13 01:52:39.081+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 5
06-13 01:52:39.081+0900 D/AUL_AMD ( 2740): amd_appinfo.c: appinfo_set_value(905) > [SECURE_LOG] org.example.example : installed : norestart
06-13 01:52:39.081+0900 D/AUL_AMD ( 2740): amd_request.c: __app_process_by_pid(279) > [SECURE_LOG] __app_process_by_pid, pid: 18613, 
06-13 01:52:39.081+0900 D/AUL     ( 2740): app_sock.c: __app_send_raw_with_delay_reply(455) > pid(18613) : cmd(4)
06-13 01:52:39.081+0900 D/AUL_AMD ( 2740): amd_launch.c: _term_app(1076) > term done
06-13 01:52:39.081+0900 D/AUL_AMD ( 2740): amd_launch.c: __set_reply_handler(1015) > listen fd : 31, send fd : 30
06-13 01:52:39.081+0900 D/APP_CORE(18613): appcore.c: __aul_handler(632) > [APP 18613]     AUL event: AUL_TERMINATE
06-13 01:52:39.081+0900 I/APP_CORE(18613): appcore-efl.c: __do_app(496) > [APP 18613] Event: TERMINATE State: RUNNING
06-13 01:52:39.081+0900 D/APP_CORE(18613): appcore-efl.c: __do_app(517) > [APP 18613] TERMINATE
06-13 01:52:39.081+0900 W/AUL_AMD ( 2740): amd_launch.c: __reply_handler(913) > listen fd(31) , send fd(30), pid(18613), cmd(4)
06-13 01:52:39.081+0900 D/AUL     (18846): launch.c: app_request_to_launchpad(425) > launch request result : 0
06-13 01:52:39.081+0900 D/AUL     (18846): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(14)
06-13 01:52:39.081+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 14
06-13 01:52:39.081+0900 D/AUL_AMD ( 2740): amd_status.c: _status_app_is_running_from_cache(836) > is_running hit cache, return immediately
06-13 01:52:39.081+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(1028) > [SECURE_LOG] APP_IS_RUNNING : org.example.example : 18613
06-13 01:52:39.081+0900 W/AUL_AMD ( 2740): amd_request.c: __send_result_to_client(150) > __send_result_to_client, pid: 18613
06-13 01:52:39.081+0900 D/RESOURCED( 2846): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 18613
06-13 01:52:39.081+0900 D/AUL     (18613): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-13 01:52:39.081+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 22
06-13 01:52:39.081+0900 W/AUL_AMD ( 2740): amd_request.c: __request_handler(1056) > app status : 5
06-13 01:52:39.081+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(456) > pid(18613) status(5)
06-13 01:52:39.081+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(468) > pid(18613) appid(org.example.example) pkgid(org.example.example) status(5)
06-13 01:52:39.081+0900 D/AUL     (18613): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-13 01:52:39.081+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 22
06-13 01:52:39.081+0900 W/AUL_AMD ( 2740): amd_request.c: __request_handler(1056) > app status : 5
06-13 01:52:39.081+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(456) > pid(18613) status(5)
06-13 01:52:39.081+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(468) > pid(18613) appid(org.example.example) pkgid(org.example.example) status(5)
06-13 01:52:39.081+0900 D/APP_CORE(18613): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
06-13 01:52:39.081+0900 D/APP_CORE(18613): appcore-efl.c: __after_loop(1169) > [APP 18613] PAUSE before termination
06-13 01:52:39.081+0900 I/CAPI_APPFW_APPLICATION(18613): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-13 01:52:39.081+0900 I/CAPI_APPFW_APPLICATION(18613): app_main.c: _ui_app_appcore_terminate(662) > app_appcore_terminate
06-13 01:52:39.081+0900 E/EFL     (18613): eo<18613> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x8001a0d1 is not pointing to a valid object. Maybe it has already been freed.
06-13 01:52:39.081+0900 E/EFL     (18613): eo<18613> lib/eo/eo.c:485 _eo_do_internal() Obj (0x8001a0d1) is an invalid ref.
06-13 01:52:39.081+0900 E/EFL     ( 2760): eo<2760> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-13 01:52:39.091+0900 D/AUL_AMD ( 2740): amd_launch.c: __e17_status_handler(2891) > pid(2866) status(3)
06-13 01:52:39.091+0900 D/AUL_AMD ( 2740): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-13 01:52:39.091+0900 W/AUL_AMD ( 2740): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 01:52:39.091+0900 W/AUL_AMD ( 2740): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-13 01:52:39.091+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(456) > pid(2866) status(3)
06-13 01:52:39.091+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(468) > pid(2866) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(3)
06-13 01:52:39.091+0900 D/AUL     ( 2740): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.tizen.homescreen
06-13 01:52:39.091+0900 W/AUL     ( 2740): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2866, appid: org.tizen.homescreen, status: fg
06-13 01:52:39.091+0900 D/RESOURCED( 2846): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2866
06-13 01:52:39.091+0900 D/RESOURCED( 2846): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 2866, appname = org.tizen.homescreen, pkgname = org.tizen.homescreen
06-13 01:52:39.091+0900 D/RESOURCED( 2846): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2866, appname = org.tizen.homescreen
06-13 01:52:39.091+0900 D/RESOURCED( 2846): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2866
06-13 01:52:39.091+0900 I/tag     (18613): 0
06-13 01:52:39.121+0900 E/E17     ( 2760): e_border.c: e_border_show(2088) > BD_SHOW(0x01600002)
06-13 01:52:39.121+0900 E/E17     ( 2760): e_border.c: e_border_hide(2248) > BD_HIDE(0x02a00002), visible:1
06-13 01:52:39.121+0900 D/INDICATOR( 2850): main.c: _property_changed_cb(432) > UNSNIFF API 2a00002
06-13 01:52:39.121+0900 D/INDICATOR( 2850): util.c: util_signal_emit_by_win(116) > emission bg.translucent
06-13 01:52:39.121+0900 D/INDICATOR( 2850): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-13 01:52:39.121+0900 D/INDICATOR( 2850): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-13 01:52:39.121+0900 D/INDICATOR( 2850): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-13 01:52:39.121+0900 D/INDICATOR( 2850): main.c: _rotate_window(252) > port :: hide more icon
06-13 01:52:39.131+0900 W/CRASH_MANAGER(18848): worker.c: worker_job(1204) > 1118613657861149728635
