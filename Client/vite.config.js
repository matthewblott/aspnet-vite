import { defineConfig } from 'vite'
import { svelte } from '@sveltejs/vite-plugin-svelte'

export default defineConfig({
  plugins: [svelte()],
  server: {
    port: 5173
  },
  build: {
    outDir: "../wwwroot/client"
  },
  base: "/",
  emptyOutDir: true,
})