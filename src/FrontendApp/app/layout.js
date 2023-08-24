import './globals.css'
import { Roboto_Mono } from 'next/font/google'
import Header from './components/Header'

const roboto_mono = Roboto_Mono({ subsets: ['latin'] })

export const metadata = {
  title: 'Omnilist',
  description: 'Omnilist',
}

export default function RootLayout({ children }) {
  return (
    <html lang="en">
      <body className={roboto_mono.className}>
        <Header/>
        {children}</body>
    </html>
  )
}
