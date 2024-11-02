import '../styles/globals.css'
import { useEffect } from 'react'
import { useRouter } from 'next/router'
import Layout from '../components/Layout'

function MyApp({ Component, pageProps }) {
  const router = useRouter()

  useEffect(() => {
    if (router.pathname === '/') {
      router.push('/login')
    }
  }, [router])

  return (
    <Layout>
      <Component {...pageProps} />
    </Layout>
  )
}

export default MyApp
