S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: example
PID: 7097
Date: 2017-06-03 00:20:54+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 7097, uid 5000)

Register Information
r0   = 0x8000ca66, r1   = 0x372c3034
r2   = 0xb3ee9000, r3   = 0xb3ee9020
r4   = 0x8001b6dc, r5   = 0xbeef72a0
r6   = 0xb27d4e5d, r7   = 0xbeef7128
r8   = 0x8001b6dc, r9   = 0xb5ecb708
r10  = 0xb7281970, fp   = 0xbeef727c
ip   = 0xb5fbb120, sp   = 0xbeef70e8
lr   = 0xb5f7fbd9, pc   = 0xb27d4e86
cpsr = 0x800f0030

Memory Information
MemTotal:   987012 KB
MemFree:     42064 KB
Buffers:     15520 KB
Cached:     114116 KB
VmPeak:     121924 KB
VmSize:     114636 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       29144 KB
VmRSS:       25844 KB
VmData:      36924 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35728 KB
VmPTE:          90 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 7097 TID = 7097
7097 7099 7149 7150 

Maps Information
b12cd000 b1acc000 rw-p [stack:7150]
b1b48000 b1b50000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1b61000 b1b62000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b72000 b1b86000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b9a000 b1b9b000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bab000 b1bae000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1bbf000 b1bc0000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1bd0000 b1bd2000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1be2000 b1be4000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1bf4000 b1c04000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c14000 b1c20000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c32000 b2431000 rw-p [stack:7149]
b2762000 b2769000 r-xp /usr/lib/libefl-extension.so.0.1.0
b277a000 b2782000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b2792000 b27a7000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b27b9000 b27bf000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27cf000 b27d7000 r-xp /opt/usr/apps/org.example.example/bin/example
b292f000 b2a12000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a49000 b2a71000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a83000 b3282000 rw-p [stack:7099]
b3282000 b3284000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3294000 b329e000 r-xp /lib/libnss_files-2.20-2014.11.so
b32af000 b32b8000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32c9000 b32da000 r-xp /lib/libnsl-2.20-2014.11.so
b32ed000 b32f3000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3304000 b3305000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b332d000 b3334000 r-xp /usr/lib/libminizip.so.1.0.0
b3344000 b3349000 r-xp /usr/lib/libstorage.so.0.1
b3359000 b33b8000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33ce000 b33e2000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33f2000 b3436000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3446000 b344e000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b345e000 b348e000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34a1000 b355a000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b356e000 b35c1000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35d2000 b35ed000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35fd000 b36be000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36d1000 b36e1000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36f1000 b36fe000 r-xp /usr/lib/libmdm-common.so.1.0.98
b370f000 b3716000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3726000 b3767000 r-xp /usr/lib/libmdm.so.1.2.12
b3777000 b377f000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b378e000 b379e000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37bf000 b381f000 r-xp /usr/lib/libasound.so.2.0.0
b3831000 b3834000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3844000 b3847000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3857000 b385c000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b386c000 b386d000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b387d000 b3888000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b389c000 b38a3000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38b3000 b38b9000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38c9000 b38ce000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38de000 b38f9000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3909000 b3910000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3920000 b3923000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3934000 b3962000 r-xp /usr/lib/libidn.so.11.5.44
b3972000 b3988000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3999000 b39a3000 r-xp /usr/lib/libcares.so.2.1.0
b39b3000 b39bd000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39cd000 b39cf000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39df000 b39e0000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39f0000 b39f4000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a05000 b3a2d000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a3e000 b3a67000 r-xp /usr/lib/libturbojpeg.so
b3a87000 b3a8d000 r-xp /usr/lib/libgif.so.4.1.6
b3a9d000 b3ae3000 r-xp /usr/lib/libcurl.so.4.3.0
b3af4000 b3b15000 r-xp /usr/lib/libexif.so.12.3.3
b3b30000 b3b45000 r-xp /usr/lib/libtts.so
b3b56000 b3b5e000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b6e000 b3c34000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c54000 b3d4c000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d6b000 b3e39000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e50000 b3e52000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e62000 b3e68000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e78000 b3e9b000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3eac000 b3eae000 r-xp /usr/lib/libappsvc.so.0.1.0
b3ebe000 b3ec0000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ed1000 b3ed6000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3eed000 b3eef000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3eff000 b3f06000 r-xp /usr/lib/libsensord-share.so
b3f16000 b3f2e000 r-xp /usr/lib/libsensor.so.1.1.0
b3f3f000 b3f42000 r-xp /usr/lib/libXv.so.1.0.0
b3f52000 b3f57000 r-xp /usr/lib/libutilX.so.1.1.0
b3f67000 b3f6c000 r-xp /usr/lib/libappcore-common.so.1.1
b3f7c000 b3f83000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f96000 b3f9a000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fab000 b4089000 r-xp /usr/lib/libCOREGL.so.4.0
b40a9000 b40ac000 r-xp /usr/lib/libuuid.so.1.3.0
b40bc000 b40d3000 r-xp /usr/lib/libblkid.so.1.1.0
b40e4000 b40e6000 r-xp /usr/lib/libXau.so.6.0.0
b40f6000 b413d000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b414f000 b4155000 r-xp /usr/lib/libjson-c.so.2.0.1
b4166000 b416a000 r-xp /usr/lib/libogg.so.0.7.1
b417a000 b419c000 r-xp /usr/lib/libvorbis.so.0.4.3
b41ac000 b4290000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42ac000 b42af000 r-xp /usr/lib/libEGL.so.1.4
b42c0000 b42c6000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42d6000 b42d8000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42e8000 b42f5000 r-xp /usr/lib/libGLESv2.so.2.0
b4306000 b4368000 r-xp /usr/lib/libpixman-1.so.0.28.2
b437d000 b4395000 r-xp /usr/lib/libmount.so.1.1.0
b43a7000 b43bb000 r-xp /usr/lib/libxcb.so.1.1.0
b43cb000 b43d2000 r-xp /lib/libcrypt-2.20-2014.11.so
b440a000 b440c000 r-xp /usr/lib/libiri.so
b441c000 b4427000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4438000 b446e000 r-xp /usr/lib/libpulse.so.0.16.2
b447f000 b44c2000 r-xp /usr/lib/libsndfile.so.1.0.25
b44d7000 b44ec000 r-xp /lib/libexpat.so.1.5.2
b44fe000 b45bc000 r-xp /usr/lib/libcairo.so.2.11200.14
b45d0000 b45d8000 r-xp /usr/lib/libdrm.so.2.4.0
b45e8000 b45eb000 r-xp /usr/lib/libdri2.so.0.0.0
b45fb000 b4649000 r-xp /usr/lib/libssl.so.1.0.0
b465e000 b466a000 r-xp /usr/lib/libeeze.so.1.13.0
b467b000 b4684000 r-xp /usr/lib/libethumb.so.1.13.0
b4694000 b4697000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46a7000 b485e000 r-xp /usr/lib/libcrypto.so.1.0.0
b5649000 b5652000 r-xp /usr/lib/libXi.so.6.1.0
b5662000 b5664000 r-xp /usr/lib/libXgesture.so.7.0.0
b5674000 b5678000 r-xp /usr/lib/libXtst.so.6.1.0
b5688000 b568e000 r-xp /usr/lib/libXrender.so.1.3.0
b569e000 b56a4000 r-xp /usr/lib/libXrandr.so.2.2.0
b56b4000 b56b6000 r-xp /usr/lib/libXinerama.so.1.0.0
b56c7000 b56ca000 r-xp /usr/lib/libXfixes.so.3.1.0
b56da000 b56e5000 r-xp /usr/lib/libXext.so.6.4.0
b56f5000 b56f7000 r-xp /usr/lib/libXdamage.so.1.1.0
b5707000 b5709000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5719000 b57fb000 r-xp /usr/lib/libX11.so.6.3.0
b580f000 b5816000 r-xp /usr/lib/libXcursor.so.1.0.2
b5826000 b583e000 r-xp /usr/lib/libudev.so.1.6.0
b5840000 b5843000 r-xp /lib/libattr.so.1.1.0
b5853000 b5873000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5874000 b5879000 r-xp /usr/lib/libffi.so.6.0.2
b588a000 b58a2000 r-xp /lib/libz.so.1.2.8
b58b2000 b58b4000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58c4000 b5999000 r-xp /usr/lib/libxml2.so.2.9.2
b59ae000 b5a49000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a65000 b5a68000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a78000 b5a91000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5aa2000 b5ab3000 r-xp /lib/libresolv-2.20-2014.11.so
b5ac7000 b5b41000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b56000 b5b58000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b68000 b5b6f000 r-xp /usr/lib/libembryo.so.1.13.0
b5b7f000 b5b89000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b9a000 b5bb2000 r-xp /usr/lib/libpng12.so.0.50.0
b5bc3000 b5be6000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c07000 b5c1b000 r-xp /usr/lib/libector.so.1.13.0
b5c2c000 b5c44000 r-xp /usr/lib/liblua-5.1.so
b5c55000 b5cac000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cc0000 b5ce8000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cf9000 b5d0c000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d1d000 b5d57000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d68000 b5d76000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d86000 b5d8e000 r-xp /usr/lib/libtbm.so.1.0.0
b5d9e000 b5dab000 r-xp /usr/lib/libeio.so.1.13.0
b5dbb000 b5dbd000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dcd000 b5dd2000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5de2000 b5df9000 r-xp /usr/lib/libefreet.so.1.13.0
b5e0b000 b5e2b000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e3b000 b5e5b000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e5d000 b5e63000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e73000 b5e84000 r-xp /usr/lib/libemotion.so.1.13.0
b5e95000 b5e9c000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5eac000 b5ebb000 r-xp /usr/lib/libeo.so.1.13.0
b5ecc000 b5ede000 r-xp /usr/lib/libecore_input.so.1.13.0
b5eef000 b5ef4000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f04000 b5f1d000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f2d000 b5f4a000 r-xp /usr/lib/libeet.so.1.13.0
b5f63000 b5fab000 r-xp /usr/lib/libeina.so.1.13.0
b5fbc000 b5fcc000 r-xp /usr/lib/libefl.so.1.13.0
b5fdd000 b60c2000 r-xp /usr/lib/libicuuc.so.51.1
b60df000 b621f000 r-xp /usr/lib/libicui18n.so.51.1
b6236000 b626e000 r-xp /usr/lib/libecore_x.so.1.13.0
b6280000 b6283000 r-xp /lib/libcap.so.2.21
b6293000 b62bc000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62cd000 b62d4000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62e6000 b631d000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b632e000 b6419000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b642c000 b64a5000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64b7000 b64bc000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64cc000 b64d6000 r-xp /usr/lib/libvconf.so.0.2.45
b64e6000 b64e8000 r-xp /usr/lib/libvasum.so.0.3.1
b64f8000 b64fa000 r-xp /usr/lib/libttrace.so.1.1
b650a000 b650d000 r-xp /usr/lib/libiniparser.so.0
b651d000 b6543000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6553000 b6558000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6569000 b6580000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6591000 b65fc000 r-xp /lib/libm-2.20-2014.11.so
b660d000 b6613000 r-xp /lib/librt-2.20-2014.11.so
b6624000 b6631000 r-xp /usr/lib/libunwind.so.8.0.1
b6667000 b678b000 r-xp /lib/libc-2.20-2014.11.so
b67a0000 b67b9000 r-xp /lib/libgcc_s-4.9.so.1
b67c9000 b68ab000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68bc000 b68e6000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68f7000 b6933000 r-xp /usr/lib/libsystemd.so.0.4.0
b6935000 b69b8000 r-xp /usr/lib/libedje.so.1.13.0
b69cb000 b69e9000 r-xp /usr/lib/libecore.so.1.13.0
b6a09000 b6b90000 r-xp /usr/lib/libevas.so.1.13.0
b6bc5000 b6bd9000 r-xp /lib/libpthread-2.20-2014.11.so
b6bed000 b6e21000 r-xp /usr/lib/libelementary.so.1.13.0
b6e50000 b6e54000 r-xp /usr/lib/libsmack.so.1.0.0
b6e64000 b6e6b000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e7b000 b6e7d000 r-xp /usr/lib/libdlog.so.0.0.0
b6e8d000 b6e90000 r-xp /usr/lib/libbundle.so.0.1.22
b6ea0000 b6ea2000 r-xp /lib/libdl-2.20-2014.11.so
b6eb3000 b6ecb000 r-xp /usr/lib/libaul.so.0.1.0
b6edf000 b6ee4000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ef5000 b6f02000 r-xp /usr/lib/liblptcp.so
b6f14000 b6f18000 r-xp /usr/lib/libsys-assert.so
b6f29000 b6f49000 r-xp /lib/ld-2.20-2014.11.so
b6f5a000 b6f5f000 r-xp /usr/bin/launchpad-loader
b7027000 b72cc000 rw-p [heap]
beed7000 beef8000 rw-p [stack]
beed7000 beef8000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7097)
Call Stack Count: 18
 0: setting_view_cb + 0x29 (0xb27d4e86) [/opt/usr/apps/org.example.example/bin/example] + 0x5e86
 1: (0xb6a3e175) [/usr/lib/libevas.so.1] + 0x35175
 2: (0xb5eb7219) [/usr/lib/libeo.so.1] + 0xb219
 3: eo_event_callback_call + 0x68 (0xb5eb5fb9) [/usr/lib/libeo.so.1] + 0x9fb9
 4: (0xb6a3e515) [/usr/lib/libevas.so.1] + 0x35515
 5: (0xb6a46725) [/usr/lib/libevas.so.1] + 0x3d725
 6: evas_canvas_event_feed_mouse_down + 0x6a (0xb6a4bf6b) [/usr/lib/libevas.so.1] + 0x42f6b
 7: evas_event_feed_mouse_down + 0x30 (0xb6a4f939) [/usr/lib/libevas.so.1] + 0x46939
 8: (0xb4696173) [/usr/lib/libecore_input_evas.so.1] + 0x2173
 9: (0xb69d6c4b) [/usr/lib/libecore.so.1] + 0xbc4b
10: (0xb69dca5d) [/usr/lib/libecore.so.1] + 0x11a5d
11: ecore_main_loop_begin + 0x3e (0xb69dcc83) [/usr/lib/libecore.so.1] + 0x11c83
12: appcore_efl_main + 0x20c (0xb6ee22bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
13: ui_app_main + 0xc0 (0xb3f98909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
14: main + 0x10e (0xb27d4673) [/opt/usr/apps/org.example.example/bin/example] + 0x5673
15: (0xb6f5bbb5) [/opt/usr/apps/org.example.example/bin/example] + 0x1bb5
16: __libc_start_main + 0x114 (0xb667d4bc) [/lib/libc.so.6] + 0x164bc
17: (0xb6f5beb4) [/opt/usr/apps/org.example.example/bin/example] + 0x1eb4
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
.021+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:18:21.021+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 7239
06-03 00:18:21.021+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7239
06-03 00:18:21.021+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:18:21.021+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 7239.
06-03 00:18:22.973+0900 W/LFE      (15849): [15849] 26:12:55.051[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:18:25.475+0900 W/LFE      (15849): [15849] 26:12:57.550[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:18:25.895+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-03 00:18:27.978+0900 W/LFE      (15849): [15849] 26:13:00.056[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:18:29.839+0900 E/VOLUME  (  858): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-03 00:18:29.839+0900 E/VOLUME  (  858): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-03 00:18:29.849+0900 E/GAME    ( 2577): .\..\src\TizenImpl.c: device_display_changed_cb(80) > device_display_changed_cb: state change to 2
06-03 00:18:29.849+0900 I/Internet(27388): main.cpp: __display_changed_cb(1445) > 3, 0x2, 0xbe8305a0
06-03 00:18:29.849+0900 I/Internet(27388): main.cpp: __display_changed_cb(1462) > DISPLAY_STATE_SCREEN state : [2]
06-03 00:18:29.849+0900 I/CAPI_NETWORK_CONNECTION(27388): connection.c: connection_get_type(463) > Connected Network = 0
06-03 00:18:29.849+0900 W/UI_GADGET(27388): manager.c: ugman_pause(1092) > [34mugman_pause failed: no root[0m
06-03 00:18:29.859+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(168) > [_dbus_message_recv_cb:168:W] PRE_LCD_OFF cause[timeout] (status:3)
06-03 00:18:29.859+0900 W/LOCKSCREEN(  845): event.c: _lcd_off_cb(64) > [_lcd_off_cb:64:W] Dbus LCD off:timeout
06-03 00:18:29.859+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30000:LCD_WILL_OFF
06-03 00:18:29.859+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:30000 event_info:2ae6f10
06-03 00:18:29.859+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:5
06-03 00:18:29.859+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => WILL PAUSE
06-03 00:18:29.859+0900 W/APP_CORE(  845): appcore-efl.c: __cmsg_cb(1038) > LCD Off. Pause the topmost app
06-03 00:18:29.859+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: PAUSE State: RUNNING
06-03 00:18:29.859+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:18:29.859+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:18:29.859+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 00:18:29.859+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
06-03 00:18:29.859+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
06-03 00:18:29.859+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 00:18:29.859+0900 E/LOCKSCREEN(  845): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-03 00:18:29.979+0900 E/LOCKSCREEN(  845): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
06-03 00:18:29.979+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 00:18:29.979+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:18:29.979+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 00:18:29.979+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 00:18:29.979+0900 I/Tizen::Net::Wifi( 1210): (941) > The background scan result updated.
06-03 00:18:30.230+0900 E/VOLUME  (  858): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-03 00:18:30.230+0900 E/VOLUME  (  858): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-03 00:18:30.230+0900 E/GAME    ( 2577): .\..\src\TizenImpl.c: device_display_changed_cb(80) > device_display_changed_cb: state change to 2
06-03 00:18:30.240+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(179) > [_dbus_message_recv_cb:179:W] POST_LCD_OFF status 4 visibility(1)
06-03 00:18:30.240+0900 W/LOCKSCREEN(  845): event.c: _lcd_off_completed_cb(48) > [_lcd_off_completed_cb:48:W] Vconf LCD off
06-03 00:18:30.240+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30002:LCD_OFF
06-03 00:18:30.240+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:30002 event_info:0
06-03 00:18:30.240+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:6
06-03 00:18:30.240+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL PAUSE => PAUSE
06-03 00:18:30.300+0900 I/Internet(27388): main.cpp: __display_changed_cb(1445) > 3, 0x2, 0xbe8305a0
06-03 00:18:30.300+0900 I/Internet(27388): main.cpp: __display_changed_cb(1462) > DISPLAY_STATE_SCREEN state : [2]
06-03 00:18:30.300+0900 I/CAPI_NETWORK_CONNECTION(27388): connection.c: connection_get_type(463) > Connected Network = 0
06-03 00:18:30.300+0900 W/UI_GADGET(27388): manager.c: ugman_pause(1092) > [34mugman_pause failed: no root[0m
06-03 00:18:30.470+0900 W/LFE      (15849): [15849] 26:13:02.547[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:18:32.962+0900 W/LFE      (15849): [15849] 26:13:05.045[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:18:34.864+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: MEM_FLUSH State: PAUSED
06-03 00:18:35.465+0900 W/LFE      (15849): [15849] 26:13:07.543[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:18:37.957+0900 W/LFE      (15849): [15849] 26:13:10.043[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:18:40.460+0900 W/LFE      (15849): [15849] 26:13:12.543[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:18:42.982+0900 W/LFE      (15849): [15849] 26:13:15.057[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:18:45.485+0900 W/LFE      (15849): [15849] 26:13:17.556[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:18:47.967+0900 W/LFE      (15849): [15849] 26:13:20.054[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:18:50.469+0900 W/LFE      (15849): [15849] 26:13:22.552[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:18:52.972+0900 W/LFE      (15849): [15849] 26:13:25.050[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:18:55.474+0900 W/LFE      (15849): [15849] 26:13:27.549[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:18:57.967+0900 W/LFE      (15849): [15849] 26:13:30.048[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:19:00.469+0900 W/LFE      (15849): [15849] 26:13:32.546[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:19:02.962+0900 W/LFE      (15849): [15849] 26:13:35.044[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:19:05.464+0900 W/LFE      (15849): [15849] 26:13:37.543[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:19:07.987+0900 W/LFE      (15849): [15849] 26:13:40.057[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:19:10.479+0900 W/LFE      (15849): [15849] 26:13:42.555[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:19:12.971+0900 W/LFE      (15849): [15849] 26:13:45.054[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:19:14.463+0900 W/BROWSER_PROVIDER(29519): browser-provider-requests-manager.c: bp_thread_requests_manager(892) > old client[BOOKMARK_CSC:1903049268] slot:3 sock:18
06-03 00:19:15.474+0900 W/LFE      (15849): [15849] 26:13:47.554[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:19:17.976+0900 W/LFE      (15849): [15849] 26:13:50.052[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:19:20.469+0900 W/LFE      (15849): [15849] 26:13:52.551[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:19:22.971+0900 W/LFE      (15849): [15849] 26:13:55.049[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:19:25.474+0900 W/LFE      (15849): [15849] 26:13:57.546[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:19:27.966+0900 W/LFE      (15849): [15849] 26:14:00.044[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:19:30.458+0900 W/LFE      (15849): [15849] 26:14:02.543[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:19:32.961+0900 W/LFE      (15849): [15849] 26:14:05.042[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:19:35.463+0900 W/LFE      (15849): [15849] 26:14:07.542[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:19:37.966+0900 W/LFE      (15849): [15849] 26:14:10.042[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:19:40.458+0900 W/LFE      (15849): [15849] 26:14:12.542[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:19:42.961+0900 W/LFE      (15849): [15849] 26:14:15.041[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:19:45.483+0900 W/LFE      (15849): [15849] 26:14:17.557[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:19:47.976+0900 W/LFE      (15849): [15849] 26:14:20.054[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:19:50.478+0900 W/LFE      (15849): [15849] 26:14:22.553[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:19:52.970+0900 W/LFE      (15849): [15849] 26:14:25.052[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:19:55.473+0900 W/LFE      (15849): [15849] 26:14:27.550[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:19:57.975+0900 W/LFE      (15849): [15849] 26:14:30.049[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:20:00.468+0900 W/LFE      (15849): [15849] 26:14:32.547[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:20:02.960+0900 W/LFE      (15849): [15849] 26:14:35.044[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:20:03.000+0900 W/LOCKSCREEN(  845): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 200 is changed to 78
06-03 00:20:03.000+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:40000:CONF_CHANGED
06-03 00:20:03.000+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:40000 event_info:200
06-03 00:20:03.000+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:200
06-03 00:20:03.010+0900 E/INDICATOR(  646): battery.c: indicator_battery_update_display(598) > indicator_battery_update_display[598]	 ""
06-03 00:20:05.463+0900 W/LFE      (15849): [15849] 26:14:37.544[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:20:07.965+0900 W/LFE      (15849): [15849] 26:14:40.042[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:20:10.457+0900 W/LFE      (15849): [15849] 26:14:42.542[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:20:12.980+0900 W/LFE      (15849): [15849] 26:14:45.055[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:20:14.521+0900 W/BROWSER_PROVIDER(29519): browser-provider-requests-manager.c: bp_thread_requests_manager(892) > old client[BOOKMARK_CSC:1903049268] slot:3 sock:18
06-03 00:20:15.472+0900 W/LFE      (15849): [15849] 26:14:47.553[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:20:17.975+0900 W/LFE      (15849): [15849] 26:14:50.052[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:20:20.477+0900 W/LFE      (15849): [15849] 26:14:52.550[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:20:22.970+0900 W/LFE      (15849): [15849] 26:14:55.049[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:20:25.472+0900 W/LFE      (15849): [15849] 26:14:57.547[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:20:27.975+0900 W/LFE      (15849): [15849] 26:15:00.046[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:20:30.457+0900 W/LFE      (15849): [15849] 26:15:02.545[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:20:32.959+0900 W/LFE      (15849): [15849] 26:15:05.043[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:20:35.482+0900 W/LFE      (15849): [15849] 26:15:07.557[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:20:37.974+0900 W/LFE      (15849): [15849] 26:15:10.055[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:20:40.477+0900 W/LFE      (15849): [15849] 26:15:12.555[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:20:42.969+0900 W/LFE      (15849): [15849] 26:15:15.054[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:20:45.472+0900 W/LFE      (15849): [15849] 26:15:17.551[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:20:47.974+0900 W/LFE      (15849): [15849] 26:15:20.050[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:20:50.477+0900 W/LFE      (15849): [15849] 26:15:22.549[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:20:52.969+0900 W/LFE      (15849): [15849] 26:15:25.047[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:20:53.259+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(143) > [_dbus_message_recv_cb:143:W] PRE_LCD_ON cause[powerkey] (status:1)
06-03 00:20:53.259+0900 W/LOCKSCREEN(  845): event.c: _lcd_on_cb(54) > [_lcd_on_cb:54:W] Dbus LCD on
06-03 00:20:53.259+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30001:LCD_ON
06-03 00:20:53.259+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:30001 event_info:0
06-03 00:20:53.259+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:3
06-03 00:20:53.259+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] PAUSE => WILL RESUME
06-03 00:20:53.259+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(195) > ""
06-03 00:20:53.259+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:20:53.269+0900 E/UXT     (  646): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 12:20
06-03 00:20:53.269+0900 I/INDICATOR(  646): clock.c: getTimeFormatted(176) > "time format : 오전 12:20"
06-03 00:20:53.269+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 12:20"
06-03 00:20:53.269+0900 W/INDICATOR(  646): clock.c: indicator_clock_changed_cb(272) > 
06-03 00:20:53.269+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145761993 Time: <font_size=31> </font_size> <font_size=31> 오전 12:20</font_size></font>"
06-03 00:20:53.269+0900 E/LOCKSCREEN(  845): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
06-03 00:20:53.269+0900 I/INDICATOR(  646): battery.c: show_battery_icon(376) > "Percentage:(0) / Level:(7) / batt_Full:(0) / battery_charging(1)"
06-03 00:20:53.269+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
06-03 00:20:53.269+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 00:20:53.269+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 00:20:53.269+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 00:20:53.269+0900 E/INDICATOR(  646): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-03 00:20:53.269+0900 E/INDICATOR(  646): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-03 00:20:53.479+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:4
06-03 00:20:53.479+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => RESUME
06-03 00:20:53.479+0900 W/APP_CORE(  845): appcore-efl.c: __cmsg_cb(1034) > LCD On. Resume the topmost app
06-03 00:20:53.479+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: RESUME State: PAUSED
06-03 00:20:53.479+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:20:53.479+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20004:APP_RESUME
06-03 00:20:53.479+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:20004 event_info:0
06-03 00:20:53.479+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-03 00:20:53.479+0900 E/LOCKSCREEN(  845): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-03 00:20:53.479+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
06-03 00:20:53.489+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
06-03 00:20:53.489+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 845
06-03 00:20:53.489+0900 I/AUL_AMD (  610): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
06-03 00:20:53.499+0900 W/AUL_AMD (  610): amd_launch.c: start_process(638) > child process: 7261
06-03 00:20:53.550+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:20:53.550+0900 W/AUL_AMD (  610): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 7261
06-03 00:20:53.550+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 7261, appid: com.samsung.weather-m-agent
06-03 00:20:53.560+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(425) > request cmd(0) result(7261)
06-03 00:20:53.610+0900 I/Tizen::App( 1210): (499) > LaunchedApp(com.samsung.weather-m-agent)
06-03 00:20:53.610+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 7261.
06-03 00:20:53.730+0900 E/weather-agent( 7261): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
06-03 00:20:53.730+0900 E/weather-common( 7261): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
06-03 00:20:53.730+0900 E/weather-agent( 7261): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
06-03 00:20:53.730+0900 E/weather-agent( 7261): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.deco-app, PortID : lockscreen-message-port[0;m
06-03 00:20:53.730+0900 E/weather-common( 7261): CityDBController.cpp: GetPrimaryKey(376) > [0;40;31mNo result : 101[0;m
06-03 00:20:53.730+0900 E/weather-common( 7261): CityDBController.cpp: Select(265) > [0;40;31mNo result : 101[0;m
06-03 00:20:53.730+0900 E/weather-common( 7261): DBController.cpp: SelectDataWithPrimaryKey(154) > [0;40;31m[SelectDataWithPrimaryKey(): 154] (!cityPtr) [return][0;m
06-03 00:20:53.730+0900 E/weather-common( 7261): WeatherInformationShareUtil.cpp: ShareDisplayCityWeatherInfo(289) > [0;40;31mthere is no city[0;m
06-03 00:20:53.730+0900 E/weather-common( 7261): WeatherInformationShareUtil.cpp: AddWeatherInfoToBundle(438) > [0;40;31m[AddWeatherInfoToBundle(): 438] (cityPtrVector->size() == 0) [return][0;m
06-03 00:20:53.730+0900 I/MESSAGE_PORT( 7261): message-port.c: __initialize(872) > initialize
06-03 00:20:53.740+0900 I/MESSAGE_PORT( 7261): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
06-03 00:20:53.770+0900 I/MESSAGE_PORT( 7261): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 00:20:53.770+0900 I/MESSAGE_PORT( 7261): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 00:20:53.770+0900 I/MESSAGE_PORT( 7261): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:20:53.770+0900 I/MESSAGE_PORT( 7261): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
06-03 00:20:53.770+0900 I/MESSAGE_PORT( 7261): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
06-03 00:20:53.770+0900 I/MESSAGE_PORT( 7261): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 00:20:53.770+0900 I/MESSAGE_PORT( 7261): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 00:20:53.770+0900 E/weather-common( 7261): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
06-03 00:20:53.770+0900 I/MESSAGE_PORT(  845): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 00:20:53.780+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:20:53.780+0900 I/MESSAGE_PORT( 7261): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 00:20:53.780+0900 I/MESSAGE_PORT( 7261): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 00:20:53.780+0900 I/MESSAGE_PORT( 7261): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:20:53.780+0900 I/MESSAGE_PORT( 7261): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.deco-app:lockscreen-message-port]
06-03 00:20:53.780+0900 I/MESSAGE_PORT( 7261): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.deco-app : com.samsung.weather-m-agent] 
06-03 00:20:53.780+0900 I/MESSAGE_PORT( 7261): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 00:20:53.780+0900 E/MESSAGE_PORT( 7261): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0
06-03 00:20:53.780+0900 E/weather-common( 7261): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(631) > [0;40;31mmessage_port_send_message failed [com.samsung.deco-app, lockscreen-message-port][0;m
06-03 00:20:53.780+0900 I/MESSAGE_PORT( 7261): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 00:20:53.780+0900 I/MESSAGE_PORT( 7261): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 00:20:53.780+0900 I/MESSAGE_PORT( 7261): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:20:53.780+0900 I/MESSAGE_PORT( 7261): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
06-03 00:20:53.780+0900 I/MESSAGE_PORT( 7261): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
06-03 00:20:53.780+0900 I/MESSAGE_PORT( 7261): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 00:20:53.780+0900 E/MESSAGE_PORT( 7261): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
06-03 00:20:53.780+0900 E/weather-common( 7261): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
06-03 00:20:53.780+0900 I/MESSAGE_PORT( 7261): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:20:53.780+0900 I/MESSAGE_PORT( 7261): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:20:53.780+0900 I/MESSAGE_PORT( 7261): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:20:53.780+0900 I/MESSAGE_PORT( 7261): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
06-03 00:20:53.780+0900 I/MESSAGE_PORT( 7261): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
06-03 00:20:53.780+0900 I/MESSAGE_PORT( 7261): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:20:53.780+0900 I/MESSAGE_PORT( 7261): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 00:20:53.780+0900 I/MESSAGE_PORT( 7261): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:20:53.780+0900 I/MESSAGE_PORT( 7261): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:20:53.780+0900 I/MESSAGE_PORT( 7261): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:20:53.780+0900 I/MESSAGE_PORT( 7261): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
06-03 00:20:53.780+0900 I/MESSAGE_PORT( 7261): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
06-03 00:20:53.780+0900 I/MESSAGE_PORT( 7261): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:20:53.790+0900 I/MESSAGE_PORT( 1360): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 00:20:53.790+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:20:53.790+0900 E/MESSAGE_PORT( 7261): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
06-03 00:20:53.790+0900 E/weather-common( 7261): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
06-03 00:20:53.790+0900 E/weather-common( 7261): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 1[0;m
06-03 00:20:53.790+0900 E/weather-common( 7261): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:20:53.790+0900 E/weather-common( 7261): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : [0;m
06-03 00:20:53.790+0900 E/weather-common( 7261): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:20:53.790+0900 E/weather-common( 7261): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : [0;m
06-03 00:20:53.790+0900 E/weather-common( 7261): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:20:53.790+0900 E/weather-common( 7261): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : [0;m
06-03 00:20:53.790+0900 E/weather-common( 7261): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:20:53.790+0900 E/weather-common( 7261): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : [0;m
06-03 00:20:53.790+0900 E/weather-common( 7261): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:20:53.790+0900 E/weather-common( 7261): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : [0;m
06-03 00:20:53.790+0900 E/weather-common( 7261): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:20:53.790+0900 E/weather-common( 7261): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : [0;m
06-03 00:20:53.790+0900 E/weather-common( 7261): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:20:53.790+0900 E/weather-common( 7261): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : [0;m
06-03 00:20:53.790+0900 E/weather-common( 7261): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
06-03 00:20:53.790+0900 E/weather-common( 7261): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
06-03 00:20:53.790+0900 E/weather-agent( 7261): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
06-03 00:20:53.790+0900 E/weather-agent( 7261): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
06-03 00:20:53.790+0900 I/MESSAGE_PORT( 7261): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 00:20:53.790+0900 I/MESSAGE_PORT( 7261): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 00:20:53.810+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:20:53.850+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:20:53.850+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:20:53.850+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:20:53.850+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:20:53.850+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:20:53.860+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:20:53.870+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_update_cb(287) > received updating signal
06-03 00:20:53.940+0900 I/Tizen::System( 1210): (280) > The screen has been turned on.
06-03 00:20:53.940+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:20:53.940+0900 E/GAME    ( 2577): .\..\src\TizenImpl.c: device_display_changed_cb(80) > device_display_changed_cb: state change to 0
06-03 00:20:53.950+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127433930
06-03 00:20:53.950+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:20:53.950+0900 I/Internet(27388): main.cpp: __display_changed_cb(1445) > 3, (nil), 0xbe8305a0
06-03 00:20:53.950+0900 I/Internet(27388): main.cpp: __display_changed_cb(1462) > DISPLAY_STATE_SCREEN state : [0]
06-03 00:20:53.950+0900 I/Internet(27388): main.cpp: __display_changed_cb(1474) > paused
06-03 00:20:53.970+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:20:53.970+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:20:53.970+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
06-03 00:20:54.040+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127434047
06-03 00:20:54.050+0900 E/LOCKSCREEN(  845): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-03 00:20:54.050+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80001:VIEW_GESTURED
06-03 00:20:54.050+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80001 event_info:0
06-03 00:20:54.050+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 00:20:54.050+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
06-03 00:20:54.050+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
06-03 00:20:54.050+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
06-03 00:20:54.050+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:4:LKD_EVT_WILL_UNLOCK
06-03 00:20:54.050+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:4 event_info:0
06-03 00:20:54.050+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event_delay(1041) > [lockd_event_delay:1041:W] dealyed event:2:UNLOCK wait for:0.330000
06-03 00:20:54.050+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 00:20:54.380+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
06-03 00:20:54.380+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
06-03 00:20:54.380+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
06-03 00:20:54.380+0900 E/LOCKSCREEN(  845): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
06-03 00:20:54.380+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 00:20:54.380+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:20:54.380+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 00:20:54.380+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 00:20:54.380+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-03 00:20:54.390+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:20:54.400+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:20:54.410+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(845) status(4)
06-03 00:20:54.410+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(845)
06-03 00:20:54.410+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 845, appid: com.samsung.lockscreen, status: bg
06-03 00:20:54.410+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7097) status(3)
06-03 00:20:54.410+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:20:54.410+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:20:54.410+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(7097)
06-03 00:20:54.410+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 7097, appid: org.example.example, status: fg
06-03 00:20:54.430+0900 W/LOCKSCREEN(  845): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [invisible]
06-03 00:20:54.430+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
06-03 00:20:54.430+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
06-03 00:20:54.430+0900 E/LOCKSCREEN(  845): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
06-03 00:20:54.430+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: PAUSE State: RUNNING
06-03 00:20:54.430+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:20:54.430+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:20:54.430+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 00:20:54.430+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
06-03 00:20:54.430+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
06-03 00:20:54.430+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 00:20:54.430+0900 E/LOCKSCREEN(  845): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-03 00:20:54.440+0900 I/APP_CORE( 7097): appcore-efl.c: __do_app(514) > [APP 7097] Event: RESUME State: PAUSED
06-03 00:20:54.440+0900 I/CAPI_APPFW_APPLICATION( 7097): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:20:54.440+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: MEM_FLUSH State: PAUSED
06-03 00:20:54.450+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:20:54.450+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:20:54.450+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:20:54.460+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:20:54.530+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
06-03 00:20:54.530+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 00:20:54.530+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:20:54.530+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 00:20:54.530+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 00:20:54.541+0900 E/LOCKSCREEN(  845): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
06-03 00:20:54.561+0900 E/EFL     ( 7097): ecore_x<7097> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127434560
06-03 00:20:54.711+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 7097 pgid = 7097
06-03 00:20:54.711+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(143) > dead_pid(7097)
06-03 00:20:54.721+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:20:54.731+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 00:20:54.731+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:20:54.731+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:20:54.731+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 00:20:54.731+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 00:20:54.761+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 00:20:54.761+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 00:20:54.761+0900 E/AUL_PAD ( 1359): launchpad.c: main(698) > error reading sigchld info
06-03 00:20:54.761+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[7097] terminate event is forwarded
06-03 00:20:54.761+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:20:54.761+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 7097, ]
06-03 00:20:54.761+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:20:54.761+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 00:20:54.761+0900 I/Tizen::App( 1210): (512) > Not registered pid(7097)
06-03 00:20:54.761+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 00:20:54.761+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:20:54.771+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 7097
06-03 00:20:54.771+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7097
06-03 00:20:54.771+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 7097
06-03 00:20:54.771+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3214
06-03 00:20:54.791+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 00:20:54.791+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 00:20:54.791+0900 E/weather-agent( 7261): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
06-03 00:20:54.791+0900 I/CAPI_APPFW_APPLICATION( 7261): service_app_main.c: service_app_exit(446) > service_app_exit
06-03 00:20:54.791+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:20:54.791+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 7097.
06-03 00:20:54.801+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
06-03 00:20:54.801+0900 E/weather-agent( 7261): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
06-03 00:20:54.801+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
06-03 00:20:54.811+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 00:20:54.811+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:20:54.811+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 00:20:54.811+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:20:54.821+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 00:20:54.831+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:20:54.841+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:20:54.841+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:20:54.841+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:20:54.841+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:20:54.841+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:20:54.851+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 00:20:54.851+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:20:54.871+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:20:54.881+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:20:54.881+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 00:20:54.881+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 00:20:54.881+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 00:20:54.881+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 00:20:54.901+0900 W/CRASH_MANAGER( 7269): worker.c: worker_job(1199) > 1107097657861149641685
