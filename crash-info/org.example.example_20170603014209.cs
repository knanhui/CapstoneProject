S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: example
PID: 9825
Date: 2017-06-03 01:42:09+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 9825, uid 5000)

Register Information
r0   = 0xb278cdbc, r1   = 0x8000ca66
r2   = 0x8000ca66, r3   = 0x80020905
r4   = 0x8001b6dc, r5   = 0xbeb212a0
r6   = 0xb277ae61, r7   = 0xbeb210e8
r8   = 0x8001b6dc, r9   = 0xb5e71708
r10  = 0xb8231df0, fp   = 0xbeb2127c
ip   = 0xb278ca70, sp   = 0xbeb21028
lr   = 0x00000000, pc   = 0xb277aef2
cpsr = 0x800f0030

Memory Information
MemTotal:   987012 KB
MemFree:     57228 KB
Buffers:     13588 KB
Cached:     113336 KB
VmPeak:     100844 KB
VmSize:      99336 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24140 KB
VmRSS:       24140 KB
VmData:      25268 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35728 KB
VmPTE:          84 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 9825 TID = 9825
9825 9827 9995 

Maps Information
b1aee000 b1af6000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1b07000 b1b08000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b18000 b1b2c000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b40000 b1b41000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1b51000 b1b54000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1b65000 b1b66000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1b76000 b1b78000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1b88000 b1b8a000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1b9a000 b1baa000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1bba000 b1bc6000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1bd8000 b23d7000 rw-p [stack:9995]
b2708000 b270f000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2720000 b2728000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b2738000 b274d000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b275f000 b2765000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2775000 b277d000 r-xp /opt/usr/apps/org.example.example/bin/example
b28d5000 b29b8000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b29ef000 b2a17000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a29000 b3228000 rw-p [stack:9827]
b3228000 b322a000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b323a000 b3244000 r-xp /lib/libnss_files-2.20-2014.11.so
b3255000 b325e000 r-xp /lib/libnss_nis-2.20-2014.11.so
b326f000 b3280000 r-xp /lib/libnsl-2.20-2014.11.so
b3293000 b3299000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32aa000 b32ab000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b32d3000 b32da000 r-xp /usr/lib/libminizip.so.1.0.0
b32ea000 b32ef000 r-xp /usr/lib/libstorage.so.0.1
b32ff000 b335e000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3374000 b3388000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3398000 b33dc000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b33ec000 b33f4000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3404000 b3434000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3447000 b3500000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3514000 b3567000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3578000 b3593000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35a3000 b3664000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3677000 b3687000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3697000 b36a4000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36b5000 b36bc000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b36cc000 b370d000 r-xp /usr/lib/libmdm.so.1.2.12
b371d000 b3725000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3734000 b3744000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3765000 b37c5000 r-xp /usr/lib/libasound.so.2.0.0
b37d7000 b37da000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b37ea000 b37ed000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b37fd000 b3802000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3812000 b3813000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3823000 b382e000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3842000 b3849000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3859000 b385f000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b386f000 b3874000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3884000 b389f000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38af000 b38b6000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38c6000 b38c9000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b38da000 b3908000 r-xp /usr/lib/libidn.so.11.5.44
b3918000 b392e000 r-xp /usr/lib/libnghttp2.so.5.4.0
b393f000 b3949000 r-xp /usr/lib/libcares.so.2.1.0
b3959000 b3963000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3973000 b3975000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3985000 b3986000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3996000 b399a000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39ab000 b39d3000 r-xp /usr/lib/libui-extension.so.0.1.0
b39e4000 b3a0d000 r-xp /usr/lib/libturbojpeg.so
b3a2d000 b3a33000 r-xp /usr/lib/libgif.so.4.1.6
b3a43000 b3a89000 r-xp /usr/lib/libcurl.so.4.3.0
b3a9a000 b3abb000 r-xp /usr/lib/libexif.so.12.3.3
b3ad6000 b3aeb000 r-xp /usr/lib/libtts.so
b3afc000 b3b04000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b14000 b3bda000 r-xp /usr/lib/libdali-core.so.0.0.0
b3bfa000 b3cf2000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d11000 b3ddf000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3df6000 b3df8000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e08000 b3e0e000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e1e000 b3e41000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e52000 b3e54000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e64000 b3e66000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3e77000 b3e7c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3e93000 b3e95000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ea5000 b3eac000 r-xp /usr/lib/libsensord-share.so
b3ebc000 b3ed4000 r-xp /usr/lib/libsensor.so.1.1.0
b3ee5000 b3ee8000 r-xp /usr/lib/libXv.so.1.0.0
b3ef8000 b3efd000 r-xp /usr/lib/libutilX.so.1.1.0
b3f0d000 b3f12000 r-xp /usr/lib/libappcore-common.so.1.1
b3f22000 b3f29000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f3c000 b3f40000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f51000 b402f000 r-xp /usr/lib/libCOREGL.so.4.0
b404f000 b4052000 r-xp /usr/lib/libuuid.so.1.3.0
b4062000 b4079000 r-xp /usr/lib/libblkid.so.1.1.0
b408a000 b408c000 r-xp /usr/lib/libXau.so.6.0.0
b409c000 b40e3000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b40f5000 b40fb000 r-xp /usr/lib/libjson-c.so.2.0.1
b410c000 b4110000 r-xp /usr/lib/libogg.so.0.7.1
b4120000 b4142000 r-xp /usr/lib/libvorbis.so.0.4.3
b4152000 b4236000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4252000 b4255000 r-xp /usr/lib/libEGL.so.1.4
b4266000 b426c000 r-xp /usr/lib/libxcb-render.so.0.0.0
b427c000 b427e000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b428e000 b429b000 r-xp /usr/lib/libGLESv2.so.2.0
b42ac000 b430e000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4323000 b433b000 r-xp /usr/lib/libmount.so.1.1.0
b434d000 b4361000 r-xp /usr/lib/libxcb.so.1.1.0
b4371000 b4378000 r-xp /lib/libcrypt-2.20-2014.11.so
b43b0000 b43b2000 r-xp /usr/lib/libiri.so
b43c2000 b43cd000 r-xp /usr/lib/libgpg-error.so.0.15.0
b43de000 b4414000 r-xp /usr/lib/libpulse.so.0.16.2
b4425000 b4468000 r-xp /usr/lib/libsndfile.so.1.0.25
b447d000 b4492000 r-xp /lib/libexpat.so.1.5.2
b44a4000 b4562000 r-xp /usr/lib/libcairo.so.2.11200.14
b4576000 b457e000 r-xp /usr/lib/libdrm.so.2.4.0
b458e000 b4591000 r-xp /usr/lib/libdri2.so.0.0.0
b45a1000 b45ef000 r-xp /usr/lib/libssl.so.1.0.0
b4604000 b4610000 r-xp /usr/lib/libeeze.so.1.13.0
b4621000 b462a000 r-xp /usr/lib/libethumb.so.1.13.0
b463a000 b463d000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b464d000 b4804000 r-xp /usr/lib/libcrypto.so.1.0.0
b55ef000 b55f8000 r-xp /usr/lib/libXi.so.6.1.0
b5608000 b560a000 r-xp /usr/lib/libXgesture.so.7.0.0
b561a000 b561e000 r-xp /usr/lib/libXtst.so.6.1.0
b562e000 b5634000 r-xp /usr/lib/libXrender.so.1.3.0
b5644000 b564a000 r-xp /usr/lib/libXrandr.so.2.2.0
b565a000 b565c000 r-xp /usr/lib/libXinerama.so.1.0.0
b566d000 b5670000 r-xp /usr/lib/libXfixes.so.3.1.0
b5680000 b568b000 r-xp /usr/lib/libXext.so.6.4.0
b569b000 b569d000 r-xp /usr/lib/libXdamage.so.1.1.0
b56ad000 b56af000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56bf000 b57a1000 r-xp /usr/lib/libX11.so.6.3.0
b57b5000 b57bc000 r-xp /usr/lib/libXcursor.so.1.0.2
b57cc000 b57e4000 r-xp /usr/lib/libudev.so.1.6.0
b57e6000 b57e9000 r-xp /lib/libattr.so.1.1.0
b57f9000 b5819000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b581a000 b581f000 r-xp /usr/lib/libffi.so.6.0.2
b5830000 b5848000 r-xp /lib/libz.so.1.2.8
b5858000 b585a000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b586a000 b593f000 r-xp /usr/lib/libxml2.so.2.9.2
b5954000 b59ef000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a0b000 b5a0e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a1e000 b5a37000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a48000 b5a59000 r-xp /lib/libresolv-2.20-2014.11.so
b5a6d000 b5ae7000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5afc000 b5afe000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b0e000 b5b15000 r-xp /usr/lib/libembryo.so.1.13.0
b5b25000 b5b2f000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b40000 b5b58000 r-xp /usr/lib/libpng12.so.0.50.0
b5b69000 b5b8c000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bad000 b5bc1000 r-xp /usr/lib/libector.so.1.13.0
b5bd2000 b5bea000 r-xp /usr/lib/liblua-5.1.so
b5bfb000 b5c52000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c66000 b5c8e000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5c9f000 b5cb2000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cc3000 b5cfd000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d0e000 b5d1c000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d2c000 b5d34000 r-xp /usr/lib/libtbm.so.1.0.0
b5d44000 b5d51000 r-xp /usr/lib/libeio.so.1.13.0
b5d61000 b5d63000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d73000 b5d78000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5d88000 b5d9f000 r-xp /usr/lib/libefreet.so.1.13.0
b5db1000 b5dd1000 r-xp /usr/lib/libeldbus.so.1.13.0
b5de1000 b5e01000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e03000 b5e09000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e19000 b5e2a000 r-xp /usr/lib/libemotion.so.1.13.0
b5e3b000 b5e42000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e52000 b5e61000 r-xp /usr/lib/libeo.so.1.13.0
b5e72000 b5e84000 r-xp /usr/lib/libecore_input.so.1.13.0
b5e95000 b5e9a000 r-xp /usr/lib/libecore_file.so.1.13.0
b5eaa000 b5ec3000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5ed3000 b5ef0000 r-xp /usr/lib/libeet.so.1.13.0
b5f09000 b5f51000 r-xp /usr/lib/libeina.so.1.13.0
b5f62000 b5f72000 r-xp /usr/lib/libefl.so.1.13.0
b5f83000 b6068000 r-xp /usr/lib/libicuuc.so.51.1
b6085000 b61c5000 r-xp /usr/lib/libicui18n.so.51.1
b61dc000 b6214000 r-xp /usr/lib/libecore_x.so.1.13.0
b6226000 b6229000 r-xp /lib/libcap.so.2.21
b6239000 b6262000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6273000 b627a000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b628c000 b62c3000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62d4000 b63bf000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63d2000 b644b000 r-xp /usr/lib/libsqlite3.so.0.8.6
b645d000 b6462000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6472000 b647c000 r-xp /usr/lib/libvconf.so.0.2.45
b648c000 b648e000 r-xp /usr/lib/libvasum.so.0.3.1
b649e000 b64a0000 r-xp /usr/lib/libttrace.so.1.1
b64b0000 b64b3000 r-xp /usr/lib/libiniparser.so.0
b64c3000 b64e9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b64f9000 b64fe000 r-xp /usr/lib/libxdgmime.so.1.1.0
b650f000 b6526000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6537000 b65a2000 r-xp /lib/libm-2.20-2014.11.so
b65b3000 b65b9000 r-xp /lib/librt-2.20-2014.11.so
b65ca000 b65d7000 r-xp /usr/lib/libunwind.so.8.0.1
b660d000 b6731000 r-xp /lib/libc-2.20-2014.11.so
b6746000 b675f000 r-xp /lib/libgcc_s-4.9.so.1
b676f000 b6851000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6862000 b688c000 r-xp /usr/lib/libdbus-1.so.3.8.12
b689d000 b68d9000 r-xp /usr/lib/libsystemd.so.0.4.0
b68db000 b695e000 r-xp /usr/lib/libedje.so.1.13.0
b6971000 b698f000 r-xp /usr/lib/libecore.so.1.13.0
b69af000 b6b36000 r-xp /usr/lib/libevas.so.1.13.0
b6b6b000 b6b7f000 r-xp /lib/libpthread-2.20-2014.11.so
b6b93000 b6dc7000 r-xp /usr/lib/libelementary.so.1.13.0
b6df6000 b6dfa000 r-xp /usr/lib/libsmack.so.1.0.0
b6e0a000 b6e11000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e21000 b6e23000 r-xp /usr/lib/libdlog.so.0.0.0
b6e33000 b6e36000 r-xp /usr/lib/libbundle.so.0.1.22
b6e46000 b6e48000 r-xp /lib/libdl-2.20-2014.11.so
b6e59000 b6e71000 r-xp /usr/lib/libaul.so.0.1.0
b6e85000 b6e8a000 r-xp /usr/lib/libappcore-efl.so.1.1
b6e9b000 b6ea8000 r-xp /usr/lib/liblptcp.so
b6eba000 b6ebe000 r-xp /usr/lib/libsys-assert.so
b6ecf000 b6eef000 r-xp /lib/ld-2.20-2014.11.so
b6f00000 b6f05000 r-xp /usr/bin/launchpad-loader
b7fc7000 b827f000 rw-p [heap]
beb01000 beb22000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9825)
Call Stack Count: 19
 0: create_button_view + 0x1d (0xb277aef2) [/opt/usr/apps/org.example.example/bin/example] + 0x5ef2
 1: setting_view_cb + 0x2c (0xb277ae8d) [/opt/usr/apps/org.example.example/bin/example] + 0x5e8d
 2: (0xb69e4175) [/usr/lib/libevas.so.1] + 0x35175
 3: (0xb5e5d219) [/usr/lib/libeo.so.1] + 0xb219
 4: eo_event_callback_call + 0x68 (0xb5e5bfb9) [/usr/lib/libeo.so.1] + 0x9fb9
 5: (0xb69e4515) [/usr/lib/libevas.so.1] + 0x35515
 6: (0xb69ec725) [/usr/lib/libevas.so.1] + 0x3d725
 7: evas_canvas_event_feed_mouse_down + 0x6a (0xb69f1f6b) [/usr/lib/libevas.so.1] + 0x42f6b
 8: evas_event_feed_mouse_down + 0x30 (0xb69f5939) [/usr/lib/libevas.so.1] + 0x46939
 9: (0xb463c173) [/usr/lib/libecore_input_evas.so.1] + 0x2173
10: (0xb697cc4b) [/usr/lib/libecore.so.1] + 0xbc4b
11: (0xb6982a5d) [/usr/lib/libecore.so.1] + 0x11a5d
12: ecore_main_loop_begin + 0x3e (0xb6982c83) [/usr/lib/libecore.so.1] + 0x11c83
13: appcore_efl_main + 0x20c (0xb6e882bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
14: ui_app_main + 0xc0 (0xb3f3e909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
15: main + 0x10e (0xb277a677) [/opt/usr/apps/org.example.example/bin/example] + 0x5677
16: (0xb6f01bb5) [/opt/usr/apps/org.example.example/bin/example] + 0x1bb5
17: __libc_start_main + 0x114 (0xb66234bc) [/lib/libc.so.6] + 0x164bc
18: (0xb6f01eb4) [/opt/usr/apps/org.example.example/bin/example] + 0x1eb4
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
ou are running Embryo->EDC->Embryo with script program '_p46';
06-03 01:41:00.559+0900 E/EFL     ( 9807): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:41:00.599+0900 E/EFL     ( 9807): edje<9807> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p46';
06-03 01:41:00.599+0900 E/EFL     ( 9807): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:41:00.609+0900 E/EFL     ( 9807): edje<9807> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p46';
06-03 01:41:00.609+0900 E/EFL     ( 9807): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:41:00.629+0900 E/EFL     ( 9807): edje<9807> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p46';
06-03 01:41:00.629+0900 E/EFL     ( 9807): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:41:00.649+0900 E/EFL     ( 9807): ecore_x<9807> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=132240646
06-03 01:41:00.649+0900 E/EFL     ( 9807): edje<9807> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p46';
06-03 01:41:00.649+0900 E/EFL     ( 9807): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:41:01.020+0900 E/EFL     ( 9807): ecore_x<9807> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=132241021
06-03 01:41:02.001+0900 E/EFL     ( 9807): ecore_x<9807> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=132242003
06-03 01:41:03.082+0900 E/EFL     ( 9807): ecore_x<9807> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=132243082
06-03 01:41:03.292+0900 E/EFL     ( 9807): edje<9807> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p46';
06-03 01:41:03.292+0900 E/EFL     ( 9807): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:41:03.322+0900 E/EFL     ( 9807): edje<9807> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p46';
06-03 01:41:03.322+0900 E/EFL     ( 9807): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:41:03.342+0900 E/EFL     ( 9807): edje<9807> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p46';
06-03 01:41:03.342+0900 E/EFL     ( 9807): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:41:03.362+0900 E/EFL     ( 9807): edje<9807> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p46';
06-03 01:41:03.362+0900 E/EFL     ( 9807): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:41:03.382+0900 E/EFL     ( 9807): edje<9807> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p46';
06-03 01:41:03.382+0900 E/EFL     ( 9807): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:41:03.402+0900 E/EFL     ( 9807): edje<9807> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p46';
06-03 01:41:03.402+0900 E/EFL     ( 9807): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:41:03.422+0900 E/EFL     ( 9807): edje<9807> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p46';
06-03 01:41:03.422+0900 E/EFL     ( 9807): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:41:03.432+0900 E/EFL     ( 9807): edje<9807> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p46';
06-03 01:41:03.432+0900 E/EFL     ( 9807): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:41:03.452+0900 E/EFL     ( 9807): edje<9807> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p46';
06-03 01:41:03.452+0900 E/EFL     ( 9807): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:41:03.462+0900 E/EFL     ( 9807): edje<9807> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p46';
06-03 01:41:03.462+0900 E/EFL     ( 9807): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:41:03.482+0900 E/EFL     ( 9807): edje<9807> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p46';
06-03 01:41:03.482+0900 E/EFL     ( 9807): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:41:03.492+0900 E/EFL     ( 9807): edje<9807> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p46';
06-03 01:41:03.492+0900 E/EFL     ( 9807): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:41:03.532+0900 E/EFL     ( 9807): edje<9807> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p46';
06-03 01:41:03.532+0900 E/EFL     ( 9807): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:41:03.552+0900 E/EFL     ( 9807): edje<9807> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p46';
06-03 01:41:03.552+0900 E/EFL     ( 9807): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:41:03.562+0900 E/EFL     ( 9807): edje<9807> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p46';
06-03 01:41:03.562+0900 E/EFL     ( 9807): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:41:03.582+0900 E/EFL     ( 9807): ecore_x<9807> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=132243573
06-03 01:41:03.582+0900 E/EFL     ( 9807): edje<9807> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p46';
06-03 01:41:03.582+0900 E/EFL     ( 9807): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:41:26.024+0900 I/Tizen::Net::Wifi( 1210): (941) > The background scan result updated.
06-03 01:41:26.084+0900 E/GAME    ( 2577): .\..\src\TizenImpl.c: device_display_changed_cb(80) > device_display_changed_cb: state change to 1
06-03 01:41:26.094+0900 I/Tizen::System( 1210): (458) > org.tizen.system.deviced.display - CurrentBrightness (0)
06-03 01:41:33.011+0900 E/EFL     ( 9807): ecore_x<9807> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=132273008
06-03 01:41:33.021+0900 I/Tizen::System( 1210): (280) > The screen has been turned on.
06-03 01:41:33.021+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:41:33.021+0900 E/GAME    ( 2577): .\..\src\TizenImpl.c: device_display_changed_cb(80) > device_display_changed_cb: state change to 0
06-03 01:41:33.051+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:41:33.051+0900 I/Tizen::System( 1210): (458) > org.tizen.system.deviced.display - CurrentBrightness (92)
06-03 01:41:33.111+0900 E/EFL     ( 9807): ecore_x<9807> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=132273095
06-03 01:41:33.271+0900 E/EFL     ( 9807): ecore_x<9807> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=132273260
06-03 01:41:33.431+0900 E/EFL     ( 9807): ecore_x<9807> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=132273433
06-03 01:41:35.443+0900 W/LOCKSCREEN(  845): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 200 is changed to 98
06-03 01:41:35.443+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:40000:CONF_CHANGED
06-03 01:41:35.443+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:40000 event_info:200
06-03 01:41:35.443+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:200
06-03 01:41:35.453+0900 I/INDICATOR(  646): battery.c: show_battery_icon(376) > "Percentage:(0) / Level:(9) / batt_Full:(0) / battery_charging(1)"
06-03 01:41:35.453+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
06-03 01:41:35.453+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 01:41:35.453+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 01:41:35.453+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 01:41:35.453+0900 E/INDICATOR(  646): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-03 01:41:35.473+0900 E/INDICATOR(  646): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-03 01:41:43.031+0900 E/PKGMGR_SERVER( 9868): pkgmgr-server.c: main(2414) > package manager server start
06-03 01:41:43.081+0900 E/PKGMGR  ( 9866): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.example, -1]
06-03 01:41:43.121+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
06-03 01:41:43.131+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-03 01:41:43.141+0900 E/PKGMGR_SERVER( 9868): pkgmgr-server.c: sighandler(417) > child NORMAL exit [9871]
06-03 01:41:45.003+0900 E/PKGMGR_SERVER( 9868): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-03 01:41:45.003+0900 E/PKGMGR_SERVER( 9868): pkgmgr-server.c: main(2471) > package manager server terminated.
06-03 01:41:47.735+0900 E/EFL     ( 9807): ecore_x<9807> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=132287736
06-03 01:41:47.755+0900 E/EFL     ( 9807): ecore_x<9807> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=132287757
06-03 01:41:55.753+0900 E/PKGMGR  ( 9920): pkgmgr.c: pkgmgr_client_uninstall(2142) > uninstall pkg start.
06-03 01:41:55.843+0900 E/PKGMGR_SERVER( 9922): pkgmgr-server.c: main(2414) > package manager server start
06-03 01:41:55.903+0900 E/PKGMGR_SERVER( 9922): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
06-03 01:41:55.903+0900 E/PKGMGR_SERVER( 9922): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.example]
06-03 01:41:55.913+0900 E/PKGMGR  ( 9920): pkgmgr.c: pkgmgr_client_uninstall(2270) > uninstall pkg finish, ret=[99200002]
06-03 01:41:56.063+0900 E/rpm-installer( 9925): rpm-cmdline.c: __ri_is_core_tpk_app(302) > This is a core tpk app.
06-03 01:41:56.124+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: start, val: uninstall
06-03 01:41:56.124+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [start], Value = [uninstall], install = [1]
06-03 01:41:56.124+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
06-03 01:41:56.134+0900 I/SYNCSERVICE(  945): SyncManager_SyncManager.cpp: OnPackageUninstalled(403) > OnPackageUninstalled [type tpk] type [pkdId:org.example.example]
06-03 01:41:56.134+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
06-03 01:41:56.134+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:41:56.134+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:41:56.134+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:41:56.134+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:41:56.134+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
06-03 01:41:56.144+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-03 01:41:56.144+0900 E/rpm-installer( 9925): rpm-installer.c: __ri_check_running_app(2267) > app[org.example.example] , running state[0].
06-03 01:41:56.164+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.example]
06-03 01:41:56.164+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.example]
06-03 01:41:56.164+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
06-03 01:41:56.174+0900 I/SYNCSERVICE(  945): SyncManager_SyncManager.cpp: OnPackageUninstalled(403) > OnPackageUninstalled [type tpk] type [pkdId:org.example.example]
06-03 01:41:56.244+0900 E/PKGMGR_PARSER( 9925): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
06-03 01:41:56.264+0900 I/PRIVACY-MANAGER-CLIENT( 9925): SocketClient.cpp: SocketClient(37) > Client created
06-03 01:41:56.264+0900 I/PRIVACY-MANAGER-CLIENT( 9925): SocketClient.cpp: connect(62) > Client connected
06-03 01:41:56.264+0900 I/PRIVACY-MANAGER-SERVER(  906): SocketService.cpp: mainloop(230) > Got incoming connection
06-03 01:41:56.264+0900 I/PRIVACY-MANAGER-CLIENT( 9925): SocketClient.cpp: disconnect(72) > Client disconnected
06-03 01:41:56.264+0900 E/PKGMGR_CERT( 9925): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
06-03 01:41:56.274+0900 E/PKGMGR_CERT( 9925): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
06-03 01:41:56.274+0900 E/PKGMGR_CERT( 9925): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
06-03 01:41:56.364+0900 E/PKGMGR_CERT( 9925): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
06-03 01:41:56.364+0900 E/PKGMGR_CERT( 9925): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
06-03 01:41:56.364+0900 E/PKGMGR_CERT( 9925): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
06-03 01:41:56.364+0900 E/rpm-installer( 9925): rpm-installer.c: _rpm_uninstall_pkg_with_dbpath(3415) > success
06-03 01:41:56.364+0900 E/rpm-installer( 9925): rpm-installer.c: _rpm_uninstall_pkg_with_dbpath(3416) > try to classify and delete residual files
06-03 01:41:58.005+0900 E/PKGMGR_SERVER( 9922): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-03 01:41:58.596+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
06-03 01:41:58.596+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
06-03 01:41:58.596+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
06-03 01:41:58.596+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.example]
06-03 01:41:58.596+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(494) >  #8
06-03 01:41:58.596+0900 I/SYNCSERVICE(  945): SyncManager_SyncManager.cpp: OnPackageUninstalled(403) > OnPackageUninstalled [type tpk] type [pkdId:org.example.example]
06-03 01:41:58.596+0900 I/SYNCSERVICE(  945): SyncManager_SyncAdapterAggregator.cpp: HandlePackageUninstalled(129) > Removing sync adapter for package [org.example.example]
06-03 01:41:58.596+0900 I/SYNCSERVICE(  945): SyncManager_SyncJobsAggregator.cpp: HandlePackageUninstalled(197) > Sync jobs for package org.example.example are not found
06-03 01:41:58.596+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: end, val: ok
06-03 01:41:58.596+0900 I/Tizen::App( 1210): (83) > Uninstallation is Completed. [Package = org.example.example]
06-03 01:41:58.596+0900 I/Tizen::App( 1210): (709) > Enter. package(org.example.example), uninstallationResult(1)
06-03 01:41:58.606+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1104) > g_hash_table_foreach_remove, 1
06-03 01:41:58.606+0900 E/PUSHD   ( 1001): db.c: _get_app_info_by_query(361) > DB step: 101 [unknown error]
06-03 01:41:58.606+0900 E/PUSHD   ( 1001): db.c: db_reg_get_by_tizen_pkg_id(438) > Fail to get app_info
06-03 01:41:58.616+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:41:58.616+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:41:58.626+0900 E/PKGMGR_SERVER( 9922): pkgmgr-server.c: sighandler(417) > child NORMAL exit [9925]
06-03 01:41:58.626+0900 E/Tizen::App( 1210): (1141) > [E_PKG_NOT_INSTALLED] pkgmgrinfo_pkginfo_get_pkginfo() is failed. result=[-1], package=[org.example.example]
06-03 01:41:58.626+0900 E/Tizen::App( 1210): (278) > [E_PKG_NOT_INSTALLED] package (org.example.example) is not found.
06-03 01:41:58.626+0900 E/Tizen::App( 1210): (2193) > GetPackageInfoN(org.example.example) failed.
06-03 01:41:58.626+0900 I/Tizen::App( 1210): (840) > Enter.
06-03 01:41:58.626+0900 I/Tizen::App( 1210): (883) > Exit.
06-03 01:41:58.626+0900 I/Tizen::App( 1210): (720) > Exit.
06-03 01:41:58.626+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [end], Value = [ok], install = [96]
06-03 01:41:58.626+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:41:58.626+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:41:58.646+0900 E/PKGMGR_INFO(  860): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_filter_foreach_pkginfo(2152) > where = package_info.package_support_disable IN ('true','True') and package_info.package_nodisplay IN ('false','False') and package_info.package_disable IN ('true','True')
06-03 01:41:58.646+0900 E/PKGMGR_INFO(  860): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_filter_foreach_pkginfo(2158) > query = select * from package_info LEFT OUTER JOIN package_localized_info ON package_info.package=package_localized_info.package and package_localized_info.package_locale IN ('No Locale', 'ko-kr') where package_info.package_support_disable IN ('true','True') and package_info.package_nodisplay IN ('false','False') and package_info.package_disable IN ('true','True')
06-03 01:41:58.836+0900 E/PKGMGR  ( 9931): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
06-03 01:41:58.876+0900 E/PKGMGR_SERVER( 9922): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.example-1.0.0-arm.tpk]
06-03 01:41:58.886+0900 E/PKGMGR_INFO( 9922): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.example-1.0.0-arm.tpk] not found in DB
06-03 01:41:58.896+0900 E/rpm-installer( 9922): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
06-03 01:41:58.906+0900 E/PKGMGR_SERVER( 9922): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
06-03 01:41:58.906+0900 E/PKGMGR  ( 9931): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[99310002]
06-03 01:41:59.026+0900 E/PKGMGR_INSTALLER( 9933): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
06-03 01:41:59.026+0900 E/rpm-installer( 9933): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.example-1.0.0-arm.tpk] is tpk package.
06-03 01:41:59.046+0900 E/rpm-installer( 9933): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
06-03 01:41:59.046+0900 E/rpm-installer( 9933): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
06-03 01:41:59.046+0900 E/rpm-installer( 9933): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-03 01:41:59.046+0900 E/rpm-installer( 9933): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
06-03 01:41:59.046+0900 E/rpm-installer( 9933): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-03 01:41:59.096+0900 W/CERT_SVC_VCORE( 9933): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
06-03 01:41:59.156+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: start, val: install
06-03 01:41:59.156+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [start], Value = [install], install = [96]
06-03 01:41:59.166+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: install_percent, val: 30
06-03 01:41:59.166+0900 I/Tizen::App( 1210): (119) > InstallationInProgress [30]
06-03 01:41:59.166+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [install_percent], Value = [30], install = [96]
06-03 01:41:59.166+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:41:59.166+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:41:59.166+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:41:59.166+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:41:59.166+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:41:59.166+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:41:59.166+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:41:59.166+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:41:59.367+0900 E/rpm-installer( 9933): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
06-03 01:41:59.367+0900 E/rpm-installer( 9933): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
06-03 01:41:59.367+0900 E/rpm-installer( 9933): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
06-03 01:41:59.367+0900 E/rpm-installer( 9933): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-03 01:41:59.367+0900 E/rpm-installer( 9933): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
06-03 01:41:59.367+0900 E/rpm-installer( 9933): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
06-03 01:41:59.377+0900 E/PKGMGR_PARSER( 9933): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
06-03 01:41:59.377+0900 E/PKGMGR_PARSER( 9933): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
06-03 01:41:59.427+0900 I/PRIVACY-MANAGER-CLIENT( 9933): SocketClient.cpp: SocketClient(37) > Client created
06-03 01:41:59.657+0900 E/PKGMGR_PARSER( 9933): pkgmgr_parser.c: __check_theme(142) > theme for installation.
06-03 01:41:59.667+0900 E/PKGMGR_CERT( 9933): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
06-03 01:41:59.677+0900 E/PKGMGR_CERT( 9933): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 107
06-03 01:41:59.677+0900 E/PKGMGR_CERT( 9933): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 107
06-03 01:41:59.677+0900 E/PKGMGR_CERT( 9933): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 44 2
06-03 01:41:59.677+0900 E/PKGMGR_CERT( 9933): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 45 2
06-03 01:41:59.677+0900 E/PKGMGR_CERT( 9933): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 46 2
06-03 01:41:59.677+0900 E/PKGMGR_CERT( 9933): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 47 2
06-03 01:41:59.677+0900 E/PKGMGR_CERT( 9933): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
06-03 01:41:59.687+0900 E/rpm-installer( 9933): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1956) > skip! empty dirpath=[/opt/usr/apps/org.example.example/lib]
06-03 01:41:59.687+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: install_percent, val: 60
06-03 01:41:59.687+0900 I/Tizen::App( 1210): (119) > InstallationInProgress [60]
06-03 01:41:59.687+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [install_percent], Value = [60], install = [96]
06-03 01:41:59.687+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:41:59.687+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:41:59.687+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:41:59.687+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:41:59.707+0900 E/rpm-installer( 9933): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-03 01:41:59.737+0900 E/rpm-installer( 9933): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
06-03 01:41:59.737+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:41:59.737+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: install_percent, val: 100
06-03 01:41:59.737+0900 I/Tizen::App( 1210): (119) > InstallationInProgress [100]
06-03 01:41:59.737+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [install_percent], Value = [100], install = [96]
06-03 01:41:59.737+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:41:59.737+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:41:59.737+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:41:59.997+0900 E/PKGMGR_SERVER( 9922): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-03 01:42:00.478+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(195) > ""
06-03 01:42:00.478+0900 E/UXT     (  646): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 1:42
06-03 01:42:00.478+0900 I/INDICATOR(  646): clock.c: getTimeFormatted(176) > "time format : 오전 1:42"
06-03 01:42:00.478+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 1:42"
06-03 01:42:00.478+0900 W/INDICATOR(  646): clock.c: indicator_clock_changed_cb(272) > 
06-03 01:42:00.478+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146368031 Time: <font_size=31> </font_size> <font_size=31> 오전 1:42</font_size></font>"
06-03 01:42:01.178+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_low_memory(449) > _app_appcore_low_memory
06-03 01:42:01.178+0900 I/CAPI_APPFW_APPLICATION(15849): app_main.c: _ui_app_appcore_low_memory(449) > _app_appcore_low_memory
06-03 01:42:01.178+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: LOWMEM_POST State: PAUSED
06-03 01:42:01.178+0900 E/IV-APP  (15849): image-viewer.c: _low_memory(1878) > [_low_memory : 01878]_low_memory
06-03 01:42:01.178+0900 I/APP_CORE(15849): appcore-efl.c: __do_app(514) > [APP 15849] Event: LOWMEM_POST State: PAUSED
06-03 01:42:01.178+0900 I/CAPI_APPFW_APPLICATION( 9794): app_main.c: _ui_app_appcore_low_memory(449) > _app_appcore_low_memory
06-03 01:42:01.178+0900 I/APP_CORE( 9794): appcore-efl.c: __do_app(514) > [APP 9794] Event: LOWMEM_POST State: PAUSED
06-03 01:42:01.178+0900 W/IV-APPFW (15849): [15849] 27:36:33.256[F:Application.cpp  L:  769][00][HIGH] Image Viewer : on_event UG=0xb952b950
06-03 01:42:01.178+0900 W/IV-APPFW (15849): [15849] 27:36:33.256[F:Application.cpp  L:  773][00][HIGH] Get Event : Low Memory
06-03 01:42:01.178+0900 W/CAM_SERVICE( 1336): CamService.cpp: __memoryStatusChangedCb(161) > [33mmemoryStatus changed 2[0m
06-03 01:42:01.178+0900 I/CAPI_APPFW_APPLICATION(  859): app_main.c: _ui_app_appcore_low_memory(449) > _app_appcore_low_memory
06-03 01:42:01.178+0900 I/APP_CORE(  859): appcore-efl.c: __do_app(514) > [APP 859] Event: LOWMEM_POST State: PAUSED
06-03 01:42:01.178+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_low_memory(449) > _app_appcore_low_memory
06-03 01:42:01.178+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: LOWMEM_POST State: PAUSED
06-03 01:42:01.178+0900 I/CAPI_APPFW_APPLICATION( 9807): app_main.c: _ui_app_appcore_low_memory(449) > _app_appcore_low_memory
06-03 01:42:01.178+0900 I/APP_CORE( 9807): appcore-efl.c: __do_app(514) > [APP 9807] Event: LOWMEM_POST State: RUNNING
06-03 01:42:01.178+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_low_memory(449) > _app_appcore_low_memory
06-03 01:42:01.178+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: LOWMEM_POST State: PAUSED
06-03 01:42:01.178+0900 I/SYNCSERVICE(  945): SyncManager_SyncManager.cpp: OnStorageStatusChanged(351) > Storage status changed 2
06-03 01:42:01.178+0900 I/CAPI_APPFW_APPLICATION( 1210): app_main.c: app_appcore_low_memory(267) > app_appcore_low_memory
06-03 01:42:01.178+0900 I/APP_CORE( 1210): appcore-efl.c: __do_app(514) > [APP 1210] Event: LOWMEM_POST State: CREATED
06-03 01:42:01.178+0900 I/CAPI_APPFW_APPLICATION( 1863): service_app_main.c: _service_app_low_memory(164) > service_app_low_memory
06-03 01:42:01.178+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __on_low_memory(632) > widget_app_low_memory
06-03 01:42:01.178+0900 I/CAPI_APPFW_APPLICATION( 8743): app_main.c: _ui_app_appcore_low_memory(449) > _app_appcore_low_memory
06-03 01:42:01.178+0900 I/CAPI_APPFW_APPLICATION( 1358): app_main.c: _ui_app_appcore_low_memory(449) > _app_appcore_low_memory
06-03 01:42:01.178+0900 I/APP_CORE( 8743): appcore-efl.c: __do_app(514) > [APP 8743] Event: LOWMEM_POST State: PAUSED
06-03 01:42:01.178+0900 I/CAPI_APPFW_APPLICATION(  646): app_main.c: _ui_app_appcore_low_memory(449) > _app_appcore_low_memory
06-03 01:42:01.178+0900 I/APP_CORE(  646): appcore-efl.c: __do_app(514) > [APP 646] Event: LOWMEM_POST State: PAUSED
06-03 01:42:01.178+0900 I/APP_CORE( 1358): appcore-efl.c: __do_app(514) > [APP 1358] Event: LOWMEM_POST State: CREATED
06-03 01:42:01.188+0900 I/CAPI_APPFW_APPLICATION(27314): app_main.c: _ui_app_appcore_low_memory(449) > _app_appcore_low_memory
06-03 01:42:01.188+0900 I/APP_CORE(27314): appcore-efl.c: __do_app(514) > [APP 27314] Event: LOWMEM_POST State: PAUSED
06-03 01:42:01.709+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
06-03 01:42:01.709+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
06-03 01:42:01.709+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
06-03 01:42:01.709+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: end, val: ok
06-03 01:42:01.709+0900 I/Tizen::App( 1210): (78) > Installation is Completed. [Package = org.example.example]
06-03 01:42:01.709+0900 I/Tizen::App( 1210): (671) > Enter. package(org.example.example), installationResult(0)
06-03 01:42:01.709+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:42:01.709+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:42:01.709+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:42:01.709+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:42:01.729+0900 E/PKGMGR_SERVER( 9922): pkgmgr-server.c: sighandler(417) > child NORMAL exit [9933]
06-03 01:42:01.739+0900 W/ISF_PANEL_EFL(  768): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
06-03 01:42:01.739+0900 I/Tizen::App( 1210): (1360) > package(org.example.example), version(1.0.0), type(tpk), displayName(forpet), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.example), storeClient(), appRootPath(/opt/usr/apps/org.example.example)
06-03 01:42:01.749+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.example]
06-03 01:42:01.749+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.example]
06-03 01:42:01.749+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
06-03 01:42:01.749+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
06-03 01:42:01.749+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.example]
06-03 01:42:01.759+0900 I/Tizen::App( 1210): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.example]
06-03 01:42:01.769+0900 I/Tizen::App( 1210): (416) > appName = [example]
06-03 01:42:01.769+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[forpet] enable[1] system[0]
06-03 01:42:01.769+0900 E/HOME_APPS(  860): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.example] mdm is not enabled
06-03 01:42:01.769+0900 I/Tizen::App( 1210): (509) > exe = [/opt/usr/apps/org.example.example/bin/example], displayName = [forpet], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-03 01:42:01.779+0900 E/cluster-home(  860): mainmenu-data-manager.cpp: GetBoxDataByAppId(2539) >  cannot find box with appid[org.example.example]
06-03 01:42:01.779+0900 E/PKGMGR_INFO( 1210): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-03 01:42:01.779+0900 I/Tizen::App( 1210): (683) > Application count(1) in this package
06-03 01:42:01.779+0900 I/Tizen::App( 1210): (840) > Enter.
06-03 01:42:01.779+0900 I/Tizen::App( 1210): (703) > Exit.
06-03 01:42:01.779+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [end], Value = [ok], install = [96]
06-03 01:42:01.789+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[forpet] enable[1] system[0]
06-03 01:42:01.789+0900 I/Tizen::App( 1210): (416) > appName = [example]
06-03 01:42:01.789+0900 I/Tizen::App( 1210): (509) > exe = [/opt/usr/apps/org.example.example/bin/example], displayName = [forpet], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-03 01:42:01.789+0900 I/Tizen::App( 1210): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.example.info]
06-03 01:42:01.789+0900 I/Tizen::App( 1210): (131) > Enter
06-03 01:42:01.789+0900 I/Tizen::App( 1210): (137) > org.example.example does not have launch condition
06-03 01:42:01.789+0900 I/Tizen::App( 1210): (883) > Exit.
06-03 01:42:01.799+0900 E/util-view(  860): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-03 01:42:01.809+0900 E/util-view(  860): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-03 01:42:01.999+0900 E/PKGMGR_SERVER( 9922): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-03 01:42:01.999+0900 E/PKGMGR_SERVER( 9922): pkgmgr-server.c: main(2471) > package manager server terminated.
06-03 01:42:06.394+0900 W/AUL     ( 9988): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.example)
06-03 01:42:06.394+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
06-03 01:42:06.404+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-03 01:42:06.414+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-03 01:42:06.414+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-03 01:42:06.414+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 9988
06-03 01:42:06.414+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-03 01:42:06.424+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 9
06-03 01:42:06.424+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 01:42:06.424+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 01:42:06.424+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-03 01:42:06.424+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 01:42:06.444+0900 I/CAPI_APPFW_APPLICATION( 9825): app_main.c: ui_app_main(789) > app_efl_main
06-03 01:42:06.444+0900 I/CAPI_APPFW_APPLICATION( 9825): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 01:42:06.474+0900 E/TBM     ( 9825): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 01:42:06.524+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 9825, appid: org.example.example
06-03 01:42:06.524+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 01:42:06.524+0900 W/AUL     ( 9988): launch.c: app_request_to_launchpad(425) > request cmd(0) result(9825)
06-03 01:42:06.634+0900 I/APP_CORE( 9825): appcore-efl.c: __do_app(514) > [APP 9825] Event: RESET State: CREATED
06-03 01:42:06.634+0900 I/CAPI_APPFW_APPLICATION( 9825): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 01:42:06.634+0900 E/EFL     ( 9825): edje<9825> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:42:06.634+0900 E/EFL     ( 9825): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:42:06.634+0900 E/EFL     ( 9825): edje<9825> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:42:06.634+0900 E/EFL     ( 9825): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:42:06.634+0900 E/EFL     ( 9825): edje<9825> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:42:06.634+0900 E/EFL     ( 9825): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:42:06.634+0900 E/EFL     ( 9825): edje<9825> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:42:06.634+0900 E/EFL     ( 9825): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:42:06.634+0900 E/EFL     ( 9825): edje<9825> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:42:06.634+0900 E/EFL     ( 9825): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:42:06.674+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:42:06.674+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:42:06.694+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [org.tizen.] 
06-03 01:42:06.694+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:42:06.704+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:42:06.704+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:42:06.714+0900 W/APP_CORE( 9825): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:7200002
06-03 01:42:06.714+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 01:42:06.814+0900 I/APP_CORE( 9807): appcore-efl.c: __do_app(514) > [APP 9807] Event: PAUSE State: RUNNING
06-03 01:42:06.814+0900 I/CAPI_APPFW_APPLICATION( 9807): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 01:42:06.814+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 33
06-03 01:42:06.824+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(9807) status(4)
06-03 01:42:06.824+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.tizen.crash-viewer(9807)
06-03 01:42:06.824+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 9807, appid: org.tizen.crash-viewer, status: bg
06-03 01:42:06.824+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(9825) status(3)
06-03 01:42:06.824+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 01:42:06.824+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 01:42:06.824+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(9825)
06-03 01:42:06.824+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 9825, appid: org.example.example, status: fg
06-03 01:42:06.834+0900 W/CAM_SERVICE( 1336): CamService.cpp: __memoryStatusChangedCb(161) > [33mmemoryStatus changed 1[0m
06-03 01:42:06.834+0900 W/CAM_SERVICE( 1336): CamService.cpp: __launchCameraApp(86) > [33mBEGIN[0m
06-03 01:42:06.834+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
06-03 01:42:06.834+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 27314
06-03 01:42:06.834+0900 E/CAM_SERVICE( 1336): CamService.cpp: __launchCameraApp(94) > [31mcamera app is already running[0m
06-03 01:42:06.834+0900 I/SYNCSERVICE(  945): SyncManager_SyncManager.cpp: OnStorageStatusChanged(351) > Storage status changed 1
06-03 01:42:06.854+0900 I/APP_CORE( 9825): appcore-efl.c: __do_app(514) > [APP 9825] Event: RESUME State: CREATED
06-03 01:42:06.874+0900 I/APP_CORE( 9825): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 01:42:06.874+0900 I/APP_CORE( 9825): appcore-efl.c: __do_app(625) > [APP 9825] Initial Launching, call the resume_cb
06-03 01:42:06.874+0900 I/CAPI_APPFW_APPLICATION( 9825): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 01:42:07.184+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(9825) status(0)
06-03 01:42:07.575+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 01:42:07.575+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3459
06-03 01:42:07.585+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 9825.
06-03 01:42:08.375+0900 I/UXT     ( 9996): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-03 01:42:09.747+0900 E/EFL     ( 9825): ecore_x<9825> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=132309742
06-03 01:42:09.937+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 9825 pgid = 9825
06-03 01:42:09.937+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(143) > dead_pid(9825)
06-03 01:42:09.937+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:42:09.967+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 01:42:09.967+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 01:42:09.967+0900 E/AUL_PAD ( 1359): launchpad.c: main(698) > error reading sigchld info
06-03 01:42:09.977+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 9825
06-03 01:42:09.977+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[9825] terminate event is forwarded
06-03 01:42:09.977+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 01:42:09.977+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 9825, ]
06-03 01:42:09.977+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 01:42:09.977+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 01:42:09.977+0900 I/Tizen::App( 1210): (512) > Not registered pid(9825)
06-03 01:42:09.977+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 01:42:09.977+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:42:09.977+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 9825
06-03 01:42:09.977+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 9825
06-03 01:42:09.987+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3462
06-03 01:42:09.987+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(9807) status(3)
06-03 01:42:09.987+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 01:42:09.987+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 01:42:09.987+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.tizen.crash-viewer(9807)
06-03 01:42:09.987+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 9807, appid: org.tizen.crash-viewer, status: fg
06-03 01:42:09.997+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(9807) status(0)
06-03 01:42:09.997+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 01:42:10.007+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:42:10.007+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 9825.
06-03 01:42:10.017+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:42:10.017+0900 I/APP_CORE( 9807): appcore-efl.c: __do_app(514) > [APP 9807] Event: RESUME State: PAUSED
06-03 01:42:10.017+0900 I/CAPI_APPFW_APPLICATION( 9807): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 01:42:10.027+0900 I/Tizen::System( 1210): (259) > Active app [org.tizen.], current [org.exampl] 
06-03 01:42:10.027+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:42:10.047+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
06-03 01:42:10.047+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 01:42:10.057+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
06-03 01:42:10.057+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 01:42:10.057+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:42:10.067+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:42:10.067+0900 W/CRASH_MANAGER(10002): worker.c: worker_job(1199) > 1109825657861149642172
