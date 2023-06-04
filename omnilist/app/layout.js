import './globals.css'
import { Open_Sans } from 'next/font/google'
import Header from './components/header'

const opensans = Open_Sans({ subsets: ['latin'] })

export const metadata = {
  title: 'Omnilist',
  description: 'Omnilist',
}

export default function RootLayout({ children }) {
  return (
    <html lang="en">
      <body className={opensans.className}>
        <Header/>
        {children}</body>
    </html>
  )
}
