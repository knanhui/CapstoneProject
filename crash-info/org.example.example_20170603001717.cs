S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: example
PID: 7048
Date: 2017-06-03 00:17:17+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 7048, uid 5000)

Register Information
r0   = 0x8000ca66, r1   = 0x372c3034
r2   = 0xb3f19000, r3   = 0xb3f19020
r4   = 0x8001b2da, r5   = 0xbeba42a0
r6   = 0xb28029a5, r7   = 0xbeba4128
r8   = 0x8001b2da, r9   = 0xb5efb708
r10  = 0xb81e17a0, fp   = 0xbeba427c
ip   = 0xb5feb120, sp   = 0xbeba40e8
lr   = 0xb5fafbd9, pc   = 0xb28029ce
cpsr = 0x800f0030

Memory Information
MemTotal:   987012 KB
MemFree:     45844 KB
Buffers:     14996 KB
Cached:     111896 KB
VmPeak:     110064 KB
VmSize:     109612 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24200 KB
VmRSS:       24200 KB
VmData:      35544 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35728 KB
VmPTE:          84 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 7048 TID = 7048
7048 7049 7075 7076 

Maps Information
b12fd000 b1afc000 rw-p [stack:7076]
b1b78000 b1b80000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1b91000 b1b92000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1ba2000 b1bb6000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bca000 b1bcb000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bdb000 b1bde000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1bef000 b1bf0000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c00000 b1c02000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c12000 b1c14000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c24000 b1c34000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c44000 b1c50000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c62000 b2461000 rw-p [stack:7075]
b2792000 b2799000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27aa000 b27b2000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b27c2000 b27d7000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b27e9000 b27ef000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27ff000 b2807000 r-xp /opt/usr/apps/org.example.example/bin/example
b295f000 b2a42000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a79000 b2aa1000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ab3000 b32b2000 rw-p [stack:7049]
b32b2000 b32b4000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32c4000 b32ce000 r-xp /lib/libnss_files-2.20-2014.11.so
b32df000 b32e8000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32f9000 b330a000 r-xp /lib/libnsl-2.20-2014.11.so
b331d000 b3323000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3334000 b3335000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b335d000 b3364000 r-xp /usr/lib/libminizip.so.1.0.0
b3374000 b3379000 r-xp /usr/lib/libstorage.so.0.1
b3389000 b33e8000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33fe000 b3412000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3422000 b3466000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3476000 b347e000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b348e000 b34be000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34d1000 b358a000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b359e000 b35f1000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3602000 b361d000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b362d000 b36ee000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3701000 b3711000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3721000 b372e000 r-xp /usr/lib/libmdm-common.so.1.0.98
b373f000 b3746000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3756000 b3797000 r-xp /usr/lib/libmdm.so.1.2.12
b37a7000 b37af000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37be000 b37ce000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37ef000 b384f000 r-xp /usr/lib/libasound.so.2.0.0
b3861000 b3864000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3874000 b3877000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3887000 b388c000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b389c000 b389d000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38ad000 b38b8000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38cc000 b38d3000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38e3000 b38e9000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38f9000 b38fe000 r-xp /usr/lib/libmmfsession.so.0.0.1
b390e000 b3929000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3939000 b3940000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3950000 b3953000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3964000 b3992000 r-xp /usr/lib/libidn.so.11.5.44
b39a2000 b39b8000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39c9000 b39d3000 r-xp /usr/lib/libcares.so.2.1.0
b39e3000 b39ed000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39fd000 b39ff000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a0f000 b3a10000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a20000 b3a24000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a35000 b3a5d000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a6e000 b3a97000 r-xp /usr/lib/libturbojpeg.so
b3ab7000 b3abd000 r-xp /usr/lib/libgif.so.4.1.6
b3acd000 b3b13000 r-xp /usr/lib/libcurl.so.4.3.0
b3b24000 b3b45000 r-xp /usr/lib/libexif.so.12.3.3
b3b60000 b3b75000 r-xp /usr/lib/libtts.so
b3b86000 b3b8e000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b9e000 b3c64000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c84000 b3d7c000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d9b000 b3e69000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e80000 b3e82000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e92000 b3e98000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ea8000 b3ecb000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3edc000 b3ede000 r-xp /usr/lib/libappsvc.so.0.1.0
b3eee000 b3ef0000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f01000 b3f06000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f1d000 b3f1f000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f2f000 b3f36000 r-xp /usr/lib/libsensord-share.so
b3f46000 b3f5e000 r-xp /usr/lib/libsensor.so.1.1.0
b3f6f000 b3f72000 r-xp /usr/lib/libXv.so.1.0.0
b3f82000 b3f87000 r-xp /usr/lib/libutilX.so.1.1.0
b3f97000 b3f9c000 r-xp /usr/lib/libappcore-common.so.1.1
b3fac000 b3fb3000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fc6000 b3fca000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fdb000 b40b9000 r-xp /usr/lib/libCOREGL.so.4.0
b40d9000 b40dc000 r-xp /usr/lib/libuuid.so.1.3.0
b40ec000 b4103000 r-xp /usr/lib/libblkid.so.1.1.0
b4114000 b4116000 r-xp /usr/lib/libXau.so.6.0.0
b4126000 b416d000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b417f000 b4185000 r-xp /usr/lib/libjson-c.so.2.0.1
b4196000 b419a000 r-xp /usr/lib/libogg.so.0.7.1
b41aa000 b41cc000 r-xp /usr/lib/libvorbis.so.0.4.3
b41dc000 b42c0000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42dc000 b42df000 r-xp /usr/lib/libEGL.so.1.4
b42f0000 b42f6000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4306000 b4308000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4318000 b4325000 r-xp /usr/lib/libGLESv2.so.2.0
b4336000 b4398000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43ad000 b43c5000 r-xp /usr/lib/libmount.so.1.1.0
b43d7000 b43eb000 r-xp /usr/lib/libxcb.so.1.1.0
b43fb000 b4402000 r-xp /lib/libcrypt-2.20-2014.11.so
b443a000 b443c000 r-xp /usr/lib/libiri.so
b444c000 b4457000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4468000 b449e000 r-xp /usr/lib/libpulse.so.0.16.2
b44af000 b44f2000 r-xp /usr/lib/libsndfile.so.1.0.25
b4507000 b451c000 r-xp /lib/libexpat.so.1.5.2
b452e000 b45ec000 r-xp /usr/lib/libcairo.so.2.11200.14
b4600000 b4608000 r-xp /usr/lib/libdrm.so.2.4.0
b4618000 b461b000 r-xp /usr/lib/libdri2.so.0.0.0
b462b000 b4679000 r-xp /usr/lib/libssl.so.1.0.0
b468e000 b469a000 r-xp /usr/lib/libeeze.so.1.13.0
b46ab000 b46b4000 r-xp /usr/lib/libethumb.so.1.13.0
b46c4000 b46c7000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46d7000 b488e000 r-xp /usr/lib/libcrypto.so.1.0.0
b5679000 b5682000 r-xp /usr/lib/libXi.so.6.1.0
b5692000 b5694000 r-xp /usr/lib/libXgesture.so.7.0.0
b56a4000 b56a8000 r-xp /usr/lib/libXtst.so.6.1.0
b56b8000 b56be000 r-xp /usr/lib/libXrender.so.1.3.0
b56ce000 b56d4000 r-xp /usr/lib/libXrandr.so.2.2.0
b56e4000 b56e6000 r-xp /usr/lib/libXinerama.so.1.0.0
b56f7000 b56fa000 r-xp /usr/lib/libXfixes.so.3.1.0
b570a000 b5715000 r-xp /usr/lib/libXext.so.6.4.0
b5725000 b5727000 r-xp /usr/lib/libXdamage.so.1.1.0
b5737000 b5739000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5749000 b582b000 r-xp /usr/lib/libX11.so.6.3.0
b583f000 b5846000 r-xp /usr/lib/libXcursor.so.1.0.2
b5856000 b586e000 r-xp /usr/lib/libudev.so.1.6.0
b5870000 b5873000 r-xp /lib/libattr.so.1.1.0
b5883000 b58a3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58a4000 b58a9000 r-xp /usr/lib/libffi.so.6.0.2
b58ba000 b58d2000 r-xp /lib/libz.so.1.2.8
b58e2000 b58e4000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58f4000 b59c9000 r-xp /usr/lib/libxml2.so.2.9.2
b59de000 b5a79000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a95000 b5a98000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5aa8000 b5ac1000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ad2000 b5ae3000 r-xp /lib/libresolv-2.20-2014.11.so
b5af7000 b5b71000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b86000 b5b88000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b98000 b5b9f000 r-xp /usr/lib/libembryo.so.1.13.0
b5baf000 b5bb9000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bca000 b5be2000 r-xp /usr/lib/libpng12.so.0.50.0
b5bf3000 b5c16000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c37000 b5c4b000 r-xp /usr/lib/libector.so.1.13.0
b5c5c000 b5c74000 r-xp /usr/lib/liblua-5.1.so
b5c85000 b5cdc000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cf0000 b5d18000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d29000 b5d3c000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d4d000 b5d87000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d98000 b5da6000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5db6000 b5dbe000 r-xp /usr/lib/libtbm.so.1.0.0
b5dce000 b5ddb000 r-xp /usr/lib/libeio.so.1.13.0
b5deb000 b5ded000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dfd000 b5e02000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e12000 b5e29000 r-xp /usr/lib/libefreet.so.1.13.0
b5e3b000 b5e5b000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e6b000 b5e8b000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e8d000 b5e93000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ea3000 b5eb4000 r-xp /usr/lib/libemotion.so.1.13.0
b5ec5000 b5ecc000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5edc000 b5eeb000 r-xp /usr/lib/libeo.so.1.13.0
b5efc000 b5f0e000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f1f000 b5f24000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f34000 b5f4d000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f5d000 b5f7a000 r-xp /usr/lib/libeet.so.1.13.0
b5f93000 b5fdb000 r-xp /usr/lib/libeina.so.1.13.0
b5fec000 b5ffc000 r-xp /usr/lib/libefl.so.1.13.0
b600d000 b60f2000 r-xp /usr/lib/libicuuc.so.51.1
b610f000 b624f000 r-xp /usr/lib/libicui18n.so.51.1
b6266000 b629e000 r-xp /usr/lib/libecore_x.so.1.13.0
b62b0000 b62b3000 r-xp /lib/libcap.so.2.21
b62c3000 b62ec000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62fd000 b6304000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6316000 b634d000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b635e000 b6449000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b645c000 b64d5000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64e7000 b64ec000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64fc000 b6506000 r-xp /usr/lib/libvconf.so.0.2.45
b6516000 b6518000 r-xp /usr/lib/libvasum.so.0.3.1
b6528000 b652a000 r-xp /usr/lib/libttrace.so.1.1
b653a000 b653d000 r-xp /usr/lib/libiniparser.so.0
b654d000 b6573000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6583000 b6588000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6599000 b65b0000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65c1000 b662c000 r-xp /lib/libm-2.20-2014.11.so
b663d000 b6643000 r-xp /lib/librt-2.20-2014.11.so
b6654000 b6661000 r-xp /usr/lib/libunwind.so.8.0.1
b6697000 b67bb000 r-xp /lib/libc-2.20-2014.11.so
b67d0000 b67e9000 r-xp /lib/libgcc_s-4.9.so.1
b67f9000 b68db000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68ec000 b6916000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6927000 b6963000 r-xp /usr/lib/libsystemd.so.0.4.0
b6965000 b69e8000 r-xp /usr/lib/libedje.so.1.13.0
b69fb000 b6a19000 r-xp /usr/lib/libecore.so.1.13.0
b6a39000 b6bc0000 r-xp /usr/lib/libevas.so.1.13.0
b6bf5000 b6c09000 r-xp /lib/libpthread-2.20-2014.11.so
b6c1d000 b6e51000 r-xp /usr/lib/libelementary.so.1.13.0
b6e80000 b6e84000 r-xp /usr/lib/libsmack.so.1.0.0
b6e94000 b6e9b000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6eab000 b6ead000 r-xp /usr/lib/libdlog.so.0.0.0
b6ebd000 b6ec0000 r-xp /usr/lib/libbundle.so.0.1.22
b6ed0000 b6ed2000 r-xp /lib/libdl-2.20-2014.11.so
b6ee3000 b6efb000 r-xp /usr/lib/libaul.so.0.1.0
b6f0f000 b6f14000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f25000 b6f32000 r-xp /usr/lib/liblptcp.so
b6f44000 b6f48000 r-xp /usr/lib/libsys-assert.so
b6f59000 b6f79000 r-xp /lib/ld-2.20-2014.11.so
b6f8a000 b6f8f000 r-xp /usr/bin/launchpad-loader
b7f77000 b8230000 rw-p [heap]
beb84000 beba5000 rw-p [stack]
beb84000 beba5000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7048)
Call Stack Count: 18
 0: feeding_view_cb + 0x29 (0xb28029ce) [/opt/usr/apps/org.example.example/bin/example] + 0x39ce
 1: (0xb6a6e175) [/usr/lib/libevas.so.1] + 0x35175
 2: (0xb5ee7219) [/usr/lib/libeo.so.1] + 0xb219
 3: eo_event_callback_call + 0x68 (0xb5ee5fb9) [/usr/lib/libeo.so.1] + 0x9fb9
 4: (0xb6a6e515) [/usr/lib/libevas.so.1] + 0x35515
 5: (0xb6a76725) [/usr/lib/libevas.so.1] + 0x3d725
 6: evas_canvas_event_feed_mouse_down + 0x6a (0xb6a7bf6b) [/usr/lib/libevas.so.1] + 0x42f6b
 7: evas_event_feed_mouse_down + 0x30 (0xb6a7f939) [/usr/lib/libevas.so.1] + 0x46939
 8: (0xb46c6173) [/usr/lib/libecore_input_evas.so.1] + 0x2173
 9: (0xb6a06c4b) [/usr/lib/libecore.so.1] + 0xbc4b
10: (0xb6a0ca5d) [/usr/lib/libecore.so.1] + 0x11a5d
11: ecore_main_loop_begin + 0x3e (0xb6a0cc83) [/usr/lib/libecore.so.1] + 0x11c83
12: appcore_efl_main + 0x20c (0xb6f122bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
13: ui_app_main + 0xc0 (0xb3fc8909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
14: main + 0x10e (0xb2804673) [/opt/usr/apps/org.example.example/bin/example] + 0x5673
15: (0xb6f8bbb5) [/opt/usr/apps/org.example.example/bin/example] + 0x1bb5
16: __libc_start_main + 0x114 (0xb66ad4bc) [/lib/libc.so.6] + 0x164bc
17: (0xb6f8beb4) [/opt/usr/apps/org.example.example/bin/example] + 0x1eb4
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
4533f03fc7860 
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 00:17:13.014+0900 E/MESSAGE_PORT( 7051): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
06-03 00:17:13.014+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:17:13.024+0900 I/MESSAGE_PORT( 7051): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:17:13.024+0900 I/MESSAGE_PORT( 7051): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:17:13.024+0900 I/MESSAGE_PORT( 7051): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
06-03 00:17:13.024+0900 I/MESSAGE_PORT( 7051): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
06-03 00:17:13.024+0900 I/MESSAGE_PORT( 7051): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:17:13.024+0900 I/MESSAGE_PORT( 1360): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 00:17:13.024+0900 E/MESSAGE_PORT( 7051): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 1[0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : [0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : [0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : [0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : [0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : [0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : [0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : [0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
06-03 00:17:13.024+0900 E/weather-agent( 7051): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
06-03 00:17:13.024+0900 E/weather-agent( 7051): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
06-03 00:17:13.024+0900 I/MESSAGE_PORT( 7051): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 00:17:13.024+0900 I/MESSAGE_PORT( 7051): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 00:17:13.044+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127213032
06-03 00:17:13.044+0900 I/Tizen::System( 1210): (280) > The screen has been turned on.
06-03 00:17:13.044+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:17:13.044+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:17:13.044+0900 E/GAME    ( 2577): .\..\src\TizenImpl.c: device_display_changed_cb(80) > device_display_changed_cb: state change to 0
06-03 00:17:13.054+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:17:13.054+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
06-03 00:17:13.054+0900 I/Internet(27388): main.cpp: __display_changed_cb(1445) > 3, (nil), 0xbe8305a0
06-03 00:17:13.054+0900 I/Internet(27388): main.cpp: __display_changed_cb(1462) > DISPLAY_STATE_SCREEN state : [0]
06-03 00:17:13.054+0900 I/Internet(27388): main.cpp: __display_changed_cb(1474) > paused
06-03 00:17:13.074+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:17:13.104+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 00:17:13.114+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:17:13.114+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:17:13.114+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:17:13.114+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:17:13.114+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:17:13.124+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:17:13.134+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:17:13.134+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 00:17:13.134+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 00:17:13.134+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 00:17:13.134+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 00:17:13.155+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127213151
06-03 00:17:13.155+0900 E/LOCKSCREEN(  845): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-03 00:17:13.155+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80001:VIEW_GESTURED
06-03 00:17:13.155+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80001 event_info:0
06-03 00:17:13.155+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 00:17:13.155+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
06-03 00:17:13.155+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
06-03 00:17:13.155+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
06-03 00:17:13.155+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:4:LKD_EVT_WILL_UNLOCK
06-03 00:17:13.155+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:4 event_info:0
06-03 00:17:13.155+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event_delay(1041) > [lockd_event_delay:1041:W] dealyed event:2:UNLOCK wait for:0.330000
06-03 00:17:13.155+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 00:17:13.195+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:17:13.195+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:17:13.205+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:17:13.205+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:17:13.205+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:17:13.205+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:17:13.205+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:17:13.215+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:17:13.215+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_update_cb(287) > received updating signal
06-03 00:17:13.265+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:17:13.275+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:17:13.485+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
06-03 00:17:13.485+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
06-03 00:17:13.485+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
06-03 00:17:13.485+0900 E/LOCKSCREEN(  845): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
06-03 00:17:13.485+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 00:17:13.485+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:17:13.485+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 00:17:13.485+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 00:17:13.485+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-03 00:17:13.495+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:17:13.495+0900 W/LOCKSCREEN(  845): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [invisible]
06-03 00:17:13.495+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
06-03 00:17:13.495+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
06-03 00:17:13.505+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:17:13.505+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(845) status(4)
06-03 00:17:13.505+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(845)
06-03 00:17:13.505+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 845, appid: com.samsung.lockscreen, status: bg
06-03 00:17:13.505+0900 E/LOCKSCREEN(  845): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
06-03 00:17:13.505+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: PAUSE State: RUNNING
06-03 00:17:13.505+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:17:13.505+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:17:13.505+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 00:17:13.505+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
06-03 00:17:13.505+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
06-03 00:17:13.505+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 00:17:13.505+0900 E/LOCKSCREEN(  845): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-03 00:17:13.515+0900 I/APP_CORE( 6807): appcore-efl.c: __do_app(514) > [APP 6807] Event: RESUME State: CREATED
06-03 00:17:13.525+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(6807) status(3)
06-03 00:17:13.525+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:17:13.525+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:17:13.525+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(6807)
06-03 00:17:13.525+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 6807, appid: org.example.example, status: fg
06-03 00:17:13.545+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: MEM_FLUSH State: PAUSED
06-03 00:17:13.555+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:17:13.555+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:17:13.555+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:17:13.555+0900 I/APP_CORE( 6807): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 00:17:13.555+0900 I/APP_CORE( 6807): appcore-efl.c: __do_app(625) > [APP 6807] Initial Launching, call the resume_cb
06-03 00:17:13.555+0900 I/CAPI_APPFW_APPLICATION( 6807): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:17:13.565+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:17:13.605+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
06-03 00:17:13.605+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 00:17:13.605+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:17:13.605+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 00:17:13.605+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 00:17:13.615+0900 E/LOCKSCREEN(  845): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
06-03 00:17:13.735+0900 E/EFL     ( 6807): ecore_x<6807> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127213705
06-03 00:17:13.905+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 6807 pgid = 6807
06-03 00:17:13.905+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(143) > dead_pid(6807)
06-03 00:17:13.905+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:17:13.915+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 00:17:13.925+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:17:13.925+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:17:13.925+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 00:17:13.925+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 00:17:13.975+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 00:17:13.975+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 00:17:13.975+0900 E/AUL_PAD ( 1359): launchpad.c: main(698) > error reading sigchld info
06-03 00:17:13.985+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 00:17:13.995+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[6807] terminate event is forwarded
06-03 00:17:13.995+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:17:13.995+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 6807, ]
06-03 00:17:13.995+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:17:13.995+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 00:17:13.995+0900 I/Tizen::App( 1210): (512) > Not registered pid(6807)
06-03 00:17:13.995+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 00:17:13.995+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:17:13.995+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 6807
06-03 00:17:13.995+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 6807
06-03 00:17:13.995+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 6807
06-03 00:17:14.005+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 00:17:14.015+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 00:17:14.015+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:17:14.015+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 00:17:14.015+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:17:14.015+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:17:14.015+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 6807.
06-03 00:17:14.025+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:17:14.035+0900 E/weather-agent( 7051): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
06-03 00:17:14.035+0900 I/CAPI_APPFW_APPLICATION( 7051): service_app_main.c: service_app_exit(446) > service_app_exit
06-03 00:17:14.045+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
06-03 00:17:14.045+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
06-03 00:17:14.045+0900 E/weather-agent( 7051): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
06-03 00:17:14.045+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 00:17:14.045+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:17:14.095+0900 W/CRASH_MANAGER( 7060): worker.c: worker_job(1199) > 11068076578611496416633
06-03 00:17:14.115+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:17:14.125+0900 I/Tizen::Net::Wifi( 1210): (941) > The background scan result updated.
06-03 00:17:14.296+0900 W/AUL_AMD (  610): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-03 00:17:14.326+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 7051
06-03 00:17:14.326+0900 I/Tizen::App( 1210): (243) > App[com.samsung.weather-m-agent] pid[7051] terminate event is forwarded
06-03 00:17:14.326+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:17:14.326+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 7051, ]
06-03 00:17:14.326+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:17:14.326+0900 I/Tizen::App( 1210): (506) > TerminatedApp(com.samsung.weather-m-agent)
06-03 00:17:14.326+0900 I/Tizen::App( 1210): (512) > Not registered pid(7051)
06-03 00:17:14.326+0900 I/Tizen::System( 1210): (246) > Terminated app [com.samsung.weather-m-agent]
06-03 00:17:14.336+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:17:14.336+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7051
06-03 00:17:14.346+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:17:14.346+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 7051.
06-03 00:17:14.356+0900 W/BROWSER_PROVIDER(29519): browser-provider-requests-manager.c: bp_thread_requests_manager(892) > old client[BOOKMARK_CSC:1903049268] slot:3 sock:18
06-03 00:17:14.706+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127214704
06-03 00:17:14.796+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127214791
06-03 00:17:14.806+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.example)
06-03 00:17:14.806+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
06-03 00:17:14.806+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 860
06-03 00:17:14.816+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 8
06-03 00:17:14.826+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:17:14.826+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 00:17:14.826+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-03 00:17:14.826+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 00:17:14.856+0900 I/CAPI_APPFW_APPLICATION( 7048): app_main.c: ui_app_main(789) > app_efl_main
06-03 00:17:14.856+0900 I/CAPI_APPFW_APPLICATION( 7048): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 00:17:14.896+0900 E/TBM     ( 7048): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 00:17:14.926+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 7048, appid: org.example.example
06-03 00:17:14.926+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 00:17:14.936+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(7048)
06-03 00:17:15.106+0900 I/APP_CORE( 7048): appcore-efl.c: __do_app(514) > [APP 7048] Event: RESET State: CREATED
06-03 00:17:15.106+0900 I/CAPI_APPFW_APPLICATION( 7048): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 00:17:15.106+0900 E/EFL     ( 7048): edje<7048> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:17:15.106+0900 E/EFL     ( 7048): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:17:15.106+0900 E/EFL     ( 7048): edje<7048> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:17:15.106+0900 E/EFL     ( 7048): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:17:15.116+0900 E/EFL     ( 7048): edje<7048> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:17:15.116+0900 E/EFL     ( 7048): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:17:15.116+0900 E/EFL     ( 7048): edje<7048> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:17:15.116+0900 E/EFL     ( 7048): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:17:15.116+0900 E/EFL     ( 7048): edje<7048> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:17:15.116+0900 E/EFL     ( 7048): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:17:15.146+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:17:15.146+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:17:15.176+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:17:15.187+0900 W/APP_CORE( 7048): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:9c00002
06-03 00:17:15.197+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 00:17:15.197+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:17:15.197+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:17:15.197+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:17:15.307+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
06-03 00:17:15.307+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:17:15.307+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
06-03 00:17:15.307+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
06-03 00:17:15.307+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
06-03 00:17:15.307+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
06-03 00:17:15.307+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7048) status(3)
06-03 00:17:15.317+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(7048)
06-03 00:17:15.317+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 7048, appid: org.example.example, status: fg
06-03 00:17:15.327+0900 E/weather-widget( 1360): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-03 00:17:15.327+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 00:17:15.327+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 00:17:15.327+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: bg
06-03 00:17:15.347+0900 I/APP_CORE( 7048): appcore-efl.c: __do_app(514) > [APP 7048] Event: RESUME State: CREATED
06-03 00:17:15.357+0900 I/APP_CORE( 7048): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 00:17:15.357+0900 I/APP_CORE( 7048): appcore-efl.c: __do_app(625) > [APP 7048] Initial Launching, call the resume_cb
06-03 00:17:15.357+0900 I/CAPI_APPFW_APPLICATION( 7048): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:17:15.467+0900 W/LFE      (15849): [15849] 26:11:47.546[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:17:15.667+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7048) status(0)
06-03 00:17:15.947+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3195
06-03 00:17:15.957+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 00:17:15.957+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 7048.
06-03 00:17:15.977+0900 E/EFL     ( 7048): ecore_x<7048> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127215985
06-03 00:17:16.037+0900 E/EFL     ( 7048): ecore_x<7048> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127216039
06-03 00:17:16.738+0900 I/UXT     ( 7079): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-03 00:17:17.279+0900 E/EFL     ( 7048): ecore_x<7048> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127217281
06-03 00:17:17.439+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 7048 pgid = 7048
06-03 00:17:17.439+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(143) > dead_pid(7048)
06-03 00:17:17.439+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:17:17.449+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 00:17:17.449+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:17:17.449+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:17:17.449+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 00:17:17.449+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 00:17:17.499+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 00:17:17.499+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 00:17:17.499+0900 E/AUL_PAD ( 1359): launchpad.c: main(698) > error reading sigchld info
06-03 00:17:17.499+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[7048] terminate event is forwarded
06-03 00:17:17.499+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:17:17.499+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 7048, ]
06-03 00:17:17.499+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:17:17.499+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 00:17:17.499+0900 I/Tizen::App( 1210): (512) > Not registered pid(7048)
06-03 00:17:17.499+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 00:17:17.499+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 7048
06-03 00:17:17.499+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:17:17.509+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7048
06-03 00:17:17.509+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 7048
06-03 00:17:17.509+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3198
06-03 00:17:17.509+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 00:17:17.519+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 00:17:17.519+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:17:17.519+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 00:17:17.519+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 00:17:17.519+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:17:17.519+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:17:17.519+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 7048.
06-03 00:17:17.539+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 00:17:17.539+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 00:17:17.539+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:17:17.549+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:17:17.559+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:17:17.559+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:17:17.559+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:17:17.559+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:17:17.559+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:17:17.569+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:17:17.579+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
06-03 00:17:17.579+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 00:17:17.589+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:17:17.589+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 00:17:17.589+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 00:17:17.589+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 00:17:17.589+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 00:17:17.589+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
06-03 00:17:17.589+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 00:17:17.609+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:17:17.679+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:17:17.679+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:17:17.969+0900 W/LFE      (15849): [15849] 26:11:50.046[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:17:18.229+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127218235
06-03 00:17:18.290+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127218289
06-03 00:17:18.290+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.example)
06-03 00:17:18.290+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
06-03 00:17:18.290+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 860
06-03 00:17:18.310+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 8
06-03 00:17:18.310+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:17:18.310+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 00:17:18.310+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-03 00:17:18.310+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 00:17:18.350+0900 I/CAPI_APPFW_APPLICATION( 7079): app_main.c: ui_app_main(789) > app_efl_main
06-03 00:17:18.350+0900 I/CAPI_APPFW_APPLICATION( 7079): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 00:17:18.410+0900 E/TBM     ( 7079): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 00:17:18.420+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 7079, appid: org.example.example
06-03 00:17:18.420+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 00:17:18.420+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(7079)
06-03 00:17:18.500+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: MEM_FLUSH State: PAUSED
06-03 00:17:18.610+0900 I/APP_CORE( 7079): appcore-efl.c: __do_app(514) > [APP 7079] Event: RESET State: CREATED
06-03 00:17:18.610+0900 I/CAPI_APPFW_APPLICATION( 7079): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 00:17:18.610+0900 E/EFL     ( 7079): edje<7079> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:17:18.610+0900 E/EFL     ( 7079): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:17:18.620+0900 E/EFL     ( 7079): edje<7079> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:17:18.620+0900 E/EFL     ( 7079): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:17:18.620+0900 E/EFL     ( 7079): edje<7079> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:17:18.620+0900 E/EFL     ( 7079): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:17:18.620+0900 E/EFL     ( 7079): edje<7079> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:17:18.620+0900 E/EFL     ( 7079): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:17:18.620+0900 E/EFL     ( 7079): edje<7079> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:17:18.620+0900 E/EFL     ( 7079): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:17:18.650+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:17:18.650+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:17:18.660+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:17:18.670+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:17:18.670+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:17:18.680+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:17:18.700+0900 W/APP_CORE( 7079): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:8a00002
06-03 00:17:18.700+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 00:17:18.820+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
06-03 00:17:18.820+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:17:18.820+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
06-03 00:17:18.820+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
06-03 00:17:18.820+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
06-03 00:17:18.820+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
06-03 00:17:18.820+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7079) status(3)
06-03 00:17:18.830+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(7079)
06-03 00:17:18.830+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 7079, appid: org.example.example, status: fg
06-03 00:17:18.840+0900 E/weather-widget( 1360): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-03 00:17:18.840+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 00:17:18.840+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 00:17:18.840+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: bg
06-03 00:17:18.870+0900 I/APP_CORE( 7079): appcore-efl.c: __do_app(514) > [APP 7079] Event: RESUME State: CREATED
06-03 00:17:18.880+0900 I/APP_CORE( 7079): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 00:17:18.880+0900 I/APP_CORE( 7079): appcore-efl.c: __do_app(625) > [APP 7079] Initial Launching, call the resume_cb
06-03 00:17:18.880+0900 I/CAPI_APPFW_APPLICATION( 7079): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:17:19.040+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-03 00:17:19.180+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7079) status(0)
06-03 00:17:19.351+0900 E/EFL     ( 7079): ecore_x<7079> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127219337
06-03 00:17:19.351+0900 I/example ( 7079): m
06-03 00:17:19.401+0900 E/EFL     ( 7079): ecore_x<7079> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127219402
06-03 00:17:19.461+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 00:17:19.461+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 7079.
06-03 00:17:19.461+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3199
06-03 00:17:20.322+0900 I/UXT     ( 7097): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-03 00:17:20.462+0900 W/LFE      (15849): [15849] 26:11:52.545[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:17:21.373+0900 E/EFL     ( 7079): ecore_x<7079> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127221372
06-03 00:17:21.423+0900 E/EFL     ( 7079): ecore_x<7079> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127221426
06-03 00:17:21.993+0900 W/CRASH_MANAGER( 7060): worker.c: worker_job(1199) > 1107048657861149641663
