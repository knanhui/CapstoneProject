S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 12805
Date: 2017-05-22 06:04:55+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8000aa56

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x800552ab, esi = 0xb37cb800
ebp = 0xbf8c5008, esp = 0xbf8c4fb0
eax = 0x80063d20, ebx = 0xb37d0000
ecx = 0x8000aa56, edx = 0x00000002
eip = 0xb37cb4e2

Memory Information
MemTotal:      123 KB
MemFree:        27 KB
Buffers:         7 KB
Cached:     169712 KB
VmPeak:     114452 KB
VmSize:     114452 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       27536 KB
VmRSS:       27536 KB
VmData:      45632 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33592 KB
VmPTE:         104 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 12805 TID = 12805
12805 12806 13028 13029 13033 

Maps Information
b190a000 b190e000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2c6f000 b2c79000 r-xp /usr/lib/libfeedback.so.0.1.4
b2c7f000 b2c8b000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2c8c000 b2cad000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2cb2000 b2cb3000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2cb4000 b2cb9000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2cba000 b2cbc000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2cbd000 b2cbf000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2cc0000 b2ccc000 r-xp /usr/lib/libdrm.so.2.4.0
b2ccd000 b2cd7000 r-xp /usr/lib/libtbm.so.1.0.0
b2cd8000 b2ced000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2cee000 b2d00000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3502000 b350b000 r-xp /usr/lib/libeventsystem.so.0.0.1
b350c000 b3515000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3516000 b3528000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3529000 b354a000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b3551000 b3552000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3553000 b3554000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3555000 b3558000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3559000 b355c000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3664000 b366a000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b366b000 b37af000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37bf000 b37c0000 r-xp /usr/lib/libxshmfence.so.1.0.0
b37c1000 b37c4000 r-xp /usr/lib/libdri2.so.0.0.0
b37c5000 b37c6000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37c7000 b37cf000 r-xp /opt/usr/apps/org.example.example/bin/example
b37d1000 b380a000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b420d000 b4218000 r-xp /lib/libnss_files-2.20-2014.11.so
b421a000 b4225000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4227000 b423e000 r-xp /lib/libnsl-2.20-2014.11.so
b4242000 b424a000 r-xp /lib/libnss_compat-2.20-2014.11.so
b424c000 b4270000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4271000 b4272000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4273000 b4276000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4277000 b427e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b427f000 b4289000 r-xp /usr/lib/libsensord-share.so
b428a000 b42a6000 r-xp /usr/lib/libsensor.so.1.2.0
b42a8000 b42b1000 r-xp /usr/lib/libappcore-common.so.1.1
b42b4000 b42b6000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42cb000 b42cd000 r-xp /usr/lib/libXau.so.6.0.0
b42ce000 b42f0000 r-xp /usr/lib/libxcb.so.1.1.0
b42f2000 b42fb000 r-xp /lib/libcrypt-2.20-2014.11.so
b4324000 b4326000 r-xp /usr/lib/libiri.so
b4327000 b434d000 r-xp /lib/libexpat.so.1.5.2
b434f000 b43ba000 r-xp /usr/lib/libssl.so.1.0.0
b43c0000 b43cc000 r-xp /usr/lib/libethumb.so.1.13.0
b43cd000 b43d1000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43d2000 b4623000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b9e000 b5bae000 r-xp /usr/lib/libXi.so.6.1.0
b5baf000 b5bb1000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bb2000 b5bb8000 r-xp /usr/lib/libXtst.so.6.1.0
b5bb9000 b5bc3000 r-xp /usr/lib/libXrender.so.1.3.0
b5bc4000 b5bcd000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bcf000 b5bd1000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bd2000 b5bd7000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bd8000 b5bea000 r-xp /usr/lib/libXext.so.6.4.0
b5beb000 b5bed000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bee000 b5bf0000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bf2000 b5d34000 r-xp /usr/lib/libX11.so.6.3.0
b5d38000 b5d42000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d43000 b5d59000 r-xp /usr/lib/libudev.so.1.6.0
b5d5c000 b5d60000 r-xp /lib/libattr.so.1.1.0
b5d61000 b5d90000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d92000 b5d98000 r-xp /usr/lib/libffi.so.6.0.2
b5d99000 b5dbc000 r-xp /lib/libz.so.1.2.8
b5dbd000 b5dc0000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5dc1000 b5f1d000 r-xp /usr/lib/libxml2.so.2.9.2
b5f23000 b600a000 r-xp /usr/lib/libstdc++.so.6.0.20
b6017000 b601a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b601b000 b603d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b603e000 b6052000 r-xp /lib/libresolv-2.20-2014.11.so
b6056000 b607a000 r-xp /usr/lib/liblzma.so.5.0.3
b607b000 b607d000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b607f000 b6089000 r-xp /usr/lib/libembryo.so.1.13.0
b608a000 b60b3000 r-xp /usr/lib/libpng12.so.0.50.0
b60b4000 b60fd000 r-xp /usr/lib/libjpeg.so.8.0.2
b610e000 b6115000 r-xp /lib/librt-2.20-2014.11.so
b6117000 b6136000 r-xp /usr/lib/libector.so.1.13.0
b6139000 b6166000 r-xp /usr/lib/liblua-5.1.so
b6167000 b61f7000 r-xp /usr/lib/libfreetype.so.6.11.3
b61fb000 b6239000 r-xp /usr/lib/libfontconfig.so.1.8.0
b623a000 b6250000 r-xp /usr/lib/libfribidi.so.0.3.1
b6251000 b62aa000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62ad000 b62f8000 r-xp /lib/libm-2.20-2014.11.so
b62fa000 b630c000 r-xp /usr/lib/libeio.so.1.13.0
b630d000 b6310000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6311000 b6317000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6318000 b633b000 r-xp /usr/lib/libefreet.so.1.13.0
b633e000 b6369000 r-xp /usr/lib/libeldbus.so.1.13.0
b636a000 b639e000 r-xp /usr/lib/libecore_con.so.1.13.0
b63a0000 b63a9000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63aa000 b63b3000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63b4000 b63c7000 r-xp /usr/lib/libeo.so.1.13.0
b63c9000 b63dc000 r-xp /usr/lib/libecore_input.so.1.13.0
b63dd000 b63e4000 r-xp /usr/lib/libecore_file.so.1.13.0
b63e5000 b6408000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6409000 b6435000 r-xp /usr/lib/libeet.so.1.13.0
b643e000 b64a9000 r-xp /usr/lib/libeina.so.1.13.0
b64ac000 b64c3000 r-xp /usr/lib/libefl.so.1.13.0
b64c5000 b662c000 r-xp /usr/lib/libicuuc.so.51.1
b663a000 b6846000 r-xp /usr/lib/libicui18n.so.51.1
b684e000 b689d000 r-xp /usr/lib/libecore_x.so.1.13.0
b689f000 b68b9000 r-xp /lib/libgcc_s-4.9.so.1
b68bb000 b68bf000 r-xp /lib/libcap.so.2.21
b68c0000 b6906000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6907000 b690e000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6910000 b6962000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6964000 b6aef000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6af4000 b6bc2000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bc5000 b6bc9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bca000 b6bd9000 r-xp /usr/lib/libvconf.so.0.2.45
b6bda000 b6bdd000 r-xp /usr/lib/libvasum.so.0.3.1
b6bde000 b6be1000 r-xp /usr/lib/libttrace.so.1.1
b6be3000 b6be7000 r-xp /usr/lib/libiniparser.so.0
b6be8000 b6c18000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c19000 b6c22000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c23000 b6c48000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c49000 b6c59000 r-xp /usr/lib/libunwind.so.8.0.1
b6c63000 b6e11000 r-xp /lib/libc-2.20-2014.11.so
b6e19000 b6f5c000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f5e000 b6fb6000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fb7000 b6feb000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fee000 b70c2000 r-xp /usr/lib/libedje.so.1.13.0
b70c5000 b70f1000 r-xp /usr/lib/libecore.so.1.13.0
b7102000 b7328000 r-xp /usr/lib/libevas.so.1.13.0
b7350000 b7368000 r-xp /lib/libpthread-2.20-2014.11.so
b736c000 b76e6000 r-xp /usr/lib/libelementary.so.1.13.0
b7706000 b770a000 r-xp /usr/lib/libsmack.so.1.0.0
b770b000 b7714000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7715000 b7718000 r-xp /usr/lib/libdlog.so.0.0.0
b7719000 b771e000 r-xp /usr/lib/libbundle.so.0.1.22
b771f000 b7722000 r-xp /lib/libdl-2.20-2014.11.so
b7724000 b7749000 r-xp /usr/lib/libaul.so.0.1.0
b774c000 b774e000 r-xp /usr/lib/libappsvc.so.0.1.0
b774f000 b7754000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7755000 b775c000 r-xp /usr/lib/libappcore-efl.so.1.1
b775e000 b7763000 r-xp /usr/lib/libsys-assert.so
b7766000 b7767000 r-xp [vdso]
b7767000 b7789000 r-xp /lib/ld-2.20-2014.11.so
b778b000 b7793000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:12805)
Call Stack Count: 21
 0: make_popup_time + 0x1d2 (0xb37cb4e2) [/opt/usr/apps/org.example.example/bin/example] + 0x44e2
 1: (0xb718b116) [/usr/lib/libevas.so.1] + 0x89116
 2: (0xb63c2319) [/usr/lib/libeo.so.1] + 0xe319
 3: eo_event_callback_call + 0xb3 (0xb63bfd63) [/usr/lib/libeo.so.1] + 0xbd63
 4: evas_object_smart_callback_call + 0x75 (0xb718d9e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 5: (0xb743e404) [/usr/lib/libelementary.so.1] + 0xd2404
 6: (0xb7071f39) [/usr/lib/libedje.so.1] + 0x83f39
 7: (0xb7078a11) [/usr/lib/libedje.so.1] + 0x8aa11
 8: (0xb7072fdc) [/usr/lib/libedje.so.1] + 0x84fdc
 9: (0xb70734cb) [/usr/lib/libedje.so.1] + 0x854cb
10: (0xb707368f) [/usr/lib/libedje.so.1] + 0x8568f
11: (0xb70d8702) [/usr/lib/libecore.so.1] + 0x13702
12: (0xb70d2055) [/usr/lib/libecore.so.1] + 0xd055
13: (0xb70db1b9) [/usr/lib/libecore.so.1] + 0x161b9
14: ecore_main_loop_begin + 0x57 (0xb70db587) [/usr/lib/libecore.so.1] + 0x16587
15: elm_run + 0x2d (0xb753422d) [/usr/lib/libelementary.so.1] + 0x1c822d
16: appcore_efl_main + 0x4de (0xb7758dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
17: ui_app_main + 0x140 (0xb7751c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
18: main + 0x27e (0xb37cbf8e) [/opt/usr/apps/org.example.example/bin/example] + 0x4f8e
19: create_time + 0x58 (0xb778d148) [/opt/usr/apps/org.example.example/bin/example] + 0xb778d148
20: __libc_start_main + 0xde (0xb6c7ae4e) [/lib/libc.so.6] + 0x17e4e
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
 [__SUSPEND__]
05-22 06:04:51.311+0900 I/CAPI_APPFW_APPLICATION(12805): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
05-22 06:04:51.311+0900 D/AUL     (12805): service.c: __set_bundle(186) > __set_bundle
05-22 06:04:51.311+0900 D/LAUNCH  (12805): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
05-22 06:04:51.311+0900 D/APP_CORE(12805): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
05-22 06:04:51.311+0900 E/EFL     (12805): edje<12805> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-22 06:04:51.311+0900 E/EFL     (12805): By the power of Grayskull, your previous Embryo stack is now broken!
05-22 06:04:51.321+0900 E/EFL     (12805): edje<12805> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-22 06:04:51.321+0900 E/EFL     (12805): By the power of Grayskull, your previous Embryo stack is now broken!
05-22 06:04:51.321+0900 E/EFL     (12805): edje<12805> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-22 06:04:51.321+0900 E/EFL     (12805): By the power of Grayskull, your previous Embryo stack is now broken!
05-22 06:04:51.321+0900 E/EFL     (12805): edje<12805> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-22 06:04:51.321+0900 E/EFL     (12805): By the power of Grayskull, your previous Embryo stack is now broken!
05-22 06:04:51.321+0900 E/EFL     (12805): edje<12805> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-22 06:04:51.321+0900 E/EFL     (12805): By the power of Grayskull, your previous Embryo stack is now broken!
05-22 06:04:51.351+0900 E/E17     ( 2775): e_border.c: e_border_show(2088) > BD_SHOW(0x02200002)
05-22 06:04:51.391+0900 W/PROCESSMGR( 2775): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=12805
05-22 06:04:51.391+0900 E/EFL     ( 2775): eo<2775> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-22 06:04:51.391+0900 E/EFL     ( 2775): eo<2775> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-22 06:04:51.421+0900 D/INDICATOR( 2882): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
05-22 06:04:51.421+0900 D/AUL_AMD ( 2774): amd_request.c: __request_handler(838) > __request_handler: 15
05-22 06:04:51.421+0900 D/PKGMGR_INFO( 2774): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-22 06:04:51.421+0900 D/PKGMGR_INFO( 2774): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-22 06:04:51.421+0900 D/AUL_AMD ( 2774): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 12805 is org.example.example
05-22 06:04:51.421+0900 D/AUL_AMD ( 2774): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 12805 : 0
05-22 06:04:51.421+0900 D/INDICATOR( 2882): util.c: util_signal_emit_by_win(116) > emission bg.opaque
05-22 06:04:51.421+0900 D/AUL     ( 3004): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
05-22 06:04:51.421+0900 D/INDICATOR( 2882): main.c: _rotate_window(229) > Indicator angle is 0 degree
05-22 06:04:51.421+0900 D/INDICATOR( 2882): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
05-22 06:04:51.421+0900 D/INDICATOR( 2882): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
05-22 06:04:51.421+0900 D/INDICATOR( 2882): main.c: _rotate_window(252) > port :: hide more icon
05-22 06:04:51.461+0900 D/APP_CORE(12805): appcore.c: __prt_ltime(236) > [APP 12805] first idle after reset: 375 msec
05-22 06:04:51.481+0900 W/APP_CORE(12805): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2200002
05-22 06:04:51.481+0900 D/APP_CORE(12805): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2200002
05-22 06:04:51.481+0900 D/APP_CORE(12805): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
05-22 06:04:51.481+0900 D/AUL     (12805): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
05-22 06:04:51.481+0900 D/AUL_AMD ( 2774): amd_request.c: __request_handler(838) > __request_handler: 34
05-22 06:04:51.761+0900 E/E17     ( 2775): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
05-22 06:04:51.761+0900 D/APP_CORE( 2900): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
05-22 06:04:51.761+0900 D/APP_CORE( 2900): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
05-22 06:04:51.761+0900 D/APP_CORE( 2900): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
05-22 06:04:51.761+0900 I/APP_CORE( 2900): appcore-efl.c: __do_app(496) > [APP 2900] Event: PAUSE State: RUNNING
05-22 06:04:51.761+0900 D/APP_CORE( 2900): appcore-efl.c: __do_app(565) > [APP 2900] PAUSE
05-22 06:04:51.761+0900 I/CAPI_APPFW_APPLICATION( 2900): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
05-22 06:04:51.761+0900 E/cluster-home( 2900): homescreen.cpp: OnPause(84) >  app pause
05-22 06:04:51.761+0900 D/cluster-view( 2900): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
05-22 06:04:51.761+0900 D/cluster-view( 2900): homescreen-view-manager.cpp: AppPause(923) >  END
05-22 06:04:51.761+0900 D/APP_CORE( 2900): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-22 06:04:51.761+0900 E/APP_CORE( 2900): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-22 06:04:51.761+0900 D/APP_CORE(12805): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2200002 fully_obscured 0
05-22 06:04:51.761+0900 D/APP_CORE(12805): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
05-22 06:04:51.761+0900 D/APP_CORE(12805): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
05-22 06:04:51.761+0900 I/APP_CORE(12805): appcore-efl.c: __do_app(496) > [APP 12805] Event: RESUME State: CREATED
05-22 06:04:51.761+0900 D/LAUNCH  (12805): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
05-22 06:04:51.771+0900 D/APP_CORE(12805): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
05-22 06:04:51.771+0900 D/APP_CORE(12805): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-22 06:04:51.771+0900 D/DATA_PROVIDER_MASTER( 2965): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2900 is paused
05-22 06:04:51.771+0900 D/DATA_PROVIDER_MASTER( 2965): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
05-22 06:04:51.771+0900 D/APP_CORE(12805): appcore-efl.c: __do_app(607) > [APP 12805] RESUME
05-22 06:04:51.771+0900 I/CAPI_WIDGET_APPLICATION( 3012): widget_app.c: __provider_pause_cb(294) > widget obj was paused
05-22 06:04:51.771+0900 I/CAPI_WIDGET_APPLICATION( 3012): widget_app.c: __check_status_for_cgroup(142) > enter background group
05-22 06:04:51.771+0900 W/AUL     ( 3012): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3012, appid: org.tizen.calendar.widget, status: bg
05-22 06:04:51.771+0900 D/RESOURCED( 2878): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3012, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
05-22 06:04:51.771+0900 D/RESOURCED( 2878): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3012
05-22 06:04:51.771+0900 D/RESOURCED( 2878): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3012, appname = org.tizen.calendar.widget
05-22 06:04:51.771+0900 D/RESOURCED( 2878): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3012
05-22 06:04:51.781+0900 I/APP_CORE(12805): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
05-22 06:04:51.781+0900 I/APP_CORE(12805): appcore-efl.c: __do_app(614) > [APP 12805] Initial Launching, call the resume_cb
05-22 06:04:51.781+0900 I/CAPI_APPFW_APPLICATION(12805): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
05-22 06:04:51.781+0900 D/LAUNCH  (12805): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
05-22 06:04:51.781+0900 D/LAUNCH  (12805): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
05-22 06:04:51.781+0900 D/APP_CORE(12805): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-22 06:04:51.781+0900 E/APP_CORE(12805): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-22 06:04:51.781+0900 D/AUL_AMD ( 2774): amd_status.c: _status_update_app_info_list(456) > pid(2900) status(4)
05-22 06:04:51.781+0900 D/AUL_AMD ( 2774): amd_status.c: _status_update_app_info_list(468) > pid(2900) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
05-22 06:04:51.781+0900 D/AUL     ( 2774): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
05-22 06:04:51.781+0900 W/AUL     ( 2774): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2900, appid: org.tizen.homescreen, status: bg
05-22 06:04:51.781+0900 D/AUL_AMD ( 2774): amd_launch.c: __e17_status_handler(2891) > pid(12805) status(3)
05-22 06:04:51.791+0900 D/AUL_AMD ( 2774): amd_key.c: _key_ungrab(265) > _key_ungrab, win : 800002
05-22 06:04:51.821+0900 W/AUL_AMD ( 2774): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-22 06:04:51.821+0900 W/AUL_AMD ( 2774): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
05-22 06:04:51.821+0900 D/AUL_AMD ( 2774): amd_status.c: _status_update_app_info_list(456) > pid(12805) status(3)
05-22 06:04:51.821+0900 D/AUL_AMD ( 2774): amd_status.c: _status_update_app_info_list(468) > pid(12805) appid(org.example.example) pkgid(org.example.example) status(3)
05-22 06:04:51.821+0900 D/AUL     ( 2774): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
05-22 06:04:51.821+0900 W/AUL     ( 2774): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 12805, appid: org.example.example, status: fg
05-22 06:04:51.821+0900 D/RESOURCED( 2878): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 12805
05-22 06:04:51.821+0900 D/RESOURCED( 2878): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 12805, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
05-22 06:04:51.821+0900 D/RESOURCED( 2878): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 12805
05-22 06:04:51.861+0900 D/RESOURCED( 2878): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 12805, appname = org.example.example, pkgname = org.example.example
05-22 06:04:51.861+0900 D/RESOURCED( 2878): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 12805, appname = org.example.example
05-22 06:04:51.861+0900 D/RESOURCED( 2878): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 12805
05-22 06:04:51.861+0900 I/RESOURCED( 2878): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
05-22 06:04:51.861+0900 I/RESOURCED( 2878): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
05-22 06:04:51.951+0900 D/AUL_AMD ( 2774): amd_launch.c: __e17_status_handler(2910) > pid(12805) status(0)
05-22 06:04:52.221+0900 D/AUL_PAD ( 2961): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
05-22 06:04:52.271+0900 D/AUL_PAD (13031): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
05-22 06:04:52.311+0900 D/AUL_PAD ( 2961): sigchild.h: __send_app_launch_signal(131) > send launch signal done
05-22 06:04:52.341+0900 E/RESOURCED( 2878): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.883
05-22 06:04:52.711+0900 D/AUL_AMD ( 2774): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
05-22 06:04:52.711+0900 D/RUA     ( 2774): rua.c: rua_add_history(179) > rua_add_history start
05-22 06:04:52.721+0900 D/RUA     ( 2774): rua.c: rua_add_history(247) > rua_add_history ok
05-22 06:04:53.021+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.021+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.021+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.021+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.021+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.021+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.021+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.021+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.021+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.021+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.021+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.021+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.031+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.041+0900 D/PROCESSMGR( 2775): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x40173f 
05-22 06:04:53.051+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.051+0900 E/EFL     (12805): evas_main<12805> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 06:04:53.361+0900 D/AUL_PAD (13031): launchpad_loader.c: main(588) > sleeping 1 sec...
05-22 06:04:53.361+0900 D/AUL_PAD (13031): preload.h: __preload_init(52) > max_cmdline_size = 1053
05-22 06:04:53.371+0900 D/AUL_PAD (13031): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b84a5760
05-22 06:04:53.371+0900 D/AUL_PAD (13031): preload.h: __preload_init(69) > get pre-initialization function
05-22 06:04:53.371+0900 D/AUL_PAD (13031): preload.h: __preload_init(73) > get shutdown function
05-22 06:04:53.371+0900 D/AUL_PAD (13031): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b84a5a40
05-22 06:04:53.371+0900 D/AUL_PAD (13031): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b84a7640
05-22 06:04:53.371+0900 D/AUL_PAD (13031): preload.h: __preload_init(69) > get pre-initialization function
05-22 06:04:53.371+0900 D/AUL_PAD (13031): preload.h: __preload_init(73) > get shutdown function
05-22 06:04:53.371+0900 D/AUL_PAD (13031): preexec.h: __preexec_init(76) > preexec start
05-22 06:04:53.371+0900 D/AUL_PAD (13031): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
05-22 06:04:53.371+0900 D/AUL     (13031): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
05-22 06:04:53.371+0900 D/AUL     (13031): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
05-22 06:04:53.371+0900 D/AUL     (13031): process_pool.c: __connect_to_launchpad(132) > send(13031) : 4
05-22 06:04:53.371+0900 D/AUL     (13031): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
05-22 06:04:53.371+0900 D/AUL_PAD ( 2961): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-22 06:04:53.371+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
05-22 06:04:53.371+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-22 06:04:53.371+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-22 06:04:53.371+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-22 06:04:53.371+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-22 06:04:53.371+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-22 06:04:53.371+0900 D/AUL_PAD ( 2961): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
05-22 06:04:53.371+0900 D/AUL_PAD ( 2961): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 13031
05-22 06:04:53.641+0900 D/AUL_PAD (13031): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
05-22 06:04:53.651+0900 D/AUL_PAD (13031): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
05-22 06:04:53.651+0900 D/AUL_PAD (13031): launchpad_loader.c: main(693) > [candidate] ecore handler add
05-22 06:04:53.651+0900 D/AUL_PAD (13031): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
05-22 06:04:54.061+0900 D/PROCESSMGR( 2775): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2200002
05-22 06:04:54.711+0900 D/PROCESSMGR( 2775): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x40173f 
05-22 06:04:54.751+0900 E/EFL     (12805): edje<12805> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p15';
05-22 06:04:54.751+0900 E/EFL     (12805): By the power of Grayskull, your previous Embryo stack is now broken!
05-22 06:04:55.281+0900 D/AUL_PAD ( 2961): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-22 06:04:55.301+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
05-22 06:04:55.301+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-22 06:04:55.301+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-22 06:04:55.301+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-22 06:04:55.301+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-22 06:04:55.301+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-22 06:04:55.301+0900 I/AUL_PAD ( 2961): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 12805 pgid = 12805
05-22 06:04:55.301+0900 I/AUL_PAD ( 2961): sigchild.h: __sigchild_action(142) > dead_pid(12805)
05-22 06:04:55.311+0900 E/EFL     ( 2775): eo<2775> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-22 06:04:55.311+0900 D/AUL_PAD ( 2961): sigchild.h: __send_app_dead_signal(90) > send dead signal done
05-22 06:04:55.321+0900 I/AUL_PAD ( 2961): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
05-22 06:04:55.321+0900 I/AUL_PAD ( 2961): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
05-22 06:04:55.321+0900 E/AUL_PAD ( 2961): launchpad.c: main(688) > error reading sigchld info
05-22 06:04:55.321+0900 D/STARTER ( 2875): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 12805 is termianted
05-22 06:04:55.321+0900 D/STARTER ( 2875): starter.c: _check_dead_signal(202) > [_check_dead_signal:202] Unknown process, ignore it
05-22 06:04:55.321+0900 I/ESD     ( 2998): esd_main.c: __esd_app_dead_handler(1771) > pid: 12805
05-22 06:04:55.341+0900 W/AUL_AMD ( 2774): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 12805
05-22 06:04:55.341+0900 W/AUL_AMD ( 2774): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 12805
05-22 06:04:55.341+0900 D/AUL_AMD ( 2774): amd_key.c: _unregister_key_event(179) > ===key stack===
05-22 06:04:55.341+0900 E/AUL_AMD ( 2774): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
05-22 06:04:55.341+0900 D/AUL_AMD ( 2774): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.example.example)
05-22 06:04:55.341+0900 D/AUL     ( 2774): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
05-22 06:04:55.341+0900 E/AUL     ( 2774): simple_util.c: __trm_app_info_send_socket(330) > access
05-22 06:04:55.341+0900 D/AUL_AMD ( 2774): amd_launch.c: __e17_status_handler(2891) > pid(2900) status(3)
05-22 06:04:55.341+0900 D/AUL_AMD ( 2774): amd_key.c: _key_ungrab(265) > _key_ungrab, win : 800002
05-22 06:04:55.341+0900 D/RESOURCED( 2878): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 12805
05-22 06:04:55.341+0900 D/RESOURCED( 2878): appinfo-list.c: resourced_appinfo_put(132) > appid org.example.example, pkgname = org.example.example, ref = 0
05-22 06:04:55.341+0900 W/AUL_AMD ( 2774): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-22 06:04:55.341+0900 W/AUL_AMD ( 2774): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
05-22 06:04:55.341+0900 D/AUL_AMD ( 2774): amd_status.c: _status_update_app_info_list(456) > pid(2900) status(3)
05-22 06:04:55.341+0900 D/AUL_AMD ( 2774): amd_status.c: _status_update_app_info_list(468) > pid(2900) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(3)
05-22 06:04:55.341+0900 D/AUL     ( 2774): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.tizen.homescreen
05-22 06:04:55.341+0900 W/AUL     ( 2774): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2900, appid: org.tizen.homescreen, status: fg
05-22 06:04:55.341+0900 D/RESOURCED( 2878): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2900
05-22 06:04:55.341+0900 D/RESOURCED( 2878): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 2900, appname = org.tizen.homescreen, pkgname = org.tizen.homescreen
05-22 06:04:55.341+0900 D/RESOURCED( 2878): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2900, appname = org.tizen.homescreen
05-22 06:04:55.341+0900 D/RESOURCED( 2878): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2900
05-22 06:04:55.351+0900 W/CRASH_MANAGER(13034): worker.c: worker_job(1204) > 1112805657861149540069
