S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: example
PID: 7845
Date: 2017-06-03 00:27:02+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 7845, uid 5000)

Register Information
r0   = 0x8000ca66, r1   = 0x372c3034
r2   = 0xb3f37000, r3   = 0xb3f37020
r4   = 0x8001b6dc, r5   = 0xbec042a0
r6   = 0xb2822e5d, r7   = 0xbec04128
r8   = 0x8001b6dc, r9   = 0xb5f19708
r10  = 0xb8ae2ea8, fp   = 0xbec0427c
ip   = 0xb6009120, sp   = 0xbec040e8
lr   = 0xb5fcdbd9, pc   = 0xb2822e86
cpsr = 0x800f0030

Memory Information
MemTotal:   987012 KB
MemFree:     36856 KB
Buffers:     17440 KB
Cached:     112156 KB
VmPeak:     115576 KB
VmSize:     114972 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       27272 KB
VmRSS:       26980 KB
VmData:      37192 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35728 KB
VmPTE:          90 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 7845 TID = 7845
7845 7846 7956 7957 

Maps Information
b131b000 b1b1a000 rw-p [stack:7957]
b1b96000 b1b9e000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1baf000 b1bb0000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bc0000 b1bd4000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1be8000 b1be9000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bf9000 b1bfc000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c0d000 b1c0e000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c1e000 b1c20000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c30000 b1c32000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c42000 b1c52000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c62000 b1c6e000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c80000 b247f000 rw-p [stack:7956]
b27b0000 b27b7000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27c8000 b27d0000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b27e0000 b27f5000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b2807000 b280d000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b281d000 b2825000 r-xp /opt/usr/apps/org.example.example/bin/example
b297d000 b2a60000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a97000 b2abf000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ad1000 b32d0000 rw-p [stack:7846]
b32d0000 b32d2000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32e2000 b32ec000 r-xp /lib/libnss_files-2.20-2014.11.so
b32fd000 b3306000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3317000 b3328000 r-xp /lib/libnsl-2.20-2014.11.so
b333b000 b3341000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3352000 b3353000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b337b000 b3382000 r-xp /usr/lib/libminizip.so.1.0.0
b3392000 b3397000 r-xp /usr/lib/libstorage.so.0.1
b33a7000 b3406000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b341c000 b3430000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3440000 b3484000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3494000 b349c000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34ac000 b34dc000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34ef000 b35a8000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35bc000 b360f000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3620000 b363b000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b364b000 b370c000 r-xp /usr/lib/libprotobuf.so.9.0.1
b371f000 b372f000 r-xp /usr/lib/libefl-assist.so.0.1.0
b373f000 b374c000 r-xp /usr/lib/libmdm-common.so.1.0.98
b375d000 b3764000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3774000 b37b5000 r-xp /usr/lib/libmdm.so.1.2.12
b37c5000 b37cd000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37dc000 b37ec000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b380d000 b386d000 r-xp /usr/lib/libasound.so.2.0.0
b387f000 b3882000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3892000 b3895000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38a5000 b38aa000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38ba000 b38bb000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38cb000 b38d6000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38ea000 b38f1000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3901000 b3907000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3917000 b391c000 r-xp /usr/lib/libmmfsession.so.0.0.1
b392c000 b3947000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3957000 b395e000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b396e000 b3971000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3982000 b39b0000 r-xp /usr/lib/libidn.so.11.5.44
b39c0000 b39d6000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39e7000 b39f1000 r-xp /usr/lib/libcares.so.2.1.0
b3a01000 b3a0b000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a1b000 b3a1d000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a2d000 b3a2e000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a3e000 b3a42000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a53000 b3a7b000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a8c000 b3ab5000 r-xp /usr/lib/libturbojpeg.so
b3ad5000 b3adb000 r-xp /usr/lib/libgif.so.4.1.6
b3aeb000 b3b31000 r-xp /usr/lib/libcurl.so.4.3.0
b3b42000 b3b63000 r-xp /usr/lib/libexif.so.12.3.3
b3b7e000 b3b93000 r-xp /usr/lib/libtts.so
b3ba4000 b3bac000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bbc000 b3c82000 r-xp /usr/lib/libdali-core.so.0.0.0
b3ca2000 b3d9a000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3db9000 b3e87000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e9e000 b3ea0000 r-xp /usr/lib/libboost_system.so.1.51.0
b3eb0000 b3eb6000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ec6000 b3ee9000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3efa000 b3efc000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f0c000 b3f0e000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f1f000 b3f24000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f3b000 b3f3d000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f4d000 b3f54000 r-xp /usr/lib/libsensord-share.so
b3f64000 b3f7c000 r-xp /usr/lib/libsensor.so.1.1.0
b3f8d000 b3f90000 r-xp /usr/lib/libXv.so.1.0.0
b3fa0000 b3fa5000 r-xp /usr/lib/libutilX.so.1.1.0
b3fb5000 b3fba000 r-xp /usr/lib/libappcore-common.so.1.1
b3fca000 b3fd1000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fe4000 b3fe8000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3ff9000 b40d7000 r-xp /usr/lib/libCOREGL.so.4.0
b40f7000 b40fa000 r-xp /usr/lib/libuuid.so.1.3.0
b410a000 b4121000 r-xp /usr/lib/libblkid.so.1.1.0
b4132000 b4134000 r-xp /usr/lib/libXau.so.6.0.0
b4144000 b418b000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b419d000 b41a3000 r-xp /usr/lib/libjson-c.so.2.0.1
b41b4000 b41b8000 r-xp /usr/lib/libogg.so.0.7.1
b41c8000 b41ea000 r-xp /usr/lib/libvorbis.so.0.4.3
b41fa000 b42de000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42fa000 b42fd000 r-xp /usr/lib/libEGL.so.1.4
b430e000 b4314000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4324000 b4326000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4336000 b4343000 r-xp /usr/lib/libGLESv2.so.2.0
b4354000 b43b6000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43cb000 b43e3000 r-xp /usr/lib/libmount.so.1.1.0
b43f5000 b4409000 r-xp /usr/lib/libxcb.so.1.1.0
b4419000 b4420000 r-xp /lib/libcrypt-2.20-2014.11.so
b4458000 b445a000 r-xp /usr/lib/libiri.so
b446a000 b4475000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4486000 b44bc000 r-xp /usr/lib/libpulse.so.0.16.2
b44cd000 b4510000 r-xp /usr/lib/libsndfile.so.1.0.25
b4525000 b453a000 r-xp /lib/libexpat.so.1.5.2
b454c000 b460a000 r-xp /usr/lib/libcairo.so.2.11200.14
b461e000 b4626000 r-xp /usr/lib/libdrm.so.2.4.0
b4636000 b4639000 r-xp /usr/lib/libdri2.so.0.0.0
b4649000 b4697000 r-xp /usr/lib/libssl.so.1.0.0
b46ac000 b46b8000 r-xp /usr/lib/libeeze.so.1.13.0
b46c9000 b46d2000 r-xp /usr/lib/libethumb.so.1.13.0
b46e2000 b46e5000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46f5000 b48ac000 r-xp /usr/lib/libcrypto.so.1.0.0
b5697000 b56a0000 r-xp /usr/lib/libXi.so.6.1.0
b56b0000 b56b2000 r-xp /usr/lib/libXgesture.so.7.0.0
b56c2000 b56c6000 r-xp /usr/lib/libXtst.so.6.1.0
b56d6000 b56dc000 r-xp /usr/lib/libXrender.so.1.3.0
b56ec000 b56f2000 r-xp /usr/lib/libXrandr.so.2.2.0
b5702000 b5704000 r-xp /usr/lib/libXinerama.so.1.0.0
b5715000 b5718000 r-xp /usr/lib/libXfixes.so.3.1.0
b5728000 b5733000 r-xp /usr/lib/libXext.so.6.4.0
b5743000 b5745000 r-xp /usr/lib/libXdamage.so.1.1.0
b5755000 b5757000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5767000 b5849000 r-xp /usr/lib/libX11.so.6.3.0
b585d000 b5864000 r-xp /usr/lib/libXcursor.so.1.0.2
b5874000 b588c000 r-xp /usr/lib/libudev.so.1.6.0
b588e000 b5891000 r-xp /lib/libattr.so.1.1.0
b58a1000 b58c1000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58c2000 b58c7000 r-xp /usr/lib/libffi.so.6.0.2
b58d8000 b58f0000 r-xp /lib/libz.so.1.2.8
b5900000 b5902000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5912000 b59e7000 r-xp /usr/lib/libxml2.so.2.9.2
b59fc000 b5a97000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ab3000 b5ab6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ac6000 b5adf000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5af0000 b5b01000 r-xp /lib/libresolv-2.20-2014.11.so
b5b15000 b5b8f000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5ba4000 b5ba6000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bb6000 b5bbd000 r-xp /usr/lib/libembryo.so.1.13.0
b5bcd000 b5bd7000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5be8000 b5c00000 r-xp /usr/lib/libpng12.so.0.50.0
b5c11000 b5c34000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c55000 b5c69000 r-xp /usr/lib/libector.so.1.13.0
b5c7a000 b5c92000 r-xp /usr/lib/liblua-5.1.so
b5ca3000 b5cfa000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d0e000 b5d36000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d47000 b5d5a000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d6b000 b5da5000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5db6000 b5dc4000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dd4000 b5ddc000 r-xp /usr/lib/libtbm.so.1.0.0
b5dec000 b5df9000 r-xp /usr/lib/libeio.so.1.13.0
b5e09000 b5e0b000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e1b000 b5e20000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e30000 b5e47000 r-xp /usr/lib/libefreet.so.1.13.0
b5e59000 b5e79000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e89000 b5ea9000 r-xp /usr/lib/libecore_con.so.1.13.0
b5eab000 b5eb1000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ec1000 b5ed2000 r-xp /usr/lib/libemotion.so.1.13.0
b5ee3000 b5eea000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5efa000 b5f09000 r-xp /usr/lib/libeo.so.1.13.0
b5f1a000 b5f2c000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f3d000 b5f42000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f52000 b5f6b000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f7b000 b5f98000 r-xp /usr/lib/libeet.so.1.13.0
b5fb1000 b5ff9000 r-xp /usr/lib/libeina.so.1.13.0
b600a000 b601a000 r-xp /usr/lib/libefl.so.1.13.0
b602b000 b6110000 r-xp /usr/lib/libicuuc.so.51.1
b612d000 b626d000 r-xp /usr/lib/libicui18n.so.51.1
b6284000 b62bc000 r-xp /usr/lib/libecore_x.so.1.13.0
b62ce000 b62d1000 r-xp /lib/libcap.so.2.21
b62e1000 b630a000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b631b000 b6322000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6334000 b636b000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b637c000 b6467000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b647a000 b64f3000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6505000 b650a000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b651a000 b6524000 r-xp /usr/lib/libvconf.so.0.2.45
b6534000 b6536000 r-xp /usr/lib/libvasum.so.0.3.1
b6546000 b6548000 r-xp /usr/lib/libttrace.so.1.1
b6558000 b655b000 r-xp /usr/lib/libiniparser.so.0
b656b000 b6591000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65a1000 b65a6000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65b7000 b65ce000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65df000 b664a000 r-xp /lib/libm-2.20-2014.11.so
b665b000 b6661000 r-xp /lib/librt-2.20-2014.11.so
b6672000 b667f000 r-xp /usr/lib/libunwind.so.8.0.1
b66b5000 b67d9000 r-xp /lib/libc-2.20-2014.11.so
b67ee000 b6807000 r-xp /lib/libgcc_s-4.9.so.1
b6817000 b68f9000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b690a000 b6934000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6945000 b6981000 r-xp /usr/lib/libsystemd.so.0.4.0
b6983000 b6a06000 r-xp /usr/lib/libedje.so.1.13.0
b6a19000 b6a37000 r-xp /usr/lib/libecore.so.1.13.0
b6a57000 b6bde000 r-xp /usr/lib/libevas.so.1.13.0
b6c13000 b6c27000 r-xp /lib/libpthread-2.20-2014.11.so
b6c3b000 b6e6f000 r-xp /usr/lib/libelementary.so.1.13.0
b6e9e000 b6ea2000 r-xp /usr/lib/libsmack.so.1.0.0
b6eb2000 b6eb9000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ec9000 b6ecb000 r-xp /usr/lib/libdlog.so.0.0.0
b6edb000 b6ede000 r-xp /usr/lib/libbundle.so.0.1.22
b6eee000 b6ef0000 r-xp /lib/libdl-2.20-2014.11.so
b6f01000 b6f19000 r-xp /usr/lib/libaul.so.0.1.0
b6f2d000 b6f32000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f43000 b6f50000 r-xp /usr/lib/liblptcp.so
b6f62000 b6f66000 r-xp /usr/lib/libsys-assert.so
b6f77000 b6f97000 r-xp /lib/ld-2.20-2014.11.so
b6fa8000 b6fad000 r-xp /usr/bin/launchpad-loader
b8878000 b8b31000 rw-p [heap]
bebe4000 bec05000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7845)
Call Stack Count: 18
 0: setting_view_cb + 0x29 (0xb2822e86) [/opt/usr/apps/org.example.example/bin/example] + 0x5e86
 1: (0xb6a8c175) [/usr/lib/libevas.so.1] + 0x35175
 2: (0xb5f05219) [/usr/lib/libeo.so.1] + 0xb219
 3: eo_event_callback_call + 0x68 (0xb5f03fb9) [/usr/lib/libeo.so.1] + 0x9fb9
 4: (0xb6a8c515) [/usr/lib/libevas.so.1] + 0x35515
 5: (0xb6a94725) [/usr/lib/libevas.so.1] + 0x3d725
 6: evas_canvas_event_feed_mouse_down + 0x6a (0xb6a99f6b) [/usr/lib/libevas.so.1] + 0x42f6b
 7: evas_event_feed_mouse_down + 0x30 (0xb6a9d939) [/usr/lib/libevas.so.1] + 0x46939
 8: (0xb46e4173) [/usr/lib/libecore_input_evas.so.1] + 0x2173
 9: (0xb6a24c4b) [/usr/lib/libecore.so.1] + 0xbc4b
10: (0xb6a2aa5d) [/usr/lib/libecore.so.1] + 0x11a5d
11: ecore_main_loop_begin + 0x3e (0xb6a2ac83) [/usr/lib/libecore.so.1] + 0x11c83
12: appcore_efl_main + 0x20c (0xb6f302bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
13: ui_app_main + 0xc0 (0xb3fe6909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
14: main + 0x10e (0xb2822673) [/opt/usr/apps/org.example.example/bin/example] + 0x5673
15: (0xb6fa9bb5) [/opt/usr/apps/org.example.example/bin/example] + 0x1bb5
16: __libc_start_main + 0x114 (0xb66cb4bc) [/lib/libc.so.6] + 0x164bc
17: (0xb6fa9eb4) [/opt/usr/apps/org.example.example/bin/example] + 0x1eb4
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
3 00:26:27.986+0900 W/LFE      (15849): [15849] 26:21:00.057[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:26:30.478+0900 W/LFE      (15849): [15849] 26:21:02.554[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:26:32.971+0900 W/LFE      (15849): [15849] 26:21:05.051[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:26:35.473+0900 W/LFE      (15849): [15849] 26:21:07.550[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:26:37.976+0900 W/LFE      (15849): [15849] 26:21:10.048[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:26:40.468+0900 W/LFE      (15849): [15849] 26:21:12.547[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:26:42.960+0900 W/LFE      (15849): [15849] 26:21:15.044[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:26:45.463+0900 W/LFE      (15849): [15849] 26:21:17.544[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:26:47.965+0900 W/LFE      (15849): [15849] 26:21:20.042[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:26:50.468+0900 W/LFE      (15849): [15849] 26:21:22.542[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:26:52.960+0900 W/LFE      (15849): [15849] 26:21:25.042[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:26:54.942+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(143) > [_dbus_message_recv_cb:143:W] PRE_LCD_ON cause[powerkey] (status:1)
06-03 00:26:54.942+0900 W/LOCKSCREEN(  845): event.c: _lcd_on_cb(54) > [_lcd_on_cb:54:W] Dbus LCD on
06-03 00:26:54.942+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30001:LCD_ON
06-03 00:26:54.942+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:30001 event_info:0
06-03 00:26:54.942+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:3
06-03 00:26:54.942+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] PAUSE => WILL RESUME
06-03 00:26:54.952+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(195) > ""
06-03 00:26:54.952+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:26:54.952+0900 E/UXT     (  646): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 12:26
06-03 00:26:54.952+0900 I/INDICATOR(  646): clock.c: getTimeFormatted(176) > "time format : 오전 12:26"
06-03 00:26:54.952+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 12:26"
06-03 00:26:54.952+0900 W/INDICATOR(  646): clock.c: indicator_clock_changed_cb(272) > 
06-03 00:26:54.952+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145706220 Time: <font_size=31> </font_size> <font_size=31> 오전 12:26</font_size></font>"
06-03 00:26:54.952+0900 E/LOCKSCREEN(  845): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
06-03 00:26:54.962+0900 I/INDICATOR(  646): battery.c: show_battery_icon(376) > "Percentage:(0) / Level:(7) / batt_Full:(0) / battery_charging(1)"
06-03 00:26:54.962+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
06-03 00:26:54.962+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 00:26:54.962+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 00:26:54.962+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 00:26:54.962+0900 E/INDICATOR(  646): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-03 00:26:54.962+0900 E/INDICATOR(  646): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-03 00:26:55.162+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:4
06-03 00:26:55.162+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => RESUME
06-03 00:26:55.162+0900 W/APP_CORE(  845): appcore-efl.c: __cmsg_cb(1034) > LCD On. Resume the topmost app
06-03 00:26:55.162+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: RESUME State: PAUSED
06-03 00:26:55.162+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:26:55.162+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20004:APP_RESUME
06-03 00:26:55.162+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:20004 event_info:0
06-03 00:26:55.162+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-03 00:26:55.172+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
06-03 00:26:55.172+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
06-03 00:26:55.172+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 845
06-03 00:26:55.172+0900 I/AUL_AMD (  610): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
06-03 00:26:55.182+0900 W/AUL_AMD (  610): amd_launch.c: start_process(638) > child process: 7945
06-03 00:26:55.182+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:26:55.232+0900 W/AUL_AMD (  610): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 7945
06-03 00:26:55.232+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 7945, appid: com.samsung.weather-m-agent
06-03 00:26:55.252+0900 I/Tizen::App( 1210): (499) > LaunchedApp(com.samsung.weather-m-agent)
06-03 00:26:55.252+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 7945.
06-03 00:26:55.262+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(425) > request cmd(0) result(7945)
06-03 00:26:55.413+0900 E/weather-agent( 7945): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
06-03 00:26:55.413+0900 E/weather-common( 7945): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
06-03 00:26:55.413+0900 E/weather-agent( 7945): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
06-03 00:26:55.413+0900 E/weather-agent( 7945): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.deco-app, PortID : lockscreen-message-port[0;m
06-03 00:26:55.423+0900 E/weather-common( 7945): CityDBController.cpp: GetPrimaryKey(376) > [0;40;31mNo result : 101[0;m
06-03 00:26:55.423+0900 E/weather-common( 7945): CityDBController.cpp: Select(265) > [0;40;31mNo result : 101[0;m
06-03 00:26:55.423+0900 E/weather-common( 7945): DBController.cpp: SelectDataWithPrimaryKey(154) > [0;40;31m[SelectDataWithPrimaryKey(): 154] (!cityPtr) [return][0;m
06-03 00:26:55.423+0900 E/weather-common( 7945): WeatherInformationShareUtil.cpp: ShareDisplayCityWeatherInfo(289) > [0;40;31mthere is no city[0;m
06-03 00:26:55.423+0900 E/weather-common( 7945): WeatherInformationShareUtil.cpp: AddWeatherInfoToBundle(438) > [0;40;31m[AddWeatherInfoToBundle(): 438] (cityPtrVector->size() == 0) [return][0;m
06-03 00:26:55.423+0900 I/MESSAGE_PORT( 7945): message-port.c: __initialize(872) > initialize
06-03 00:26:55.433+0900 I/MESSAGE_PORT( 7945): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
06-03 00:26:55.463+0900 I/MESSAGE_PORT( 7945): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 00:26:55.463+0900 I/MESSAGE_PORT( 7945): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 00:26:55.463+0900 I/MESSAGE_PORT( 7945): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:26:55.463+0900 I/MESSAGE_PORT( 7945): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
06-03 00:26:55.463+0900 I/MESSAGE_PORT( 7945): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
06-03 00:26:55.463+0900 I/MESSAGE_PORT( 7945): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 00:26:55.463+0900 I/MESSAGE_PORT( 7945): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 00:26:55.463+0900 E/weather-common( 7945): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
06-03 00:26:55.463+0900 I/MESSAGE_PORT(  845): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 00:26:55.463+0900 I/MESSAGE_PORT( 7945): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 00:26:55.463+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:26:55.463+0900 I/MESSAGE_PORT( 7945): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 00:26:55.463+0900 I/MESSAGE_PORT( 7945): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:26:55.463+0900 I/MESSAGE_PORT( 7945): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.deco-app:lockscreen-message-port]
06-03 00:26:55.463+0900 I/MESSAGE_PORT( 7945): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.deco-app : com.samsung.weather-m-agent] 
06-03 00:26:55.463+0900 I/MESSAGE_PORT( 7945): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 00:26:55.473+0900 E/MESSAGE_PORT( 7945): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0
06-03 00:26:55.473+0900 E/weather-common( 7945): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(631) > [0;40;31mmessage_port_send_message failed [com.samsung.deco-app, lockscreen-message-port][0;m
06-03 00:26:55.473+0900 I/MESSAGE_PORT( 7945): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 00:26:55.473+0900 I/MESSAGE_PORT( 7945): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 00:26:55.473+0900 I/MESSAGE_PORT( 7945): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:26:55.473+0900 I/MESSAGE_PORT( 7945): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
06-03 00:26:55.473+0900 I/MESSAGE_PORT( 7945): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
06-03 00:26:55.473+0900 I/MESSAGE_PORT( 7945): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 00:26:55.473+0900 W/LFE      (15849): [15849] 26:21:27.549[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:26:55.473+0900 E/MESSAGE_PORT( 7945): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
06-03 00:26:55.473+0900 E/weather-common( 7945): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
06-03 00:26:55.483+0900 I/MESSAGE_PORT( 7945): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:26:55.483+0900 I/MESSAGE_PORT( 7945): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:26:55.483+0900 I/MESSAGE_PORT( 7945): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:26:55.483+0900 I/MESSAGE_PORT( 7945): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
06-03 00:26:55.483+0900 I/MESSAGE_PORT( 7945): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
06-03 00:26:55.483+0900 I/MESSAGE_PORT( 7945): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:26:55.483+0900 I/MESSAGE_PORT( 7945): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 00:26:55.483+0900 I/MESSAGE_PORT( 7945): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:26:55.483+0900 I/MESSAGE_PORT( 7945): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:26:55.483+0900 I/MESSAGE_PORT( 7945): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:26:55.483+0900 I/MESSAGE_PORT( 7945): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
06-03 00:26:55.483+0900 I/MESSAGE_PORT( 7945): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
06-03 00:26:55.483+0900 I/MESSAGE_PORT( 1360): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 00:26:55.483+0900 I/MESSAGE_PORT( 7945): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:26:55.483+0900 E/MESSAGE_PORT( 7945): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
06-03 00:26:55.483+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:26:55.483+0900 E/weather-common( 7945): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
06-03 00:26:55.483+0900 E/weather-common( 7945): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 1[0;m
06-03 00:26:55.483+0900 E/weather-common( 7945): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:26:55.483+0900 E/weather-common( 7945): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : [0;m
06-03 00:26:55.483+0900 E/weather-common( 7945): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:26:55.483+0900 E/weather-common( 7945): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : [0;m
06-03 00:26:55.483+0900 E/weather-common( 7945): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:26:55.483+0900 E/weather-common( 7945): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : [0;m
06-03 00:26:55.483+0900 E/weather-common( 7945): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:26:55.483+0900 E/weather-common( 7945): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : [0;m
06-03 00:26:55.483+0900 E/weather-common( 7945): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:26:55.483+0900 E/weather-common( 7945): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : [0;m
06-03 00:26:55.483+0900 E/weather-common( 7945): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:26:55.483+0900 E/weather-common( 7945): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : [0;m
06-03 00:26:55.483+0900 E/weather-common( 7945): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:26:55.483+0900 E/weather-common( 7945): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : [0;m
06-03 00:26:55.483+0900 E/weather-common( 7945): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
06-03 00:26:55.483+0900 E/weather-common( 7945): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
06-03 00:26:55.483+0900 E/weather-agent( 7945): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
06-03 00:26:55.483+0900 E/weather-agent( 7945): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
06-03 00:26:55.483+0900 I/MESSAGE_PORT( 7945): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 00:26:55.483+0900 I/MESSAGE_PORT( 7945): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 00:26:55.503+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:26:55.553+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:26:55.553+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:26:55.553+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:26:55.553+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:26:55.553+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:26:55.553+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:26:55.563+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_update_cb(287) > received updating signal
06-03 00:26:55.573+0900 I/Tizen::System( 1210): (280) > The screen has been turned on.
06-03 00:26:55.573+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:26:55.573+0900 E/GAME    ( 2577): .\..\src\TizenImpl.c: device_display_changed_cb(80) > device_display_changed_cb: state change to 0
06-03 00:26:55.573+0900 I/Internet(27388): main.cpp: __display_changed_cb(1445) > 3, (nil), 0xbe8305a0
06-03 00:26:55.573+0900 I/Internet(27388): main.cpp: __display_changed_cb(1462) > DISPLAY_STATE_SCREEN state : [0]
06-03 00:26:55.573+0900 I/Internet(27388): main.cpp: __display_changed_cb(1474) > paused
06-03 00:26:55.613+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:26:55.623+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127795615
06-03 00:26:55.633+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
06-03 00:26:55.653+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:26:55.653+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 00:26:55.663+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:26:55.673+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:26:55.673+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:26:55.673+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:26:55.673+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:26:55.673+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:26:55.673+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:26:55.683+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:26:55.683+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 00:26:55.683+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 00:26:55.683+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 00:26:55.683+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 00:26:55.713+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127795701
06-03 00:26:55.713+0900 E/LOCKSCREEN(  845): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-03 00:26:55.713+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 00:26:55.753+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:26:55.763+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127795758
06-03 00:26:55.763+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:26:55.873+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127795867
06-03 00:26:55.883+0900 E/LOCKSCREEN(  845): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-03 00:26:55.883+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 00:26:56.093+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127796094
06-03 00:26:56.243+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127796245
06-03 00:26:56.243+0900 E/LOCKSCREEN(  845): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-03 00:26:56.243+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80001:VIEW_GESTURED
06-03 00:26:56.243+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80001 event_info:0
06-03 00:26:56.243+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 00:26:56.243+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
06-03 00:26:56.243+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
06-03 00:26:56.243+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
06-03 00:26:56.243+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:4:LKD_EVT_WILL_UNLOCK
06-03 00:26:56.243+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:4 event_info:0
06-03 00:26:56.243+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event_delay(1041) > [lockd_event_delay:1041:W] dealyed event:2:UNLOCK wait for:0.330000
06-03 00:26:56.243+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 00:26:56.484+0900 E/weather-agent( 7945): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
06-03 00:26:56.484+0900 I/CAPI_APPFW_APPLICATION( 7945): service_app_main.c: service_app_exit(446) > service_app_exit
06-03 00:26:56.494+0900 E/weather-agent( 7945): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
06-03 00:26:56.494+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
06-03 00:26:56.504+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
06-03 00:26:56.574+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
06-03 00:26:56.574+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
06-03 00:26:56.574+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
06-03 00:26:56.574+0900 E/LOCKSCREEN(  845): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
06-03 00:26:56.574+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 00:26:56.574+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:26:56.584+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 00:26:56.584+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 00:26:56.584+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-03 00:26:56.584+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:26:56.594+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 00:26:56.594+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:26:56.594+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 00:26:56.594+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:26:56.604+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(845) status(4)
06-03 00:26:56.604+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(845)
06-03 00:26:56.604+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 845, appid: com.samsung.lockscreen, status: bg
06-03 00:26:56.604+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 00:26:56.604+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:26:56.604+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:26:56.604+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 00:26:56.604+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 00:26:56.634+0900 W/LOCKSCREEN(  845): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [invisible]
06-03 00:26:56.634+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
06-03 00:26:56.634+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
06-03 00:26:56.654+0900 E/LOCKSCREEN(  845): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
06-03 00:26:56.654+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [com.samsun] 
06-03 00:26:56.654+0900 I/Tizen::System( 1210): (273) > Current App[com.samsun] is already actived.
06-03 00:26:56.654+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: PAUSE State: RUNNING
06-03 00:26:56.654+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:26:56.654+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:26:56.654+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 00:26:56.654+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
06-03 00:26:56.654+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
06-03 00:26:56.654+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 00:26:56.654+0900 E/LOCKSCREEN(  845): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-03 00:26:56.694+0900 I/Tizen::Net::Wifi( 1210): (941) > The background scan result updated.
06-03 00:26:56.734+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: MEM_FLUSH State: PAUSED
06-03 00:26:56.734+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:26:56.754+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
06-03 00:26:56.754+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 00:26:56.754+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:26:56.754+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 00:26:56.754+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 00:26:56.774+0900 E/LOCKSCREEN(  845): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
06-03 00:26:56.784+0900 W/AUL_AMD (  610): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-03 00:26:56.794+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7945
06-03 00:26:56.794+0900 I/Tizen::App( 1210): (243) > App[com.samsung.weather-m-agent] pid[7945] terminate event is forwarded
06-03 00:26:56.794+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:26:56.794+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 7945, ]
06-03 00:26:56.794+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:26:56.794+0900 I/Tizen::App( 1210): (506) > TerminatedApp(com.samsung.weather-m-agent)
06-03 00:26:56.794+0900 I/Tizen::App( 1210): (512) > Not registered pid(7945)
06-03 00:26:56.794+0900 I/Tizen::System( 1210): (246) > Terminated app [com.samsung.weather-m-agent]
06-03 00:26:56.794+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:26:56.794+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 7945
06-03 00:26:56.804+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:26:56.804+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 7945.
06-03 00:26:57.324+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127797319
06-03 00:26:57.415+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127797417
06-03 00:26:57.425+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.example)
06-03 00:26:57.425+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
06-03 00:26:57.425+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 860
06-03 00:26:57.435+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 8
06-03 00:26:57.435+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:26:57.435+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 00:26:57.445+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-03 00:26:57.445+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 00:26:57.455+0900 I/CAPI_APPFW_APPLICATION( 7845): app_main.c: ui_app_main(789) > app_efl_main
06-03 00:26:57.465+0900 I/CAPI_APPFW_APPLICATION( 7845): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 00:26:57.485+0900 E/TBM     ( 7845): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 00:26:57.545+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 7845, appid: org.example.example
06-03 00:26:57.545+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 00:26:57.555+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(7845)
06-03 00:26:57.645+0900 I/APP_CORE( 7845): appcore-efl.c: __do_app(514) > [APP 7845] Event: RESET State: CREATED
06-03 00:26:57.645+0900 I/CAPI_APPFW_APPLICATION( 7845): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 00:26:57.645+0900 E/EFL     ( 7845): edje<7845> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:26:57.645+0900 E/EFL     ( 7845): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:26:57.645+0900 E/EFL     ( 7845): edje<7845> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:26:57.645+0900 E/EFL     ( 7845): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:26:57.655+0900 E/EFL     ( 7845): edje<7845> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:26:57.655+0900 E/EFL     ( 7845): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:26:57.655+0900 E/EFL     ( 7845): edje<7845> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:26:57.655+0900 E/EFL     ( 7845): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:26:57.655+0900 E/EFL     ( 7845): edje<7845> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:26:57.655+0900 E/EFL     ( 7845): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:26:57.685+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:26:57.685+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:26:57.685+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:26:57.715+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:26:57.715+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:26:57.725+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:26:57.725+0900 W/APP_CORE( 7845): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:9c00002
06-03 00:26:57.725+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 00:26:57.825+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
06-03 00:26:57.825+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:26:57.825+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
06-03 00:26:57.825+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
06-03 00:26:57.825+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
06-03 00:26:57.825+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
06-03 00:26:57.835+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7845) status(3)
06-03 00:26:57.835+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(7845)
06-03 00:26:57.835+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 7845, appid: org.example.example, status: fg
06-03 00:26:57.845+0900 E/weather-widget( 1360): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-03 00:26:57.845+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 00:26:57.845+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 00:26:57.845+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: bg
06-03 00:26:57.875+0900 I/APP_CORE( 7845): appcore-efl.c: __do_app(514) > [APP 7845] Event: RESUME State: CREATED
06-03 00:26:57.885+0900 I/APP_CORE( 7845): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 00:26:57.885+0900 I/APP_CORE( 7845): appcore-efl.c: __do_app(625) > [APP 7845] Initial Launching, call the resume_cb
06-03 00:26:57.885+0900 I/CAPI_APPFW_APPLICATION( 7845): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:26:57.975+0900 W/LFE      (15849): [15849] 26:21:30.049[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:26:58.195+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7845) status(0)
06-03 00:26:58.586+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3259
06-03 00:26:58.596+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 00:26:58.596+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 7845.
06-03 00:26:59.356+0900 I/UXT     ( 7958): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-03 00:26:59.587+0900 E/EFL     ( 7845): ecore_x<7845> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127799594
06-03 00:26:59.667+0900 E/EFL     ( 7845): ecore_x<7845> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127799670
06-03 00:27:00.457+0900 W/LFE      (15849): [15849] 26:21:32.542[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:27:00.948+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(195) > ""
06-03 00:27:00.948+0900 E/UXT     (  646): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 12:27
06-03 00:27:00.948+0900 I/INDICATOR(  646): clock.c: getTimeFormatted(176) > "time format : 오전 12:27"
06-03 00:27:00.948+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 12:27"
06-03 00:27:00.948+0900 W/INDICATOR(  646): clock.c: indicator_clock_changed_cb(272) > 
06-03 00:27:00.948+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145564339 Time: <font_size=31> </font_size> <font_size=31> 오전 12:27</font_size></font>"
06-03 00:27:01.148+0900 E/EFL     ( 7845): ecore_x<7845> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127801145
06-03 00:27:01.228+0900 E/EFL     ( 7845): ecore_x<7845> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127801233
06-03 00:27:01.499+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-03 00:27:01.659+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: MEM_FLUSH State: PAUSED
06-03 00:27:02.319+0900 E/EFL     ( 7845): ecore_x<7845> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127802324
06-03 00:27:02.509+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 7845 pgid = 7845
06-03 00:27:02.509+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(143) > dead_pid(7845)
06-03 00:27:02.509+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:27:02.570+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 00:27:02.570+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 00:27:02.570+0900 E/AUL_PAD ( 1359): launchpad.c: main(698) > error reading sigchld info
06-03 00:27:02.570+0900 E/EFL     (  646): <646> lib/ecore_ipc/ecore_ipc.c:803 ecore_ipc_client_send() safety check failed: !cl->client is true
06-03 00:27:02.580+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 7845
06-03 00:27:02.580+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[7845] terminate event is forwarded
06-03 00:27:02.580+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:27:02.580+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 7845, ]
06-03 00:27:02.580+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:27:02.580+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 00:27:02.580+0900 I/Tizen::App( 1210): (512) > Not registered pid(7845)
06-03 00:27:02.580+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 00:27:02.580+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:27:02.580+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7845
06-03 00:27:02.580+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 7845
06-03 00:27:02.590+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3262
06-03 00:27:02.590+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 00:27:02.600+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:27:02.600+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:27:02.600+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 00:27:02.600+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 00:27:02.600+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 00:27:02.600+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 00:27:02.600+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:27:02.600+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 7845.
06-03 00:27:02.610+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 00:27:02.610+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:27:02.610+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 00:27:02.610+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:27:02.620+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 00:27:02.630+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:27:02.630+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:27:02.630+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:27:02.630+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:27:02.630+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:27:02.640+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:27:02.650+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 00:27:02.650+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:27:02.650+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:27:02.650+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 00:27:02.650+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 00:27:02.650+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 00:27:02.650+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 00:27:02.680+0900 W/CRASH_MANAGER( 7962): worker.c: worker_job(1199) > 1107845657861149641722
