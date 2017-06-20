S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 3135
Date: 2017-06-13 13:59:14+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0xc1640000
es  = 0xffff007b, ds  = 0x0000007b
edi = 0x00000000, esi = 0xb9392e60
ebp = 0xbfff9bb8, esp = 0xbfff9b50
eax = 0xb9392e60, ebx = 0xb6c310d4
ecx = 0xb383e000, edx = 0x00000000
eip = 0xb6c0f1f6

Memory Information
MemTotal:      123 KB
MemFree:        35 KB
Buffers:         5 KB
Cached:     149492 KB
VmPeak:     110816 KB
VmSize:     110816 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24172 KB
VmRSS:       24172 KB
VmData:      43088 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34612 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 3135 TID = 3135
3135 3136 3340 3342 

Maps Information
b2bcf000 b2bd9000 r-xp /usr/lib/libfeedback.so.0.1.4
b2bdf000 b2beb000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2bec000 b2c0d000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2c12000 b2c13000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2c14000 b2c19000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2c1a000 b2c1b000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2c1c000 b2c1e000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c1f000 b2c21000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2c22000 b2c2e000 r-xp /usr/lib/libdrm.so.2.4.0
b2c2f000 b2c32000 r-xp /usr/lib/libdri2.so.0.0.0
b2c33000 b2c3d000 r-xp /usr/lib/libtbm.so.1.0.0
b2c3e000 b2c3f000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b2c40000 b2c55000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c56000 b2c68000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b346a000 b349b000 r-xp /usr/lib/libidn.so.11.5.44
b349c000 b34be000 r-xp /usr/lib/libnghttp2.so.5.4.0
b34bf000 b34cf000 r-xp /usr/lib/libcares.so.2.1.0
b34d0000 b34d9000 r-xp /usr/lib/libeventsystem.so.0.0.1
b34da000 b34e0000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b34e1000 b34f7000 r-xp /usr/lib/libalarm.so.0.0.0
b34f9000 b3502000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3503000 b357a000 r-xp /usr/lib/libcurl.so.4.3.0
b357c000 b358e000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b358f000 b3592000 r-xp /usr/lib/libcapi-message-port.so.1.2.2.1
b3593000 b3596000 r-xp /usr/lib/libcapi-appfw-alarm.so.0.3.1.0
b3597000 b35b8000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b35bf000 b35c0000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b35c1000 b35c2000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b35c3000 b35c6000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b35c7000 b35ca000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b36d2000 b36d8000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b36d9000 b381d000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b382d000 b383c000 r-xp /opt/usr/apps/org.example.example/bin/example
b383f000 b3878000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b427b000 b4286000 r-xp /lib/libnss_files-2.20-2014.11.so
b4288000 b4293000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4295000 b42ac000 r-xp /lib/libnsl-2.20-2014.11.so
b42b0000 b42b8000 r-xp /lib/libnss_compat-2.20-2014.11.so
b42ba000 b42de000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b42df000 b42e0000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b42e1000 b42e4000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42e5000 b42ec000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42ed000 b42f7000 r-xp /usr/lib/libsensord-share.so
b42f8000 b4314000 r-xp /usr/lib/libsensor.so.1.2.0
b4316000 b431f000 r-xp /usr/lib/libappcore-common.so.1.1
b4322000 b4324000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4339000 b433b000 r-xp /usr/lib/libXau.so.6.0.0
b433c000 b435e000 r-xp /usr/lib/libxcb.so.1.1.0
b4360000 b4369000 r-xp /lib/libcrypt-2.20-2014.11.so
b4392000 b4394000 r-xp /usr/lib/libiri.so
b4395000 b43bb000 r-xp /lib/libexpat.so.1.5.2
b43bd000 b4428000 r-xp /usr/lib/libssl.so.1.0.0
b442e000 b443a000 r-xp /usr/lib/libethumb.so.1.13.0
b443b000 b443f000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4440000 b4691000 r-xp /usr/lib/libcrypto.so.1.0.0
b5c0c000 b5c1c000 r-xp /usr/lib/libXi.so.6.1.0
b5c1d000 b5c1f000 r-xp /usr/lib/libXgesture.so.7.0.0
b5c20000 b5c26000 r-xp /usr/lib/libXtst.so.6.1.0
b5c27000 b5c31000 r-xp /usr/lib/libXrender.so.1.3.0
b5c32000 b5c3b000 r-xp /usr/lib/libXrandr.so.2.2.0
b5c3d000 b5c3f000 r-xp /usr/lib/libXinerama.so.1.0.0
b5c40000 b5c45000 r-xp /usr/lib/libXfixes.so.3.1.0
b5c46000 b5c58000 r-xp /usr/lib/libXext.so.6.4.0
b5c59000 b5c5b000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c5c000 b5c5e000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c60000 b5da2000 r-xp /usr/lib/libX11.so.6.3.0
b5da6000 b5db0000 r-xp /usr/lib/libXcursor.so.1.0.2
b5db1000 b5dc7000 r-xp /usr/lib/libudev.so.1.6.0
b5dca000 b5dce000 r-xp /lib/libattr.so.1.1.0
b5dcf000 b5dfe000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5e00000 b5e06000 r-xp /usr/lib/libffi.so.6.0.2
b5e07000 b5e2a000 r-xp /lib/libz.so.1.2.8
b5e2b000 b5e2e000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5e2f000 b5f8b000 r-xp /usr/lib/libxml2.so.2.9.2
b5f91000 b6078000 r-xp /usr/lib/libstdc++.so.6.0.20
b6085000 b6088000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6089000 b60ab000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b60ac000 b60c0000 r-xp /lib/libresolv-2.20-2014.11.so
b60c4000 b60e8000 r-xp /usr/lib/liblzma.so.5.0.3
b60e9000 b60eb000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b60ed000 b60f7000 r-xp /usr/lib/libembryo.so.1.13.0
b60f8000 b6121000 r-xp /usr/lib/libpng12.so.0.50.0
b6122000 b616b000 r-xp /usr/lib/libjpeg.so.8.0.2
b617c000 b6183000 r-xp /lib/librt-2.20-2014.11.so
b6185000 b61a4000 r-xp /usr/lib/libector.so.1.13.0
b61a7000 b61d4000 r-xp /usr/lib/liblua-5.1.so
b61d5000 b6265000 r-xp /usr/lib/libfreetype.so.6.11.3
b6269000 b62a7000 r-xp /usr/lib/libfontconfig.so.1.8.0
b62a8000 b62be000 r-xp /usr/lib/libfribidi.so.0.3.1
b62bf000 b6318000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b631b000 b6366000 r-xp /lib/libm-2.20-2014.11.so
b6368000 b637a000 r-xp /usr/lib/libeio.so.1.13.0
b637b000 b637e000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b637f000 b6385000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6386000 b63a9000 r-xp /usr/lib/libefreet.so.1.13.0
b63ac000 b63d7000 r-xp /usr/lib/libeldbus.so.1.13.0
b63d8000 b640c000 r-xp /usr/lib/libecore_con.so.1.13.0
b640e000 b6417000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6418000 b6421000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6422000 b6435000 r-xp /usr/lib/libeo.so.1.13.0
b6437000 b644a000 r-xp /usr/lib/libecore_input.so.1.13.0
b644b000 b6452000 r-xp /usr/lib/libecore_file.so.1.13.0
b6453000 b6476000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6477000 b64a3000 r-xp /usr/lib/libeet.so.1.13.0
b64ac000 b6517000 r-xp /usr/lib/libeina.so.1.13.0
b651a000 b6531000 r-xp /usr/lib/libefl.so.1.13.0
b6533000 b669a000 r-xp /usr/lib/libicuuc.so.51.1
b66a8000 b68b4000 r-xp /usr/lib/libicui18n.so.51.1
b68bc000 b690b000 r-xp /usr/lib/libecore_x.so.1.13.0
b690d000 b6927000 r-xp /lib/libgcc_s-4.9.so.1
b6929000 b692d000 r-xp /lib/libcap.so.2.21
b692e000 b6974000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6975000 b697c000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b697e000 b69d0000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b69d2000 b6b5d000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b62000 b6c30000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6c33000 b6c37000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6c38000 b6c47000 r-xp /usr/lib/libvconf.so.0.2.45
b6c48000 b6c4b000 r-xp /usr/lib/libvasum.so.0.3.1
b6c4c000 b6c4f000 r-xp /usr/lib/libttrace.so.1.1
b6c51000 b6c55000 r-xp /usr/lib/libiniparser.so.0
b6c56000 b6c86000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c87000 b6c90000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c91000 b6cb6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6cb7000 b6cc7000 r-xp /usr/lib/libunwind.so.8.0.1
b6cd1000 b6e7f000 r-xp /lib/libc-2.20-2014.11.so
b6e87000 b6fca000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6fcc000 b7024000 r-xp /usr/lib/libdbus-1.so.3.8.11
b7025000 b7059000 r-xp /usr/lib/libsystemd.so.0.4.0
b705c000 b7130000 r-xp /usr/lib/libedje.so.1.13.0
b7133000 b715f000 r-xp /usr/lib/libecore.so.1.13.0
b7170000 b7396000 r-xp /usr/lib/libevas.so.1.13.0
b73be000 b73d6000 r-xp /lib/libpthread-2.20-2014.11.so
b73da000 b7754000 r-xp /usr/lib/libelementary.so.1.13.0
b7774000 b7778000 r-xp /usr/lib/libsmack.so.1.0.0
b7779000 b7782000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7783000 b7786000 r-xp /usr/lib/libdlog.so.0.0.0
b7787000 b778c000 r-xp /usr/lib/libbundle.so.0.1.22
b778d000 b7790000 r-xp /lib/libdl-2.20-2014.11.so
b7792000 b77b7000 r-xp /usr/lib/libaul.so.0.1.0
b77ba000 b77bc000 r-xp /usr/lib/libappsvc.so.0.1.0
b77bd000 b77c2000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b77c3000 b77ca000 r-xp /usr/lib/libappcore-efl.so.1.1
b77cc000 b77d1000 r-xp /usr/lib/libsys-assert.so
b77d4000 b77d5000 r-xp [vdso]
b77d5000 b77f7000 r-xp /lib/ld-2.20-2014.11.so
b77f9000 b7801000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:3135)
Call Stack Count: 9
 0: (0xb6c0f1f6) [/usr/lib/libsqlite3.so.0] + 0xad1f6
 1: open_setting_db + 0x143 (0xb38383f3) [/opt/usr/apps/org.example.example/bin/example] + 0xb3f3
 2: app_pause + 0x29 (0xb3836ea9) [/opt/usr/apps/org.example.example/bin/example] + 0x9ea9
 3: (0xb77bece2) [/usr/lib/libcapi-appfw-application.so.0] + 0x1ce2
 4: appcore_efl_main + 0x85a (0xb77c715a) [/usr/lib/libappcore-efl.so.1] + 0x415a
 5: ui_app_main + 0x140 (0xb77bfc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
 6: main + 0x2a5 (0xb3836dd5) [/opt/usr/apps/org.example.example/bin/example] + 0x9dd5
 7: (0xb77fb148) [/opt/usr/apps/org.example.example/bin/example] + 0xb77fb148
 8: __libc_start_main + 0xde (0xb6ce8e4e) [/lib/libc.so.6] + 0x17e4e
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
0 D/AUL     ( 3135): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (3136) is sent.
06-13 13:56:13.359+0900 D/AUL     ( 3135): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 3136, signo: 10
06-13 13:56:13.359+0900 D/AUL     ( 3135): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-13 13:56:13.359+0900 D/AUL_PAD ( 3135): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-13 13:56:13.359+0900 D/AUL_PAD ( 3135): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-13 13:56:13.359+0900 D/AUL_PAD ( 3135): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-13 13:56:13.359+0900 D/AUL_PAD ( 3135): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-13 13:56:13.359+0900 D/AUL_PAD ( 3135): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTczMjk3NzMvMzU5NDg3AA==##
06-13 13:56:13.359+0900 D/AUL_PAD ( 3135): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-13 13:56:13.359+0900 D/AUL_PAD ( 3135): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAAzMzM1AA==##
06-13 13:56:13.359+0900 D/AUL_PAD ( 3135): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-13 13:56:13.359+0900 D/AUL_PAD ( 3135): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-13 13:56:13.359+0900 D/AUL_PAD ( 3135): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-13 13:56:13.359+0900 D/AUL_PAD ( 3135): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-13 13:56:13.359+0900 D/AUL_PAD ( 3135): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-13 13:56:13.369+0900 I/CAPI_APPFW_APPLICATION( 3135): app_main.c: ui_app_main(788) > app_efl_main
06-13 13:56:13.369+0900 D/LAUNCH  ( 3135): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-13 13:56:13.369+0900 D/APP_CORE( 3135): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-13 13:56:13.369+0900 D/APP_CORE( 3135): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-13 13:56:13.369+0900 D/APP_CORE( 3135): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-13 13:56:13.369+0900 D/APP_CORE( 3135): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-13 13:56:13.369+0900 D/AUL     ( 3135): app_sock.c: __create_server_sock(156) > pg path - already exists
06-13 13:56:13.369+0900 D/APP_CORE( 3135): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb431f520
06-13 13:56:13.369+0900 D/LAUNCH  ( 3135): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-13 13:56:13.369+0900 I/CAPI_APPFW_APPLICATION( 3135): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-13 13:56:13.439+0900 D/LAUNCH  ( 3135): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
06-13 13:56:13.439+0900 E/E17     ( 2765): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x01200002)
06-13 13:56:13.439+0900 D/APP_CORE( 3135): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-13 13:56:13.449+0900 E/E17     ( 2765): e_border.c: e_border_show(2088) > BD_SHOW(0x01200002)
06-13 13:56:13.449+0900 D/APP_CORE( 3135): appcore.c: __aul_handler(587) > [APP 3135]     AUL event: AUL_START
06-13 13:56:13.449+0900 I/APP_CORE( 3135): appcore-efl.c: __do_app(496) > [APP 3135] Event: RESET State: CREATED
06-13 13:56:13.449+0900 D/APP_CORE( 3135): appcore-efl.c: __do_app(527) > [APP 3135] RESET
06-13 13:56:13.449+0900 D/LAUNCH  ( 3135): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
06-13 13:56:13.449+0900 D/APP_CORE( 3135): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-13 13:56:13.449+0900 D/APP_CORE( 3135): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-13 13:56:13.449+0900 I/CAPI_APPFW_APPLICATION( 3135): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-13 13:56:13.449+0900 D/AUL     ( 3135): service.c: __set_bundle(186) > __set_bundle
06-13 13:56:13.449+0900 D/tag     ( 3135): 왜안돼 ㅠㅠㅠ
06-13 13:56:13.449+0900 D/LAUNCH  ( 3135): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-13 13:56:13.449+0900 D/APP_CORE( 3135): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-13 13:56:13.449+0900 I/run     ( 3135): socket
06-13 13:56:13.449+0900 I/tag     ( 3135): eonji~
06-13 13:56:13.449+0900 I/run     ( 3135): connect
06-13 13:56:13.449+0900 I/run     ( 3135): new
06-13 13:56:13.449+0900 I/run     ( 3135): send
06-13 13:56:13.449+0900 E/EFL     ( 3135): edje<3135> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 13:56:13.449+0900 E/EFL     ( 3135): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:56:13.459+0900 E/EFL     ( 3135): edje<3135> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 13:56:13.459+0900 E/EFL     ( 3135): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:56:13.459+0900 E/EFL     ( 3135): edje<3135> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 13:56:13.459+0900 E/EFL     ( 3135): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:56:13.459+0900 E/EFL     ( 3135): edje<3135> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 13:56:13.459+0900 E/EFL     ( 3135): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:56:13.459+0900 E/EFL     ( 3135): edje<3135> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 13:56:13.459+0900 E/EFL     ( 3135): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:56:13.459+0900 D/AUL_PAD ( 2910): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-13 13:56:13.459+0900 W/AUL     ( 2747): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 3135, appid: org.example.example
06-13 13:56:13.459+0900 D/AUL     ( 2747): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-13 13:56:13.459+0900 E/AUL     ( 2747): simple_util.c: __trm_app_info_send_socket(330) > access
06-13 13:56:13.459+0900 D/AUL_AMD ( 2747): amd_launch.c: _start_app(2700) > add app group info
06-13 13:56:13.459+0900 E/AUL     ( 2747): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-13 13:56:13.459+0900 D/AUL_AMD ( 2747): amd_status.c: _status_add_app_info_list(427) > pid(3135) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-13 13:56:13.459+0900 D/RESOURCED( 2842): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 3135
06-13 13:56:13.459+0900 D/RESOURCED( 2842): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-13 13:56:13.459+0900 E/RESOURCED( 2842): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-13 13:56:13.459+0900 D/RESOURCED( 2842): proc-main.c: resourced_proc_status_change(888) > available memory = 311
06-13 13:56:13.459+0900 W/APP_CORE( 3135): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1200002
06-13 13:56:13.469+0900 D/APP_CORE( 3135): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:1200002
06-13 13:56:13.469+0900 D/APP_CORE( 3135): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-13 13:56:13.469+0900 D/AUL     ( 3135): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-13 13:56:13.469+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(838) > __request_handler: 34
06-13 13:56:13.469+0900 W/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=3135
06-13 13:56:13.469+0900 E/EFL     ( 2765): eo<2765> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:56:13.469+0900 E/EFL     ( 2765): eo<2765> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:56:13.479+0900 D/INDICATOR( 2846): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
06-13 13:56:13.479+0900 D/INDICATOR( 2846): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-13 13:56:13.479+0900 D/INDICATOR( 2846): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-13 13:56:13.479+0900 D/INDICATOR( 2846): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-13 13:56:13.479+0900 D/INDICATOR( 2846): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-13 13:56:13.479+0900 D/INDICATOR( 2846): main.c: _rotate_window(252) > port :: hide more icon
06-13 13:56:13.479+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(838) > __request_handler: 15
06-13 13:56:13.479+0900 D/PKGMGR_INFO( 2747): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-13 13:56:13.479+0900 D/PKGMGR_INFO( 2747): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-13 13:56:13.479+0900 D/AUL_AMD ( 2747): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 3135 is org.example.example
06-13 13:56:13.479+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 3135 : 0
06-13 13:56:13.479+0900 D/AUL     ( 2934): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-13 13:56:13.659+0900 D/APP_CORE( 3135): appcore.c: __prt_ltime(236) > [APP 3135] first idle after reset: 304 msec
06-13 13:56:13.719+0900 E/E17     ( 2765): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
06-13 13:56:13.719+0900 D/APP_CORE( 2863): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
06-13 13:56:13.719+0900 D/APP_CORE( 2863): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-13 13:56:13.719+0900 D/APP_CORE( 2863): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-13 13:56:13.719+0900 I/APP_CORE( 2863): appcore-efl.c: __do_app(496) > [APP 2863] Event: PAUSE State: RUNNING
06-13 13:56:13.719+0900 D/APP_CORE( 2863): appcore-efl.c: __do_app(565) > [APP 2863] PAUSE
06-13 13:56:13.719+0900 I/CAPI_APPFW_APPLICATION( 2863): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-13 13:56:13.719+0900 E/cluster-home( 2863): homescreen.cpp: OnPause(84) >  app pause
06-13 13:56:13.719+0900 D/cluster-view( 2863): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-13 13:56:13.719+0900 D/cluster-view( 2863): homescreen-view-manager.cpp: AppPause(923) >  END
06-13 13:56:13.719+0900 D/APP_CORE( 2863): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-13 13:56:13.719+0900 E/APP_CORE( 2863): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-13 13:56:13.719+0900 D/AUL_AMD ( 2747): amd_status.c: _status_update_app_info_list(456) > pid(2863) status(4)
06-13 13:56:13.719+0900 D/AUL_AMD ( 2747): amd_status.c: _status_update_app_info_list(468) > pid(2863) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-13 13:56:13.719+0900 D/AUL     ( 2747): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-13 13:56:13.719+0900 W/AUL     ( 2747): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2863, appid: org.tizen.homescreen, status: bg
06-13 13:56:13.729+0900 D/AUL_AMD ( 2747): amd_launch.c: __e17_status_handler(2891) > pid(3135) status(3)
06-13 13:56:13.729+0900 D/AUL_AMD ( 2747): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-13 13:56:13.729+0900 D/DATA_PROVIDER_MASTER( 2922): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2863 is paused
06-13 13:56:13.729+0900 D/DATA_PROVIDER_MASTER( 2922): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-13 13:56:13.729+0900 I/CAPI_WIDGET_APPLICATION( 3008): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-13 13:56:13.729+0900 I/CAPI_WIDGET_APPLICATION( 3008): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-13 13:56:13.729+0900 W/AUL     ( 3008): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3008, appid: org.tizen.calendar.widget, status: bg
06-13 13:56:13.739+0900 D/RESOURCED( 2842): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3008, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-13 13:56:13.739+0900 D/RESOURCED( 2842): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3008
06-13 13:56:13.739+0900 D/RESOURCED( 2842): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3008, appname = org.tizen.calendar.widget
06-13 13:56:13.739+0900 D/RESOURCED( 2842): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3008
06-13 13:56:13.739+0900 W/AUL_AMD ( 2747): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 13:56:13.739+0900 W/AUL_AMD ( 2747): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-13 13:56:13.739+0900 D/AUL_AMD ( 2747): amd_status.c: _status_update_app_info_list(456) > pid(3135) status(3)
06-13 13:56:13.739+0900 D/AUL_AMD ( 2747): amd_status.c: _status_update_app_info_list(468) > pid(3135) appid(org.example.example) pkgid(org.example.example) status(3)
06-13 13:56:13.739+0900 D/AUL     ( 2747): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-13 13:56:13.739+0900 W/AUL     ( 2747): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3135, appid: org.example.example, status: fg
06-13 13:56:13.739+0900 D/APP_CORE( 3135): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1200002 fully_obscured 0
06-13 13:56:13.739+0900 D/APP_CORE( 3135): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-13 13:56:13.739+0900 D/APP_CORE( 3135): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-13 13:56:13.739+0900 I/APP_CORE( 3135): appcore-efl.c: __do_app(496) > [APP 3135] Event: RESUME State: CREATED
06-13 13:56:13.739+0900 D/LAUNCH  ( 3135): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-13 13:56:13.739+0900 D/APP_CORE( 3135): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-13 13:56:13.739+0900 D/APP_CORE( 3135): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-13 13:56:13.739+0900 D/APP_CORE( 3135): appcore-efl.c: __do_app(607) > [APP 3135] RESUME
06-13 13:56:13.739+0900 D/RESOURCED( 2842): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 3135
06-13 13:56:13.739+0900 D/RESOURCED( 2842): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3135, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-13 13:56:13.739+0900 D/RESOURCED( 2842): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 3135
06-13 13:56:13.749+0900 I/APP_CORE( 3135): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-13 13:56:13.749+0900 I/APP_CORE( 3135): appcore-efl.c: __do_app(614) > [APP 3135] Initial Launching, call the resume_cb
06-13 13:56:13.749+0900 I/CAPI_APPFW_APPLICATION( 3135): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-13 13:56:13.749+0900 D/LAUNCH  ( 3135): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-13 13:56:13.749+0900 D/LAUNCH  ( 3135): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-13 13:56:13.749+0900 D/APP_CORE( 3135): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-13 13:56:13.749+0900 E/APP_CORE( 3135): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-13 13:56:13.809+0900 D/RESOURCED( 2842): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 3135, appname = org.example.example, pkgname = org.example.example
06-13 13:56:13.809+0900 D/RESOURCED( 2842): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 3135, appname = org.example.example
06-13 13:56:13.809+0900 D/RESOURCED( 2842): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 3135
06-13 13:56:13.809+0900 I/RESOURCED( 2842): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-13 13:56:13.809+0900 I/RESOURCED( 2842): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-13 13:56:13.889+0900 D/AUL_AMD ( 2747): amd_launch.c: __e17_status_handler(2910) > pid(3135) status(0)
06-13 13:56:13.999+0900 E/PKGMGR_SERVER( 3266): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 13:56:13.999+0900 E/PKGMGR_SERVER( 3266): pkgmgr-server.c: main(2265) > package manager server terminated.
06-13 13:56:14.459+0900 D/AUL_PAD ( 2910): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-13 13:56:14.459+0900 D/AUL_PAD ( 3344): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-13 13:56:14.469+0900 D/AUL_PAD ( 2910): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-13 13:56:14.469+0900 E/RESOURCED( 2842): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.153
06-13 13:56:14.959+0900 D/AUL_AMD ( 2747): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-13 13:56:14.959+0900 D/RUA     ( 2747): rua.c: rua_add_history(179) > rua_add_history start
06-13 13:56:14.979+0900 D/RUA     ( 2747): rua.c: rua_add_history(247) > rua_add_history ok
06-13 13:56:15.488+0900 D/AUL_PAD ( 3344): launchpad_loader.c: main(588) > sleeping 1 sec...
06-13 13:56:15.488+0900 D/AUL_PAD ( 3344): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-13 13:56:15.498+0900 D/AUL_PAD ( 3344): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b8020760
06-13 13:56:15.498+0900 D/AUL_PAD ( 3344): preload.h: __preload_init(69) > get pre-initialization function
06-13 13:56:15.498+0900 D/AUL_PAD ( 3344): preload.h: __preload_init(73) > get shutdown function
06-13 13:56:15.498+0900 D/AUL_PAD ( 3344): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b8020a40
06-13 13:56:15.508+0900 D/AUL_PAD ( 3344): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b8022640
06-13 13:56:15.508+0900 D/AUL_PAD ( 3344): preload.h: __preload_init(69) > get pre-initialization function
06-13 13:56:15.508+0900 D/AUL_PAD ( 3344): preload.h: __preload_init(73) > get shutdown function
06-13 13:56:15.508+0900 D/AUL_PAD ( 3344): preexec.h: __preexec_init(76) > preexec start
06-13 13:56:15.508+0900 D/AUL_PAD ( 3344): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-13 13:56:15.508+0900 D/AUL     ( 3344): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-13 13:56:15.508+0900 D/AUL     ( 3344): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-13 13:56:15.508+0900 D/AUL     ( 3344): process_pool.c: __connect_to_launchpad(132) > send(3344) : 4
06-13 13:56:15.508+0900 D/AUL     ( 3344): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-13 13:56:15.518+0900 D/AUL_PAD ( 2910): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-13 13:56:15.518+0900 D/AUL_PAD ( 2910): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-13 13:56:15.518+0900 D/AUL_PAD ( 2910): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-13 13:56:15.518+0900 D/AUL_PAD ( 2910): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-13 13:56:15.518+0900 D/AUL_PAD ( 2910): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-13 13:56:15.518+0900 D/AUL_PAD ( 2910): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-13 13:56:15.518+0900 D/AUL_PAD ( 2910): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-13 13:56:15.518+0900 D/AUL_PAD ( 2910): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-13 13:56:15.518+0900 D/AUL_PAD ( 2910): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 3344
06-13 13:56:15.668+0900 D/AUL_PAD ( 3344): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-13 13:56:15.678+0900 D/AUL_PAD ( 3344): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-13 13:56:15.678+0900 D/AUL_PAD ( 3344): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-13 13:56:15.688+0900 D/AUL_PAD ( 3344): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-13 13:56:16.688+0900 E/AUL_AMD ( 2747): amd_main.c: __platform_ready_handler(429) > [Info]__platform_ready_handler
06-13 13:56:17.048+0900 D/ALARM_MANAGER( 3077): alarm-lib.c: alarmmgr_fini(481) > [SECURE_LOG] Enter
06-13 13:56:17.048+0900 D/ALARM_MANAGER( 3077): alarm-lib.c: alarmmgr_fini(503) > [SECURE_LOG] Leave
06-13 13:56:18.188+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:56:18.188+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:56:18.188+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:56:18.188+0900 E/INDICATOR( 2846): 
06-13 13:56:18.728+0900 D/APP_CORE( 2863): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
06-13 13:56:18.728+0900 I/APP_CORE( 2863): appcore-efl.c: __do_app(496) > [APP 2863] Event: MEM_FLUSH State: PAUSED
06-13 13:56:18.728+0900 D/APP_CORE( 2863): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
06-13 13:56:18.728+0900 D/APP_CORE( 2863): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2863
06-13 13:56:18.728+0900 D/APP_CORE( 2863): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
06-13 13:56:18.728+0900 D/RESOURCED( 2842): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2863
06-13 13:56:21.248+0900 I/service ( 3135): socket
06-13 13:56:21.248+0900 I/example ( 3135): m
06-13 13:56:21.338+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400216 
06-13 13:56:22.338+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1200002
06-13 13:56:27.348+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x400216 bd->visible=1
06-13 13:56:38.208+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:56:38.208+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:56:38.208+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:56:38.208+0900 E/INDICATOR( 2846): 
06-13 13:56:58.228+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:56:58.228+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:56:58.228+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:56:58.228+0900 E/INDICATOR( 2846): 
06-13 13:57:00.948+0900 D/INDICATOR( 2846): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-13 13:57:00.948+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-13 13:57:00.948+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 13:57:00.948+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 1:57 4 h"
06-13 13:57:00.948+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 1:57"
06-13 13:57:00.948+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 1&#x2236;57"
06-13 13:57:00.948+0900 D/INDICATOR( 2846): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147223043 Time: <font_size=33>1&#x2236;57</font_size> <font_size=32>PM</font_size></font>
06-13 13:57:13.148+0900 D/RESOURCED( 2842): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 13:57:13.148+0900 I/RESOURCED( 2842): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 13:57:13.148+0900 D/RESOURCED( 2842): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 13:57:13.148+0900 I/RESOURCED( 2842): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 13:57:13.598+0900 D/DOWNLOAD_PROVIDER( 2933): download-provider-client-manager.c: dp_client_manager(700) > 0 clients are active now
06-13 13:57:13.598+0900 D/DOWNLOAD_PROVIDER( 2933): download-provider-client-manager.c: __dp_manage_client_requests(315) > slot_index:0
06-13 13:57:13.598+0900 D/PKGMGR_INFO( 2933): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/download-provider' and package_app_info.app_disable IN ('false','False')
06-13 13:57:13.598+0900 D/PKGMGR_INFO( 2933): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/download-provider' and package_app_info.app_disable IN ('false','False')
06-13 13:57:13.598+0900 I/AUL     ( 2933): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/download-provider, ret : 0
06-13 13:57:13.598+0900 D/AUL     ( 2933): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 2933, pid = 2933
06-13 13:57:13.598+0900 D/PKGMGR_INFO( 2933): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/download-provider' and package_app_info.app_disable IN ('false','False')
06-13 13:57:13.598+0900 D/PKGMGR_INFO( 2933): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/download-provider' and package_app_info.app_disable IN ('false','False')
06-13 13:57:13.598+0900 I/AUL     ( 2933): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/download-provider, ret : 0
06-13 13:57:13.598+0900 D/DATA_PROVIDER_MASTER( 2922): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [46]
06-13 13:57:13.598+0900 D/DATA_PROVIDER_MASTER( 2922): notification_service.c: service_thread_main(864) > [SECURE_LOG] 0xb2100468 REQ: Command: [del_noti_multiple]
06-13 13:57:13.598+0900 D/DATA_PROVIDER_MASTER( 2922): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 92 bytes
06-13 13:57:13.608+0900 D/DATA_PROVIDER_MASTER( 2922): notification_service.c: _handler_delete_multiple(345) > [SECURE_LOG] pkgname: [/usr/bin/download-provider] type: [1]
06-13 13:57:13.608+0900 D/DATA_PROVIDER_MASTER( 2922): notification_service.c: _handler_delete_multiple(348) > [SECURE_LOG] ret: [0] num_deleted: [0]
06-13 13:57:13.608+0900 D/DATA_PROVIDER_MASTER( 2922): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
06-13 13:57:13.608+0900 D/COM_CORE( 2933): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2922, fd: -1
06-13 13:57:13.608+0900 D/COM_CORE( 2933): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 8 bytes (pid: 2922), fd: -1
06-13 13:57:13.608+0900 D/COM_CORE( 2933): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 3 (recv_fd: -1)
06-13 13:57:13.608+0900 E/NOTIFICATION( 2933): notification_ipc.c: notification_ipc_request_delete_multiple(1289) > [SECURE_LOG] [notification_ipc_request_delete_multiple : 1289] num deleted:0
06-13 13:57:13.608+0900 D/DOWNLOAD_PROVIDER( 2933): download-provider-client-manager.c: __dp_db_free_client_manager(110) > [SECURE_LOG] TRY to close [.download-provider-clients]
06-13 13:57:13.608+0900 D/COM_CORE( 2922): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
06-13 13:57:13.608+0900 D/DOWNLOAD_PROVIDER( 2933): download-provider-client-manager.c: dp_client_manager(723) > try to deallocate the resources for all clients
06-13 13:57:13.608+0900 I/DOWNLOAD_PROVIDER( 2933): download-provider-client-manager.c: dp_client_manager(738) > client-manager's working is done
06-13 13:57:13.608+0900 D/DATA_PROVIDER_MASTER( 2922): notification_service.c: service_thread_main(851) > [SECURE_LOG] TCB: 0xb2100468 is terminated
06-13 13:57:13.608+0900 D/DATA_PROVIDER_MASTER( 2922): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
06-13 13:57:13.608+0900 E/WIFI_DIRECT( 2933): wifi-direct-client-proxy.c: wifi_direct_unset_connection_state_changed_cb(1342) > http://tizen.org/feature/network.wifi.direct feature is disabled
06-13 13:57:13.608+0900 E/WIFI_DIRECT( 2933): wifi-direct-client-proxy.c: wifi_direct_deinitialize(1070) > http://tizen.org/feature/network.wifi.direct feature is disabled
06-13 13:57:13.608+0900 I/CAPI_NETWORK_CONNECTION( 2933): connection.c: __connection_set_type_changed_callback(175) > Successfully de-registered(0)
06-13 13:57:13.608+0900 I/CAPI_NETWORK_CONNECTION( 2933): connection.c: __connection_set_ip_changed_callback(262) > Successfully de-registered(0)
06-13 13:57:13.608+0900 I/CAPI_NETWORK_CONNECTION( 2933): connection.c: connection_destroy(426) > Destroy handle: 0xb9269810
06-13 13:57:13.608+0900 I/DOWNLOAD_PROVIDER( 2933): download-provider-main.c: main(64) > download-provider's working is done
06-13 13:57:18.238+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:57:18.238+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:57:18.238+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:57:18.238+0900 E/INDICATOR( 2846): 
06-13 13:57:38.267+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:57:38.267+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:57:38.267+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:57:38.267+0900 E/INDICATOR( 2846): 
06-13 13:57:58.277+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:57:58.277+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:57:58.277+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:57:58.277+0900 E/INDICATOR( 2846): 
06-13 13:58:00.957+0900 D/INDICATOR( 2846): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-13 13:58:00.957+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-13 13:58:00.957+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 13:58:00.957+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 1:58 4 h"
06-13 13:58:00.957+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 1:58"
06-13 13:58:00.957+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 1&#x2236;58"
06-13 13:58:00.957+0900 D/INDICATOR( 2846): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147221502 Time: <font_size=33>1&#x2236;58</font_size> <font_size=32>PM</font_size></font>
06-13 13:58:06.797+0900 I/service ( 3135): socket
06-13 13:58:06.797+0900 I/example ( 3135): m
06-13 13:58:06.827+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400216 
06-13 13:58:07.827+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1200002
06-13 13:58:12.837+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x400216 bd->visible=1
06-13 13:58:13.137+0900 D/RESOURCED( 2842): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 13:58:13.137+0900 I/RESOURCED( 2842): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 13:58:13.137+0900 D/RESOURCED( 2842): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 13:58:13.137+0900 I/RESOURCED( 2842): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 13:58:18.297+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:58:18.297+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:58:18.297+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:58:18.297+0900 E/INDICATOR( 2846): 
06-13 13:58:23.067+0900 I/service ( 3135): socket
06-13 13:58:23.067+0900 I/example ( 3135): m
06-13 13:58:23.157+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400216 
06-13 13:58:24.157+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1200002
06-13 13:58:27.527+0900 I/service ( 3135): socket
06-13 13:58:27.527+0900 I/example ( 3135): m
06-13 13:58:27.617+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400216 
06-13 13:58:28.127+0900 I/service ( 3135): socket
06-13 13:58:28.127+0900 I/example ( 3135): m
06-13 13:58:28.157+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400216 
06-13 13:58:28.557+0900 I/service ( 3135): socket
06-13 13:58:28.557+0900 I/example ( 3135): m
06-13 13:58:28.617+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400216 
06-13 13:58:29.167+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x400216 bd->visible=1
06-13 13:58:38.327+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:58:38.327+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:58:38.327+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:58:38.327+0900 E/INDICATOR( 2846): 
06-13 13:58:58.346+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:58:58.346+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:58:58.346+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:58:58.346+0900 E/INDICATOR( 2846): 
06-13 13:59:00.966+0900 D/INDICATOR( 2846): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-13 13:59:00.966+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-13 13:59:00.966+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 13:59:00.966+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 1:59 4 h"
06-13 13:59:00.966+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 1:59"
06-13 13:59:00.966+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 1&#x2236;59"
06-13 13:59:00.966+0900 D/INDICATOR( 2846): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147219450 Time: <font_size=33>1&#x2236;59</font_size> <font_size=32>PM</font_size></font>
06-13 13:59:13.166+0900 D/RESOURCED( 2842): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 13:59:13.166+0900 I/RESOURCED( 2842): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 13:59:13.166+0900 D/RESOURCED( 2842): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 13:59:13.166+0900 I/RESOURCED( 2842): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 13:59:13.976+0900 E/PKGMGR_SERVER( 3384): pkgmgr-server.c: main(2209) > package manager server start
06-13 13:59:13.976+0900 D/PKGMGR  ( 3384): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(405) > initialize_gdbus Enter
06-13 13:59:13.976+0900 D/PKGMGR  ( 3384): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(423) > initialize_gdbus Exit
06-13 13:59:13.996+0900 D/PKGMGR  ( 3384): comm_pkg_mgr_server.c: on_bus_acquired(376) > on_bus_acquired
06-13 13:59:13.996+0900 D/PKGMGR  ( 3384): comm_pkg_mgr_server.c: on_bus_acquired(400) > on_bus_acquired done
06-13 13:59:14.016+0900 D/PKGMGR  ( 3384): comm_pkg_mgr_server.c: pkgmgr_request(145) > Called
06-13 13:59:14.016+0900 D/PKGMGR  ( 3384): comm_pkg_mgr_server.c: pkgmgr_request(164) > sender_name: :1.156
06-13 13:59:14.026+0900 D/PKGMGR  ( 3384): comm_pkg_mgr_server.c: pkg_mgr_get_sender_pid(79) > zone pid : 3382
06-13 13:59:14.026+0900 D/PKGMGR  ( 3384): comm_pkg_mgr_server.c: pkgmgr_request(166) > sender_pid: 3382
06-13 13:59:14.026+0900 D/PKGMGR  ( 3384): comm_pkg_mgr_server.c: pkgmgr_request(175) > [SECURE_LOG] Call request callback(obj, org.example.example_1275369539, 14, tpk, org.example.example, , host)
06-13 13:59:14.026+0900 D/PKGMGR_SERVER( 3384): pkgmgr-server.c: req_cb(625) > [SECURE_LOG] >> in callback >> Got request: [org.example.example_1275369539] [14] [tpk] [org.example.example] [] [] [host]
06-13 13:59:14.026+0900 D/PKGMGR_SERVER( 3384): pkgmgr-server.c: req_cb(646) > req_type=(14)  backend_flag=(0) zone(host)
06-13 13:59:14.026+0900 D/PKGMGR_SERVER( 3384): pkgmgr-server.c: queue_job(1880) > target zone(host, host)
06-13 13:59:14.026+0900 D/PKGMGR_SERVER( 3384): pkgmgr-server.c: queue_job(1884) > child forked [3387] for request type [14]
06-13 13:59:14.026+0900 D/PKGMGR_SERVER( 3384): pkgmgr-server.c: queue_job(2126) > parent exit
06-13 13:59:14.026+0900 D/PKGMGR_SERVER( 3387): pkgmgr-server.c: queue_job(1884) > child forked [0] for request type [14]
06-13 13:59:14.026+0900 D/PKGMGR_SERVER( 3387): pkgmgr-server.c: queue_job(2057) > kill/check request
06-13 13:59:14.026+0900 D/PKGMGR  ( 3382): pkgmgr.c: __check_sync_process(868) > info_file file is generated, result = 0
06-13 13:59:14.026+0900 D/PKGMGR  ( 3382): . 
06-13 13:59:14.026+0900 E/PKGMGR  ( 3382): pkgmgr.c: __check_sync_process(884) > file is can not remove[/tmp/org.example.example, -1]
06-13 13:59:14.046+0900 D/PKGMGR_SERVER( 3387): pkgmgr-server.c: __pkgcmd_app_cb(1458) > sub_cmd(kill), zone_name(host)
06-13 13:59:14.056+0900 D/AUL     ( 3387): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(14)
06-13 13:59:14.056+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(838) > __request_handler: 14
06-13 13:59:14.056+0900 D/AUL_AMD ( 2747): amd_status.c: _status_app_is_running_from_cache(836) > is_running hit cache, return immediately
06-13 13:59:14.056+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(1028) > [SECURE_LOG] APP_IS_RUNNING : org.example.example : 3135
06-13 13:59:14.056+0900 W/AUL_AMD ( 2747): amd_request.c: __send_result_to_client(150) > __send_result_to_client, pid: 3135
06-13 13:59:14.056+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(838) > __request_handler: 12
06-13 13:59:14.056+0900 D/AUL     ( 3387): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 292
06-13 13:59:14.056+0900 D/AUL     ( 3387): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : 3135
06-13 13:59:14.056+0900 D/AUL     ( 3387): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(5)
06-13 13:59:14.066+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(838) > __request_handler: 5
06-13 13:59:14.066+0900 D/AUL_AMD ( 2747): amd_appinfo.c: appinfo_set_value(905) > [SECURE_LOG] org.example.example : installed : norestart
06-13 13:59:14.066+0900 D/AUL_AMD ( 2747): amd_request.c: __app_process_by_pid(279) > [SECURE_LOG] __app_process_by_pid, pid: 3135, 
06-13 13:59:14.066+0900 D/AUL     ( 2747): app_sock.c: __app_send_raw_with_delay_reply(455) > pid(3135) : cmd(4)
06-13 13:59:14.066+0900 D/AUL_AMD ( 2747): amd_launch.c: _term_app(1076) > term done
06-13 13:59:14.066+0900 D/AUL_AMD ( 2747): amd_launch.c: __set_reply_handler(1015) > listen fd : 31, send fd : 30
06-13 13:59:14.066+0900 D/APP_CORE( 3135): appcore.c: __aul_handler(632) > [APP 3135]     AUL event: AUL_TERMINATE
06-13 13:59:14.066+0900 I/APP_CORE( 3135): appcore-efl.c: __do_app(496) > [APP 3135] Event: TERMINATE State: RUNNING
06-13 13:59:14.066+0900 D/APP_CORE( 3135): appcore-efl.c: __do_app(517) > [APP 3135] TERMINATE
06-13 13:59:14.066+0900 W/AUL_AMD ( 2747): amd_launch.c: __reply_handler(913) > listen fd(31) , send fd(30), pid(3135), cmd(4)
06-13 13:59:14.066+0900 D/RESOURCED( 2842): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 3135
06-13 13:59:14.066+0900 D/AUL     ( 3387): launch.c: app_request_to_launchpad(425) > launch request result : 0
06-13 13:59:14.066+0900 D/AUL     ( 3387): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(14)
06-13 13:59:14.066+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(838) > __request_handler: 14
06-13 13:59:14.066+0900 D/AUL_AMD ( 2747): amd_status.c: _status_app_is_running_from_cache(836) > is_running hit cache, return immediately
06-13 13:59:14.066+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(1028) > [SECURE_LOG] APP_IS_RUNNING : org.example.example : 3135
06-13 13:59:14.066+0900 W/AUL_AMD ( 2747): amd_request.c: __send_result_to_client(150) > __send_result_to_client, pid: 3135
06-13 13:59:14.066+0900 D/AUL     ( 3135): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-13 13:59:14.066+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(838) > __request_handler: 22
06-13 13:59:14.066+0900 W/AUL_AMD ( 2747): amd_request.c: __request_handler(1056) > app status : 5
06-13 13:59:14.066+0900 D/AUL     ( 3135): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-13 13:59:14.076+0900 D/AUL_AMD ( 2747): amd_status.c: _status_update_app_info_list(456) > pid(3135) status(5)
06-13 13:59:14.076+0900 D/AUL_AMD ( 2747): amd_status.c: _status_update_app_info_list(468) > pid(3135) appid(org.example.example) pkgid(org.example.example) status(5)
06-13 13:59:14.076+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(838) > __request_handler: 22
06-13 13:59:14.076+0900 W/AUL_AMD ( 2747): amd_request.c: __request_handler(1056) > app status : 5
06-13 13:59:14.076+0900 D/AUL_AMD ( 2747): amd_status.c: _status_update_app_info_list(456) > pid(3135) status(5)
06-13 13:59:14.076+0900 D/AUL_AMD ( 2747): amd_status.c: _status_update_app_info_list(468) > pid(3135) appid(org.example.example) pkgid(org.example.example) status(5)
06-13 13:59:14.076+0900 D/APP_CORE( 3135): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
06-13 13:59:14.076+0900 D/APP_CORE( 3135): appcore-efl.c: __after_loop(1169) > [APP 3135] PAUSE before termination
06-13 13:59:14.076+0900 I/CAPI_APPFW_APPLICATION( 3135): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-13 13:59:14.076+0900 I/user_tag0( 3135): /opt/usr/apps/org.example.example/data/test.db
06-13 13:59:14.126+0900 W/CRASH_MANAGER( 3389): worker.c: worker_job(1204) > 1103135657861149732995
