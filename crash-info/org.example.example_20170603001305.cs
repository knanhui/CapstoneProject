S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: example
PID: 6663
Date: 2017-06-03 00:13:05+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 6663, uid 5000)

Register Information
r0   = 0x8000ca66, r1   = 0x372c3034
r2   = 0xb3f4b000, r3   = 0xb3f4b020
r4   = 0x8001b2da, r5   = 0xbef722a0
r6   = 0xb28349a5, r7   = 0xbef72128
r8   = 0x8001b2da, r9   = 0xb5f2d708
r10  = 0xb872ea98, fp   = 0xbef7227c
ip   = 0xb601d120, sp   = 0xbef720e8
lr   = 0xb5fe1bd9, pc   = 0xb28349ce
cpsr = 0x800f0030

Memory Information
MemTotal:   987012 KB
MemFree:     45440 KB
Buffers:     14060 KB
Cached:     115492 KB
VmPeak:     110064 KB
VmSize:     108572 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24176 KB
VmRSS:       24176 KB
VmData:      34504 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35728 KB
VmPTE:          82 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 6663 TID = 6663
6663 6669 6708 6709 

Maps Information
b132f000 b1b2e000 rw-p [stack:6709]
b1baa000 b1bb2000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1bc3000 b1bc4000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bd4000 b1be8000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bfc000 b1bfd000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c0d000 b1c10000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c21000 b1c22000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c32000 b1c34000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c44000 b1c46000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c56000 b1c66000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c76000 b1c82000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c94000 b2493000 rw-p [stack:6708]
b27c4000 b27cb000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27dc000 b27e4000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b27f4000 b2809000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b281b000 b2821000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2831000 b2839000 r-xp /opt/usr/apps/org.example.example/bin/example
b2991000 b2a74000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2aab000 b2ad3000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ae5000 b32e4000 rw-p [stack:6669]
b32e4000 b32e6000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32f6000 b3300000 r-xp /lib/libnss_files-2.20-2014.11.so
b3311000 b331a000 r-xp /lib/libnss_nis-2.20-2014.11.so
b332b000 b333c000 r-xp /lib/libnsl-2.20-2014.11.so
b334f000 b3355000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3366000 b3367000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b338f000 b3396000 r-xp /usr/lib/libminizip.so.1.0.0
b33a6000 b33ab000 r-xp /usr/lib/libstorage.so.0.1
b33bb000 b341a000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3430000 b3444000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3454000 b3498000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34a8000 b34b0000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34c0000 b34f0000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3503000 b35bc000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35d0000 b3623000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3634000 b364f000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b365f000 b3720000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3733000 b3743000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3753000 b3760000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3771000 b3778000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3788000 b37c9000 r-xp /usr/lib/libmdm.so.1.2.12
b37d9000 b37e1000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37f0000 b3800000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3821000 b3881000 r-xp /usr/lib/libasound.so.2.0.0
b3893000 b3896000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38a6000 b38a9000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38b9000 b38be000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38ce000 b38cf000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38df000 b38ea000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38fe000 b3905000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3915000 b391b000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b392b000 b3930000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3940000 b395b000 r-xp /usr/lib/libmmfsound.so.0.1.0
b396b000 b3972000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3982000 b3985000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3996000 b39c4000 r-xp /usr/lib/libidn.so.11.5.44
b39d4000 b39ea000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39fb000 b3a05000 r-xp /usr/lib/libcares.so.2.1.0
b3a15000 b3a1f000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a2f000 b3a31000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a41000 b3a42000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a52000 b3a56000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a67000 b3a8f000 r-xp /usr/lib/libui-extension.so.0.1.0
b3aa0000 b3ac9000 r-xp /usr/lib/libturbojpeg.so
b3ae9000 b3aef000 r-xp /usr/lib/libgif.so.4.1.6
b3aff000 b3b45000 r-xp /usr/lib/libcurl.so.4.3.0
b3b56000 b3b77000 r-xp /usr/lib/libexif.so.12.3.3
b3b92000 b3ba7000 r-xp /usr/lib/libtts.so
b3bb8000 b3bc0000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bd0000 b3c96000 r-xp /usr/lib/libdali-core.so.0.0.0
b3cb6000 b3dae000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3dcd000 b3e9b000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3eb2000 b3eb4000 r-xp /usr/lib/libboost_system.so.1.51.0
b3ec4000 b3eca000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3eda000 b3efd000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f0e000 b3f10000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f20000 b3f22000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f33000 b3f38000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f4f000 b3f51000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f61000 b3f68000 r-xp /usr/lib/libsensord-share.so
b3f78000 b3f90000 r-xp /usr/lib/libsensor.so.1.1.0
b3fa1000 b3fa4000 r-xp /usr/lib/libXv.so.1.0.0
b3fb4000 b3fb9000 r-xp /usr/lib/libutilX.so.1.1.0
b3fc9000 b3fce000 r-xp /usr/lib/libappcore-common.so.1.1
b3fde000 b3fe5000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3ff8000 b3ffc000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b400d000 b40eb000 r-xp /usr/lib/libCOREGL.so.4.0
b410b000 b410e000 r-xp /usr/lib/libuuid.so.1.3.0
b411e000 b4135000 r-xp /usr/lib/libblkid.so.1.1.0
b4146000 b4148000 r-xp /usr/lib/libXau.so.6.0.0
b4158000 b419f000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41b1000 b41b7000 r-xp /usr/lib/libjson-c.so.2.0.1
b41c8000 b41cc000 r-xp /usr/lib/libogg.so.0.7.1
b41dc000 b41fe000 r-xp /usr/lib/libvorbis.so.0.4.3
b420e000 b42f2000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b430e000 b4311000 r-xp /usr/lib/libEGL.so.1.4
b4322000 b4328000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4338000 b433a000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b434a000 b4357000 r-xp /usr/lib/libGLESv2.so.2.0
b4368000 b43ca000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43df000 b43f7000 r-xp /usr/lib/libmount.so.1.1.0
b4409000 b441d000 r-xp /usr/lib/libxcb.so.1.1.0
b442d000 b4434000 r-xp /lib/libcrypt-2.20-2014.11.so
b446c000 b446e000 r-xp /usr/lib/libiri.so
b447e000 b4489000 r-xp /usr/lib/libgpg-error.so.0.15.0
b449a000 b44d0000 r-xp /usr/lib/libpulse.so.0.16.2
b44e1000 b4524000 r-xp /usr/lib/libsndfile.so.1.0.25
b4539000 b454e000 r-xp /lib/libexpat.so.1.5.2
b4560000 b461e000 r-xp /usr/lib/libcairo.so.2.11200.14
b4632000 b463a000 r-xp /usr/lib/libdrm.so.2.4.0
b464a000 b464d000 r-xp /usr/lib/libdri2.so.0.0.0
b465d000 b46ab000 r-xp /usr/lib/libssl.so.1.0.0
b46c0000 b46cc000 r-xp /usr/lib/libeeze.so.1.13.0
b46dd000 b46e6000 r-xp /usr/lib/libethumb.so.1.13.0
b46f6000 b46f9000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4709000 b48c0000 r-xp /usr/lib/libcrypto.so.1.0.0
b56ab000 b56b4000 r-xp /usr/lib/libXi.so.6.1.0
b56c4000 b56c6000 r-xp /usr/lib/libXgesture.so.7.0.0
b56d6000 b56da000 r-xp /usr/lib/libXtst.so.6.1.0
b56ea000 b56f0000 r-xp /usr/lib/libXrender.so.1.3.0
b5700000 b5706000 r-xp /usr/lib/libXrandr.so.2.2.0
b5716000 b5718000 r-xp /usr/lib/libXinerama.so.1.0.0
b5729000 b572c000 r-xp /usr/lib/libXfixes.so.3.1.0
b573c000 b5747000 r-xp /usr/lib/libXext.so.6.4.0
b5757000 b5759000 r-xp /usr/lib/libXdamage.so.1.1.0
b5769000 b576b000 r-xp /usr/lib/libXcomposite.so.1.0.0
b577b000 b585d000 r-xp /usr/lib/libX11.so.6.3.0
b5871000 b5878000 r-xp /usr/lib/libXcursor.so.1.0.2
b5888000 b58a0000 r-xp /usr/lib/libudev.so.1.6.0
b58a2000 b58a5000 r-xp /lib/libattr.so.1.1.0
b58b5000 b58d5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58d6000 b58db000 r-xp /usr/lib/libffi.so.6.0.2
b58ec000 b5904000 r-xp /lib/libz.so.1.2.8
b5914000 b5916000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5926000 b59fb000 r-xp /usr/lib/libxml2.so.2.9.2
b5a10000 b5aab000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ac7000 b5aca000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ada000 b5af3000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b04000 b5b15000 r-xp /lib/libresolv-2.20-2014.11.so
b5b29000 b5ba3000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bb8000 b5bba000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bca000 b5bd1000 r-xp /usr/lib/libembryo.so.1.13.0
b5be1000 b5beb000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bfc000 b5c14000 r-xp /usr/lib/libpng12.so.0.50.0
b5c25000 b5c48000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c69000 b5c7d000 r-xp /usr/lib/libector.so.1.13.0
b5c8e000 b5ca6000 r-xp /usr/lib/liblua-5.1.so
b5cb7000 b5d0e000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d22000 b5d4a000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d5b000 b5d6e000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d7f000 b5db9000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5dca000 b5dd8000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5de8000 b5df0000 r-xp /usr/lib/libtbm.so.1.0.0
b5e00000 b5e0d000 r-xp /usr/lib/libeio.so.1.13.0
b5e1d000 b5e1f000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e2f000 b5e34000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e44000 b5e5b000 r-xp /usr/lib/libefreet.so.1.13.0
b5e6d000 b5e8d000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e9d000 b5ebd000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ebf000 b5ec5000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ed5000 b5ee6000 r-xp /usr/lib/libemotion.so.1.13.0
b5ef7000 b5efe000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f0e000 b5f1d000 r-xp /usr/lib/libeo.so.1.13.0
b5f2e000 b5f40000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f51000 b5f56000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f66000 b5f7f000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f8f000 b5fac000 r-xp /usr/lib/libeet.so.1.13.0
b5fc5000 b600d000 r-xp /usr/lib/libeina.so.1.13.0
b601e000 b602e000 r-xp /usr/lib/libefl.so.1.13.0
b603f000 b6124000 r-xp /usr/lib/libicuuc.so.51.1
b6141000 b6281000 r-xp /usr/lib/libicui18n.so.51.1
b6298000 b62d0000 r-xp /usr/lib/libecore_x.so.1.13.0
b62e2000 b62e5000 r-xp /lib/libcap.so.2.21
b62f5000 b631e000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b632f000 b6336000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6348000 b637f000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6390000 b647b000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b648e000 b6507000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6519000 b651e000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b652e000 b6538000 r-xp /usr/lib/libvconf.so.0.2.45
b6548000 b654a000 r-xp /usr/lib/libvasum.so.0.3.1
b655a000 b655c000 r-xp /usr/lib/libttrace.so.1.1
b656c000 b656f000 r-xp /usr/lib/libiniparser.so.0
b657f000 b65a5000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65b5000 b65ba000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65cb000 b65e2000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65f3000 b665e000 r-xp /lib/libm-2.20-2014.11.so
b666f000 b6675000 r-xp /lib/librt-2.20-2014.11.so
b6686000 b6693000 r-xp /usr/lib/libunwind.so.8.0.1
b66c9000 b67ed000 r-xp /lib/libc-2.20-2014.11.so
b6802000 b681b000 r-xp /lib/libgcc_s-4.9.so.1
b682b000 b690d000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b691e000 b6948000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6959000 b6995000 r-xp /usr/lib/libsystemd.so.0.4.0
b6997000 b6a1a000 r-xp /usr/lib/libedje.so.1.13.0
b6a2d000 b6a4b000 r-xp /usr/lib/libecore.so.1.13.0
b6a6b000 b6bf2000 r-xp /usr/lib/libevas.so.1.13.0
b6c27000 b6c3b000 r-xp /lib/libpthread-2.20-2014.11.so
b6c4f000 b6e83000 r-xp /usr/lib/libelementary.so.1.13.0
b6eb2000 b6eb6000 r-xp /usr/lib/libsmack.so.1.0.0
b6ec6000 b6ecd000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6edd000 b6edf000 r-xp /usr/lib/libdlog.so.0.0.0
b6eef000 b6ef2000 r-xp /usr/lib/libbundle.so.0.1.22
b6f02000 b6f04000 r-xp /lib/libdl-2.20-2014.11.so
b6f15000 b6f2d000 r-xp /usr/lib/libaul.so.0.1.0
b6f41000 b6f46000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f57000 b6f64000 r-xp /usr/lib/liblptcp.so
b6f76000 b6f7a000 r-xp /usr/lib/libsys-assert.so
b6f8b000 b6fab000 r-xp /lib/ld-2.20-2014.11.so
b6fbc000 b6fc1000 r-xp /usr/bin/launchpad-loader
b84cb000 b8784000 rw-p [heap]
bef52000 bef73000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6663)
Call Stack Count: 18
 0: feeding_view_cb + 0x29 (0xb28349ce) [/opt/usr/apps/org.example.example/bin/example] + 0x39ce
 1: (0xb6aa0175) [/usr/lib/libevas.so.1] + 0x35175
 2: (0xb5f19219) [/usr/lib/libeo.so.1] + 0xb219
 3: eo_event_callback_call + 0x68 (0xb5f17fb9) [/usr/lib/libeo.so.1] + 0x9fb9
 4: (0xb6aa0515) [/usr/lib/libevas.so.1] + 0x35515
 5: (0xb6aa8725) [/usr/lib/libevas.so.1] + 0x3d725
 6: evas_canvas_event_feed_mouse_down + 0x6a (0xb6aadf6b) [/usr/lib/libevas.so.1] + 0x42f6b
 7: evas_event_feed_mouse_down + 0x30 (0xb6ab1939) [/usr/lib/libevas.so.1] + 0x46939
 8: (0xb46f8173) [/usr/lib/libecore_input_evas.so.1] + 0x2173
 9: (0xb6a38c4b) [/usr/lib/libecore.so.1] + 0xbc4b
10: (0xb6a3ea5d) [/usr/lib/libecore.so.1] + 0x11a5d
11: ecore_main_loop_begin + 0x3e (0xb6a3ec83) [/usr/lib/libecore.so.1] + 0x11c83
12: appcore_efl_main + 0x20c (0xb6f442bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
13: ui_app_main + 0xc0 (0xb3ffa909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
14: main + 0x10e (0xb2836673) [/opt/usr/apps/org.example.example/bin/example] + 0x5673
15: (0xb6fbdbb5) [/opt/usr/apps/org.example.example/bin/example] + 0x1bb5
16: __libc_start_main + 0x114 (0xb66df4bc) [/lib/libc.so.6] + 0x164bc
17: (0xb6fbdeb4) [/opt/usr/apps/org.example.example/bin/example] + 0x1eb4
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
: amd_request.c: __request_handler(906) > __request_handler: 1
06-03 00:12:57.455+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 860
06-03 00:12:57.465+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 8
06-03 00:12:57.465+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:12:57.475+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 00:12:57.475+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-03 00:12:57.475+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 00:12:57.495+0900 I/CAPI_APPFW_APPLICATION( 6622): app_main.c: ui_app_main(789) > app_efl_main
06-03 00:12:57.495+0900 I/CAPI_APPFW_APPLICATION( 6622): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 00:12:57.535+0900 E/TBM     ( 6622): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 00:12:57.575+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 6622, appid: org.example.example
06-03 00:12:57.575+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 00:12:57.585+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(6622)
06-03 00:12:57.725+0900 I/APP_CORE( 6622): appcore-efl.c: __do_app(514) > [APP 6622] Event: RESET State: CREATED
06-03 00:12:57.725+0900 I/CAPI_APPFW_APPLICATION( 6622): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 00:12:57.725+0900 E/EFL     ( 6622): edje<6622> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:12:57.725+0900 E/EFL     ( 6622): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:12:57.725+0900 E/EFL     ( 6622): edje<6622> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:12:57.725+0900 E/EFL     ( 6622): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:12:57.725+0900 E/EFL     ( 6622): edje<6622> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:12:57.725+0900 E/EFL     ( 6622): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:12:57.725+0900 E/EFL     ( 6622): edje<6622> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:12:57.725+0900 E/EFL     ( 6622): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:12:57.725+0900 E/EFL     ( 6622): edje<6622> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:12:57.725+0900 E/EFL     ( 6622): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:12:57.765+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:12:57.765+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:12:57.815+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:12:57.815+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:12:57.825+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:12:57.835+0900 W/APP_CORE( 6622): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:8a00002
06-03 00:12:57.835+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 00:12:57.855+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:12:57.956+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
06-03 00:12:57.956+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:12:57.956+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
06-03 00:12:57.966+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
06-03 00:12:57.966+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
06-03 00:12:57.966+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
06-03 00:12:57.966+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(6622) status(3)
06-03 00:12:57.966+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(6622)
06-03 00:12:57.966+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 6622, appid: org.example.example, status: fg
06-03 00:12:57.976+0900 W/LFE      (15849): [15849] 26:07:30.049[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:12:57.996+0900 I/APP_CORE( 6622): appcore-efl.c: __do_app(514) > [APP 6622] Event: RESUME State: CREATED
06-03 00:12:58.006+0900 I/APP_CORE( 6622): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 00:12:58.006+0900 I/APP_CORE( 6622): appcore-efl.c: __do_app(625) > [APP 6622] Initial Launching, call the resume_cb
06-03 00:12:58.006+0900 I/CAPI_APPFW_APPLICATION( 6622): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:12:58.316+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(6622) status(0)
06-03 00:12:58.616+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3160
06-03 00:12:58.616+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 00:12:58.616+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 6622.
06-03 00:12:58.706+0900 E/EFL     ( 6622): ecore_x<6622> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=126958706
06-03 00:12:58.886+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 6622 pgid = 6622
06-03 00:12:58.886+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(143) > dead_pid(6622)
06-03 00:12:58.886+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:12:58.896+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 00:12:58.896+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:12:58.896+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:12:58.896+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 00:12:58.896+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 00:12:58.957+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 00:12:58.957+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 00:12:58.957+0900 E/AUL_PAD ( 1359): launchpad.c: main(698) > error reading sigchld info
06-03 00:12:58.957+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 6622
06-03 00:12:58.957+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 6622
06-03 00:12:58.957+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[6622] terminate event is forwarded
06-03 00:12:58.957+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:12:58.957+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 6622, ]
06-03 00:12:58.957+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:12:58.957+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 00:12:58.957+0900 I/Tizen::App( 1210): (512) > Not registered pid(6622)
06-03 00:12:58.957+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 00:12:58.957+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:12:58.957+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3161
06-03 00:12:58.967+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 00:12:58.967+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 00:12:58.977+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 6622
06-03 00:12:58.977+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 00:12:58.977+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:12:58.977+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 00:12:58.987+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:12:58.987+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 6622.
06-03 00:12:58.987+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:12:59.027+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 00:12:59.027+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:12:59.027+0900 I/CAPI_WIDGET_APPLICATION( 1320): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 00:12:59.027+0900 I/CAPI_WIDGET_APPLICATION( 1320): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 00:12:59.027+0900 W/AUL     ( 1320): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1320, appid: live-com.samsung.browser, status: fg
06-03 00:12:59.047+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:12:59.047+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:12:59.047+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:12:59.067+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
06-03 00:12:59.067+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 00:12:59.077+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
06-03 00:12:59.077+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 00:12:59.077+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:12:59.477+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3162
06-03 00:12:59.857+0900 I/UXT     ( 6663): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-03 00:13:00.008+0900 I/Tizen::Net::Wifi( 1210): (941) > The background scan result updated.
06-03 00:13:00.028+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:13:00.038+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:00.048+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:13:00.048+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:00.068+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:13:00.068+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:00.088+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:13:00.088+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:00.108+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:13:00.108+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:00.108+0900 W/CRASH_MANAGER( 6635): worker.c: worker_job(1199) > 11066226578611496416378
06-03 00:13:00.128+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:13:00.128+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:00.138+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:13:00.148+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:00.158+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:13:00.168+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:00.178+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:13:00.178+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:00.188+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:13:00.188+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:00.198+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:13:00.198+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:00.218+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:13:00.218+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:00.238+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:13:00.238+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:00.468+0900 W/LFE      (15849): [15849] 26:07:32.548[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:13:00.598+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=126960604
06-03 00:13:00.598+0900 E/cluster-view(  860): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Down]Event!! 
06-03 00:13:00.598+0900 W/STARTER (  793): hw_key.c: _key_press_cb(758) > [_key_press_cb:758] Home Key is pressed
06-03 00:13:00.598+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=126960604
06-03 00:13:00.598+0900 W/STARTER (  793): hw_key.c: _key_press_cb(776) > [_key_press_cb:776] homekey count : 1
06-03 00:13:00.778+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(195) > ""
06-03 00:13:00.778+0900 E/UXT     (  646): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 12:13
06-03 00:13:00.778+0900 I/INDICATOR(  646): clock.c: getTimeFormatted(176) > "time format : 오전 12:13"
06-03 00:13:00.778+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 12:13"
06-03 00:13:00.778+0900 W/INDICATOR(  646): clock.c: indicator_clock_changed_cb(272) > 
06-03 00:13:00.778+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146038452 Time: <font_size=31> </font_size> <font_size=31> 오전 12:13</font_size></font>"
06-03 00:13:00.808+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=126960808
06-03 00:13:00.808+0900 E/cluster-view(  860): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Up]Event!! 
06-03 00:13:00.808+0900 W/STARTER (  793): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
06-03 00:13:00.808+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=126960808
06-03 00:13:00.808+0900 W/cluster-home(  860): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-03 00:13:00.808+0900 W/cluster-home(  860): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
06-03 00:13:00.808+0900 E/STARTER (  793): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-03 00:13:00.808+0900 E/STARTER (  793): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-03 00:13:00.808+0900 E/STARTER (  793): )
06-03 00:13:00.818+0900 I/SYSPOPUP(  858): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-03 00:13:00.818+0900 I/SYSPOPUP(  858): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-03 00:13:00.818+0900 E/VOLUME  (  858): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-03 00:13:00.818+0900 E/VOLUME  (  858): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-03 00:13:00.828+0900 I/CAPI_WIDGET_APPLICATION( 1320): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 00:13:00.828+0900 I/CAPI_WIDGET_APPLICATION( 1320): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 00:13:00.828+0900 W/AUL     ( 1320): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1320, appid: live-com.samsung.browser, status: bg
06-03 00:13:00.948+0900 W/cluster-home(  860): cluster-data-provider.cpp: OnMainScrollCompleted(4747) >  Main Scroll Completed
06-03 00:13:00.948+0900 W/cluster-home(  860): cluster-data-provider.cpp: OnMainScrollCompleted(4750) >  Main Scroll Completed Done
06-03 00:13:00.978+0900 I/CAPI_WIDGET_APPLICATION( 1320): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 00:13:00.978+0900 I/CAPI_WIDGET_APPLICATION( 1320): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 00:13:00.978+0900 W/AUL     ( 1320): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1320, appid: live-com.samsung.browser, status: fg
06-03 00:13:00.999+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:13:00.999+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:01.019+0900 W/STARTER (  793): hw_key.c: _homekey_timer_cb(479) > [_homekey_timer_cb:479] _homekey_timer_cb, homekey count[1], lock state[0]
06-03 00:13:01.029+0900 E/STARTER (  793): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-03 00:13:01.029+0900 E/STARTER (  793): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-03 00:13:01.029+0900 E/STARTER (  793): )
06-03 00:13:01.029+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
06-03 00:13:01.029+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 860
06-03 00:13:01.049+0900 W/AUL     (  793): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.homescreen)
06-03 00:13:01.049+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
06-03 00:13:01.059+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
06-03 00:13:01.059+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-03 00:13:01.059+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 793
06-03 00:13:01.059+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-03 00:13:01.069+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 860, appid: com.samsung.homescreen
06-03 00:13:01.069+0900 W/AUL_AMD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 0, pid: 860
06-03 00:13:01.069+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESET State: RUNNING
06-03 00:13:01.069+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 00:13:01.069+0900 W/AUL_AMD (  610): amd_request.c: __send_home_launch_signal(577) > send a home launch signal
06-03 00:13:01.069+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(81) , send fd(80), pid(860), cmd(0)
06-03 00:13:01.069+0900 W/AUL     (  793): launch.c: app_request_to_launchpad(425) > request cmd(0) result(860)
06-03 00:13:01.069+0900 E/STARTER (  793): dbus-util.c: starter_dbus_home_raise_signal_send(219) > [starter_dbus_home_raise_signal_send:219] Sending HOME RAISE signal, result:0
06-03 00:13:01.069+0900 W/CAPI_APPFW_APP_CONTROL(  860): app_control.c: app_control_error(152) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-03 00:13:01.089+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(564) > Legacy lifecycle: 0
06-03 00:13:01.089+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(566) > [APP 860] App already running, raise the window
06-03 00:13:01.129+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 00:13:01.139+0900 I/CAPI_WIDGET_APPLICATION( 1320): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 00:13:01.139+0900 I/CAPI_WIDGET_APPLICATION( 1320): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 00:13:01.139+0900 W/AUL     ( 1320): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1320, appid: live-com.samsung.browser, status: bg
06-03 00:13:01.139+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:13:01.139+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:13:01.139+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:13:01.139+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:13:01.139+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:13:01.149+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:13:01.159+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:13:01.159+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 00:13:01.159+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 00:13:01.159+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 00:13:01.159+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 00:13:01.219+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:13:01.229+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:01.979+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:13:01.979+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:01.999+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:13:01.999+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:02.020+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:13:02.020+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:02.040+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:13:02.040+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:02.050+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:13:02.060+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:02.070+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:13:02.070+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
06-03 00:13:02.070+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:13:02.080+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:02.090+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:13:02.090+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:02.110+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:13:02.110+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:02.130+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:13:02.130+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:02.150+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:13:02.150+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:02.160+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:13:02.170+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:02.180+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:13:02.190+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:02.570+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=126962573
06-03 00:13:02.610+0900 W/cluster-home(  860): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-03 00:13:02.610+0900 W/cluster-home(  860): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
06-03 00:13:02.630+0900 E/weather-widget( 1360): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-03 00:13:02.630+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 00:13:02.630+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 00:13:02.630+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: bg
06-03 00:13:02.700+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=126962704
06-03 00:13:02.980+0900 W/LFE      (15849): [15849] 26:07:35.056[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:13:03.541+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=126963540
06-03 00:13:03.631+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=126963639
06-03 00:13:03.641+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.example)
06-03 00:13:03.641+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
06-03 00:13:03.641+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 860
06-03 00:13:03.651+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 8
06-03 00:13:03.651+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:13:03.661+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 00:13:03.661+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-03 00:13:03.661+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 00:13:03.681+0900 I/CAPI_APPFW_APPLICATION( 6663): app_main.c: ui_app_main(789) > app_efl_main
06-03 00:13:03.681+0900 I/CAPI_APPFW_APPLICATION( 6663): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 00:13:03.711+0900 E/TBM     ( 6663): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 00:13:03.761+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 6663, appid: org.example.example
06-03 00:13:03.761+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 00:13:03.761+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(6663)
06-03 00:13:03.881+0900 I/APP_CORE( 6663): appcore-efl.c: __do_app(514) > [APP 6663] Event: RESET State: CREATED
06-03 00:13:03.881+0900 I/CAPI_APPFW_APPLICATION( 6663): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 00:13:03.881+0900 E/EFL     ( 6663): edje<6663> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:13:03.881+0900 E/EFL     ( 6663): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:13:03.891+0900 E/EFL     ( 6663): edje<6663> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:13:03.891+0900 E/EFL     ( 6663): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:13:03.891+0900 E/EFL     ( 6663): edje<6663> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:13:03.891+0900 E/EFL     ( 6663): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:13:03.891+0900 E/EFL     ( 6663): edje<6663> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:13:03.891+0900 E/EFL     ( 6663): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:13:03.891+0900 E/EFL     ( 6663): edje<6663> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:13:03.891+0900 E/EFL     ( 6663): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:13:03.921+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:13:03.921+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:13:03.941+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:13:03.941+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:13:03.941+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:13:03.951+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:13:03.981+0900 W/APP_CORE( 6663): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:8a00002
06-03 00:13:03.981+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 00:13:04.082+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
06-03 00:13:04.082+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:13:04.082+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
06-03 00:13:04.082+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
06-03 00:13:04.082+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
06-03 00:13:04.082+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
06-03 00:13:04.092+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(6663) status(3)
06-03 00:13:04.092+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(6663)
06-03 00:13:04.092+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 6663, appid: org.example.example, status: fg
06-03 00:13:04.132+0900 I/APP_CORE( 6663): appcore-efl.c: __do_app(514) > [APP 6663] Event: RESUME State: CREATED
06-03 00:13:04.142+0900 I/APP_CORE( 6663): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 00:13:04.142+0900 I/APP_CORE( 6663): appcore-efl.c: __do_app(625) > [APP 6663] Initial Launching, call the resume_cb
06-03 00:13:04.142+0900 I/CAPI_APPFW_APPLICATION( 6663): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:13:04.452+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(6663) status(0)
06-03 00:13:04.802+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 00:13:04.802+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 6663.
06-03 00:13:05.283+0900 E/EFL     ( 6663): ecore_x<6663> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=126965278
06-03 00:13:05.453+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 6663 pgid = 6663
06-03 00:13:05.453+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(143) > dead_pid(6663)
06-03 00:13:05.453+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:13:05.463+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 00:13:05.463+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:13:05.463+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:13:05.463+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 00:13:05.463+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 00:13:05.473+0900 W/LFE      (15849): [15849] 26:07:37.550[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:13:05.523+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 00:13:05.523+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 00:13:05.523+0900 E/AUL_PAD ( 1359): launchpad.c: main(698) > error reading sigchld info
06-03 00:13:05.523+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[6663] terminate event is forwarded
06-03 00:13:05.523+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:13:05.523+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 6663, ]
06-03 00:13:05.523+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:13:05.523+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 00:13:05.523+0900 I/Tizen::App( 1210): (512) > Not registered pid(6663)
06-03 00:13:05.523+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 00:13:05.523+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:13:05.533+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 6663
06-03 00:13:05.533+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 6663
06-03 00:13:05.533+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 6663
06-03 00:13:05.533+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3167
06-03 00:13:05.543+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 00:13:05.543+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:13:05.543+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 00:13:05.543+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:13:05.553+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 00:13:05.563+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 00:13:05.563+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 00:13:05.583+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:13:05.583+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:13:05.583+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:13:05.583+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:13:05.583+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:13:05.583+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
06-03 00:13:05.583+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 00:13:05.583+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
06-03 00:13:05.583+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 00:13:05.593+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:13:05.593+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:13:05.603+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:13:05.603+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 00:13:05.603+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 00:13:05.603+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 00:13:05.603+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 00:13:05.613+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:13:05.613+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 6663.
06-03 00:13:05.633+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 00:13:05.633+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:13:05.653+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:13:05.733+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:13:05.733+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:05.983+0900 I/UXT     ( 6712): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-03 00:13:07.685+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=126967688
06-03 00:13:07.685+0900 E/cluster-view(  860): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86PowerOff]Key [Down]Event!! 
06-03 00:13:07.835+0900 E/GAME    ( 2577): .\..\src\TizenImpl.c: device_display_changed_cb(80) > device_display_changed_cb: state change to 2
06-03 00:13:07.835+0900 E/VOLUME  (  858): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-03 00:13:07.835+0900 E/VOLUME  (  858): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-03 00:13:07.835+0900 I/Internet(27388): main.cpp: __display_changed_cb(1445) > 3, 0x2, 0xbe8305a0
06-03 00:13:07.835+0900 I/Internet(27388): main.cpp: __display_changed_cb(1462) > DISPLAY_STATE_SCREEN state : [2]
06-03 00:13:07.835+0900 I/CAPI_NETWORK_CONNECTION(27388): connection.c: connection_get_type(463) > Connected Network = 0
06-03 00:13:07.845+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=126967826
06-03 00:13:07.845+0900 E/weather-widget( 1360): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-03 00:13:07.845+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 00:13:07.845+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 00:13:07.845+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: bg
06-03 00:13:07.855+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(168) > [_dbus_message_recv_cb:168:W] PRE_LCD_OFF cause[powerkey] (status:3)
06-03 00:13:07.855+0900 W/LOCKSCREEN(  845): event.c: _lcd_off_cb(64) > [_lcd_off_cb:64:W] Dbus LCD off:powerkey
06-03 00:13:07.855+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30000:LCD_WILL_OFF
06-03 00:13:07.855+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:30000 event_info:0
06-03 00:13:07.855+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:3
06-03 00:13:07.855+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] HIDE => WILL RESUME
06-03 00:13:07.855+0900 W/APP_CORE(  860): appcore-efl.c: __cmsg_cb(1038) > LCD Off. Pause the topmost app
06-03 00:13:07.855+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
06-03 00:13:07.855+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:13:07.865+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
06-03 00:13:07.865+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:13:07.865+0900 E/LOCKSCREEN(  845): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
06-03 00:13:07.865+0900 E/LOCKSCREEN(  845): util-daemon.c: _lock_state_timer_cb(62) > [_lock_state_timer_cb:62:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LAUNCHING_LOCK ##########
06-03 00:13:07.865+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:5
06-03 00:13:07.865+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => WILL PAUSE
06-03 00:13:07.865+0900 W/INDICATOR(  646): main.c: _indicator_lock_status_cb(418) > LockState is Lock, but Lockscreen invisible state
06-03 00:13:07.865+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
06-03 00:13:07.875+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
06-03 00:13:07.875+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 845
06-03 00:13:07.875+0900 I/AUL_AMD (  610): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
06-03 00:13:07.885+0900 W/AUL_AMD (  610): amd_launch.c: start_process(638) > child process: 6725
06-03 00:13:07.905+0900 W/UI_GADGET(27388): manager.c: ugman_pause(1092) > [34mugman_pause failed: no root[0m
06-03 00:13:07.925+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:13:07.935+0900 W/AUL_AMD (  610): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 6725
06-03 00:13:07.935+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 6725, appid: com.samsung.weather-m-agent
06-03 00:13:07.945+0900 I/Tizen::App( 1210): (499) > LaunchedApp(com.samsung.weather-m-agent)
06-03 00:13:07.945+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 6725.
06-03 00:13:07.945+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(425) > request cmd(0) result(6725)
06-03 00:13:07.955+0900 W/CRASH_MANAGER( 6635): worker.c: worker_job(1199) > 1106663657861149641638
