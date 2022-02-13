import { find as _find, forEach as _forEach } from 'lodash'

export const getWidget = (widgets, key) => {
  if(widgets && key) {
    const property = _find(Object.keys(widgets), property => property.toLowerCase().includes(key.toLowerCase()))
    if(property) {
      return JSON.parse(widgets[property])
    }
  }
  return null
}
