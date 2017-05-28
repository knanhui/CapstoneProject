S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 12576
Date: 2017-05-22 06:03:22+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8000aa56

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000000, esi = 0x8000aa56
ebp = 0xbfdc6688, esp = 0xbfdc6570
eax = 0x8000aa56, ebx = 0xb37e3000
ecx = 0x00000040, edx = 0xbfdc6670
eip = 0xb37de728

Memory Information
MemTotal:      123 KB
MemFree:        26 KB
Buffers:         7 KB
Cached:     169104 KB
VmPeak:     122248 KB
VmSize:     122248 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       35784 KB
VmRSS:       35784 KB
VmData:      53248 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33744 KB
VmPTE:         104 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 12576 TID = 12576
12576 12577 12802 12803 12807 

Maps Information
b0f09000 b0f21000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b190b000 b1912000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b1915000 b191c000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b191d000 b1921000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2c82000 b2c8c000 r-xp /usr/lib/libfeedback.so.0.1.4
b2c92000 b2c9e000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2c9f000 b2cc0000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2cc5000 b2cc6000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2cc7000 b2ccc000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2ccd000 b2ccf000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2cd0000 b2cd2000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2cd3000 b2cdf000 r-xp /usr/lib/libdrm.so.2.4.0
b2ce0000 b2cea000 r-xp /usr/lib/libtbm.so.1.0.0
b2ceb000 b2d00000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2d01000 b2d13000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3515000 b351e000 r-xp /usr/lib/libeventsystem.so.0.0.1
b351f000 b3528000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3529000 b353b000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b353c000 b355d000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b3564000 b3565000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3566000 b3567000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3568000 b356b000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b356c000 b356f000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3677000 b367d000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b367e000 b37c2000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37d2000 b37d3000 r-xp /usr/lib/libxshmfence.so.1.0.0
b37d4000 b37d7000 r-xp /usr/lib/libdri2.so.0.0.0
b37d8000 b37d9000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37da000 b37e2000 r-xp /opt/usr/apps/org.example.example/bin/example
b37e4000 b381d000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4220000 b422b000 r-xp /lib/libnss_files-2.20-2014.11.so
b422d000 b4238000 r-xp /lib/libnss_nis-2.20-2014.11.so
b423a000 b4251000 r-xp /lib/libnsl-2.20-2014.11.so
b4255000 b425d000 r-xp /lib/libnss_compat-2.20-2014.11.so
b425f000 b4283000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4284000 b4285000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4286000 b4289000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b428a000 b4291000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4292000 b429c000 r-xp /usr/lib/libsensord-share.so
b429d000 b42b9000 r-xp /usr/lib/libsensor.so.1.2.0
b42bb000 b42c4000 r-xp /usr/lib/libappcore-common.so.1.1
b42c7000 b42c9000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42de000 b42e0000 r-xp /usr/lib/libXau.so.6.0.0
b42e1000 b4303000 r-xp /usr/lib/libxcb.so.1.1.0
b4305000 b430e000 r-xp /lib/libcrypt-2.20-2014.11.so
b4337000 b4339000 r-xp /usr/lib/libiri.so
b433a000 b4360000 r-xp /lib/libexpat.so.1.5.2
b4362000 b43cd000 r-xp /usr/lib/libssl.so.1.0.0
b43d3000 b43df000 r-xp /usr/lib/libethumb.so.1.13.0
b43e0000 b43e4000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43e5000 b4636000 r-xp /usr/lib/libcrypto.so.1.0.0
b5bb1000 b5bc1000 r-xp /usr/lib/libXi.so.6.1.0
b5bc2000 b5bc4000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bc5000 b5bcb000 r-xp /usr/lib/libXtst.so.6.1.0
b5bcc000 b5bd6000 r-xp /usr/lib/libXrender.so.1.3.0
b5bd7000 b5be0000 r-xp /usr/lib/libXrandr.so.2.2.0
b5be2000 b5be4000 r-xp /usr/lib/libXinerama.so.1.0.0
b5be5000 b5bea000 r-xp /usr/lib/libXfixes.so.3.1.0
b5beb000 b5bfd000 r-xp /usr/lib/libXext.so.6.4.0
b5bfe000 b5c00000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c01000 b5c03000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c05000 b5d47000 r-xp /usr/lib/libX11.so.6.3.0
b5d4b000 b5d55000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d56000 b5d6c000 r-xp /usr/lib/libudev.so.1.6.0
b5d6f000 b5d73000 r-xp /lib/libattr.so.1.1.0
b5d74000 b5da3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5da5000 b5dab000 r-xp /usr/lib/libffi.so.6.0.2
b5dac000 b5dcf000 r-xp /lib/libz.so.1.2.8
b5dd0000 b5dd3000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5dd4000 b5f30000 r-xp /usr/lib/libxml2.so.2.9.2
b5f36000 b601d000 r-xp /usr/lib/libstdc++.so.6.0.20
b602a000 b602d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b602e000 b6050000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6051000 b6065000 r-xp /lib/libresolv-2.20-2014.11.so
b6069000 b608d000 r-xp /usr/lib/liblzma.so.5.0.3
b608e000 b6090000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6092000 b609c000 r-xp /usr/lib/libembryo.so.1.13.0
b609d000 b60c6000 r-xp /usr/lib/libpng12.so.0.50.0
b60c7000 b6110000 r-xp /usr/lib/libjpeg.so.8.0.2
b6121000 b6128000 r-xp /lib/librt-2.20-2014.11.so
b612a000 b6149000 r-xp /usr/lib/libector.so.1.13.0
b614c000 b6179000 r-xp /usr/lib/liblua-5.1.so
b617a000 b620a000 r-xp /usr/lib/libfreetype.so.6.11.3
b620e000 b624c000 r-xp /usr/lib/libfontconfig.so.1.8.0
b624d000 b6263000 r-xp /usr/lib/libfribidi.so.0.3.1
b6264000 b62bd000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62c0000 b630b000 r-xp /lib/libm-2.20-2014.11.so
b630d000 b631f000 r-xp /usr/lib/libeio.so.1.13.0
b6320000 b6323000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6324000 b632a000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b632b000 b634e000 r-xp /usr/lib/libefreet.so.1.13.0
b6351000 b637c000 r-xp /usr/lib/libeldbus.so.1.13.0
b637d000 b63b1000 r-xp /usr/lib/libecore_con.so.1.13.0
b63b3000 b63bc000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63bd000 b63c6000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63c7000 b63da000 r-xp /usr/lib/libeo.so.1.13.0
b63dc000 b63ef000 r-xp /usr/lib/libecore_input.so.1.13.0
b63f0000 b63f7000 r-xp /usr/lib/libecore_file.so.1.13.0
b63f8000 b641b000 r-xp /usr/lib/libecore_evas.so.1.13.0
b641c000 b6448000 r-xp /usr/lib/libeet.so.1.13.0
b6451000 b64bc000 r-xp /usr/lib/libeina.so.1.13.0
b64bf000 b64d6000 r-xp /usr/lib/libefl.so.1.13.0
b64d8000 b663f000 r-xp /usr/lib/libicuuc.so.51.1
b664d000 b6859000 r-xp /usr/lib/libicui18n.so.51.1
b6861000 b68b0000 r-xp /usr/lib/libecore_x.so.1.13.0
b68b2000 b68cc000 r-xp /lib/libgcc_s-4.9.so.1
b68ce000 b68d2000 r-xp /lib/libcap.so.2.21
b68d3000 b6919000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b691a000 b6921000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6923000 b6975000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6977000 b6b02000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b07000 b6bd5000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bd8000 b6bdc000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bdd000 b6bec000 r-xp /usr/lib/libvconf.so.0.2.45
b6bed000 b6bf0000 r-xp /usr/lib/libvasum.so.0.3.1
b6bf1000 b6bf4000 r-xp /usr/lib/libttrace.so.1.1
b6bf6000 b6bfa000 r-xp /usr/lib/libiniparser.so.0
b6bfb000 b6c2b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c2c000 b6c35000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c36000 b6c5b000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c5c000 b6c6c000 r-xp /usr/lib/libunwind.so.8.0.1
b6c76000 b6e24000 r-xp /lib/libc-2.20-2014.11.so
b6e2c000 b6f6f000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f71000 b6fc9000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fca000 b6ffe000 r-xp /usr/lib/libsystemd.so.0.4.0
b7001000 b70d5000 r-xp /usr/lib/libedje.so.1.13.0
b70d8000 b7104000 r-xp /usr/lib/libecore.so.1.13.0
b7115000 b733b000 r-xp /usr/lib/libevas.so.1.13.0
b7363000 b737b000 r-xp /lib/libpthread-2.20-2014.11.so
b737f000 b76f9000 r-xp /usr/lib/libelementary.so.1.13.0
b7719000 b771d000 r-xp /usr/lib/libsmack.so.1.0.0
b771e000 b7727000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7728000 b772b000 r-xp /usr/lib/libdlog.so.0.0.0
b772c000 b7731000 r-xp /usr/lib/libbundle.so.0.1.22
b7732000 b7735000 r-xp /lib/libdl-2.20-2014.11.so
b7737000 b775c000 r-xp /usr/lib/libaul.so.0.1.0
b775f000 b7761000 r-xp /usr/lib/libappsvc.so.0.1.0
b7762000 b7767000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7768000 b776f000 r-xp /usr/lib/libappcore-efl.so.1.1
b7771000 b7776000 r-xp /usr/lib/libsys-assert.so
b7779000 b777a000 r-xp [vdso]
b777a000 b779c000 r-xp /lib/ld-2.20-2014.11.so
b779e000 b77a6000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:12576)
Call Stack Count: 21
 0: popup_set_btn_clicked_cb + 0x78 (0xb37de728) [/opt/usr/apps/org.example.example/bin/example] + 0x4728
 1: (0xb719e116) [/usr/lib/libevas.so.1] + 0x89116
 2: (0xb63d5319) [/usr/lib/libeo.so.1] + 0xe319
 3: eo_event_callback_call + 0xb3 (0xb63d2d63) [/usr/lib/libeo.so.1] + 0xbd63
 4: evas_object_smart_callback_call + 0x75 (0xb71a09e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 5: (0xb7451404) [/usr/lib/libelementary.so.1] + 0xd2404
 6: (0xb7084f39) [/usr/lib/libedje.so.1] + 0x83f39
 7: (0xb708ba11) [/usr/lib/libedje.so.1] + 0x8aa11
 8: (0xb7085fdc) [/usr/lib/libedje.so.1] + 0x84fdc
 9: (0xb70864cb) [/usr/lib/libedje.so.1] + 0x854cb
10: (0xb708668f) [/usr/lib/libedje.so.1] + 0x8568f
11: (0xb70eb702) [/usr/lib/libecore.so.1] + 0x13702
12: (0xb70e5055) [/usr/lib/libecore.so.1] + 0xd055
13: (0xb70ee1b9) [/usr/lib/libecore.so.1] + 0x161b9
14: ecore_main_loop_begin + 0x57 (0xb70ee587) [/usr/lib/libecore.so.1] + 0x16587
15: elm_run + 0x2d (0xb754722d) [/usr/lib/libelementary.so.1] + 0x1c822d
16: appcore_efl_main + 0x4de (0xb776bdde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
17: ui_app_main + 0x140 (0xb7764c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
18: main + 0x27e (0xb37def8e) [/opt/usr/apps/org.example.example/bin/example] + 0x4f8e
19: create_time + 0x58 (0xb77a0148) [/opt/usr/apps/org.example.example/bin/example] + 0xb77a0148
20: __libc_start_main + 0xde (0xb6c8de4e) [/lib/libc.so.6] + 0x17e4e
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
it(294) > Interval is updated to 10.000000
05-22 06:03:15.392+0900 E/INDICATOR( 2882): 
05-22 06:03:15.402+0900 E/EFL     ( 2775): eo<2775> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-22 06:03:15.402+0900 E/EFL     ( 2775): eo<2775> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-22 06:03:15.422+0900 D/AUL_AMD ( 2774): amd_request.c: __request_handler(838) > __request_handler: 15
05-22 06:03:15.422+0900 D/INDICATOR( 2882): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
05-22 06:03:15.422+0900 D/PKGMGR_INFO( 2774): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-22 06:03:15.422+0900 D/PKGMGR_INFO( 2774): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-22 06:03:15.422+0900 D/INDICATOR( 2882): util.c: util_signal_emit_by_win(116) > emission bg.opaque
05-22 06:03:15.422+0900 D/INDICATOR( 2882): main.c: _rotate_window(229) > Indicator angle is 0 degree
05-22 06:03:15.422+0900 D/INDICATOR( 2882): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
05-22 06:03:15.422+0900 D/INDICATOR( 2882): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
05-22 06:03:15.422+0900 D/INDICATOR( 2882): main.c: _rotate_window(252) > port :: hide more icon
05-22 06:03:15.422+0900 D/AUL_AMD ( 2774): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 12576 is org.example.example
05-22 06:03:15.422+0900 D/AUL_AMD ( 2774): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 12576 : 0
05-22 06:03:15.432+0900 D/AUL     ( 3004): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
05-22 06:03:15.482+0900 D/APP_CORE(12576): appcore.c: __prt_ltime(236) > [APP 12576] first idle after reset: 410 msec
05-22 06:03:15.492+0900 W/APP_CORE(12576): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2a00002
05-22 06:03:15.492+0900 D/APP_CORE(12576): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2a00002
05-22 06:03:15.492+0900 D/APP_CORE(12576): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
05-22 06:03:15.492+0900 D/AUL     (12576): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
05-22 06:03:15.492+0900 D/AUL_AMD ( 2774): amd_request.c: __request_handler(838) > __request_handler: 34
05-22 06:03:15.822+0900 E/E17     ( 2775): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
05-22 06:03:15.822+0900 D/APP_CORE( 2900): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
05-22 06:03:15.822+0900 D/APP_CORE(12576): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2a00002 fully_obscured 0
05-22 06:03:15.822+0900 D/APP_CORE(12576): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
05-22 06:03:15.822+0900 D/APP_CORE(12576): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
05-22 06:03:15.822+0900 D/APP_CORE( 2900): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
05-22 06:03:15.822+0900 D/APP_CORE( 2900): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
05-22 06:03:15.822+0900 I/APP_CORE( 2900): appcore-efl.c: __do_app(496) > [APP 2900] Event: PAUSE State: RUNNING
05-22 06:03:15.822+0900 D/APP_CORE( 2900): appcore-efl.c: __do_app(565) > [APP 2900] PAUSE
05-22 06:03:15.822+0900 I/CAPI_APPFW_APPLICATION( 2900): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
05-22 06:03:15.822+0900 I/APP_CORE(12576): appcore-efl.c: __do_app(496) > [APP 12576] Event: RESUME State: CREATED
05-22 06:03:15.822+0900 D/LAUNCH  (12576): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
05-22 06:03:15.822+0900 D/APP_CORE(12576): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
05-22 06:03:15.822+0900 D/APP_CORE(12576): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-22 06:03:15.822+0900 D/APP_CORE(12576): appcore-efl.c: __do_app(607) > [APP 12576] RESUME
05-22 06:03:15.822+0900 E/cluster-home( 2900): homescreen.cpp: OnPause(84) >  app pause
05-22 06:03:15.822+0900 D/cluster-view( 2900): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
05-22 06:03:15.822+0900 D/cluster-view( 2900): homescreen-view-manager.cpp: AppPause(923) >  END
05-22 06:03:15.822+0900 D/APP_CORE( 2900): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-22 06:03:15.822+0900 E/APP_CORE( 2900): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-22 06:03:15.822+0900 I/APP_CORE(12576): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
05-22 06:03:15.822+0900 I/APP_CORE(12576): appcore-efl.c: __do_app(614) > [APP 12576] Initial Launching, call the resume_cb
05-22 06:03:15.822+0900 I/CAPI_APPFW_APPLICATION(12576): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
05-22 06:03:15.822+0900 D/LAUNCH  (12576): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
05-22 06:03:15.822+0900 D/LAUNCH  (12576): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
05-22 06:03:15.822+0900 D/APP_CORE(12576): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-22 06:03:15.822+0900 E/APP_CORE(12576): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-22 06:03:15.832+0900 D/AUL_AMD ( 2774): amd_status.c: _status_update_app_info_list(456) > pid(2900) status(4)
05-22 06:03:15.832+0900 D/AUL_AMD ( 2774): amd_status.c: _status_update_app_info_list(468) > pid(2900) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
05-22 06:03:15.832+0900 D/AUL     ( 2774): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
05-22 06:03:15.832+0900 W/AUL     ( 2774): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2900, appid: org.tizen.homescreen, status: bg
05-22 06:03:15.842+0900 D/DATA_PROVIDER_MASTER( 2965): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2900 is paused
05-22 06:03:15.842+0900 D/DATA_PROVIDER_MASTER( 2965): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
05-22 06:03:15.842+0900 I/CAPI_WIDGET_APPLICATION( 3012): widget_app.c: __provider_pause_cb(294) > widget obj was paused
05-22 06:03:15.842+0900 I/CAPI_WIDGET_APPLICATION( 3012): widget_app.c: __check_status_for_cgroup(142) > enter background group
05-22 06:03:15.842+0900 W/AUL     ( 3012): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3012, appid: org.tizen.calendar.widget, status: bg
05-22 06:03:15.842+0900 D/RESOURCED( 2878): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3012, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
05-22 06:03:15.842+0900 D/RESOURCED( 2878): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3012
05-22 06:03:15.842+0900 D/RESOURCED( 2878): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3012, appname = org.tizen.calendar.widget
05-22 06:03:15.842+0900 D/RESOURCED( 2878): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3012
05-22 06:03:15.862+0900 D/AUL_AMD ( 2774): amd_launch.c: __e17_status_handler(2891) > pid(12576) status(3)
05-22 06:03:15.862+0900 D/AUL_AMD ( 2774): amd_key.c: _key_ungrab(265) > _key_ungrab, win : 800002
05-22 06:03:15.862+0900 W/AUL_AMD ( 2774): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-22 06:03:15.862+0900 W/AUL_AMD ( 2774): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
05-22 06:03:15.862+0900 D/AUL_AMD ( 2774): amd_status.c: _status_update_app_info_list(456) > pid(12576) status(3)
05-22 06:03:15.862+0900 D/AUL_AMD ( 2774): amd_status.c: _status_update_app_info_list(468) > pid(12576) appid(org.example.example) pkgid(org.example.example) status(3)
05-22 06:03:15.862+0900 D/AUL     ( 2774): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
05-22 06:03:15.862+0900 W/AUL     ( 2774): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 12576, appid: org.example.example, status: fg
05-22 06:03:15.862+0900 D/RESOURCED( 2878): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 12576
05-22 06:03:15.862+0900 D/RESOURCED( 2878): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 12576, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
05-22 06:03:15.862+0900 D/RESOURCED( 2878): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 12576
05-22 06:03:15.912+0900 D/RESOURCED( 2878): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 12576, appname = org.example.example, pkgname = org.example.example
05-22 06:03:15.922+0900 D/RESOURCED( 2878): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 12576, appname = org.example.example
05-22 06:03:15.922+0900 D/RESOURCED( 2878): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 12576
05-22 06:03:15.922+0900 I/RESOURCED( 2878): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
05-22 06:03:15.922+0900 I/RESOURCED( 2878): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
05-22 06:03:16.102+0900 D/AUL_AMD ( 2774): amd_launch.c: __e17_status_handler(2910) > pid(12576) status(0)
05-22 06:03:16.202+0900 D/AUL_PAD ( 2961): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
05-22 06:03:16.202+0900 D/AUL_PAD (12805): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
05-22 06:03:16.252+0900 D/AUL_PAD ( 2961): sigchild.h: __send_app_launch_signal(131) > send launch signal done
05-22 06:03:16.272+0900 E/RESOURCED( 2878): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.866
05-22 06:03:16.702+0900 D/AUL_AMD ( 2774): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
05-22 06:03:16.702+0900 D/RUA     ( 2774): rua.c: rua_add_history(179) > rua_add_history start
05-22 06:03:16.752+0900 D/RUA     ( 2774): rua.c: rua_add_history(247) > rua_add_history ok
05-22 06:03:17.292+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.292+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.292+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.292+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.292+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.292+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.292+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.292+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.292+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.292+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.292+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.292+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.292+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.292+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.302+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.302+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.302+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.302+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.302+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.302+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.302+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.302+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.302+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.302+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.302+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.302+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.302+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.302+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.302+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.302+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.302+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.302+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.302+0900 D/AUL_PAD (12805): launchpad_loader.c: main(588) > sleeping 1 sec...
05-22 06:03:17.302+0900 D/AUL_PAD (12805): preload.h: __preload_init(52) > max_cmdline_size = 1053
05-22 06:03:17.302+0900 D/AUL_PAD (12805): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b93c7760
05-22 06:03:17.312+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.312+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.312+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.312+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.312+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.312+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.312+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.312+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.312+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.312+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.312+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.312+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.312+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.312+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.312+0900 D/AUL_PAD (12805): preload.h: __preload_init(69) > get pre-initialization function
05-22 06:03:17.312+0900 D/AUL_PAD (12805): preload.h: __preload_init(73) > get shutdown function
05-22 06:03:17.312+0900 D/AUL_PAD (12805): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b93c7a40
05-22 06:03:17.312+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.312+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.312+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.312+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.312+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.312+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.312+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.312+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.312+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.312+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.312+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.312+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.312+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.312+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.322+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.332+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.332+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.332+0900 D/AUL_PAD (12805): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b93c9640
05-22 06:03:17.332+0900 D/AUL_PAD (12805): preload.h: __preload_init(69) > get pre-initialization function
05-22 06:03:17.332+0900 D/AUL_PAD (12805): preload.h: __preload_init(73) > get shutdown function
05-22 06:03:17.332+0900 D/AUL_PAD (12805): preexec.h: __preexec_init(76) > preexec start
05-22 06:03:17.332+0900 E/EFL     (12576): evas_main<12576> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:03:17.332+0900 D/AUL_PAD (12805): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
05-22 06:03:17.332+0900 D/AUL     (12805): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
05-22 06:03:17.332+0900 D/AUL     (12805): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
05-22 06:03:17.332+0900 D/AUL     (12805): process_pool.c: __connect_to_launchpad(132) > send(12805) : 4
05-22 06:03:17.332+0900 D/AUL     (12805): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
05-22 06:03:17.332+0900 D/AUL_PAD ( 2961): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-22 06:03:17.332+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
05-22 06:03:17.332+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-22 06:03:17.332+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-22 06:03:17.332+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-22 06:03:17.332+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-22 06:03:17.332+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-22 06:03:17.332+0900 D/AUL_PAD ( 2961): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
05-22 06:03:17.332+0900 D/AUL_PAD ( 2961): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 12805
05-22 06:03:17.382+0900 E/RESOURCED( 2878): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.867
05-22 06:03:17.412+0900 D/PROCESSMGR( 2775): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x4016cd 
05-22 06:03:17.652+0900 D/AUL_PAD (12805): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
05-22 06:03:17.662+0900 D/AUL_PAD (12805): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
05-22 06:03:17.662+0900 D/AUL_PAD (12805): launchpad_loader.c: main(693) > [candidate] ecore handler add
05-22 06:03:17.662+0900 D/AUL_PAD (12805): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
05-22 06:03:18.432+0900 D/PROCESSMGR( 2775): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2a00002
05-22 06:03:19.612+0900 D/PROCESSMGR( 2775): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x4016cd 
05-22 06:03:19.672+0900 E/EFL     (12576): edje<12576> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p15';
05-22 06:03:19.672+0900 E/EFL     (12576): By the power of Grayskull, your previous Embryo stack is now broken!
05-22 06:03:20.112+0900 E/EFL     (12576): edje<12576> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-22 06:03:20.132+0900 E/EFL     (12576): edje<12576> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-22 06:03:20.142+0900 D/IMMODULE(12576): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
05-22 06:03:20.142+0900 D/ISF_SOCKET(12576): scim_socket.cpp: connect(515) > ppid:2961  trying connect() to local:/tmp/scim-socket-frontend, example
05-22 06:03:20.142+0900 D/ISF_SOCKET(12576): scim_socket.cpp: connect(524) > connect() succeeded
05-22 06:03:20.152+0900 D/ISF_SOCKET(12576): scim_socket.cpp: connect(515) > ppid:2961  trying connect() to local:/tmp/scim-socket-frontend, example
05-22 06:03:20.152+0900 D/ISF_SOCKET(12576): scim_socket.cpp: connect(524) > connect() succeeded
05-22 06:03:20.212+0900 D/ISF_SOCKET(12576): scim_socket.cpp: connect(515) > ppid:2961  trying connect() to local:/tmp/scim-socket-frontend, example
05-22 06:03:20.212+0900 D/ISF_SOCKET(12576): scim_socket.cpp: connect(524) > connect() succeeded
05-22 06:03:20.222+0900 D/ISF_QUERY(12576): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
05-22 06:03:20.222+0900 D/ISF_QUERY(12576): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-22 06:03:20.222+0900 D/ISF_QUERY(12576): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-22 06:03:20.222+0900 D/ISF_QUERY(12576): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-22 06:03:20.222+0900 D/ISF_QUERY(12576): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-22 06:03:20.222+0900 D/ISF_QUERY(12576): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-22 06:03:20.222+0900 D/ISF_QUERY(12576): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-22 06:03:20.232+0900 D/ISF_SOCKET(12576): scim_socket.cpp: connect(515) > ppid:2961  trying connect() to local:/tmp/scim-socket-frontend, example
05-22 06:03:20.232+0900 D/ISF_SOCKET(12576): scim_socket.cpp: connect(524) > connect() succeeded
05-22 06:03:20.242+0900 D/IMMODULE(12576): scim_panel_client.cpp: open_connection(162) > 
05-22 06:03:20.242+0900 D/ISF_SOCKET(12576): scim_socket.cpp: connect(515) > ppid:2961  trying connect() to local:/tmp/scim-panel-socket:0, example
05-22 06:03:20.242+0900 D/ISF_SOCKET(12576): scim_socket.cpp: connect(524) > connect() succeeded
05-22 06:03:20.252+0900 D/ISF_SOCKET(12576): scim_socket.cpp: connect(515) > ppid:2961  trying connect() to local:/tmp/scim-panel-socket:0, example
05-22 06:03:20.252+0900 D/ISF_SOCKET(12576): scim_socket.cpp: connect(524) > connect() succeeded
05-22 06:03:20.272+0900 D/IMMODULE(12576): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 1
05-22 06:03:20.842+0900 D/APP_CORE( 2900): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
05-22 06:03:20.842+0900 I/APP_CORE( 2900): appcore-efl.c: __do_app(496) > [APP 2900] Event: MEM_FLUSH State: PAUSED
05-22 06:03:20.852+0900 D/APP_CORE( 2900): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
05-22 06:03:20.852+0900 D/APP_CORE( 2900): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2900
05-22 06:03:20.852+0900 D/APP_CORE( 2900): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
05-22 06:03:20.852+0900 D/RESOURCED( 2878): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2900
05-22 06:03:22.152+0900 D/PROCESSMGR( 2775): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x4016cd 
05-22 06:03:22.312+0900 E/EFL     (12576): edje<12576> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
05-22 06:03:22.312+0900 E/EFL     (12576): By the power of Grayskull, your previous Embryo stack is now broken!
05-22 06:03:22.842+0900 W/CRASH_MANAGER(12808): worker.c: worker_job(1204) > 1112576657861149540060
