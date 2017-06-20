S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 6853
Date: 2017-06-13 15:04:54+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xd

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb22edc10, esi = 0xb22edc10
ebp = 0xb22ee128, esp = 0xb22edc10
eax = 0xb37a0000, ebx = 0xb37a0000
ecx = 0x00000000, edx = 0xb22edce3
eip = 0xb37997cf

Memory Information
MemTotal:      123 KB
MemFree:        32 KB
Buffers:         7 KB
Cached:     156188 KB
VmPeak:     108868 KB
VmSize:     108868 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22108 KB
VmRSS:       22108 KB
VmData:      41144 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34612 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 6853 TID = 6906
6853 6854 6903 6904 6906 

Maps Information
b2b31000 b2b3b000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b41000 b2b4d000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b4e000 b2b6f000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2b74000 b2b75000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2b76000 b2b7b000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2b7c000 b2b7d000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2b7e000 b2b80000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2b81000 b2b83000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2b84000 b2b90000 r-xp /usr/lib/libdrm.so.2.4.0
b2b91000 b2b94000 r-xp /usr/lib/libdri2.so.0.0.0
b2b95000 b2b9f000 r-xp /usr/lib/libtbm.so.1.0.0
b2ba0000 b2ba1000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b2ba2000 b2bb7000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2bb8000 b2bca000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b33cc000 b33fd000 r-xp /usr/lib/libidn.so.11.5.44
b33fe000 b3420000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3421000 b3431000 r-xp /usr/lib/libcares.so.2.1.0
b3432000 b343b000 r-xp /usr/lib/libeventsystem.so.0.0.1
b343c000 b3442000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b3443000 b3459000 r-xp /usr/lib/libalarm.so.0.0.0
b345b000 b3464000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3465000 b34dc000 r-xp /usr/lib/libcurl.so.4.3.0
b34de000 b34f0000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34f1000 b34f4000 r-xp /usr/lib/libcapi-message-port.so.1.2.2.1
b34f5000 b34f8000 r-xp /usr/lib/libcapi-appfw-alarm.so.0.3.1.0
b34f9000 b351a000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b3521000 b3522000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3523000 b3524000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3525000 b3528000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3529000 b352c000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3634000 b363a000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b363b000 b377f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3790000 b379f000 r-xp /opt/usr/apps/org.example.example/bin/example
b37a1000 b37da000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41dd000 b41e8000 r-xp /lib/libnss_files-2.20-2014.11.so
b41ea000 b41f5000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41f7000 b420e000 r-xp /lib/libnsl-2.20-2014.11.so
b4212000 b421a000 r-xp /lib/libnss_compat-2.20-2014.11.so
b421c000 b4240000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4241000 b4242000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4243000 b4246000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4247000 b424e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b424f000 b4259000 r-xp /usr/lib/libsensord-share.so
b425a000 b4276000 r-xp /usr/lib/libsensor.so.1.2.0
b4278000 b4281000 r-xp /usr/lib/libappcore-common.so.1.1
b4284000 b4286000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b429b000 b429d000 r-xp /usr/lib/libXau.so.6.0.0
b429e000 b42c0000 r-xp /usr/lib/libxcb.so.1.1.0
b42c2000 b42cb000 r-xp /lib/libcrypt-2.20-2014.11.so
b42f4000 b42f6000 r-xp /usr/lib/libiri.so
b42f7000 b431d000 r-xp /lib/libexpat.so.1.5.2
b431f000 b438a000 r-xp /usr/lib/libssl.so.1.0.0
b4390000 b439c000 r-xp /usr/lib/libethumb.so.1.13.0
b439d000 b43a1000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43a2000 b45f3000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b6e000 b5b7e000 r-xp /usr/lib/libXi.so.6.1.0
b5b7f000 b5b81000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b82000 b5b88000 r-xp /usr/lib/libXtst.so.6.1.0
b5b89000 b5b93000 r-xp /usr/lib/libXrender.so.1.3.0
b5b94000 b5b9d000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b9f000 b5ba1000 r-xp /usr/lib/libXinerama.so.1.0.0
b5ba2000 b5ba7000 r-xp /usr/lib/libXfixes.so.3.1.0
b5ba8000 b5bba000 r-xp /usr/lib/libXext.so.6.4.0
b5bbb000 b5bbd000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bbe000 b5bc0000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bc2000 b5d04000 r-xp /usr/lib/libX11.so.6.3.0
b5d08000 b5d12000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d13000 b5d29000 r-xp /usr/lib/libudev.so.1.6.0
b5d2c000 b5d30000 r-xp /lib/libattr.so.1.1.0
b5d31000 b5d60000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d62000 b5d68000 r-xp /usr/lib/libffi.so.6.0.2
b5d69000 b5d8c000 r-xp /lib/libz.so.1.2.8
b5d8d000 b5d90000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d91000 b5eed000 r-xp /usr/lib/libxml2.so.2.9.2
b5ef3000 b5fda000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fe7000 b5fea000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5feb000 b600d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b600e000 b6022000 r-xp /lib/libresolv-2.20-2014.11.so
b6026000 b604a000 r-xp /usr/lib/liblzma.so.5.0.3
b604b000 b604d000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b604f000 b6059000 r-xp /usr/lib/libembryo.so.1.13.0
b605a000 b6083000 r-xp /usr/lib/libpng12.so.0.50.0
b6084000 b60cd000 r-xp /usr/lib/libjpeg.so.8.0.2
b60de000 b60e5000 r-xp /lib/librt-2.20-2014.11.so
b60e7000 b6106000 r-xp /usr/lib/libector.so.1.13.0
b6109000 b6136000 r-xp /usr/lib/liblua-5.1.so
b6137000 b61c7000 r-xp /usr/lib/libfreetype.so.6.11.3
b61cb000 b6209000 r-xp /usr/lib/libfontconfig.so.1.8.0
b620a000 b6220000 r-xp /usr/lib/libfribidi.so.0.3.1
b6221000 b627a000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b627d000 b62c8000 r-xp /lib/libm-2.20-2014.11.so
b62ca000 b62dc000 r-xp /usr/lib/libeio.so.1.13.0
b62dd000 b62e0000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62e1000 b62e7000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62e8000 b630b000 r-xp /usr/lib/libefreet.so.1.13.0
b630e000 b6339000 r-xp /usr/lib/libeldbus.so.1.13.0
b633a000 b636e000 r-xp /usr/lib/libecore_con.so.1.13.0
b6370000 b6379000 r-xp /usr/lib/libecore_imf.so.1.13.0
b637a000 b6383000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6384000 b6397000 r-xp /usr/lib/libeo.so.1.13.0
b6399000 b63ac000 r-xp /usr/lib/libecore_input.so.1.13.0
b63ad000 b63b4000 r-xp /usr/lib/libecore_file.so.1.13.0
b63b5000 b63d8000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63d9000 b6405000 r-xp /usr/lib/libeet.so.1.13.0
b640e000 b6479000 r-xp /usr/lib/libeina.so.1.13.0
b647c000 b6493000 r-xp /usr/lib/libefl.so.1.13.0
b6495000 b65fc000 r-xp /usr/lib/libicuuc.so.51.1
b660a000 b6816000 r-xp /usr/lib/libicui18n.so.51.1
b681e000 b686d000 r-xp /usr/lib/libecore_x.so.1.13.0
b686f000 b6889000 r-xp /lib/libgcc_s-4.9.so.1
b688b000 b688f000 r-xp /lib/libcap.so.2.21
b6890000 b68d6000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68d7000 b68de000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68e0000 b6932000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6934000 b6abf000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6ac4000 b6b92000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b95000 b6b99000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b9a000 b6ba9000 r-xp /usr/lib/libvconf.so.0.2.45
b6baa000 b6bad000 r-xp /usr/lib/libvasum.so.0.3.1
b6bae000 b6bb1000 r-xp /usr/lib/libttrace.so.1.1
b6bb3000 b6bb7000 r-xp /usr/lib/libiniparser.so.0
b6bb8000 b6be8000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6be9000 b6bf2000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bf3000 b6c18000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c19000 b6c29000 r-xp /usr/lib/libunwind.so.8.0.1
b6c33000 b6de1000 r-xp /lib/libc-2.20-2014.11.so
b6de9000 b6f2c000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f2e000 b6f86000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f87000 b6fbb000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fbe000 b7092000 r-xp /usr/lib/libedje.so.1.13.0
b7095000 b70c1000 r-xp /usr/lib/libecore.so.1.13.0
b70d2000 b72f8000 r-xp /usr/lib/libevas.so.1.13.0
b7320000 b7338000 r-xp /lib/libpthread-2.20-2014.11.so
b733c000 b76b6000 r-xp /usr/lib/libelementary.so.1.13.0
b76d6000 b76da000 r-xp /usr/lib/libsmack.so.1.0.0
b76db000 b76e4000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76e5000 b76e8000 r-xp /usr/lib/libdlog.so.0.0.0
b76e9000 b76ee000 r-xp /usr/lib/libbundle.so.0.1.22
b76ef000 b76f2000 r-xp /lib/libdl-2.20-2014.11.so
b76f4000 b7719000 r-xp /usr/lib/libaul.so.0.1.0
b771c000 b771e000 r-xp /usr/lib/libappsvc.so.0.1.0
b771f000 b7724000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7725000 b772c000 r-xp /usr/lib/libappcore-efl.so.1.1
b772e000 b7733000 r-xp /usr/lib/libsys-assert.so
b7736000 b7737000 r-xp [vdso]
b7737000 b7759000 r-xp /lib/ld-2.20-2014.11.so
b775b000 b7763000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:6853)
Call Stack Count: 3
 0: run_app + 0x4df (0xb37997cf) [/opt/usr/apps/org.example.example/bin/example] + 0x97cf
 1: (0xb732615f) [/lib/libpthread.so.0] + 0x615f
 2: clone + 0x5e (0xb6d1a3ee) [/lib/libc.so.6] + 0xe73ee
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
57+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(365) >  forseAnim[1] && mIsMenuBoxEditing[0]
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(380) >  cut Animation : basicui
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(403) >  Animation start : basicui
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(365) >  forseAnim[1] && mIsMenuBoxEditing[0]
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(380) >  cut Animation : Calendar
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(403) >  Animation start : Calendar
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(365) >  forseAnim[1] && mIsMenuBoxEditing[0]
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(380) >  cut Animation : Camera
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(403) >  Animation start : Camera
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(365) >  forseAnim[1] && mIsMenuBoxEditing[0]
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(380) >  cut Animation : Contacts
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(403) >  Animation start : Contacts
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(365) >  forseAnim[1] && mIsMenuBoxEditing[0]
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(380) >  cut Animation : Email
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(403) >  Animation start : Email
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(365) >  forseAnim[1] && mIsMenuBoxEditing[0]
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(380) >  cut Animation : forpet
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(403) >  Animation start : forpet
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(365) >  forseAnim[1] && mIsMenuBoxEditing[0]
06-13 15:04:36.957+0900 D/cluster-home( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(369) >  Menu Box[601] can not animation
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(365) >  forseAnim[1] && mIsMenuBoxEditing[0]
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(380) >  cut Animation : Gallery
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(403) >  Animation start : Gallery
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(365) >  forseAnim[1] && mIsMenuBoxEditing[0]
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(380) >  cut Animation : Internet
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(403) >  Animation start : Internet
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(365) >  forseAnim[1] && mIsMenuBoxEditing[0]
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(380) >  cut Animation : Messages
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(403) >  Animation start : Messages
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(365) >  forseAnim[1] && mIsMenuBoxEditing[0]
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(380) >  cut Animation : Music
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(403) >  Animation start : Music
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(365) >  forseAnim[1] && mIsMenuBoxEditing[0]
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(380) >  cut Animation : My Files
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(403) >  Animation start : My Files
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(365) >  forseAnim[1] && mIsMenuBoxEditing[0]
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(380) >  cut Animation : Phone
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(403) >  Animation start : Phone
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(365) >  forseAnim[1] && mIsMenuBoxEditing[0]
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(380) >  cut Animation : Settings
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(403) >  Animation start : Settings
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(365) >  forseAnim[1] && mIsMenuBoxEditing[0]
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(380) >  cut Animation : Video
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(403) >  Animation start : Video
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(365) >  forseAnim[1] && mIsMenuBoxEditing[0]
06-13 15:04:36.957+0900 D/cluster-home( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(369) >  Menu Box[602] can not animation
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(365) >  forseAnim[1] && mIsMenuBoxEditing[0]
06-13 15:04:36.957+0900 D/cluster-home( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(369) >  Menu Box[603] can not animation
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(365) >  forseAnim[1] && mIsMenuBoxEditing[0]
06-13 15:04:36.957+0900 D/cluster-home( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(369) >  Menu Box[604] can not animation
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(365) >  forseAnim[1] && mIsMenuBoxEditing[0]
06-13 15:04:36.957+0900 D/cluster-home( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(369) >  Menu Box[605] can not animation
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(365) >  forseAnim[1] && mIsMenuBoxEditing[0]
06-13 15:04:36.957+0900 D/cluster-home( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(369) >  Menu Box[606] can not animation
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(365) >  forseAnim[1] && mIsMenuBoxEditing[0]
06-13 15:04:36.957+0900 D/cluster-home( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(369) >  Menu Box[607] can not animation
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(365) >  forseAnim[1] && mIsMenuBoxEditing[0]
06-13 15:04:36.957+0900 D/cluster-home( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(369) >  Menu Box[608] can not animation
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(365) >  forseAnim[1] && mIsMenuBoxEditing[0]
06-13 15:04:36.957+0900 D/cluster-home( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(369) >  Menu Box[609] can not animation
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(365) >  forseAnim[1] && mIsMenuBoxEditing[0]
06-13 15:04:36.957+0900 D/cluster-home( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(369) >  Menu Box[610] can not animation
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(365) >  forseAnim[1] && mIsMenuBoxEditing[0]
06-13 15:04:36.957+0900 D/cluster-home( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(369) >  Menu Box[611] can not animation
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(365) >  forseAnim[1] && mIsMenuBoxEditing[0]
06-13 15:04:36.957+0900 D/cluster-home( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(369) >  Menu Box[612] can not animation
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(365) >  forseAnim[1] && mIsMenuBoxEditing[0]
06-13 15:04:36.957+0900 D/cluster-home( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(369) >  Menu Box[613] can not animation
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(365) >  forseAnim[1] && mIsMenuBoxEditing[0]
06-13 15:04:36.957+0900 D/cluster-home( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(369) >  Menu Box[614] can not animation
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(365) >  forseAnim[1] && mIsMenuBoxEditing[0]
06-13 15:04:36.957+0900 D/cluster-home( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(369) >  Menu Box[615] can not animation
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(365) >  forseAnim[1] && mIsMenuBoxEditing[0]
06-13 15:04:36.957+0900 D/cluster-home( 2863): mainmenu-box-impl.cpp: DoEditModeAnimation(369) >  Menu Box[616] can not animation
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-apps-view-impl.cpp: SetAppsViewEditMode(980) >  ==== [1] page's box count[30]  ======
06-13 15:04:36.957+0900 D/cluster-view( 2863): homescreen-page-indicator.cpp: Update(281) >  Unit size is same [1]
06-13 15:04:36.957+0900 D/cluster-view( 2863): mainmenu-apps-view-impl.cpp: SetAppsViewEditMode(1017) >  Delete page
06-13 15:04:36.957+0900 D/cluster-home( 2863): mainmenu-presenter.cpp: OnPageDataNotify(226) >  Page [2]
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-apps-view-impl.cpp: ScrollToFocusedPage(2304) >  ScrollToFocusedPage(0.00) page[1]
06-13 15:04:36.957+0900 D/cluster-view( 2863): mainmenu-apps-view-impl.cpp: _OnScrollStart(1488) >  on appsview scroll started[1] xPos[-0] 
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-apps-view-impl.cpp: _OnScrollComplete(1505) >  Horizontal Apps scrollview is stopped normally.
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-apps-view-impl.cpp: _OnScrollComplete(1508) >  mMenuScrollView.GetCurrentPage(0)
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-apps-view-impl.cpp: _OnScrollComplete(1510) >  on appsview scroll completed[1] xPos[0]
06-13 15:04:36.957+0900 D/cluster-view( 2863): mainmenu-apps-view-impl.cpp: SetAppsViewFocusedPage(834) >  page [1]
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-view-manager-impl.cpp: OnAppsViewPageChangeCompleted(1114) >  page change updated, get new page map
06-13 15:04:36.957+0900 D/test-log( 2863): mainmenu-view-manager-impl.cpp: OnAppsViewPageChangeCompleted(1115) >  focused page!!!!!!!!!!!!!![1]
06-13 15:04:36.957+0900 D/cluster-view( 2863): mainmenu-view-manager-impl.cpp: OnAppsViewPageChangeCompleted(1155) >  Current View state[1]
06-13 15:04:36.957+0900 D/cluster-view( 2863): cluster-home-accessibility.cpp: SetCurrentGroup(62) >  Focus Group changed [12]->[12] Block[0]
06-13 15:04:36.957+0900 D/cluster-view( 2863): mainmenu-view-manager-impl.cpp: _UpdateScreenReader(2054) >  [TTS] For Home update type[1], group[12]
06-13 15:04:36.957+0900 D/cluster-view( 2863): cluster-view-controller.cpp: _OnTTSFocusChanged(1652) >  _OnTTSFocusChanged Order[0]
06-13 15:04:36.957+0900 D/cluster-view( 2863): custom-cluster-impl.cpp: OnFocusChanged(5705) >  OnFocusChanged[0]
06-13 15:04:36.957+0900 D/cluster-view( 2863): cluster-view-controller.cpp: _OnTTSFocusChanged(1652) >  _OnTTSFocusChanged Order[0]
06-13 15:04:36.957+0900 D/cluster-view( 2863): custom-cluster-impl.cpp: OnFocusChanged(5705) >  OnFocusChanged[0]
06-13 15:04:36.957+0900 D/cluster-view( 2863): cluster-view-controller.cpp: _OnTTSFocusChanged(1652) >  _OnTTSFocusChanged Order[60010]
06-13 15:04:36.957+0900 D/cluster-view( 2863): custom-cluster-impl.cpp: OnFocusChanged(5705) >  OnFocusChanged[60010]
06-13 15:04:36.957+0900 D/cluster-view( 2863): mainmenu-view-manager-impl.cpp: SetViewManagerEditMode(457) >  APPS_VIEW_MAIN
06-13 15:04:36.957+0900 D/test-log( 2863): homescreen-view-manager.cpp: ShowIndicator(700) >  call show indicator.
06-13 15:04:36.957+0900 D/cluster-view( 2863): homescreen-view-manager.cpp: _ShowIndicator(830) >  SHOW INDICATOR 1
06-13 15:04:37.277+0900 D/test-log( 2863): mainmenu-box-impl.cpp: _OnEditAnimationFinished(314) >  Animation stopped : basicui
06-13 15:04:37.277+0900 D/test-log( 2863): mainmenu-box-impl.cpp: _OnEditAnimationFinished(314) >  Animation stopped : Calendar
06-13 15:04:37.277+0900 D/test-log( 2863): mainmenu-box-impl.cpp: _OnEditAnimationFinished(314) >  Animation stopped : Camera
06-13 15:04:37.277+0900 D/test-log( 2863): mainmenu-box-impl.cpp: _OnEditAnimationFinished(314) >  Animation stopped : Contacts
06-13 15:04:37.277+0900 D/test-log( 2863): mainmenu-box-impl.cpp: _OnEditAnimationFinished(314) >  Animation stopped : Email
06-13 15:04:37.277+0900 D/test-log( 2863): mainmenu-box-impl.cpp: _OnEditAnimationFinished(314) >  Animation stopped : Gallery
06-13 15:04:37.277+0900 D/test-log( 2863): mainmenu-box-impl.cpp: _OnEditAnimationFinished(314) >  Animation stopped : Internet
06-13 15:04:37.277+0900 D/test-log( 2863): mainmenu-box-impl.cpp: _OnEditAnimationFinished(314) >  Animation stopped : Messages
06-13 15:04:37.277+0900 D/test-log( 2863): mainmenu-box-impl.cpp: _OnEditAnimationFinished(314) >  Animation stopped : Music
06-13 15:04:37.277+0900 D/test-log( 2863): mainmenu-box-impl.cpp: _OnEditAnimationFinished(314) >  Animation stopped : My Files
06-13 15:04:37.277+0900 D/test-log( 2863): mainmenu-box-impl.cpp: _OnEditAnimationFinished(314) >  Animation stopped : Phone
06-13 15:04:37.277+0900 D/test-log( 2863): mainmenu-box-impl.cpp: _OnEditAnimationFinished(314) >  Animation stopped : Settings
06-13 15:04:37.277+0900 D/test-log( 2863): mainmenu-box-impl.cpp: _OnEditAnimationFinished(314) >  Animation stopped : Video
06-13 15:04:37.277+0900 D/test-log( 2863): mainmenu-box-impl.cpp: _OnEditAnimationFinished(314) >  Animation stopped : forpet
06-13 15:04:37.927+0900 D/test-log( 2863): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1023) >  menu box Pick touched
06-13 15:04:37.927+0900 D/test-log( 2863): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1034) >  Long Tap Timer Start
06-13 15:04:37.967+0900 D/cluster-view( 2863): homescreen-view-manager.cpp: OnKeyEventHappenedTimerComplete(507) >  Key Event Happened Timer complete!
06-13 15:04:37.987+0900 D/test-log( 2863): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1194) >  Box[0] pick ended by Up
06-13 15:04:37.987+0900 D/test-log( 2863): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1199) >  Cancel Long Tap Timer
06-13 15:04:37.987+0900 D/test-log( 2863): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1240) >  app launch state[1]
06-13 15:04:37.987+0900 D/test-log( 2863): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1249) >  touch is moved upper position!!!
06-13 15:04:37.987+0900 D/test-log( 2863): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1298) >  laundch!!!!! touch position is moved from[243.00][353.00] to[243.00][353.00]!
06-13 15:04:37.987+0900 D/cluster-view( 2863): homescreen-view-manager.cpp: IsOverScrollThreshold(997) >  is Over Scrollview TreshHold?[0]
06-13 15:04:37.987+0900 D/cluster-home( 2863): mainmenu-custom-box-impl.cpp: OnClicked(171) >  [617]MenuBox clicked
06-13 15:04:37.987+0900 D/cluster-home( 2863): mainmenu-custom-box-impl.cpp: OnClicked(184) >  launch application via service(operation APP_CONTROL_OPERATION_DEFAULT)
06-13 15:04:37.987+0900 D/AUL     ( 2863): service.c: __set_bundle(186) > __set_bundle
06-13 15:04:37.987+0900 D/AUL     ( 2863): service.c: __get_alias_appid(548) > [SECURE_LOG] alias_id : (null)
06-13 15:04:37.987+0900 D/AUL     ( 2863): service.c: __set_bundle(186) > __set_bundle
06-13 15:04:37.987+0900 D/AUL     ( 2863): service.c: __run_svc_with_pkgname(276) > [SECURE_LOG] pkg_name : org.example.example - no result
06-13 15:04:37.987+0900 D/AUL     ( 2863): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : org.example.example
06-13 15:04:37.987+0900 D/AUL     ( 2863): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(0)
06-13 15:04:37.987+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(838) > __request_handler: 0
06-13 15:04:37.987+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-13 15:04:37.987+0900 W/AUL_AMD ( 2747): amd_launch.c: _start_app(2231) > [SECURE_LOG] caller appid : org.tizen.homescreen
06-13 15:04:37.987+0900 W/AUL_AMD ( 2747): amd_launch.c: _start_app(2233) > caller pid : 2863
06-13 15:04:37.997+0900 D/AUL_AMD ( 2747): amd_launch.c: _start_app(2443) > win(a00002) ecore_x_pointer_grab(1)
06-13 15:04:37.997+0900 D/AUL_AMD ( 2747): amd_key.c: _key_grab(243) > _key_grab, win : a00002
06-13 15:04:37.997+0900 D/AUL_AMD ( 2747): amd_launch.c: _start_app(2448) > back key grab
06-13 15:04:37.997+0900 W/AUL_AMD ( 2747): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-13 15:04:37.997+0900 D/RESOURCED( 2842): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-13 15:04:37.997+0900 D/RESOURCED( 2842): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-13 15:04:37.997+0900 E/RESOURCED( 2842): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 15:04:37.997+0900 D/AUL_AMD ( 2747): amd_launch.c: _start_app(2518) > org.tizen.system.deviced.PmQos-AppLaunch : 0
06-13 15:04:37.997+0900 D/AUL_AMD ( 2747): amd_launch.c: _start_app(2648) > process_pool: false
06-13 15:04:37.997+0900 D/AUL_AMD ( 2747): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-13 15:04:37.997+0900 D/AUL_AMD ( 2747): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-13 15:04:37.997+0900 W/AUL_AMD ( 2747): amd_launch.c: _start_app(2665) > pad pid(-5)
06-13 15:04:37.997+0900 D/AUL_AMD ( 2747): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-13 15:04:37.997+0900 D/AUL_AMD ( 2747): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-13 15:04:37.997+0900 D/AUL     ( 2747): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-13 15:04:37.997+0900 D/AUL_PAD ( 2910): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-13 15:04:37.997+0900 D/AUL_PAD ( 2910): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-13 15:04:37.997+0900 D/AUL_PAD ( 2910): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-13 15:04:37.997+0900 D/AUL_PAD ( 2910): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-13 15:04:37.997+0900 D/AUL_PAD ( 2910): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-13 15:04:37.997+0900 D/AUL_PAD ( 2910): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-13 15:04:37.997+0900 D/AUL_PAD ( 2910): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-13 15:04:37.997+0900 D/AUL_PAD ( 2910): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-13 15:04:37.997+0900 D/AUL_PAD ( 2910): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-13 15:04:37.997+0900 D/AUL_PAD ( 2910): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-13 15:04:37.997+0900 D/AUL_PAD ( 2910): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-13 15:04:37.997+0900 D/AUL_PAD ( 2910): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-13 15:04:37.997+0900 D/AUL_PAD ( 2910): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-13 15:04:37.997+0900 D/AUL_PAD ( 2910): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-13 15:04:37.997+0900 W/AUL_PAD ( 2910): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-13 15:04:37.997+0900 D/AUL     ( 2910): process_pool.c: __send_pkt_raw_data(219) > send(11) : 884 / 884
06-13 15:04:37.997+0900 D/AUL_PAD ( 2910): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 6853, bin path: /opt/usr/apps/org.example.example/bin/example
06-13 15:04:37.997+0900 W/AUL_PAD ( 2910): launchpad.c: __send_result_to_caller(265) > Check app launching
06-13 15:04:37.997+0900 D/AUL_PAD ( 2910): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-13 15:04:37.997+0900 D/AUL_PAD ( 6853): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-13 15:04:37.997+0900 D/AUL_PAD ( 6853): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 884, pkt->len: 876
06-13 15:04:37.997+0900 D/AUL_PAD ( 6853): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-13 15:04:37.997+0900 D/AUL_PAD ( 6853): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-13 15:04:37.997+0900 D/AUL_PAD ( 6853): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-13 15:04:37.997+0900 D/AUL_PAD ( 6853): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-13 15:04:37.997+0900 D/AUL     ( 6853): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (6854) is sent.
06-13 15:04:37.997+0900 D/AUL     ( 6853): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 6854, signo: 10
06-13 15:04:37.997+0900 D/AUL     ( 6853): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-13 15:04:37.997+0900 D/AUL_PAD ( 6853): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-13 15:04:37.997+0900 D/AUL_PAD ( 6853): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-13 15:04:37.997+0900 D/AUL_PAD ( 6853): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-13 15:04:37.997+0900 D/AUL_PAD ( 6853): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
06-13 15:04:37.997+0900 D/AUL_PAD ( 6853): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : UgAAAAEEAAAUAAAAX19BUFBfU1ZDX09QX1RZUEVfXwAuAAAAaHR0cDovL3RpemVuLm9yZy9hcHBjb250cm9sL29wZXJhdGlvbi9kZWZhdWx0AA==##
06-13 15:04:37.997+0900 D/AUL_PAD ( 6853): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __APP_SVC_PKG_NAME__##
06-13 15:04:37.997+0900 D/AUL_PAD ( 6853): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : OQAAAAEEAAAVAAAAX19BUFBfU1ZDX1BLR19OQU1FX18AFAAAAG9yZy5leGFtcGxlLmV4YW1wbGUA##
06-13 15:04:37.997+0900 D/AUL_PAD ( 6853): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_STARTTIME__##
06-13 15:04:37.997+0900 D/AUL_PAD ( 6853): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTczMzM4NzcvOTk4NzA3AA==##
06-13 15:04:37.997+0900 D/AUL_PAD ( 6853): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 8 : __AUL_CALLER_PID__##
06-13 15:04:37.997+0900 D/AUL_PAD ( 6853): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 9 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAAyODYzAA==##
06-13 15:04:37.997+0900 D/AUL_PAD ( 6853): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 10 : __AUL_CALLER_APPID__##
06-13 15:04:37.997+0900 D/AUL_PAD ( 6853): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 11 : OgAAAAEEAAAVAAAAX19BVUxfQ0FMTEVSX0FQUElEX18AFQAAAG9yZy50aXplbi5ob21lc2NyZWVuAA==##
06-13 15:04:37.997+0900 D/AUL_PAD ( 6853): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 12 : __AUL_INTERNAL_POOL__##
06-13 15:04:37.997+0900 D/AUL_PAD ( 6853): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 13 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-13 15:04:37.997+0900 D/AUL_PAD ( 6853): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 14
06-13 15:04:37.997+0900 D/AUL_PAD ( 6853): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-13 15:04:37.997+0900 D/AUL_PAD ( 6853): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-13 15:04:37.997+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x40004e 
06-13 15:04:37.997+0900 I/CAPI_APPFW_APPLICATION( 6853): app_main.c: ui_app_main(788) > app_efl_main
06-13 15:04:37.997+0900 D/LAUNCH  ( 6853): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-13 15:04:37.997+0900 D/APP_CORE( 6853): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-13 15:04:37.997+0900 D/APP_CORE( 6853): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-13 15:04:38.007+0900 D/APP_CORE( 6853): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-13 15:04:38.007+0900 D/APP_CORE( 6853): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-13 15:04:38.007+0900 D/AUL     ( 6853): app_sock.c: __create_server_sock(156) > pg path - already exists
06-13 15:04:38.007+0900 D/APP_CORE( 6853): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb4281520
06-13 15:04:38.007+0900 D/LAUNCH  ( 6853): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-13 15:04:38.007+0900 I/CAPI_APPFW_APPLICATION( 6853): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-13 15:04:38.087+0900 D/LAUNCH  ( 6853): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
06-13 15:04:38.087+0900 D/APP_CORE( 6853): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-13 15:04:38.087+0900 E/E17     ( 2765): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02800002)
06-13 15:04:38.097+0900 E/E17     ( 2765): e_border.c: e_border_show(2088) > BD_SHOW(0x02800002)
06-13 15:04:38.097+0900 D/APP_CORE( 6853): appcore.c: __aul_handler(587) > [APP 6853]     AUL event: AUL_START
06-13 15:04:38.097+0900 I/APP_CORE( 6853): appcore-efl.c: __do_app(496) > [APP 6853] Event: RESET State: CREATED
06-13 15:04:38.097+0900 D/APP_CORE( 6853): appcore-efl.c: __do_app(527) > [APP 6853] RESET
06-13 15:04:38.097+0900 D/LAUNCH  ( 6853): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
06-13 15:04:38.097+0900 D/APP_CORE( 6853): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-13 15:04:38.097+0900 D/APP_CORE( 6853): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-13 15:04:38.097+0900 I/CAPI_APPFW_APPLICATION( 6853): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-13 15:04:38.097+0900 D/tag     ( 6853): 왜안돼 ㅠㅠㅠ
06-13 15:04:38.097+0900 D/LAUNCH  ( 6853): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-13 15:04:38.097+0900 D/APP_CORE( 6853): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : org.tizen.homescreen
06-13 15:04:38.097+0900 I/run     ( 6853): socket
06-13 15:04:38.097+0900 I/tag     ( 6853): eonji~
06-13 15:04:38.097+0900 I/run     ( 6853): connect
06-13 15:04:38.097+0900 I/run     ( 6853): new
06-13 15:04:38.097+0900 I/run     ( 6853): send
06-13 15:04:38.097+0900 D/AUL_PAD ( 2910): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-13 15:04:38.097+0900 E/EFL     ( 6853): edje<6853> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 15:04:38.097+0900 E/EFL     ( 6853): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 15:04:38.097+0900 W/AUL     ( 2747): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 6853, appid: org.example.example
06-13 15:04:38.097+0900 D/AUL     ( 2747): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-13 15:04:38.097+0900 E/AUL     ( 2747): simple_util.c: __trm_app_info_send_socket(330) > access
06-13 15:04:38.097+0900 D/AUL_AMD ( 2747): amd_launch.c: _start_app(2700) > add app group info
06-13 15:04:38.097+0900 E/AUL     ( 2747): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-13 15:04:38.097+0900 D/AUL_AMD ( 2747): amd_status.c: _status_add_app_info_list(427) > pid(6853) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-13 15:04:38.097+0900 E/EFL     ( 6853): edje<6853> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 15:04:38.097+0900 E/EFL     ( 6853): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 15:04:38.097+0900 E/EFL     ( 6853): edje<6853> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 15:04:38.097+0900 E/EFL     ( 6853): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 15:04:38.097+0900 E/EFL     ( 6853): edje<6853> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 15:04:38.097+0900 E/EFL     ( 6853): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 15:04:38.097+0900 D/AUL     ( 2863): launch.c: app_request_to_launchpad(425) > launch request result : 6853
06-13 15:04:38.097+0900 E/EFL     ( 6853): edje<6853> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 15:04:38.097+0900 E/EFL     ( 6853): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 15:04:38.097+0900 E/cluster-home( 2863): mainmenu-custom-box-impl.cpp: OnClicked(202) >  Success to launch [0][org.example.example]
06-13 15:04:38.097+0900 D/test-log( 2863): mainmenu-apps-view-impl.cpp: _OnScrollViewTouched(1592) >  Stop boost timer of Apps view by [1]
06-13 15:04:38.097+0900 D/RESOURCED( 2842): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 6853
06-13 15:04:38.097+0900 D/RESOURCED( 2842): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-13 15:04:38.097+0900 E/RESOURCED( 2842): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-13 15:04:38.097+0900 D/RESOURCED( 2842): proc-main.c: resourced_proc_status_change(888) > available memory = 317
06-13 15:04:38.107+0900 W/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=6853
06-13 15:04:38.107+0900 W/APP_CORE( 6853): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2800002
06-13 15:04:38.107+0900 D/APP_CORE( 6853): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2800002
06-13 15:04:38.107+0900 D/APP_CORE( 6853): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-13 15:04:38.107+0900 D/AUL     ( 6853): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-13 15:04:38.107+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(838) > __request_handler: 34
06-13 15:04:38.107+0900 E/EFL     ( 2765): eo<2765> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-13 15:04:38.107+0900 E/EFL     ( 2765): eo<2765> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-13 15:04:38.117+0900 D/INDICATOR( 2846): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
06-13 15:04:38.117+0900 D/INDICATOR( 2846): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-13 15:04:38.117+0900 D/INDICATOR( 2846): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-13 15:04:38.117+0900 D/INDICATOR( 2846): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-13 15:04:38.117+0900 D/INDICATOR( 2846): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-13 15:04:38.117+0900 D/INDICATOR( 2846): main.c: _rotate_window(252) > port :: hide more icon
06-13 15:04:38.117+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(838) > __request_handler: 15
06-13 15:04:38.117+0900 D/PKGMGR_INFO( 2747): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-13 15:04:38.117+0900 D/PKGMGR_INFO( 2747): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-13 15:04:38.117+0900 D/AUL_AMD ( 2747): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 6853 is org.example.example
06-13 15:04:38.117+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 6853 : 0
06-13 15:04:38.117+0900 D/AUL     ( 2934): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-13 15:04:38.167+0900 D/APP_CORE( 6853): appcore.c: __prt_ltime(236) > [APP 6853] first idle after reset: 178 msec
06-13 15:04:38.367+0900 E/E17     ( 2765): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
06-13 15:04:38.367+0900 D/APP_CORE( 6853): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2800002 fully_obscured 0
06-13 15:04:38.367+0900 D/APP_CORE( 2863): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
06-13 15:04:38.367+0900 D/APP_CORE( 2863): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-13 15:04:38.367+0900 D/APP_CORE( 2863): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-13 15:04:38.367+0900 I/APP_CORE( 2863): appcore-efl.c: __do_app(496) > [APP 2863] Event: PAUSE State: RUNNING
06-13 15:04:38.367+0900 D/APP_CORE( 2863): appcore-efl.c: __do_app(565) > [APP 2863] PAUSE
06-13 15:04:38.367+0900 I/CAPI_APPFW_APPLICATION( 2863): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-13 15:04:38.367+0900 E/cluster-home( 2863): homescreen.cpp: OnPause(84) >  app pause
06-13 15:04:38.367+0900 D/cluster-view( 2863): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-13 15:04:38.367+0900 D/cluster-view( 2863): homescreen-view-manager.cpp: AppPause(923) >  END
06-13 15:04:38.367+0900 D/APP_CORE( 2863): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-13 15:04:38.367+0900 E/APP_CORE( 2863): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-13 15:04:38.367+0900 D/APP_CORE( 6853): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-13 15:04:38.367+0900 D/APP_CORE( 6853): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-13 15:04:38.367+0900 I/APP_CORE( 6853): appcore-efl.c: __do_app(496) > [APP 6853] Event: RESUME State: CREATED
06-13 15:04:38.367+0900 D/LAUNCH  ( 6853): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-13 15:04:38.367+0900 D/APP_CORE( 6853): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-13 15:04:38.367+0900 D/APP_CORE( 6853): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-13 15:04:38.367+0900 D/APP_CORE( 6853): appcore-efl.c: __do_app(607) > [APP 6853] RESUME
06-13 15:04:38.367+0900 D/AUL_AMD ( 2747): amd_status.c: _status_update_app_info_list(456) > pid(2863) status(4)
06-13 15:04:38.367+0900 D/AUL_AMD ( 2747): amd_status.c: _status_update_app_info_list(468) > pid(2863) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-13 15:04:38.367+0900 D/AUL     ( 2747): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-13 15:04:38.367+0900 W/AUL     ( 2747): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2863, appid: org.tizen.homescreen, status: bg
06-13 15:04:38.367+0900 D/AUL_AMD ( 2747): amd_launch.c: __e17_status_handler(2891) > pid(6853) status(3)
06-13 15:04:38.367+0900 D/AUL_AMD ( 2747): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-13 15:04:38.367+0900 I/APP_CORE( 6853): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-13 15:04:38.377+0900 I/APP_CORE( 6853): appcore-efl.c: __do_app(614) > [APP 6853] Initial Launching, call the resume_cb
06-13 15:04:38.377+0900 I/CAPI_APPFW_APPLICATION( 6853): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-13 15:04:38.377+0900 D/LAUNCH  ( 6853): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-13 15:04:38.377+0900 D/LAUNCH  ( 6853): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-13 15:04:38.377+0900 D/APP_CORE( 6853): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-13 15:04:38.377+0900 E/APP_CORE( 6853): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-13 15:04:38.377+0900 D/DATA_PROVIDER_MASTER( 2922): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2863 is paused
06-13 15:04:38.377+0900 D/DATA_PROVIDER_MASTER( 2922): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-13 15:04:38.397+0900 D/AUL_AMD ( 2747): amd_launch.c: __e17_status_handler(2897) > back key ungrab
06-13 15:04:38.397+0900 D/AUL_AMD ( 2747): amd_status.c: _status_update_app_info_list(456) > pid(6853) status(3)
06-13 15:04:38.397+0900 D/AUL_AMD ( 2747): amd_status.c: _status_update_app_info_list(468) > pid(6853) appid(org.example.example) pkgid(org.example.example) status(3)
06-13 15:04:38.397+0900 D/AUL     ( 2747): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-13 15:04:38.397+0900 W/AUL     ( 2747): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 6853, appid: org.example.example, status: fg
06-13 15:04:38.397+0900 D/RESOURCED( 2842): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 6853
06-13 15:04:38.397+0900 D/RESOURCED( 2842): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 6853, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-13 15:04:38.397+0900 D/RESOURCED( 2842): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 6853
06-13 15:04:38.457+0900 D/RESOURCED( 2842): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 6853, appname = org.example.example, pkgname = org.example.example
06-13 15:04:38.457+0900 D/RESOURCED( 2842): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 6853, appname = org.example.example
06-13 15:04:38.457+0900 D/RESOURCED( 2842): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 6853
06-13 15:04:38.457+0900 I/RESOURCED( 2842): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-13 15:04:38.457+0900 I/RESOURCED( 2842): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-13 15:04:38.487+0900 D/AUL_AMD ( 2747): amd_launch.c: __e17_status_handler(2910) > pid(6853) status(0)
06-13 15:04:39.097+0900 D/AUL_PAD ( 2910): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-13 15:04:39.097+0900 D/AUL_PAD ( 6907): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-13 15:04:39.117+0900 D/AUL_PAD ( 2910): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-13 15:04:39.117+0900 E/RESOURCED( 2842): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.546
06-13 15:04:39.247+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x40004e bd->visible=0
06-13 15:04:39.597+0900 D/AUL_AMD ( 2747): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-13 15:04:39.597+0900 D/RUA     ( 2747): rua.c: rua_add_history(179) > rua_add_history start
06-13 15:04:39.607+0900 D/RUA     ( 2747): rua.c: rua_add_history(247) > rua_add_history ok
06-13 15:04:40.117+0900 I/service ( 6853): socket
06-13 15:04:40.117+0900 I/example ( 6853): m
06-13 15:04:40.147+0900 D/AUL_PAD ( 6907): launchpad_loader.c: main(588) > sleeping 1 sec...
06-13 15:04:40.147+0900 D/AUL_PAD ( 6907): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-13 15:04:40.157+0900 D/AUL_PAD ( 6907): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b8c14760
06-13 15:04:40.157+0900 D/AUL_PAD ( 6907): preload.h: __preload_init(69) > get pre-initialization function
06-13 15:04:40.157+0900 D/AUL_PAD ( 6907): preload.h: __preload_init(73) > get shutdown function
06-13 15:04:40.157+0900 D/AUL_PAD ( 6907): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b8c14a40
06-13 15:04:40.157+0900 D/AUL_PAD ( 6907): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b8c16640
06-13 15:04:40.157+0900 D/AUL_PAD ( 6907): preload.h: __preload_init(69) > get pre-initialization function
06-13 15:04:40.167+0900 D/AUL_PAD ( 6907): preload.h: __preload_init(73) > get shutdown function
06-13 15:04:40.167+0900 D/AUL_PAD ( 6907): preexec.h: __preexec_init(76) > preexec start
06-13 15:04:40.167+0900 D/AUL_PAD ( 6907): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-13 15:04:40.167+0900 D/AUL     ( 6907): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-13 15:04:40.167+0900 D/AUL     ( 6907): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-13 15:04:40.167+0900 D/AUL     ( 6907): process_pool.c: __connect_to_launchpad(132) > send(6907) : 4
06-13 15:04:40.167+0900 D/AUL_PAD ( 2910): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-13 15:04:40.167+0900 D/AUL_PAD ( 2910): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-13 15:04:40.167+0900 D/AUL_PAD ( 2910): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-13 15:04:40.167+0900 D/AUL_PAD ( 2910): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-13 15:04:40.167+0900 D/AUL_PAD ( 2910): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-13 15:04:40.167+0900 D/AUL_PAD ( 2910): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-13 15:04:40.167+0900 D/AUL_PAD ( 2910): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-13 15:04:40.167+0900 D/AUL_PAD ( 2910): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-13 15:04:40.167+0900 D/AUL_PAD ( 2910): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 6907
06-13 15:04:40.167+0900 D/AUL     ( 6907): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-13 15:04:40.227+0900 D/AUL_PAD ( 6907): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-13 15:04:40.237+0900 D/AUL_PAD ( 6907): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-13 15:04:40.237+0900 D/AUL_PAD ( 6907): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-13 15:04:40.237+0900 D/AUL_PAD ( 6907): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-13 15:04:40.237+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x401389 
06-13 15:04:41.247+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2800002
06-13 15:04:41.377+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 15:04:41.377+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 15:04:41.377+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 15:04:41.377+0900 E/INDICATOR( 2846): 
06-13 15:04:43.377+0900 D/APP_CORE( 2863): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
06-13 15:04:43.377+0900 I/APP_CORE( 2863): appcore-efl.c: __do_app(496) > [APP 2863] Event: MEM_FLUSH State: PAUSED
06-13 15:04:43.377+0900 D/APP_CORE( 2863): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
06-13 15:04:43.377+0900 D/APP_CORE( 2863): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2863
06-13 15:04:43.377+0900 D/APP_CORE( 2863): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
06-13 15:04:43.377+0900 D/RESOURCED( 2842): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2863
06-13 15:04:43.897+0900 I/service ( 6853): socket
06-13 15:04:43.897+0900 I/example ( 6853): m
06-13 15:04:44.027+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x401389 
06-13 15:04:46.247+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x401389 bd->visible=1
06-13 15:04:48.427+0900 I/service ( 6853): socket
06-13 15:04:48.427+0900 I/example ( 6853): m
06-13 15:04:48.547+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x401389 
06-13 15:04:54.147+0900 I/tag     ( 6853): here
06-13 15:04:54.147+0900 I/tag     ( 6853): receive: feedn
06-13 15:04:54.227+0900 E/EFL     ( 2765): eo<2765> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-13 15:04:54.227+0900 D/AUL_PAD ( 2910): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-13 15:04:54.227+0900 D/AUL_PAD ( 2910): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-13 15:04:54.227+0900 D/AUL_PAD ( 2910): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-13 15:04:54.227+0900 D/AUL_PAD ( 2910): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-13 15:04:54.227+0900 D/AUL_PAD ( 2910): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-13 15:04:54.227+0900 D/AUL_PAD ( 2910): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-13 15:04:54.227+0900 D/AUL_PAD ( 2910): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-13 15:04:54.227+0900 I/AUL_PAD ( 2910): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 6853 pgid = 6853
06-13 15:04:54.227+0900 W/CRASH_MANAGER( 6909): worker.c: worker_job(1204) > 1106853657861149733389
