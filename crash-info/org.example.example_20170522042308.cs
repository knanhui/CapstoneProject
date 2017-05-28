S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 8834
Date: 2017-05-22 04:23:08+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8000aa56

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb85b1b70, esi = 0x8000aa56
ebp = 0xbf93d758, esp = 0xbf93d710
eax = 0x80055aaf, ebx = 0xb37e1000
ecx = 0x8000aa56, edx = 0x00000110
eip = 0xb37dc1c6

Memory Information
MemTotal:      123 KB
MemFree:        29 KB
Buffers:         6 KB
Cached:     167368 KB
VmPeak:     113496 KB
VmSize:     113496 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25512 KB
VmRSS:       25512 KB
VmData:      44912 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33576 KB
VmPTE:          92 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 8834 TID = 8834
8834 8835 9054 9055 9059 

Maps Information
b2c80000 b2c8a000 r-xp /usr/lib/libfeedback.so.0.1.4
b2c90000 b2c9c000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2c9d000 b2cbe000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2cc3000 b2cc4000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2cc5000 b2cca000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2ccb000 b2ccd000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2cce000 b2cd0000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2cd1000 b2cdd000 r-xp /usr/lib/libdrm.so.2.4.0
b2cde000 b2ce8000 r-xp /usr/lib/libtbm.so.1.0.0
b2ce9000 b2cfe000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2cff000 b2d11000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3513000 b351c000 r-xp /usr/lib/libeventsystem.so.0.0.1
b351d000 b3526000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3527000 b3539000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b353a000 b355b000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b3562000 b3563000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3564000 b3565000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3566000 b3569000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b356a000 b356d000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3675000 b367b000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b367c000 b37c0000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37d0000 b37d1000 r-xp /usr/lib/libxshmfence.so.1.0.0
b37d2000 b37d5000 r-xp /usr/lib/libdri2.so.0.0.0
b37d6000 b37d7000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37d8000 b37e0000 r-xp /opt/usr/apps/org.example.example/bin/example
b37e2000 b381b000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b421e000 b4229000 r-xp /lib/libnss_files-2.20-2014.11.so
b422b000 b4236000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4238000 b424f000 r-xp /lib/libnsl-2.20-2014.11.so
b4253000 b425b000 r-xp /lib/libnss_compat-2.20-2014.11.so
b425d000 b4281000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4282000 b4283000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4284000 b4287000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4288000 b428f000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4290000 b429a000 r-xp /usr/lib/libsensord-share.so
b429b000 b42b7000 r-xp /usr/lib/libsensor.so.1.2.0
b42b9000 b42c2000 r-xp /usr/lib/libappcore-common.so.1.1
b42c5000 b42c7000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42dc000 b42de000 r-xp /usr/lib/libXau.so.6.0.0
b42df000 b4301000 r-xp /usr/lib/libxcb.so.1.1.0
b4303000 b430c000 r-xp /lib/libcrypt-2.20-2014.11.so
b4335000 b4337000 r-xp /usr/lib/libiri.so
b4338000 b435e000 r-xp /lib/libexpat.so.1.5.2
b4360000 b43cb000 r-xp /usr/lib/libssl.so.1.0.0
b43d1000 b43dd000 r-xp /usr/lib/libethumb.so.1.13.0
b43de000 b43e2000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43e3000 b4634000 r-xp /usr/lib/libcrypto.so.1.0.0
b5baf000 b5bbf000 r-xp /usr/lib/libXi.so.6.1.0
b5bc0000 b5bc2000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bc3000 b5bc9000 r-xp /usr/lib/libXtst.so.6.1.0
b5bca000 b5bd4000 r-xp /usr/lib/libXrender.so.1.3.0
b5bd5000 b5bde000 r-xp /usr/lib/libXrandr.so.2.2.0
b5be0000 b5be2000 r-xp /usr/lib/libXinerama.so.1.0.0
b5be3000 b5be8000 r-xp /usr/lib/libXfixes.so.3.1.0
b5be9000 b5bfb000 r-xp /usr/lib/libXext.so.6.4.0
b5bfc000 b5bfe000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bff000 b5c01000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c03000 b5d45000 r-xp /usr/lib/libX11.so.6.3.0
b5d49000 b5d53000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d54000 b5d6a000 r-xp /usr/lib/libudev.so.1.6.0
b5d6d000 b5d71000 r-xp /lib/libattr.so.1.1.0
b5d72000 b5da1000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5da3000 b5da9000 r-xp /usr/lib/libffi.so.6.0.2
b5daa000 b5dcd000 r-xp /lib/libz.so.1.2.8
b5dce000 b5dd1000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5dd2000 b5f2e000 r-xp /usr/lib/libxml2.so.2.9.2
b5f34000 b601b000 r-xp /usr/lib/libstdc++.so.6.0.20
b6028000 b602b000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b602c000 b604e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b604f000 b6063000 r-xp /lib/libresolv-2.20-2014.11.so
b6067000 b608b000 r-xp /usr/lib/liblzma.so.5.0.3
b608c000 b608e000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6090000 b609a000 r-xp /usr/lib/libembryo.so.1.13.0
b609b000 b60c4000 r-xp /usr/lib/libpng12.so.0.50.0
b60c5000 b610e000 r-xp /usr/lib/libjpeg.so.8.0.2
b611f000 b6126000 r-xp /lib/librt-2.20-2014.11.so
b6128000 b6147000 r-xp /usr/lib/libector.so.1.13.0
b614a000 b6177000 r-xp /usr/lib/liblua-5.1.so
b6178000 b6208000 r-xp /usr/lib/libfreetype.so.6.11.3
b620c000 b624a000 r-xp /usr/lib/libfontconfig.so.1.8.0
b624b000 b6261000 r-xp /usr/lib/libfribidi.so.0.3.1
b6262000 b62bb000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62be000 b6309000 r-xp /lib/libm-2.20-2014.11.so
b630b000 b631d000 r-xp /usr/lib/libeio.so.1.13.0
b631e000 b6321000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6322000 b6328000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6329000 b634c000 r-xp /usr/lib/libefreet.so.1.13.0
b634f000 b637a000 r-xp /usr/lib/libeldbus.so.1.13.0
b637b000 b63af000 r-xp /usr/lib/libecore_con.so.1.13.0
b63b1000 b63ba000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63bb000 b63c4000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63c5000 b63d8000 r-xp /usr/lib/libeo.so.1.13.0
b63da000 b63ed000 r-xp /usr/lib/libecore_input.so.1.13.0
b63ee000 b63f5000 r-xp /usr/lib/libecore_file.so.1.13.0
b63f6000 b6419000 r-xp /usr/lib/libecore_evas.so.1.13.0
b641a000 b6446000 r-xp /usr/lib/libeet.so.1.13.0
b644f000 b64ba000 r-xp /usr/lib/libeina.so.1.13.0
b64bd000 b64d4000 r-xp /usr/lib/libefl.so.1.13.0
b64d6000 b663d000 r-xp /usr/lib/libicuuc.so.51.1
b664b000 b6857000 r-xp /usr/lib/libicui18n.so.51.1
b685f000 b68ae000 r-xp /usr/lib/libecore_x.so.1.13.0
b68b0000 b68ca000 r-xp /lib/libgcc_s-4.9.so.1
b68cc000 b68d0000 r-xp /lib/libcap.so.2.21
b68d1000 b6917000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6918000 b691f000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6921000 b6973000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6975000 b6b00000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b05000 b6bd3000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bd6000 b6bda000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bdb000 b6bea000 r-xp /usr/lib/libvconf.so.0.2.45
b6beb000 b6bee000 r-xp /usr/lib/libvasum.so.0.3.1
b6bef000 b6bf2000 r-xp /usr/lib/libttrace.so.1.1
b6bf4000 b6bf8000 r-xp /usr/lib/libiniparser.so.0
b6bf9000 b6c29000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c2a000 b6c33000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c34000 b6c59000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c5a000 b6c6a000 r-xp /usr/lib/libunwind.so.8.0.1
b6c74000 b6e22000 r-xp /lib/libc-2.20-2014.11.so
b6e2a000 b6f6d000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f6f000 b6fc7000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fc8000 b6ffc000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fff000 b70d3000 r-xp /usr/lib/libedje.so.1.13.0
b70d6000 b7102000 r-xp /usr/lib/libecore.so.1.13.0
b7113000 b7339000 r-xp /usr/lib/libevas.so.1.13.0
b7361000 b7379000 r-xp /lib/libpthread-2.20-2014.11.so
b737d000 b76f7000 r-xp /usr/lib/libelementary.so.1.13.0
b7717000 b771b000 r-xp /usr/lib/libsmack.so.1.0.0
b771c000 b7725000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7726000 b7729000 r-xp /usr/lib/libdlog.so.0.0.0
b772a000 b772f000 r-xp /usr/lib/libbundle.so.0.1.22
b7730000 b7733000 r-xp /lib/libdl-2.20-2014.11.so
b7735000 b775a000 r-xp /usr/lib/libaul.so.0.1.0
b775d000 b775f000 r-xp /usr/lib/libappsvc.so.0.1.0
b7760000 b7765000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7766000 b776d000 r-xp /usr/lib/libappcore-efl.so.1.1
b776f000 b7774000 r-xp /usr/lib/libsys-assert.so
b7777000 b7778000 r-xp [vdso]
b7778000 b779a000 r-xp /lib/ld-2.20-2014.11.so
b779c000 b77a4000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:8834)
Call Stack Count: 21
 0: make_popup_time + 0x46 (0xb37dc1c6) [/opt/usr/apps/org.example.example/bin/example] + 0x41c6
 1: (0xb719c116) [/usr/lib/libevas.so.1] + 0x89116
 2: (0xb63d3319) [/usr/lib/libeo.so.1] + 0xe319
 3: eo_event_callback_call + 0xb3 (0xb63d0d63) [/usr/lib/libeo.so.1] + 0xbd63
 4: evas_object_smart_callback_call + 0x75 (0xb719e9e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 5: (0xb744f404) [/usr/lib/libelementary.so.1] + 0xd2404
 6: (0xb7082f39) [/usr/lib/libedje.so.1] + 0x83f39
 7: (0xb7089a11) [/usr/lib/libedje.so.1] + 0x8aa11
 8: (0xb7083fdc) [/usr/lib/libedje.so.1] + 0x84fdc
 9: (0xb70844cb) [/usr/lib/libedje.so.1] + 0x854cb
10: (0xb708468f) [/usr/lib/libedje.so.1] + 0x8568f
11: (0xb70e9702) [/usr/lib/libecore.so.1] + 0x13702
12: (0xb70e3055) [/usr/lib/libecore.so.1] + 0xd055
13: (0xb70ec1b9) [/usr/lib/libecore.so.1] + 0x161b9
14: ecore_main_loop_begin + 0x57 (0xb70ec587) [/usr/lib/libecore.so.1] + 0x16587
15: elm_run + 0x2d (0xb754522d) [/usr/lib/libelementary.so.1] + 0x1c822d
16: appcore_efl_main + 0x4de (0xb7769dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
17: ui_app_main + 0x140 (0xb7762c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
18: main + 0x27e (0xb37dcc0e) [/opt/usr/apps/org.example.example/bin/example] + 0x4c0e
19: time2string + 0x68 (0xb779e148) [/opt/usr/apps/org.example.example/bin/example] + 0xb779e148
20: __libc_start_main + 0xde (0xb6c8be4e) [/lib/libc.so.6] + 0x17e4e
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
ib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-22 04:23:03.967+0900 E/EFL     ( 8834): By the power of Grayskull, your previous Embryo stack is now broken!
05-22 04:23:03.967+0900 E/EFL     ( 8834): edje<8834> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-22 04:23:03.967+0900 E/EFL     ( 8834): By the power of Grayskull, your previous Embryo stack is now broken!
05-22 04:23:03.967+0900 E/EFL     ( 8834): edje<8834> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-22 04:23:03.967+0900 E/EFL     ( 8834): By the power of Grayskull, your previous Embryo stack is now broken!
05-22 04:23:03.967+0900 E/EFL     ( 8834): edje<8834> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-22 04:23:03.967+0900 E/EFL     ( 8834): By the power of Grayskull, your previous Embryo stack is now broken!
05-22 04:23:03.967+0900 E/EFL     ( 8834): edje<8834> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-22 04:23:03.967+0900 E/EFL     ( 8834): By the power of Grayskull, your previous Embryo stack is now broken!
05-22 04:23:03.997+0900 W/APP_CORE( 8834): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2a00002
05-22 04:23:03.997+0900 D/APP_CORE( 8834): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2a00002
05-22 04:23:03.997+0900 D/APP_CORE( 8834): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
05-22 04:23:03.997+0900 D/AUL     ( 8834): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
05-22 04:23:03.997+0900 D/AUL_AMD ( 2774): amd_request.c: __request_handler(838) > __request_handler: 34
05-22 04:23:03.997+0900 W/PROCESSMGR( 2775): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=8834
05-22 04:23:04.007+0900 E/EFL     ( 2775): eo<2775> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-22 04:23:04.007+0900 E/EFL     ( 2775): eo<2775> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-22 04:23:04.027+0900 D/INDICATOR( 2882): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
05-22 04:23:04.027+0900 D/INDICATOR( 2882): util.c: util_signal_emit_by_win(116) > emission bg.opaque
05-22 04:23:04.027+0900 D/INDICATOR( 2882): main.c: _rotate_window(229) > Indicator angle is 0 degree
05-22 04:23:04.027+0900 D/INDICATOR( 2882): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
05-22 04:23:04.027+0900 D/INDICATOR( 2882): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
05-22 04:23:04.027+0900 D/INDICATOR( 2882): main.c: _rotate_window(252) > port :: hide more icon
05-22 04:23:04.027+0900 D/AUL_AMD ( 2774): amd_request.c: __request_handler(838) > __request_handler: 15
05-22 04:23:04.027+0900 D/PKGMGR_INFO( 2774): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-22 04:23:04.027+0900 D/PKGMGR_INFO( 2774): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-22 04:23:04.027+0900 D/AUL_AMD ( 2774): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 8834 is org.example.example
05-22 04:23:04.027+0900 D/AUL_AMD ( 2774): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 8834 : 0
05-22 04:23:04.027+0900 D/AUL     ( 3004): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
05-22 04:23:04.307+0900 D/APP_CORE( 8834): appcore.c: __prt_ltime(236) > [APP 8834] first idle after reset: 591 msec
05-22 04:23:04.477+0900 E/E17     ( 2775): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
05-22 04:23:04.487+0900 D/APP_CORE( 2900): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
05-22 04:23:04.487+0900 D/APP_CORE( 8834): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2a00002 fully_obscured 0
05-22 04:23:04.487+0900 D/APP_CORE( 2900): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
05-22 04:23:04.487+0900 D/APP_CORE( 2900): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
05-22 04:23:04.487+0900 I/APP_CORE( 2900): appcore-efl.c: __do_app(496) > [APP 2900] Event: PAUSE State: RUNNING
05-22 04:23:04.487+0900 D/APP_CORE( 2900): appcore-efl.c: __do_app(565) > [APP 2900] PAUSE
05-22 04:23:04.487+0900 I/CAPI_APPFW_APPLICATION( 2900): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
05-22 04:23:04.487+0900 E/cluster-home( 2900): homescreen.cpp: OnPause(84) >  app pause
05-22 04:23:04.487+0900 D/APP_CORE( 8834): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
05-22 04:23:04.487+0900 D/APP_CORE( 8834): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
05-22 04:23:04.487+0900 I/APP_CORE( 8834): appcore-efl.c: __do_app(496) > [APP 8834] Event: RESUME State: CREATED
05-22 04:23:04.487+0900 D/LAUNCH  ( 8834): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
05-22 04:23:04.487+0900 D/APP_CORE( 8834): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
05-22 04:23:04.487+0900 D/APP_CORE( 8834): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-22 04:23:04.487+0900 D/APP_CORE( 8834): appcore-efl.c: __do_app(607) > [APP 8834] RESUME
05-22 04:23:04.487+0900 D/cluster-view( 2900): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
05-22 04:23:04.487+0900 D/cluster-view( 2900): homescreen-view-manager.cpp: AppPause(923) >  END
05-22 04:23:04.487+0900 D/APP_CORE( 2900): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-22 04:23:04.487+0900 E/APP_CORE( 2900): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-22 04:23:04.497+0900 D/AUL_AMD ( 2774): amd_status.c: _status_update_app_info_list(456) > pid(2900) status(4)
05-22 04:23:04.497+0900 D/AUL_AMD ( 2774): amd_status.c: _status_update_app_info_list(468) > pid(2900) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
05-22 04:23:04.497+0900 D/AUL     ( 2774): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
05-22 04:23:04.497+0900 W/AUL     ( 2774): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2900, appid: org.tizen.homescreen, status: bg
05-22 04:23:04.497+0900 D/AUL_AMD ( 2774): amd_launch.c: __e17_status_handler(2891) > pid(8834) status(3)
05-22 04:23:04.497+0900 D/AUL_AMD ( 2774): amd_key.c: _key_ungrab(265) > _key_ungrab, win : 800002
05-22 04:23:04.497+0900 I/APP_CORE( 8834): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
05-22 04:23:04.497+0900 I/APP_CORE( 8834): appcore-efl.c: __do_app(614) > [APP 8834] Initial Launching, call the resume_cb
05-22 04:23:04.497+0900 I/CAPI_APPFW_APPLICATION( 8834): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
05-22 04:23:04.497+0900 D/LAUNCH  ( 8834): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
05-22 04:23:04.497+0900 D/LAUNCH  ( 8834): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
05-22 04:23:04.497+0900 D/APP_CORE( 8834): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-22 04:23:04.497+0900 E/APP_CORE( 8834): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-22 04:23:04.507+0900 W/AUL_AMD ( 2774): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-22 04:23:04.507+0900 W/AUL_AMD ( 2774): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
05-22 04:23:04.507+0900 D/AUL_AMD ( 2774): amd_status.c: _status_update_app_info_list(456) > pid(8834) status(3)
05-22 04:23:04.507+0900 D/AUL_AMD ( 2774): amd_status.c: _status_update_app_info_list(468) > pid(8834) appid(org.example.example) pkgid(org.example.example) status(3)
05-22 04:23:04.507+0900 D/AUL     ( 2774): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
05-22 04:23:04.507+0900 W/AUL     ( 2774): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 8834, appid: org.example.example, status: fg
05-22 04:23:04.507+0900 D/DATA_PROVIDER_MASTER( 2965): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2900 is paused
05-22 04:23:04.507+0900 D/DATA_PROVIDER_MASTER( 2965): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
05-22 04:23:04.507+0900 D/RESOURCED( 2878): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 8834
05-22 04:23:04.507+0900 I/CAPI_WIDGET_APPLICATION( 3012): widget_app.c: __provider_pause_cb(294) > widget obj was paused
05-22 04:23:04.507+0900 I/CAPI_WIDGET_APPLICATION( 3012): widget_app.c: __check_status_for_cgroup(142) > enter background group
05-22 04:23:04.507+0900 W/AUL     ( 3012): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3012, appid: org.tizen.calendar.widget, status: bg
05-22 04:23:04.507+0900 D/RESOURCED( 2878): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 8834, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
05-22 04:23:04.507+0900 D/RESOURCED( 2878): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 8834
05-22 04:23:04.557+0900 D/AUL_AMD ( 2774): amd_launch.c: __e17_status_handler(2910) > pid(8834) status(0)
05-22 04:23:04.577+0900 D/RESOURCED( 2878): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 8834, appname = org.example.example, pkgname = org.example.example
05-22 04:23:04.577+0900 D/RESOURCED( 2878): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 8834, appname = org.example.example
05-22 04:23:04.577+0900 D/RESOURCED( 2878): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 8834
05-22 04:23:04.577+0900 D/RESOURCED( 2878): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3012, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
05-22 04:23:04.577+0900 D/RESOURCED( 2878): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3012
05-22 04:23:04.577+0900 D/RESOURCED( 2878): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3012, appname = org.tizen.calendar.widget
05-22 04:23:04.577+0900 D/RESOURCED( 2878): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3012
05-22 04:23:04.577+0900 I/RESOURCED( 2878): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
05-22 04:23:04.577+0900 I/RESOURCED( 2878): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
05-22 04:23:04.837+0900 D/AUL_PAD ( 2961): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
05-22 04:23:04.837+0900 D/AUL_PAD ( 9057): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
05-22 04:23:04.847+0900 D/AUL_PAD ( 2961): sigchild.h: __send_app_launch_signal(131) > send launch signal done
05-22 04:23:04.857+0900 E/RESOURCED( 2878): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.573
05-22 04:23:05.337+0900 D/AUL_AMD ( 2774): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
05-22 04:23:05.337+0900 D/RUA     ( 2774): rua.c: rua_add_history(179) > rua_add_history start
05-22 04:23:05.357+0900 D/RUA     ( 2774): rua.c: rua_add_history(247) > rua_add_history ok
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.777+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.787+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.797+0900 E/EFL     ( 8834): evas_main<8834> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800385c3 is not stable during recalc loop
05-22 04:23:05.857+0900 D/PROCESSMGR( 2775): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400e51 
05-22 04:23:05.867+0900 D/AUL_PAD ( 9057): launchpad_loader.c: main(588) > sleeping 1 sec...
05-22 04:23:05.867+0900 D/AUL_PAD ( 9057): preload.h: __preload_init(52) > max_cmdline_size = 1053
05-22 04:23:05.877+0900 D/AUL_PAD ( 9057): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b86e8760
05-22 04:23:05.877+0900 D/AUL_PAD ( 9057): preload.h: __preload_init(69) > get pre-initialization function
05-22 04:23:05.877+0900 D/AUL_PAD ( 9057): preload.h: __preload_init(73) > get shutdown function
05-22 04:23:05.877+0900 D/AUL_PAD ( 9057): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b86e8a40
05-22 04:23:05.887+0900 D/AUL_PAD ( 9057): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b86ea640
05-22 04:23:05.887+0900 D/AUL_PAD ( 9057): preload.h: __preload_init(69) > get pre-initialization function
05-22 04:23:05.887+0900 D/AUL_PAD ( 9057): preload.h: __preload_init(73) > get shutdown function
05-22 04:23:05.887+0900 D/AUL_PAD ( 9057): preexec.h: __preexec_init(76) > preexec start
05-22 04:23:05.887+0900 D/AUL_PAD ( 9057): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
05-22 04:23:05.887+0900 D/AUL     ( 9057): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
05-22 04:23:05.887+0900 D/AUL     ( 9057): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
05-22 04:23:05.887+0900 D/AUL_PAD ( 2961): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-22 04:23:05.887+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
05-22 04:23:05.887+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-22 04:23:05.887+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-22 04:23:05.887+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-22 04:23:05.887+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-22 04:23:05.887+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-22 04:23:05.887+0900 D/AUL_PAD ( 2961): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
05-22 04:23:05.887+0900 D/AUL_PAD ( 2961): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 9057
05-22 04:23:05.887+0900 D/AUL     ( 9057): process_pool.c: __connect_to_launchpad(132) > send(9057) : 4
05-22 04:23:05.887+0900 D/AUL     ( 9057): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
05-22 04:23:06.147+0900 D/AUL_PAD ( 9057): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
05-22 04:23:06.157+0900 D/AUL_PAD ( 9057): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
05-22 04:23:06.157+0900 D/AUL_PAD ( 9057): launchpad_loader.c: main(693) > [candidate] ecore handler add
05-22 04:23:06.167+0900 D/AUL_PAD ( 9057): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
05-22 04:23:06.867+0900 D/PROCESSMGR( 2775): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2a00002
05-22 04:23:06.947+0900 D/RESOURCED( 2878): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
05-22 04:23:06.947+0900 I/RESOURCED( 2878): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
05-22 04:23:06.947+0900 D/RESOURCED( 2878): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
05-22 04:23:06.947+0900 I/RESOURCED( 2878): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
05-22 04:23:07.727+0900 D/PROCESSMGR( 2775): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400e51 
05-22 04:23:07.837+0900 E/EFL     ( 8834): edje<8834> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p15';
05-22 04:23:07.837+0900 E/EFL     ( 8834): By the power of Grayskull, your previous Embryo stack is now broken!
05-22 04:23:08.257+0900 E/EFL     ( 2775): eo<2775> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-22 04:23:08.257+0900 D/AUL_PAD ( 2961): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-22 04:23:08.257+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
05-22 04:23:08.257+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-22 04:23:08.257+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-22 04:23:08.257+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-22 04:23:08.257+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-22 04:23:08.257+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-22 04:23:08.257+0900 I/AUL_PAD ( 2961): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 8834 pgid = 8834
05-22 04:23:08.257+0900 I/AUL_PAD ( 2961): sigchild.h: __sigchild_action(142) > dead_pid(8834)
05-22 04:23:08.277+0900 D/AUL_PAD ( 2961): sigchild.h: __send_app_dead_signal(90) > send dead signal done
05-22 04:23:08.277+0900 I/AUL_PAD ( 2961): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
05-22 04:23:08.277+0900 I/AUL_PAD ( 2961): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
05-22 04:23:08.277+0900 E/AUL_PAD ( 2961): launchpad.c: main(688) > error reading sigchld info
05-22 04:23:08.277+0900 I/ESD     ( 2998): esd_main.c: __esd_app_dead_handler(1771) > pid: 8834
05-22 04:23:08.287+0900 D/STARTER ( 2875): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 8834 is termianted
05-22 04:23:08.287+0900 W/AUL_AMD ( 2774): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 8834
05-22 04:23:08.287+0900 D/STARTER ( 2875): starter.c: _check_dead_signal(202) > [_check_dead_signal:202] Unknown process, ignore it
05-22 04:23:08.287+0900 W/AUL_AMD ( 2774): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 8834
05-22 04:23:08.287+0900 D/AUL_AMD ( 2774): amd_key.c: _unregister_key_event(179) > ===key stack===
05-22 04:23:08.287+0900 E/AUL_AMD ( 2774): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
05-22 04:23:08.287+0900 D/AUL_AMD ( 2774): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.example.example)
05-22 04:23:08.287+0900 D/AUL     ( 2774): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
05-22 04:23:08.287+0900 E/AUL     ( 2774): simple_util.c: __trm_app_info_send_socket(330) > access
05-22 04:23:08.297+0900 E/RESOURCED( 2878): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.578
05-22 04:23:08.307+0900 D/RESOURCED( 2878): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 8834
05-22 04:23:08.307+0900 D/RESOURCED( 2878): appinfo-list.c: resourced_appinfo_put(132) > appid org.example.example, pkgname = org.example.example, ref = 0
05-22 04:23:08.307+0900 D/AUL_AMD ( 2774): amd_launch.c: __e17_status_handler(2891) > pid(2900) status(3)
05-22 04:23:08.307+0900 D/AUL_AMD ( 2774): amd_key.c: _key_ungrab(265) > _key_ungrab, win : 800002
05-22 04:23:08.307+0900 E/E17     ( 2775): e_border.c: e_border_show(2088) > BD_SHOW(0x01600002)
05-22 04:23:08.317+0900 W/AUL_AMD ( 2774): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-22 04:23:08.317+0900 W/AUL_AMD ( 2774): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
05-22 04:23:08.317+0900 D/AUL_AMD ( 2774): amd_status.c: _status_update_app_info_list(456) > pid(2900) status(3)
05-22 04:23:08.317+0900 D/AUL_AMD ( 2774): amd_status.c: _status_update_app_info_list(468) > pid(2900) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(3)
05-22 04:23:08.317+0900 D/AUL     ( 2774): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.tizen.homescreen
05-22 04:23:08.317+0900 W/AUL     ( 2774): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2900, appid: org.tizen.homescreen, status: fg
05-22 04:23:08.317+0900 D/RESOURCED( 2878): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2900
05-22 04:23:08.317+0900 D/RESOURCED( 2878): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 2900, appname = org.tizen.homescreen, pkgname = org.tizen.homescreen
05-22 04:23:08.317+0900 D/RESOURCED( 2878): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2900, appname = org.tizen.homescreen
05-22 04:23:08.317+0900 D/RESOURCED( 2878): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2900
05-22 04:23:08.327+0900 W/CRASH_MANAGER( 9060): worker.c: worker_job(1204) > 1108834657861149539458
