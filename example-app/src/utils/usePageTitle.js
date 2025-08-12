import { useEffect } from 'react'
import { useLocation } from 'react-router-dom'

export default function usePageSEO(seoData) {
  const location = useLocation()
  useEffect(() => {
    if (seoData.title) {
      document.title = seoData.title
    }
    if (seoData.description) {
      document.querySelector('meta[name="description"]').setAttribute('content', seoData.description)
    }
    if (seoData.ogTitle) {
      document.querySelector('meta[property="og:title"]').setAttribute('content', seoData.ogTitle)
    }
    if (seoData.ogDescription) {
      document.querySelector('meta[property="og:description"]').setAttribute('content', seoData.ogDescription)
    }
    if (seoData.twitterTitle) {
      document.querySelector('meta[name="twitter:title"]').setAttribute('content', seoData.twitterTitle)
    }
    if (seoData.twitterDescription) {
      document.querySelector('meta[name="twitter:description"]').setAttribute('content', seoData.twitterDescription)
    }
  }, [seoData, location.pathname])
}
