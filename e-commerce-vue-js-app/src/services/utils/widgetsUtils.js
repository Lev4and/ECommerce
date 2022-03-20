import { find as _find, filter as _filter, map as _map } from 'lodash'

export const getWidget = (widgets, key) => {
  if (widgets && key) {
    const properties = _filter(Object.keys(widgets), (property) => property.toLowerCase().includes(key.toLowerCase() + '-'))
    if (properties.length > 0) {
      const property = _find(properties, (property) => widgets[property])
      if (property) return JSON.parse(widgets[property])
    }
  }
  return null
}

export const getWidgets = (widgets, key) => {
  if (widgets && key) {
    const properties = _filter(Object.keys(widgets), (property) => property.toLowerCase().includes(key.toLowerCase() + '-'))
    if (properties.length > 0) {
      return _map(_filter(properties, (property) => widgets[property]), (property) =>
        JSON.parse(widgets[property]))
    }
  }
  return []
}
