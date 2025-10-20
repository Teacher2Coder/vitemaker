import { useEffect } from 'react';
import { useLocation } from 'react-router-dom';

export default function usePageSEO(seoData) {
  const location = useLocation();

  useEffect(() => {
    if (seoData.title) {
      document.title = seoData.title;
    }

    const updateMeta = (selector, attribute, value) => {
      const element = document.querySelector(selector);
      if (element && value) {
        element.setAttribute(attribute, value);
      }
    };

    updateMeta('meta[name="description"]', 'content', seoData.description);
    updateMeta('meta[property="og:title"]', 'content', seoData.ogTitle);
    updateMeta('meta[property="og:description"]', 'content', seoData.ogDescription);
    updateMeta('meta[name="twitter:title"]', 'content', seoData.twitterTitle);
    updateMeta('meta[name="twitter:description"]', 'content', seoData.twitterDescription);
  }, [seoData, location.pathname]);
}
