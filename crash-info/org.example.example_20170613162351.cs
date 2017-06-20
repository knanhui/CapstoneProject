S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 3904
Date: 2017-06-13 16:23:51+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000000, esi = 0xb8096668
ebp = 0xbfe786d8, esp = 0xbfe78670
eax = 0xb8096668, ebx = 0xb6b4a0d4
ecx = 0xb3757000, edx = 0x00000000
eip = 0xb6b281f6

Memory Information
MemTotal:      123 KB
MemFree:        31 KB
Buffers:         8 KB
Cached:     152908 KB
VmPeak:     114964 KB
VmSize:     114964 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       27000 KB
VmRSS:       27000 KB
VmData:      46732 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34612 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 3904 TID = 3904
3904 3907 4042 4049 

Maps Information
b2ae8000 b2af2000 r-xp /usr/lib/libfeedback.so.0.1.4
b2af8000 b2b04000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b05000 b2b26000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2b2b000 b2b2c000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2b2d000 b2b32000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2b33000 b2b34000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2b35000 b2b37000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2b38000 b2b3a000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2b3b000 b2b47000 r-xp /usr/lib/libdrm.so.2.4.0
b2b48000 b2b4b000 r-xp /usr/lib/libdri2.so.0.0.0
b2b4c000 b2b56000 r-xp /usr/lib/libtbm.so.1.0.0
b2b57000 b2b58000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b2b59000 b2b6e000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2b6f000 b2b81000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3383000 b33b4000 r-xp /usr/lib/libidn.so.11.5.44
b33b5000 b33d7000 r-xp /usr/lib/libnghttp2.so.5.4.0
b33d8000 b33e8000 r-xp /usr/lib/libcares.so.2.1.0
b33e9000 b33f2000 r-xp /usr/lib/libeventsystem.so.0.0.1
b33f3000 b33f9000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b33fa000 b3410000 r-xp /usr/lib/libalarm.so.0.0.0
b3412000 b341b000 r-xp /usr/lib/libefl-extension.so.0.1.0
b341c000 b3493000 r-xp /usr/lib/libcurl.so.4.3.0
b3495000 b34a7000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34a8000 b34ab000 r-xp /usr/lib/libcapi-message-port.so.1.2.2.1
b34ac000 b34af000 r-xp /usr/lib/libcapi-appfw-alarm.so.0.3.1.0
b34b0000 b34d1000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b34d8000 b34d9000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b34da000 b34db000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b34dc000 b34df000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b34e0000 b34e3000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b35eb000 b35f1000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b35f2000 b3736000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3746000 b3755000 r-xp /opt/usr/apps/org.example.example/bin/example
b3758000 b3791000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4194000 b419f000 r-xp /lib/libnss_files-2.20-2014.11.so
b41a1000 b41ac000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41ae000 b41c5000 r-xp /lib/libnsl-2.20-2014.11.so
b41c9000 b41d1000 r-xp /lib/libnss_compat-2.20-2014.11.so
b41d3000 b41f7000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b41f8000 b41f9000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b41fa000 b41fd000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b41fe000 b4205000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4206000 b4210000 r-xp /usr/lib/libsensord-share.so
b4211000 b422d000 r-xp /usr/lib/libsensor.so.1.2.0
b422f000 b4238000 r-xp /usr/lib/libappcore-common.so.1.1
b423b000 b423d000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4252000 b4254000 r-xp /usr/lib/libXau.so.6.0.0
b4255000 b4277000 r-xp /usr/lib/libxcb.so.1.1.0
b4279000 b4282000 r-xp /lib/libcrypt-2.20-2014.11.so
b42ab000 b42ad000 r-xp /usr/lib/libiri.so
b42ae000 b42d4000 r-xp /lib/libexpat.so.1.5.2
b42d6000 b4341000 r-xp /usr/lib/libssl.so.1.0.0
b4347000 b4353000 r-xp /usr/lib/libethumb.so.1.13.0
b4354000 b4358000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4359000 b45aa000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b25000 b5b35000 r-xp /usr/lib/libXi.so.6.1.0
b5b36000 b5b38000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b39000 b5b3f000 r-xp /usr/lib/libXtst.so.6.1.0
b5b40000 b5b4a000 r-xp /usr/lib/libXrender.so.1.3.0
b5b4b000 b5b54000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b56000 b5b58000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b59000 b5b5e000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b5f000 b5b71000 r-xp /usr/lib/libXext.so.6.4.0
b5b72000 b5b74000 r-xp /usr/lib/libXdamage.so.1.1.0
b5b75000 b5b77000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5b79000 b5cbb000 r-xp /usr/lib/libX11.so.6.3.0
b5cbf000 b5cc9000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cca000 b5ce0000 r-xp /usr/lib/libudev.so.1.6.0
b5ce3000 b5ce7000 r-xp /lib/libattr.so.1.1.0
b5ce8000 b5d17000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d19000 b5d1f000 r-xp /usr/lib/libffi.so.6.0.2
b5d20000 b5d43000 r-xp /lib/libz.so.1.2.8
b5d44000 b5d47000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d48000 b5ea4000 r-xp /usr/lib/libxml2.so.2.9.2
b5eaa000 b5f91000 r-xp /usr/lib/libstdc++.so.6.0.20
b5f9e000 b5fa1000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fa2000 b5fc4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5fc5000 b5fd9000 r-xp /lib/libresolv-2.20-2014.11.so
b5fdd000 b6001000 r-xp /usr/lib/liblzma.so.5.0.3
b6002000 b6004000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6006000 b6010000 r-xp /usr/lib/libembryo.so.1.13.0
b6011000 b603a000 r-xp /usr/lib/libpng12.so.0.50.0
b603b000 b6084000 r-xp /usr/lib/libjpeg.so.8.0.2
b6095000 b609c000 r-xp /lib/librt-2.20-2014.11.so
b609e000 b60bd000 r-xp /usr/lib/libector.so.1.13.0
b60c0000 b60ed000 r-xp /usr/lib/liblua-5.1.so
b60ee000 b617e000 r-xp /usr/lib/libfreetype.so.6.11.3
b6182000 b61c0000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61c1000 b61d7000 r-xp /usr/lib/libfribidi.so.0.3.1
b61d8000 b6231000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6234000 b627f000 r-xp /lib/libm-2.20-2014.11.so
b6281000 b6293000 r-xp /usr/lib/libeio.so.1.13.0
b6294000 b6297000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6298000 b629e000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b629f000 b62c2000 r-xp /usr/lib/libefreet.so.1.13.0
b62c5000 b62f0000 r-xp /usr/lib/libeldbus.so.1.13.0
b62f1000 b6325000 r-xp /usr/lib/libecore_con.so.1.13.0
b6327000 b6330000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6331000 b633a000 r-xp /usr/lib/libethumb_client.so.1.13.0
b633b000 b634e000 r-xp /usr/lib/libeo.so.1.13.0
b6350000 b6363000 r-xp /usr/lib/libecore_input.so.1.13.0
b6364000 b636b000 r-xp /usr/lib/libecore_file.so.1.13.0
b636c000 b638f000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6390000 b63bc000 r-xp /usr/lib/libeet.so.1.13.0
b63c5000 b6430000 r-xp /usr/lib/libeina.so.1.13.0
b6433000 b644a000 r-xp /usr/lib/libefl.so.1.13.0
b644c000 b65b3000 r-xp /usr/lib/libicuuc.so.51.1
b65c1000 b67cd000 r-xp /usr/lib/libicui18n.so.51.1
b67d5000 b6824000 r-xp /usr/lib/libecore_x.so.1.13.0
b6826000 b6840000 r-xp /lib/libgcc_s-4.9.so.1
b6842000 b6846000 r-xp /lib/libcap.so.2.21
b6847000 b688d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b688e000 b6895000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6897000 b68e9000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b68eb000 b6a76000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6a7b000 b6b49000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b4c000 b6b50000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b51000 b6b60000 r-xp /usr/lib/libvconf.so.0.2.45
b6b61000 b6b64000 r-xp /usr/lib/libvasum.so.0.3.1
b6b65000 b6b68000 r-xp /usr/lib/libttrace.so.1.1
b6b6a000 b6b6e000 r-xp /usr/lib/libiniparser.so.0
b6b6f000 b6b9f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6ba0000 b6ba9000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6baa000 b6bcf000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bd0000 b6be0000 r-xp /usr/lib/libunwind.so.8.0.1
b6bea000 b6d98000 r-xp /lib/libc-2.20-2014.11.so
b6da0000 b6ee3000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6ee5000 b6f3d000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f3e000 b6f72000 r-xp /usr/lib/libsystemd.so.0.4.0
b6f75000 b7049000 r-xp /usr/lib/libedje.so.1.13.0
b704c000 b7078000 r-xp /usr/lib/libecore.so.1.13.0
b7089000 b72af000 r-xp /usr/lib/libevas.so.1.13.0
b72d7000 b72ef000 r-xp /lib/libpthread-2.20-2014.11.so
b72f3000 b766d000 r-xp /usr/lib/libelementary.so.1.13.0
b768d000 b7691000 r-xp /usr/lib/libsmack.so.1.0.0
b7692000 b769b000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b769c000 b769f000 r-xp /usr/lib/libdlog.so.0.0.0
b76a0000 b76a5000 r-xp /usr/lib/libbundle.so.0.1.22
b76a6000 b76a9000 r-xp /lib/libdl-2.20-2014.11.so
b76ab000 b76d0000 r-xp /usr/lib/libaul.so.0.1.0
b76d3000 b76d5000 r-xp /usr/lib/libappsvc.so.0.1.0
b76d6000 b76db000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b76dc000 b76e3000 r-xp /usr/lib/libappcore-efl.so.1.1
b76e5000 b76ea000 r-xp /usr/lib/libsys-assert.so
b76ed000 b76ee000 r-xp [vdso]
b76ee000 b7710000 r-xp /lib/ld-2.20-2014.11.so
b7712000 b771a000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:3904)
Call Stack Count: 9
 0: (0xb6b281f6) [/usr/lib/libsqlite3.so.0] + 0xad1f6
 1: open_db + 0x116 (0xb3751186) [/opt/usr/apps/org.example.example/bin/example] + 0xb186
 2: app_pause + 0x2a (0xb374fc4a) [/opt/usr/apps/org.example.example/bin/example] + 0x9c4a
 3: (0xb76d7ce2) [/usr/lib/libcapi-appfw-application.so.0] + 0x1ce2
 4: appcore_efl_main + 0x85a (0xb76e015a) [/usr/lib/libappcore-efl.so.1] + 0x415a
 5: ui_app_main + 0x140 (0xb76d8c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
 6: main + 0x2a5 (0xb374fb75) [/opt/usr/apps/org.example.example/bin/example] + 0x9b75
 7: (0xb7714148) [/opt/usr/apps/org.example.example/bin/example] + 0xb7714148
 8: __libc_start_main + 0xde (0xb6c01e4e) [/lib/libc.so.6] + 0x17e4e
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
NDICATOR( 2826): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 16:22:00.775+0900 D/INDICATOR( 2826): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 4:22 4 h"
06-13 16:22:00.775+0900 D/INDICATOR( 2826): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 4:22"
06-13 16:22:00.775+0900 D/INDICATOR( 2826): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 4&#x2236;22"
06-13 16:22:00.775+0900 D/INDICATOR( 2826): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147201495 Time: <font_size=33>4&#x2236;22</font_size> <font_size=32>PM</font_size></font>
06-13 16:22:16.105+0900 E/CAPI_NETWORK_WIFI( 2826): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 16:22:16.105+0900 E/INDICATOR( 2826): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-13 16:22:16.105+0900 E/INDICATOR( 2826): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 16:22:16.105+0900 E/INDICATOR( 2826): 
06-13 16:22:30.725+0900 D/RESOURCED( 2824): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 16:22:30.725+0900 I/RESOURCED( 2824): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 16:22:30.725+0900 D/RESOURCED( 2824): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 16:22:30.725+0900 I/RESOURCED( 2824): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 16:22:30.725+0900 I/RESOURCED( 2824): logging.c: logging_save_to_storage(978) > storage cache is empty
06-13 16:22:36.125+0900 E/CAPI_NETWORK_WIFI( 2826): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 16:22:36.125+0900 E/INDICATOR( 2826): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-13 16:22:36.125+0900 E/INDICATOR( 2826): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 16:22:36.125+0900 E/INDICATOR( 2826): 
06-13 16:22:54.974+0900 E/PKGMGR_SERVER( 3985): pkgmgr-server.c: main(2209) > package manager server start
06-13 16:22:54.974+0900 D/PKGMGR  ( 3985): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(405) > initialize_gdbus Enter
06-13 16:22:54.974+0900 D/PKGMGR  ( 3985): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(423) > initialize_gdbus Exit
06-13 16:22:54.984+0900 D/PKGMGR  ( 3985): comm_pkg_mgr_server.c: on_bus_acquired(376) > on_bus_acquired
06-13 16:22:54.984+0900 D/PKGMGR  ( 3985): comm_pkg_mgr_server.c: on_bus_acquired(400) > on_bus_acquired done
06-13 16:22:54.994+0900 D/PKGMGR  ( 3985): comm_pkg_mgr_server.c: pkgmgr_request(145) > Called
06-13 16:22:54.994+0900 D/PKGMGR  ( 3985): comm_pkg_mgr_server.c: pkgmgr_request(164) > sender_name: :1.210
06-13 16:22:54.994+0900 D/PKGMGR  ( 3985): comm_pkg_mgr_server.c: pkg_mgr_get_sender_pid(79) > zone pid : 3983
06-13 16:22:54.994+0900 D/PKGMGR  ( 3985): comm_pkg_mgr_server.c: pkgmgr_request(166) > sender_pid: 3983
06-13 16:22:54.994+0900 D/PKGMGR  ( 3985): comm_pkg_mgr_server.c: pkgmgr_request(175) > [SECURE_LOG] Call request callback(obj, org.example.example_1306432135, 14, tpk, org.example.example, , host)
06-13 16:22:54.994+0900 D/PKGMGR_SERVER( 3985): pkgmgr-server.c: req_cb(625) > [SECURE_LOG] >> in callback >> Got request: [org.example.example_1306432135] [14] [tpk] [org.example.example] [] [] [host]
06-13 16:22:54.994+0900 D/PKGMGR_SERVER( 3985): pkgmgr-server.c: req_cb(646) > req_type=(14)  backend_flag=(0) zone(host)
06-13 16:22:54.994+0900 D/PKGMGR_SERVER( 3985): pkgmgr-server.c: queue_job(1880) > target zone(host, host)
06-13 16:22:54.994+0900 D/PKGMGR_SERVER( 3985): pkgmgr-server.c: queue_job(1884) > child forked [3988] for request type [14]
06-13 16:22:54.994+0900 D/PKGMGR_SERVER( 3988): pkgmgr-server.c: queue_job(1884) > child forked [0] for request type [14]
06-13 16:22:54.994+0900 D/PKGMGR_SERVER( 3988): pkgmgr-server.c: queue_job(2057) > kill/check request
06-13 16:22:54.994+0900 D/PKGMGR_SERVER( 3985): pkgmgr-server.c: queue_job(2126) > parent exit
06-13 16:22:55.004+0900 D/PKGMGR  ( 3983): pkgmgr.c: __check_sync_process(868) > info_file file is generated, result = 0
06-13 16:22:55.004+0900 D/PKGMGR  ( 3983): . 
06-13 16:22:55.004+0900 E/PKGMGR  ( 3983): pkgmgr.c: __check_sync_process(884) > file is can not remove[/tmp/org.example.example, -1]
06-13 16:22:55.004+0900 D/PKGMGR_SERVER( 3988): pkgmgr-server.c: __pkgcmd_app_cb(1458) > sub_cmd(kill), zone_name(host)
06-13 16:22:55.004+0900 D/AUL     ( 3988): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(14)
06-13 16:22:55.004+0900 D/AUL_AMD ( 2752): amd_request.c: __request_handler(838) > __request_handler: 14
06-13 16:22:55.004+0900 D/AUL_AMD ( 2752): amd_request.c: __request_handler(1028) > [SECURE_LOG] APP_IS_RUNNING : org.example.example : -1
06-13 16:22:55.014+0900 W/AUL_AMD ( 2752): amd_request.c: __send_result_to_client(150) > __send_result_to_client, pid: -1
06-13 16:22:55.014+0900 D/PKGMGR_SERVER( 3988): pkgmgr-server.c: __make_pid_info_file(1384) > cano_path(tmp/org.example.example)
06-13 16:22:55.014+0900 D/PKGMGR_SERVER( 3988): pkgmgr-server.c: __make_pid_info_file(1403) > security_server_label_access(tmp/org.example.example, *) is ok.
06-13 16:22:55.014+0900 D/PKGMGR_SERVER( 3985): pkgmgr-server.c: sighandler(387) > child exit [3988]
06-13 16:22:55.014+0900 E/PKGMGR_SERVER( 3985): pkgmgr-server.c: sighandler(402) > child NORMAL exit [3988]
06-13 16:22:55.504+0900 D/AUL_AMD ( 2752): amd_request.c: __request_handler(838) > __request_handler: 0
06-13 16:22:55.514+0900 D/AUL_AMD ( 2752): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-13 16:22:55.514+0900 D/PKGMGR_INFO( 2752): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-13 16:22:55.514+0900 D/PKGMGR_INFO( 2752): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-13 16:22:55.514+0900 I/AUL     ( 2752): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
06-13 16:22:55.514+0900 D/AUL     ( 2752): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 4035, pid = 4037
06-13 16:22:55.514+0900 D/PKGMGR_INFO( 2752): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-13 16:22:55.514+0900 D/PKGMGR_INFO( 2752): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-13 16:22:55.514+0900 I/AUL     ( 2752): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
06-13 16:22:55.514+0900 E/AUL_AMD ( 2752): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-13 16:22:55.514+0900 W/AUL_AMD ( 2752): amd_launch.c: _start_app(2233) > caller pid : 4037
06-13 16:22:55.514+0900 E/AUL_AMD ( 2752): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-13 16:22:55.514+0900 W/AUL_AMD ( 2752): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-13 16:22:55.514+0900 D/AUL_AMD ( 2752): amd_launch.c: _start_app(2648) > process_pool: false
06-13 16:22:55.514+0900 D/AUL_AMD ( 2752): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-13 16:22:55.514+0900 D/AUL_AMD ( 2752): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-13 16:22:55.514+0900 W/AUL_AMD ( 2752): amd_launch.c: _start_app(2665) > pad pid(-5)
06-13 16:22:55.514+0900 D/AUL_AMD ( 2752): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-13 16:22:55.514+0900 D/AUL_AMD ( 2752): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-13 16:22:55.514+0900 D/AUL     ( 2752): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-13 16:22:55.514+0900 D/AUL_PAD ( 2894): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-13 16:22:55.514+0900 D/AUL_PAD ( 2894): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-13 16:22:55.514+0900 D/AUL_PAD ( 2894): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-13 16:22:55.514+0900 D/AUL_PAD ( 2894): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-13 16:22:55.514+0900 D/AUL_PAD ( 2894): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-13 16:22:55.514+0900 D/AUL_PAD ( 2894): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-13 16:22:55.514+0900 D/AUL_PAD ( 2894): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-13 16:22:55.514+0900 D/AUL_PAD ( 2894): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-13 16:22:55.514+0900 D/RESOURCED( 2824): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-13 16:22:55.514+0900 D/RESOURCED( 2824): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-13 16:22:55.514+0900 D/AUL_PAD ( 2894): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-13 16:22:55.514+0900 D/AUL_PAD ( 2894): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-13 16:22:55.514+0900 D/AUL_PAD ( 2894): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-13 16:22:55.514+0900 D/AUL_PAD ( 2894): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-13 16:22:55.514+0900 D/AUL_PAD ( 2894): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-13 16:22:55.514+0900 D/AUL_PAD ( 2894): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-13 16:22:55.514+0900 W/AUL_PAD ( 2894): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-13 16:22:55.514+0900 D/AUL     ( 2894): process_pool.c: __send_pkt_raw_data(219) > send(13) : 620 / 620
06-13 16:22:55.514+0900 D/AUL_PAD ( 2894): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 3904, bin path: /opt/usr/apps/org.example.example/bin/example
06-13 16:22:55.514+0900 W/AUL_PAD ( 2894): launchpad.c: __send_result_to_caller(265) > Check app launching
06-13 16:22:55.514+0900 D/AUL_PAD ( 2894): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-13 16:22:55.514+0900 E/RESOURCED( 2824): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 16:22:55.514+0900 D/AUL_PAD ( 3904): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-13 16:22:55.514+0900 D/AUL_PAD ( 3904): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
06-13 16:22:55.514+0900 D/AUL_PAD ( 3904): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-13 16:22:55.514+0900 D/AUL_PAD ( 3904): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-13 16:22:55.514+0900 D/AUL_PAD ( 3904): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-13 16:22:55.514+0900 D/AUL_PAD ( 3904): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-13 16:22:55.514+0900 D/AUL     ( 3904): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (3907) is sent.
06-13 16:22:55.514+0900 D/AUL     ( 3904): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 3907, signo: 10
06-13 16:22:55.514+0900 D/AUL     ( 3904): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-13 16:22:55.514+0900 D/AUL_PAD ( 3904): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-13 16:22:55.514+0900 D/AUL_PAD ( 3904): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-13 16:22:55.514+0900 D/AUL_PAD ( 3904): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-13 16:22:55.514+0900 D/AUL_PAD ( 3904): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-13 16:22:55.514+0900 D/AUL_PAD ( 3904): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTczMzg1NzUvNTE5ODAwAA==##
06-13 16:22:55.514+0900 D/AUL_PAD ( 3904): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-13 16:22:55.514+0900 D/AUL_PAD ( 3904): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA0MDM3AA==##
06-13 16:22:55.514+0900 D/AUL_PAD ( 3904): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-13 16:22:55.514+0900 D/AUL_PAD ( 3904): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-13 16:22:55.514+0900 D/AUL_PAD ( 3904): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-13 16:22:55.514+0900 D/AUL_PAD ( 3904): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-13 16:22:55.514+0900 D/AUL_PAD ( 3904): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-13 16:22:55.524+0900 I/CAPI_APPFW_APPLICATION( 3904): app_main.c: ui_app_main(788) > app_efl_main
06-13 16:22:55.524+0900 D/LAUNCH  ( 3904): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-13 16:22:55.524+0900 D/APP_CORE( 3904): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-13 16:22:55.524+0900 D/APP_CORE( 3904): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-13 16:22:55.524+0900 D/APP_CORE( 3904): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-13 16:22:55.524+0900 D/APP_CORE( 3904): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-13 16:22:55.524+0900 D/AUL     ( 3904): app_sock.c: __create_server_sock(156) > pg path - already exists
06-13 16:22:55.524+0900 D/APP_CORE( 3904): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb4238520
06-13 16:22:55.524+0900 D/LAUNCH  ( 3904): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-13 16:22:55.524+0900 I/CAPI_APPFW_APPLICATION( 3904): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-13 16:22:55.564+0900 D/LAUNCH  ( 3904): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
06-13 16:22:55.564+0900 E/E17     ( 2675): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02600002)
06-13 16:22:55.564+0900 D/APP_CORE( 3904): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-13 16:22:55.574+0900 E/E17     ( 2675): e_border.c: e_border_show(2088) > BD_SHOW(0x02600002)
06-13 16:22:55.584+0900 D/APP_CORE( 3904): appcore.c: __aul_handler(587) > [APP 3904]     AUL event: AUL_START
06-13 16:22:55.584+0900 I/APP_CORE( 3904): appcore-efl.c: __do_app(496) > [APP 3904] Event: RESET State: CREATED
06-13 16:22:55.584+0900 D/APP_CORE( 3904): appcore-efl.c: __do_app(527) > [APP 3904] RESET
06-13 16:22:55.584+0900 D/LAUNCH  ( 3904): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
06-13 16:22:55.584+0900 D/APP_CORE( 3904): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-13 16:22:55.584+0900 D/APP_CORE( 3904): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-13 16:22:55.584+0900 I/CAPI_APPFW_APPLICATION( 3904): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-13 16:22:55.584+0900 D/AUL     ( 3904): service.c: __set_bundle(186) > __set_bundle
06-13 16:22:55.584+0900 D/LAUNCH  ( 3904): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-13 16:22:55.584+0900 D/APP_CORE( 3904): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-13 16:22:55.584+0900 E/EFL     ( 3904): edje<3904> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 16:22:55.584+0900 E/EFL     ( 3904): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 16:22:55.584+0900 E/EFL     ( 3904): edje<3904> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 16:22:55.584+0900 E/EFL     ( 3904): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 16:22:55.584+0900 E/EFL     ( 3904): edje<3904> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 16:22:55.584+0900 E/EFL     ( 3904): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 16:22:55.584+0900 E/EFL     ( 3904): edje<3904> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 16:22:55.584+0900 E/EFL     ( 3904): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 16:22:55.584+0900 E/EFL     ( 3904): edje<3904> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 16:22:55.584+0900 E/EFL     ( 3904): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 16:22:55.584+0900 W/PROCESSMGR( 2675): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=3904
06-13 16:22:55.584+0900 W/APP_CORE( 3904): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2600002
06-13 16:22:55.584+0900 D/APP_CORE( 3904): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2600002
06-13 16:22:55.584+0900 D/APP_CORE( 3904): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-13 16:22:55.584+0900 D/AUL     ( 3904): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-13 16:22:55.584+0900 E/EFL     ( 2675): eo<2675> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-13 16:22:55.584+0900 E/EFL     ( 2675): eo<2675> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-13 16:22:55.594+0900 D/INDICATOR( 2826): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
06-13 16:22:55.594+0900 D/INDICATOR( 2826): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-13 16:22:55.594+0900 D/INDICATOR( 2826): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-13 16:22:55.594+0900 D/INDICATOR( 2826): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-13 16:22:55.594+0900 D/INDICATOR( 2826): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-13 16:22:55.594+0900 D/INDICATOR( 2826): main.c: _rotate_window(252) > port :: hide more icon
06-13 16:22:55.614+0900 D/AUL_PAD ( 2894): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-13 16:22:55.614+0900 W/AUL     ( 2752): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 3904, appid: org.example.example
06-13 16:22:55.614+0900 D/AUL     ( 2752): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-13 16:22:55.614+0900 E/AUL     ( 2752): simple_util.c: __trm_app_info_send_socket(330) > access
06-13 16:22:55.614+0900 D/AUL_AMD ( 2752): amd_launch.c: _start_app(2700) > add app group info
06-13 16:22:55.614+0900 E/AUL     ( 2752): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-13 16:22:55.614+0900 D/AUL_AMD ( 2752): amd_status.c: _status_add_app_info_list(427) > pid(3904) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-13 16:22:55.614+0900 D/AUL_AMD ( 2752): amd_request.c: __request_handler(838) > __request_handler: 34
06-13 16:22:55.614+0900 D/AUL_AMD ( 2752): amd_request.c: __request_handler(838) > __request_handler: 15
06-13 16:22:55.614+0900 D/RESOURCED( 2824): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 3904
06-13 16:22:55.614+0900 D/RESOURCED( 2824): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-13 16:22:55.614+0900 E/RESOURCED( 2824): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-13 16:22:55.614+0900 D/RESOURCED( 2824): proc-main.c: resourced_proc_status_change(888) > available memory = 317
06-13 16:22:55.614+0900 D/PKGMGR_INFO( 2752): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-13 16:22:55.614+0900 D/PKGMGR_INFO( 2752): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-13 16:22:55.614+0900 D/AUL_AMD ( 2752): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 3904 is org.example.example
06-13 16:22:55.614+0900 D/AUL_AMD ( 2752): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 3904 : 0
06-13 16:22:55.614+0900 D/AUL     ( 2917): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-13 16:22:56.114+0900 E/CAPI_NETWORK_WIFI( 2826): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 16:22:56.114+0900 E/INDICATOR( 2826): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-13 16:22:56.114+0900 E/INDICATOR( 2826): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 16:22:56.114+0900 E/INDICATOR( 2826): 
06-13 16:22:56.144+0900 D/APP_CORE( 3904): appcore.c: __prt_ltime(236) > [APP 3904] first idle after reset: 633 msec
06-13 16:22:56.144+0900 E/E17     ( 2675): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
06-13 16:22:56.144+0900 D/APP_CORE( 2838): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
06-13 16:22:56.144+0900 D/APP_CORE( 2838): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-13 16:22:56.144+0900 D/APP_CORE( 2838): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-13 16:22:56.144+0900 I/APP_CORE( 2838): appcore-efl.c: __do_app(496) > [APP 2838] Event: PAUSE State: RUNNING
06-13 16:22:56.144+0900 D/APP_CORE( 2838): appcore-efl.c: __do_app(565) > [APP 2838] PAUSE
06-13 16:22:56.144+0900 I/CAPI_APPFW_APPLICATION( 2838): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-13 16:22:56.144+0900 E/cluster-home( 2838): homescreen.cpp: OnPause(84) >  app pause
06-13 16:22:56.144+0900 D/cluster-view( 2838): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-13 16:22:56.144+0900 D/cluster-view( 2838): homescreen-view-manager.cpp: AppPause(923) >  END
06-13 16:22:56.144+0900 D/APP_CORE( 2838): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-13 16:22:56.144+0900 E/APP_CORE( 2838): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-13 16:22:56.144+0900 D/AUL_AMD ( 2752): amd_status.c: _status_update_app_info_list(456) > pid(2838) status(4)
06-13 16:22:56.144+0900 D/AUL_AMD ( 2752): amd_status.c: _status_update_app_info_list(468) > pid(2838) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-13 16:22:56.144+0900 D/AUL     ( 2752): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-13 16:22:56.144+0900 W/AUL     ( 2752): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2838, appid: org.tizen.homescreen, status: bg
06-13 16:22:56.154+0900 D/DATA_PROVIDER_MASTER( 2896): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2838 is paused
06-13 16:22:56.154+0900 D/DATA_PROVIDER_MASTER( 2896): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-13 16:22:56.164+0900 D/AUL_AMD ( 2752): amd_launch.c: __e17_status_handler(2891) > pid(3904) status(3)
06-13 16:22:56.164+0900 D/AUL_AMD ( 2752): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-13 16:22:56.164+0900 I/CAPI_WIDGET_APPLICATION( 2993): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-13 16:22:56.164+0900 I/CAPI_WIDGET_APPLICATION( 2993): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-13 16:22:56.164+0900 W/AUL     ( 2993): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2993, appid: org.tizen.calendar.widget, status: bg
06-13 16:22:56.164+0900 D/RESOURCED( 2824): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 2993, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-13 16:22:56.164+0900 D/RESOURCED( 2824): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 2993
06-13 16:22:56.164+0900 D/RESOURCED( 2824): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 2993, appname = org.tizen.calendar.widget
06-13 16:22:56.164+0900 D/RESOURCED( 2824): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 2993
06-13 16:22:56.164+0900 W/AUL_AMD ( 2752): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 16:22:56.164+0900 W/AUL_AMD ( 2752): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-13 16:22:56.164+0900 D/AUL_AMD ( 2752): amd_status.c: _status_update_app_info_list(456) > pid(3904) status(3)
06-13 16:22:56.164+0900 D/AUL_AMD ( 2752): amd_status.c: _status_update_app_info_list(468) > pid(3904) appid(org.example.example) pkgid(org.example.example) status(3)
06-13 16:22:56.164+0900 D/AUL     ( 2752): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-13 16:22:56.164+0900 W/AUL     ( 2752): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3904, appid: org.example.example, status: fg
06-13 16:22:56.164+0900 D/RESOURCED( 2824): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 3904
06-13 16:22:56.164+0900 D/RESOURCED( 2824): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3904, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-13 16:22:56.164+0900 D/RESOURCED( 2824): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 3904
06-13 16:22:56.214+0900 D/RESOURCED( 2824): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 3904, appname = org.example.example, pkgname = org.example.example
06-13 16:22:56.214+0900 D/RESOURCED( 2824): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 3904, appname = org.example.example
06-13 16:22:56.214+0900 D/RESOURCED( 2824): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 3904
06-13 16:22:56.214+0900 I/RESOURCED( 2824): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-13 16:22:56.214+0900 I/RESOURCED( 2824): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-13 16:22:56.224+0900 D/APP_CORE( 3904): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2600002 fully_obscured 0
06-13 16:22:56.224+0900 D/APP_CORE( 3904): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-13 16:22:56.224+0900 D/APP_CORE( 3904): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-13 16:22:56.224+0900 I/APP_CORE( 3904): appcore-efl.c: __do_app(496) > [APP 3904] Event: RESUME State: CREATED
06-13 16:22:56.224+0900 D/LAUNCH  ( 3904): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-13 16:22:56.224+0900 D/APP_CORE( 3904): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-13 16:22:56.224+0900 D/APP_CORE( 3904): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-13 16:22:56.224+0900 D/APP_CORE( 3904): appcore-efl.c: __do_app(607) > [APP 3904] RESUME
06-13 16:22:56.224+0900 I/APP_CORE( 3904): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-13 16:22:56.224+0900 I/APP_CORE( 3904): appcore-efl.c: __do_app(614) > [APP 3904] Initial Launching, call the resume_cb
06-13 16:22:56.224+0900 I/CAPI_APPFW_APPLICATION( 3904): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-13 16:22:56.224+0900 D/LAUNCH  ( 3904): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-13 16:22:56.224+0900 D/LAUNCH  ( 3904): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-13 16:22:56.224+0900 D/APP_CORE( 3904): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-13 16:22:56.224+0900 E/APP_CORE( 3904): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-13 16:22:56.314+0900 D/AUL_AMD ( 2752): amd_launch.c: __e17_status_handler(2910) > pid(3904) status(0)
06-13 16:22:56.624+0900 D/AUL_PAD ( 2894): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-13 16:22:56.624+0900 D/AUL_PAD ( 4044): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-13 16:22:56.634+0900 D/AUL_PAD ( 2894): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-13 16:22:56.644+0900 E/RESOURCED( 2824): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.214
06-13 16:22:56.994+0900 E/PKGMGR_SERVER( 3985): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 16:22:56.994+0900 E/PKGMGR_SERVER( 3985): pkgmgr-server.c: main(2265) > package manager server terminated.
06-13 16:22:57.114+0900 D/AUL_AMD ( 2752): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-13 16:22:57.114+0900 D/RUA     ( 2752): rua.c: rua_add_history(179) > rua_add_history start
06-13 16:22:57.124+0900 D/RUA     ( 2752): rua.c: rua_add_history(247) > rua_add_history ok
06-13 16:22:57.684+0900 D/AUL_PAD ( 4044): launchpad_loader.c: main(588) > sleeping 1 sec...
06-13 16:22:57.684+0900 D/AUL_PAD ( 4044): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-13 16:22:57.684+0900 D/AUL_PAD ( 4044): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b9147760
06-13 16:22:57.684+0900 D/AUL_PAD ( 4044): preload.h: __preload_init(69) > get pre-initialization function
06-13 16:22:57.684+0900 D/AUL_PAD ( 4044): preload.h: __preload_init(73) > get shutdown function
06-13 16:22:57.684+0900 D/AUL_PAD ( 4044): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b9147a40
06-13 16:22:57.684+0900 D/AUL_PAD ( 4044): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b9149640
06-13 16:22:57.684+0900 D/AUL_PAD ( 4044): preload.h: __preload_init(69) > get pre-initialization function
06-13 16:22:57.684+0900 D/AUL_PAD ( 4044): preload.h: __preload_init(73) > get shutdown function
06-13 16:22:57.684+0900 D/AUL_PAD ( 4044): preexec.h: __preexec_init(76) > preexec start
06-13 16:22:57.684+0900 D/AUL_PAD ( 4044): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-13 16:22:57.684+0900 D/AUL     ( 4044): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-13 16:22:57.684+0900 D/AUL     ( 4044): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-13 16:22:57.684+0900 D/AUL_PAD ( 2894): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-13 16:22:57.684+0900 D/AUL_PAD ( 2894): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-13 16:22:57.684+0900 D/AUL_PAD ( 2894): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-13 16:22:57.684+0900 D/AUL_PAD ( 2894): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-13 16:22:57.684+0900 D/AUL_PAD ( 2894): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-13 16:22:57.684+0900 D/AUL_PAD ( 2894): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-13 16:22:57.684+0900 D/AUL_PAD ( 2894): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-13 16:22:57.684+0900 D/AUL_PAD ( 2894): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-13 16:22:57.684+0900 D/AUL_PAD ( 2894): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 4044
06-13 16:22:57.684+0900 D/AUL     ( 4044): process_pool.c: __connect_to_launchpad(132) > send(4044) : 4
06-13 16:22:57.684+0900 D/AUL     ( 4044): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-13 16:22:57.754+0900 D/AUL_PAD ( 4044): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-13 16:22:57.754+0900 D/AUL_PAD ( 4044): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-13 16:22:57.754+0900 D/AUL_PAD ( 4044): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-13 16:22:57.754+0900 D/AUL_PAD ( 4044): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-13 16:23:00.774+0900 D/INDICATOR( 2826): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-13 16:23:00.774+0900 D/INDICATOR( 2826): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-13 16:23:00.774+0900 D/INDICATOR( 2826): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 16:23:00.774+0900 D/INDICATOR( 2826): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 4:23 4 h"
06-13 16:23:00.774+0900 D/INDICATOR( 2826): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 4:23"
06-13 16:23:00.774+0900 D/INDICATOR( 2826): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 4&#x2236;23"
06-13 16:23:00.774+0900 D/INDICATOR( 2826): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147196365 Time: <font_size=33>4&#x2236;23</font_size> <font_size=32>PM</font_size></font>
06-13 16:23:01.154+0900 D/APP_CORE( 2838): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
06-13 16:23:01.154+0900 I/APP_CORE( 2838): appcore-efl.c: __do_app(496) > [APP 2838] Event: MEM_FLUSH State: PAUSED
06-13 16:23:01.154+0900 D/APP_CORE( 2838): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
06-13 16:23:01.154+0900 D/APP_CORE( 2838): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2838
06-13 16:23:01.154+0900 D/APP_CORE( 2838): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
06-13 16:23:01.154+0900 D/RESOURCED( 2824): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2838
06-13 16:23:03.014+0900 I/user_tag0( 3904): /opt/usr/apps/org.example.example/data/feeding.db
06-13 16:23:03.014+0900 I/tag     ( 3904): eonji~
06-13 16:23:03.014+0900 I/MESSAGE_PORT( 3904): message-port.c: __initialize(875) > initialize
06-13 16:23:03.014+0900 I/MESSAGE_PORT( 3904): message-port.c: __initialize(881) > init : org.example.example
06-13 16:23:03.024+0900 I/MESSAGE_PORT( 3904): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1d0774e4a776fc31bf631e133bd3b6590 
06-13 16:23:03.024+0900 I/MESSAGE_PORT( 3904): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1d0774e4a776fc31bf631e133bd3b6590 
06-13 16:23:03.024+0900 I/MESSAGE_PORT( 3904): message-port.c: __message_port_send_message(975) > port exist check !!
06-13 16:23:03.024+0900 I/MESSAGE_PORT( 3904): message-port.c: __check_remote_port(545) > Check a remote port : [org.example.service:forpet]
06-13 16:23:03.024+0900 I/MESSAGE_PORT( 3904): message-port.c: __check_remote_port(557) > remote_app_id, app_id :[org.example.service : org.example.example] 
06-13 16:23:03.024+0900 I/MESSAGE_PORT( 3904): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1d0774e4a776fc31bf631e133bd3b6590 
06-13 16:23:03.024+0900 I/MESSAGE_PORT( 3904): message-port.c: __check_remote_port(603) > Name not exist org.tizen.messageport._1d0774e4a776fc31bf631e133bd3b6590
06-13 16:23:03.024+0900 E/example ( 3904): message_port_check_remote_port error : -18022399
06-13 16:23:03.134+0900 D/PROCESSMGR( 2675): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x6004a5 
06-13 16:23:04.134+0900 D/PROCESSMGR( 2675): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2600002
06-13 16:23:09.144+0900 D/PROCESSMGR( 2675): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x6004a5 bd->visible=1
06-13 16:23:16.134+0900 E/CAPI_NETWORK_WIFI( 2826): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 16:23:16.134+0900 E/INDICATOR( 2826): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-13 16:23:16.134+0900 E/INDICATOR( 2826): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 16:23:16.134+0900 E/INDICATOR( 2826): 
06-13 16:23:30.734+0900 D/RESOURCED( 2824): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 16:23:30.734+0900 I/RESOURCED( 2824): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 16:23:30.734+0900 D/RESOURCED( 2824): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 16:23:30.734+0900 I/RESOURCED( 2824): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 16:23:36.164+0900 E/CAPI_NETWORK_WIFI( 2826): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 16:23:36.164+0900 E/INDICATOR( 2826): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-13 16:23:36.164+0900 E/INDICATOR( 2826): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 16:23:36.164+0900 E/INDICATOR( 2826): 
06-13 16:23:51.364+0900 E/PKGMGR_SERVER( 4083): pkgmgr-server.c: main(2209) > package manager server start
06-13 16:23:51.364+0900 D/PKGMGR  ( 4083): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(405) > initialize_gdbus Enter
06-13 16:23:51.364+0900 D/PKGMGR  ( 4083): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(423) > initialize_gdbus Exit
06-13 16:23:51.374+0900 D/PKGMGR  ( 4083): comm_pkg_mgr_server.c: on_bus_acquired(376) > on_bus_acquired
06-13 16:23:51.374+0900 D/PKGMGR  ( 4083): comm_pkg_mgr_server.c: on_bus_acquired(400) > on_bus_acquired done
06-13 16:23:51.384+0900 D/PKGMGR  ( 4083): comm_pkg_mgr_server.c: pkgmgr_request(145) > Called
06-13 16:23:51.384+0900 D/PKGMGR  ( 4083): comm_pkg_mgr_server.c: pkgmgr_request(164) > sender_name: :1.217
06-13 16:23:51.384+0900 D/PKGMGR  ( 4083): comm_pkg_mgr_server.c: pkg_mgr_get_sender_pid(79) > zone pid : 4081
06-13 16:23:51.384+0900 D/PKGMGR  ( 4083): comm_pkg_mgr_server.c: pkgmgr_request(166) > sender_pid: 4081
06-13 16:23:51.384+0900 D/PKGMGR  ( 4083): comm_pkg_mgr_server.c: pkgmgr_request(175) > [SECURE_LOG] Call request callback(obj, org.example.example_1362820922, 14, tpk, org.example.example, , host)
06-13 16:23:51.384+0900 D/PKGMGR_SERVER( 4083): pkgmgr-server.c: req_cb(625) > [SECURE_LOG] >> in callback >> Got request: [org.example.example_1362820922] [14] [tpk] [org.example.example] [] [] [host]
06-13 16:23:51.384+0900 D/PKGMGR_SERVER( 4083): pkgmgr-server.c: req_cb(646) > req_type=(14)  backend_flag=(0) zone(host)
06-13 16:23:51.384+0900 D/PKGMGR_SERVER( 4083): pkgmgr-server.c: queue_job(1880) > target zone(host, host)
06-13 16:23:51.384+0900 D/PKGMGR_SERVER( 4083): pkgmgr-server.c: queue_job(1884) > child forked [4086] for request type [14]
06-13 16:23:51.384+0900 D/PKGMGR_SERVER( 4086): pkgmgr-server.c: queue_job(1884) > child forked [0] for request type [14]
06-13 16:23:51.384+0900 D/PKGMGR_SERVER( 4086): pkgmgr-server.c: queue_job(2057) > kill/check request
06-13 16:23:51.384+0900 D/PKGMGR_SERVER( 4083): pkgmgr-server.c: queue_job(2126) > parent exit
06-13 16:23:51.384+0900 D/PKGMGR  ( 4081): pkgmgr.c: __check_sync_process(868) > info_file file is generated, result = 0
06-13 16:23:51.384+0900 D/PKGMGR  ( 4081): . 
06-13 16:23:51.384+0900 E/PKGMGR  ( 4081): pkgmgr.c: __check_sync_process(884) > file is can not remove[/tmp/org.example.example, -1]
06-13 16:23:51.384+0900 D/PKGMGR_SERVER( 4086): pkgmgr-server.c: __pkgcmd_app_cb(1458) > sub_cmd(kill), zone_name(host)
06-13 16:23:51.394+0900 D/AUL     ( 4086): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(14)
06-13 16:23:51.394+0900 D/AUL_AMD ( 2752): amd_request.c: __request_handler(838) > __request_handler: 14
06-13 16:23:51.394+0900 D/AUL_AMD ( 2752): amd_status.c: _status_app_is_running_from_cache(836) > is_running hit cache, return immediately
06-13 16:23:51.394+0900 D/AUL_AMD ( 2752): amd_request.c: __request_handler(1028) > [SECURE_LOG] APP_IS_RUNNING : org.example.example : 3904
06-13 16:23:51.394+0900 W/AUL_AMD ( 2752): amd_request.c: __send_result_to_client(150) > __send_result_to_client, pid: 3904
06-13 16:23:51.394+0900 D/AUL_AMD ( 2752): amd_request.c: __request_handler(838) > __request_handler: 12
06-13 16:23:51.394+0900 D/AUL     ( 4086): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 292
06-13 16:23:51.394+0900 D/AUL     ( 4086): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : 3904
06-13 16:23:51.394+0900 D/AUL     ( 4086): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(5)
06-13 16:23:51.394+0900 D/AUL_AMD ( 2752): amd_request.c: __request_handler(838) > __request_handler: 5
06-13 16:23:51.394+0900 D/AUL_AMD ( 2752): amd_appinfo.c: appinfo_set_value(905) > [SECURE_LOG] org.example.example : installed : norestart
06-13 16:23:51.394+0900 D/AUL_AMD ( 2752): amd_request.c: __app_process_by_pid(279) > [SECURE_LOG] __app_process_by_pid, pid: 3904, 
06-13 16:23:51.394+0900 D/AUL     ( 2752): app_sock.c: __app_send_raw_with_delay_reply(455) > pid(3904) : cmd(4)
06-13 16:23:51.394+0900 D/AUL_AMD ( 2752): amd_launch.c: _term_app(1076) > term done
06-13 16:23:51.394+0900 D/AUL_AMD ( 2752): amd_launch.c: __set_reply_handler(1015) > listen fd : 31, send fd : 30
06-13 16:23:51.394+0900 D/APP_CORE( 3904): appcore.c: __aul_handler(632) > [APP 3904]     AUL event: AUL_TERMINATE
06-13 16:23:51.394+0900 I/APP_CORE( 3904): appcore-efl.c: __do_app(496) > [APP 3904] Event: TERMINATE State: RUNNING
06-13 16:23:51.394+0900 D/APP_CORE( 3904): appcore-efl.c: __do_app(517) > [APP 3904] TERMINATE
06-13 16:23:51.394+0900 W/AUL_AMD ( 2752): amd_launch.c: __reply_handler(913) > listen fd(31) , send fd(30), pid(3904), cmd(4)
06-13 16:23:51.394+0900 D/AUL     ( 4086): launch.c: app_request_to_launchpad(425) > launch request result : 0
06-13 16:23:51.394+0900 D/AUL     ( 4086): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(14)
06-13 16:23:51.394+0900 D/AUL_AMD ( 2752): amd_request.c: __request_handler(838) > __request_handler: 14
06-13 16:23:51.394+0900 D/AUL_AMD ( 2752): amd_status.c: _status_app_is_running_from_cache(836) > is_running hit cache, return immediately
06-13 16:23:51.394+0900 D/AUL_AMD ( 2752): amd_request.c: __request_handler(1028) > [SECURE_LOG] APP_IS_RUNNING : org.example.example : 3904
06-13 16:23:51.394+0900 W/AUL_AMD ( 2752): amd_request.c: __send_result_to_client(150) > __send_result_to_client, pid: 3904
06-13 16:23:51.394+0900 D/RESOURCED( 2824): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 3904
06-13 16:23:51.394+0900 D/AUL     ( 3904): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-13 16:23:51.394+0900 D/AUL_AMD ( 2752): amd_request.c: __request_handler(838) > __request_handler: 22
06-13 16:23:51.394+0900 W/AUL_AMD ( 2752): amd_request.c: __request_handler(1056) > app status : 5
06-13 16:23:51.394+0900 D/AUL_AMD ( 2752): amd_status.c: _status_update_app_info_list(456) > pid(3904) status(5)
06-13 16:23:51.394+0900 D/AUL_AMD ( 2752): amd_status.c: _status_update_app_info_list(468) > pid(3904) appid(org.example.example) pkgid(org.example.example) status(5)
06-13 16:23:51.394+0900 D/AUL     ( 3904): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-13 16:23:51.394+0900 D/AUL_AMD ( 2752): amd_request.c: __request_handler(838) > __request_handler: 22
06-13 16:23:51.394+0900 W/AUL_AMD ( 2752): amd_request.c: __request_handler(1056) > app status : 5
06-13 16:23:51.394+0900 D/AUL_AMD ( 2752): amd_status.c: _status_update_app_info_list(456) > pid(3904) status(5)
06-13 16:23:51.394+0900 D/AUL_AMD ( 2752): amd_status.c: _status_update_app_info_list(468) > pid(3904) appid(org.example.example) pkgid(org.example.example) status(5)
06-13 16:23:51.404+0900 D/APP_CORE( 3904): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
06-13 16:23:51.404+0900 D/APP_CORE( 3904): appcore-efl.c: __after_loop(1169) > [APP 3904] PAUSE before termination
06-13 16:23:51.404+0900 I/CAPI_APPFW_APPLICATION( 3904): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-13 16:23:51.424+0900 W/CRASH_MANAGER( 4088): worker.c: worker_job(1204) > 1103904657861149733863
